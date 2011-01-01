using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DTCMS.BLL;
using DTCMS.Config;
using DTCMS.Common;
using DTCMS.Entity;

namespace DTCMS.Web.admin.sys
{
    public partial class base_setting : AdminPage
    {
        SectionConfigBLL bllSelectionConfig = new SectionConfigBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitPage();
            }
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            SavePage();
        }

        private void InitPage()
        {
            InitCheckLevel();
            SystemConfig sysConfig = CMSConfig.GetInstance().LoadConfig();

            txt_SiteName.Value = sysConfig.SysInfoParams.SiteName.Trim();
            txt_SiteDomain.Value = sysConfig.SysInfoParams.SiteDomain.Trim();
            txt_HomeTemplet.Value = sysConfig.SysInfoParams.HomeTemplet.Trim();
            txt_HomeUrl.Value = sysConfig.SysInfoParams.HomeUrl.Trim();
            txt_HomeName.Value = sysConfig.SysInfoParams.HomeName.Trim();

            txt_ClassPath.Value = sysConfig.SysInfoParams.ClassPath.Trim();
            txt_IndexTemplet.Value = sysConfig.SysInfoParams.IndexTemplet.Trim();
            txt_ListTemplet.Value = sysConfig.SysInfoParams.ListTemplet.Trim();
            txt_ArchiveTemplet.Value = sysConfig.SysInfoParams.ArchiveTemplet.Trim();
            txt_IndexRule.Value = sysConfig.SysInfoParams.IndexRule.Trim();
            txt_ListRule.Value = sysConfig.SysInfoParams.ListRule.Trim();
            txt_ArchiveRule.Value = sysConfig.SysInfoParams.ArchiveRule.Trim();

            txt_Keywords.Value = sysConfig.SysInfoParams.MetaKey.Trim();
            txt_Description.Value = sysConfig.SysInfoParams.MetaDescription.Trim();
            txt_SiteCopyRightInfo.Value = sysConfig.SysInfoParams.SiteCopyRightInfo.Trim();
            txt_RecordNo.Value = sysConfig.SysInfoParams.RecordNo.Trim();
            txt_AdminEmail.Value = sysConfig.SysInfoParams.AdminEmail.Trim();
            txt_DefaultTemplet.Value = sysConfig.SysInfoParams.DefaultTemplet.Trim();
            slt_CheckLevel.SelectedIndex = slt_CheckLevel.Items.IndexOf(slt_CheckLevel.Items.FindByValue(sysConfig.SysInfoParams.CheckLevel));
            hidden_LoginValidate.Value = sysConfig.SysInfoParams.LoginValidate.Trim();            
            if (hidden_LoginValidate.Value.ToString() == "1")
            {
                rdo_yes.Checked = true;
            }
            else
            {
                rdo_no.Checked = true;
            }
        }

        private void SavePage()
        {
            SystemConfig sysConfig = CMSConfig.GetInstance().LoadConfig();

            sysConfig.SysInfoParams.SiteName = txt_SiteName.Value.Trim();
            sysConfig.SysInfoParams.SiteDomain = txt_SiteDomain.Value.Trim();
            sysConfig.SysInfoParams.HomeTemplet = txt_HomeTemplet.Value.Trim();
            sysConfig.SysInfoParams.HomeUrl = txt_HomeUrl.Value.Trim();
            sysConfig.SysInfoParams.HomeName = txt_HomeName.Value.Trim();

            sysConfig.SysInfoParams.ClassPath = txt_ClassPath.Value.Trim();
            sysConfig.SysInfoParams.IndexTemplet = txt_IndexTemplet.Value;
            sysConfig.SysInfoParams.ListTemplet=txt_ListTemplet.Value.Trim();
            sysConfig.SysInfoParams.ArchiveTemplet=txt_ArchiveTemplet.Value.Trim();
            sysConfig.SysInfoParams.IndexRule=txt_IndexRule.Value.Trim();
            sysConfig.SysInfoParams.ListRule=txt_ListRule.Value.Trim();
            sysConfig.SysInfoParams.ArchiveRule=txt_ArchiveRule.Value.Trim();

            sysConfig.SysInfoParams.MetaKey=txt_Keywords.Value.Trim();
            sysConfig.SysInfoParams.MetaDescription=txt_Description.Value.Trim();
            sysConfig.SysInfoParams.SiteCopyRightInfo=txt_SiteCopyRightInfo.Value.Trim();
            sysConfig.SysInfoParams.RecordNo=txt_RecordNo.Value.Trim();
            sysConfig.SysInfoParams.AdminEmail=txt_AdminEmail.Value.Trim();
            sysConfig.SysInfoParams.DefaultTemplet=txt_DefaultTemplet.Value.Trim();
            sysConfig.SysInfoParams.CheckLevel=slt_CheckLevel.Value.Trim();
            sysConfig.SysInfoParams.LoginValidate=hidden_LoginValidate.Value.Trim();

            CMSConfig.GetInstance().SaveGobalConfig(sysConfig);
            Message.Dialog("系统配置保存成功", "-1", MessageIcon.Success, 0);
        }

        #region 初始化页面数据
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
        #endregion 初始化页面数据
    }
}
