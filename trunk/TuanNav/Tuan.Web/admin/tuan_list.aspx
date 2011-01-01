<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tuan_list.aspx.cs" Inherits="Tuan.Web.admin.tuan_list" %>
<%@ Register TagPrefix="DT" Assembly="Tuan.Controls" Namespace="Tuan.Controls" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>团来了——您的团购生活导航专家！</title>
    <link href="../css/gobal.css" type="text/css" rel="stylesheet" />
    <link href="../css/admin.css" rel="stylesheet" type="text/css" />
    <link href="../css/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
    <script src="../js/jquery.plugin.js" type="text/javascript"></script>
    <script src="../js/datagrid.js" type="text/javascript"></script>
    <script src="../js/dialog.js" type="text/javascript"></script>
    <script src="../js/base.js" type="text/javascript"></script>
    <script type="text/javascript">
        function formatTitle(n) {
            var title;
            if (n.title.length > 30) {
                title = n.title.substring(0, 30) + '..';
            }
            return title;
        }
        function formatStatu(n){
            switch (n.statu) {
                case '0':
                    return '<a class="unaudited" href="javascript:;" onclick="editStatu(' + n.tuanid + ',this);">未审核</a>';
                case '1':
                    return '<a class="normal">正常</a>';
                case '2':
                    return '<a class="sellup">卖光了</a>';
                case '3':
                    return '<a class="end">已结束</a>';
                default:
                    return '未知';
            }
        }
        function formatOperate(n) {
            return '<a href="javascript:addData(' + n.tuanid + ');">编辑</a>&nbsp;&nbsp;<a href="javascript:deleteData(' + n.tuanid + ');">删除</a>';
        }
        function addData(id) {
            var id = id || 0;
            var diag = new Dialog();
            diag.ID = "addTuanGou"
            diag.Width = 780;
            diag.Height = 550;
            diag.Title = "添加团购商品";
            diag.URL = "tuan_add.aspx?id=" + id;
            diag.OKEvent = function() {
                var callback = function() { loadData(); };
                diag.innerFrame.contentWindow.addTuanGou(callback);
            };
            diag.show();
        }
        function deleteData(id) {
            Dialog.confirm("是否删除该团购商品？", function() {
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    url: "?op=DeleteTuanGou&ID=" + id + "&r=" + Math.random(),
                    success: function(data) {
                        if (data.error > 0) {
                            showSuccess("删除团购商品成功！");
                            loadData(false);
                        } else if (data.error == -1) {
                            showError("删除团购商品失败！");
                        } else {
                            Dialog.alert(data.message);
                        }
                    }
                });
            });
        }
        function editStatu(id, obj) {
            Dialog.confirm("是否审核该团购商品？", function() {
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    url: "?op=EditStatu&statu=1&ID=" + id + "&r=" + Math.random(),
                    success: function(data) {
                        if (data.error > 0) {
                            showSuccess("审核团购商品成功！");
                            obj.innerHTML = '正常';
                            obj.className = 'normal';
                            obj.onclick = null;
                        } else if (data.error == -1) {
                            showError("审核团购商品失败！");
                        } else {
                            Dialog.alert(data.message);
                        }
                    }
                });
            });
        }
        function search() {
            keyWord = $("#txt_keyWord").val();
            totalRecord = -1;
            loadData();
        }
    </script>
</head>
<body>
<!--#include file="header.aspx"-->
<div id="content" class="bodywidth">
    <form id="form1" runat="server">
        <div class="position">当前位置：后台管理 &gt; 团购商品管理</div>
        <div class="toolbar">
            <div style="float:right;">
                团购商品名：<input type="text" id="txt_keyWord" class="input_text" name="txt_keyWord" />
                <input type="button" value="搜索" class="button b2" onclick="search();" />
            </div>
            <a class="button b4" href="javascript:addData();">添加团购</a>
        </div>
        <DT:DataGrid ID="dt_DataGrid" PrimaryKey="TuanID" BindAjaxMethod="GetTuanGouList" IsPage="true" CssClass="table_data" runat="server">
            <Colunms>
                <DT:CheckBox Visible="false" />
                <DT:RowNumber HeaderText="编号" Increase="false" Visible="true" SortField="TuanID" Width="6%" />
                <DT:ColumnItem HeaderText="分类" DataField="CName" Width="12%" />
                <DT:ColumnItem HeaderText="城市" DataField="City" Width="9%" />
                <DT:ColumnItem HeaderText="商品名称" DataFormat="formatTitle" Width="34%" />
                <DT:ColumnItem HeaderText="添加时间" DataField="AddDate" Width="15%" />
                <DT:ColumnItem HeaderText="状态" DataFormat="formatStatu" Width="6%" />
                <DT:ColumnItem HeaderText="操作" DataFormat="formatOperate" CssClass="bleft" Width="8%" />
            </Colunms>
        </DT:DataGrid>
    </form>
</div>
<!--#include file="footer.aspx"-->
</body>
</html>