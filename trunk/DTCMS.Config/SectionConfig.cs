using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common.Xml;
using DTCMS.Common;
using System.Xml;
using System.Data;

namespace DTCMS.Config
{
    public class SectionConfig
    {
        private static XmlDocumentExtender xmlDoc = new XmlDocumentExtender();
        private static string path = Utils.GetRootPath() + ConfigPath.SECTION;

        /// <summary>
        /// 初始化XML文档
        /// </summary>
        private static void InitXmlDoc()
        {
            xmlDoc.Load(path);
        }

        /// <summary>
        /// 获取下拉列表
        /// </summary>
        /// <param name="sectionkey"></param>
        /// <returns></returns>
        public static DataTable GetSectionList(string sectionkey)
        {
            InitXmlDoc();
            DataTable dtSectionList = new DataTable();
            dtSectionList.Columns.Add("key");
            dtSectionList.Columns.Add("value");

            XmlNodeList sectionNodeList = xmlDoc.DocumentElement.SelectNodes("/configuration/section[@key='" + sectionkey + "']/item");
            if (sectionNodeList != null && sectionNodeList.Count > 0)
            {
                foreach (XmlNode sectionNode in sectionNodeList)
                {
                    DataRow drNew = dtSectionList.NewRow();
                    drNew["key"]=sectionNode.Attributes["key"].Value.Trim();
                    drNew["value"] = sectionNode.Attributes["value"].Value.Trim();
                    dtSectionList.Rows.Add(drNew);              
                }
            }
            return dtSectionList;
        }       

    }
}
