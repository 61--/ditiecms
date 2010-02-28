using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace DTCMS.Controls.DropDownTree
{
    public sealed class DropDownTree
    {
        IDropDownTree _DropDownTree;
        public DropDownTree(IDropDownTree dropDownTree)
        {
            _DropDownTree = dropDownTree;
        }

        #region 绑定下拉菜单 
        /**/
        /// <summary>
        /// 绑定连动级的下拉菜单
        /// </summary>
        /// <param name="ddlGoodsType">传进一个被绑定的DropDownList</param>
        public void BindToDropDownList(DropDownList ddlGoodsType)
        {
            BindToDropDownList(ddlGoodsType, string.Empty, null, true);
        }
        /**/
        /// <summary>
        /// 绑定连动级的下拉菜单
        /// </summary>
        /// <param name="ddlGoodsType">传进一个被绑定的DropDownList</param>
        /// <param name="removeID">被排除的ID</param>
        public void BindToDropDownList(DropDownList ddlGoodsType, string removeID)
        {
            BindToDropDownList(ddlGoodsType, removeID, null, true);
        }
        /**/
        /// <summary>
        /// 绑定连动级的下拉菜单
        /// </summary>
        /// <param name="ddlGoodsType">传进一个被绑定的DropDownList</param>
        /// <param name="removeID">被排除的ID,若没有,传null</param>
        /// <param name="parentID">起始父ID</param>
        public void BindToDropDownList(DropDownList ddlGoodsType, string removeID, string parentID)
        {
            BindToDropDownList(ddlGoodsType, removeID, parentID, true);
        }

        /**/
        /// <summary>
        /// 绑定连动级的下拉菜单
        /// </summary>
        /// <param name="ddlGoodsType">传进一个被绑定的DropDownList</param>
        /// <param name="removeID">被排除绑定的节点ID</param>
        /// <param name="AutoDispose">是否自动释放</param>
        public void BindToDropDownList(DropDownList ddlGoodsType, string removeID, string parentID, bool autoDispose)
        {
            if (ddlGoodsType != null)
            {
                ListItem listItem = null;
                string currentID = parentID;//根节点/父ID
                string currentSign = string.Empty;//当前节点符号;
                string parrentSign = string.Empty; //父节点符号;
                bool HasChild = true;//是否有子
                Queue<string> parentKeyList = new Queue<string>();//存 有子节点的 节点ID
                Queue<string> parentSignList = new Queue<string>();//对应节点ID的前缀符号
                int itemIndexOf = 0;//父节点所在的位置　
                while (HasChild)
                {
                    int lastOneCount = 1;//用于计算在同级别中是否最后一个
                    Dictionary<string, string> childList = _DropDownTree.GetChildCategory(currentID);// 得到子节点列表
                    if (childList != null && childList.Count > 0)
                    {
                        if (!string.IsNullOrEmpty(removeID) && childList.ContainsKey(removeID))
                        {
                            childList.Remove(removeID);
                        }
                        foreach (KeyValuePair<string, string> entry in childList)
                        {
                            if (_DropDownTree.GetChildCategory(entry.Key) != null)//存在子
                            {
                                currentSign = GetPreFix(lastOneCount == childList.Count, true, parrentSign);
                                listItem = new ListItem(currentSign + entry.Value, entry.Key);

                                parentKeyList.Enqueue(entry.Key);//当前的节点ID
                                parentSignList.Enqueue(currentSign);//当前的节点符号
                            }
                            else//不存在子
                            {
                                currentSign = GetPreFix(lastOneCount == childList.Count, false, parrentSign);
                                listItem = new ListItem(currentSign + entry.Value, entry.Key);
                            }
                            if (ddlGoodsType.Items.Count != 0)
                            {
                                itemIndexOf = string.IsNullOrEmpty(currentID) ? itemIndexOf + 1 : ddlGoodsType.Items.IndexOf(ddlGoodsType.Items.FindByValue(currentID)) + lastOneCount;
                            }
                            ddlGoodsType.Items.Insert(itemIndexOf, listItem);//添加子节点
                            lastOneCount++;
                        }
                        if (parentKeyList.Count > 0)//存在子节点时
                        {
                            currentID = parentKeyList.Dequeue();
                            parrentSign = parentSignList.Dequeue();
                        }
                        else
                        {
                            HasChild = false;
                        }
                    }
                    else
                    {
                        break;
                    }


                }
                if (autoDispose)
                {
                    _DropDownTree.Dispose();
                }

            }
        }
        #endregion
        /// <summary>
        /// 用于树的前缀
        /// </summary>
        /// <param name="IsLast">是否是同级节点中的最后一个</param>
        /// <param name="HasChild">本节点是否拥有子节点</param>
        /// <param name="ParentString">父节点前缀符号</param>
        /// <returns>本节点的前缀</returns>
        private string GetPreFix(bool isLast, bool hasChild, string parentString)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(parentString))
            {
                parentString = parentString.Remove(parentString.Length - 1).Replace("├", "│").Replace("└", "　");
                result += parentString;
            }
            if (isLast)
            {
                result += "└";
            }
            else
            {
                result += "├";
            }
            if (hasChild)
            {
                result += "┬";
            }
            else
            {
                result += "─";
            }
            return result;
        }
    }

}
