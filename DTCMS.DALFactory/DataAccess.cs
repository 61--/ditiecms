using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.DALFactory
{
    /// <summary>
    /// 数据访问简单工厂，用于创建相应的数据访问对象
    /// </summary>
    //public sealed class DataAccess<T,It> where T:It,new ()
    //{
       
    //     //<summary>
    //     //获取用户数据访问类
    //     //</summary>
    //     //<returns></returns>
    //    public static IUserDAL CreateUserDAL()
    //    {
    //        //Type t = typeof(T);
    //        return (It)DependencyProvider.GetDALObject(t.Name+"DAL");
    //         //return (IUserDAL)DependencyProvider.GetDALObject("UserDAL");
    //    }
    //}
    /// <summary>
    /// 工厂
    /// </summary>
    /// <typeparam name="I">接口对象</typeparam>
    public sealed class DataAccess<I>
    {

        // //<summary>
        // //获取用户数据访问类
        // //</summary>
        // //<returns></returns>
        //public static I CreateFactoryDAL(string)
        //{
        //    return (I)DependencyProvider.GetDALObject();
        //}
    }

}
