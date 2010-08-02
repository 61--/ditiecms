//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-10-29 19:54:46
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common.Xml;
using DTCMS.Common;
using System.Xml;
using System.Data;

namespace DTCMS.Config
{
    public class SectionConfig : BaseConfig
    {
        private readonly string path = Utils.GetRootPath() + ConfigPath.SECTION;
        /// <summary>
        /// 获取下拉列表
        /// </summary>
        /// <param name="sectionkey"></param>
        /// <returns></returns>
        public DataTable GetSectionList(string sectionkey)
        {
            DataTable dtSectionList = new DataTable();
            dtSectionList.Columns.Add("key");
            dtSectionList.Columns.Add("value");
            dtSectionList.AcceptChanges();

            XmlNodeList sectionNodeList = SelectNodes(path, "/configuration/section[@key='" + sectionkey + "']/item");
            if (sectionNodeList != null && sectionNodeList.Count > 0)
            {
                foreach (XmlNode sectionNode in sectionNodeList)
                {
                    DataRow drNew = dtSectionList.NewRow();
                    drNew["key"] = sectionNode.Attributes["key"].Value.Trim();
                    drNew["value"] = sectionNode.Attributes["value"].Value.Trim();
                    dtSectionList.Rows.Add(drNew);
                }
            }
            return dtSectionList;
        }

    }
}
