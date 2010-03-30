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
using System.Text.RegularExpressions;

#endregion

namespace Ader.TemplateEngine
{
	public static class Util
	{
		static object syncObject = new object();

		static Regex regExVarName;

		public static bool ToBool(object obj)
		{
			if (obj is bool)
				return (bool)obj;
			else if (obj is string)
			{
				string str = (string)obj;
				if (string.Compare(str, "true", true) == 0)
					return true;
				else if (string.Compare(str, "yes", true) == 0)
					return true;
				else
					return false;
			}
			else
				return false;
		}

		public static bool IsValidVariableName(string name)
		{
			return RegExVarName.IsMatch(name);
		}

		private static Regex RegExVarName
		{
			get
			{
				if ((regExVarName == null))
				{
					System.Threading.Monitor.Enter(syncObject);
					if (regExVarName == null)
					{
						try
						{
							regExVarName = new Regex("^[a-zA-Z_][a-zA-Z0-9_]*$", RegexOptions.Compiled);
						}
						finally
						{
							System.Threading.Monitor.Exit(syncObject);
						}
					}
				}

				return regExVarName;
			}
		}
	}
}
