using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Controls.DropDownTree
{
    public interface IDropDownTree : IDisposable
    {
        /// <summary>
        /// 返回Dictionary里分别对应ID,文本,如果没有子节点返回null
        /// </summary>
        /// <param name="parentID">父节点ID</param>
        Dictionary<string, string> GetChildCategory(string parentID);
        /// <summary>
        /// 代码里写return new Interface.Common.DropDownTree(this);
        /// </summary>
        DropDownTree DropDownTree
        {
            get;
        }
    }

}
