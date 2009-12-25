using System;
using System.Data;
using DTCMS.Entity;
namespace DTCMS.IDAL
{
    public interface IDAL_Sys_Template
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="CID">类别主键</param>
        /// <param name="FiledName">字段名称</param>
        /// <param name="FiledValue">字段值</param>
        bool Exists(int CID, string filedName, string filedValue);

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

        /// <summary>
        /// 获取风格数据
        /// </summary>
        /// <param name="Fileds">要查询的字段</param>
        /// <returns></returns>
        DataTable GetDataTable(string Fileds);
    }
}
