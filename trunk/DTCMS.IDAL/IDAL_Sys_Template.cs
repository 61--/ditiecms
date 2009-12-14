using System;
using System.Data;
using DTCMS.Entity;
namespace DTCMS.IDAL
{
    public interface IDAL_Sys_Template
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(Sys_Template model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        int Update(Sys_Template model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        int Delete(string TemplateID);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Sys_Template GetModel(int TemplateID);
    }
}
