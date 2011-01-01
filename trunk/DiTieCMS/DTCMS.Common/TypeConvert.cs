//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-12-12 20:23:09
// 功能描述: C#类型转换类
// 修改描述: LinPanxing 修改于 2010-06-27 19:42:50
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
        #region Convert ToBool
        /// <summary>
        /// object型转换为bool型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool ToBool(object obj)
        {
            if (obj != null)
                return ToBool(obj.ToString());
            else
                return false;
        }

        /// <summary>
        /// string型转换为bool型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool ToBool(string str)
        {
            if (str != null)
            {
                if (str == "1" || string.Equals(str, Boolean.TrueString, StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                    return false;
            }
            return false;
        }
        #endregion

        #region Convert ToByte
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
            if (string.IsNullOrEmpty(str))
                return defValue;

            byte rv;
            if (byte.TryParse(str, out rv))
                return rv;
            else
                return defValue;
        }

        /// <summary>
        /// 将对象转换为Byte类型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <returns>转换后的Byte类型结果</returns>
        public static byte ToByte(object obj)
        {
            return ToByte(obj, 0);
        }

        /// <summary>
        /// 将对象转换为Byte类型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Byte类型结果</returns>
        public static byte ToByte(object obj, byte defValue)
        {
            if (obj != null)
                return ToByte(obj.ToString(), defValue);
            else
                return defValue;
        }
        #endregion

        #region Convert ToInt16
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
            if (string.IsNullOrEmpty(str))
                return defValue;

            Int16 rv;
            if (Int16.TryParse(str, out rv))
                return rv;
            else
                return defValue;
        }

        /// <summary>
        /// 将对象转换为Int16类型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <returns>转换后的Int16类型结果</returns>
        public static Int16 ToInt16(object obj)
        {
            return ToInt16(obj.ToString(), 0);
        }

        /// <summary>
        /// 将对象转换为Int16类型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Int16类型结果</returns>
        public static Int16 ToInt16(object obj, Int16 defValue)
        {
            if (obj != null)
                return ToInt16(obj.ToString(), defValue);
            else
                return defValue;
        }
        #endregion

        #region Convert ToInt32
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
            if (string.IsNullOrEmpty(str))
                return defValue;

            int rv;
            if (Int32.TryParse(str, out rv))
                return rv;
            else
                return defValue;
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <returns>转换后的Int32类型结果</returns>
        public static int ToInt32(object obj)
        {
            return ToInt32(obj, 0);
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Int32类型结果</returns>
        public static int ToInt32(object obj, int defValue)
        {
            if (obj != null)
                return ToInt32(obj.ToString(), defValue);
            else
                return defValue;
        }
        #endregion

        #region Convert ToFloat
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
        public static float ToFloat(string str, float defValue)
        {
            if (string.IsNullOrEmpty(str))
                return defValue;

            float rv;
            if (float.TryParse(str, out rv))
                return rv;
            else
                return defValue;
        }

        /// <summary>
        /// Object型转换为float型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的float类型结果</returns>
        public static float ToFloat(object obj)
        {
            return ToFloat(obj, 0);
        }

        /// <summary>
        /// Object型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的float类型结果</returns>
        public static float ToFloat(object obj, float defValue)
        {
            if (obj != null)
                return ToFloat(obj.ToString(), defValue);
            else
                return defValue;
        }
        #endregion
    }
}
