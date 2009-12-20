﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DTCMS.Web.admin.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>DTCMS内容管理系统</title>
    <link href="css/blue_index.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
    <script type="text/javascript" src="js/common.js"></script>
    <script type="text/javascript">
        $(document).ready(function() {
            openMenu(0, '');
            popTip('H0201002');
        });
        function popTip(msg, func, w, h) {
            var width = w || 260,
            height = h || 110;
            var diag = new Dialog({
                Width: width,
                Height: height,
                Modal: -1
            });
            diag.ID = "popTip";
            diag.AutoClose = 30
            diag.Drag = false;
            diag.Top = "100%";
            diag.Left = "100%";
            diag.ShowButtonRow = true;
            diag.Title = "系统消息";
            diag.CancelEvent = function() {
                diag.close();
                if (func) func();
            };
            diag.InnerHtml = '<div style="padding:10px;">' + msg + '</div>';
            diag.show();
            diag.okButton.parentNode.style.textAlign = "right";
            diag.okButton.value = "查 看";
            diag.cancelButton.value = "关 闭";
            diag.cancelButton.focus();
        }
        function changeMenu(n) {
            if (n == 0) {
                if ($("#side").width() == 0) {
                    $("#side").width(176);
                } else {
                    $("#side").width(0);
                }
            } else {
                $("#side").width($("#side").width() + n);
            }
        }
        var preID = 0;
        function openMenu(cid, url) {
            $("#d" + cid).attr("class","thisclass");
            if (preID > 0 && preID != cid)
                $("#d" + preID).attr("class","");
            preID = cid;
            if (url != "") {
                document.getElementById("main_body").src = url;
            }
            $.ajax({
                url: "menu.aspx",
                type: "GET",
                data: "cid=" + cid,
                beforeSend: function() {
                    $("#ajaxloading").show();
                },
                success: function(data) {
                    $("#left_menu").html(data);
                    $("#ajaxloading").fadeOut(500);
                }
            });
        }
        function showHide(item) {
            $("#" + item).slideToggle(200);
        }
        function frameRedirect(url) {
            $("#ajaxloading").show();
            document.getElementById("main_body").src = url;
        }
    </script>

</head>
<body>
    <div class="top">
        <div class="topnav">
            <div id="ajaxloading">
                正在加载数据,请稍候...</div>
            <div class="sitenav">
                <div class="welcome">
                    你好<span class="username"></span>
                </div>
                <div class="welcome">
                    <a href="javascript:changeMenu(-10)">
                        <img src="images/blue/frame-l.gif" alt="减小左框架" /></a> <a href="javascript:changeMenu(0)">
                            <img src="images/blue/frame_on.gif" alt="隐藏/显示左框架" /></a> <a href="javascript:changeMenu(10)"
                                title="增大左框架">
                                <img src="images/blue/frame-r.gif" alt="增大左框架" /></a>
                </div>
                <div class="sitelink">
                    <a href="javascript:openMenu(0,'','main_index.aspx',0)">管理主页</a> | <a href="#">注销登陆</a>
                </div>
            </div>
            <div class="leftnav">
                <ul>
                    <li class="navleft"></li>
                    <li id="d1"><a href="javascript:openMenu(1,'news/Class_list.aspx')">频道管理</a></li>
                    <li id="d2"><a href="javascript:openMenu(2,'news/News_list.aspx')">内容管理</a></li>
                    <li id="d3"><a href="javascript:openMenu(3,'news/news_list.html')">生成管理</a></li>
                    <li id="d4"><a href="javascript:openMenu(4,'main_index.aspx')">采集管理</a></li>
                    <li id="d5"><a href="javascript:openMenu(5,'main_index.aspx')">多媒体</a></li>
                    <li id="d6"><a href="javascript:openMenu(6,'main_index.aspx')">插件管理</a></li>
                    <li id="d7"><a href="javascript:openMenu(7,'main_index.aspx')">系统管理</a></li>
                    <li class="navright"></li>
                </ul>
            </div>
        </div>
    </div>
    <div id="side" class="side">
        <div id="left_menu" style="padding-top: 6px;">
        </div>
    </div>
    <div id="main" class="main">
        <iframe id="main_body" name="main_body" width="100%" height="100%" onload="$('#ajaxloading').fadeOut(500);" frameborder="0" src="news/class_list.aspx">
        </iframe>
    </div>
    <div class="bottom">
        CopyRight &copy; 2009 <a href="http://www.91aspx.com" target="_blank">www.91aspx.com</a>
        All rights reserved. Powered by <a href="http://www.91aspx.com" target="_blank">DTCMS V1.0</a>
        <div style="display:none;"><script type="text/javascript" src="http://js.users.51.la/3439117.js"></script></div>
    </div>
</body>
</html>
