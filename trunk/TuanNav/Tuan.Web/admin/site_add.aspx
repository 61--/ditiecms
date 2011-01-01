<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="site_add.aspx.cs" Inherits="Tuan.Web.admin.site_add" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>团来了——您的团购生活导航专家！</title>
    <link href="../css/modal.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
    <script src="../js/jquery.plugin.js" type="text/javascript"></script>
    <script src="../js/dialog.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function() { 
            $("#ddl_City").val(<%=cityID %>);
            $("#ddl_ApiTypeID").val(<%=apiTypeID %>);
        });
        function addSite(func) {
            $.ajax({
                type: "POST",
                dataType: "json",
                url: "?op=AddSite&ID=<%=siteID %>",
                data: $("#form1").formToArray(),
                success: function(data) {
                    var op = '<%=siteID>0?"编辑":"添加" %>';
                    if (data.error > 0) {
                        showSuccess(op + "站点成功！", null, 1, function() { Dialog.getInstance('addSite').close(); func(); });
                    } else if (data.error == -1) {
                        showError(op + "站点失败！");
                    } else {
                        Dialog.alert(data.message);
                    }
                }
            });
        }
    </script>
</head>
<body>
<form id="form1" method="post" runat="server">
    <table class="input_form">
        <tr>
            <th width="25%">网站名字：</th>
            <td><input type="text" id="txt_SiteName" name="txt_SiteName" class="input_text w_m" runat="server" /><span>*</span></td>
        </tr>
        <tr>
            <th>所在城市：</th>
            <td>
                <select id="ddl_City" name="ddl_City">
                    <%for (int i = 0; i < cityList.Count; i++){ %>
                        <option value="<%=cityList[i]["CityID"] %>">0<%=cityList[i]["CityID"] %> - <%=cityList[i]["City"] %></option><%} %>
                </select>
                <span>*</span></td>
        </tr>
        <tr>
            <th>首页地址：</th>
            <td><input type="text" id="txt_SiteUrl" name="txt_SiteUrl" class="input_text w_m" runat="server" /><span>*</span></td>
        </tr>
        <tr>
            <th>Logo地址：</th>
            <td><input type="text" id="txt_LogoUrl" name="txt_LogoUrl" class="input_text w_m" runat="server" /><span>*</span></td>
        </tr>
        <tr>
            <th>API 类型：</th>
            <td>
                <select id="ddl_ApiTypeID" name="ddl_ApiTypeID">
                    <option value="0">—请选择—</option>
                    <option value="1">百度 Hao123 API</option>
                    <option value="2">方维团购 API</option>
                    <option value="9">最土团购 API</option>
                    <option value="3">Tuan800 API</option>
                    <option value="4">Tuanp API</option>
                    <option value="5">搜狐 Sohu API</option>
                    <option value="6">来优 LetYo API</option>
                    <option value="7">拉手(旧版) API</option>
                    <option value="8">团来了Tuanlet API</option>
                </select>
                <input type="button" value="测试API" onclick="testApi()" class="input_btn" />
            </td>
        </tr>
        <tr>
            <th>API 地址：</th>
            <td><input type="text" id="txt_ApiUrl" name="txt_LogoUrl" class="input_text w_m" runat="server" /></td>
        </tr>
        <tr>
            <th>QQ号：</th>
            <td><input type="text" id="txt_QQ" name="txt_LogoUrl" class="input_text w_m" runat="server" /><span>*</span></td>
        </tr>
        <tr>
            <th>站点类型：</th>
            <td>
                <input type="radio" id="rdo_SiteType_1" name="rdo_SiteType" value="0" runat="server" />个人
                <input type="radio" id="rdo_SiteType_2" name="rdo_SiteType" value="1" runat="server" checked="true" />公司<span>*</span>
            </td>
        </tr>
        <tr>
            <th>网站评级（100分）：</th>
            <td><input type="text" id="txt_Rank" value="60" name="txt_Rank" class="input_text w_m" runat="server" /></td>
        </tr>
        <tr>
            <th>信任度（1-5级）：</th>
            <td><input type="text" id="txt_Trust" value="3" name="txt_Trust" class="input_text w_m" runat="server" /></td>
        </tr>
    </table>
</form>
</body>
</html>
