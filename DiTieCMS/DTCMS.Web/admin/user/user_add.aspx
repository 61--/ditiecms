<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_add.aspx.cs" Inherits="DTCMS.Web.admin.user_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>添加新用户</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery.min.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a onclick="selectTab('tab1',this)" href="javascript:void(0)">基本信息</a></li>                
                <li><a onclick="selectTab('tab2',this)" href="javascript:void(0)">详细信息</a></li>
            </ul>
        </div>
    <div id="content">
    <div id="tab1" class="tab_show">
                <table cellpadding="10" cellspacing="0" class="table_form">
                    <tr>
                        <td class="main_bleft split">
                            用户名:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_UserName" class="textbox short" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            昵称:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_NickName" class="textbox short" runat="server"/>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            密码:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Password1" class="textbox short" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            确认密码:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Password2" class="textbox short" runat="server" />                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            性别:
                        </td>
                        <td class="main_bright split">
                            <input type="radio" name="rdo_Sex" id="rdo_Men" checked="true" runat="server" /><label for="rdo_Men">男</label>
                            <input type="radio" name="rdo_Sex" id="rdo_Female" runat="server" /><label for="rdo_Female">女</label>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            Email:
                        </td>
                        <td class="main_bright split">
                        <input type="text" id="txt_Email" class="textbox short" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            安全提示问题:
                        </td>
                        <td class="main_bright split">
                            <select id="slt_SecureQuestion" runat="server" style="width: 185px; background: #F7FAFC;">
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            安全提示答案:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_SecureAnswer" class="textbox short" runat="server" />
                        </td>
                    </tr>                   
                </table>
            </div>
    </div>
    </form>
</body>
</html>
