<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaseSetting.aspx.cs" Inherits="DTCMS.Web.admin.sys.BaseSetting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>基本设置</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>

    <script type="text/javascript" src="../../inc/dialog/dialog.js"></script>

    <script type="text/javascript" src="../js/common.js"></script>

    <style type="text/css">
        #container
        {
            width: 980px;
            margin: 0 auto;
            text-align: center;
        }
        em
        {
            border: 0;
            font-size: 12px;
        }
        #tab_menu a
        {
            font-size: 13px;
        }
        .hr
        {
            height: 10px;
            line-height: 10px;
            overflow: hidden;
            border: 0;
            clear: both;
        }
        #tagmanage table, #tagmanage tr, #tagmanage td, #authormanage table, #authormanage tr, #authormanage td, #newssourcemanage table, #newssourcemanage tr, #newssourcemanage td
        {
            border: 0px;
        }
        fieldset
        {
            border: #CCCCCC 1px solid;
            padding-bottom: 20px;
        }
        legend
        {
            font-weight: bold;
            line-height: 45px;
            padding-left: 45px;
            -moz-background-clip: border;
            -moz-background-origin: padding;
            -moz-background-size: auto auto;
            background: transparent url(../images/ico/ico_Success_Small.gif) no-repeat scroll 6px 5px;
        }
        .multiLine
        {
            height: 120px;
            width: 90%;
            vertical-align: top;
        }
    </style>

    <script type="text/javascript">
        $(document).ready(function() {
            ajax_bs_tag("list");
            ajax_bs_author("list");
            ajax_bs_newssource("list");
        });
    </script>

</head>
<body>
    <div id="container">
        <fieldset>
            <legend>数据字典</legend>
            <div id="tag">
                <div style="text-align: left; padding-left: 5%;">
                    <em>关键字(TAG):</em></div>
                <input type="text" id="txt_tagname" name="tagname" class="textbox multiLine" />
            </div>
            <div class="hr">
            </div>
            <div id="author">
                <div style="text-align: left; padding-left: 5%;">
                    <em>作 者:</em></div>
                <input type="text" id="txt_authorname" name="authorname" class="textbox multiLine" />
            </div>
            <div class="hr">
            </div>
            <div id="newssource">
                <div style="text-align: left; padding-left: 5%;">
                    <em>文章来源:</em></div>
                <input type="text" id="txt_newssourcename" name="newssourcename" class="textbox multiLine" />
            </div>
        </fieldset>
        <div class="hr">
        </div>
        <div style="text-align: center">
            <input type="button" id="btn_add_newssource" class="button b1" value="保存" onclick="save_newssource();" /></div>
    </div>

    <script type="text/javascript">

        /*=======Tag=========*/
        function show_tag(obj) {
            selectTab('tab1', obj);
            ajax_bs_tag("list");
        }
        function save_tag() {
            var title = $("#txt_tagname").val();
            ajax_bs_tag("save", title);
        }

        function list_tag(responseText) {
            $("#txt_tagname").val(responseText);
        }

        function ajax_bs_tag(method, title) {
            $.ajax({
                url: "/admin/ajax/basesetting_list.aspx",
                type: "GET",
                data: "action=tag&method=" + method + "&title=" + escape(title) + "&ran=" + Math.random(),
                success: function(responseText) {
                    switch (method) {
                        case "save":
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
        function save_author() {
            var title = $("#txt_authorname").val();
            ajax_bs_author("save", title);
        }
        function list_author(responseText) {
            $("#txt_authorname").val(responseText);
        }
        function ajax_bs_author(method, title) {
            $.ajax({
                url: "/admin/ajax/basesetting_list.aspx",
                type: "GET",
                data: "action=author&method=" + method + "&title=" + escape(title) + "&ran=" + Math.random(),
                success: function(responseText) {
                    switch (method) {
                        case "save":
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
        function save_newssource() {
            var title = $("#txt_newssourcename").val();
            ajax_bs_newssource("save", title);
        }
        function list_newssource(responseText) {
            $("#txt_newssourcename").val(responseText);
        }
        function ajax_bs_newssource(method, title) {
            $.ajax({
                url: "/admin/ajax/basesetting_list.aspx",
                type: "GET",
                data: "action=newssource&method=" + method + "&save=" + escape(title) + "&ran=" + Math.random(),
                success: function(responseText) {
                    switch (method) {
                        case "save":
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
