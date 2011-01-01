//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-04-24 15:52:06
// 功能描述: 
// 修改标识:
// 修改描述: LinPanxing 修改于 2010-05-06 16:10:03
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Entity.TemplateEngine
{
    /// <summary>
    /// ArcClass 实体类
    /// </summary>
    public class Channel
    {
        public Channel()
        { }

        private int _id;
        private string _name;
        private string _eName;
        private byte _type;
        private string _domain;
        private string _path;
        private string _URL;
        private string _description;
        private byte _siteID;
        private string _imgUrl;
        private string _keywords;

        /// <summary>
        /// 栏目ID
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 栏目名称
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 栏目英文名称
        /// </summary>
        public string EName
        {
            set { _eName = value; }
            get { return _eName; }
        }
        /// <summary>
        /// 栏目类型
        /// </summary>
        public byte Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 栏目二级域名
        /// </summary>
        public string Domain
        {
            set { _domain = value; }
            get { return _domain; }
        }
        /// <summary>
        /// 栏目目录，{#CmsPath}/Archive/
        /// </summary>
        public string Path
        {
            set { _path = value; }
            get { return _path; }
        }
        /// <summary>
        /// 栏目地址
        /// </summary>
        public string URL
        {
            set { _URL = value; }
            get { return _URL; }
        }
        /// <summary>
        /// 栏目描述
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 站点ID
        /// </summary>
        public byte SiteID
        {
            set { _siteID = value; }
            get { return _siteID; }
        }
        /// <summary>
        /// 栏目图片地址
        /// </summary>
        public string ImgUrl
        {
            set { _imgUrl = value; }
            get { return _imgUrl; }
        }
        /// <summary>
        /// 栏目关键字
        /// </summary>
        public string Keywords
        {
            set { _keywords = value; }
            get { return _keywords; }
        }
    }
}
