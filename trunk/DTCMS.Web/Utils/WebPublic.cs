using System;
using System.Collections.Generic;
using System.Web;
using System.Collections;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

namespace DTCMS.Web.Utils
{
    public class WebPublic
    {
        /// <summary>
        /// 获取动态树
        /// </summary>
        /// <param name="dtTreeSource">数据源</param>
        /// <param name="PNodes">父节点</param>
        /// <param name="parentField">父ID字段名</param>
        /// <param name="parentID">父ID</param>
        /// <param name="DisplayFieldName">显示字段</param>
        /// <param name="ValueFieldName">值字段</param>
        public static void WriteDynTree(DataTable dtTreeSource, TreeNode PNodes, string parentField,
            int parentID, string DisplayFieldName, string ValueFieldName)
        {
            if (parentField != "")
            {
                if (dtTreeSource != null && dtTreeSource.Rows.Count > 0)
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
                        TreeNode CNode = new TreeNode();
                        CNode.Text = drNews[i][DisplayFieldName].ToString();
                        CNode.Value = drNews[i][ValueFieldName].ToString();
                        PNodes.ChildNodes.Add(CNode);

                        if (drNews[i][parentField] != null)
                        {
                            WriteDynTree(dtTreeSource, CNode, parentField, Convert.ToInt32(drNews[i]["ID"]), DisplayFieldName, ValueFieldName);
                        }
                    }
                }
            }
        }

        #region 获取静态数
        private static StringBuilder sbDTree = new StringBuilder();
        
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
            iBuf.Append(sbDTree.ToString());
            iBuf.Append("document.write(column)");
            iBuf.Append("</script>");
            sbDTree.Remove(0, sbDTree.Length);
            return iBuf.ToString();
        }

       /// <summary>
       /// 设置静态树
       /// </summary>
       /// <param name="dtTreeSource">数据源</param>
       /// <param name="parentField">父ID字段名</param>
       /// <param name="parentID">父ID</param>
       /// <param name="DisplayFieldName">显示字段</param>
       /// <param name="ValueFieldName">值字段</param>
       /// <param name="URL">访问URL</param>
        public static void WriteStaticDTree(DataTable dtTreeSource, string parentField, int parentID,
            string DisplayFieldName, string ValueFieldName, string URL)
        {
            if (parentField != "")
            {
                if (dtTreeSource != null && dtTreeSource.Rows.Count > 0)
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
                        sbDTree.Append(string.Format("column.add({0},{1},\"{2}\",\"{3}\",\"{4}\",\"{5}\");",
                            drNews[i]["ID"].ToString(), drNews[i][parentField].ToString(),
                            drNews[i][DisplayFieldName].ToString(), URL, "", "mainFrame"));

                        if (drNews[i][parentField] != null)
                        {
                            WriteStaticDTree(dtTreeSource, parentField, Convert.ToInt32(drNews[i]["ID"]), DisplayFieldName, ValueFieldName, URL);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
