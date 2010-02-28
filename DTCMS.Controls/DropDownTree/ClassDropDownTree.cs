using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Entity;

namespace DTCMS.Controls.DropDownTree
{
    public class ClassDropDownTree : IDropDownTree
    {

        #region IDropDownTree 成员
        BLL.Arc_ClassBLL bll = new BLL.Arc_ClassBLL();

        public Dictionary<string, string> GetChildCategory(string parentID)
        {
            if (parentID == string.Empty || parentID==null)
                parentID = "0";

            int count = 0;
            List<Arc_Class> classList = bll.GetDropList(parentID);

            if (classList != null && classList.Count > 0)
            {
                Dictionary<string, string> categoryList = new Dictionary<string, string>();
                for (int i = 0; i < classList.Count; i++)
                {
                    categoryList.Add(classList[i].CID.ToString(), classList[i].ClassName);
                }
                return categoryList;
            }
            return null;
        }

        public DropDownTree DropDownTree
        {
            get
            {
                return new DropDownTree(this);
            }
        }

        public void Dispose()
        {            
        }

        #endregion
    }
}
