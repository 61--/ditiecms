using System;
using System.Collections.Generic;
using System.Data;
using Tuan.Entity;

namespace Tuan.Data.DAO
{
    /// <summary>
    /// ���ݷ��ʳ����� CategoryDAO
    /// </summary>
    public abstract class CategoryDAO : BaseDAO<CategoryDAO>
    {
        /// <summary>
        /// ��ȡָ����ID��Ʒ���-1Ϊ��ȡ����
        /// </summary>
        public abstract IList<Category> GetList(int pid);

        /// <summary>
        /// ��ȡ������Ʒ���
        /// </summary>
        public abstract DataTable GetDataList();
    }
}