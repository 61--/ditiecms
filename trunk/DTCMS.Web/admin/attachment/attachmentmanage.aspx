<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="attachmentmanage.aspx.cs"
    Inherits="DTCMS.Web.admin.attachmentmanage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图片管理</title>
    <style type="text/css">
        *
        {
            margin: 0;
            padding: 0;
        }        
        .hr
        {
            height: 8px;
            line-height: 8px;
            overflow: hidden;
            clear: both;
        }
        #container
        {
            width: 570px;
            margin: 0 auto;
        }
        #menu
        {
            float: left;
            margin-top: 5px;
        }
        #menu ul
        {
            list-style: none outside none;
        }
        #menu ul li
        {
            float: left;
            padding-right: 10px;
        }
        #menu ul li a
        {
            display: block;
            color: #006699;
            font-size: 16px;
            font-family: "Arial Unicode MS";
            text-decoration: none;
            cursor: pointer;
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
            <div class="hr">
            </div>
            <div id="main">
                <iframe src="attachmentload.aspx" width="100%" height="360px" id="FrmUpload" name="FrmUpload"
                    frameborder="0" scrolling="no"></iframe>
            </div>
        </div>
    </div>
    </form>

    <script type="text/javascript">
        function attachmentUpload(obj) {
            document.getElementById("FrmUpload").src = "attachmentload.aspx";
            obj.blur();
        }
        function attachmentSearch(obj) {
            document.getElementById("FrmUpload").src = "attachmentsearch.aspx";
            obj.blur();
        }
    </script>

</body>
</html>
