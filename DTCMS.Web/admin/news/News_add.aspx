<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News_add.aspx.cs" Inherits="DTCMS.Web.admin.news.News_add" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加新闻</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/common.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div style="line-height: 28px;">当前位置:添加文章</div>
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a onclick="selectTab('tab1',this)" href="javascript:void(0)">基本信息</a></li>
                <li><a onclick="selectTab('tab2',this)" href="javascript:void(0)">其他参数</a></li>
            </ul>
        </div>
        <div id="content">
            <!--基本-->
            <div id="tab1" class="tab_show">
                <table cellpadding="0" cellspacing="0" class="table_form">
                    <tr>
                        <td class="main_bleft split">文章标题:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Title" class="textbox long" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            文章属性:
                        </td>
                        <td class="main_bright split">
                            <input type="checkbox" id="chk_Headline" runat="server" /><label for="chk_Headline">头条</label>
                            <input type="checkbox" id="chk_Recommended" runat="server" /><label for="chk_Recommended">推荐</label>
                            <input type="checkbox" id="chk_LightMagic" runat="server" /><label for="chk_LightMagic">幻灯片</label>
                            <input type="checkbox" id="chk_Scroll" runat="server" /><label for="chk_Scroll">滚动</label>
                            <input type="checkbox" id="chk_JumpUrl" runat="server" /><label for="chk_JumpUrl">跳转网址</label>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            TAG标签:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Tags" class="textbox" runat="server" /><img src="../images/blue/s.gif" class="select" alt="选取" />
                            (多个TAG用逗号,隔开)
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            所属栏目:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ClassID" class="textbox short" runat="server" /><img src="../images/blue/s.gif" class="select" alt="选择" />
                            <span class="main_bleft">文章来源: </span><input type="text" id="txt_Source" class="textbox" style="width:120px;" runat="server" /><img src="../images/blue/s.gif" class="select" alt="选择" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            文章作者:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Author" class="textbox" style="width:120px;" runat="server" /><img src="../images/blue/s.gif" class="select" alt="选取" />
                            <span class="main_bleft">责任编辑: </span><input type="text" id="txtEditor" class="textbox" style="width:120px;" runat="server" /><img src="../images/blue/s.gif" class="select" alt="选取" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            文章缩略图:
                        </td>
                        <td class="main_bright split">
                            <input type="file" id="file_ImageUrl" style="width: 480px;" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            内容
                        </td>
                        <td class="main_bright split">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <FCKeditorV2:FCKeditor ID="txt_Content" Height="400px" Width="50%" runat="server"></FCKeditorV2:FCKeditor>
                        </td>
                    </tr>
                </table>
            </div>
            <!--其他信息-->
            <div id="tab2" class="tab_hiden">
                <table cellpadding="0" cellspacing="0" class="table_form">
                    <tr>
                        <td class="main_bleft split">
                            文章模板:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Templet" class="textbox" style="width: 480px;" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            文章内容:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_" class="textbox" style="width: 520px; height: 200px;" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
