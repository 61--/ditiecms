//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-07-13 22:08:53
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;

namespace DTCMS.Entity.TemplateEngine
{
    public class Article_Info : Archive
    {
        private string _tags;
        private string _editor;
        private string _source;
        private string _templet;
        private string _keywords;
        private string _content;
        private Int16 _readaccess;
        private Int16 _money;
        private byte _isComment;
        private byte _isPaging;
        private string _filePath;
        private string _similarArticle;

        /// <summary>
        /// 文章TAG
        /// </summary>
        public string Tags
        {
            set { _tags = value; }
            get { return _tags; }
        }
        /// <summary>
        /// 责任编辑
        /// </summary>
        public string Editor
        {
            set { _editor = value; }
            get { return _editor; }
        }
        /// <summary>
        /// 文章来源
        /// </summary>
        public string Source
        {
            set { _source = value; }
            get { return _source; }
        }
        /// <summary>
        /// 关键字
        /// </summary>
        public string Keywords
        {
            set { _keywords = value; }
            get { return _keywords; }
        }
        /// <summary>
        /// 文章正文
        /// </summary>
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 阅读权限，会员组
        /// </summary>
        public Int16 Readaccess
        {
            set { _readaccess = value; }
            get { return _readaccess; }
        }
        /// <summary>
        /// 消费点数
        /// </summary>
        public Int16 Money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// 是否允许评论，1允许，0不允许
        /// </summary>
        public byte IsComment
        {
            set { _isComment = value; }
            get { return _isComment; }
        }
        /// <summary>
        /// 是否分页，1分页，0不分页
        /// </summary>
        public byte IsPaging
        {
            set { _isPaging = value; }
            get { return _isPaging; }
        }
        /// <summary>
        /// 文章模版
        /// </summary>
        public string Templet
        {
            set { _templet = value; }
            get { return _templet; }
        }
        /// <summary>
        /// 存储路径
        /// </summary>
        public string FilePath
        {
            set { _filePath = value; }
            get { return _filePath; }
        }
        /// <summary>
        /// 相关文章
        /// </summary>
        public string SimilarArticle
        {
            set { _similarArticle = value; }
            get { return _similarArticle; }
        }
    }
}
