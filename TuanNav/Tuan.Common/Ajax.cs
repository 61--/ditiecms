using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Tuan.Common
{
    public delegate void EventMethod();

    public class Ajax
    {
        public static void RegMethod(EventMethod method)
        {
            if (string.Compare(method.Method.Name, Utils.GetQueryString("op"), true) == 0)
            {
                method();
            }
        }

        public static void Write(object obj)
        {
            Write(obj, DataType.Html);
        }

        /// <summary>
        /// 将对象输出到新页面.
        /// </summary>
        public static void Write(object obj, DataType type)
        {
            object temp = obj ?? new object();
            HttpContext.Current.Response.AddHeader("Content-Type", type.Type);
            HttpContext.Current.Response.Write(temp);
            HttpContext.Current.Response.End();
        }

        /// <summary>
        /// Ajax输出页面消息
        /// </summary>
        public static void Message(int error)
        {
            Message(error, string.Empty);
        }

        /// <summary>
        /// Ajax输出页面消息
        /// </summary>
        public static void Message(int error, string message)
        {
            string responseText = string.Format("{{'error':{0},'message':'{1}'}}", error, message);
            Write(responseText, DataType.Json);
        }
    }

    public class DataType
    {
        public static DataType Text = new DataType("text/plain; charset=UTF-8");

        public static DataType Html = new DataType("text/html; charset=UTF-8");

        public static DataType Xml = new DataType("text/xml; charset=UTF-8");

        public static DataType JavaScript = new DataType("text/javascript; charset=UTF-8");

        public static DataType Json = new DataType("application/json; charset=UTF-8");

        public string Type
        {
            get { return type; }
        }

        private string type;
        private DataType(string type)
        {
            this.type = type;
        }
    }
}
