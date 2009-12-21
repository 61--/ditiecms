﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DTCMS.Web.admin.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>测试</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />        
    <script type="text/javascript" src="../../inc/dialog/dialog.js"></script>
    <script type="text/javascript">
        function upload() {
            var diag = new Dialog();
            diag.Title = "图片管理";
            diag.Width = 600;
            diag.Height = 380;
            diag.URL = "PhotoManagement.aspx";
            diag.OKEvent = function() {
                var win = diag.innerFrame.contentWindow;
                win.frames["FrmUpload"].upload();
            };
            diag.CancelEvent = function() {
                var win = diag.innerFrame.contentWindow;
                var returnPath = win.frames["FrmUpload"].returnPath();
                if (returnPath) {
                    document.getElementById("imgDisplay").src = returnPath;
                    document.getElementById("imgPath").value = returnPath;
                }
                diag.close();
            };
            diag.show();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div >
        <img id="imgDisplay" src="" alt="" />
        <input type="text" id="imgPath" />
        <button id="btnUpload" onclick="upload();">浏览</button>
        <button id="Button1">浏览1</button>
    </div>
    </form>
</body>
</html>
