<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News_list.aspx.cs" Inherits="DTCMS.Web.admin.news.News_list" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>文章列表</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="/Inc/Dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="/Inc/Dialog/Dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="/Inc/treetable/TableTree4J.js"></script>
    <script type="text/javascript">
        $(function() {
            LoadData();
        });

        function LoadData() {
            $.ajax({
                url: "/admin/ajax/news_list.aspx",
                type: "GET",
                data: "action=load&ran=" + Math.random(),
                success: function(json) {
                    showGridTree(json);
                }
            });
        }
        var gridTree;
        function showGridTree(json) {
            gridTree = new TableTree4J("gridTree", "/Inc/treetable/",true,true);
            gridTree.config.useLine = false;
            gridTree.tableDesc = "<table id=\"tab\" class=\"GridView\">";

            var headerDataList = new Array("文章标题", "所属栏目", "创建时间", "是否审核", "操作");
            var widthList = new Array("4%", "4%", "32%", "20%", "20%", "10%", "10%");

            gridTree.setHeader(headerDataList, -1, widthList, true, "GridHead", "展开/折叠", "header status text", "", "");
            //设置列样式
            gridTree.gridHeaderColStyleArray = new Array("", "", "", "", "bleft");
            gridTree.gridDataCloStyleArray = new Array("", "", "", "", "");

            if (json != "") {
                var data = eval("data=" + json);
                $.each(data, function(i, n) {
                var dataList = new Array("<a href=\"News_add.aspx?Id=" + n.id + "\">" + n.title + "</a>", n.classname, n.adddate, n.ischecked, "<a href=\"News_add.aspx?Id=" + n.id + "\">修改</a>&nbsp;&nbsp;<a href=\"javascript:DeleteData(" + n.id + ",false)\">删除</a>");
                    gridTree.addGirdNode(dataList, n.id,-1,null, n.id, "");
                });
            }
            gridTree.printTableTreeToElement("gridTreeDiv");
        }
    </script>
    <style type="text/css">
        .GridView{
            width: 100%;
            font-size: 12px;
            border: 1px #CAD9EA solid;
            border-collapse: collapse;
        }
        .GridHead td{
            line-height: 28px;
            height: 28px;
            font-weight: bold;
            text-indent: 10px;
            background: url(../images/blue/th_bg.gif) right bottom no-repeat;
        }
        .GridHead a{
            white-space: nowrap;
            text-decoration: none;
        }
        .GridHead .bleft{   
        	background-position:left bottom;
        }
        .GridView td{
            height: 26px;
            text-indent: 10px;
            border-top: 1px solid #D3E0ED;
            border-bottom: 1px solid #D3E0ED;
        }
        .GridHighLightRow td{
            background: #E0F0FD;
        }
        .class_order
        {
            width:60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server"><div id="container">
		<div id="tab_menu" class="tabs">
			<ul>
				<li class="tab_on"><a href="javascript:;" >后台首页</a></li>
			</ul>
		</div>
		<div id="content">
		    <div class="toolbar">
                <a href="News_Add.aspx" class="button b4"><img src="../images/ico/i_add.gif" alt="" />添加文章</a>
                <a href="javascript:Dialog.alert('您没有权限编辑文章！');" class="button b4"><img src="../images/ico/i_edit.gif" alt="" />编辑文章</a>
                <a href="javascript:DeleteData(-1,true);" class="button b4"><img src="../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
			<div id="gridTreeDiv">
			</div>
		</div>
	</div>
    </form>
    <script type="text/javascript">
        //aid:文章编号
        //flag:是否批量删除，true批量删除，false单个删除
        function DeleteData(aid, flag) {
            if (flag) {
                var id = GetCheckId();
                if (id == "") {
                    Dialog.alert("请选择你要删除的数据!");
                    return;
                }
                else {
                    aid = id;
                }
            }

            Dialog.confirm("确定要删除文章吗？", function() {
                $.ajax({
                    url: "/admin/ajax/news_list.aspx",
                    type: "GET",
                    data: "action=delete&Id=" + aid + "&ran=" + Math.random(),
                    success: function(responseText) {//提示
                        if (responseText.toString().toUpperCase() == "TRUE") {
                            LoadData();
                            Dialog.alert("文章删除成功!");
                        }
                        else {
                            Dialog.alert(responseText);
                        }
                    },
                    error: function() {
                        Dialog.alert("Ajax请求失败！");
                    }
                });
            });
        }
    </script>
</body>
</html>
