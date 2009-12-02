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
		int Delete(int ID);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		Arc_Article GetModel(int ID);
		#endregion  ��Ա����
	}
}
