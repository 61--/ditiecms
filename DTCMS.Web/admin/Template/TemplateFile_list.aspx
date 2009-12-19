<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TemplateFile_list.aspx.cs" Inherits="DTCMS.Web.admin.TemplateFile_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
  <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>模板列表</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="/Inc/Dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
    <script type="text/javascript" src="/Inc/Dialog/Dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="/Inc/treetable/TableTree4J.js"></script>
    <script type="text/javascript">
        $(function() {
            LoadData("/template/default/");
        });

        function LoadData(path) {
            $.ajax({
                url: "/admin/ajax/File_list.aspx",
                type: "GET",
                data: "action=template&path="+path+"&ran=" + Math.random(),
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

            var headerDataList = new Array("模板文件", "模板说明", "大小", "更新时间", "操作");
            var widthList = new Array("4%", "4%", "32%", "20%", "10%", "15%", "15%");

            gridTree.setHeader(headerDataList, -1, widthList, true, "GridHead", "展开/折叠", "header status text", "", "");
            //设置列样式
            gridTree.gridHeaderColStyleArray = new Array("", "", "", "", "bleft");
            gridTree.gridDataCloStyleArray = new Array("", "", "", "", "");
            if (json != "") {
                var data = eval("data=" + json); 
                    
                $.each(data, function(i, n) {
                
                    var title="<a href=\"Template_Edit.aspx?file="+n.FilePath+"\">"+n.FileName+"</a>";
                    var option="<a href=\"Template_Edit.aspx?file="+n.FilePath+"\">编辑</a>&nbsp;&nbsp;<a href=\"###\" onclick=\"DeleteFile("+n.FilePath+")\">删除</a>";
                    if(n.isDirectory==true){
                        title="<a href=\"###\" onclick=\"LoadData("+n.FilePath+")\">"+n.FileName+"</a>";
                        option="<a href=\"Template_Edit.aspx?file="+n.FilePath+"\">编辑</a>";
                    }
                    var dataList = new Array(title, n.FileTitle, n.FileSize, n.UpdateTime.toString(),option);
                    gridTree.addGirdNode(dataList, i+1,-1,null,i+1, "");
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
                <a href="News_Add.aspx" class="button b4"><img src="../images/ico/i_add.gif" alt="" />上传文件</a>
                <a href="javascript:Dialog.alert('您没有权限编辑文章！');" class="button b4"><img src="../images/ico/i_edit.gif" alt="" />编辑模板</a>               
            </div>
			<div id="gridTreeDiv">
			</div>
		</div>
	</div>
    </form>
    <script type="text/javascript">
        //aid:文章编号
        //flag:是否批量删除，true批量删除，false单个删除
        function DeleteFile(path) {
//            if (flag) {
//                var id = GetCheckId();
//                if (id == "") {
//                    Dialog.alert("请选择你要删除的数据!");
//                    return;
//                }
//                else {
//                    aid = id;
//                }
//            }

            Dialog.confirm("确定要删除此模板吗？", function() {
                $.ajax({
                    url: "/admin/ajax/File_list.aspx",
                    type: "GET",
                    data: "action=delete&path=" + path + "&ran=" + Math.random(),
                    success: function(responseText) {//提示
                        if (responseText.toString().toUpperCase() == "TRUE") {
                            LoadData();
                            Dialog.alert("模板删除成功!");
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

