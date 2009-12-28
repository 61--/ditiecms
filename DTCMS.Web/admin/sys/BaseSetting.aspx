<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaseSetting.aspx.cs" Inherits="DTCMS.Web.admin.sys.BaseSetting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>基本设置</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="../../inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <style type="text/css">
        #tab_menu a{ font-size:13px;}
        .hr{ height:16px; line-height:16px; overflow:hidden;}
        #tagmanage table,#tagmanage tr,#tagmanage td,#authormanage table,#authormanage tr,#authormanage td,#newssourcemanage table,#newssourcemanage tr,#newssourcemanage td{border:0px;}
         fieldset{border:#CCCCCC 1px solid; }
         legend{ font-weight:bold; line-height:45px; padding-left:45px;-moz-background-clip:border;-moz-background-origin:padding;-moz-background-size:auto auto; background:transparent url(../images/ico/ico_Success_Small.gif) no-repeat scroll 6px 5px;}
    </style>
    <script type="text/javascript">
        $(document).ready(function() {
            ajax_bs_tag("list");
        });
    </script>    
</head>
<body>
    <div id="container">
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a onclick="show_tag(this);" href="javascript:void(0)">关键字</a></li>
                <li><a onclick="show_author(this);" href="javascript:void(0)">作 者</a></li>
                <li><a onclick="show_newssource(this);" href="javascript:void(0)">文章来源</a></li>
            </ul>
        </div>
       <%-- 关键字TAG--%>
        <div id="tab1" class="tab_show"> 
            <div id="taglist"></div>
            <div class="hr"></div>
            <div id="tagmanage">
                <fieldset><legend>TAG</legend>
                    <table cellpadding="0" cellspacing="0" width="100%" border="0" class="table_form">
                        <tbody>
                            <tr>
                                <td class="main_bleft split">TAG名称:</td>
                                <td class="main_bright split">
                                    <input type="text" id="txt_tagname" name="tagname" class="textbox short" />
                                    <span style="color:#FA001A;text-align:center;">*</span>                                
                                </td>
                            </tr>
                            <tr>
                                <td class="main_bleft split"></td>
                                <td class="main_bright split">
                                    <input type="button" id="btn_add" class="button b1" value="保存" onclick="add_tag();" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </fieldset>
            </div>
        </div>
        <%-- 作者--%>
        <div id="tab2" class="tab_hiden">
            <div id="authorlist"></div>
            <div class="hr"></div>
            <div id="authormanage">
                <fieldset><legend>作者</legend>
                    <table cellpadding="0" cellspacing="0" width="100%" border="0" class="table_form">
                        <tbody>
                            <tr>
                                <td class="main_bleft split">名 称:</td>
                                <td class="main_bright split">
                                    <input type="text" id="txt_authorname" name="authorname" class="textbox short" />
                                    <span style="color:#FA001A;text-align:center;">*</span>
                                </td>
                            </tr>
                            <tr>
                                <td class="main_bleft split">电子邮件:</td>
                                <td class="main_bright split">
                                    <input type="text" id="txt_authoremail" name="authoremail" class="textbox short" />
                                </td>
                            </tr>
                            <tr>
                                <td class="main_bleft split"></td>
                                <td class="main_bright split">
                                    <input type="button" id="add_author" class="button b1" value="保存" onclick="add_author();" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </fieldset>
            </div>
        </div>    
        <%--文章来源--%>
        <div id="tab3" class="tab_hiden">
            <div id="newssourcelist"></div>
            <div class="hr"></div>
            <div id="newssourcemanage">
                <fieldset><legend>文章来源</legend>
                    <table cellpadding="0" cellspacing="0" width="100%" border="0" class="table_form">
                        <tbody>
                            <tr>
                                <td class="main_bleft split">标 题:</td>
                                <td class="main_bright split">
                                    <input type="text" id="txt_newssourcename" name="newssourcename" class="textbox short" />
                                    <span style="color:#FA001A;text-align:center;">*</span>
                                </td>
                            </tr>
                            <tr>
                                <td class="main_bleft split">链接地址:</td>
                                <td class="main_bright split">
                                    <input type="text" id="txt_mewssourceurl" name="mewssourceurl" class="textbox short" />
                                </td>
                            </tr>
                            <tr>
                                <td class="main_bleft split"></td>
                                <td class="main_bright split">
                                    <input type="button" id="btn_add_newssource" class="button b1" value="保存" onclick="add_newssource();" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </fieldset>
            </div>
        </div>
    </div>
    <script type="text/javascript">

        /*=======Tag=========*/
        function show_tag(obj) {
            selectTab('tab1', obj);
            ajax_bs_tag("list");
        }
        function clear_tag() {
            $("#txt_tagname").val("");
        }
        function add_tag() {
            var name = $("#txt_tagname");
            var val = name.val();
            if (val == "" || val == null) {
                Dialog.alert("TAG名称 不能为空!");
                name.focus();
                return;
            }
            ajax_bs_tag("add", val);
        }
        function del_tag(tagname) {
            if (tagname == "" || tagname == null) {
                Dialog.alert("请选择要删除数据!");
                return;
            }
            ajax_bs_tag("delete", tagname);
        }
        function list_tag(responseText) {
            $("#taglist").html(responseText);
        }
        function ajax_bs_tag(method, name) {
            $.ajax({
                url: "/admin/ajax/basesetting_list.aspx",
                type: "GET",
                data: "action=tag&method=" + method + "&name=" + escape(name) + "&ran=" + Math.random(),
                success: function(responseText) {
                    switch (method) {
                        case "add":
                            clear_tag();
                        case "delete":
                            Dialog.alert(responseText);
                            ajax_bs_tag("list");
                            break;
                        case "list":
                            list_tag(responseText);
                            break;
                        default:
                            break;
                    }
                }
            });
        } /*=======Tag=========*/

        /*=======Author=========*/
        function show_author(obj) {
            selectTab('tab2', obj);
            ajax_bs_author("list");
        }
        function clear_author() {
            $("#txt_authorname").val("");
            $("#txt_authoremail").val("");
        }
        function add_author() {
            var name = $("#txt_authorname");
            var email = $("#txt_authoremail");
            var nameval = name.val();
            var emailval = email.val();
            if (nameval == "" || nameval == null) {
                Dialog.alert("作者名称 不能为空!");
                name.focus();
                return;
            }
            ajax_bs_author("add", nameval, emailval);
        }
        function del_author(authorname) {
            if (authorname == "" || authorname == null) {
                Dialog.alert("请选择要删除数据!");
                return;
            }
            ajax_bs_author("delete",authorname);
        }
        function list_author(responseText) {
            $("#authorlist").html(responseText);
        }
        function ajax_bs_author(method, name,email) {
            $.ajax({
                url: "/admin/ajax/basesetting_list.aspx",
                type: "GET",
                data: "action=author&method=" + method + "&name=" + escape(name) + "&email=" + escape(email) + "&ran=" + Math.random(),
                success: function(responseText) {
                    switch (method) {
                        case "add":
                            clear_author();
                        case "delete":
                            Dialog.alert(responseText);
                            ajax_bs_author("list");
                            break;
                        case "list":
                            list_author(responseText);
                            break;
                        default:
                            break;
                    }
                }
            });
        } /*=======Author=========*/
        
        /*=====newssource=======*/
        function show_newssource(obj) {
            selectTab('tab3', obj);
            ajax_bs_newssource("list");
        }
        function clear_newssource() {
            $("#txt_newssourcename").val("");
            $("#txt_mewssourceurl").val("");
        }
        function add_newssource() {
            var name = $("#txt_newssourcename");
            var url = $("#txt_mewssourceurl");
            var nameval = name.val();
            var urllval = url.val();
            if (nameval == "" || nameval == null) {
                Dialog.alert("文章来源标题 不能为空!");
                name.focus();
                return;
            }
            ajax_bs_newssource("add", nameval, urllval);
        }
        function del_newssource(newssourcename) {
            if (newssourcename == "" || newssourcename == null) {
                Dialog.alert("请选择要删除数据!");
                return;
            }
            ajax_bs_newssource("delete", newssourcename);
        }
        function list_newssource(responseText) {
            $("#newssourcelist").html(responseText);
        }
        function ajax_bs_newssource(method, name, url) {
            $.ajax({
                url: "/admin/ajax/basesetting_list.aspx",
                type: "GET",
                data: "action=newssource&method=" + method + "&name=" + escape(name) + "&url=" + escape(url) + "&ran=" + Math.random(),
                success: function(responseText) {
                    switch (method) {
                        case "add":
                            clear_newssource();
                        case "delete":
                            Dialog.alert(responseText);
                            ajax_bs_newssource("list");
                            break;
                        case "list":
                            list_newssource(responseText);
                            break;
                        default:
                            break;
                    }
                }
            });
        } /*=====newssource=======*/
    </script>
</body>
</html>
