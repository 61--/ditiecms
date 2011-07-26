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
            get { return m_UserData; }
            set { m_UserData = value; }
        }
        private UserData m_UserData;

        [XmlElement(ElementName = "SystemSetting")]
        public SystemSetting SystemSetting
        {
            get { return m_SystemSetting; }
            set { m_SystemSetting = value; }
        }
        private SystemSetting m_SystemSetting;
    }

    [Serializable]
    public class UserData
    {

        public string DefaultAccount
        {
            get { return m_DefaultAccount; }
            set { m_DefaultAccount = value; }
        }
        private string m_DefaultAccount;

        [XmlElement(ElementName = "Account")]
        public List<Account> Account
        {
            get { return m_Account; }
            set { m_Account = value; }
        }
        private List<Account> m_Account;

        public string GoodsUrl
        {
            get { return m_GoodsUrl; }
            set { m_GoodsUrl = value; }
        }
        private string m_GoodsUrl;
    }

    [Serializable]
    public class Account
    {
        public string UserName
        {
            get { return m_UserName; }
            set { m_UserName = value; }
        }
        private string m_UserName;

        public string PassWord
        {
            get { return m_PassWord; }
            set { m_PassWord = value; }
        }
        private string m_PassWord;
    }

    [Serializable]
    public class SystemSetting
    {
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
