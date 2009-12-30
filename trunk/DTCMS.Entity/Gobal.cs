using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Entity
{
    /// <summary>
    /// 系统配置
    /// </summary>
    public class Gobal
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
        private string _waterpic;
        private string _watercharater;
        private string _waterpicpath;
        private string _xpercent;
        private string _ypercent;
        private string _charcolor;
        private string _transparence;
        private string _fontfamilyname;
        private string _fontsize;
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }
        public string Directory
        {
            get { return this._directory; }
            set { this._directory = value; }
        }
        public string ImageFormat
        {
            get { return this._imageformat; }
            set { this._imageformat = value; }
        }
        public string VideoFormat
        {
            get { return this._videoformat; }
            set { this._videoformat = value; }
        }
        public string AudioFormat
        {
            get { return this._audioformat; }
            set { this._audioformat = value; }
        }
        public string FlashFormat
        {
            get { return this._flashformat; }
            set { this._flashformat = value; }
        }
        public string AttachmentFormat
        {
            get { return this._attachmentformat; }
            set { this._attachmentformat = value; }
        }
        public string HasWaterMark
        {
            get { return this._haswatermark; }
            set { this._haswatermark = value; }
        }
        public string HasAbbrImage
        {
            get { return this._hasabbrimage; }
            set { this._hasabbrimage = value; }
        }
        public string HasAbbrImageWaterMark
        {
            get { return this._hasabbrimagewatermark; }
            set { this._hasabbrimagewatermark = value; }
        }
        public string AbbrImageWidth
        {
            get { return this._abbrimagewidth; }
            set { this._abbrimagewidth = value; }
        }
        public string AbbrImageHeight
        {
            get { return this._abbrimageheight; }
            set { this._abbrimageheight = value; }
        }
        public string WaterPic
        {
            get { return this._waterpic; }
            set { this._waterpic = value; }
        }
        public string WaterCharater
        {
            get { return this._watercharater; }
            set { this._watercharater = value; }
        }
        public string WaterPicPath
        {
            get { return this._waterpicpath; }
            set { this._waterpicpath = value; }
        }
        public string XPercent
        {
            get { return this._xpercent; }
            set { this._xpercent = value; }
        }
        public string YPercent
        {
            get { return this._ypercent; }
            set { this._ypercent = value; }
        }
        public string CharColor
        {
            get { return this._charcolor; }
            set { this._charcolor = value; }
        }
        public string Transparence
        {
            get { return this._transparence; }
            set { this._transparence = value; }
        }
        public string FontFamilyName
        {
            get { return this._fontfamilyname; }
            set { this._fontfamilyname = value; }
        }
        public string FontSize
        {
            get { return this._fontsize; }
            set { this._fontsize = value; }
        }
    }
}
