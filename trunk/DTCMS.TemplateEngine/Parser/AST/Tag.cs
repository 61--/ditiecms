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


	public class Tag : Element
	{
        private string _Name;
        private List<TagAttribute> _Attribs;
        private List<Element> _InnerElements;
        private TagClose _CloseTag;
        private bool _IsClosed;	// set to true if tag ends with />

        public Tag(int line, int col, string name)
            : base(line, col)
        {
            _Name = name;
            _Attribs = new List<TagAttribute>();
            _InnerElements = new List<Element>();
        }

		public List<TagAttribute> Attributes
		{
            get { return this._Attribs; }
		}

        public Expression AttributeValue(string name)
        {
            foreach (TagAttribute attrib in _Attribs)
                if (string.Compare(attrib.Name, name, true) == 0)
                    return attrib.Expression;

            return null;
        }

        public List<Element> InnerElements
        {
            get { return _InnerElements; }
        }

        public string Name
        {
            get { return _Name; }
        }

        public TagClose CloseTag
        {
            get { return _CloseTag; }
            set { _CloseTag = value; }
        }

        public bool IsClosed
        {
            get { return _IsClosed; }
            set { _IsClosed = value; }
        }
	}
}
