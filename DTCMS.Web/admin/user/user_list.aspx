<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_list.aspx.cs" Inherits="DTCMS.Web.admin.user_list" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>用户列表</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/public.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="/inc/treetable/TableTree4J.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">  
            <div id="tab_menu" class="tabs">
                <ul>
                    <li class="tab_on"><a href="javascript:;">用户管理</a></li>
                </ul>
            </div>
            <div class="toolbar">
                <a href="user_add.aspx" class="button b4"><img src="../images/ico/i_add.gif" alt="" />添加用户</a>
                <a href="javascript:editData();" class="button b4"><img src="../images/ico/i_edit.gif" alt="" />编辑用户</a>
                <a href="javascript:verifyData(-1,true);" class="button b4"><img src="../images/ico/i_verify.gif" alt="" />审核用户</a>
                <a href="javascript:deleteData(-1,true);" class="button b4"><img src="../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
            <div id="gridTreeDiv">
            </div>
        </div>
    </form>
    <script type="text/javascript">
        $(document).ready(function() {
            showLoading();
            loadData(1);
            hideMessage();
        });
        //加载用户列表
        function loadData(page) {
            DTCMS.Web.admin.user_list.GetUserJsonData(page, loadData_callback);
        }
        function loadData_callback(res) {
            showGridTree(res.value);
        }
        var gridTree;
        function showGridTree(json) {
            gridTree = new TableTree4J("gridTree", false, true);
            gridTree.config.useLine = false;
            gridTree.tableDesc = "<table id=\"tab\" class=\"GridView\">";

            var headerDataList = new Array("UID", "用户名", "邮箱", "用户角色", "注册IP", "注册时间", "是否审核", "操作");
            var widthList = new Array("4%", "6%", "12%", "18%", "12%", "12%", "18%", "8%", "10%");

            gridTree.setHeader(headerDataList, -1, widthList, true, "GridHead", "", "", "");
            //设置列样式
            gridTree.gridHeaderColStyleArray = new Array("", "", "", "", "", "", "", "bleft");
            gridTree.gridDataCloStyleArray = new Array("", "", "", "", "", "", "", "");

            if (json != "") {
                var data = eval("data=" + json);
                $.each(data, function(i, n) {
                    var dataList = new Array(n.uid, "<a href='user_add.aspx?Id=" + n.uid + "'>" + n.username + "</a>",
                n.email, n.rolename, n.registerip, n.registertime,
                n.isverify == 1 ? "<a href=\"javascript:;\" onclick=\"verifyData(" + n.uid + ",false,this)\">已审核</a>" : "<a href=\"javascript:;\" onclick=\"verifyData(" + n.uid + ",false,this)\" style=\"color:red\">未审核</a>",
                "<a href=\"user_add.aspx?Id=" + n.uid + "\">编辑</a>&nbsp;&nbsp;<a href=\"javascript:deleteData(" + n.uid + ",false)\">删除</a>");
                    gridTree.addGirdNode(dataList, n.uid, -1, null, n.uid, "");
                });
            }
            gridTree.printTableTreeToElement("gridTreeDiv");
        }
        //*uid:  用户编号
        function editData() {
            var uid=getSingleCheckID();
            if (uid != "") {
                window.location.href = "user_add.aspx?Id=" + uid;
            } else {
                Dialog.alert("请选择要修改的用户!");
            }
        }
        //uid:  用户编号
        //flag:  是否批量删除，表示true:批量删除，false:单个删除
        function deleteData(uid, flag) {//删除用户
            if (flag) {
                uid = getCheckId();
                if (uid == "") {
                    Dialog.alert("请选择要删除的数据!");
                    return;
                }
            }
            Dialog.confirm("确定要删除用户吗？", function() {
                DTCMS.Web.admin.user_list.DeleteUsers(uid, deleteData_callback);
            });
        }
        function deleteData_callback(res) {
            if (res.value > 0) {
                loadData(1);
                showSuccess("成功删除" + res.value + "个用户！");
                return;
            }
            else {
                showError("删除用户失败！");
                return;
            }
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
            DTCMS.Web.admin.user_list.VerifyUsers(uid, verifyData_callback(elem));
        }
        function verifyData_callback(res,elem) {
            if (res.value > 0) {
                if (flag) {
                    loadData(1);
                    showSuccess("批量审核用户成功！");
                } else {
                    elem.blur();
                    if (elem.innerHTML == "未审核") {
                        elem.innerHTML = "已审核";
                        elem.style.color = "black";
                    } else {
                        elem.innerHTML = "未审核";
                        elem.style.color = "red";
                    }
                }
            } else {
                showError("审核用户失败！");
            }
        }     
</script>
</body>
</html>
