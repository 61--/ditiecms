//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-02-06 23:35:36
// 功能描述: 创建数据表达式标识、条件连接标识、数据排序标识
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.SqlProvider
{
    #region 数据表达式标识
    /// <summary>
    /// 数据表达式标识
    /// 
    public class OperateSign
    {
        /// <summary>
        /// 等于 默认
        /// </summary>
        public static readonly string Equal = "={0}";
        /// <summary>
        /// 不等于
        /// </summary>
        public static readonly string NotEqual = "<>{0}";
        /// <summary>
        /// 大于等于
        /// </summary>
        public static readonly string GreatThanEqual = ">={0}";
        /// <summary>
        /// 大于
        /// </summary>
        public static readonly string GreatThan = ">{0}";
        /// <summary>
        /// 小于等于
        /// </summary>
        public static readonly string SmallThanEqual = "<={0}";
        /// <summary>
        /// 小于
        /// </summary>
        public static readonly string SmallThan = "<{0}";
        /// <summary>
        /// 包含
        /// </summary>
        public static readonly string In = " IN({0})";
        /// <summary>
        /// 左匹配
        /// </summary>
        public static readonly string LeftLike = " LIKE '%{0}'";
        /// <summary>
        /// 左匹配
        /// </summary>
        public static readonly string RightLike = " LIKE '{0}%'";
        /// <summary>
        /// 左右匹配
        /// </summary>
        public static readonly string Like = " LIKE '%{0}%'";
    }
    #endregion

    #region 数据排序标识
    /// <summary>
    /// 数据排序标识
    /// </summary>
    public enum ESortSign
    {
        /// <summary>
        /// 倒排序
        /// </summary>
        DESC,
        /// <summary>
        /// 正排序
        /// </summary>
        ASC
    }
    #endregion

    #region 数据类型
    public enum EDBType
    {
        /// <summary>
        /// 字符串
        /// </summary>
        VARCHAR,
        /// <summary>
        /// 日前
        /// </summary>
        DATETIME,
        /// <summary>
        /// 匹配
        /// </summary>
        LIKE,
        /// <summary>
        /// 数字
        /// </summary>
        NUMBER,        
        /// <summary>
        /// 包含字符串
        /// </summary>
        INVARCHAR,
        /// <summary>
        /// 包含数字
        /// </summary>
        INNUMBER
        
    }
    #endregion
}
