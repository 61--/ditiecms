<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main_index.aspx.cs" Inherits="DTCMS.Web.Manage.main_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理后台首页</title>
    <link href="css/blue_body.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="welcome">
        欢迎使用功能强大的物业管理系统！
    </div>
    <div class="bodytitle">
        <div class="bodytitleleft">
        </div>
        <h1>
            用户信息</h1>
    </div>
    <div class="main_dnews">
        <div>
            快捷信息</div>
    </div>
    <div class="bodytitle">
        <div class="bodytitleleft">
        </div>
        <h1>
            系统信息</h1>
    </div>
    <table width="96%" align="center" cellpadding="10" cellspacing="1" class="tab1">
        <tr>
            <td class="main_bleft">
                您的级别：
            </td>
            <td class="main_bright">
                <strong>超级管理员</strong>
            </td>
        </tr>
        <tr>
            <td rowspan="5" class="main_bleft">
                服务器环境：
            </td>
            <td class="main_bright">
                操作系统：
            </td>
        </tr>
        <tr>
            <td class="main_bright">
                系统目录：
            </td>
        </tr>
        <tr>
            <td class="main_bright">
                计算机名：
            </td>
        </tr>
        <tr>
            <td class="main_bright">
                系统运行时间：
            </td>
        </tr>
        <tr>
            <td class="main_bright">
                系统域名：
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                软件版本：
            </td>
            <td class="main_bright">
                <strong>版本号：</strong>V2.0
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                开发团队：
            </td>
            <td class="main_bright">
                纪维锋、朱小奔、林潘星、陈海翔、王翰、许健、许晓君、邱晓雯、林童亮、廖应谭
            </td>
        </tr>
    </table>
    <div id="copyright">
        Powered by <a href="http://www.91aspx.com">www.91aspx.com</a> Copyright &copy; 2006-2008
        All Rights Reserved.
    </div>
    </form>
</body>
</html>
