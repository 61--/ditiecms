using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tuan.Common;
using Tuan.Config;
using Tuan.Entity;
using Tuan.Entity.Config;
using Tuan.Data.DAO;

namespace Tuan.Web.user
{
    public partial class site_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                if (txt_UserName.Text == "")
                {
                    JScript.ShowMessage(this, "请先登陆！");
                }
                else
                {
                    CheckUser();
                }
            }
        }

        protected string GetAllCity()
        {
            ModelList cityList = CityDAO.Instance.GetCityList();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cityList.Count; i++)
            {
                sb.AppendFormat("<option value=\"{0}\">0{0} - {1}</option>", cityList[i]["CityID"], cityList[i]["City"]);
            }
            return sb.ToString();
        }

        protected void btn_AddSite_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                if (txt_UserName.Text == "")
                {
                    JScript.ShowMessage(this, "请先登陆！");
                    return;
                }
                else
                {
                    CheckUser();
                }
            }
            TuanSite model = new TuanSite();
            model.UserID = TryConvert.ToInt32(Session["User"]);
            model.CityID = Utils.GetFormInt("ddl_City");
            model.SiteName = txt_SiteName.Value;
            model.SiteUrl = txt_SiteUrl.Value;
            if (model.SiteUrl.EndsWith("/"))
            {
                model.SiteUrl = model.SiteUrl.TrimEnd('/');
            }
            model.LogoUrl = txt_LogoUrl.Value;
            model.ApiUrl = txt_ApiUrl.Value;
            model.QQ = txt_QQ.Value;
            model.SiteType = rdb_SiteType_1.Checked == true ? (byte)1 : (byte)0;
            model.Rank = TryConvert.ToByte(txt_Rank.Value);
            model.Trust = TryConvert.ToByte(txt_Trust.Value);

            model.Description = string.Empty;
            model.Master = string.Empty;
            model.ContactPerson = string.Empty;
            model.Phone = string.Empty;
            model.Email = string.Empty;
            model.OpenDate = DateTime.Now;
            model.AddDate = DateTime.Now;
            model.IsVerify = (byte)1;

            int ret = TuanSiteDAO.Instance.Add(model);
            if (ret > 0)
            {
                JScript.ShowMessage(this, "添加成功！");
            }
            else
            {
                JScript.ShowMessage(this, "添加失败！");
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            CheckUser();
        }

        private void CheckUser()
        {
            if (txt_UserName.Text != "linpanxing" && txt_UserName.Text != "luwenhao")
            {
                JScript.ShowMessage(this, "用户名或密码错误！");
                return;
            }
            else
            {
                Session["User"] = txt_UserName.Text == "linpanxing" ? 1 : 2;
            }
        }
    }
}
