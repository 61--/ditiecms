using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.DALFactory
{

    /// <summary>
    ///  ���ݷ��ʼ򵥹��������ڴ�����Ӧ�����ݷ��ʶ���
    /// </summary>
    /// <typeparam name="I">�ӿڶ���</typeparam>
    public sealed class DataAccess
    {

        /// <summary>
        /// ��ȡ�û����ݷ�����
        /// </summary>
        /// <param name="className">���ݲ���DAL����</param>
        /// <returns>���ݷ��������</returns>
        public static I CreateFactoryDAL<I>(string className)
        {
            return (I)DependencyProvider.GetDALObject(className);
        }

    }
}
