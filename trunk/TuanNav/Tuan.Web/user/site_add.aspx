<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="site_add.aspx.cs" Inherits="Tuan.Web.user.site_add" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>团来了——您的团购生活导航专家！</title>
    <link type="text/css" rel="stylesheet" href="../css/gobal.css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
    <script src="../js/jquery.plugin.js" type="text/javascript"></script>
    <script src="../js/base.js" type="text/javascript"></script>
</head>

<body>
<div id="top" class="bodywidth">
	<div id="site_nav">
		<span class="n_a">您好，欢迎来到 TuanLet! 请  <a href="/login.aspx">[登录</a>·<a href="/register.aspx">免费注册]</a></span>
		<span class="n_b">会员中心 | 网址提交 | 帮助中心</span>
	</div>
	<table class="site_basic">
		<tr>
			<td width="300"><a href="/"><img src="images/logo.jpg" alt="团来了" /></a></td>
			<td width="200" style="text-align:left;vertical-align:bottom;padding-bottom:10px;">
			    <span id="city">福州站</span> <span class="changecity">
			    <a href="javascript:;">切换城市</a></span></td>
			<td width="500" style="vertical-align:bottom;padding-bottom:5px;">
			    <div class="search">
			        <input type="text" name="keyword" class="input" id="keyword" /><button type="button" id="btn_search"><img src="images/search_bn.gif" />搜索</button>
			        <span class="text">|&nbsp; <a href="search.aspx">高级搜索</a></span>
			     </div>
			</td>
		</tr>
	</table>
</div>
<div id="nav">
	<ul class="nav_link bodywidth">
		<li class="hover"><a href="#">首 页</a></li>
		<li><a href="#">往期团购</a></li>
		<li><a href="#">团购导航</a></li>
		<li><a href="#">团购导航</a></li>
		<li><a href="#">团购导航</a></li>
		<li><a href="#">团购导航</a></li>
	</ul>
    <div id="scroll_ad" class="bodywidth">
		<ul>
			<li><a target="_blank" href="">1折门票！2折美食！3折精品！最精彩的超级折扣，天天更新，尽在团123！</a></li>
			<li><a target="_blank" href="">团购网站API接口推出，请各团购网做好接口网购将自动收录</a></li>
			<li><a target="_blank" href="">6月25日耗时一晚上零半天更新了风格，好看吧！自己弄的。</a></li>
			<li><a target="_blank" href="">大家好，我是团123，我擅长加班，不擅长追女孩，不擅长讨好老板，爱情、金钱、生活都比较匮乏。不过，我还是有理想有激情的，请告诉身边的人团123，就是便宜！</a></li>
			<li><a target="_blank" href="">百度搜“团购导航”，团123在首屏位置，感谢大家的爱护与支持，特别要感谢一下第一个支持我的嘉肯蒙西服，meituan.hk，搜房网，哲生活，对了，要先感谢国家。</a></li>
			<li><a target="_blank" href="">7月5日下午被攻击，首页错位，团长登录不上去，现已恢复。</a></li>
			<li><a target="_blank" href="">7月7好本站升级程序，增加评论功能，重写部分代码，届时团长登录功能不能使用。需要添加每日一团的站长请联系我个人后台添加</a></li>
			<li><a target="_blank" href="">团123昨天主机挂掉了，今天换主机了，昨天提交的团长请从新提交一下</a></li>
			<li><a target="_blank" href="">Tuan123.com就是便宜，喜欢图便宜的速度记下....</a></li>
			<li><a target="_blank" href="">1折门票！2折美食！3折精品！最精彩的超级折扣，天天更新，尽在团123！</a></li>
		</ul>
	</div>
</div>
<div id="content" class="bodywidth">
    <form id="form1" runat="server">
        <div class="title">网站提交</div>
        <table class="input_form">
            <tr>
                <td class="label">用户名：</td>
                <td><asp:TextBox ID="txt_UserName" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_login" runat="server" Text="登录" onclick="btn_login_Click" />
                </td>
            </tr>
            <tr>
                <td class="label">网站名字：</td>
                <td><input type="text" id="txt_SiteName" runat="server" /><span>*</span></td>
            </tr>
            <tr>
                <td class="label">所在城市：</td>
                <td>
                    <select id="ddl_City" name="ddl_City">
                        <%=GetAllCity() %>
                    </select>
                    <span>*</span></td>
            </tr>
            <tr>
                <td class="label">首页地址：</td>
                <td><input type="text" id="txt_SiteUrl" runat="server" /><span>*</span></td>
            </tr>
            <tr>
                <td class="label">Logo地址：</td>
                <td><input type="text" id="txt_LogoUrl" runat="server" /><span>*</span></td>
            </tr>
            <tr>
                <td class="label">API 地址：</td>
                <td><input type="text" id="txt_ApiUrl" runat="server" /></td>
            </tr>
            <tr>
                <td class="label">QQ号：</td>
                <td><input type="text" id="txt_QQ" runat="server" /><span>*</span></td>
            </tr>
            <tr>
                <td class="label">站点类型：</td>
                <td>
                    <asp:RadioButton ID="rdb_SiteType_1" GroupName="rdb_SiteType" runat="server" Text="个人" />
                    <asp:RadioButton ID="rdb_SiteType_2" GroupName="rdb_SiteType" Checked="true" runat="server" Text="公司" /><span>*</span>
                </td>
            </tr>
            <tr>
                <td class="label">网站评级（100分）：</td>
                <td><input type="text" id="txt_Rank" value="60" runat="server" /></td>
            </tr>
            <tr>
                <td class="label">信任度（1-5级）：</td>
                <td><input type="text" id="txt_Trust" value="3" runat="server" /></td>
            </tr>
            <tr>
                <td class="label"></td>
                <td>
                    <asp:Button ID="btn_AddSite" runat="server" Text="添加网站" 
                        onclick="btn_AddSite_Click" /></td>
            </tr>
        </table>
    </form>
</div>
</body>
</html>