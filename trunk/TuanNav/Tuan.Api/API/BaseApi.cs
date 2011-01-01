using System;
using System.IO;
using System.Net;
using Tuan.Common.XML;

namespace Tuan.Api
{
    public abstract class BaseApi<T> where T : BaseApi<T>
    {
        public T GetRemoteData(string apiUrl)
        {
            WebRequest wrq = WebRequest.Create(apiUrl);
            wrq.Timeout = 6000;
            wrq.Method = "GET";
            WebResponse wrp = wrq.GetResponse();
            using (Stream sr = wrp.GetResponseStream())
            {
                T instance;
                Type type = typeof(T);
                instance = (T)SerializerXML.Load(type, sr);
                return instance;
            }
        }
    }
}
