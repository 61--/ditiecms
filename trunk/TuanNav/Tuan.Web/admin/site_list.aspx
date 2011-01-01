<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="site_list.aspx.cs" Inherits="Tuan.Web.admin.site_list" %>
<%@ Register TagPrefix="DT" Assembly="Tuan.Controls" Namespace="Tuan.Controls" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>团来了——您的团购生活导航专家！</title>
    <link href="../css/gobal.css" type="text/css" rel="stylesheet" />
    <link href="../css/admin.css" rel="stylesheet" type="text/css" />
    <link href="../css/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
    <script src="../js/jquery.plugin.js" type="text/javascript"></script>
    <script src="../js/datagrid.js" type="text/javascript"></script>
    <script src="../js/base.js" type="text/javascript"></script>
    <script src="../js/dialog.js" type="text/javascript"></script>
    <script type="text/javascript">
        function formatSiteUrl(n) {
            return '<a href="' + n.siteurl + '" target="_blank">' + n.siteurl + '</a>';
        }
        function formatLogoUrl(n) {
            if (n.logourl == '') {
                return '<img src="/images/noimage.gif" width="120" height="32" />';
            } else {
                return '<img src="' + n.logourl + '" width="120" height="32" />';
            }
        }
        function formatApiUrl(n) {
            if (n.apiurl.length > 25) {
                return '<a href="' + n.apiurl + '" target="_blank">' + n.apiurl.substring(0, 25) + '..</a>';
            } else {
                return '<a href="' + n.apiurl + '" target="_blank">' + n.apiurl + '</a>';
            }
        }
        function formatOperate(n) {
            return '<a href="javascript:addData(' + n.siteid + ');">编辑</a>&nbsp;&nbsp;<a href="javascript:deleteData(' + n.siteid + ');">删除</a>';
        }
        function addData(id) {
            var id = id || 0;
            var diag = new Dialog();
            diag.ID = "addSite"
            diag.Width = 600;
            diag.Height = 350;
            diag.Title = "添加团购网站";
            diag.URL = "site_add.aspx?id=" + id;
            diag.OKEvent = function() {
                var callback = function() { loadData(); };
                diag.innerFrame.contentWindow.addSite(callback);
            };
            diag.show();
        }
        function deleteData(id) {
            Dialog.confirm("是否删除该团购网站？", function() {
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    url: "?op=DeleteTuanSite&ID=" + id + "&r=" + Math.random(),
                    success: function(data) {
                        if (data.error > 0) {
                            showSuccess("删除网站成功！");
                            loadData(false);
                        } else if (data.error == -1) {
                            showError("删除网站失败！");
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
        <div class="position">当前位置：后台管理 &gt; 团购网站管理</div>
        <div class="toolbar">
            <div style="float:right;">
                网站名或域名：<input type="text" id="txt_keyWord" class="input_text" name="txt_keyWord" />
                <input type="button" value="搜索" class="button b2" onclick="search();" />
            </div>
            <a class="button b4" href="javascript:addData();">添加网站</a>
        </div>
        <DT:DataGrid ID="dt_DataGrid" PrimaryKey="SiteID" BindAjaxMethod="GetTuanSiteList" IsPage="true" CssClass="table_data" runat="server">
            <Colunms>
                <DT:CheckBox Visible="false" />
                <DT:RowNumber HeaderText="编号" Increase="false" Visible="true" SortField="SiteID" Width="10%" />
                <DT:ColumnItem HeaderText="区号" DataField="CityID" SortField="CityID" Width="10%" />
                <DT:ColumnItem HeaderText="网站名" DataField="SiteName" Width="15%" />
                <DT:ColumnItem HeaderText="主页地址" DataField="SiteUrl" DataFormat="formatSiteUrl" Width="14%" />
                <DT:ColumnItem HeaderText="Logo地址" DataField="LogoUrl" DataFormat="formatLogoUrl" Width="14%" />
                <DT:ColumnItem HeaderText="API地址" DataField="ApiUrl" SortField="ApiUrl" DataFormat="formatApiUrl" Width="15%" />
                <DT:ColumnItem HeaderText="QQ" DataField="QQ" Width="12%" />
                <DT:ColumnItem HeaderText="操作" DataField="ID" DataFormat="formatOperate" CssClass="bleft" Width="10%" />
            </Colunms>
        </DT:DataGrid>
    </form>
</div>
<!--#include file="footer.aspx"-->
</body>
</html>
