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
        /// 判断对象是否为Int32类型的数字
        /// </summary>
        /// <param name="Expression"></param>
        /// <returns></returns>
        public static bool ValidateNum(object expression)
        {
            if (expression != null)
                return ValidateNum(expression.ToString());

            return false;

        }

        /// <summary>
        /// 判断对象是否为Int32类型的数字
        /// </summary>
        /// <param name="Expression"></param>
        /// <returns></returns>
        public static bool ValidateNum(string expression)
        {
            if (expression != null)
            {
                string str = expression;
                if (str.Length > 0 && str.Length <= 11 && Regex.IsMatch(str, @"^[-]?[0-9]*[.]?[0-9]*$"))
                {
                    if ((str.Length < 10) || (str.Length == 10 && str[0] == '1') || (str.Length == 11 && str[0] == '-' && str[1] == '1'))
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 是否为Double类型
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static bool ValidateDouble(object expression)
        {
            if (expression != null)
                return Regex.IsMatch(expression.ToString(), @"^([0-9])[0-9]*(\.\w*)?$");

            return false;
        }

        /// <summary>
        /// 判断给定的字符串数组(strNumber)中的数据是不是都为数值型
        /// </summary>
        /// <param name="strNumber">要确认的字符串数组</param>
        /// <returns>是则返加true 不是则返回 false</returns>
        public static bool ValidateNumericArray(string[] strNumber)
        {
            if (strNumber == null)
                return false;

            if (strNumber.Length < 1)
                return false;

            foreach (string id in strNumber)
            {
                if (!ValidateNum(id))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 验证SQL条件是否安全，抛出异常：语句存在危险字符
        /// </summary>
        /// <param name="obj">where值</param>
        /// <returns>安全返回false，危险字符返回true</returns>
        public static bool ValidateSQL(string strSql)
        {
            return !Regex.IsMatch(strSql, @"[insert|delete|alter|create|drop|restore|backup]");
        }
    }
}
