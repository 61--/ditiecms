<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DTCMS.Web.admin.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>DTCMS内容管理系统</title>
    <link href="css/blue_index.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="js/common.js"></script>
</head>
<body>
<form id="form1" runat="server">
    <div class="top">
        <div class="topnav">
            <div id="ajaxloading">
                正在加载数据,请稍候...</div>
            <div class="sitenav">
                <div class="welcome">
                    <marquee scrollamount="5" scrolldelay="200" onmouseover="stop()" onmouseout="start()" style="width:350px;">
                        您好<asp:Label ID="lbl_username" runat="server" CssClass="username"></asp:Label>，欢迎您登陆DTCMS网站内容管理系统后台管理中心！
                    </marquee>
                </div>
                <div class="welcome">
                    <a href="javascript:changeMenu(-10)">
                        <img src="images/blue/frame-l.gif" alt="减小左框架" /></a> <a href="javascript:changeMenu(0)">
                        <img src="images/blue/frame_on.gif" alt="隐藏/显示左框架" /></a> <a href="javascript:changeMenu(10)" title="增大左框架">
                        <img src="images/blue/frame-r.gif" alt="增大左框架" /></a>
                </div>
                <div class="sitelink">
                    <a href="javascript:openMenu('M01','controlpanel.aspx')">管理主页</a> | <asp:LinkButton ID="lbn_Logout" OnClick="lbn_Logout_Click" runat="server">注销登陆</asp:LinkButton>
                </div>
            </div>
            <div class="leftnav">
                <asp:Repeater ID="rpt_Topnav" runat="server">
                    <HeaderTemplate><ul><li class="navleft"></li>
                    </HeaderTemplate>
                    <ItemTemplate><li id="<%# Eval("ModuleID") %>"><a href="javascript:;" onclick="openMenu('<%# Eval("ModuleID") %>','<%# Eval("ModuleURL") %>')"><%# Eval("ModuleName")%></a></li>
                    </ItemTemplate>
                    <FooterTemplate><li class="navright"></li>
                </ul></FooterTemplate>
                </asp:Repeater>
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
        <%--<div style="display:none;"><script type="text/javascript" src="http://js.users.51.la/3439117.js"></script></div>--%>
    </div>
</form>
<script type="text/javascript">
    $(document).ready(function() {
        openMenu('M01', 'controlpanel.aspx');
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
    var preID = "M0";
    function openMenu(mid, url) {
        $("#" + mid).attr("class", "thisclass");
        if (preID != "M0" && preID != mid)
            $("#" + preID).attr("class", "");
        preID = mid;
        if (url != "") {
            $("#main_body").attr("src", url);
        }
        DTCMS.Web.admin.index.GetLeftnav(mid, openMenu_callback);
    }
    function openMenu_callback(res) {
        $("#left_menu").html(res.value);
    }
    function toggleMenu(item) {
        $("#" + item).slideToggle(200);
    }
    AjaxPro.onLoading = function(b) {
        if (b) {
            $("#ajaxloading").show();
        } else {
            $("#ajaxloading").fadeOut(500);
        }
    }
    </script>
</body>
</html>
