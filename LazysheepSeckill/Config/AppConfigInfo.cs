using System;
using System.Collections.Generic;
using System.Text;

namespace Config
{
    [Serializable]
    public class AppConfigInfo : IConfigInfo
    {
        private string _username;
        private string _password;
        private string _goodsurl;

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }

        public string GoodsUrl
        {
            get { return _goodsurl; }
            set { _goodsurl = value; }
        }
    }
}
