<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sys_Nvaigate_Add.aspx.cs" Inherits="DTCMS.Web.admin.sys.Sys_Nvaigate_Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>功能菜单</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="content">            
            <div>
                <table cellpadding="10" cellspacing="0" class="table_form">
                    <tr>
                        <td class="main_bleft split">
                            菜单名称:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Name" class="textbox" runat="server" />                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            父菜单:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ParentName" class="textbox short" runat="server" disabled="disabled" />                            
                            <img src="../images/blue/s.gif" class="select" alt="选择菜单" title="选择菜单" />
                            <input type="hidden" id="txt_ParentID" runat="server"/>                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            链接路劲:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_FilePath" class="textbox" runat="server" />                                  
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            打开窗口:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Target" class="textbox short" runat="server" />                                  
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            系统菜单:
                        </td>
                        <td class="main_bright split">
                            <input type="radio" id="rdo_SysNvaYes" name="rdo_sysnva" /><label for="rdo_SysNvaYes">是</label>
                            <input type="radio" id="rdo_SysNvaNo" name="rdo_sysnva"  checked="checked"/><label for="rdo_SysNvaNo">否</label>
                            <input type="checkbox" id="chk_Enable" checked="checked" /><label for="chk_Enable">应用</label>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            排列顺序:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_OrderID" class="textbox" style="width:120px;" value="0" runat="server" />                                  
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            权限码:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_CopyrightCode" class="textbox" style="width:120px;" runat="server" />                                  
                        </td>
                    </tr>
                    
                </table>
            </div>
            <!--操作按钮-->
            <div style="margin:10px;text-align:center;">
                <button id="btn_Submit" type="button" class="b1" runat="server" onserverclick="btn_Submit_Click">保存</button>
                <button id="btn_Cancel" type="button" class="b1" onclick="history.back(-1);"> 取消</button>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
