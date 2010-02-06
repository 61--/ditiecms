using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using DTCMS.IDAL;

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

        /// <summary>
        /// 2010-02-06 ��ӣ����Դ���
        /// </summary>
        static string DbType = ConfigurationManager.AppSettings["DbType"];
        public static IDAL_Modules CreateModulesDAL()
        {
            IDAL_Modules dal = null;

            switch (DbType)
            {
                case "SqlServer":
                    dal = new SqlServerDAL.ModulesDAL();
                    break;
            }

            return dal;
        }
    }
}
