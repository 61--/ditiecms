using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.DALFactory
{
    /// <summary>
    /// ���ݷ��ʼ򵥹��������ڴ�����Ӧ�����ݷ��ʶ���
    /// </summary>
    //public sealed class DataAccess<T,It> where T:It,new ()
    //{
       
    //     //<summary>
    //     //��ȡ�û����ݷ�����
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
    /// ����
    /// </summary>
    /// <typeparam name="I">�ӿڶ���</typeparam>
    public sealed class DataAccess<I>
    {

        // //<summary>
        // //��ȡ�û����ݷ�����
        // //</summary>
        // //<returns></returns>
        //public static I CreateFactoryDAL(string)
        //{
        //    return (I)DependencyProvider.GetDALObject();
        //}
    }

}
