<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Tuan.Web.test" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>团来了提示信息</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv='refresh' content='2; url=/login.aspx' />
    <link rel="stylesheet" type="text/css" href="/css/dialog.css" />
    <script type="text/javascript">
        function test(sl) {
            sl = sl ? true : false;
            alert(sl);
        }
    </script>
</head>
<body>
    <input type="button" value="button" onclick="test(false);" />
</html>

