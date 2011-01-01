//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-02-06 23:35:36
// 功能描述: 数据组装对象
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.SqlProvider
{
    /// <summary>
    /// 数据组装对象
    /// </summary>
    public class SqlWhereCondition
    {
        private string fieldName;
        private object fieldValue;
        private OperateSign operateSign;
        private JoinSign joinSign;

        /// <summary>
        /// 字段名称
        /// </summary>
        public string FieldName
        {
            get { return this.fieldName; }
        }
        /// <summary>
        /// 字段值
        /// </summary>
        public object FieldValue
        {
            get { return this.fieldValue; }
        }
        /// <summary>
        /// 操作符
        /// </summary>
        public OperateSign OperateSign
        {
            get { return this.operateSign; }
        }
        /// <summary>
        /// 连接符
        /// </summary>
        public JoinSign JoinSign
        {
            get { return this.joinSign; }
        }

        /// <summary>
        /// 构造组装对象
        /// </summary>
        /// <param name="fieldName">列名称</param>
        /// <param name="parameterName">参数名称</param>
        /// <param name="parameterValue">参数值</param>
        /// <param name="joinSign">操作符</param>
        /// <param name="operateSign">连接符</param>
        public SqlWhereCondition(string fieldName, object fieldValue, JoinSign joinSign, OperateSign operateSign)
        {
            this.fieldName = fieldName;
            this.fieldValue = fieldValue;
            this.operateSign = operateSign;
            this.joinSign = joinSign;
        }
    }
}
