<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="permission_list.aspx.cs" Inherits="DTCMS.Web.admin.permission_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>角色列表</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="../css/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="../../inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/public.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="../../inc/treetable/TableTree4J.js"></script>
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
                <a <%= SettingPermission?"href='javascript:settingData();'":"disabled='disabled'" %> class="button b4"><img src="../images/ico/i_verify.gif" alt="" />配置权限</a>
                <a <%= DeletePermission?"href='javascript:deleteData(-1,true);'":"disabled='disabled'" %> class="button b4"><img src="../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
            <div id="gridTreeDiv">
            </div>
        </div>
    </form>
    <script type="text/javascript">
        $(document).ready(function() {
            showLoading();
            loadData();
            hideMessage();
        });
        function loadData() {
            var callback = function(res) {
                if (res.error) {
                    alert("请求错误，请刷新页面重试！\n" + res.error.Message);
                    return;
                }
                showGridTree(res.value);
            }
            DTCMS.Web.admin.permission_list.GetRolesJsonData(callback);
        }
        var gridTree;
        function showGridTree(json) {
            gridTree = new TableTree4J("gridTree", false, true);
            gridTree.config.useLine = false;
            gridTree.tableDesc = '<table id="tab" class="GridView">';

            var headerDataList = new Array("ID", "角色名称", "角色描述", "创建时间", "系统角色", "操作");
            var widthList = new Array("4%", "6%", "15%", "30%", "15%", "10%", "20%");

            gridTree.setHeader(headerDataList, -1, widthList, true, "GridHead", "", "", "");
            //设置列样式
            gridTree.gridHeaderColStyleArray = new Array("", "", "", "", "", "bleft");
            gridTree.gridDataCloStyleArray = new Array("", "", "", "", "", "");

            if (json != "") {
                var data = eval("data=" + json);
                $.each(data, function(i, n) {
                    var dataList = new Array(n.id, n.rolename,
                n.description, n.adddate, n.id == 1 ? "是" : "否", getOperateLink(n.id));
                    gridTree.addGirdNode(dataList, n.id, -1, null, n.id, "");
                });
            }
            gridTree.printTableTreeToElement("gridTreeDiv");
        }
        //操作权限
        var EditPermission = <%= EditPermission.ToString().ToLower() %>;
        var DeletePermission = <%= DeletePermission.ToString().ToLower() %>;
        var SettingPermission = <%= SettingPermission.ToString().ToLower() %>;
        function getOperateLink(id) {
            var operateLink = '';
            if (SettingPermission) {
                operateLink += '<a href="permission_setting.aspx?Id=' + id + '">配置</a>&nbsp;&nbsp;';
            } else {
                operateLink += '<a disabled="disabled">配置</a>&nbsp;&nbsp;';
            }
            if (EditPermission) {
                operateLink += '<a href="javascript:editData(' + id + ')">编辑</a>&nbsp;&nbsp;';
            } else {
                operateLink += '<a disabled="disabled">编辑</a>&nbsp;&nbsp;';
            }
            if (DeletePermission && id != 1) {
                operateLink += '<a href="javascript:deleteData(\'' + id + '\',false)">删除</a>';
            } else {
                operateLink += '<a disabled="disabled">删除</a>';
            }
            return operateLink;
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
        function settingData(){
            rid = getSingleCheckID
            ();
            if (rid == "") {
                Dialog.alert("请选择要配置的权限数据!");
            }else{
                window.location="permission_setting.aspx?Id=" + rid;
            }
        }
        //id:角色编号
        //flag:是否批量删除，表示true:批量删除，false:单个删除
        function deleteData(rid, flag) {//删除角色
            if (flag) {
                rid = getCheckId();
                if (rid == "") {
                    Dialog.alert("请选择要删除的数据!");
                    return;
                }
            }
            Dialog.confirm("删除角色将会影响到与之关联的用户不能正常使用后台功能，确定要删除吗？", function() {
                var callback=function(res){
                    if (res.error) {
                        alert("删除用户失败，请刷新本页面后重试！\n" + res.error.Message);
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
                DTCMS.Web.admin.permission_list.DeleteRoles(rid,callback);
            });
        }
</script>
</body>
</html>

