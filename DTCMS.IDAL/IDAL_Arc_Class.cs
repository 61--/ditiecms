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
		bool Exists(int CID);
		/// <summary>
		/// ����һ������
		/// </summary>
        int Add(Arc_Class model);
		/// <summary>
		/// ����һ������
		/// </summary>
        void Update(Arc_Class model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(int CID);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		Arc_Class GetModel(int CID);
		#endregion  ��Ա����
	}
}
