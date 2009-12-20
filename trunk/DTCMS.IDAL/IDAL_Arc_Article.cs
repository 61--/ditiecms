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
        /// -- �ַ�������ʵ�ֵ�ͨ�÷�ҳ�洢����(ת���޽�)  
        /// </summary>
        /// <param name="tbname">Ҫ��ҳ��ʾ�ı���������ʹ�ñ�����  </param>
        /// <param name="FieldKey">���ڶ�λ��¼������(Ωһ��)�ֶ�,ֻ���ǵ����ֶ�  </param>
        /// <param name="PageCurrent">Ҫ��ʾ��ҳ��  </param>
        /// <param name="PageSize">ÿҳ�Ĵ�С(��¼��)  </param>
        /// <param name="FieldShow">�Զ��ŷָ���Ҫ��ʾ���ֶ��б�,�����ָ��,����ʾ�����ֶ�  </param>
        /// <param name="FieldOrder">����ָ������˳��  </param>
        /// <param name="Where">��ѯ����  </param>
        /// <param name="PageCount">��ҳ��  </param>
        /// <returns></returns>
        DataTable GetDataTable(string tbname, string FieldKey, int PageCurrent, int PageSize
            , string FieldShow, string FieldOrder, string Where, out int PageCount);
        #endregion

    }
}
