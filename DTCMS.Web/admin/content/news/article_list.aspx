﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="article_list.aspx.cs" Inherits="DTCMS.Web.admin.News_list" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>文章列表</title>
    <link href="../../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../../js/common.js"></script>
    <script type="text/javascript" src="../../js/public.js"></script>
    <script type="text/javascript" src="/inc/treetable/TableTree4J.js"></script>
    <script type="text/javascript">
        $(function() {
            showLoading();
            loadData(1);
            hideMessage();
        });

        function loadData(page) {
            $.ajax({
                url: "../../ajax/news_list.aspx",
                type: "GET",
                data: "action=load&page="+page+"&ran=" + Math.random(),
                success: function(json) {
                    showGridTree(json);
                }
            });
        }
        var gridTree;
        function showGridTree(json) {
            gridTree = new TableTree4J("gridTree", true, true);
            gridTree.tableDesc = "<table id=\"tab\" class=\"GridView\">";

            var headerDataList = new Array("文章标题", "所属栏目", "创建时间", "是否审核", "操作");
            var widthList = new Array("4%", "4%", "32%", "20%", "20%", "10%", "10%");

            gridTree.setHeader(headerDataList, -1, widthList, true, "GridHead", "", "", "");
            //设置列样式
            gridTree.gridHeaderColStyleArray = new Array("", "", "", "", "bleft");
            gridTree.gridDataCloStyleArray = new Array("", "", "", "", "");

            if (json != "") {
                var data = eval("data=" + json);
                $.each(data, function(i, n) {
                var dataList = new Array("<a href=\"article_add.aspx?Id=" + n.id + "\">" + n.title + "</a>", n.classname, n.adddate,
                    n.isverify==1?"<a href=\"javascript:;\" onclick=\"verifyData(" + n.id + ",false,this)\">已审核</a>":"<a href=\"javascript:;\" onclick=\"verifyData(" + n.id + ",false,this)\" style=\"color:red\">未审核</a>",
                    "<a href=\"article_add.aspx?Id=" + n.id + "\">修改</a>&nbsp;&nbsp;<a href=\"javascript:DeleteData(" + n.id + ",false)\">删除</a>");
                    gridTree.addGirdNode(dataList, n.id,-1,null, n.id, "");
                });
            }
            gridTree.printTableTreeToElement("gridTreeDiv");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server"><div id="container">
		<div id="tab_menu" class="tabs">
			<ul>
				<li class="tab_on"><a href="javascript:;" >文章管理</a></li>
			</ul>
		</div>
		<div id="content">
		    <div class="toolbar">
                <a href="article_add.aspx" class="button b4"><img src="../../images/ico/i_add.gif" alt="" />添加文章</a>
                <a href="javascript:Dialog.alert('您没有权限编辑文章！');" class="button b4"><img src="../../images/ico/i_edit.gif" alt="" />编辑文章</a>
                <a href="javascript:verifyData(-1,true);" class="button b4"><img src="../../images/ico/i_verify.gif" alt="" />审核文章</a>
                <a href="javascript:DeleteData(-1,true);" class="button b4"><img src="../../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
			<div id="gridTreeDiv">
			</div>
			<table>
				<tr>
					<td>
					<div class="grayr">
						<span class="disabled">&lt; </span>
						<span class="current">1</span>
						<a href="javascript:loadData(2)">2</a>
						<a href="javascript:loadData(3)">3</a>
						<a href="javascript:loadData(4)">4</a>
						<a href="javascript:loadData(5)">5</a>
						<a href="javascript:loadData(6)">6</a>
						<a href="javascript:loadData(7)">7</a>...
						<a href="javascript:loadData(199)">199</a>
						<a href="javascript:loadData(200)">200</a>
						<a href="javascript:loadData(2)"> 
						&gt; </a></div>
					</td>
				</tr>
			</table>
		</div>
	</div>
    </form>
    <script type="text/javascript">
        //aid:文章编号
        //flag:是否批量删除，true批量删除，false单个删除
        function DeleteData(aid, flag) {
            if (flag) {
                aid = getCheckId();
                if (aid == "") {
                    Dialog.alert("请选择你要删除的数据!");
                    return;
                }
            }
            Dialog.confirm("确定要删除文章吗？", function() {
                $.ajax({
                    url: "../../ajax/news_list.aspx",
                    type: "GET",
                    data: "action=delete&Id=" + aid + "&ran=" + Math.random(),
                    success: function(responseText) {//提示
                        if (responseText>0) {
                            showSuccess("成功删除"+responseText+"篇文章！");
                            loadData(1);
                            return;
                        }
                        else {
                            showError("删除文章失败！");
                            return;
                        }
                    },
                    error: function() {
                        showError("删除文章失败！");
                        return;
                    }
                });
            });
        }
        //审核文章
        function verifyData(aid, flag, elem) {
            if (flag) {
                aid = getCheckId();
                if (aid == "") {
                    Dialog.alert("请选择要审核的文章!");
                    return;
                }
            }
            $.ajax({
                url: "../ajax/user_ajax.aspx",
                type: "GET",
                data: "action=verify&Id=" + aid + "&ran=" + Math.random(),
                success: function(responseText) {
                    if (responseText > 0) {
                        if(flag){
                            loadData(1);
                            showSuccess("批量审核文章成功！");
                        }else{
                            elem.blur();
                            if(elem.innerHTML=="未审核"){
                                elem.innerHTML="已审核";
                                elem.style.color="black";
                            }else{
                                elem.innerHTML="未审核";
                                elem.style.color="red";
                            }
                        }
                    }else {
                        showError("审核文章失败！");
                    }
                }
            });
    </script>
</body>
</html>