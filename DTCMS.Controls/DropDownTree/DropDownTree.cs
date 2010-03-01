using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace DTCMS.Controls.DropDownTree
{
    public sealed class DropDownTree
    {
        public static void BindToDropDownList(HtmlSelect htmlSelect, DataTable dt, string parentID)
        {

            string currentID = parentID;    //根节点/父ID
            string currentSign = string.Empty;  //当前节点符号;
            string parrentSign = string.Empty;  //父节点符号;
            bool hasChild = true;   //是否有子节点

            Queue<string> childKeyList = new Queue<string>();   //存有子节点的节点ID
            Queue<string> childSignList = new Queue<string>();  //对应节点ID的前缀符号
            ListItem listItem = null;

            int itemIndexOf = 0;    //父节点所在的位置　
            if (dt != null)
            {
                while (hasChild)
                {
                    int lastOneCount = 0;
                    DataRow[] dr = GetChildDataTable(dt, currentID);

                    if (dr != null && dr.Length > 0)
                    {
                        foreach (DataRow row in dr)
                        {
                            lastOneCount++;
                            if (GetChildDataTable(dt, row["ID"].ToString()).Length > 0)
                            {
                                currentSign = GetPreFix(lastOneCount == dr.Length, true, parrentSign);
                                listItem = new ListItem(currentSign + row["NAME"].ToString(), row["ID"].ToString());
                                childKeyList.Enqueue(row["ID"].ToString());
                                childSignList.Enqueue(currentSign);
                            }
                            else
                            {
                                currentSign = GetPreFix(lastOneCount == dr.Length, false, parrentSign);
                                listItem = new ListItem(currentSign + row["NAME"].ToString(), row["ID"].ToString());
                            }

                            if (htmlSelect.Items.Count != 0)
                            {
                                itemIndexOf = string.IsNullOrEmpty(currentID) ? itemIndexOf + 1 : htmlSelect.Items.IndexOf(htmlSelect.Items.FindByValue(currentID)) + lastOneCount;
                            }

                            htmlSelect.Items.Insert(itemIndexOf, listItem);
                        }

                        if (childKeyList.Count > 0)
                        {
                            currentID = childKeyList.Dequeue();
                            parrentSign = childSignList.Dequeue();
                        }
                        else
                        {
                            hasChild = false;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }

        private static DataRow[] GetChildDataTable(DataTable dt, string parentId)
        {
            return dt.Select(string.Format("parentId='{0}'", parentId));
        }

        private static string GetPreFix(bool isLast, bool hasChild, string parentString)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(parentString))
            {
                result += parentString.Replace("├", "｜").Replace("└", "　");
            }
            if (isLast)
            {
                return result += "└";
            }
            else
            {
                result += "├";
            }
            return result;
        }
    }

}
