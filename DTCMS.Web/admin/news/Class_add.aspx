<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Class_add.aspx.cs" Inherits="DTCMS.Web.admin.news.Class_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>栏目添加</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div class="bodytitle">
            <div class="bodytitleleft">
            </div>
            <div class="bodytitletxt">
                添加栏目</div>
        </div>
        <div class="form_table">
            <table width="100%" align="center" cellpadding="10" cellspacing="1" class="table_form">
                <tr>
                    <td class="main_bleft">
                        是否隐藏栏目:
                    </td>
                    <td class="main_bright">
                        <input type="radio" name="rad_IsHtml" id="rad_Show" value="" runat="server" /><label
                            for="rad_AttributeCover">显示</label>&nbsp;&nbsp;&nbsp;&nbsp;
                        <input type="radio" name="rad_IsHtml" id="rad_Hide" runat="server" /><label for="rad_AttributeCover">
                        隐藏</lable>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft">
                        栏目名称:
                    </td>
                    <td class="main_bright">
                        <input type="text" id="txt_ClassName" class="textbox" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft">
                        浏览权限:
                    </td>
                    <td class="main_bright">
                        <select id="sel_Readaccess" runat="server">
                        </select>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft">
                        文件保存目录
                    </td>
                    <td class="main_bright">
                        <input type="text" id="txt_ClassPath" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft">
                        栏目属性:
                    </td>
                    <td class="main_bright">
                        <input type="radio" name="rad_Attribute" id="rad_AttributeCover" /><label for="rad_AttributeCover">频道封面</label><br />
                        <input type="radio" name="rad_Attribute" id="rad_AttributeList" /><label for="rad_AttributeList">最终列表栏目</label><br />
                        <input type="radio" name="rad_Attribute" id="rad_AttributeUrl" /><label for="rad_AttributeUrl">外部连接</label><br />
                    </td>
                </tr>
            </table>
            <!--高级-->
            <table>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
