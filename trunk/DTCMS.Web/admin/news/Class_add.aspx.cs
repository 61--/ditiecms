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
namespace DTCMS.Web.admin.news
{
    public partial class Class_add : System.Web.UI.Page
    {
        Arc_ClassBLL classBll = new Arc_ClassBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int cid = Common.Utils.GetQueryInt("Id");
                if (cid > 0)
                {
                    SetData(cid);
                }
            }
        }
        /// <summary>
        /// 绑定下拉框数据
        /// </summary>
        private void SelectDataBind()
        { 
        }
        /// <summary>
        ///  更新数据赋值
        /// </summary>
        /// <param name="CID"></param>
        private void SetData(int CID)
        {
            Arc_Class model = classBll.GetModel(CID);
            if (model != null)
            {
                hidden_ClassId.Value = model.CID.ToString();
                txt_ClassName.Value = model.ClassName;
            }
        }
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <returns></returns>
        private Arc_Class GetModel()
        {
            Arc_Class model = new Arc_Class();
            model.CID = int.Parse(hidden_ClassId.Value);
            model.ClassName = txt_ClassName.Value;
            return model;
        }
        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (int.Parse(hidden_ClassId.Value) > 0)
            {
                n= classBll.Add(GetModel());
                if (n > 0)
                {
                    Message.Dialog("添加栏目成功！", "Class.aspx", MessageIcon.Success);
                }
                else
                {
                    Message.Dialog("添加栏目失败！请检查数据是否完整。",null,MessageIcon.Error);
                }
            }
            else
            {
                n= classBll.Update(GetModel());
                if (n > 0)
                {
                    Message.Dialog("更新栏目成功！", "Class.aspx", MessageIcon.Success);
                }
                else
                {
                    Message.Dialog("更新栏目失败！请检查数据是否完整。", null, MessageIcon.Error);
                }
            }
        }
    }
}
