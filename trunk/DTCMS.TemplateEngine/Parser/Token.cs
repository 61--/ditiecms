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

namespace Ader.TemplateEngine.Parser
{
	public enum TokenKind
	{
		EOF,
		Comment,
		// common tokens
		ID,				// (alpha)+

		// text specific tokens
		TextData,

		// tag tokens
		TagStart,		// <ad: 
		TagEnd,			// > 
		TagEndClose,	// />
		TagClose,		// </ad:
		TagEquals,		// =


		// expression
		ExpStart,		// # at the beginning
		ExpEnd,			// # at the end
		LParen,			// (
		RParen,			// )
		Dot,			// .
		Comma,			// ,
		Integer,		// integer number
		Double,			// double number
		LBracket,		// [
		RBracket,		// ]

		// operators
        OpOr,           // "or" keyword
        OpAnd,          // "and" keyword
		OpIs,			// "is" keyword
		OpIsNot,		// "isnot" keyword
		OpLt,			// "lt" keyword
		OpGt,			// "gt" keyword
		OpLte,			// "lte" keyword
		OpGte,			// "gte" keyword

		// string tokens
		StringStart,	// "
		StringEnd,		// "
		StringText		// text within the string
	}

	public class Token
	{
		private int _Line;
		private int _Col;
		private string _Data;
		private TokenKind _TokenKind;

		public Token(TokenKind kind, string data, int line, int col)
		{
			_TokenKind = kind;
			_Line = line;
			_Col = col;
			_Data = data;
		}

		public int Col
		{
			get { return _Col; }
		}

		public string Data
		{
			get { return _Data; }
			set { _Data = value; }
		}

		public int Line
		{
			get { return _Line; }
		}

		public TokenKind TokenKind
		{
			get { return _TokenKind; }
			set { _TokenKind = value; }
		}

	}
}
