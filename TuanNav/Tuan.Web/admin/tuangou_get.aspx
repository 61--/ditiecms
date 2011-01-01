<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tuangou_get.aspx.cs" Inherits="Tuan.Web.tuangou_get" %>
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
        var totalSite = 0;
        var curSite = 0;
        var siteList = [];
        var totalCity = <%=citys.Count %>;
        var curCity = 1;
        var isbat = false;
        function getTuanGou() {
            var cityID = $("#ddl_City").val();
            var opt = document.getElementById("ddl_City");     
            var city = opt[opt.selectedIndex].text
            Dialog.confirm('确定要采集 ' + city + ' 的团购商品吗？', function() {
                if (cityID == 0) {
                    cityID = opt[1].value;
                    isbat = true;
                }
                $("#totalProgress").html(opt[curCity].text);
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    url: "?op=GetSiteByCityID&cityID=" + cityID + "&r=" + Math.random(),
                    success: function(data) {
                        if (data.error > 0) {
                            if (data.totalRecord > 0) {
                                totalSite = data.totalRecord;
                                siteList = data.dataTable;
                                $("#beginGet").attr("disabled", "disabled");
                                doingGet();
                            } else {
                                Dialog.alert("该城市没有团购网站！");
                            }
                        } else if (data.error == -1) {
                            showError("获取该城市团购网站数失败！");
                        } else {
                            Dialog.alert(data.message);
                        }
                    }
                });
            });
        }
        function getSiteByCityID() {
            setTotalProgress();
            curCity++;
            if (!isbat || (curCity > totalCity)) {
                Dialog.alert("所有城市团购信息采集完毕！");
                $("#beginGet").attr("disabled", "");
                return false;
            } else {
                var opt = document.getElementById("ddl_City");
                var cityID = opt[curCity].value;
                $("#totalProgress").html(opt[curCity].text);
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    url: "?op=GetSiteByCityID&cityID=" + cityID + "&r=" + Math.random(),
                    success: function(data) {
                        if (data.error > 0) {
                            if (data.totalRecord > 0) {
                                totalSite = data.totalRecord;
                                siteList = data.dataTable;
                                curSite = 0;
                                doingGet();
                            } else {
                                getSiteByCityID();
                            }
                        } else {
                            getSiteByCityID(); ;
                        }
                    }
                });
            }
        }
        function doingGet() {
            if (curSite >= totalSite) {
                getSiteByCityID();
            } else {
                $("#curProgress").html(siteList[curSite].sitename);
                if (siteList[curSite].apitypeid > 0) {
                    $.ajax({
                        type: "POST",
                        dataType: "json",
                        url: "get.aspx?op=get",
                        data: { siteID: siteList[curSite].siteid, apiTypeID: siteList[curSite].apitypeid, apiUrl: siteList[curSite].apiurl, rank: siteList[curSite].rank },
                        success: function(data) {
                        if (data.error > 0) {
                                $("#console ul").prepend('<li class="success">' +siteList[curSite].siteid + ' - ' + siteList[curSite].sitename + '<span>采集成功！</span></li>');
                                curSite++;
                                setCurProgress();
                                setTimeout(doingGet, 10);
                            } else if (data.error == -1) {
                                $("#console ul").prepend('<li class="error">' + siteList[curSite].siteid + ' - ' + siteList[curSite].sitename + '<span>采集失败！' + data.message + '</span></li>');
                                curSite++;
                                setCurProgress();
                                setTimeout(doingGet, 10);
                            } else {
                                Dialog.alert(data.message);
                            }
                        }
                    });
                } else {
                    $("#console ul").prepend('<li class="error">' + siteList[curSite].siteid + ' - ' + siteList[curSite].sitename + '<span>采集失败！未指定API地址类型。</span></li>');
                    curSite++;
                    setCurProgress();
                    setTimeout(doingGet, 10);
                }
            }
        }
        function setTotalProgress() {
            var per = ((curCity / totalCity) * 100).toFixed(2);
            if (!isbat)
                per = 100.00.toFixed(2);
            $("#totalBar .per").html(per + '%');
            $("#totalBar .bar").width(per + '%');
        }
        function setCurProgress() {
            var per = ((curSite / totalSite) * 100).toFixed(2);
            $("#curBar .per").html(per + '%');
            $("#curBar .bar").width(per + '%');
        }
    </script>
</head>
<body>
<!--#include file="header.aspx"-->
<div id="content" class="bodywidth">
    <form id="form1" runat="server">
        <div class="position">当前位置：后台管理 &gt; 团购商品采集</div>
        <div class="toolbar">
            <div style="float:right;">
                团购商品名：<input type="text" id="txt_keyWord" class="input_text" name="txt_keyWord" />
                <input type="button" value="搜索" class="button b2" onclick="search();" />
            </div>
            <div>
                城市：<select id="ddl_City" name="ddl_City">
                    <option value="0">0 - 全部</option>
                    <%for (int i = 0; i < citys.Count; i++){ %>
                        <option value="<%=citys[i]["CityID"] %>">0<%=citys[i]["CityID"] %> - <%=citys[i]["City"] %></option><%} %>
                </select>
                <a id="beginGet" class="button b4" href="javascript:getTuanGou();">开始采集</a>
            </div>
            <div id="progress">
                <div class="progress">
                    总 进 度：<span id="totalProgress"></span>
                    <div id="totalBar" class="progressBar">
                        <span class="per">0%</span>
                        <div style="width: 0%" class="bar"></div>
                    </div>
                </div>
                <div class="progress">
                    当前进度：<span id="curProgress"></span>
                    <div id="curBar" class="progressBar">
                            <span class="per">0%</span>
                            <div style="width: 0%" class="bar"></div>
                    </div>
                </div>
            </div>
            <h3>控制台：</h3>
            <div style="height:350px;border:1px #ddd solid;overflow:auto;">
                <div id="console">
                    <ul></ul>
                </div>
            </div>
        </div>
    </form>
</div>
<!--#include file="footer.aspx"-->
</body>
</html>