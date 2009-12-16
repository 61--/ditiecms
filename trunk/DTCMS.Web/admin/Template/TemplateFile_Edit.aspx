<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TemplateFile_Edit.aspx.cs" Inherits="DTCMS.Web.TemplateFile_Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>模板添加/编辑</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/Inc/Dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
    <script type="text/javascript" src="/Inc/Dialog/Dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="../../Inc/codepress/codepress.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <%--<div style="line-height:28px;">当前位置：栏目添加</div>--%>
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a onclick="selectTab('tab1',this)" href="javascript:void(0)">基本信息</a></li>
            </ul>
        </div>
        <div id="content">
            <!--基本-->
            <div id="tab1" class="tab_show">
                <table cellpadding="10" cellspacing="0" class="table_form">
                    <tr>
                        <td class="main_bleft split">
                            模板文件名:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ParentClassName" class="textbox" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="main_bright split">
                            <textarea id="templatecode" rows="40" cols="50" class="codepress html linenumbers-on"></textarea>
                        </td>
                    </tr>
                  
                </table>
            </div>
            <!--操作按钮-->
            <div style="margin:10px;text-align:center;">
                <button id="btn_Submit" type="submit" class="b1" runat="server">保存</button>
                <button id="btn_Cancel" type="button" class="b1" onclick="history.back(-1);"> 取消</button>
                <input id="hidden_ClassId" type="hidden" value="0" runat="server" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>

