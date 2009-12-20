using System;
using System.Data;
using DTCMS.Entity;

namespace DTCMS.IDAL
{
	/// <summary>
	/// �ӿڲ�IDT_Arc_Article ��ժҪ˵����
	/// </summary>
	public interface IDAL_Arc_Article
	{
		#region  ��Ա����
	
		 /// <summary>
        /// �ж�ĳ���ֶ�ֵ�Ƿ����
        /// </summary>
        /// <param name="CID">��Ŀ���</param>
        /// <param name="filedName">�ֶ�����</param>
        /// <param name="filedValue">�ֶ�ֵ</param>
        /// <returns>�ɹ�����true��ʧ�ܷ���false</returns>
        bool Exists(int CID, string filedName, string filedValue);
        
		/// <summary>
		/// ����һ������
		/// </summary>
		int Add(Arc_Article model);
		/// <summary>
		/// ����һ������
		/// </summary>
        int Update(Arc_Article model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		int Delete(string ID);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		Arc_Article GetModel(int ID);
        /// <summary>
        /// ������Ŀid �жϴ���Ŀ�Ƿ��������
        /// </summary>
        /// <param name="CID">��Ŀ���</param>
        /// <returns>true����,false������</returns>
        bool ExistAtricleToClass(int CID);
        /// <summary>
        /// �ж������Ƿ��Ѿ�����
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        bool ExistsArticleName(int ArticleID, string Title);
		#endregion  ��Ա����

        #region ������
        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <param name="tb">����</param>
        /// <param name="colist">-Ҫ��ѯ�����ֶ��б�,*��ʾȫ���ֶ�</param>
        /// <param name="top">����ȡ��¼�� </param>
        /// <param name="pagesize">ÿҳ��¼��</param>
        /// <param name="page">ָ��ҳ</param>
        /// <param name="condition">��ѯ����</param>
        /// <param name="sql_key">�������������</param>
        /// <param name="col">-���������磺id desc (���id desc,dt asc)</param>
        /// <param name="orderby">����,0-˳��,1-����</param>
        /// <param name="pagesum">��ҳ��</param>
        /// <returns>���ݱ�</returns>
        DataTable GetDataTable(string tb, string collist, int top, int pagesize, int page
            , string condition, string sql_key, string col, int orderby, out int pagesum);
        #endregion

    }
}
