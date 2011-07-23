/*
使用方法：
HttpUtils http = new HttpUtils();
string lcHtml = "";

http.HandleCookies = true;//操作Cookies
http.Method = "GET";
lcHtml = http.GetUrl("http://signin.ebay.com.cn/ws2/eBayISAPI.dll?SignIn&ssPageName=h:h:sout:CN");

http.AddPostKey("Key", "Value");
http.Referer = "http://signin.ebay.com.cn/ws2/eBayISAPI.dll?SignIn&ssPageName=h:h:sout:CN";

http.Method = "POST";
lcHtml = http.GetUrl("http://signin.ebay.com.cn/ws2/eBayISAPI.dll");

MessageBox.Show(http.ErrorMsg);
MessageBox.Show(lcHtml);

*/

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils
{
    public class HttpUtils
    {
        /// <summary>
        /// User name used for Authentication. 
        /// To use the currently logged in user when accessing an NTLM resource you can use "AUTOLOGIN".
        /// </summary>
        public string Username
        {
            get { return this.cUsername; }
            set { cUsername = value; }
        }

        /// <summary>
        /// Password for Authentication.
        /// </summary>
        public string Password
        {
            get { return this.cPassword; }
            set { this.cPassword = value; }
        }

        /// <summary>
        /// Address of the Proxy Server to be used.
        /// Use optional DEFAULTPROXY value to specify that you want to IE's Proxy Settings
        /// </summary>
        public string ProxyAddress
        {
            get { return this.cProxyAddress; }
            set { this.cProxyAddress = value; }
        }

        /// <summary>
        /// Semicolon separated Address list of the servers the proxy is not used for.
        /// </summary>
        public string ProxyBypass
        {
            get { return this.cProxyBypass; }
            set { this.cProxyBypass = value; }
        }

        /// <summary>
        /// Username for a password validating Proxy. Only used if the proxy info is set.
        /// </summary>
        public string ProxyUsername
        {
            get { return this.cProxyUsername; }
            set { this.cProxyUsername = value; }
        }
        /// <summary>
        /// Password for a password validating Proxy. Only used if the proxy info is set.
        /// </summary>
        public string ProxyPassword
        {
            get { return this.cProxyPassword; }
            set { this.cProxyPassword = value; }
        }

        /// <summary>
        /// Timeout for the Web request in seconds. Times out on connection, read and send operations.
        /// Default is 30 seconds.
        /// </summary>
        public int Timeout
        {
            get { return this.nConnectTimeout; }
            set { this.nConnectTimeout = value; }
        }

        public bool HandleReferer
        {
            get { return this.bHandleReferer; }
            set { this.bHandleReferer = value; }
        }

        /// <summary>
        /// 引用页
        /// </summary>
        public string Referer
        {
            get { return this.cReferer; }
            set { this.cReferer = value; }
        }

        /// <summary>
        /// 提交模式，默认是POST,用GET模式的时候不能使用PostData
        /// </summary>
        /// <value></value>
        public string Method
        {
            get { return this.cMethod; }
            set { this.cMethod = value; }
        }
        /// <summary>
        /// Error Message if the Error Flag is set or an error value is returned from a method.
        /// </summary>
        public string ErrorMsg
        {
            get { return this.cErrorMsg; }
            set { this.cErrorMsg = value; }
        }

        /// <summary>
        /// Error flag if an error occurred.
        /// </summary>
        public bool Error
        {
            get { return this.bError; }
            set { this.bError = value; }
        }

        /// <summary>
        /// Determines whether errors cause exceptions to be thrown. By default errors 
        /// are handled in the class and the Error property is set for error conditions.
        /// (not implemented at this time).
        /// </summary>
        public bool ThrowExceptions
        {
            get { return bThrowExceptions; }
            set { this.bThrowExceptions = value; }
        }

        /// <summary>
        /// If set to a non-zero value will automatically track cookies. The number assigned is the cookie count.
        /// </summary>
        public bool HandleCookies
        {
            get { return this.bHandleCookies; }
            set { this.bHandleCookies = value; }
        }

        //Cookies集合
        public CookieCollection Cookies
        {
            get { return this.oCookies; }
            set { this.oCookies = value; }
        }

        //默认的编码
        public string MyEncoding
        {
            get { return this.cEncoding; }
            set { this.cEncoding = value; }
        }

        //自动跳转到新的页面
        public bool Location
        {
            get { return this.bLocation; }
            set { this.bLocation = value; }
        }

        // *** member properties
        string cPostData = ""; //提交的数据
        int nConnectTimeout = 30; //超时
        string cUserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; Trident/4.0; TencentTraveler 4.0; .NET CLR 2.0.50727)";
        bool bHandleReferer = true; //自动操作引用页
        string cReferer = ""; //引用页
        string cMethod = "POST"; //提交模式POST ro GET
        string cUsername = "";
        string cPassword = "";
        string cProxyAddress = "";
        string cProxyBypass = "";
        string cProxyUsername = "";
        string cProxyPassword = "";
        bool bThrowExceptions = false; //是否抛出异常
        bool bHandleCookies = true; //自动操作Cookies
        CookieCollection oCookies;
        string cErrorMsg = ""; //错误返回
        bool bError = false;
        string cEncoding = "GB2312";//UTF-8 GB2312
        bool bLocation = false;

        /// <summary>
        /// 增加提交的值
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void AddPostKey(string Key, string Value)
        {
            cPostData += string.Format("{0}={1}&", Key, System.Web.HttpUtility.UrlEncode(Value, System.Text.Encoding.GetEncoding("GB2312")));
        }

        /// <summary>
        /// 增加提交的连续值（完整或者部分完整值）
        /// </summary>
        /// <param name="FullPostBuffer"></param>
        public void AddPostKey(string FullPostBuffer)
        {
            cPostData += FullPostBuffer;
        }

        /// <summary>
        /// 修改提交的值
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void EditPostKey(string Key, string Value)
        {
            cPostData = Regex.Replace(cPostData, string.Format("{0}=*[0-9]+&", Key), string.Format("{0}={1}&", Key, Value), RegexOptions.IgnoreCase);
        }

        public string RequestUrl(string Url)
        {
            Url = UrlEncode(Url);
            //System.Diagnostics.Debug.WriteLine(Url);
            try
            {
                this.bError = false;
                this.cErrorMsg = "";

                //通用的属性
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.UserAgent = this.cUserAgent;
                request.Timeout = this.nConnectTimeout * 1000;
                request.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, */*";
                request.Referer = this.cReferer;
                //Request.Connection = "keep-alive";

                // 需要安全验证的访问
                if (this.cUsername.Length > 0)
                {
                    if (this.cUsername == "AUTOLOGIN")
                        request.Credentials = CredentialCache.DefaultCredentials;
                    else
                        request.Credentials = new NetworkCredential(this.cUsername, this.cPassword);
                }

                // 需要使用Proxy和其配置
                if (this.cProxyAddress.Length > 0)
                {
                    if (this.cProxyAddress == "DEFAULTPROXY")
                    {
                        request.Proxy = new WebProxy();
                        request.Proxy = WebProxy.GetDefaultProxy();
                    }
                    else
                    {
                        WebProxy loProxy = new WebProxy(this.cProxyAddress, true);
                        if (this.cProxyBypass.Length > 0)
                        {
                            loProxy.BypassList = this.cProxyBypass.Split(';');
                        }

                        if (this.cProxyUsername.Length > 0)
                            loProxy.Credentials = new NetworkCredential(this.cProxyUsername, this.cProxyPassword);

                        request.Proxy = loProxy;
                    }
                }

                // 需要操作Cookies和自动重用Cookies
                if (this.bHandleCookies)
                {
                    request.CookieContainer = new CookieContainer();
                    if (this.oCookies != null && this.oCookies.Count > 0)
                    {
                        request.CookieContainer.Add(this.oCookies);
                    }
                }

                request.Method = cMethod;//设置提交模式

                if (this.cMethod == "POST")
                {
                    request.ContentType = "application/x-www-form-urlencoded";
                    if (this.cPostData.EndsWith("&"))
                        this.cPostData = this.cPostData.Substring(0, this.cPostData.Length - 1);

                    //MessageBox.Show(this.cPostData);

                    byte[] lbPostBuffer = System.Text.Encoding.GetEncoding(cEncoding).GetBytes(cPostData);
                    request.ContentLength = lbPostBuffer.Length;
                    Stream loPostData = request.GetRequestStream();

                    loPostData.Write(lbPostBuffer, 0, lbPostBuffer.Length);
                    loPostData.Close();

                    // *** clear the POST buffer
                    System.Diagnostics.Debug.WriteLine(cPostData);
                    this.cPostData = "";
                }

                // *** Retrieve the response headers 
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // ** Save cookies the server sends
                if (this.bHandleCookies)
                {
                    if (response.Cookies.Count > 0)
                    {
                        if (this.oCookies == null)
                        {
                            this.oCookies = response.Cookies;
                        }
                        else
                        {
                            // ** If we already have cookies update the list
                            foreach (Cookie oRespCookie in response.Cookies)
                            {
                                bool bMatch = false;
                                foreach (Cookie oReqCookie in this.oCookies)
                                {
                                    if (oReqCookie.Name == oRespCookie.Name)
                                    {
                                        oReqCookie.Value = oRespCookie.Value;
                                        bMatch = true;
                                        break; // 
                                    }
                                } // for each ReqCookies
                                if (!bMatch)
                                    this.oCookies.Add(oRespCookie);
                            } // for each Response.Cookies
                        } // this.Cookies == null
                    } // if Response.Cookie.Count > 0
                } // if this.bHandleCookies = 0


                // *** Save the response object for external access
                Encoding enc;
                try
                {
                    if (response.ContentEncoding.Length > 0)
                        enc = Encoding.GetEncoding(response.ContentEncoding);
                    else
                        enc = Encoding.GetEncoding(cEncoding);
                }
                catch
                {
                    // *** Invalid encoding passed
                    enc = Encoding.GetEncoding(cEncoding);
                }

                // *** drag to a stream
                StreamReader strResponse = new StreamReader(response.GetResponseStream(), enc);
                string str = strResponse.ReadToEnd();
                response.Close();
                strResponse.Close();
                //自动跟踪引用页
                if (this.bHandleReferer)
                {
                    this.cReferer = Url;
                }
                //自动处理HTTP/1.0 302 Moved Temporarily中的Location后的页面。（自动完成跳转）
                if (this.bLocation)
                {

                    //这里需要自动获得跳转页面的地址。并且再次使用这个方法访问页面
                }
                return str;
            }
            catch (Exception e)
            {
                if (this.bThrowExceptions)
                    throw e;
                this.cErrorMsg = e.Message;
                this.bError = true;
                return null;
            }
        }

        private string UrlEncode(string url)
        {
            byte[] bs = Encoding.GetEncoding("gb2312").GetBytes(url);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bs.Length; i++)
            {
                if (bs[i] < 128)
                    sb.Append((char)bs[i]);
                else
                {
                    sb.Append("%" + bs[i++].ToString("x").PadLeft(2, '0'));
                    sb.Append("%" + bs[i].ToString("x").PadLeft(2, '0'));
                }
            }
            return sb.ToString();
        }
    }
}
