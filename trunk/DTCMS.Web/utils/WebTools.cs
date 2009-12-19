using System;
using System.Collections.Generic;
using System.Web;
using System.Collections;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;
using DTCMS.Common;

namespace DTCMS.Web.Utils
{
    public class WebTools
    {
        
        #region 获取静态数
        private static StringBuilder sbDTreeNode = new StringBuilder();

        /// <summary>
        /// 获取静态树
        /// </summary>
        /// <param name="dtTreeSource">数据源</param>
        /// <param name="parentField">父ID字段名</param>
        /// <param name="parentID">父ID</param>
        /// <param name="DisplayFieldName">显示字段</param>
        /// <param name="ValueFieldName">值字段</param>
        /// <param name="UrlOrClick">访问URL或click事件</param>
        /// <param name="target">target</param>
        /// <param name="rootPath">JS根目录</param>
        /// <returns></returns>
        public static string GetStaticDTree(DataTable dtTreeSource, string parentField, int parentID,
            string displayFieldName, string valueFieldName, string urlOrClick, string target,
            string icon, string iconOpen,string open,string rootPath)
        {
            WriteStaticDTree(dtTreeSource, parentField, parentID, displayFieldName, valueFieldName, urlOrClick, target,icon,iconOpen,open);
            if (sbDTreeNode.ToString() != "")
            {
                return ReadStaticDTTree(rootPath);
            }
            else
            {
                return "";
            }

        }
        
        /// <summary>
        /// 获取静态树
        /// </summary>
        /// <param name="rootPath">JS根目录</param>
        /// <returns></returns>
        public static string ReadStaticDTTree(string rootPath)
        {
            StringBuilder iBuf = new StringBuilder();
            iBuf.Append("<script type=text/javascript>");
            iBuf.Append("column = new dTree(\"column\", \"" + rootPath + "/\");");
            iBuf.Append("column.add(0,-1,\"全部\");");
            iBuf.Append(sbDTreeNode.ToString());
            iBuf.Append("document.write(column)");
            iBuf.Append("</script>");
            sbDTreeNode.Remove(0, sbDTreeNode.Length);
            return iBuf.ToString();
        }

        /// <summary>
        /// 设置静态树,生成节点
        /// </summary>
        /// <param name="dtTreeSource">数据源</param>
        /// <param name="parentField">父ID字段名</param>
        /// <param name="parentID">父ID</param>
        /// <param name="DisplayFieldName">显示字段</param>
        /// <param name="ValueFieldName">值字段</param>
        /// <param name="UrlOrClick">访问URL或click事件</param>
        /// <param name="target">target</param>
        public static void WriteStaticDTree(DataTable dtTreeSource, string parentField, int parentID,
            string DisplayFieldName, string ValueFieldName, string UrlOrClick, string target,string icon, string iconOpen,string open)
        {
            if (parentField != "" && dtTreeSource != null && dtTreeSource.Rows.Count > 0 &&
                DisplayFieldName!="" && ValueFieldName!="")
            {
                string where = "";
                if (parentID < 0)
                {
                    where = string.Format("{0}={1}", parentField, 0);
                }
                else
                {
                    where = string.Format("{0}={1}", parentField, parentID);
                }

                DataRow[] drNews = dtTreeSource.Select(where);

                for (int i = 0; i < drNews.Length; i++)
                {
                    try
                    {
                        string iID = drNews[i]["ID"] != null ? drNews[i]["ID"].ToString() : "";
                        string iParentField = drNews[i][parentField] != null ? drNews[i][parentField].ToString() : "";
                        string iDisplayFieldNmae = drNews[i][DisplayFieldName] != null ? drNews[i][DisplayFieldName].ToString() : "";
                        string iValueFieldName = drNews[i][ValueFieldName] != null ? drNews[i][ValueFieldName].ToString() : "";


                        if (UrlOrClick.ToUpper().IndexOf("JAVASCRIPT:") > -1)
                        {//click事件
                            sbDTreeNode.Append(string.Format("column.add({0},{1},\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\");",
                                iID, iParentField, iDisplayFieldNmae, string.Format(UrlOrClick, iValueFieldName), "", target, icon, iconOpen, open));
                        }
                        else
                        { //输入URL
                            sbDTreeNode.Append(string.Format("column.add({0},{1},\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\");",
                            iID, iParentField,
                            iDisplayFieldNmae, UrlOrClick + "?id=" + iValueFieldName, "", target, icon, iconOpen, open));
                        }

                    }
                    catch
                    {
                        sbDTreeNode.Remove(0, sbDTreeNode.Length);
                        break;
                    }

                    if (drNews[i][parentField] != null)
                    {
                        WriteStaticDTree(dtTreeSource, parentField, Convert.ToInt32(drNews[i]["ID"]), DisplayFieldName, ValueFieldName, UrlOrClick, target, icon, iconOpen, open);
                    }
                }
            }
        }

        #endregion
    }
}
