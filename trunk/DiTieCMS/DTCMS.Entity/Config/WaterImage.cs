using System;
using System.Text;

namespace DTCMS.Entity
{
    [Serializable]
    public class WaterImage
    {
        private string _waterpic;
        private string _watercharater;
        private string _waterpicpath;
        private string _xpercent;
        private string _ypercent;
        private string _charcolor;
        private string _transparence;
        private string _fontfamilyname;
        private string _fontsize;
        public string WaterPic
        {
            set
            {
                this._waterpic = value;
            }
            get
            {
                return this._waterpic;
            }

        }
        public string WaterCharater
        {
            set
            {
                this._watercharater = value;
            }
            get
            {
                return this._watercharater;
            }

        }
        public string WaterPicPath
        {
            set
            {
                this._waterpicpath = value;
            }
            get
            {
                return this._waterpicpath;
            }

        }
        public string XPercent
        {
            set
            {
                this._xpercent = value;
            }
            get
            {
                return this._xpercent;
            }

        }
        public string YPercent
        {
            set
            {
                this._ypercent = value;
            }
            get
            {
                return this._ypercent;
            }

        }
        public string CharColor
        {
            set
            {
                this._charcolor = value;
            }
            get
            {
                return this._charcolor;
            }

        }
        public string Transparence
        {
            set
            {
                this._transparence = value;
            }
            get
            {
                return this._transparence;
            }

        }
        public string FontFamilyName
        {
            set
            {
                this._fontfamilyname = value;
            }
            get
            {
                return this._fontfamilyname;
            }

        }
        public string FontSize
        {
            set
            {
                this._fontsize = value;
            }
            get
            {
                return this._fontsize;
            }

        }

    }
}