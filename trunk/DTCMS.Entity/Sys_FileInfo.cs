using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DTCMS.Entity
{
    /// <summary>
    /// 文件信息实体
    /// </summary>
    public class Sys_FileInfo
    {
        
        private string _filename;
        private DateTime _updatetime;
        private long? _filesize;
        private string _filetitle;
        private bool _isdirectory;
        private string _filepath;
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName
        {
            get { return _filename; }
            set { _filename = value; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime
        {
            get { return _updatetime; }
            set { _updatetime = value; }
        }
        /// <summary>
        /// 文件大小
        /// </summary>
        public long? FileSize
        {
            get { return _filesize; }
            set { _filesize = value; }
        }
        /// <summary>
        /// 是否是目录
        /// </summary>
        public bool isDirectory
        {
            get { return _isdirectory; }
            set { _isdirectory = value; }
        }
        /// <summary>
        /// 文件标题(根据文件内容获取)
        /// </summary>
        public string FileTitle
        {
            get { return _filetitle; }
            set { _filetitle = value; }
        }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath
        {
            get { return _filepath; }
            set { _filepath = value; }
        }
    }
}
