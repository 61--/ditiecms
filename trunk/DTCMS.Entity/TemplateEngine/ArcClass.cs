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
    public class ArcClass
    {
        public ArcClass()
        { }

        private int _id;
        private string _className;
        private string _classEName;
        private byte _classType;
        private string _classDomain;
        private string _classPath;
        private string _classURL;
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
        public string ClassName
        {
            set { _className = value; }
            get { return _className; }
        }
        /// <summary>
        /// 栏目英文名称
        /// </summary>
        public string ClassEName
        {
            set { _classEName = value; }
            get { return _classEName; }
        }
        /// <summary>
        /// 栏目类型
        /// </summary>
        public byte ClassType
        {
            set { _classType = value; }
            get { return _classType; }
        }
        /// <summary>
        /// 栏目二级域名
        /// </summary>
        public string ClassDomain
        {
            set { _classDomain = value; }
            get { return _classDomain; }
        }
        /// <summary>
        /// 栏目目录，{#CmsPath}/Archive/
        /// </summary>
        public string ClassPath
        {
            set { _classPath = value; }
            get { return _classPath; }
        }
        /// <summary>
        /// 栏目地址
        /// </summary>
        public string ClassURL
        {
            set { _classURL = value; }
            get { return _classURL; }
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
