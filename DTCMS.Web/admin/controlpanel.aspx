<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="controlpanel.aspx.cs" Inherits="DTCMS.Web.admin.controlpanel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>管理后台首页</title>
    <link href="css/blue_body.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a href="javascript:;">后台首页</a></li>
            </ul>
        </div>
        <div id="content">
            <table width="100%" align="center" cellpadding="0" cellspacing="0" class="table_form">
                <tr>
                    <td class="main_bleft split">
                        您的级别：
                    </td>
                    <td class="main_bright split">
                        <strong>超级管理员</strong>
                    </td>
                </tr>
                <tr>
                    <td rowspan="5" class="main_bleft split">
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
                    <td class="main_bright split">
                        系统域名：
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        软件版本：
                    </td>
                    <td class="main_bright split">
                        <strong>版本号：</strong>V2.0
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft">
                        开发团队：
                    </td>
                    <td class="main_bright">
                        纪维锋、林潘星、李裕钬
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
