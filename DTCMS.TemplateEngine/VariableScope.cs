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

namespace Ader.TemplateEngine
{
	public class VariableScope
	{
        private VariableScope _Parent;
        private Dictionary<string, object> _Values;

		public VariableScope()
			:this(null)
		{
		}

		public VariableScope(VariableScope parent)
		{
			this._Parent = parent;
			this._Values = new Dictionary<string, object>(StringComparer.InvariantCultureIgnoreCase);
		}

		/// <summary>
		/// clear all variables from this scope
		/// </summary>
		public void Clear()
		{
			_Values.Clear();
		}

		/// <summary>
		/// gets the parent scope for this scope
		/// </summary>
		public VariableScope Parent
		{
			get { return _Parent; }
		}

		/// <summary>
		/// returns true if variable name is defined
		/// otherwise returns parents isDefined if parent != null
		/// </summary>
		public bool IsDefined(string name)
		{
			if (_Values.ContainsKey(name))
				return true;
			else if (_Parent != null)
				return _Parent.IsDefined(name);
			else
				return false;
		}

		/// <summary>
		/// returns value of variable name
		/// If name is not in this scope and parent != null
		/// parents this[name] is called
		/// </summary>
		public object this[string name]
		{
			get {
				if (!_Values.ContainsKey(name))
				{
					if (_Parent != null)
						return _Parent[name];
					else
						return null;
				}
				else
					return _Values[name];
			}
			set { _Values[name] = value; }
		}
	}
}
