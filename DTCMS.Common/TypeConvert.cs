//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-12-12 20:23:09
// 功能描述: C#类型转换类
// 修改标识: 修改于2010-1-11 21:19:20
// 修改描述: 增加ToByte、ToInt16方法，修改一处bug
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DTCMS.Common
{
    public class TypeConvert
    {
        /// <summary>
        /// string型转换为bool型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool ToBool(object expression, bool defValue)
        {
            if (expression != null)
                return ToBool(expression, defValue);

            return defValue;
        }

        /// <summary>
        /// string型转换为bool型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool ToBool(string expression, bool defValue)
        {
            if (expression != null)
            {
                if (string.Compare(expression, "true", true) == 0)
                    return true;
                else if (string.Compare(expression, "false", true) == 0)
                    return false;
            }
            return defValue;
        }

        /// <summary>
        /// 将对象转换为Byte类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <returns>转换后的Byte类型结果</returns>
        public static byte ToByte(object expression)
        {
            return ToByte(expression, 0);
        }

        /// <summary>
        /// 将对象转换为Byte类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Byte类型结果</returns>
        public static byte ToByte(object expression, byte defValue)
        {
            if (expression != null)
                return ToByte(expression.ToString(), defValue);

            return defValue;
        }

        /// <summary>
        /// 将对象转换为Byte类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的Byte类型结果</returns>
        public static byte ToByte(string str)
        {
            return ToByte(str, 0);
        }

        /// <summary>
        /// 将对象转换为Byte类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Byte类型结果</returns>
        public static byte ToByte(string str, byte defValue)
        {
            if (string.IsNullOrEmpty(str) || str.Trim().Length > 3 || !Regex.IsMatch(str.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            byte rv;
            if (byte.TryParse(str, out rv))
                return rv;

            return Convert.ToByte(str);
        }

        /// <summary>
        /// 将对象转换为Int16类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <returns>转换后的Int16类型结果</returns>
        public static Int16 ToInt16(object expression)
        {
            return ToInt16(expression, 0);
        }

        /// <summary>
        /// 将对象转换为Int16类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Int16类型结果</returns>
        public static Int16 ToInt16(object expression, Int16 defValue)
        {
            if (expression != null)
                return ToInt16(expression.ToString(), defValue);

            return defValue;
        }

        /// <summary>
        /// 将对象转换为Int16类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的Int16类型结果</returns>
        public static Int16 ToInt16(string str)
        {
            return ToInt16(str, 0);
        }

        /// <summary>
        /// 将对象转换为Int16类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Int16类型结果</returns>
        public static Int16 ToInt16(string str, Int16 defValue)
        {
            if (string.IsNullOrEmpty(str) || str.Trim().Length > 5 || !Regex.IsMatch(str.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            Int16 rv;
            if (Int16.TryParse(str, out rv))
                return rv;

            return Convert.ToInt16(str);
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <returns>转换后的Int32类型结果</returns>
        public static int ToInt32(object expression)
        {
            return ToInt32(expression, 0);
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Int32类型结果</returns>
        public static int ToInt32(object expression, int defValue)
        {
            if (expression != null)
                return ToInt32(expression.ToString(), defValue);

            return defValue;
        }

        /// <summary>
        /// 将对象转换为Int32类型,转换失败返回0
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的Int32类型结果</returns>
        public static int ToInt32(string str)
        {
            return ToInt32(str, 0);
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Int32类型结果</returns>
        public static int ToInt32(string str, int defValue)
        {
            if (string.IsNullOrEmpty(str) || str.Trim().Length > 10 || !Regex.IsMatch(str.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            int rv;
            if (Int32.TryParse(str, out rv))
                return rv;

            return Convert.ToInt32(str);
        }

        /// <summary>
        /// Object型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的float类型结果</returns>
        public static float ToFloat(object strValue)
        {
            return ToFloat(strValue.ToString(), 0);
        }

        /// <summary>
        /// Object型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的float类型结果</returns>
        public static float ToFloat(object strValue, float defValue)
        {
            if ((strValue == null))
                return defValue;

            return ToFloat(strValue.ToString(), defValue);
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <returns>转换后的float类型结果</returns>
        public static float ToFloat(string strValue)
        {
            return ToFloat(strValue, 0);
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的float类型结果</returns>
        public static float ToFloat(string strValue, float defValue)
        {
            if ((strValue == null) || (strValue.Length > 10))
                return defValue;

            float intValue = defValue;
            if (strValue != null)
            {
                bool IsFloat = Regex.IsMatch(strValue, @"^([-]|[0-9])[0-9]*(\.\w*)?$");
                if (IsFloat)
                    float.TryParse(strValue, out intValue);
            }
            return intValue;
        }
    }
}
