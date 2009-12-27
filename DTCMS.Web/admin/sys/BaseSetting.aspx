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
    <script type="text/javascript">
        $(document).ready(function() {
            LoadDataTag();
        });
        function LoadDataTag() {
            ajax_bs_tag("list");
        }
    </script>
</head>
<body>
    <form runat="server" id="form1">
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a onclick="selectTab('tab1',this)" href="javascript:void(0)">关键字(TAG)</a></li>
            </ul>
        </div>
       <%-- 关键字TAG--%>
        <div id="tab1" class="tab_show"> 
            <div id="taglist"></div>
            <div id="hr"></div>
            <div id="tagmanage">
                <table cellpadding="0" cellspacing="0" width="100%" class="table_form">
                    <tbody>
                        <tr>
                            <td class="main_bleft split">TAG名称</td>
                            <td class="main_bright split">
                                <input type="text" id="txt_tagname" name="tagname" class="textbox short" />
                                <span style="color:#FA001A;text-align:center;">*</span>
                                <input type="button" id="btn_add" class="button b1" value="保存" onclick="add_tag();" />
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
    <script type="text/javascript">
    
    /*=======Tag=========*/
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
    </script>
</body>
</html>
