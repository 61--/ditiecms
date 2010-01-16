using System;
using System.Text;
using System.Xml.Serialization;

namespace DTCMS.Entity
{
    [Serializable]
    public class SysInfoParam
    {
        private string _sitename;
        private string _sitedomain;
        private string _hometemplet;
        private string _homerule;
        private string _homeurl;
        private string _homename;
        private string _classpath;
        private string _indextemplet;
        private string _listtemplet;
        private string _archivetemplet;
        private string _indexrule;
        private string _listrule;
        private string _archiverule;
        private string _metakey;
        private string _metadescription;
        private string _sitecopyrightinfo;
        private string _recordno;
        private string _adminemail;
        private string _defaulttemplet;
        private string _checklevel;
        private string _loginvalidate;
        private string _tableprefix;        
        public string SiteName
        {
            set
            {
                this._sitename = value;
            }
            get
            {
                return this._sitename;
            }

        }
        public string SiteDomain
        {
            set
            {
                this._sitedomain = value;
            }
            get
            {
                return this._sitedomain;
            }

        }
        public string HomeTemplet
        {
            set
            {
                this._hometemplet = value;
            }
            get
            {
                return this._hometemplet;
            }

        }
        public string HomeRule
        {
            set
            {
                this._homerule = value;
            }
            get
            {
                return this._homerule;
            }

        }
        public string HomeUrl
        {
            set
            {
                this._homeurl = value;
            }
            get
            {
                return this._homeurl;
            }

        }
        public string HomeName
        {
            set
            {
                this._homename = value;
            }
            get
            {
                return this._homename;
            }

        }
        public string ClassPath
        {
            set
            {
                this._classpath = value;
            }
            get
            {
                return this._classpath;
            }

        }
        public string IndexTemplet
        {
            set
            {
                this._indextemplet = value;
            }
            get
            {
                return this._indextemplet;
            }

        }
        public string ListTemplet
        {
            set
            {
                this._listtemplet = value;
            }
            get
            {
                return this._listtemplet;
            }

        }
        public string ArchiveTemplet
        {
            set
            {
                this._archivetemplet = value;
            }
            get
            {
                return this._archivetemplet;
            }

        }
        public string IndexRule
        {
            set
            {
                this._indexrule = value;
            }
            get
            {
                return this._indexrule;
            }

        }
        public string ListRule
        {
            set
            {
                this._listrule = value;
            }
            get
            {
                return this._listrule;
            }

        }
        public string ArchiveRule
        {
            set
            {
                this._archiverule = value;
            }
            get
            {
                return this._archiverule;
            }

        }
        public string MetaKey
        {
            set
            {
                this._metakey = value;
            }
            get
            {
                return this._metakey;
            }

        }
        public string MetaDescription
        {
            set
            {
                this._metadescription = value;
            }
            get
            {
                return this._metadescription;
            }

        }
        public string SiteCopyRightInfo
        {
            set
            {
                this._sitecopyrightinfo = value;
            }
            get
            {
                return this._sitecopyrightinfo;
            }

        }
        public string RecordNo
        {
            set
            {
                this._recordno = value;
            }
            get
            {
                return this._recordno;
            }       
        }
        public string AdminEmail
        {
            set
            {
                this._adminemail = value;
            }
            get
            {
                return this._adminemail;
            }

        }
        public string DefaultTemplet
        {
            set
            {
                this._defaulttemplet = value;
            }
            get
            {
                return this._defaulttemplet;
            }

        }
        public string CheckLevel
        {
            set
            {
                this._checklevel = value;
            }
            get
            {
                return this._checklevel;
            }

        }
        public string LoginValidate
        {
            set
            {
                this._loginvalidate = value;
            }
            get
            {
                return this._loginvalidate;
            }

        }
        public string TablePrefix
        {
            set
            {
                this._tableprefix = value;
            }
            get
            {
                return this._tableprefix;
            }
        }

    }
}
