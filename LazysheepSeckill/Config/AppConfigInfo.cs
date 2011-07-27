using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Config
{
    [Serializable]
    [XmlRoot(ElementName = "AppSetting")]
    public class AppConfigInfo : IConfigInfo
    {
        public AppConfigInfo()
        {
            CFG_PATH = "app.config";
        }

        public bool WindowTopMost
        {
            get { return m_WindowTopMost; }
            set { m_WindowTopMost = value; }
        }
        private bool m_WindowTopMost;

        public string SkinFile
        {
            get { return m_SkinFile; }
            set { m_SkinFile = value; }
        }
        private string m_SkinFile;
    }
}
