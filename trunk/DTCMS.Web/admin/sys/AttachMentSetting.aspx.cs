using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DTCMS.BLL;

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
        private void InitPage()
        {
            InitFontType();
        }

        #region 初始化页面数据
        private void InitFontType()
        {
            DataTable dtFontType=SectionConfigBLL.GetSectionListTitleFontType();
            if(dtFontType!=null && dtFontType.Rows.Count>0){
                slt_WaterFontType.DataSource = dtFontType;
                slt_WaterFontType.DataTextField = "value";
                slt_WaterFontType.DataValueField = "key";
                slt_WaterFontType.DataBind();
            }
        }
        #endregion 初始化页面数据
    }
}
