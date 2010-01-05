using System;
using System.Data;
using DTCMS.Entity;

namespace DTCMS.IDAL
{
    public interface IDAL_Sys_Navigate
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int NvaID);

        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(DT_SYS_Navigate model);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        int Update(DT_SYS_Navigate model);

        /// <summary>
        /// 删除一条数据
        /// </summary>
        int Delete(string NID);

       /// <summary>
        /// 获取导航菜单名称
        /// </summary>
        /// <param name="NvaID"></param>
        /// <returns></returns>
        string GetSingleFileName(string filedName, string NvaID);
    }
}
