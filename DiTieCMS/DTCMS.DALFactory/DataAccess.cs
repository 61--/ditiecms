//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-10-29 11:52:24
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using DTCMS.IDAL;

namespace DTCMS.DALFactory
{

    /// <summary>
    ///  数据访问简单工厂，用于创建相应的数据访问对象
    /// </summary>
    /// <typeparam name="T">接口对象</typeparam>
    public sealed class DataAccess
    {

        /// <summary>
        /// 获取用户数据访问类
        /// </summary>
        /// <param name="className">数据层类DAL名称</param>
        /// <returns>数据访问类对象</returns>
        public static T CreateFactoryDAL<T>(string className)
        {
            return (T)DependencyProvider.GetDALObject(className);
        }

        /// <summary>
        /// 2010-02-06 添加，测试代码
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
