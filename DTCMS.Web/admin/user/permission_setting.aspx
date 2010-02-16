<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="permission_setting.aspx.cs" Inherits="DTCMS.Web.admin.permission_setting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>权限配置</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/public.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="/inc/treetable/TableTree4J.js"></script>
    <script type="text/javascript">
        $(document).ready(function() {
            showLoading();
            LoadData();
            hideMessage();
        });
        function LoadData() {
            $.ajax({
                url: "../ajax/modules_ajax.aspx",
                type: "GET",
                data: "action=load&ran=" + Math.random(),
                success: function(json) {
                    showGridTree(json);
                }
            });
        }
        var gridTree;
        function showGridTree(json) {
            gridTree = new TableTree4J("gridTree", false, false);
            gridTree.config.useIcon=true;
            gridTree.config.useLine=true;
            gridTree.tableDesc = "<table id=\"tab\" class=\"GridTree\">";
            
            var headerDataList = new Array("模块名称", "权限设置");
            var widthList = new Array("30%","70%");

            gridTree.setHeader(headerDataList, -1, widthList, true, "GridTreeHead", "", "", "");
            //设置列样式
            gridTree.gridHeaderColStyleArray = new Array("", "bleft");
            gridTree.gridDataCloStyleArray = new Array("", "");
            if (json != "") {
            var data = eval("data=" + json);
            $.each(data, function(i, n) {
            var dataList = new Array(n.modulename, n.moduleid);
                gridTree.addGirdNode(dataList, n.moduleid, n.parentid == "M0" ? -1 : n.parentid, null, n.orderid, "");
               });
            }
            gridTree.printTableTreeToElement("gridTreeDiv");
        }
    </script>
    <style type="text/css">
        html,body{
            height:100%;
        }
        .table1
        {
            width: 100%;
            height:100%;
	        border-collapse: collapse;
        }
        .table1 td{
            vertical-align:top;
        }
        /*数据列表样式*/
        .GridTree{
            width: 100%;
            font-size: 12px;
            border: 1px #CAD9EA solid;
            border-collapse: collapse;
        }
        .GridTree td{
            vertical-align:middle;
            height: 18px;
            text-indent: 10px;
        }
        .GridTreeHead td{
            line-height: 28px;
            height: 28px;
            font-weight: bold;
            text-indent: 10px;
            background: url(../images/blue/th_bg.gif) right bottom no-repeat;
        }
        .GridTreeHead a{
            white-space: nowrap;
            text-decoration: none;
        }
        .GridTreeHead .bleft{   
	        background-position:left bottom;
        }
        .GridTreeHead td{
            height: 26px;
            text-indent: 10px;
            border-top: 1px solid #D3E0ED;
            border-bottom: 1px solid #D3E0ED;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a href="javascript:;">权限配置</a></li>
            </ul>
        </div>
        <table class="table1">
            <tr>
               <td style="width:170px;">
                    <fieldset style="padding:6px;border:1px solid #BDBCBD;">
                        <legend style="margin-left: 8px;">角色列表</legend>
                        <asp:Repeater ID="rpt_RolesList" runat="server">
                            <HeaderTemplate><ul></HeaderTemplate>
                            <ItemTemplate><li id="<%# Eval("ID") %>"><a href="javascript:;" onclick=""><%# Eval("RoleName")%></a></li>
                            </ItemTemplate>
                            <FooterTemplate></ul></FooterTemplate>
                        </asp:Repeater>
                    </fieldset>
                </td>
                <td style="padding-left:10px;">
                    <div id="gridTreeDiv">
                    </div>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
