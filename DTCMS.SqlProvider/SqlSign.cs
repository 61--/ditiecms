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
    /// </summary>
    public class OperateSign
    {
        /// <summary>
        /// 等于 默认
        /// </summary>
        public static OperateSign Equal = new OperateSign("={0}");
        /// <summary>
        /// 不等于
        /// </summary>
        public static OperateSign NotEqual = new OperateSign("<>{0}");
        /// <summary>
        /// 大于等于
        /// </summary>
        public static OperateSign GreatThanEqual = new OperateSign(">={0}");
        /// <summary>
        /// 大于
        /// </summary>
        public static OperateSign GreatThan = new OperateSign(">{0}");
        /// <summary>
        /// 小于等于
        /// </summary>
        public static OperateSign SmallThanEqual = new OperateSign("<={0}");
        /// <summary>
        /// 小于
        /// </summary>
        public static OperateSign SmallThan = new OperateSign("<{0}");
        /// <summary>
        /// 包含
        /// </summary>
        public static OperateSign In = new OperateSign("IN ({0})");
        /// <summary>
        /// 匹配
        /// </summary>
        public static OperateSign Like = new OperateSign("LIKE '%{0}%'");

        private string sign;
        private OperateSign(string sign)
        {
            this.sign = sign;
        }
        /// <summary>
        /// 获得表达式值
        /// </summary>
        public string Sign
        {
            get { return this.sign; }
        }
    }
    #endregion

    #region 条件连接标识
    /// <summary>
    /// 条件连接标识
    /// </summary>
    public class JoinSign
    {
        /// <summary>
        /// 无连接（默认）
        /// </summary>
        public static JoinSign None = new JoinSign("");

        /// <summary>
        /// 用AND连接
        /// </summary>
        public static JoinSign And = new JoinSign(" AND ");
        /// <summary>
        /// 用OR连接
        /// </summary>
        public static JoinSign Or = new JoinSign(" OR ");

        private string sign;
        private JoinSign(string sign)
        {
            this.sign = sign;
        }
        /// <summary>
        /// 获得连接值
        /// </summary>
        public string Sign
        {
            get { return this.sign; }
        }
    }
    #endregion

    #region 数据排序标识
    /// <summary>
    /// 数据排序标识
    /// </summary>
    public class SortSign
    {
        /// <summary>
        /// 倒排序
        /// </summary>
        public static SortSign Desc = new SortSign(" DESC ");
        /// <summary>
        /// 正排序
        /// </summary>
        public static SortSign Asc = new SortSign(" ASC ");

        private string sign;
        private SortSign(string sign)
        {
            this.sign = sign;
        }
        /// <summary>
        /// 排序字符串
        /// </summary>
        public string Sign
        {
            get { return this.sign; }
        }
    }
    #endregion
}
