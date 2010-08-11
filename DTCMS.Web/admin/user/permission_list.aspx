<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="permission_list.aspx.cs" Inherits="DTCMS.Web.admin.permission_list" %>
<%@ Register TagPrefix="DT" Assembly="DTCMS.Controls" Namespace="DTCMS.Controls" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>角色列表</title>
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
                    <li class="tab_on"><a>角色管理</a></li>
                </ul>
            </div>
            <div class="toolbar">
                <a <%= AddPermission?"href='javascript:addData();'":"disabled='disabled'" %> class="button b4"><img src="../images/ico/i_add.gif" alt="" />添加角色</a>
                <a <%= EditPermission?"href='javascript:editData();'":"disabled='disabled'" %> class="button b4"><img src="../images/ico/i_edit.gif" alt="" />编辑角色</a>
                <a <%= SettingPermission?"href='javascript:settingData();'":"disabled='disabled'" %> class="button b4"><img src="../images/ico/i_setting.gif" alt="" />配置权限</a>
                <a <%= DeletePermission?"href='javascript:deleteData();'":"disabled='disabled'" %> class="button b4"><img src="../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
            <table style="width:100%;">
                <tr style="vertical-align:top;">
                    <td style="width:48%;">
                        <DT:DataGrid ID="dt_DataGrid" PrimaryKey="ID" BindAjaxMethod="DTCMS.Web.admin.permission_list.GetRolesJsonData" 
                            RowHandler="contextMenu(this)" IsPage="false" CssClass="table_data" runat="server">
                            <Colunms>
                                <DT:CheckBox Visible="true" Width="6%" />
                                <DT:RowNumber HeaderText="ID" Increase="false" SortField="ID" Visible="true" Width="14%" />
                                <DT:ColumnItem HeaderText="角色名称" Width="30%" DataField="RoleName" />
                                <DT:ColumnItem HeaderText="系统角色" Width="20%" DataField="ID" DataFormat="formatIsSystem" />
                                <DT:ColumnItem HeaderText="操作" Width="30%" DataField="ID" DataFormat="formatOperate" CssClass="bleft" />
                            </Colunms>
                        </DT:DataGrid>
                    </td>
                    <td style="width:52%;">
                        <div style="margin-left:5px;">
                            <iframe id="main_body" name="main_body" width="100%" onload="setFrameHeight();" frameborder="0" <%--style="border:1px #CAD9EA solid;"--%> src="permission_setting.aspx?Id=1"></iframe>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <script type="text/javascript">
        function setFrameHeight(){
            //alert($(document).height())
            iframeHeight = $(document).height()-100;
            $("#main_body").height(iframeHeight);
        }
        function setFrameUrl(Id){
            url="permission_setting.aspx?Id="+Id;
            $("#main_body").attr("src", url);
        }
        //操作权限
        var EditPermission = <%= EditPermission.ToString().ToLower() %>;
        var DeletePermission = <%= DeletePermission.ToString().ToLower() %>;
        var SettingPermission = <%= SettingPermission.ToString().ToLower() %>;
        function formatIsSystem(r){
            return r.id == 1 ? '是' : '否';
        }
        function formatOperate(r){
            var operateLink = '';
            if (SettingPermission) {
                operateLink += '<a href="javascript:setFrameUrl(' + r.id + ');" target="main_body">配置</a>&nbsp;&nbsp;';
            } else {
                operateLink += '<a disabled="disabled">配置</a>&nbsp;&nbsp;';
            }
            if (EditPermission) {
                operateLink += '<a href="javascript:editData(' + r.id + ')">编辑</a>&nbsp;&nbsp;';
            } else {
                operateLink += '<a disabled="disabled">编辑</a>&nbsp;&nbsp;';
            }
            if (DeletePermission && r.id != 1) {
                operateLink += '<a href="javascript:deleteData(\'' + r.id + '\',false)">删除</a>';
            } else {
                operateLink += '<a disabled="disabled">删除</a>';
            }
            return operateLink;
        }
        function contextMenu(row) {
            var menu = { items: [
                { text: "预览", icon: "view", alias: "view", action: menuItem_click },
                { text: "编辑", icon: "edit", alias: "edit", action: menuItem_click },
                { text: "删除", icon: "delete", alias: "delete", action: menuItem_click },
                { type: "split" },
                { text: "配置", icon: "setting", alias:"setting", action: menuItem_click },
                { type: "split" },
                { text: "刷新", icon: "refresh", alias: "refresh", action: menuItem_click }
                ]};
            $(row).contextmenu(menu);
        }
        function menuItem_click(target) {
            var aid = target.id;
            var cmd = this.data.alias;
            switch (cmd) {
                case "view": window.location.href = "article.aspx?ID=" + aid; break;
                case "edit": editData(aid); break;
                case "delete": deleteData(aid); break;
                case "setting":settingData(aid);break;
                case "refresh": loadData(true); break;
            }
        }
        //添加角色
        function addData(){
            Dialog.open("添加角色", addPermission_onOk, "permission_add.aspx?action=add");
        }
        function addPermission_onOk(win) {
            var ret = win.getAddData();
            if (ret == 1) {
                showSuccess("添加角色成功！");
                loadData();
            } else if (ret == 2) {
                showSuccess("编辑角色成功！");
                loadData();
            } else if (ret == -1) {
                showError("添加角色失败！");
            } else if (ret == -2) {
                showError("编辑角色失败！");
            }
        }
        //id:角色编号
        function editData(id) {
            var rid = id || getSingleCheckID();
            if (rid != "") {
                Dialog.open("编辑角色", addPermission_onOk, "permission_add.aspx?action=edit&Id="+rid);
            } else {
                Dialog.alert("请选择要修改的角色!");
            }
        }
        //配置权限
        function settingData(rid){
            rid = rid || getSingleCheckID();
            if (rid == "") {
                Dialog.alert("请选择要配置的角色!");
            }else{
                window.location="permission_setting.aspx?ID=" + rid;
            }
        }
        //删除角色
        function deleteData(rid) {
            rid = rid || getCheckId();
            if (rid == "") {
                Dialog.alert("请选择要删除的数据!");
                return;
            }
            if (rid == "1" || rid.indexOf(",1") > -1 || rid.indexOf(",1,") > -1 || rid.indexOf("1,") > -1) {
                Dialog.alert("您不能删除系统内置角色!");
                return;
            }
            Dialog.confirm("删除角色将会影响到与之关联的用户不能正常使用后台功能，确定要删除吗？", function() {
                var callback = function(res) {
                    if (res.error) {
                        alert("删除角色失败，请刷新本页面后重试！\n" + res.error.Message);
                        return;
                    }
                    if (res.value > 0) {
                        showSuccess("成功删除" + res.value + "个角色！");
                        loadData();
                    }
                    else {
                        showError("删除角色失败！");
                    }
                }
                DTCMS.Web.admin.permission_list.DeleteRoles(rid, callback);
            });
        }
</script>
</body>
</html>

