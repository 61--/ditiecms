using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace DTCMS.DBUtility
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    public class DBHelper
    {
        public DBHelper(){ }

        //获取数据库连接字符串，其属于静态变量且只读，项目中所有文档可以直接使用，但不能修改
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

        #region 由Object取值
        /// <summary>
        /// 取得Int16值
        /// </summary>
        public Int16 GetInt16(object obj)
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
        public UInt16 GetUInt16(object obj)
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
        public int GetInt(object obj)
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
        public uint GetUInt(object obj)
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
        public ulong GetULong(object obj)
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
        public Byte GetByte(object obj)
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
        public sbyte GetSByte(object obj)
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
        public long GetLong(object obj)
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
        public decimal GetDecimal(object obj)
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
        public float GetFloat(object obj)
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
        public double GetDouble(object obj)
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
        public Guid GetGuid(object obj)
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
        public DateTime GetDateTime(object obj)
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
        public bool GetBool(object obj)
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
        public Byte[] GetBinary(object obj)
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
        public string GetString(object obj)
        {
            return obj.ToString();
        }
        #endregion
    }
}
