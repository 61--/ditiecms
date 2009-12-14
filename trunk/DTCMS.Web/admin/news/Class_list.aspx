<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Class_list.aspx.cs" Inherits="DTCMS.Web.admin.news.Class_list" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>栏目列表</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="/Inc/Dialog/dialog.css" rel="stylesheet" type="text/css" />
    <link href="/Inc/Popup/popup.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="/Inc/Dialog/Dialog.js"></script>
    <script type="text/javascript" src="/Inc/Popup/popup.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="../js/color.js"></script>
    <script type="text/javascript" src="/Inc/treetable/TableTree4J.js"></script>
    <script type="text/javascript">
        $(function() {
            LoadData();
        });
        function LoadData() { 
            $.ajax({
                url: "/admin/ajax/class_list.aspx",
                type: "GET",
                data: "action=load&ran=" + Math.random(),
                success: function(json) {
                    showGridTree(json);
                }               
            });
        }
        var gridTree;
        function showGridTree(json) {
            gridTree = new TableTree4J("gridTree", "/Inc/treetable/",false,true);
            gridTree.config.useLine = false;
            gridTree.tableDesc = "<table id=\"tab\" class=\"GridView\">";
            
            var headerDataList = new Array("栏目名称", "所属类型", "创建时间", "排序","操作");
            var widthList = new Array("4%","32%", "20%", "20%", "10%","10%");

            gridTree.setHeader(headerDataList, -1, widthList, true, "GridHead", "展开/折叠", "header status text", "", "");
            //设置列样式
            gridTree.gridHeaderColStyleArray = new Array("", "", "","","bleft");
            gridTree.gridDataCloStyleArray = new Array("", "", "", "", "");

            if (json != "") {
            var data = eval("data=" + json);
            $.each(data, function(i, n) {
            var dataList = new Array("<a href='Class_add.aspx?Id=" + n.cid + "'>" + n.classname + "</a>", n.classtype, n.adddate, "<input type=\"text\" onfocus=\"getCurValue(this)\" onblur=\"updateSort(" + n.cid + ")\" id=\"order_" + n.cid + "\" class=\"class_order\" value=\"" + n.orderid + "\">", "<a href=\"Class_add.aspx?Id=" + n.cid + "\">修改</a>&nbsp;&nbsp;<a href=\"javascript:DeleteData(" + n.cid + ",false)\">删除</a>");
                gridTree.addGirdNode(dataList, n.cid, n.parentid == 0 ? -1 : n.parentid, null, n.orderid, "");
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
    <form id="form1" runat="server">
        <div id="container">  
            <div id="tab_menu" class="tabs">
                <ul>
                    <li class="tab_on"><a href="javascript:;">栏目管理</a></li>
                </ul>
            </div>
            <div class="toolbar">
                <a href="Class_Add.aspx" class="button b4"><img src="../images/ico/i_add.gif" alt="" />新建栏目</a>
                <a href="javascript:updateData();" class="button b4"><img src="../images/ico/i_edit.gif" alt="" />修改栏目</a>
                <a href="javascript:deleteData(-1,true);" class="button b4"><img src="../images/ico/i_allDelete.gif" alt="" />批量删除</a>
                <a href="javascript:;" onclick="jPrompt('document.getElementById(tab_menu).length')" id="color">标题样式</a>
            </div>
            <div id="gridTreeDiv">
            </div>
            <input type="hidden" id="curOrder" value="" />
        </div>
    </form>
    <script type="text/javascript">
        //*cid:  栏目编号
        function updateData() {
            var input = document.getElementsByName("items");
            var len = input.length;
            for (var i = 0; i < len; i++) {
                if ((input[i].type == "checkbox") && input[i].checked) {
                    window.location.href = "Class_add.aspx?Id=" + input[i].value;
                    return;
                }
            }
            Dialog.alert("请选择要修改的栏目!");
        }
        //cid:  栏目编号
        //flag:  是否批量删除，表示true:批量删除，false:单个删除
        function deleteData(cid, flag) {//删除栏目
            if (flag) {
                var id = GetCheckId();
                if (id == "") {
                    Dialog.alert("请选择要删除的数据!");
                    return;
                }
                else {
                    cid = id;
                }
            }
            Dialog.confirm("确定要删除栏目吗？", function() {
                $.ajax({
                    url: "/admin/ajax/class_list.aspx",
                    type: "GET",
                    data: "action=delete&Id=" + cid + "&ran=" + Math.random(),
                    success: function(responseText) {//提示
                        if (responseText.toString().toUpperCase() == "TRUE") {
                            Dialog.alert("栏目删除成功!");
                            LoadData();
                        } else {
                            Dialog.alert(responseText);
                        }
                    },
                    error: function() {
                        Dialog.alert("栏目删除失败！");
                    }
                });
            });
        }
        //获取当前排序号
        function getCurValue(obj) {
            $("#curOrder").val(obj.value);
        }
        //更新排序
        function updateSort(cid) {
            var curVal = $("#order_" + cid).val();
            if (curVal != $("#curOrder").val()) {
                $.ajax({
                    url: "/admin/ajax/class_list.aspx",
                    type: "GET",
                    data: "action=order&Id=" + cid + "&orderId=" + curVal + "&ran=" + Math.random(),
                    success: function(responseText) {
                        if (responseText > 0) {
                            LoadData();
                        } else if (responseText == -1) {
                            Dialog.alert("栏目排序更新出错！");
                            $("#order_" + cid).val($("#curOrder").val());
                        } else {
                            Dialog.alert("栏目排序更新失败！");
                            $("#order_" + cid).val($("#curOrder").val());
                        }
                    }
                });
            }
        }
</script>
</body>
</html>
