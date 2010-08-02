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
    public partial class attchment_setting : AdminPage
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitPage();
            }
        }
        protected void btn_Save_Click(object sender, EventArgs e)
        {
            SavePage();
        }
        private void InitPage()
        {
            InitFontType();
            SystemConfig sysConfig = CMSConfig.GetCobalInstance().LoadGoableConfig();

            this.hideen_dirctory.Value = sysConfig.Attachments.Directory;
            InitDirctory(this.hideen_dirctory.Value.Trim());
            this.chk_HashAbbrImage.Checked = (sysConfig.Attachments.HasAbbrImage.Trim() == "1");
            this.txt_AbbrImageWidth.Value = sysConfig.Attachments.AbbrImageWidth;
            this.txt_AbbrImageHeight.Value = sysConfig.Attachments.AbbrImageHeight;
            this.chk_HasWaterMark.Checked = sysConfig.Attachments.HasWaterMark.Trim() == "1";
            this.chk_HasAbbrImageWaterMark.Checked = sysConfig.Attachments.HasAbbrImageWaterMark == "1";
            this.txt_WaterFont.Value = sysConfig.Attachments.WaterImages.WaterCharater;
            this.txt_WaterFontColor.Value = sysConfig.Attachments.WaterImages.CharColor;
            this.slt_WaterFontType.Value = sysConfig.Attachments.WaterImages.FontFamilyName;
            this.txt_WaterFontSize.Value = sysConfig.Attachments.WaterImages.FontSize;
            this.txt_WaterImageUrl.Value = sysConfig.Attachments.WaterImages.WaterPicPath;
            this.txt_WaterImageUrlTran.Value = sysConfig.Attachments.WaterImages.Transparence;
            this.hidden_XPercent.Value = sysConfig.Attachments.WaterImages.XPercent;
            this.hidden_YPercent.Value = sysConfig.Attachments.WaterImages.YPercent;
            this.txt_ImageFormat.Value = sysConfig.Attachments.ImageFormat;
            this.txt_VidoFormat.Value = sysConfig.Attachments.VideoFormat;
            this.txt_AudioFormat.Value = sysConfig.Attachments.AudioFormat;
            this.txt_Flash.Value = sysConfig.Attachments.FlashFormat;
            this.txt_AttachmentFormat.Value = sysConfig.Attachments.AttachmentFormat;
        }

        private void SavePage()
        {
            try
            {
                SystemConfig sysConfig = CMSConfig.GetCobalInstance().LoadGoableConfig();

                sysConfig.Attachments.Directory = this.hideen_dirctory.Value.Trim();
                sysConfig.Attachments.HasAbbrImage = this.chk_HashAbbrImage.Checked ? "1" : "0";
                sysConfig.Attachments.AbbrImageWidth = this.txt_AbbrImageWidth.Value.Trim();
                sysConfig.Attachments.AbbrImageHeight = this.txt_AbbrImageHeight.Value.Trim();
                sysConfig.Attachments.HasWaterMark = this.chk_HasWaterMark.Checked ? "1" : "0";
                sysConfig.Attachments.HasAbbrImageWaterMark = this.chk_HasAbbrImageWaterMark.Checked ? "1" : "0";
                sysConfig.Attachments.WaterImages.WaterCharater = this.txt_WaterFont.Value.Trim();
                sysConfig.Attachments.WaterImages.CharColor = this.txt_WaterFontColor.Value.Trim();
                sysConfig.Attachments.WaterImages.FontFamilyName = this.slt_WaterFontType.Value.Trim();
                sysConfig.Attachments.WaterImages.FontSize = this.txt_WaterFontSize.Value.Trim();
                sysConfig.Attachments.WaterImages.WaterPicPath = this.txt_WaterImageUrl.Value.Trim();
                sysConfig.Attachments.WaterImages.Transparence = this.txt_WaterImageUrlTran.Value.Trim();
                sysConfig.Attachments.WaterImages.XPercent = this.hidden_XPercent.Value.Trim();
                sysConfig.Attachments.WaterImages.YPercent = this.hidden_YPercent.Value.Trim();
                sysConfig.Attachments.ImageFormat = this.txt_ImageFormat.Value.Trim();
                sysConfig.Attachments.VideoFormat = this.txt_VidoFormat.Value.Trim();
                sysConfig.Attachments.AudioFormat = this.txt_AudioFormat.Value.Trim();
                sysConfig.Attachments.FlashFormat = this.txt_Flash.Value.Trim();
                sysConfig.Attachments.AttachmentFormat = this.txt_AttachmentFormat.Value.Trim();

                CMSConfig.GetCobalInstance().SaveGobalConfig(sysConfig);

                Message.Dialog("附件配置保存成功", "-1", MessageIcon.Success, 0);
            }
            catch { }
        }

        #region 初始化页面数据
        private void InitFontType()
        {
            SectionConfigBLL bllSelectionConfig = new SectionConfigBLL();
            DataTable dtFontType = bllSelectionConfig.GetSectionListTitleFontType();
            if (dtFontType != null && dtFontType.Rows.Count > 0)
            {
                slt_WaterFontType.DataSource = dtFontType;
                slt_WaterFontType.DataTextField = "value";
                slt_WaterFontType.DataValueField = "key";
                slt_WaterFontType.DataBind();
            }
        }

        private void InitDirctory(string dirctory)
        {
            switch (dirctory)
            {
                case "yyyy":
                    rdo_y.Checked = true;
                    break;
                case "yyyyMM":
                    rdo_ym.Checked = true;
                    break;
                case "yyyyMMdd":
                    rdo_ymd.Checked = true;
                    break;
                default:
                    rdo_ymd.Checked = true;
                    break;
            }
        }
        #endregion 初始化页面数据


    }
}
