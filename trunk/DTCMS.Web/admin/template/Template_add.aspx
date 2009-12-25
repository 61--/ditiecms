<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Template_add.aspx.cs" Inherits="DTCMS.Web.admin.Template_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>栏目添加</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
   
</head>
<body>
    <form id="form1" runat="server">
     <div id="container">
        <%--<div style="line-height:28px;">当前位置：栏目添加</div>--%>
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on">基本信息</li>
            </ul>
        </div>
        <div id="content">
            <!--基本-->
            <div id="tab1" class="tab_show">
                <table cellpadding="10" cellspacing="0" class="table_form">
                    <tr>
                        <td class="main_bleft split">
                            风格名称:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_TemplateName" class="textbox" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            作者:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Author" class="textbox" runat="server" />
                        </td>
                    </tr>
                     <tr>
                        <td class="main_bleft split">
                            目录:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_TemplateDirectory" class="textbox" runat="server" />
                        </td>
                    </tr>
                 
                    <tr>
                        <td class="main_bleft split">
                            是否启用:
                        </td>
                        <td class="main_bright split">
                            <input type="radio" id="rad_yes" name="rad_isEnable"  runat="server" />是
                            <input type="radio" id="rad_no" name="rad_isEnable" checked=true  runat="server" />否
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            风格展示:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_TemplateImg" class="textbox" runat="server" />
                            <button id="btnUpload" class="b1" >上传</button> 
                        </td>
                        
                    </tr>
                    <tr>
                        <td></td>
                        <td class="main_bright split">
                            <img src="" alt="" />
                        </td>
                    </tr>
                 </table>
             </div>
             <!--操作按钮-->
            <div style="margin:10px;text-align:center;">
                <input id="hide_CreateDateTime" type="hidden" runat="server" />
                <button id="btn_Submit" type="submit" class="b1" runat="server" onserverclick="Btn_Submit_Click" >保存</button>
                <button id="btn_Cancel" type="button" class="b1" onclick="history.back(-1);"> 取消</button>
            </div>
          </div>
      </div>
    </form>
</body>
</html>
