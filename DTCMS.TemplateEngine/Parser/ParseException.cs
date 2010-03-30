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
	public class ParseException : Exception
	{
        private int _Line;
        private int _Col;
		
		public ParseException(string msg, int line, int col)
			:base(msg)
		{
            this._Line = line;
            this._Col = col;

		}

		public int Col
		{
            get { return this._Col; }
		}

		public int Line
		{
            get { return this._Line; }
		}
	}
}
