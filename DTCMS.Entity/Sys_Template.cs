using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DTCMS.Entity
{
    public class Sys_Template
    {
        public Sys_Template() { }
        #region Model
        private int _templateid;
        private string _templatename;
        private string _templatedirectory;
        private int _isenable;
        private DateTime? _createdatetime;
        private string _templateimg;
        /// <summary>
        /// 模板主键
        /// </summary>
        public int TemplateID
        {
            set { _templateid = value; }
            get { return _templateid; }
        }
        /// <summary>
        /// 模板名称
        /// </summary>
        public string TemplateName
        {
            set { _templatename = value; }
            get { return _templatename; }
        }
        /// <summary>
        /// 模板目录
        /// </summary>
        public string TemplateDirectory
        {
            set { _templatedirectory = value; }
            get { return _templatedirectory; }
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int isEnable
        {
            set { _isenable = value; }
            get { return _isenable; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDateTime
        {
            set { _createdatetime = value; }
            get { return _createdatetime; }
        }
        /// <summary>
        /// 模板缩略图
        /// </summary>
        public string TemplateImg
        {
            set { _templateimg = value; }
            get { return _templateimg; }
        }
        #endregion Model
       
    }
}
