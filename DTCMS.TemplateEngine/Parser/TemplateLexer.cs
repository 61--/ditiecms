/*****************************************************
 * AderTemplates
 * (C) Andrew Deren 2004
 * http://www.adersoftware.com
 *
 *	This file is part of AderTemplate
 * AderTemplate is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * AderTemplate is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with AderTemplate; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 *****************************************************/

#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion
using System.IO;

namespace Ader.TemplateEngine.Parser
{
    public class TemplateLexer
    {
        private const char _EOF = (char)0;

        private LexMode _CurrentMode;
        private Stack<LexMode> _Modes;

        private int _Line;
        private int _Column;
        private int _Pos;	// _Position within _Data

        private string _Data;

        private int _SaveLine;
        private int _SaveCol;
        private int _SavePos;

        private static Dictionary<string, TokenKind> keywords;

        static TemplateLexer()
        {
            keywords = new Dictionary<string, TokenKind>(StringComparer.InvariantCultureIgnoreCase);
            keywords["or"] = TokenKind.OpOr;
            keywords["and"] = TokenKind.OpAnd;
            keywords["is"] = TokenKind.OpIs;
            keywords["isnot"] = TokenKind.OpIsNot;
            keywords["lt"] = TokenKind.OpLt;
            keywords["gt"] = TokenKind.OpGt;
            keywords["lte"] = TokenKind.OpLte;
            keywords["gte"] = TokenKind.OpGte;
        }

        private enum LexMode
        {
            Text,
            Tag,
            Expression,
            String
        }

        public TemplateLexer(TextReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException("reader");

            _Data = reader.ReadToEnd();

            Reset();
        }

        public TemplateLexer(string _Data)
        {
            if (_Data == null)
                throw new ArgumentNullException("_Data");

            this._Data = _Data;

            Reset();
        }

        private void EnterMode(LexMode mode)
        {
            _Modes.Push(_CurrentMode);
            _CurrentMode = mode;
        }

        private void LeaveMode()
        {
            _CurrentMode = _Modes.Pop();
        }

        private void Reset()
        {
            _Modes = new Stack<LexMode>();
            _CurrentMode = LexMode.Text;
            _Modes.Push(_CurrentMode);

            _Line = 1;
            _Column = 1;
            _Pos = 0;
        }

        protected char LA(int count)
        {
            if (_Pos + count >= _Data.Length)
                return _EOF;
            else
                return _Data[_Pos + count];
        }

        protected char Consume()
        {
            char ret = _Data[_Pos];
            _Pos++;
            _Column++;

            return ret;
        }

        protected char Consume(int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException("count", "count has to be greater than 0");

            char ret = ' ';
            while (count > 0)
            {
                ret = Consume();
                count--;
            }
            return ret;
        }

        void NewLine()
        {
            _Line++;
            _Column = 1;
        }

        protected Token CreateToken(TokenKind kind, string value)
        {
            return new Token(kind, value, _Line, _Column);
        }

        protected Token CreateToken(TokenKind kind)
        {
            string tokenData = _Data.Substring(_SavePos, _Pos - _SavePos);
            if (kind == TokenKind.StringText)
                tokenData = tokenData.Replace("\"\"", "\""); // replace double "" with single "
            //if (kind == TokenKind.StringText || kind == TokenKind.TextData)
            //    tokenData = tokenData.Replace("##", "#");	// replace ## with #

            return new Token(kind, tokenData, _SaveLine, _SaveCol);
        }

        /// <summary>
        /// reads all whitespace characters (does not include new_Line)
        /// </summary>
        /// <returns></returns>
        protected void ReadWhitespace()
        {
            while (true)
            {
                char ch = LA(0);
                switch (ch)
                {
                    case ' ':
                    case '\t':
                        Consume();
                        break;
                    case '\n':
                        Consume();
                        NewLine();
                        break;

                    case '\r':
                        Consume();
                        if (LA(0) == '\n')
                            Consume();
                        NewLine();
                        break;
                    default:
                        return;
                }
            }
        }

        /// <summary>
        /// save read point _Positions so that CreateToken can use those
        /// </summary>
        private void StartRead()
        {
            _SaveLine = _Line;
            _SaveCol = _Column;
            _SavePos = _Pos;
        }

        public Token Next()
        {
            switch (_CurrentMode)
            {
                case LexMode.Text: return NextText();
                case LexMode.Expression: return NextExpression();
                case LexMode.Tag: return NextTag();
                case LexMode.String: return NextString();
                default: throw new ParseException("遇到无效的语法：" + _CurrentMode.ToString(), _Line, _Column);
            }
        }

        private Token NextExpression()
        {
            StartRead();
            char ch = LA(0);
            switch (ch)
            {
                case _EOF:
                    return CreateToken(TokenKind.EOF);
                case ',':
                    Consume();
                    return CreateToken(TokenKind.Comma);
                case '.':
                    Consume();
                    return CreateToken(TokenKind.Dot);
                case '(':
                    Consume();
                    return CreateToken(TokenKind.LParen);
                case ')':
                    Consume();
                    return CreateToken(TokenKind.RParen);
                case ']':
                    Consume();
                    LeaveMode();
                    return CreateToken(TokenKind.ExpEnd);
                case '<':
                    Consume();
                    return CreateToken(TokenKind.LBracket);
                case '>':
                    Consume();
                    return CreateToken(TokenKind.RBracket);
                case ' ':
                case '\t':
                case '\r':
                case '\n':
                    ReadWhitespace();
                    return NextExpression();

                case '"':
                case '\'':
                    Consume();
                    EnterMode(LexMode.String);
                    return CreateToken(TokenKind.StringStart);

                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return ReadNumber();

                case '-':
                    {
                        if (Char.IsDigit(LA(1)))
                            return ReadNumber();

                        goto default;
                    }

                default:
                    if (Char.IsLetter(ch) || ch == '_')
                        return ReadId();
                    else
                        throw new ParseException("Expression 中包含无效的字符:" + ch, _Line, _Column);

            }
        }

        private Token NextTag()
        {
            StartRead();
        StartTagRead:
            char ch = LA(0);
            switch (ch)
            {
                case _EOF:
                    return CreateToken(TokenKind.EOF);
                case '=':
                    Consume();
                    return CreateToken(TokenKind.TagEquals);
                case '"':
                case '\'':
                    Consume();
                    EnterMode(LexMode.String);
                    return CreateToken(TokenKind.StringStart);
                case ' ':
                case '\t':
                case '\r':
                case '\n':
                    ReadWhitespace();	// ignore whitespace
                    StartRead();		// remark current _Position
                    goto StartTagRead;	// start again
                case '}':
                    Consume();
                    LeaveMode();
                    return CreateToken(TokenKind.TagEnd);
                case '/':
                    if (LA(1) == '}')
                    {
                        Consume(2); // consume />
                        LeaveMode();
                        return CreateToken(TokenKind.TagEndClose);
                    }
                    break;
                default:
                    if (Char.IsLetter(ch) || ch == '_')
                        return ReadId();
                    break;

            }
            throw new ParseException("Tag 中包含无效的字符: " + ch, _Line, _Column);
        }

        private Token NextString()
        {
            StartRead();
        StartStringRead:
            char ch = LA(0);
            switch (ch)
            {
                case _EOF:
                    return CreateToken(TokenKind.EOF);

                case '[':
                    char ch1 = LA(1);

                    if (ch1 == '#')
                    {
                        if (_SavePos == _Pos)
                        {
                            Consume(2);
                            EnterMode(LexMode.Expression);
                            return CreateToken(TokenKind.ExpStart);
                        }
                        else
                            break;
                    }
                    Consume();
                    goto StartStringRead;

                case '\r':
                case '\n':
                    ReadWhitespace();
                    goto StartStringRead;
                case '"':
                case '\'':
                    if (LA(1) == '"' || LA(1) == '\'')
                    {
                        // just escape
                        Consume(2);
                        goto StartStringRead;
                    }
                    else if (_Pos == _SavePos)
                    {
                        Consume();
                        LeaveMode();
                        return CreateToken(TokenKind.StringEnd);
                    }
                    else
                        break; // just break so that text is returned
                default:
                    Consume();
                    goto StartStringRead;

            }

            return CreateToken(TokenKind.StringText);
        }

        private Token NextText()
        {
            StartRead();

        StartTextRead:
            switch (LA(0))
            {
                case _EOF:
                    if (_SavePos == _Pos)
                        return CreateToken(TokenKind.EOF);
                    else
                        break;

                case '[':
                    char ch1 = LA(1);
                    string s = String.Format("{0},{1}", _SavePos, _Pos);

                    if (ch1 == '$')
                    {
                        if (_SavePos == _Pos)
                        {
                            Consume(2);
                            EnterMode(LexMode.Expression);
                            return CreateToken(TokenKind.ExpStart);
                        }
                        else
                            break;
                    }

                    Consume();
                    goto StartTextRead;

                case '{':
                    if ((LA(1) == 'd' || LA(1) == 'D') && (LA(2) == 't' || LA(2) == 'T') && LA(3) == ':')
                    {
                        if (_SavePos == _Pos)
                        {
                            Consume(4);
                            EnterMode(LexMode.Tag);
                            return CreateToken(TokenKind.TagStart);
                        }
                        else
                            break;
                    }
                    else if (LA(1) == '/' && (LA(2) == 'd' || LA(2) == 'D') && (LA(3) == 't' || LA(3) == 'T') && LA(4) == ':')
                    {
                        if (_SavePos == _Pos)
                        {
                            Consume(5);
                            EnterMode(LexMode.Tag);
                            return CreateToken(TokenKind.TagClose);
                        }
                        else
                            break;
                    }
                    Consume();
                    goto StartTextRead;

                case '\n':
                case '\r':
                    ReadWhitespace();	// handle new_Lines specially so that _Line number count is kept
                    goto StartTextRead;

                default:
                    Consume();
                    goto StartTextRead;
            }

            return CreateToken(TokenKind.TextData);
        }

        /// <summary>
        /// reads word. Word contains any alpha character or _
        /// </summary>
        protected Token ReadId()
        {
            StartRead();

            Consume(); // consume first character of the word

            while (true)
            {
                char ch = LA(0);
                if (Char.IsLetterOrDigit(ch) || ch == '_')
                    Consume();
                else
                    break;
            }

            string tokenData = _Data.Substring(_SavePos, _Pos - _SavePos);

            if (keywords.ContainsKey(tokenData))
                return CreateToken(keywords[tokenData]);
            else
                return CreateToken(TokenKind.ID, tokenData);
        }

        /// <summary>
        /// returns either Integer or Double Token
        /// </summary>
        /// <returns></returns>
        protected Token ReadNumber()
        {
            StartRead();
            Consume(); // consume first digit or -

            bool hasDot = false;

            while (true)
            {
                char ch = LA(0);
                if (Char.IsNumber(ch))
                    Consume();

                // if "." and didn't see "." yet, and next char
                // is number, than starting to read decimal number
                else if (ch == '.' && !hasDot && Char.IsNumber(LA(1)))
                {
                    Consume();
                    hasDot = true;
                }
                else
                    break;
            }
            return CreateToken(hasDot ? TokenKind.Double : TokenKind.Integer);
        }

    }
}
