//------------------------------------------------------------------------------
// ������ʶ: Copyright (C) 2010 91aspx.com ��Ȩ����
// ��������: DTCMS V1.0 ������ 2009-10-29 11:52:24
// ��������: 
// �޸ı�ʶ:
// �޸�����: 
//------------------------------------------------------------------------------
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
    /// <typeparam name="T">�ӿڶ���</typeparam>
    public sealed class DataAccess
    {

        /// <summary>
        /// ��ȡ�û����ݷ�����
        /// </summary>
        /// <param name="className">���ݲ���DAL����</param>
        /// <returns>���ݷ��������</returns>
        public static T CreateFactoryDAL<T>(string className)
        {
            return (T)DependencyProvider.GetDALObject(className);
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
