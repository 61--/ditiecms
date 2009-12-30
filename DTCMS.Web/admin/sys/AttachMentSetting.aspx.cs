using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DTCMS.BLL;
using DTCMS.Config;
using DTCMS.Common;

namespace DTCMS.Web.admin.sys
{
    public partial class AttachMentSetting : AdminPage
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
            this.hideen_dirctory.Value = GobalConfig.Directory;
            InitDirctory(this.hideen_dirctory.Value.Trim());
            this.chk_HashAbbrImage.Checked = (GobalConfig.HasAbbrImage.Trim() == "1");
            this.txt_AbbrImageWidth.Value = GobalConfig.AbbrImageWidth;
            this.txt_AbbrImageHeight.Value = GobalConfig.AbbrImageHeight;
            this.chk_HasWaterMark.Checked = GobalConfig.HasWaterMark.Trim() == "1";
            this.chk_HasAbbrImageWaterMark.Checked = GobalConfig.HasAbbrImageWaterMark == "1";
            this.txt_WaterFont.Value = GobalConfig.WaterCharater;
            this.txt_WaterFontColor.Value = GobalConfig.CharColor;
            this.slt_WaterFontType.Value = GobalConfig.FontFamilyName;
            this.txt_WaterFontSize.Value = GobalConfig.FontSize;
            this.txt_WaterImageUrl.Value = GobalConfig.WaterPicPath;
            this.txt_WaterImageUrlTran.Value = GobalConfig.Transparence;
            this.hidden_XPercent.Value = GobalConfig.XPercent;
            this.hidden_YPercent.Value = GobalConfig.YPercent;
            this.txt_ImageFormat.Value = GobalConfig.ImageFormat;
            this.txt_VidoFormat.Value = GobalConfig.VideoFormat;
            this.txt_AudioFormat.Value = GobalConfig.AudioFormat;
            this.txt_Flash.Value = GobalConfig.FlashFormat;
            this.txt_AttachmentFormat.Value = GobalConfig.AttachmentFormat;
        }

        private void SavePage()
        {
            try
            {
                GobalConfig.Directory = this.hideen_dirctory.Value.Trim();
                GobalConfig.HasAbbrImage = this.chk_HashAbbrImage.Checked ? "1" : "0";
                GobalConfig.AbbrImageWidth = this.txt_AbbrImageWidth.Value.Trim();
                GobalConfig.AbbrImageHeight = this.txt_AbbrImageHeight.Value.Trim();
                GobalConfig.HasWaterMark = this.chk_HasWaterMark.Checked ? "1" : "0";
                GobalConfig.HasAbbrImageWaterMark = this.chk_HasAbbrImageWaterMark.Checked ? "1" : "0";
                GobalConfig.WaterCharater = this.txt_WaterFont.Value.Trim();
                GobalConfig.CharColor = this.txt_WaterFontColor.Value.Trim();
                GobalConfig.FontFamilyName = this.slt_WaterFontType.Value.Trim();
                GobalConfig.FontSize = this.txt_WaterFontSize.Value.Trim();
                GobalConfig.WaterPicPath = this.txt_WaterImageUrl.Value.Trim();
                GobalConfig.Transparence = this.txt_WaterImageUrlTran.Value.Trim();
                GobalConfig.XPercent = this.hidden_XPercent.Value.Trim();
                GobalConfig.YPercent = this.hidden_YPercent.Value.Trim();
                GobalConfig.ImageFormat = this.txt_ImageFormat.Value.Trim();
                GobalConfig.VideoFormat = this.txt_VidoFormat.Value.Trim();
                GobalConfig.AudioFormat = this.txt_AudioFormat.Value.Trim();
                GobalConfig.FlashFormat = this.txt_Flash.Value.Trim();
                GobalConfig.AttachmentFormat = this.txt_AttachmentFormat.Value.Trim();
                GobalConfig.SaveXMLDocument();

                Message.Dialog("附件配置保存成功", "-1", MessageIcon.Success, 0);
            }
            catch { }
        }

        #region 初始化页面数据
        private void InitFontType()
        {
            DataTable dtFontType = SectionConfigBLL.GetSectionListTitleFontType();
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
