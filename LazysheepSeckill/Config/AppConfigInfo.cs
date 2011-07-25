using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Config
{
    [Serializable]
    public class AppConfigInfo : IConfigInfo
    {
        [XmlElement(ElementName = "UserData")]
        public UserData UserData
        {
            get;
            set;
        }

        [XmlElement(ElementName = "SystemSetting")]
        public SystemSetting SystemSetting
        {
            get;
            set;
        }
    }

    [Serializable]
    public class UserData
    {
        public string UserName
        {
            get;
            set;
        }

        public string PassWord
        {
            get;
            set;
        }

        public string GoodsUrl
        {
            get;
            set;
        }
    }

    [Serializable]
    public class SystemSetting
    {
        public bool WindowTopMost
        {
            get;
            set;
        }

        public string SkinFile
        {
            get;
            set;
        }
    }
}
