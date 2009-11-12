using System;
using System.Collections.Generic;
using System.Web;
using System.Collections;
using System.Data;
using System.Web.UI.WebControls;
using System.Text;

namespace DTCMS.Web
{
    public class test
    {
        public static void GetTree(DataTable dtTreeSource,TreeNode PNodes ,string parentField,
            int parentID,string DisplayFieldName,string ValueFieldName)
        {
            if (parentField != "")
            {
                if (dtTreeSource != null && dtTreeSource.Rows.Count > 0)
                {
                    string where = "";
                    if (parentID<0)
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
                        /*=================效果===============================*/

                        TreeNode CNode = new TreeNode();
                        CNode.Text = drNews[i][DisplayFieldName].ToString();
                        CNode.Value = drNews[i][ValueFieldName].ToString();
                        PNodes.ChildNodes.Add(CNode);
          
                        /*=================效果=结束==============================*/
                        if (drNews[i][parentField] != null)
                        {
                            GetTree(dtTreeSource, CNode, parentField, Convert.ToInt32(drNews[i]["ID"]), DisplayFieldName, ValueFieldName);
                        }
                    }
                }
            }
        }
        private static StringBuilder sbDTree = new StringBuilder();

        public static string ReadDTTree()
        {
            StringBuilder iBuf = new StringBuilder();
            iBuf.Append("<script type=text/javascript>");
            iBuf.Append("column = new dTree(\"column\", \"dtree/\");");
            iBuf.Append("column.add(0,-1,\"全部\");");
            iBuf.Append(sbDTree.ToString());
            iBuf.Append("document.write(column)");
            iBuf.Append("</script>");
            return iBuf.ToString();
        }

        public static void WriteDTree(DataTable dtTreeSource, string parentField, int parentID, 
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
                    /*=================构造树=============*/
                    for (int i = 0; i < drNews.Length; i++)
                    {
                        sbDTree.Append(string.Format("column.add({0},{1},\"{2}\",\"{3}\",\"{4}\",\"{5}\");",
                            drNews[i]["ID"].ToString(),drNews[i][parentField].ToString(),
                            drNews[i][DisplayFieldName].ToString(), URL, "", "mainFrame"));
                        
                        if (drNews[i][parentField] != null)
                        {
                            WriteDTree(dtTreeSource, parentField, Convert.ToInt32(drNews[i]["ID"]), DisplayFieldName, ValueFieldName,URL);
                        }
                    }/*=================构造树=结束===========*/
                }
            }
        }
    }
}
