<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="base_setting.aspx.cs" Inherits="DTCMS.Web.admin.sys.base_setting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>系统参数设置</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="content">            
            <div>
                <table cellpadding="10" cellspacing="0" class="table_form">
                    <tr>
                        <td class="main_bleft split">
                            网站名称:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_SiteName" class="textbox" runat="server" />                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            网站域名:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_SiteDomain" class="textbox" runat="server" />                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            首页模版路径:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_HomeTemplet" class="textbox long" runat="server" />                            
                            <img src="../images/blue/s.gif" class="select" alt="首页模版" title="首页模版" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            首页链接:                            
                        </td>
                        <td class="main_bright split">
                             <input type="text" id="txt_HomeUrl" class="textbox" style="width:222px;" runat="server" />  
                             <span class="main_bleft">链接名: </span>
                             <input type="text" id="txt_HomeName" class="textbox" style="width:143px;" runat="server" />                  
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            默认栏目目录:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ClassPath" class="textbox" runat="server" />                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            默认封面模版:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_IndexTemplet" class="textbox long"  runat="server" />
                            <img src="../images/blue/s.gif" class="select" alt="选择封面模版" title="选择封面模版" />                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            默认列表模版:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ListTemplet" class="textbox long"  runat="server" />
                            <img src="../images/blue/s.gif" class="select" alt="选择列表模版" title="选择列表模版" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            默认文档模版:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ArchiveTemplet" class="textbox long"  runat="server" />
                            <img src="../images/blue/s.gif" class="select" alt="选择文档模版" title="选择文档模版" />                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                           默认封面页规则:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_IndexRule" class="textbox long" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            默认列表页规则:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ListRule" class="textbox long" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            默认文档页规则:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ArchiveRule" class="textbox long" runat="server" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            Meta关键字:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Keywords" class="textbox long" runat="server" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft">
                            Meta描述:
                        </td>
                        <td class="main_bright">
                            <textarea id="txt_Description" runat="server" rows="6" cols="50"></textarea>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft">
                            网站版权信息:
                        </td>
                        <td class="main_bright">
                            <input type="text" id="txt_SiteCopyRightInfo" class="textbox" style="width:222px;" runat="server" />
                            <span class="main_bleft">备案号: </span>
                            <input type="text" id="txt_RecordNo" class="textbox" style="width:143px;" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft">
                            管理员Email:
                        </td>
                        <td class="main_bright">
                            <input type="text" id="txt_AdminEmail" class="textbox short" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft">
                            模板默认风格:
                        </td>
                        <td class="main_bright">
                            <input type="text" id="txt_DefaultTemplet" class="textbox short" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            默认审核机制:
                        </td>
                        <td class="main_bright split">
                            <select id="slt_CheckLevel" runat="server" style="width: 105px; background: #F7FAFC;">
                            </select>
                            <span class="main_bleft">后台登陆验证: </span>
                            <input type="radio" id="rdo_yes" name="rdo_validate" value="1" onclick="rdo_LoginValidate(this)" runat="server" /><label for="rdo_yes">是</label>
                            <input type="radio" id="rdo_no"  name="rdo_validate" value="0" onclick="rdo_LoginValidate(this)" runat="server" /><label for="rdo_no">否</label>
                            <input type="hidden" id="hidden_LoginValidate" value="1" runat="server" />
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
    <script type="text/javascript">
        function rdo_LoginValidate(obj) {
            $("#hidden_LoginValidate").val(obj.value);
        }
        
    </script>
</body>
</html>
