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
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(int ID);
		/// <summary>
		/// ����һ������
		/// </summary>
		int Add(Arc_Article model);
		/// <summary>
		/// ����һ������
		/// </summary>
        void Update(Arc_Article model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(int ID);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		Arc_Article GetModel(int ID);
		#endregion  ��Ա����
	}
}
