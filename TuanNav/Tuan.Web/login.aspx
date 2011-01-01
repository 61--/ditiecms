<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Tuan.Web.login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>用户登录 - 团来了——您的团购生活导航专家！</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta content="Panxing Lin E-mail:support@tuanlet.com" name="Author" />
    <meta content="tuanlet.com" name="Copyright" />
    <link type="text/css" rel="stylesheet" href="/css/gobal.css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
    <script src="/js/jquery.plugin.js" type="text/javascript"></script>
    <script src="/js/base.js" type="text/javascript"></script>
</head>
<body>
<!--#include file="header.aspx"-->
    <form id="form1" runat="server">
    <div>
        用户名：<asp:TextBox ID="txt_UserName" runat="server"></asp:TextBox>
        密 码：<asp:TextBox ID="txt_Pwd" runat="server"></asp:TextBox>
        <asp:Button ID="btn_login" runat="server" Text="登录" 
            onclick="btn_login_Click" />
    </div>
    </form>
<!--#include file="footer.aspx"-->
</body>
</html>
