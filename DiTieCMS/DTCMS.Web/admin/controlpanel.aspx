<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="controlpanel.aspx.cs" Inherits="DTCMS.Web.admin.controlpanel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>管理后台首页</title>
    <link href="css/blue_body.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a href="javascript:;">后台首页</a></li>
            </ul>
        </div>
        <div id="content">
        <div id="fragment-1">
			<table class="table_form">
				<tr>
					<th> 服务器名 </th>
					<td><asp:Label ID="lbServerName" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> IP地址 </th>
					<td><asp:Label ID="lbIp" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 当前域名 </th>
					<td><asp:Label ID="lbDomain" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> WEB端口 </th>
					<td><asp:Label ID="lbPort" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> IIS版本 </th>
					<td align="left"><asp:Label ID="lbIISVer" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 当前目录 </th>
					<td><asp:Label ID="lbPhPath" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 服务器操作系统 </th>
					<td><asp:Label ID="lbOperat" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 系统所在文件夹 </th>
					<td><asp:Label ID="lbSystemPath" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 脚本超时时间 </th>
					<td><asp:Label ID="lbTimeOut" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 服务器的语言种类 </th>
					<td><asp:Label ID="lbLan" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> .NET Framework 版本 </th>
					<td><asp:Label ID="lbAspnetVer" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 服务器当前时间 </th>
					<td><asp:Label ID="lbCurrentTime" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 服务器IE版本 </th>
					<td><asp:Label ID="lbIEVer" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 上次启动到现在已运行 </th>
					<td><asp:Label ID="lbServerLastStartToNow" runat="server"></asp:Label>
					</td>
				</tr>
			</table>
		</div>
		<div id="fragment-2">
			<table class="table_form">
				<tr>
					<th> 逻辑驱动器 </th>
					<td><asp:Label ID="lbLogicDriver" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> CPU 总数 </th>
					<td><asp:Label ID="lbCpuNum" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> CPU 类型 </th>
					<td><asp:Label ID="lbCpuType" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 虚拟内存 </th>
					<td><asp:Label ID="lbMemory" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 当前程序占用内存 </th>
					<td><asp:Label ID="lbMemoryPro" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> Asp.net所占内存 </th>
					<td><asp:Label ID="lbMemoryNet" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> Asp.net所占CPU </th>
					<td><asp:Label ID="lbCpuNet" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 当前Session数量 </th>
					<td><asp:Label ID="lbSessionNum" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 当前SessionID </th>
					<td><asp:Label ID="lbSession" runat="server"></asp:Label>
					</td>
				</tr>
				<tr>
					<th> 当前系统用户名 </th>
					<td><asp:Label ID="lbUser" runat="server"></asp:Label>
					</td>
				</tr>
			</table>
		</div>
		
            <table width="100%" align="center" cellpadding="0" cellspacing="0" class="table_form">
                <tr>
                    <td class="main_bleft split">
                        您的级别：
                    </td>
                    <td class="main_bright split">
                        <strong>超级管理员</strong>
                    </td>
                </tr>
                <tr>
                    <td rowspan="5" class="main_bleft split">
                        服务器环境：
                    </td>
                    <td class="main_bright">
                        操作系统：
                    </td>
                </tr>
                <tr>
                    <td class="main_bright">
                        系统目录：
                    </td>
                </tr>
                <tr>
                    <td class="main_bright">
                        计算机名：
                    </td>
                </tr>
                <tr>
                    <td class="main_bright">
                        系统运行时间：
                    </td>
                </tr>
                <tr>
                    <td class="main_bright split">
                        系统域名：
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        软件版本：
                    </td>
                    <td class="main_bright split">
                        <strong>版本号：</strong>V2.0
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft">
                        开发团队：
                    </td>
                    <td class="main_bright">
                        纪维锋、林潘星、李裕钬
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
