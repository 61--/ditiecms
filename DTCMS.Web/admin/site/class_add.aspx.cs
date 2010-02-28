using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DTCMS.Entity;
using DTCMS.Entity.Enum;
using DTCMS.BLL;
using DTCMS.Common;
using DTCMS.Config;
using DTCMS.Controls.DropDownTree;

namespace DTCMS.Web.admin
{
    public partial class Class_add : AdminPage
    {
        private Arc_ClassBLL bllClass = new Arc_ClassBLL();
        SectionConfigBLL bllSelectionConfig = new SectionConfigBLL();

        private int CID = -1;  //栏目ID

        protected void Page_Load(object sender, EventArgs e)
        {
            CID = Utils.GetQueryInt("Id");

            if (!IsPostBack)
            {
                InitPage();
                if (CID > 0)
                {
                    SetPageData();  //更新数据赋值
                }
            }
        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        private void InitPage()
        {
            InitClass();
            InitClassType();
            InitReadaccess();
            InitCheckLevel();
            InitDefaultData();
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            int updateStatus = 0;//更新是否成功
            Arc_Class modelClass = GetClassModel();

            #region 数据验证
            if (modelClass.ClassName.Trim() == "")
            {
                Message.Dialog("操作失败！栏目名称不能为空。", "-1", MessageIcon.Stop, 0);
            }
            if (bllClass.ExistsClassName(CID, modelClass.ClassName))
            {
                Message.Dialog("操作失败！该栏目已经存在。", "-1", MessageIcon.Stop, 0);
            }

            #endregion 数据验证

            if (CID > 0)
            {//修改栏目

                try
                {
                    updateStatus = bllClass.Update(modelClass);
                }
                catch
                {
                    Message.Dialog("更新栏目失败！更新栏目出现未知错误。", "-1", MessageIcon.Error, 0);
                }

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
                try
                {
                    updateStatus = bllClass.Add(modelClass);
                }
                catch
                {
                    Message.Dialog("添加栏目失败！添加栏目出现未知次错误。", "-1", MessageIcon.Error, 0);
                }

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
                slt_ParentClassName.SelectedIndex=slt_ParentClassName.Items.IndexOf(slt_ParentClassName.Items.FindByValue(model.CID.ToString()));
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
                txt_Content.Value = model.ClassContent;
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
            model.ParentID = Convert.ToInt32(slt_ParentClassName.Value);
            model.Attribute = GetClassAttribute();
            model.ClassName = txt_ClassName.Value;
            model.ClassEName = txt_ClassEName.Value.Trim();
            model.ClassType = Convert.ToByte(slt_ClassType.Value.Trim());
            model.ClassDomain = txt_ClassDomain.Value.Trim();
            model.ClassPath = txt_ClassPath.Value.Trim();
            model.IndexTemplet = txt_IndexTemplet.Value.Trim();
            model.ListTemplet = txt_ListTemplet.Value.Trim();
            model.ArchiveTemplet = txt_ArchiveTemplet.Value.Trim();
            model.IndexRule = txt_IndexRule.Value.Trim();
            model.ListRule = txt_ListRule.Value.Trim();
            model.ArchiveRule = txt_ArchiveRule.Value.Trim();
            model.ClassPage = Convert.ToByte(txt_ClassPage.Value.Trim());
            model.Description = txt_Description.Value.Trim();
            model.IsHidden = (byte)(chk_ISHiden.Checked ? 1 : 0);
            model.IsHtml = (byte)(chk_ISHtml.Checked ? 1 : 0);
            model.CheckLevel = Convert.ToByte(slt_CheckLevel.Value.Trim());
            model.IsContribute = (byte)(chk_ISContribute.Checked ? 1 : 0);
            model.IsComment = (byte)(chk_ISComment.Checked ? 1 : 0);
            model.Readaccess = Convert.ToInt32(slt_Readaccess.Value.Trim());
            model.SiteID = 1;//站点ID，默认1
            model.AddDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            if (model.ParentID == 0)
            {
                model.Relation = "." + model.ParentID.ToString() + ".";
            }
            else
            {
                model.Relation = bllClass.GetRelation(model.ParentID) + model.ParentID + ".";
            }

            model.OrderID = Convert.ToInt32(txt_OrderID.Value.Trim());
            model.ImgUrl = txt_ImgUrl.Value.Trim();
            model.Keywords = txt_Keywords.Value.Trim();
            model.CrossID = txt_CorssID.Value.Trim();
            model.ClassContent = txt_Content.Value.Trim();

            return model;
        }

        /// <summary>
        /// 获取栏目属性
        /// </summary>
        /// <returns></returns>
        private byte GetClassAttribute()
        {
            if (rdo_List.Checked)
            {//列表
                return (byte)EClassAttribute.List;
            }
            else if (rdo_Singl.Checked)
            {//单页面
                return (byte)EClassAttribute.Singl;
            }
            else if (rdo_Link.Checked)
            {//链接
                return (byte)EClassAttribute.Link;
            }
            else//rdo_Index.Checked
            {//封面
                return (byte)EClassAttribute.Cover;
            }

        }

        /// <summary>
        /// 设置栏目属性
        /// </summary>
        /// <param name="attribute"></param>
        private void SetClassAttribute(int attribute)
        {
            rdo_List.Checked = false;
            rdo_Singl.Checked = false;
            rdo_Link.Checked = false;
            rdo_Index.Checked = false;

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
        /// 初始化栏目
        /// </summary>
        private void InitClass()
        {
            DataTable dtClass=bllClass.GetDropList("");
            DropDownTree.BindToDropDownList(slt_ParentClassName, dtClass, "0");
        }
        /// <summary>
        /// 初始化栏目类型
        /// </summary>
        private void InitClassType()
        {
            DataTable dtTypeList = bllSelectionConfig.GetSectionListClassType();
            if (dtTypeList != null && dtTypeList.Rows.Count > 0)
            {
                slt_ClassType.DataSource = dtTypeList;
                slt_ClassType.DataTextField = "value";
                slt_ClassType.DataValueField = "key";
                slt_ClassType.DataBind();
            }
        }

        /// <summary>
        /// 初始化阅读权限
        /// </summary>
        private void InitReadaccess()
        {
            DataTable dtReadaccess = bllSelectionConfig.GetSectionListReadaccess();
            if (dtReadaccess != null && dtReadaccess.Rows.Count > 0)
            {
                slt_Readaccess.DataSource = dtReadaccess;
                slt_Readaccess.DataTextField = "value";
                slt_Readaccess.DataValueField = "key";
                slt_Readaccess.DataBind();
            }
        }

        /// <summary>
        /// 初始化审核机制
        /// </summary>
        private void InitCheckLevel()
        {
            DataTable dtCheckLevel = bllSelectionConfig.GetSectionListCheckLevel();
            if (dtCheckLevel != null && dtCheckLevel.Rows.Count > 0)
            {
                slt_CheckLevel.DataSource = dtCheckLevel;
                slt_CheckLevel.DataTextField = "value";
                slt_CheckLevel.DataValueField = "key";
                slt_CheckLevel.DataBind();
            }

        }

        /// <summary>
        /// 默认设置
        /// </summary>
        private void InitDefaultData()
        {
            SystemConfig sysConfig = GobalConfig.GetCobalInstance().LoadGoableConfig();

            txt_ClassPath.Value = sysConfig.SysInfoParams.ClassPath.Trim();
            slt_CheckLevel.SelectedIndex = slt_CheckLevel.Items.IndexOf(slt_CheckLevel.Items.FindByValue(sysConfig.SysInfoParams.CheckLevel));
            txt_IndexTemplet.Value = sysConfig.SysInfoParams.IndexTemplet.Trim();
            txt_ListTemplet.Value = sysConfig.SysInfoParams.ListTemplet.Trim();
            txt_ArchiveTemplet.Value = sysConfig.SysInfoParams.ArchiveTemplet.Trim();
            txt_IndexRule.Value = sysConfig.SysInfoParams.IndexRule.Trim();
            txt_ListRule.Value = sysConfig.SysInfoParams.ListRule.Trim();
            txt_ArchiveRule.Value = sysConfig.SysInfoParams.ArchiveRule.Trim();
            txt_Keywords.Value = sysConfig.SysInfoParams.MetaKey.Trim();
            txt_Description.Value = sysConfig.SysInfoParams.MetaDescription.Trim();
        }

        #endregion 初始化页面数据
    }
}
