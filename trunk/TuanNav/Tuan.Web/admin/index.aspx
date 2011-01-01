<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Tuan.Web.admin.index" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>团来了——您的团购生活导航专家！</title>
    <link type="text/css" rel="stylesheet" href="../css/gobal.css" />
    <link href="../css/admin.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
    <script src="../js/jquery.plugin.js" type="text/javascript"></script>
    <script src="../js/datagrid.js" type="text/javascript"></script>
    <script src="../js/base.js" type="text/javascript"></script>
</head>
<body>
<!--#include file="header.aspx"-->
<form id="form1" runat="server">
<div id="content" class="bodywidth">
    <div id="fragment-1" class="fragment" style="width:49%;float:left;padding-right:8px;">
        <h3 style="background:url(../images/admin/simple_info.gif) left center no-repeat;">
            程序和系统信息</h3>
        <table class="table_info">
		    <tr>
			    <th> 程序版本 </th>
			    <td><asp:Label ID="lbSoftVersion" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> IP地址 </th>
			    <td><asp:Label ID="lbIp" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr>
			    <th> 服务器操作系统 </th>
			    <td><asp:Label ID="lbOperat" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> IIS版本 </th>
			    <td align="left"><asp:Label ID="lbIISVer" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr>
			    <th> .NET Framework 版本 </th>
			    <td><asp:Label ID="lbAspnetVer" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> 脚本超时时间 </th>
			    <td><asp:Label ID="lbTimeOut" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr>
			    <th> 系统运行时间 </th>
			    <td><asp:Label ID="lbServerLastStartToNow" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> 程序物理目录 </th>
			    <td><asp:Label ID="lbPhPath" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr>
			    <th> 逻辑驱动器 </th>
			    <td><asp:Label ID="lbLogicDriver" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> CPU 信息 </th>
			    <td><asp:Label ID="lbCpuType" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr>
			    <th> 物理内存 </th>
			    <td><asp:Label ID="lbMemory" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> Asp.net占用内存 </th>
			    <td><asp:Label ID="lbMemoryNet" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr>
			    <th> Asp.net占用CPU </th>
			    <td><asp:Label ID="lbCpuNet" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> 数据库版本 </th>
			    <td><asp:Label ID="lbDbVersion" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr>
			    <th> 数据库大小 </th>
			    <td><asp:Label ID="lblDbSize" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> 当前SessionID </th>
			    <td><asp:Label ID="lbSession" runat="server"></asp:Label>
			    </td>
		    </tr>
	    </table>
    </div>
    <div id="fragment-2" class="fragment" style="width:49%;float:left;padding-left:8px;">
        <h3 style="background:url(../images/admin/simple_stat.gif) left center no-repeat;">网站统计信息</h3>
	    <table class="table_info">
		    <tr>
			    <th> 注册会员总数 </th>
			    <td><asp:Label ID="lbTotalUser" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> 团购网站总数 </th>
			    <td><asp:Label ID="lbTotalSite" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr>
			    <th> 团购商品总数 </th>
			    <td><asp:Label ID="lbTotalTuan" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr class="stat">
			    <th> 网站评论总数 </th>
			    <td><asp:Label ID="lbSiteComment" runat="server"></asp:Label>
			    </td>
		    </tr>
		    <tr>
			    <th> 团购评论总数 </th>
			    <td><asp:Label ID="lbTuanComment" runat="server"></asp:Label>
			    </td>
		    </tr>
	    </table>
    </div>
</div>
</form>
<!--#include file="footer.aspx"-->
</body>
</html>