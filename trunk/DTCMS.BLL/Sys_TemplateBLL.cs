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
    }
}
