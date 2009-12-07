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
using System.Text;
using DTCMS.Common;
using DTCMS.BLL;
namespace DTCMS.Web.admin.ajax
{
    public partial class class_list : System.Web.UI.Page
    {
        private Arc_ClassBLL bllClass = new Arc_ClassBLL();     //栏目
        private Arc_ArticleBLL bllArticle = new Arc_ArticleBLL();   //文章

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action");
            switch (action)
            {
                case "load":
                    Response.Write(GetClassListJson());
                    break;
                case "delete":
                    Response.Write(Delete());
                    break;
                case "order":
                    Response.Write(UpdateOrder().ToString());
                    break;
                default:
                    break;

            }
            

        }
        /// <summary>
        /// 获取栏目累表
        /// </summary>
        /// <returns>json对象</returns>
        public string GetClassListJson()
        {
            return bllClass.GetDataTableJoson();
        }

        /// <summary>
        /// 删除栏目
        /// </summary>
        /// <returns>cid为空返回：-1，成功返回：1，失败返回：0，存在子栏目返回：2,存在文章返回，3</returns>
        public string Delete()
        {
            try
            {
                string id = Common.Utils.GetQueryString("Id");
                if (id == "")
                {
                    return "请选择你要删除的栏目！";
                }
                string[] cid = id.Split(',');

                //判断是否存在子栏目,是否存在文章
                for (int i = 0; i < cid.Length; i++)
                {
                    if (bllClass.ExistsChildNode(int.Parse(cid[i])))
                    {//存在子栏目
                        return "该栏目存在子栏目，请先删除子栏目！";
                    }
                    if (bllArticle.ExistAtricleToClass(int.Parse(cid[i])))
                    {//存在文章
                        return "该栏目下存在文章，请先删除文章！";
                    }
                }

                if (bllClass.Delete(id) > 0)
                {
                    return "True";
                }
                else
                {
                    return "栏目删除失败！";
                }
            }
            catch
            {
                return "删除栏目出现未知错误！";
            }

        }

        /// <summary>
        /// 更新栏目排序
        /// </summary>
        /// <returns>成功返回影响行数，异常返回-1，失败返回0</returns>
        public int UpdateOrder()
        {
            try
            {
                int id = int.Parse(Common.Utils.GetQueryString("Id"));
                int orderId = int.Parse(Common.Utils.GetQueryString("orderId"));

                return bllClass.UpdateOrder(id, orderId);
            }
            catch
            {
                return -1;
            }
        }
    }

}