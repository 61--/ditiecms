<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxTest.aspx.cs" Inherits="DTCMS.Web.admin.AjaxTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>AjaxPro测试</title>
    <script type="text/javascript">
        function getDate() {
            var date = DTCMS.Web.admin.AjaxTest.GetDate().value;
            document.getElementById('time').innerHTML = date;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    当前时间：<div id="time"></div>
    <input id="btn" type="button" value="查看" onclick="getDate()" />
    </form>
</body>
</html>
