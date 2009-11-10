<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News_add.aspx.cs" Inherits="DTCMS.Web.admin.news.News_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加新闻</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="96%" align="center" cellpadding="10" cellspacing="1" class="tab1">
    <tr>
            <td class="main_bleft">
                文章属性：
            </td>
            <td class="main_bright">
                <input type="checkbox" id="chk_Headline" runat="server" /><label for="chk_Headline">&nbsp;头条&nbsp;&nbsp;</label>
                <input type="checkbox" id="chk_Recommended" runat="server" /><label for="chk_Recommended">&nbsp;推荐&nbsp;&nbsp;</label>
                <input type="checkbox" id="chk_Picture" runat="server" /><label for="chk_Picture">&nbsp;图片&nbsp;&nbsp;</label>
                <input type="checkbox" id="chk_LightMagic" runat="server" /><label for="chk_LightMagic">&nbsp;幻灯片&nbsp;&nbsp;</label>
                <input type="checkbox" id="chk_Scroll" runat="server" /><label for="chk_Scroll">&nbsp;滚动&nbsp;&nbsp;</label>
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                标题：
            </td>
            <td class="main_bright">
                 <input type="text" id="txt_Title" class="textbox" style="width:480px;" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                缩略标题：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_ShortTitle" class="textbox" style="width:480px;" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                栏目：
            </td>
            <td class="main_bright">
                <select style="width: 200px;"></select>
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                TAG：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_Tags" class="textbox" style="width:480px;" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                文章缩略图：
            </td>
            <td class="main_bright">
                <input type="file" id="file_ImageUrl" style="width:480px;"  runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                文章作者：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_Author" class="textbox" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                责任编辑：
            </td>
            <td class="main_bright">
               <input type="text" id="txtEditor" class="textbox" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                文章来源：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_Source" class="textbox" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                文章模板：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_Templet" class="textbox" style="width:480px;" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                关键字：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_Keywords" class="textbox" style="width:480px;" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                文章描述：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_Description" class="textbox" style="width:480px;"  runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                文章内容：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_Content" class="textbox" runat="server" />
            </td>
        </tr>
         <tr>
            <td class="main_bleft">
                阅读权限：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_Readaccess" class="textbox" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="main_bleft">
                存储路径：
            </td>
            <td class="main_bright">
                <input type="text" id="txt_FieldPath" class="textbox" style="width:480px;" runat="server" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
