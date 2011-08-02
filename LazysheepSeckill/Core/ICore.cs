using System;
using System.Net;

namespace Core
{
    public interface ICore
    {
        bool Login(string userName, string passWord);

        string ErrorMsg { get; }

        CookieCollection Cookies { get; }
    }
}
