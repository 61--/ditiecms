using System;
using System.Text;
using System.Xml.Serialization;

namespace DTCMS.Entity
{
    [Serializable]
    public class Attachment
    {
        private string _path;
        private string _directory;
        private string _imageformat;
        private string _videoformat;
        private string _audioformat;
        private string _flashformat;
        private string _attachmentformat;
        private string _haswatermark;
        private string _hasabbrimage;
        private string _hasabbrimagewatermark;
        private string _abbrimagewidth;
        private string _abbrimageheight;
        private WaterImage _waterimage;
        public string Path
        {
            set
            {
                this._path = value;
            }
            get
            {
                return this._path;
            }

        }
        public string Directory
        {
            set
            {
                this._directory = value;
            }
            get
            {
                return this._directory;
            }

        }
        public string ImageFormat
        {
            set
            {
                this._imageformat = value;
            }
            get
            {
                return this._imageformat;
            }

        }
        public string VideoFormat
        {
            set
            {
                this._videoformat = value;
            }
            get
            {
                return this._videoformat;
            }

        }
        public string AudioFormat
        {
            set
            {
                this._audioformat = value;
            }
            get
            {
                return this._audioformat;
            }

        }
        public string FlashFormat
        {
            set
            {
                this._flashformat = value;
            }
            get
            {
                return this._flashformat;
            }

        }
        public string AttachmentFormat
        {
            set
            {
                this._attachmentformat = value;
            }
            get
            {
                return this._attachmentformat;
            }

        }
        public string HasWaterMark
        {
            set
            {
                this._haswatermark = value;
            }
            get
            {
                return this._haswatermark;
            }

        }
        public string HasAbbrImage
        {
            set
            {
                this._hasabbrimage = value;
            }
            get
            {
                return this._hasabbrimage;
            }

        }
        public string HasAbbrImageWaterMark
        {
            set
            {
                this._hasabbrimagewatermark = value;
            }
            get
            {
                return this._hasabbrimagewatermark;
            }

        }
        public string AbbrImageWidth
        {
            set
            {
                this._abbrimagewidth = value;
            }
            get
            {
                return this._abbrimagewidth;
            }

        }
        public string AbbrImageHeight
        {
            set
            {
                this._abbrimageheight = value;
            }
            get
            {
                return this._abbrimageheight;
            }

        }

        [XmlElement(ElementName = "WaterImage")]
        public WaterImage WaterImages
        {
            set
            {
                this._waterimage = value;
            }
            get
            {
                return this._waterimage;
            }

        }

    }
}