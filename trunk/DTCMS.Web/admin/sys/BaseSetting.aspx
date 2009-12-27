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
        .hr{ height:16px; line-height:16px; overflow:hidden;}
    #tagmanage table,#tagmanage tr,#tagmanage td,#authormanage table,#authormanage tr,#authormanage td{border:0px;}
    fieldset{border:#4B6888 1px solid;}
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
                <li class="tab_on"><a onclick="show_tag(this);" href="javascript:void(0)">关键字(TAG)</a></li>
                <li><a onclick="show_author(this);" href="javascript:void(0)">作 者</a></li>
            </ul>
        </div>
       <%-- 关键字TAG--%>
        <div id="tab1" class="tab_show"> 
            <div id="taglist"></div>
            <div class="hr"></div>
            <div id="tagmanage">
                <fieldset><legend>添加 Tag</legend>
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
                <fieldset><legend>添加 作者</legend>
                    <table cellpadding="0" cellspacing="0" width="100%" border="0" class="table_form">
                        <tbody>
                            <tr>
                                <td class="main_bleft split">作者名称:</td>
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
    </script>
</body>
</html>
