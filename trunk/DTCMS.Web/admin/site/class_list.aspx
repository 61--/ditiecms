<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="class_list.aspx.cs" Inherits="DTCMS.Web.admin.Class_list" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>栏目列表</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/public.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="/inc/treetable/TableTree4J.js"></script>
    <script type="text/javascript">
        $(document).ready(function() {
            LoadData();
        });
        function LoadData() {
            $.ajax({
                url: "../ajax/class_list.aspx",
                type: "GET",
                data: "action=load&ran=" + Math.random(),
                success: function(json) {
                    showGridTree(json);
                }
            });
        }
        var gridTree;
        function showGridTree(json) {
            gridTree = new TableTree4J("gridTree", false, true);
            gridTree.tableDesc = "<table id=\"tab\" class=\"GridView\">";
            
            var headerDataList = new Array("栏目名称", "所属类型", "创建时间", "排序","操作");
            var widthList = new Array("4%","32%", "20%", "20%", "10%","10%");

            gridTree.setHeader(headerDataList, -1, widthList, true, "GridHead", "", "", "");
            //设置列样式
            gridTree.gridHeaderColStyleArray = new Array("", "", "","","bleft");
            gridTree.gridDataCloStyleArray = new Array("", "", "", "", "");

            if (json != "") {
            var data = eval("data=" + json);
            $.each(data, function(i, n) {
            var dataList = new Array("<a href='class_add.aspx?Id=" + n.cid + "'>" + n.classname + "</a>", n.classtype, n.adddate, "<input type=\"text\" onchange=\"updateSort(" + n.cid + ")\" id=\"order_" + n.cid + "\" class=\"class_order\" value=\"" + n.orderid + "\">", "<a href=\"class_add.aspx?Id=" + n.cid + "\">编辑</a>&nbsp;&nbsp;<a href=\"javascript:deleteData(" + n.cid + ",false)\">删除</a>");
                gridTree.addGirdNode(dataList, n.cid, n.parentid == 0 ? -1 : n.parentid, null, n.orderid, "");
               });
            }
            gridTree.printTableTreeToElement("gridTreeDiv");
        }
    </script>
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
                <a href="class_add.aspx" class="button b4"><img src="../images/ico/i_add.gif" alt="" />新建栏目</a>
                <a href="javascript:editData();" class="button b4"><img src="../images/ico/i_edit.gif" alt="" />修改栏目</a>
                <a href="javascript:deleteData(-1,true);" class="button b4"><img src="../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
            <div id="gridTreeDiv">
            </div>
        </div>
    </form>
    <script type="text/javascript">
        //*cid:  栏目编号
        function editData() {
            var cid=getSingleCheckID();
            if (cid != "") {
                window.location.href = "Class_add.aspx?Id=" + cid;
            } else {
                Dialog.alert("请选择要修改的栏目!");
            }
        }
        //cid:  栏目编号
        //flag:  是否批量删除，表示true:批量删除，false:单个删除
        function deleteData(cid, flag) {//删除栏目
            if (flag) {
                cid = getCheckId();
                if (cid == "") {
                    Dialog.alert("请选择要删除的数据!");
                    return;
                }
            }
            Dialog.confirm("确定要删除栏目吗？", function() {
                $.ajax({
                    url: "../ajax/class_list.aspx",
                    type: "GET",
                    data: "action=delete&Id=" + cid + "&ran=" + Math.random(),
                    success: function(responseText) {//提示
                        if (responseText.toString().toUpperCase() == "TRUE") {
                            showSuccess('栏目删除成功！');
                            LoadData();
                        } else {
                            Dialog.alert(responseText);
                            return;
                        }
                    },
                    error: function() {
                        showError('栏目删除失败！')
                    }
                });
            });
        }
        //更新排序
        function updateSort(cid) {
            var curVal = $("#order_" + cid).val();
            $.ajax({
                url: "../ajax/class_list.aspx",
                type: "GET",
                data: "action=order&Id=" + cid + "&orderId=" + curVal + "&ran=" + Math.random(),
                success: function(responseText) {
                    if (responseText > 0) {
                        LoadData();
                        showSuccess('栏目排序更新成功！')
                    } else if (responseText == -1) {
                        showError('栏目排序更新出错！')
                        $("#order_" + cid).val($("#curOrder").val());
                    } else {
                        showError('栏目排序更新失败！')
                        $("#order_" + cid).val($("#curOrder").val());
                    }
                }
            });
        }        
</script>
</body>
</html>
