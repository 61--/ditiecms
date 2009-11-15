using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DTCMS.Entity
{
    /// <summary>
    /// 自定义错误类
    /// </summary>
    public class CustomError
    {
        public CustomError()
        { }
        #region Model
        private string _message;
        private string _source;
        private MethodBase _TargetSite;
        private string _StackTrace;
        /// <summary>
        /// 错误提示
        /// </summary>
        public string Message
        {
            set { _message = value; }
            get { return _message; }
        }
        /// <summary>
        /// 错误来源
        /// </summary>
        public string Source
        {
            set { _source = value; }
            get { return _source; }
        }
        /// <summary>
        /// 获取引发最后一次错误的方法
        /// </summary>
        public MethodBase TargetSite
        {
            set { _TargetSite = value; }
            get { return _TargetSite; }
        }
        /// <summary>
        /// 获取最后一次错误的详细堆栈信息
        /// </summary>
        public string StackTrace
        {
            set { _StackTrace = value; }
            get { return _StackTrace; }
        }
        #endregion
    }
}
