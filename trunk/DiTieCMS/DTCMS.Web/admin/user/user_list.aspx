<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_list.aspx.cs" Inherits="DTCMS.Web.admin.user_list" %>
<%@ Register TagPrefix="DT" Assembly="DTCMS.Controls" Namespace="DTCMS.Controls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>用户列表</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <script type="text/javascript" src="../js/jquery.min.js"></script>
    <script type="text/javascript" src="../../inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="../js/public.js"></script>
    <script type="text/javascript" src="../js/datagrid.js"></script>
    <script type="text/javascript" src="../js/contextmenu.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">  
            <div id="tab_menu" class="tabs">
                <ul>
                    <li class="tab_on"><a>用户管理</a></li>
                </ul>
            </div>
            <div class="toolbar">
                <a href="user_add.aspx" class="button b4"><img src="../images/ico/i_add.gif" alt="" />添加用户</a>
                <a href="javascript:editData();" class="button b4"><img src="../images/ico/i_edit.gif" alt="" />编辑用户</a>
                <a href="javascript:verifyData(-1,true);" class="button b4"><img src="../images/ico/i_verify.gif" alt="" />审核用户</a>
                <a href="javascript:deleteData();" class="button b4"><img src="../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
            <DT:DataGrid ID="dt_DataGrid" PrimaryKey="UID" BindAjaxMethod="DTCMS.Web.admin.user_list.GetUserJsonData" 
                RowHandler="contextMenu(this)" IsPage="true" CssClass="table_data" runat="server">
                <Colunms>
                    <DT:CheckBox Visible="true" Width="4%" />
                    <DT:RowNumber HeaderText="UID" Increase="false" Visible="true" SortField="UID" Width="6%" />
                    <DT:ColumnItem HeaderText="用户名" DataField="UserName" SortField="UserName" Width="12%" />
                    <DT:ColumnItem HeaderText="邮箱" DataField="Email" Width="18%" />
                    
                    <DT:ColumnItem HeaderText="用户角色" DataField="RoleName" Width="12%" />
                    <DT:ColumnItem HeaderText="注册IP" DataField="RegisterIP" Width="12%" />
                    <DT:ColumnItem HeaderText="注册时间" DataField="RegisterTime" SortField="RegisterTime" Width="18%" />
                    <DT:ColumnItem HeaderText="是否审核" DataField="IsVerify" DataFormat="formatIsVerify" Width="8%" />
                    <DT:ColumnItem HeaderText="操作" DataField="ID" DataFormat="formatOperate" Width="10%" CssClass="bleft" />
                </Colunms>
            </DT:DataGrid>
            <input id="Texthidden" type="text" style="visibility:hidden;" />
        </div>
    </form>
    <script type="text/javascript">
        function formatIsVerify(r) {
            return r.isverify == 1 ? "<a href='javascript:;' onclick='verifyData(\"" + r.uid + "\",false,this)' style='color:green'>已审核</a>" : "<a href='javascript:;' onclick='verifyData(\"" + r.uid + "\",false,this)' style='color:red'>未审核</a>";
        }
        function formatOperate(r) {
            return "<a href='article_add.aspx?Id=" + r.uid + "'>编辑</a>&nbsp;&nbsp;<a href='javascript:deleteData(\"" + r.uid + "\",false)'>删除</a>";
        }
        function contextMenu(row) {
            var menu = { items: [
                { text: "查看", icon: "view", alias: "view", action: menuItem_click },
                { text: "添加", icon: "add", alias: "add", action: menuItem_click },
                { text: "编辑", icon: "edit", alias: "edit", action: menuItem_click },
                { text: "删除", icon: "delete", alias: "delete", action: menuItem_click },
                { type: "split" },
                { text: "刷新", icon: "refresh", alias: "refresh", action: menuItem_click }
                ]};
            $(row).contextmenu(menu);
        }
        function menuItem_click(target) {
            var aid = target.id;
            var cmd = this.data.alias;
            switch (cmd) {
                case "add": window.location.href = "user_add.aspx"; break;
                case "view": window.location.href = "user_add.aspx?Id=" + aid; break;
                case "edit": editData(aid); break;
                case "delete": deleteData(aid); break;
                case "refresh": loadData(true); break;
            }
        }
        //编辑用户
        function editData(uid) {
            uid = uid || getSingleCheckID();
            if (uid != "") {
                window.location.href = "user_add.aspx?Id=" + uid;
            } else {
                Dialog.alert("请选择要修改的用户!");
            }
        }
        //删除用户
        function deleteData(uid) {
            uid = uid || getCheckId();
            if (uid == "") {
                Dialog.alert("请选择要删除的用户!");
                return;
            }
            Dialog.confirm("删除用户后将不能恢复，确定要删除用户吗？", function() {
                var callback = function(res) {
                    if (res.error) {
                        alert("删除用户失败，请刷新本页面后重试！\n" + res.error.Message);
                        return;
                    }
                    if (res.value > 0) {
                        showSuccess("成功删除" + res.value + "个用户！");
                        loadData();
                        return;
                    }
                    else {
                        showError("删除用户失败！");
                        return;
                    }
                }
                DTCMS.Web.admin.user_list.DeleteUsers(uid, callback);
            });
        }
        //审核用户
        function verifyData(uid, flag, elem) {
            if (flag) {
                uid = getCheckId();
                if (uid == "") {
                    Dialog.alert("请选择要审核的用户!");
                    return;
                }
            }
            var callback = function(res) {
                if (res.error) {
                    alert("审核用户失败，请刷新本页面后重试！\n" + res.error.Message);
                    return;
                }
                if (res.value > 0) {
                    if (flag) {
                        showSuccess("批量审核用户成功！");
                        loadData();
                    } else {
                        elem.blur();
                        if (elem.innerHTML == "未审核") {
                            elem.innerHTML = "已审核";
                            elem.style.color = "green";
                        } else {
                            elem.innerHTML = "未审核";
                            elem.style.color = "red";
                        }
                    }
                } else {
                    showError("审核用户失败！");
                }
            }
            DTCMS.Web.admin.user_list.VerifyUsers(uid, callback);
        }
    </script>
</body>
</html>
