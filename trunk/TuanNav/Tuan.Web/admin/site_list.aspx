<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="site_list.aspx.cs" Inherits="Tuan.Web.admin.site_list" %>
<%@ Register TagPrefix="DT" Assembly="Tuan.Controls" Namespace="Tuan.Controls" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>�����ˡ��������Ź������ר�ң�</title>
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
            return '<a href="javascript:addData(' + n.siteid + ');">�༭</a>&nbsp;&nbsp;<a href="javascript:deleteData(' + n.siteid + ');">ɾ��</a>';
        }
        function addData(id) {
            var id = id || 0;
            var diag = new Dialog();
            diag.ID = "addSite"
            diag.Width = 600;
            diag.Height = 350;
            diag.Title = "����Ź���վ";
            diag.URL = "site_add.aspx?id=" + id;
            diag.OKEvent = function() {
                var callback = function() { loadData(); };
                diag.innerFrame.contentWindow.addSite(callback);
            };
            diag.show();
        }
        function deleteData(id) {
            Dialog.confirm("�Ƿ�ɾ�����Ź���վ��", function() {
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    url: "?op=DeleteTuanSite&ID=" + id + "&r=" + Math.random(),
                    success: function(data) {
                        if (data.error > 0) {
                            showSuccess("ɾ����վ�ɹ���");
                            loadData(false);
                        } else if (data.error == -1) {
                            showError("ɾ����վʧ�ܣ�");
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
        <div class="position">��ǰλ�ã���̨���� &gt; �Ź���վ����</div>
        <div class="toolbar">
            <div style="float:right;">
                ��վ����������<input type="text" id="txt_keyWord" class="input_text" name="txt_keyWord" />
                <input type="button" value="����" class="button b2" onclick="search();" />
            </div>
            <a class="button b4" href="javascript:addData();">�����վ</a>
        </div>
        <DT:DataGrid ID="dt_DataGrid" PrimaryKey="SiteID" BindAjaxMethod="GetTuanSiteList" IsPage="true" CssClass="table_data" runat="server">
            <Colunms>
                <DT:CheckBox Visible="false" />
                <DT:RowNumber HeaderText="���" Increase="false" Visible="true" SortField="SiteID" Width="10%" />
                <DT:ColumnItem HeaderText="����" DataField="CityID" SortField="CityID" Width="10%" />
                <DT:ColumnItem HeaderText="��վ��" DataField="SiteName" Width="15%" />
                <DT:ColumnItem HeaderText="��ҳ��ַ" DataField="SiteUrl" DataFormat="formatSiteUrl" Width="14%" />
                <DT:ColumnItem HeaderText="Logo��ַ" DataField="LogoUrl" DataFormat="formatLogoUrl" Width="14%" />
                <DT:ColumnItem HeaderText="API��ַ" DataField="ApiUrl" SortField="ApiUrl" DataFormat="formatApiUrl" Width="15%" />
                <DT:ColumnItem HeaderText="QQ" DataField="QQ" Width="12%" />
                <DT:ColumnItem HeaderText="����" DataField="ID" DataFormat="formatOperate" CssClass="bleft" Width="10%" />
            </Colunms>
        </DT:DataGrid>
    </form>
</div>
<!--#include file="footer.aspx"-->
</body>
</html>
