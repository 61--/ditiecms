using System;
using System.Data;
using Tuan.Entity;

namespace Tuan.Data.DAO
{
    /// <summary>
    /// ���ݷ��ʳ����� TuanGouDAO
    /// </summary>
    public abstract class TuanGouDAO : BaseDAO<TuanGouDAO>
    {
        /// <summary>
        /// ����һ������
        /// </summary>
        public abstract int Add(TuanGou model);

        /// <summary>
        /// �ɼ��Ź���Ʒ
        /// </summary>
        public abstract int AddOrUpdate(TuanGou model);

        /// <summary>
        /// ����һ������
        /// </summary>
        public abstract int Update(TuanGou model);

        /// <summary>
        /// �����Ź�״̬
        /// </summary>
        public abstract int UpdateStatu(int tuanID, int statu);
            
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public abstract int Delete(int TuanID);
      
        /// <summary>
        /// ��ȡһ��ʵ������
        /// </summary>
        public abstract TuanGou GetModel(int TuanID);

        /// <summary>
        /// ��ȡ���������Ź���Ϣ
        /// </summary>
        public abstract ModelList GetNewTuan(int cityID, int category, int lp, int hp, string order, bool desc);

        /// <summary>
        /// ��ȡָ�������Ƽ��Ź�
        /// </summary>
        public abstract ModelList GetRecommend(int cityID);

        /// <summary>
        /// ��ҳ��ȡ�Ź���Ʒ�б�
        /// </summary>
        public abstract DataTable GetTuanList(int curPage, int pageSize, string sortValue, bool isDesc, string keyWord, ref int totalRecord);
    }
}