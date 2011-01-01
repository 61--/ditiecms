<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tuan_add.aspx.cs" Inherits="Tuan.Web.admin.tuan_add" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>团来了——您的团购生活导航专家！</title>
    <link href="../css/modal.css" rel="stylesheet" type="text/css" />
    <link href="../css/jquery.autocomplete.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
    <script src="../js/jquery.autocomplete.js" type="text/javascript"></script>
    <script src="../js/jquery.validate.js" type="text/javascript"></script>
    <script src="../js/jquery.plugin.js" type="text/javascript"></script>
    <script src="../js/dialog.js" type="text/javascript"></script>
    <script src="../js/site_json.ashx" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
            //为页面控件赋初始值
            $("#ddl_City").val(<%=cityID %>);
            var statu = $("#hid_Statu").val();
            $("#rdo_Statu_" + statu).attr("checked", "checked");
            var siteID = $("#hid_SiteID").val();
            if (siteID != 0) {
                for (var i = 0; i < siteJson.length; i++) {
                    if (siteJson[i].siteid == siteID) {
                        $("#txt_SiteName").val(siteID + ' - ' + siteJson[i].sitename);
                        break;
                    }
                }
            }

            $("#txt_SiteName").autocomplete(siteJson, {
                minChars: 1,
                matchCase: false,
                autoFill: false,
                max: 12,
                afterFun: function(row) {
                    $("#hid_SiteID").val(row.siteid);
                },
                formatItem: function(row, i, max, term) {
                    var v = $("#txt_SiteName").val();
                    return row.siteid + " - " + row.sitename;
                    if (row.siteid.indexOf(v) == 0 || row.spell.indexOf(v) == 0) {
                        return row.siteid + " - " + row.sitename;
                    }
                    else
                        return false;
                },
                formatMatch: function(row, i, max) {
                    return row.siteid + " - " + row.sitename;
                },
                formatResult: function(row) {
                    return row.siteid + " - " + row.sitename;
                },
                reasultSearch: function(row, v) {
                    if (row.data.siteid.indexOf(v) == 0 || row.data.spell.indexOf(v) == 0 || row.data.sitename.indexOf(v) == 0) {
                        return row;
                    }
                    else
                        return false;
                }
            });
        });
        function validateSite() {
            var siteID = $("#txt_SiteID").val();
            if (siteID == "" || siteID.indexOf($("#txt_SiteName").val()) != 0) {
                $("#txt_SiteName").val("");
            }
        }
        function addTuanGou(func) {
            $.ajax({
                type: "POST",
                dataType: "json",
                url: "?op=AddTuanGou&ID=<%=tuanID %>",
                data: $("#form1").formToArray(),
                success: function(data) {
                    var op = '<%=tuanID > 0 ? "编辑" : "添加" %>';
                    if (data.error > 0) {
                        showSuccess(op + "团购商品成功！", null, 1, function() { Dialog.getInstance('addTuanGou').close(); func(); });
                    } else if (data.error == -1) {
                        showError(op + "团购商品失败！");
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
            <th width="18%">商品名称：</th>
            <td colspan="5"><input type="text" id="txt_Title" name="txt_Title" cname="商品名称" validate="required length[6,12]" class="input_text w_xl" runat="server" /><span>*</span></td>
        </tr>
        <tr>
            <th>所在城市：</th>
            <td width="20%">
                <select id="ddl_City" name="ddl_City">
                    <%for (int i = 0; i < cityList.Count; i++){ %>
                        <option value="<%=cityList[i]["CityID"] %>">0<%=cityList[i]["CityID"] %> - <%=cityList[i]["City"] %></option><%} %>
                </select>
                <span>*</span></td>
            <td width="12%" align="right">团购网站：</td>
            <td colspan="3">
                <input type="text" id="txt_SiteName" name="txt_SiteName" class="input_text w_s" onchange="validateSite();" runat="server" /><span>*</span>
                <input type="hidden" id="hid_SiteID" name="hid_SiteID" value="0" runat="server" />
            </td>
        </tr>
        <tr>
            <th>商品类别：</th>
            <td colspan="5">
                <select id="ddl_Category" name="ddl_Category" runat="server"></select><span>*</span></td>
        </tr>
        <tr>
            <th>商品描述：</th>
            <td colspan="5">
                <textarea id="txt_Description" name="txt_Description" style="height:50px" cols="60" rows="200" class="input_text" runat="server"></textarea></td>
        </tr>
        <tr>
            <th>市场价/团购价：</th>
            <td colspan="3"><input type="text" id="txt_MarketPrice" name="txt_MarketPrice" class="input_text w_xxs" dir="rtl" runat="server" /> /
                <input type="text" id="txt_TuanPrice" name="txt_TuanPrice" class="input_text w_xxs" dir="rtl" runat="server" /> 元<span>*</span>
            </td>
            <td width="15%" align="right">折扣：</td>
            <td><input type="text" id="txt_Rebate" name="txt_Rebate" class="input_text w_xxs" dir="rtl" runat="server" /> 折<span>*</span></td>
        </tr>
        <tr>
            <th>总数/已购买：</th>
            <td colspan="3"><input type="text" id="txt_TotalCount" name="txt_TotalCount" class="input_text w_xxs" dir="rtl" runat="server" /> /
                <input type="text" id="txt_BuyCount" name="txt_BuyCount" class="input_text w_xxs" dir="rtl" value="0" runat="server" /> 件<span>*</span></td>
            <td align="right">点击/评论/观点：</td>
            <td><input type="text" id="txt_ClickCount" value="0" name="txt_ClickCount" class="input_text w_xxs" dir="rtl" runat="server" /> /
                <input type="text" id="txt_CommentCount" value="0" name="txt_CommentCount" class="input_text" style="width:50px;" dir="rtl" runat="server" /> /
                <input type="text" id="txt_PointCount" value="0" name="txt_PointCount" class="input_text" style="width:50px;" dir="rtl" runat="server" /> 次</td>
        </tr>
        <tr>
            <th>团购开始/结束时间：</th>
            <td colspan="5">
                <input type="text" id="txt_BeginTime" name="txt_BeginTime" class="input_text" runat="server" /> -
                <input type="text" id="txt_EndTime" name="txt_EndTime" class="input_text" runat="server" /><span>*</span>
            </td>
        </tr>
        <tr>
            <th>团购地址：</th>
            <td colspan="5">
                <input type="text" id="txt_TuanUrl" name="txt_TuanUrl" class="input_text w_l" runat="server" /><span>*</span></td>
        </tr>
        <tr>
            <th>缩略图地址：</th>
            <td colspan="5">
                <input type="text" id="txt_ImageThumbUrl" name="txt_ImageThumbUrl" class="input_text w_l" runat="server" /><span>*</span></td>
        </tr>
        <tr>
            <th>源图片地址：</th>
            <td colspan="5">
                <input type="text" id="txt_ImageUrl" name="txt_ImageUrl" class="input_text w_l" runat="server" /><span>*</span></td>
        </tr>
        <tr>
            <th>商家名称：</th>
            <td colspan="2"><input type="text" id="txt_MerchantName" name="txt_MerchantName" class="input_text w_s" runat="server" /></td>
            <td colspan="2" align="right">商家电话：</td>
            <td><input type="text" id="txt_MerchantPhone" name="txt_MerchantPhone" class="input_text" runat="server" /></td>
        </tr>
        <tr>
            <th>商家地址：</th>
            <td colspan="5">
                <input type="text" id="txt_MerchantAddress" name="txt_MerchantAddress" class="input_text w_xl" runat="server" />
            </td>
        </tr>
        <tr>
            <th>商家位置：</th>
            <td colspan="5">
                <input type="text" id="txt_Longitude" name="txt_Longitude" class="input_text w_xxs" dir="rtl" runat="server" /> （经度）/
                <input type="text" id="txt_Latitude" name="txt_Latitude" class="input_text w_xxs" dir="rtl" runat="server" /> （纬度）
            </td>
        </tr>
        <tr>
            <th>团购评级：</th>
            <td ><input type="text" id="txt_Rank" value="60" name="txt_Rank" class="input_text w_xxs" dir="rtl" runat="server" />（100分）</td>
            <th>排序：</th>
            <td colspan="3"><input type="text" id="txt_OrderID" value="0" name="txt_OrderID" class="input_text w_xxs" dir="rtl" runat="server" /></td>
        </tr>
        <tr>
            <th>团购状态：</th>
            <td colspan="5">
                <input type="radio" id="rdo_Statu_0" name="rdo_Statu" value="0" runat="server" />未审核
                <input type="radio" id="rdo_Statu_1" name="rdo_Statu" value="1" runat="server" checked="true" />正常
                <input type="radio" id="rdo_Statu_2" name="rdo_Statu" value="2" runat="server" />卖光了
                <input type="radio" id="rdo_Statu_3" name="rdo_Statu" value="3" runat="server" />已结束
                <input type="hidden" id="hid_Statu" value="1" runat="server" />
            </td>
            
        </tr>
    </table>
</form>
</body>
</html>
