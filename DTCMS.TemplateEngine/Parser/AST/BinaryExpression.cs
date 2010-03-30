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

namespace Ader.TemplateEngine.Parser.AST
{
    public class BinaryExpression : Expression
    {
        private Expression _Lhs;
        private Expression _Rhs;
        private TokenKind _op;

		public BinaryExpression(int line, int col, Expression lhs, TokenKind op, Expression rhs)
			: base(line, col)
		{
			_Lhs = lhs;
			_Rhs = rhs;
			_op = op;
		}

		public Expression Lhs
		{
			get { return _Lhs; }
		}

		public Expression Rhs
		{
			get { return _Rhs; }
		}

		public TokenKind Operator
		{
			get { return _op; }
		}
    }
}
