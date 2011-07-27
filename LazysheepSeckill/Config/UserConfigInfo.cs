using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Config
{
    [Serializable]
    [XmlRoot(ElementName = "UserData")]
    public class UserConfigInfo : IConfigInfo
    {
        public UserConfigInfo()
        {
            CFG_PATH = "user.config";
        }

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
}
