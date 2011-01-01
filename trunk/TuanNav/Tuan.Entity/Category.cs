/*******************************************************************************
* 创建标识: Copyright (C) 2007-2010 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2010-10-5 19:57:04
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;

namespace Tuan.Entity
{
    /// <summary>
    /// 实体类 Category
    /// </summary>
    public class Category
    {
        public Category(){ }
        
        #region 实体属性
        private int _categoryID;
        private string _ename;
        private string _cName;
        private string _description;
          
        /// <summary>
        /// CategoryID
        /// </summary>
        public int CategoryID
        {
            set { _categoryID = value; }
            get { return _categoryID; }
        }
                  
        /// <summary>
        /// Ename
        /// </summary>
        public string Ename
        {
            set { _ename = value; }
            get { return _ename; }
        }
                  
        /// <summary>
        /// CName
        /// </summary>
        public string CName
        {
            set { _cName = value; }
            get { return _cName; }
        }
                  
        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }        
        #endregion
    }
}
    