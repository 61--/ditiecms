using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using Tuan.Config;

namespace Tuan.Data.Provider
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    public abstract class DbHelper
    {
        //获取数据库连接字符串
        protected static string CONNECTIONSTRING = ConfigAccess<Tuan.Entity.Config.AppConfigInfo>.GetConfig().DbConnection;
        protected const int COMMAND_TIMEOUT = 20;

        private static int _querycount = 0;
        /// <summary>
        /// 查询次数统计
        /// </summary>
        public static int QueryCount
        {
            get { return _querycount; }
            set { _querycount = value; }
        }

        #region 由Object取值
        /// <summary>
        /// 取得Int16值
        /// </summary>
        public static Int16 GetInt16(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToInt16(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得UInt16值
        /// </summary>
        public static UInt16 GetUInt16(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToUInt16(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得Int值
        /// </summary>
        public static int GetInt(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得UInt值
        /// </summary>
        public static uint GetUInt(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToUInt32(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得UInt64值
        /// </summary>
        public static ulong GetULong(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToUInt64(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得byte值
        /// </summary>
        public static Byte GetByte(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToByte(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得sbyte值
        /// </summary>
        public static sbyte GetSByte(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToSByte(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 获得Long值
        /// </summary>
        public static long GetLong(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToInt64(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得Decimal值
        /// </summary>
        public static decimal GetDecimal(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToDecimal(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得float值
        /// </summary>
        public static float GetFloat(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToSingle(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得double值
        /// </summary>
        public static double GetDouble(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToDouble(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取得Guid值
        /// </summary>
        public static Guid GetGuid(object obj)
        {
            if (obj != DBNull.Value)
            {
                return new Guid(obj.ToString());
            }
            else
            {
                return Guid.Empty;
            }
        }

        /// <summary>
        /// 取得DateTime值
        /// </summary>
        public static DateTime GetDateTime(object obj)
        {
            if (obj != DBNull.Value)
            {
                DateTime tmp;
                if (DateTime.TryParse(obj.ToString(), out tmp))
                {
                    return tmp;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// 取得bool值
        /// </summary>
        public static bool GetBool(object obj)
        {
            if (obj != DBNull.Value)
            {
                return Convert.ToBoolean(obj);
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 取得byte[]
        /// </summary>
        public static Byte[] GetBinary(object obj)
        {
            if (obj != DBNull.Value)
            {
                return (Byte[])obj;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得string值
        /// </summary>
        public static string GetString(object obj)
        {
            return obj.ToString();
        }
        #endregion
    }
}
