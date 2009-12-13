<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Class_add.aspx.cs" Inherits="DTCMS.Web.admin.news.Class_add" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>栏目添加</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/Inc/Dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="/Inc/Dialog/Dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <%--<div style="line-height:28px;">当前位置：栏目添加</div>--%>
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a onclick="selectTab('tab1',this)" href="javascript:void(0)">基本信息</a></li>
                <li><a onclick="selectTab('tab2',this)" href="javascript:void(0)">高级设置</a></li>
                <li><a onclick="selectTab('tab3',this)" href="javascript:void(0)">栏目内容</a></li>
            </ul>
        </div>
        <div id="content">
            <!--基本-->
            <div id="tab1" class="tab_show">
                <table cellpadding="10" cellspacing="0" class="table_form">
                    <tr>
                        <td class="main_bleft split">
                            上级栏目:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ParentClassName" class="textbox" runat="server" />
                            <input id="hidden_ParentClassID" type="hidden" value="0" runat="server" />
                            <img src="../images/blue/s.gif" class="select" alt="选择上级栏目" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目名称:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ClassName" maxlength="50" class="textbox" runat="server" />
                            <span id="msg_ClassName"></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目英文名称:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ClassEName" maxlength="50" class="textbox" runat="server" />
                            <span id="msg_ClassEName"></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目目录:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ClassPath" value="{#cmsPath}/archive/" class="textbox" runat="server" />
                            <input type="checkbox" name="chk_IsClassEName" id="chk_IsClassEName" checked="checked" runat="server" /><label for="chk_IsClassEName">栏目英文名</label>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目类型:
                        </td>
                        <td class="main_bright split">
                            <select id="slt_ClassType" runat="server" style="width: 185px; background: #F7FAFC;">
                                <option value="0">普通文章（Article）</option>
                            </select>
                            <span id="msg_ClassType"></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目排序:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_OrderID" class="textbox short" value="50" runat="server" />
                            <span id="msg_OrderID"></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            阅读权限:
                        </td>
                        <td class="main_bright split">
                            <select id="slt_Readaccess" runat="server" style="width: 185px; background: #F7FAFC;">
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            审核机制:
                        </td>
                        <td class="main_bright split">
                            <select id="slt_CheckLevel" runat="server" style="width: 185px; background: #F7FAFC;">
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目分页:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ClassPage" value="20" class="textbox short" runat="server" />
                            <span id="msg_ClassPage"></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目属性:
                        </td>
                        <td class="main_bright split">
                            <input type="radio" name="rdo_Attribute" id="rdo_Index" checked="true" runat="server" />
                            <label for="rdo_Index">封面（栏目本身不允许发布文档）</label><br />
                            <input type="radio" name="rdo_Attribute" id="rdo_List" runat="server" />
                            <label for="rdo_List">列表（允许在本栏目发布文档，并生成文档列表）</label><br />
                            <input type="radio" name="rdo_Attribute" id="rdo_Singl" runat="server" />
                            <label for="rdo_Singl">单独页面（栏目本身不允许发布文档）</label><br />
                            <input type="radio" name="rdo_Attribute" id="rdo_Link" runat="server" />
                            <label for="rdo_Link">链接地址</label><input type="text" id="txt_Link" class="textbox" style="display:none" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft">
                            其他属性:
                        </td>
                        <td class="main_bright">
                            <input type="checkbox" name="chk_ISContribute" id="chk_ISContribute" checked="true" runat="server" /><label for="chk_ISContribute">是否允许投稿</label>
                            <input type="checkbox" name="chk_ISHtml" id="chk_ISHtml" checked="true" runat="server" /><label for="chk_ISHtml">是否生成静态页</label>
                            <input type="checkbox" name="chk_ISComment" id="chk_ISComment" checked="true" runat="server" /><label for="chk_ISComment">是否允许评论</label>
                            <input type="checkbox" name="chk_ISHiden" id="chk_ISHiden" runat="server" /><label for="chk_ISHiden">是否隐藏栏目</label>
                        </td>
                    </tr>
                </table>
            </div>
            <!--高级-->
            <div id="tab2" class="tab_hiden">
                <table cellpadding="10" cellspacing="0" class="table_form">
                    <tr>
                        <td class="main_bleft split">
                            栏目二级域名:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ClassDomain" class="textbox" runat="server" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            交叉栏目:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_CorssID" class="textbox" runat="server" />
                            <img src="../images/blue/s.gif" class="select" alt="选择交叉栏目" title="选择交叉栏目" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            封面模版:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_IndexTemplet" class="textbox long" value="/{#Templet}/article/index.html" runat="server" />
                            <img src="../images/blue/s.gif" class="select" alt="选择封面模版" title="选择封面模版" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            列表模版:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ListTemplet" class="textbox long" value="/{#Templet}/article/list.html" runat="server" />
                            <img src="../images/blue/s.gif" class="select" alt="选择列表模版" title="选择列表模版" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            文档模版:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ArchiveTemplet" class="textbox long" value="/{#Templet}/article/article.html" runat="server" />
                            <img src="../images/blue/s.gif" class="select" alt="选择文档模版" title="选择文档模版" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            封面页规则:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_IndexRule" class="textbox long" value="{#ClassPath}/index.html" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            列表页规则:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ListRule" class="textbox long" value="{#ClassPath}/list_{#page}.html" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            文档页规则:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ArchiveRule" class="textbox long" value="{#ClassPath}/{#DateTime Format=yyyyMM}/{#AID}.html" runat="server" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目图片地址:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ImgUrl" class="textbox" runat="server" />
                            <img src="../images/blue/s.gif" class="select" alt="上传栏目图片" title="上传栏目图片" />
                            
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
                </table>
            </div>
            <!--栏目内容-->
            <div id="tab3" class="tab_hiden">
                <FCKeditorV2:FCKeditor ID="txt_Content" runat="server" Height="420px">
                </FCKeditorV2:FCKeditor>
            </div>
            <!--操作按钮-->
            <div style="margin:10px;text-align:center;">
                <input id="btn_Submit" type="submit" value="保存" class="button b1" runat="server" onserverclick="Btn_Submit_Click" />
                <input id="btn_Cancel" type="button" value="取消" class="button b1" onclick="history.back(-1);" />
                <input id="hidden_ClassId" type="hidden" value="0" runat="server" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
