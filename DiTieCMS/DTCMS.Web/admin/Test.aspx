<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="DTCMS.Web.admin.Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>Test</title>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/blue_body.css" rel="stylesheet" type="text/css" />

    <script src="js/jquery.min.js" type="text/javascript"></script>

    <script src="/admin/js/Public.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/contextmenu.js"></script>
    <script type="text/javascript">
        $('#test');
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 800px; margin: 50px auto;">
        <h3 style="height: 30px;">
            jQuery通用dialog/popup窗口插件</h3>
        <ul>
            <li><a id="H01" href="#" onmouseover="showHelper('#H01', '帮助主题', '多个TAG标签用半角逗号隔开',30)"
                onmouseout="$('#_Popup_help').remove()" title="查看帮助">帮助窗口（根据位置自动判断在底下弹出）</a></li>
            <li><a id="H02" href="#" onmouseover="showHelper('#H02', '帮助主题', '多个TAG标签用半角逗号隔开',30)"
                onmouseout="$('#_Popup_help').remove()" title="查看帮助">帮助窗口（根据位置自动判断在头部弹出）</a></li>
        </ul>
        <ul>
            <li><a id="H11" href="javascript:showLoading()" title="查看帮助">显示Loading信息（默认）</a>&nbsp;&nbsp;&nbsp;&nbsp;<a
                href="javascript:hideMessage()">隐藏Loading信息</a></li>
            <li><a id="H12" href="javascript:showLoading('正在提交数据...')">显示自定义Loading信息（默认）</a>&nbsp;&nbsp;&nbsp;&nbsp;<a
                href="javascript:hideMessage()">隐藏Loading信息</a></li>
            <li><a id="H13" href="javascript:showLoading('正在加载列表数据...','#H13')">在指定容器内显示Loading信息（默认）</a>&nbsp;&nbsp;&nbsp;&nbsp;<a
                href="javascript:hideMessage()">隐藏Loading信息</a></li>
            <li><a id="H14" href="javascript:showSuccess('发表成功，经验 + 5')">显示提示信息</a>&nbsp;&nbsp;&nbsp;&nbsp;<a
                href="javascript:hideMessage()">隐藏Tip信息</a></li>
            <li><a id="H15" href="javascript:showSuccess('回复成功，经验 + 1')">显示提示信息（自动隐藏）</a></li>
            <li><a id="A1" href="javascript:showError('删除失败，经验 - 1')">显示提示信息（自动隐藏）</a></显示提示信息（自动隐藏）</a></li>
        </ul>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" />
    </div>
    <select id="DropDownList1" runat="server">
    </select>
    
    <script type="text/javascript">
        $().ready(function() {
            var st = new Date().getTime();
            var menu = { items: [
                { text: "预览", icon: "view", alias: "contextmenu-edit", action: contextMenuItem_click },
                { text: "编辑", icon: "edit", alias: "contextmenu-view", action: contextMenuItem_click },
                { text: "删除", disable: true, icon: "delete", alias: "contextmenu-delete", action: contextMenuItem_click },
                { type: "split" },
                { text: "发布", alias: "contextmenu-create", action: contextMenuItem_click },
                { text: "置顶", icon: "edit", alias: "contextmenu-create", width: 120, type: "group",
                    items: [
	                            { text: "组三集合", icon: "view", alias: "2-2", type: "group", width: 120, items: [
		                            { text: "组3一项", alias: "3-1" },
		                            { text: "组3二项", alias: "3-2" }
	                            ]
	                            },
	                            { text: "组1一项", icon: "view", alias: "2-1" },
	                            { text: "组1二项", alias: "2-3" },
	                            { text: "组1三项", alias: "2-4", action: contextMenuItem_click }
                            ]
                },
                { type: "split" },
                { text: "刷新", icon: "refresh", alias: "contextmenu-reflash", action: contextMenuItem_click }
                ]
            };
            $('body').contextmenu(menu);
            var st2 = new Date().getTime() - st;
            alert(st2);
        });
        function contextMenuItem_click() {
            alert('123');
        }
    </script>
    </form>
</body>
</html>
