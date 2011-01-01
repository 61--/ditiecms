using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.Common;
using DTCMS.Entity;
using DTCMS.BLL;

namespace DTCMS.Web.admin
{
    public partial class AjaxTest : System.Web.UI.Page
    {
        public string action;
        public int myid;
        private ModulesBLL modulesBll = new ModulesBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(AjaxTest));
            action = Request.QueryString["action"];
            myid = int.Parse(Request.QueryString["id"]);

            Modules mo = new Modules();
            mo = modulesBll.GetModel(myid);
            txt_ID.Value= mo.ModuleID;
            txt_PID.Value= mo.ParentID;
            txt_Name.Value= mo.ModuleName;
            txt_EName.Value= mo.EName;
            txt_Deep.Value= mo.ModuleDepth.ToString();
            txt_URL.Value= mo.ModuleURL;
            txt_Description.Value= mo.Description;
            txt_OrderID.Value= mo.OrderID.ToString();           
        }

        [AjaxPro.AjaxMethod]
        public int Add(string id, string pid, string Name, string EName, int Deep, string URL, string description, int orderID)
        {
            Modules mo = new Modules();
            mo.ModuleID = id;
            mo.ParentID = pid;
            mo.ModuleName = Name;
            mo.EName = EName;
            mo.ModuleDepth = (byte)Deep;
            mo.ModuleURL = URL;
            mo.Description = description;
            mo.OrderID = orderID;

            mo.CreateTime = DateTime.Now;
            mo.IsEnable = 1;
            mo.IsQuickMenu = 0;
            mo.IsSystem = 1;
            mo.Target = "main_body";
            
            try
            {
                return modulesBll.Add(mo);
            }
            catch
            {

                return -1;
            }
        }

        /// <summary>
        /// 编辑用户角色
        /// </summary>
        /// <returns>成功返回1，失败返回-1</returns>
        [AjaxPro.AjaxMethod]
        public int Edit(int mid,string id, string pid, string Name, string EName, int Deep, string URL, string description, int orderID)
        {
            Modules mo = new Modules();
            mo.ID = mid;
            mo.ModuleID = id;
            mo.ParentID = pid;
            mo.ModuleName = Name;
            mo.EName = EName;
            mo.ModuleDepth = (byte)Deep;
            mo.ModuleURL = URL;
            mo.Description = description;
            mo.OrderID = orderID;

            mo.CreateTime = DateTime.Now;
            mo.IsEnable = 1;
            mo.IsQuickMenu = 0;
            mo.IsSystem = 1;
            mo.Target = "main_body";

            try
            {
                return modulesBll.Update(mo);
            }
            catch
            {

                return -1;
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            modulesBll.Delete(myid);
        }
    }
}
