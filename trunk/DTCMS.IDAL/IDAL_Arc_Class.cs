using System;
using System.Data;
using DTCMS.Entity;

namespace DTCMS.IDAL
{
	/// <summary>
	/// �ӿڲ�IDT_Arc_Class ��ժҪ˵����
	/// </summary>
	public interface IDAL_Arc_Class
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
        /// <param name="CID">�������</param>
        /// <param name="FiledName">�ֶ�����</param>
        /// <param name="FiledValue">�ֶ�ֵ</param>
		bool Exists(int CID,string filedName,string filedValue);
		/// <summary>
		/// ����һ������
		/// </summary>
        int Add(Arc_Class model);
		/// <summary>
		/// ����һ������`
		/// </summary>
        int Update(Arc_Class model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
        int Delete(string CID);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		Arc_Class GetModel(int CID);

        /// <summary>
        /// ��ȡ��Ŀ��ϵ
        /// </summary>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        string GetRelation(int ParentID);
        /// <summary>
        /// ��ȡ����Ŀ����
        /// </summary>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        string GetParentName(int ParentID);

        /// <summary>
        /// ��ȡ��Ŀ����
        /// </summary>
        /// <param name="Fileds">Ҫ��ѯ���ֶ�</param>
        /// <returns></returns>
        DataTable  GetDataTable(string Fileds);

        /// <summary>
        /// �жϵ�ǰ�ڵ��Ƿ�����ӽڵ�
        /// </summary>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        bool ExistsChildNode(int CID);

		#endregion  ��Ա����
	}
}
