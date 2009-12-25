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

        /// <summary>
        /// 设置风格为启动状态
        /// </summary>
        /// <param name="tempID">风格编号</param>
        /// <param name="isEnable"> 1启动 </param>
        /// <returns></returns>
        bool UpdateEnable(int TemplateID, int isEnable);
    }
}
