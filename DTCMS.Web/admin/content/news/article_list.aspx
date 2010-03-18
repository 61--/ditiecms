<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="article_list.aspx.cs" Inherits="DTCMS.Web.admin.article_list" %>
<%@ Register TagPrefix="DT" Assembly="DTCMS.Controls" Namespace="DTCMS.Controls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>文章列表</title>
    <link href="../../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../../js/common.js"></script>
    <script type="text/javascript" src="../../js/public.js"></script>
    <script type="text/javascript" src="../../js/datagrid.js"></script>
    <script type="text/javascript" src="../../js/contextmenu.js"></script>
</head>
<body>
    <form id="form1" runat="server"><div id="container">
		<div id="tab_menu" class="tabs">
			<ul>
				<li class="tab_on"><a href="javascript:;" >文章管理</a></li>
			</ul>
		</div>
		<div id="content">
		    <div class="toolbar">
                <a href="article_add.aspx" class="button b4"><img src="../../images/ico/i_add.gif" alt="" />添加文章</a>
                <a href="javascript:Dialog.alert('您没有权限编辑文章！');" class="button b4"><img src="../../images/ico/i_edit.gif" alt="" />编辑文章</a>
                <a href="javascript:verifyData(-1,true);" class="button b4"><img src="../../images/ico/i_verify.gif" alt="" />审核文章</a>
                <a href="javascript:DeleteData(-1,true);" class="button b4"><img src="../../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
            <DT:DataGrid ID="dt_DataGrid" BindAjaxMethod="DTCMS.Web.admin.article_list.GetArticleJsonData" IsPage="true" RowHandler="contextMenu(this)" CssClass="table_data" runat="server">
                <Colunms>
                    <DT:CheckBox Visible="true" Width="4%" />
                    <DT:RowsIndex HeaderText="文章ID" DataField="ID" Visible="true" Width="6%" />
                    <DT:ColumnItem HeaderText="文章标题" Width="35%" DataField="Title" DataFormat="formatTitle" SortField="Title" />
                    <DT:ColumnItem HeaderText="所属栏目" Width="15%" DataField="ClassName" />
                    <DT:ColumnItem HeaderText="创建时间" Width="20%" DataField="AddDate" SortField="A.AddDate" />
                    <DT:ColumnItem HeaderText="是否审核" Width="10%" DataField="IsVerify" DataFormat="formatIsVerify" />
                    <DT:ColumnItem HeaderText="操作" Width="10%" DataField="ID" DataFormat="formatOperate" CssClass="bleft" />
                </Colunms>
            </DT:DataGrid>
            <input id="Texthidden" type="text" style="visibility:hidden;" />
		</div>
	</div>
    </form>
    <script type="text/javascript">
        function formatTitle(r) {
            return "<a href='article_add.aspx?ID=" + r.id + "'>" + r.title + "</a>";
        }
        function formatIsVerify(r) {
            return r.isverify == 1 ? "<a href='javascript:;' onclick='verifyData(" + r.id + ",false,this)'>已审核</a>" : "<a href='javascript:;' onclick='verifyData(" + r.id + ",false,this)' style='color:red'>未审核</a>";
        }
        function formatOperate(r) {
            return "<a href='article_add.aspx?Id=" + r.id + "'>编辑</a>&nbsp;&nbsp;<a href='javascript:DeleteData(" + r.id + ",false)'>删除</a>";
        }
        function contextMenu(row) {
            var menu = { items: [
                { text: "预览", icon: "view", alias: "edit", action: contextMenuItem_click },
                { text: "编辑", icon: "edit", alias: "view", action: contextMenuItem_click },
                { text: "删除", disable: true, icon: "delete", alias: "delete", action: contextMenuItem_click },
                { type: "split" },
                { text: "发布", alias: "create", action: contextMenuItem_click },
                { text: "置顶", icon: "edit", alias: "create", width: 120, type: "group",
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
                { text: "刷新", icon: "refresh", alias: "reflash", action: contextMenuItem_click }
                ]
            };
            $(row).contextmenu(menu);
        }
        function contextMenuItem_click() {
            /*var id = $(target).attr("id").substr(3);
            var cmd = this.data.alias;
            var ch = $.browser.msie ? target.ch : target.getAttribute("ch");
            var cell = ch.split("_FG$SP_");
            if (cmd == "contextmenu-edit") {
            alert("编辑，产品编号=" + id);
            }
            else if (cmd == "contextmenu-view") {
            alert("编辑，产品编号=" + id);
            }
            else if (cmd == "contextmenu-delete") {
            var name = cell[1];
            if (confirm("你确认要删除商品 [" + name + "] 吗？")) {
            alert("删除，产品编号=" + id);
            }
            }
            else {
            $("#productlist").flexReload();
            }*/
            loadData();
        }
        //编辑文章
        function editData() {
            var aid=getSingleCheckID();
            if (aid != "") {
                window.location.href = "article_add.aspx?Id=" + aid;
            } else {
                Dialog.alert("请选择要编辑的文章!");
            }
        }
        //aid:文章编号
        //flag:是否批量删除，true批量删除，false单个删除
        function DeleteData(aid, flag) {
            if (flag) {
                aid = getCheckId();
                if (aid == "") {
                    Dialog.alert("请选择要删除的文章!");
                    return;
                }
            }
            Dialog.confirm("确定要删除文章吗？", function() {
                var res = DTCMS.Web.admin.article_list.DeleteArticle(aid).value;
                if (res > 0) {
                    loadData();
                    showSuccess("成功删除" + res + "篇文章！");
                    return;
                }
                else {
                    showError("删除文章失败！");
                    return;
                }
            });
        }
        //审核文章
        function verifyData(aid, flag, elem) {
            if (flag) {
                aid = getCheckId();
                if (aid == "") {
                    Dialog.alert("请选择要审核的文章!");
                    return;
                }
            }
            var res = DTCMS.Web.admin.user_list.VerifyArticle(aid).value;
            if (res > 0) {
                if (flag) {
                    loadData();
                    showSuccess("批量审核文章成功！");
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
                showError("审核文章失败！");
            }
        }
    </script>
</body>
</html>
