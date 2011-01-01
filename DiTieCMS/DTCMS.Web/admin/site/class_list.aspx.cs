using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.Common;
using DTCMS.BLL;
using DTCMS.Entity.Enum;

namespace DTCMS.Web.admin
{
    public partial class Class_list : AdminPage
    {
        private Arc_ClassBLL classBll = new Arc_ClassBLL();
        private Arc_ArticleBLL articleBll = new Arc_ArticleBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(Class_list));
        }

        #region Ajax 方法
        /// <summary>
        /// 获取栏目列表
        /// </summary>
        [AjaxPro.AjaxMethod]
        public string GetClassListToJson()
        {
            return classBll.GetClassListToJson();
        }

        /// <summary>
        /// 删除栏目
        /// </summary>
        [AjaxPro.AjaxMethod]
        public string DeleteClass(string id)
        {
            try
            {
                string[] cid = id.Split(',');

                for (int i = 0; i < cid.Length; i++)    //判断栏目是否存在子栏目或存在文章
                {
                    if (classBll.ExistsChildNode(int.Parse(cid[i])))
                    {
                        //存在子栏目
                        return "栏目包含子栏目，请先删除子栏目！";
                    }
                    if (articleBll.ExistAtricleToClass(int.Parse(cid[i])))
                    {
                        //存在文章
                        return "栏目下存在文章，请先删除文章！";
                    }
                }

                if (classBll.Delete(id) > 0)
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
        #endregion
    }
}
