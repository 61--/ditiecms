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
using DTCMS.Entity.Enum;
using DTCMS.BLL;
using DTCMS.Common;

namespace DTCMS.Web.admin.news
{
    public partial class Class_add : System.Web.UI.Page
    {
        private Arc_ClassBLL bllClass = new Arc_ClassBLL();
        private int CID=-1;  //栏目ID

        protected void Page_Load(object sender, EventArgs e)
        {
            CID = Common.Utils.GetQueryInt("Id");

            if (!IsPostBack)
            {                
                if (CID > 0)
                {
                    SetPageData();  //更新数据赋值
                }
            }
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            int updateStatus = 0;//更新是否成功
            Arc_Class modelClass = GetClassModel();

            #region 数据验证
            if (modelClass.ClassName.Trim() == "")
            {
                Message.Dialog("操作失败！栏目名称不能为空。", "-1", MessageIcon.Error, 0);
            }
            if (bllClass.ExistsClassName(CID, modelClass.ClassName))
            {
                Message.Dialog("操作失败！该栏目已经存在。", "-1", MessageIcon.Error, 0);
            }

            #endregion 数据验证

            if (CID > 0)
            {//修改栏目

                updateStatus = bllClass.Update(modelClass);

                if (updateStatus > 0)
                {
                    Message.Dialog("更新栏目成功！", "Class_list.aspx", MessageIcon.Success, 0);
                }
                else
                {
                    Message.Dialog("更新栏目失败！请检查数据是否完整。", "-1", MessageIcon.Error, 0);
                }
            }
            else
            {//添加栏目
                updateStatus = bllClass.Add(modelClass);

                if (updateStatus > 0)
                {
                    Message.Dialog("添加栏目成功！", "Class_list.aspx", MessageIcon.Success, 0);
                }
                else
                {
                    Message.Dialog("添加栏目失败！请检查数据是否完整。", "-1", MessageIcon.Error, 0);
                }
            }
        }

        /// <summary>
        ///  更新，初始化页面数据
        /// </summary>
        /// <param name="CID">栏目ID</param>
        private void SetPageData()
        {
            if (CID <= 0)
            {
                return;
            }

            Arc_Class model = bllClass.GetModel(CID);

            if (model != null)
            {
                hidden_ParentClassID.Value = model.ParentID.ToString();
                txt_ParentClassName.Value = model.ParentID.ToString();
                txt_ParentClassName.Value = bllClass.GetClassName(model.ParentID);
                SetClassAttribute(model.Attribute);
                txt_ClassName.Value = model.ClassName;
                txt_ClassEName.Value = model.ClassEName;
                slt_ClassType.Value = model.ClassType.ToString();
                txt_ClassDomain.Value = model.ClassDomain;
                txt_ClassPath.Value = model.ClassPath;
                txt_IndexTemplet.Value = model.IndexTemplet;
                txt_ListTemplet.Value = model.ListTemplet;
                txt_ArchiveTemplet.Value = model.ArchiveTemplet;
                txt_IndexRule.Value = model.IndexRule;
                txt_ListRule.Value = model.ListRule;
                txt_ArchiveRule.Value = model.ArchiveRule;
                txt_ClassPage.Value = model.ClassPage.ToString();
                txt_Description.Value = model.Description;
                chk_ISHiden.Checked = model.IsHidden == 1;
                chk_ISHtml.Checked = model.IsHtml == 1;
                slt_CheckLevel.Value = model.CheckLevel.ToString();
                chk_ISContribute.Checked = model.IsContribute == 1;
                chk_ISComment.Checked = model.IsComment == 1;
                slt_Readaccess.Value = model.Readaccess.ToString();
                txt_OrderID.Value = model.OrderID.ToString();
                txt_ImgUrl.Value = model.ImgUrl;
                txt_Keywords.Value = model.Keywords;
                txt_CorssID.Value = model.CrossID;
                txt_Content.Value = model.Content;
            }
        }

        /// <summary>
        /// 获取栏目实体，添加，修改
        /// </summary>
        /// <returns>栏目实体</returns>
        private Arc_Class GetClassModel()
        {
            Arc_Class model = new Arc_Class();

            model.CID = CID;
            model.ParentID = Convert.ToInt32(hidden_ParentClassID.Value == "" ? "0" : hidden_ParentClassID.Value.Trim());
            model.Attribute = GetClassAttribute();
            model.ClassName = txt_ClassName.Value;
            model.ClassEName = txt_ClassEName.Value.Trim();
            model.ClassType = Convert.ToInt32(slt_ClassType.Value == "" ? "0" : slt_ClassType.Value.Trim());
            model.ClassDomain = txt_ClassDomain.Value.Trim();
            model.ClassPath = txt_ClassPath.Value.Trim();
            model.IndexTemplet = txt_IndexTemplet.Value.Trim();
            model.ListTemplet = txt_ListTemplet.Value.Trim();
            model.ArchiveTemplet = txt_ArchiveTemplet.Value.Trim();
            model.IndexRule = txt_IndexRule.Value.Trim();
            model.ListRule = txt_ListRule.Value.Trim();
            model.ArchiveRule = txt_ArchiveRule.Value.Trim();
            model.ClassPage = Convert.ToInt32(txt_ClassPage.Value == "" ? "0" : txt_ClassPage.Value.Trim());
            model.Description = txt_Description.Value.Trim();
            model.IsHidden = chk_ISHiden.Checked ? 1 : 0;
            model.IsHtml = chk_ISHtml.Checked ? 1 : 0;
            model.CheckLevel = Convert.ToInt32(slt_CheckLevel.Value == "" ? "0" : slt_CheckLevel.Value.Trim());
            model.IsContribute = chk_ISContribute.Checked ? 1 : 0;
            model.IsComment = chk_ISComment.Checked ? 1 : 0;
            model.Readaccess = Convert.ToInt32(slt_Readaccess.Value == "" ? "0" : slt_Readaccess.Value.Trim());
            model.SiteID = 1;//站点ID，默认1
            model.AddDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            if (model.ParentID == 0)
            {
                model.Relation = model.ParentID.ToString();
            }
            else
            {
                model.Relation = bllClass.GetRelation(model.ParentID) + "." + model.ParentID;
            }

            model.OrderID = Convert.ToInt32(txt_OrderID.Value.Trim());
            model.ImgUrl = txt_ImgUrl.Value.Trim();
            model.Keywords = txt_Keywords.Value.Trim();
            model.CrossID = txt_CorssID.Value.Trim();
            model.Content = txt_Content.Value.Trim();

            return model;
        }

        /// <summary>
        /// 获取栏目属性
        /// </summary>
        /// <returns></returns>
        private int GetClassAttribute()
        {
            if (rdo_List.Checked)
            {//列表
                return (int)EClassAttribute.List;
            }
            else if (rdo_Singl.Checked)
            {//单页面
                return (int)EClassAttribute.Singl;
            }
            else if (rdo_Link.Checked)
            {//链接
                return (int)EClassAttribute.Link;
            }
            else//rdo_Index.Checked
            {//封面
                return (int)EClassAttribute.Cover;
            }
            
        }

        /// <summary>
        /// 设置栏目属性
        /// </summary>
        /// <param name="attribute"></param>
        private void SetClassAttribute(int attribute)
        {
            if (attribute == (int)EClassAttribute.List)
            {//列表
                rdo_List.Checked = true;
            }
            else if (attribute == (int)EClassAttribute.Singl)
            {//单页面
                rdo_Singl.Checked = true;
            }
            else if (attribute == (int)EClassAttribute.Link)
            {//链接
                rdo_Link.Checked = true;
            }
            else//EClassAttribute.Cover
            {//封面
                rdo_Index.Checked = true;
            }
        }

        #region 初始化页面数据

        /// <summary>
        /// 初始化栏目类型
        /// </summary>
        private void InitClassType()
        {
        }

        /// <summary>
        /// 初始化阅读权限
        /// </summary>
        private void InitReadaccess()
        {
        }

        /// <summary>
        /// 初始化审核机制
        /// </summary>
        private void InitCheckLevel()
        {
        }

        #endregion 初始化页面数据
    }
}
