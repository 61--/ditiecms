<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="DTCMS.Web.admin.Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Test</title>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="Inc/Dialog/Dialog.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="toolbar">
                <a href="News_Add.aspx" class="button b4"><img src="images/ico/i_add.gif" alt="" />添加文章</a>
                <a href="javascript:Dialog.alert('您没有权限编辑文章！');" class="button b4"><img src="images/ico/i_edit.gif" alt="" />编辑文章</a>
                <a href="javascript:DeleteData(-1,true);" class="button b4"><img src="images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
    </form>
</body>
</html>
