using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DTCMS.Common
{
    //正则
    public class Regular
    {
        /// <summary>
        /// 正则表达式验证
        /// </summary>
        /// <param name="regValue">验证字符串</param>
        /// <param name="reg">正式表达式</param>
        /// <returns>符合true，不符合false</returns>
        public static bool ValidateReg(string regValue, string reg)
        {
            Regex iRegex = new Regex(reg, RegexOptions.Compiled);
            return iRegex.Match(regValue).Success;
        }

        /// <summary>
        /// URL验证
        /// </summary>
        public static string URL
        {
            get { return @"([\w-]+\.)+[\w-]+.([^a-z])(/[\w- ./?%&=]*)?|[a-zA-Z0-9\-\.][\w-]+.([^a-z])(/[\w- ./?%&=]*)? "; }
        }
    }
}
