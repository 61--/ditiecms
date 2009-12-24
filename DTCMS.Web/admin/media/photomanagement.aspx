<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="photomanagement.aspx.cs"
    Inherits="DTCMS.Web.admin.PhotoManagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图片管理</title>
    <style type="text/css">
        *
        {
            margin: 0 auto;
            padding: 0;
            font-family: "Arial Unicode MS";
            font-size: 16px;
        }        
        #container
        {
            width:570px;
            margin:0 auto;
            text-align: center;
        }
        #menu
        {
            float:left;
            margin:2px 0 6px 0;
        }
        #menu ul
        {            
            list-style:none outside none;
        }
        #menu ul li
        {
            float: left;
            padding-right:10px;            
        }
        #menu ul li a
        {
            display: block;
            color:#006699;
            font-size:16px;
            text-decoration: none;
            cursor: pointer;
        }
        #main
        {
            clear:both;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="content">
            <div id="menu">
                <ul>
                    <li><a href="javascript:void(0)" onclick="attachmentUpload(this)">附件上传</a></li>
                    <li><a href="javascript:void(0)" onclick="attachmentSearch(this)">附件浏览</a></li>
                </ul>
            </div>
            <div id="main">
                <iframe src="photoupload.aspx" width="100%" height="340px" id="FrmUpload" name="FrmUpload"
                    frameborder="0" scrolling="no"></iframe>
            </div>
        </div>
    </div>
    </form>

    <script type="text/javascript">
        function attachmentUpload(obj) {
            document.getElementById("FrmUpload").src = "photoupload.aspx";
            obj.blur();
        }
        function attachmentSearch(obj) {
            document.getElementById("FrmUpload").src = "photosearch.aspx";
            obj.blur();
        }
    </script>

</body>
</html>
