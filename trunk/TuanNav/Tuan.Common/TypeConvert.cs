using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tuan.Common
{
    public class TryConvert
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

        #region Convert ToSingle
        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <returns>转换后的float类型结果</returns>
        public static float ToSingle(string strValue)
        {
            return ToSingle(strValue, 0f);
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的float类型结果</returns>
        public static float ToSingle(string str, float defValue)
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
        public static float ToSingle(object obj)
        {
            return ToSingle(obj, 0f);
        }

        /// <summary>
        /// Object型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的float类型结果</returns>
        public static float ToSingle(object obj, float defValue)
        {
            if (obj != null)
                return ToSingle(obj.ToString(), defValue);
            else
                return defValue;
        }
        #endregion

        #region Convert ToDouble
        /// <summary>
        /// string型转换为double型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <returns>转换后的double类型结果</returns>
        public static double ToDouble(string strValue)
        {
            return ToDouble(strValue, 0d);
        }

        /// <summary>
        /// string型转换为double型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的double类型结果</returns>
        public static double ToDouble(string str, double defValue)
        {
            if (string.IsNullOrEmpty(str))
                return defValue;

            double rv;
            if (double.TryParse(str, out rv))
                return rv;
            else
                return defValue;
        }

        /// <summary>
        /// Object型转换为double型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的double类型结果</returns>
        public static double ToDouble(object obj)
        {
            return ToDouble(obj, 0d);
        }

        /// <summary>
        /// Object型转换为double型
        /// </summary>
        /// <param name="strValue">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的double类型结果</returns>
        public static double ToDouble(object obj, double defValue)
        {
            if (obj != null)
                return ToDouble(obj.ToString(), defValue);
            else
                return defValue;
        }

        #endregion

        #region Convert ToDecimal
        /// <summary>
        /// string型转换为decimal型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <returns>转换后的decimal类型结果</returns>
        public static decimal ToDecimal(string strValue)
        {
            return ToDecimal(strValue, 0m);
        }

        /// <summary>
        /// string型转换为decimal型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的decimal类型结果</returns>
        public static decimal ToDecimal(string str, decimal defValue)
        {
            if (string.IsNullOrEmpty(str))
                return defValue;

            decimal rv;
            if (decimal.TryParse(str, out rv))
                return rv;
            else
                return defValue;
        }

        /// <summary>
        /// Object型转换为decimal型
        /// </summary>
        /// <param name="obj">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的decimal类型结果</returns>
        public static decimal ToDecimal(object obj)
        {
            return ToDecimal(obj, 0m);
        }

        /// <summary>
        /// Object型转换为decimal型
        /// </summary>
        /// <param name="strValue">要转换的Object对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的decimal类型结果</returns>
        public static decimal ToDecimal(object obj, decimal defValue)
        {
            if (obj != null)
                return ToDecimal(obj.ToString(), defValue);
            else
                return defValue;
        }

        /// <summary>
        /// PHP 时间戳转换为DateTime
        /// </summary>
        /// <param name="time">要转换的PHP时间戳</param>
        /// <returns>转换后的DateTime类型</returns>
        public static DateTime ToDateTime(long time)
        {
            DateTime timeStamp = new DateTime(1970, 1, 1);  //得到1970年的时间戳
            long t = (time + 8 * 3600) * 10000000 + timeStamp.Ticks;
            DateTime dt = new DateTime(t);
            return dt;
        }

        /// <summary>
        /// String字符串转换为DateTime
        /// </summary>
        /// <param name="time">要转换的String字符串</param>
        /// <returns>转换后的DateTime类型</returns>
        public static DateTime ToDateTime(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new DateTime(1970, 1, 1);

            DateTime rv;
            if (DateTime.TryParse(str, out rv))
                return rv;
            else
                return new DateTime(1970, 1, 1);
        }

        /// <summary>
        /// Object对象转换为DateTime
        /// </summary>
        /// <param name="time">要转换的Object对象</param>
        /// <returns>转换后的DateTime类型</returns>
        public static DateTime ToDateTime(object obj)
        {
            if (obj != null)
                return ToDateTime(obj.ToString());
            else
                return new DateTime(1970, 1, 1);
        }
        #endregion
    }
}
