using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DTCMS.Entity;
using DTCMS.BLL;
using DTCMS.Common;
namespace DTCMS.Web.admin
{
    public partial class Template_add : AdminPage
    {
        int TempID = 0;
        Sys_TemplateBLL bllTemplate = new Sys_TemplateBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            TempID = DTCMS.Common.Utils.GetQueryInt("Id");
            if (!IsPostBack)
            {
                if (TempID > 0)
                {
                    SetPageData(TempID);
                        
                }
            }
        }

        protected void SetPageData(int TempID)
        { 
            if (TempID <= 0)
            {
                return;
            }

            Sys_Template  model = bllTemplate.GetModel(TempID);
            if (model != null)
            {
                txt_TemplateName.Value = model.TemplateName;
                txt_Author.Value = model.Author;
                txt_TemplateDirectory.Value = model.TemplateDirectory;
                txt_TemplateImg.Value = model.TemplateImg;
                hide_CreateDateTime.Value = model.CreateDateTime.HasValue ? model.CreateDateTime.ToString() : DateTime.Now.ToString();
                if (model.isEnable == 1)
                    rad_yes.Checked = true;
                else
                    rad_no.Checked = true;

            }
        }

        protected Sys_Template GetTemplateModel()
        {
            Sys_Template model = new Sys_Template();
            model.TemplateID = TempID;
            model.TemplateName = txt_TemplateName.Value.Trim();
            model.Author = txt_Author.Value.Trim();
            model.TemplateDirectory = txt_TemplateDirectory.Value.Trim();
            model.TemplateImg = txt_TemplateImg.Value.Trim();
            if(string.IsNullOrEmpty(hide_CreateDateTime.Value))
                hide_CreateDateTime.Value=DateTime.Now.ToString();
            model.CreateDateTime =Convert.ToDateTime( hide_CreateDateTime.Value);
            model.isEnable = 0;
            if (rad_yes.Checked)
            {
                model.isEnable = 1;
                bllTemplate.UpdateEnable(TempID, 1);//保证只有一个模板启用
            }
            return model;
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TemplateName.Value))
            {
                Message.Dialog("风格名称不能为空!","-1",MessageIcon.Error);
                return;
            }
                
            if (!bllTemplate.ExistTemplateName(TempID, txt_TemplateName.Value.Trim()))
            {
                if (TempID > 0)
                {
                    if (bllTemplate.Update(GetTemplateModel()) > 0)
                        Message.Dialog("更新风格信息成功！", "-1", MessageIcon.Success);
                    else
                        Message.Dialog("更新风格信息失败!请检查您的数据是否规范!","-1",MessageIcon.Error);
                }
                else
                {
                   if( bllTemplate.Add(GetTemplateModel())>0)
                       Message.Dialog("添加风格信息成功！", "template_list", MessageIcon.Success);
                   else
                       Message.Dialog("添加风格信息失败!请检查您的数据是否规范!", "-1", MessageIcon.Error);
                }
            }
            else
            {
                Message.Dialog("此风格名称已存在!请重新填写！", "-1", MessageIcon.Error);
            }
        }
    }
}
