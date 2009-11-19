using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DTCMS.Common
{
    //正则
    public class Regular
    {
        private static string regNum = @"^([-]|[0-9])[0-9]*(\.\w*)?$";

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
        /// 验证是否是整数
        /// </summary>
        /// <param name="regValue">验证的字符串</param>
        /// <returns></returns>
        public static bool ValidateNum(string regValue)
        {
            return ValidateReg(regValue,regNum); 
        }
    }
}
