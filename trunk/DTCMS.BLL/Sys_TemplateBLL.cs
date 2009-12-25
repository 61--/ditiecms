using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Common;
using DTCMS.DALFactory;
using DTCMS.IDAL;
using DTCMS.Entity;

namespace DTCMS.BLL
{
    public class Sys_TemplateBLL
    {
        IDAL_Sys_Template dalTemplate = DataAccess.CreateFactoryDAL<IDAL_Sys_Template>("Sys_TemplateDAL");
        /// <summary>
        /// 增加一条模板风格数据
        /// </summary>
        public int Add(Sys_Template model)
        {
           return dalTemplate.Add(model);
        }
        /// <summary>
        /// 更新一条模板风格数据
        /// </summary>
        public int Update(Sys_Template model)
        {
           return  dalTemplate.Update(model);
        }
        /// <summary>
        /// 批量删除模板风格数据
        /// </summary>
        public int Delete(string TemplateID)
        {
           return  dalTemplate.Delete(TemplateID);
        }
        /// <summary>
        /// 得到一个模板风格对象实体
        /// </summary>
        public Sys_Template GetModel(int TemplateID)
        {
           return  dalTemplate.GetModel(TemplateID);
        }

        /// <summary>
        /// 设置风格为启动状态
        /// </summary>
        /// <param name="tempID">风格编号</param>
        /// <param name="isEnable"> 1启动 </param>
        /// <returns></returns>
        public bool UpdateEnable(int TemplateID, int isEnable)
        {
            return dalTemplate.UpdateEnable(TemplateID, isEnable);
        }

        /// <summary>
        /// 判断此风格名称是否存在
        /// </summary>
        /// <param name="TemplateID">风格编号</param>
        /// <param name="templateName">名称</param>
        /// <returns></returns>
        public bool ExistTemplateName(int TemplateID,string templateName)
        {
            return dalTemplate.Exists(TemplateID, "TemplateName", templateName);
        }

        /// <summary>
        /// 获取附件-图片
        /// </summary>
        /// <param name="pageCurrent">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="where">查询条件</param>
        /// <param name="pagecount">总页数</param>
        /// <returns></returns>
        public DataTable GetTemplateList()
        {
            return dalTemplate.GetDataTable("TemplateID,TemplateName,Author,TemplateDirectory,isEnable,TemplateImg");
        }
    }
}
