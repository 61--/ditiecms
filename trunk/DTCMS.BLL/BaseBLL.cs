using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using DTCMS.Entity;
using System.Reflection;
using DTCMS.Common;


namespace DTCMS.BLL
{
    public class BaseBLL
    {
        private CustomError modCustomErr;

        public BaseBLL()
        {}

        #region 错误信息

        /// <summary>
        /// 设置错误信息
        /// </summary>
        /// <param name="ex"></param>
        protected void SetErrorMessage(Exception ex)
        {
            if (ex != null)
            {
                modCustomErr=new CustomError ();
                modCustomErr.Message = ex.Message;
                modCustomErr.Source = ex.Source;
                modCustomErr.StackTrace = ex.StackTrace;
                modCustomErr.TargetSite = ex.TargetSite;

                WriteErrorLog();
            }
        }

        /// <summary>
        /// 错误写入日志
        /// </summary>
        public void WriteErrorLog()
        {
            StringBuilder sbLog = new StringBuilder();
            sbLog.Append("\r\n");
            sbLog.Append("===========================【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "】===========================");
            sbLog.Append("\r\n\r\n");
            sbLog.Append("===============================错误信息===========================");
            sbLog.Append("\r\n\r\n");
            sbLog.Append(modCustomErr.Message);
            sbLog.Append("\r\n\r\n");
            sbLog.Append("================================错误原===========================");
            sbLog.Append("\r\n\r\n");
            sbLog.Append(modCustomErr.Source);
            sbLog.Append("\r\n\r\n");
            sbLog.Append("================================错误方法===========================");
            sbLog.Append("\r\n\r\n");
            sbLog.Append(modCustomErr.TargetSite);
            sbLog.Append("\r\n\r\n");
            sbLog.Append("================================错误堆栈信息===========================");
            sbLog.Append("\r\n\r\n");
            sbLog.Append(modCustomErr.StackTrace);
            sbLog.Append("\r\n\r\n\r\n\r\n\r\n");
            string logPath = ServerInfo.GetRootPath() + "admin\\Log\\" + DateTime.Now.ToShortDateString() + ".txt";
            FileAccessHelper.WriteTextAppendFile(logPath, sbLog.ToString());
        }

        /// <summary>
        /// 获取错误实体类并清除错误信息
        /// </summary>
        /// <param name="ex"></param>
        public CustomError GetErrorMessage()
        {
            if (modCustomErr != null)
            {
                CustomError iCustomError = new CustomError();
                iCustomError.Message = modCustomErr.Message;
                iCustomError.Source = modCustomErr.Source;
                iCustomError.StackTrace = modCustomErr.StackTrace;
                iCustomError.TargetSite = modCustomErr.TargetSite;

                ClearError();
                return iCustomError;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取引发最后一次错误的方法
        /// </summary>
        /// <returns></returns>
        public MethodBase GetLastErrorTargetSite()
        {
            if (modCustomErr != null)
            {
                return modCustomErr.TargetSite;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取最后一次错误的详细堆栈信息
        /// </summary>
        /// <returns></returns>
        public string GetLastErrorStackTrace()
        {
            if (modCustomErr != null)
            {
                return modCustomErr.StackTrace;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 获取是否发生了错误
        /// </summary>
        /// <returns></returns>
        public bool HasError()
        {
            if (modCustomErr != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 清楚当前异常
        /// </summary>
        public void ClearError()
        {
            if (modCustomErr != null)
            {
                modCustomErr = null;
            }
        }
        #endregion
    }
}
