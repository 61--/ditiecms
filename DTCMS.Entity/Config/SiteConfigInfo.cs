//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-08-04 22:52:15
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Xml.Serialization;

namespace DTCMS.Entity.Config
{
    /// <summary>
    /// 站点设置
    /// </summary>
    [Serializable]
    public class SiteConfigInfo : IConfigInfo
    {
        private string _siteOpen;
        private string _webName;
        private string _webDomain;
        private string _cmsPath;
        private string _htmlPath;
        private string _indexFilename;
        private string _metaKeyword;
        private string _metaDescription;
        private string _copyRight;
        private string _adminEmail;
        private string _beian;
        private string _visitType;
        private string _defaultTemplet;
        private string _indexTemplet;
        private string _listTemplet;
        private string _archiveTemplet;
        private string _indexRule;
        private string _listRule;
        private string _archiveRule;

        /// <summary>
        /// 站点开放访问
        /// </summary>
        public string SiteOpen
        {
            get { return _siteOpen; }
            set { _siteOpen = value; }
        }

        /// <summary>
        /// 站点名
        /// </summary>
        public string WebName
        {
            get { return _webName; }
            set { _webName = value; }
        }

        /// <summary>
        /// 网站域名
        /// </summary>
        public string WebDomain
        {
            get { return _webDomain; }
            set { _webDomain = value; }
        }

        /// <summary>
        /// CMS安装目录
        /// </summary>
        public string CmsPath
        {
            get { return _cmsPath; }
            set { _cmsPath = value; }
        }

        /// <summary>
        /// 生成静态文件目录
        /// </summary>
        public string HtmlPath
        {
            get { return _htmlPath; }
            set { _htmlPath = value; }
        }

        /// <summary>
        /// 生成首页文件名
        /// </summary>
        public string IndexFilename
        {
            get { return _indexFilename; }
            set { _indexFilename = value; }
        }

        /// <summary>
        /// Meta关键字
        /// </summary>
        public string MetaKeyword
        {
            get { return _metaKeyword; }
            set { _metaKeyword = value; }
        }

        /// <summary>
        /// Meta描述
        /// </summary>
        public string MetaDescription
        {
            get { return _metaDescription; }
            set { _metaDescription = value; }
        }

        /// <summary>
        /// 网站版权信息
        /// </summary>
        public string CopyRight
        {
            get { return _copyRight; }
            set { _copyRight = value; }
        }

        /// <summary>
        /// 管理员邮箱
        /// </summary>
        public string AdminEmail
        {
            get { return _adminEmail; }
            set { _adminEmail = value; }
        }

        /// <summary>
        /// 网站备案号
        /// </summary>
        public string Beian
        {
            get { return _beian; }
            set { _beian = value; }
        }

        /// <summary>
        /// 访问类型
        /// </summary>
        public string VisitType
        {
            get { return _visitType; }
            set { _visitType = value; }
        }

        /// <summary>
        /// 默认模版
        /// </summary>
        public string DefaultTemplet
        {
            get { return _defaultTemplet; }
            set { _defaultTemplet = value; }
        }

        /// <summary>
        /// 首页模版文件
        /// </summary>
        public string IndexTemplet
        {
            get { return _indexTemplet; }
            set { _indexTemplet = value; }
        }

        /// <summary>
        /// 列表页模版文件
        /// </summary>
        public string ListTemplet
        {
            get { return _listTemplet; }
            set { _listTemplet = value; }
        }

        /// <summary>
        /// 文档页模版文件
        /// </summary>
        public string ArchiveTemplet
        {
            get { return _archiveTemplet; }
            set { _archiveTemplet = value; }
        }

        /// <summary>
        /// 生成首页规则
        /// </summary>
        public string IndexRule
        {
            get { return _indexRule; }
            set { _indexRule = value; }
        }

        /// <summary>
        /// 生成列表页规则
        /// </summary>
        public string ListRule
        {
            get { return _listRule; }
            set { _listRule = value; }
        }

        /// <summary>
        /// 生成文档页规则
        /// </summary>
        public string ArchiveRule
        {
            get { return _archiveRule; }
            set { _archiveRule = value; }
        }
    }
}
