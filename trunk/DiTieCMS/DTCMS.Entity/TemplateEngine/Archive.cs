//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-04-15 22:39:15
// 功能描述: 
// 修改标识: 
// 修改描述: LinPanxing 修改于 2010-06-09 21:24:42
//------------------------------------------------------------------------------

using System;

namespace DTCMS.Entity.TemplateEngine
{
    /// <summary>
    /// 文档实体抽象类
    /// </summary>
    public abstract class Archive
    {
        private int _id;
        private int _classID;
        private string _className;
        private string _classUrl;
        private byte _titleFlag;
        private string _title;
        private string _shortTitle;
        private string _titleStyle;
        private string _imgUrl;
        private string _author;
        private string _description;
        private int _click;
        private int _good;
        private int _bad;
        private string _url;
        private DateTime _pubDate;

        /// <summary>
        /// 文档ID
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 栏目ID
        /// </summary>
        public int ClassID
        {
            set { _classID = value; }
            get { return _classID; }
        }
        /// <summary>
        /// 栏目名称
        /// </summary>
        public string ClassName
        {
            set { _className = value; }
            get { return _className; }
        }
        /// <summary>
        /// 栏目地址
        /// </summary>
        public string ClassUrl
        {
            set { _classUrl = value; }
            get { return _classUrl; }
        }
        /// <summary>
        /// 标题标签，如1[原创]、2[转载]、3[投稿]
        /// </summary>
        public byte TitleFlag
        {
            set { _titleFlag = value; }
            get { return _titleFlag; }
        }
        /// <summary>
        /// 文档标题
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 文档缩略标题
        /// </summary>
        public string ShortTitle
        {
            set { _shortTitle = value; }
            get { return _shortTitle; }
        }
        /// <summary>
        /// 标题样式
        /// </summary>
        public string TitleStyle
        {
            set { _titleStyle = value; }
            get { return _titleStyle; }
        }
        /// <summary>
        /// 文档缩略图
        /// </summary>
        public string ImgUrl
        {
            set { _imgUrl = value; }
            get { return _imgUrl; }
        }
        /// <summary>
        /// 文档作者
        /// </summary>
        public string Author
        {
            set { _author = value; }
            get { return _author; }
        }
        /// <summary>
        /// 文档描述
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 文档点击
        /// </summary>
        public int Click
        {
            set { _click = value; }
            get { return _click; }
        }
        /// <summary>
        /// 顶
        /// </summary>
        public int Good
        {
            set { _good = value; }
            get { return _good; }
        }
        /// <summary>
        /// 踩
        /// </summary>
        public int Bad
        {
            set { _bad = value; }
            get { return _bad; }
        }
        /// <summary>
        /// 文档地址
        /// </summary>
        public string Url
        {
            set { _url = value; }
            get { return _url; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime PubDate
        {
            set { _pubDate = value; }
            get { return _pubDate; }
        }
    }
}
