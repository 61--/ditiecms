using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Tuan.Entity;

namespace Tuan.Entity.Config
{
    [Serializable]
    [XmlRoot(ElementName = "UrlRewriteInfo")]
    public class UrlRewriteInfo : IConfigInfo
    {
        private List<UrlRewrite> _urlRewrite;

        [XmlElement(ElementName = "UrlRewrite")]
        public List<UrlRewrite> UrlRewrite
        {
            get { return _urlRewrite; }
            set { _urlRewrite = value; }
        }
    }

    [Serializable]
    public class UrlRewrite
    {
        private string _name;
        private string _pattern;
        private string _page;
        private string _queryString;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Pattern
        {
            get
            {
                return _pattern;
            }
            set
            {
                _pattern = value;
            }
        }

        public string Page
        {
            get
            {
                return _page;
            }
            set
            {
                _page = value;
            }
        }

        public string QueryString
        {
            get
            {
                return _queryString;
            }
            set
            {
                _queryString = value;
            }
        }
    }
}
