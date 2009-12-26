<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaseSetting.aspx.cs" Inherits="DTCMS.Web.admin.sys.BaseSetting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>基本设置</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/common.js"></script>
</head>
<body>
    <div id="tab_menu" class="tabs">
        <ul>
            <li class="tab_on"><a onclick="selectTab('tab1',this)" href="javascript:void(0)">关键字(TAG)</a></li>
        </ul>
    </div>
   <%-- 关键字TAG--%>
    <div id="tab1" class="tab_show">
        <div id="taglist"></div>
        <div id="tagmanage">
            
        </div>
    </div>
</body>
</html>
