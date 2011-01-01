/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2010 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2010-10-5 19:57:04
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;

namespace Tuan.Entity
{
    /// <summary>
    /// ʵ���� Category
    /// </summary>
    public class Category
    {
        public Category(){ }
        
        #region ʵ������
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
    