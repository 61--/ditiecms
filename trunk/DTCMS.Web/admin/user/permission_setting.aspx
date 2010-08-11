<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="permission_setting.aspx.cs" Inherits="DTCMS.Web.admin.permission_setting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>权限配置</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <script type="text/javascript" src="../js/jquery.min.js"></script>
    <script type="text/javascript" src="../../inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/public.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="../../inc/treetable/TableTree4J.js"></script>
    <style type="text/css">
        html,body{
            height:100%;
        }
        img{
        	vertical-align:middle;
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
            text-indent: 10px;
        }
        .GridTreeHead td{
            line-height: 28px;
            height: 28px;
            font-weight: bold;
            text-indent: 10px;
            border-top: 1px solid #D3E0ED;
            border-bottom: 1px solid #D3E0ED;
            background: url(../images/blue/th_bg.gif) right bottom no-repeat;
        }
        .GridTreeHead a{
            white-space: nowrap;
            text-decoration: none;
        }
        .GridTreeHead .bleft{   
	        background-position:left bottom;
        }

        .mlist{
            width: 100%;
            font-size: 12px;
            border: 1px #CAD9EA solid;
            border-collapse: collapse;
        }
        .mlist td{
            vertical-align:middle;
        }
        .mlist th{
            line-height: 26px;
            height: 26px;
            font-weight: bold;
            text-indent: 10px;
            border-top: 1px solid #D3E0ED;
            border-bottom: 1px solid #D3E0ED;
        }
        .mlist .mt
        {
        	font-weight:bold;
        	line-height:24px;
        	text-indent: 10px;
        }
        .mlist .mi
        {
        	line-height: 22px;
        	text-indent: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<%--    <div id="container">
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a href="javascript:;">权限配置</a></li>
            </ul>
        </div>--%>
        <div id="gridTreeDiv"></div>
    <%--</div>--%>
    
        <%= GetModulesByControl()%>
    </form>
    <script type="text/javascript">
        $(document).ready(function() {
            //LoadData();
        });
        function LoadData() {
            var callback = function(res) {
                if (res.error) {
                    alert("请求错误，请刷新页面重试！\n" + res.error.Message);
                    return;
                }
                showGridTree(res.value);
            }
            DTCMS.Web.admin.permission_setting.GetModulesJsonData(callback);
        }
        var gridTree;
        function showGridTree(json) {
            gridTree = new TableTree4J("gridTree", false, false);
            gridTree.config.useIcon = true;
            gridTree.config.useLine = true;
            gridTree.config.booleanHighLightRow = false;
            gridTree.tableDesc = "<table id=\"tab\" class=\"GridTree\">";

            var headerDataList = new Array("模块名称", "权限设置");
            var widthList = new Array("50%", "50%");

            gridTree.setHeader(headerDataList, -1, widthList, true, "GridTreeHead", "", "", "");
            //设置列样式
            gridTree.gridHeaderColStyleArray = new Array("", "bleft");
            gridTree.gridDataCloStyleArray = new Array("", "");
            if (json != "") {
                var data = eval("data=" + json).dataTable;
                $.each(data, function(i, n) {
                    var dataList = new Array(n.modulename, n.moduleid);
                    gridTree.addGirdNode(dataList, n.moduleid, n.parentid == "M0" ? -1 : n.parentid, null, n.orderid, "");
                });
            }
            gridTree.printTableTreeToElement("gridTreeDiv");
        }
    </script>
</body>
</html>
