<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Class_add.aspx.cs" Inherits="DTCMS.Web.admin.news.Class_add" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>栏目添加</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/common.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="tab_menu" class="bodytitle">
            <div class="bodytitleleft"></div>
            <div class="tab_on" title="baseInfo" ><a href="##">基本信息</a> </div>
            <div class="tab_off" title="advancedSeting"><a href="##">高级设置</a></div>
            <div class="tab_off" title="classContent"><a href="##">栏目内容</a></div>     
        </div>
        
        <div id="content">
            <!--基本-->
            <div id="baseInfo"class="tab_show">
                <table cellpadding="10" cellspacing="1" class="table_form">
                <tr>
                    <td class="main_bleft split">
                        上级栏目:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_ParentClassName" class="textbox" runat="server" />
                        <a href="##" class="help" title="查看帮助">帮助</a>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        栏目名称:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_ClassName" class="textbox" runat="server" />
                        <a href="##" class="help" title="查看帮助">帮助</a>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        栏目地址:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_ClassUrl" class="textbox" runat="server" />
                        <a href="##" class="help" title="查看帮助">帮助</a>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        交叉栏目:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_CorssID" class="textbox" runat="server" />
                        <img src="../images/blue/s.gif" class="s" alt="选择交叉栏目" title="选择交叉栏目" />
                        <a href="##" class="help" title="查看帮助">帮助</a>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        栏目权限:
                    </td>
                    <td class="main_bright split">
                        <select id="slt_Readaccess" runat="server" style="width:185px; background:#F7FAFC;"></select>
                        <a href="##" class="help" title="查看帮助">帮助</a>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        栏目分页:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_ClassPage" class="textbox" style="width:180px;" runat="server" />
                        <a href="##" class="help" title="查看帮助">帮助</a>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        栏目排序:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_OrderID" class="textbox" style="width:180px;" runat="server" />
                        <a href="##" class="help" title="查看帮助">帮助</a>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        栏目属性:
                    </td>
                    <td class="main_bright split">
                        <input type ="radio" id="rdo_Cover" runat="server" />
                        <label for="rdo_Cover" class="select">封面</label>
                        <input type ="radio" id="rdo_List" runat="server" />
                        <label for="rdo_List" class="select">列表</label>
                        <input type ="radio" id="rdo_Link" runat="server" />
                        <label for="rdo_Link" class="select">连接地址</label>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft">
                    </td>
                    <td class="main_bright">
                        <input type="checkbox" name="chk_ISHiden" id="chk_ISHiden" runat="server" />
                        <label for="chk_ISHiden" class="select">是否隐藏栏目</label>
                        <input type="checkbox" name="chk_ISHtml" id="chk_ISHtml" runat="server" />
                        <label for="chk_ISHtml" class="select">允许生成静态页</label>
                        <input type="checkbox" name="chk_ISComment" id="chk_ISComment" runat="server" />
                        <label for="chk_ISComment" class="select">是否允许评论</label>
                    </td>
                </tr>
             </table>
            </div>
            
            <!--高级-->
            <div id="advancedSeting" class="tab_hiden">
                <table cellpadding="10" cellspacing="1" class="table_form">
                    <tr>
                        <td class="main_bleft split">
                            站点ID:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_SiteID" class="textbox" runat="server" />
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
                     <tr>
                        <td class="main_bleft split">
                            封面模版:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_IndexTemplet" class="textbox" runat="server" />
                            <img src="../images/blue/s.gif" class="s" alt="选择封面模版" title="选择封面模版" />
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            列表模版:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ListTemplet" class="textbox" runat="server" />
                            <img src="../images/blue/s.gif" class="s" alt="选择列表模版" title="选择列表模版" />
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            文档模版:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ArchiveTemplet" class="textbox" runat="server" />
                            <img src="../images/blue/s.gif" class="s" alt="选择文档模版" title="选择文档模版" />
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目目录:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ClassPath" class="textbox" runat="server" />
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            列表页规则:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ListRule" class="textbox" runat="server" />
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            文档页规则:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ArchiveRule" class="textbox" runat="server" />
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            栏目图片地址:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_ImgUrl" class="textbox" runat="server" />
                            <img src="../images/blue/s.gif" class="s" alt="上传栏目图片" title="上传栏目图片" />
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft split">
                            Meta关键字:
                        </td>
                        <td class="main_bright split">
                            <input type="text" id="txt_Keywords" class="textbox" runat="server" />
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
                    <tr>
                        <td class="main_bleft">
                            Meta描述:
                        </td>
                        <td class="main_bright">
                            <textarea id="txts_Description" runat="server" style="width:430px; height:106px;"></textarea>
                            <a href="##" class="help" title="查看帮助">帮助</a>
                        </td>
                    </tr>
               </table>
            </div>
            
            <!--栏目内容-->
            <div id="classContent" class="tab_hiden">
                <FCKeditorV2:FCKeditor ID="txt_Content" runat="server" Height="407px"></FCKeditorV2:FCKeditor>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
