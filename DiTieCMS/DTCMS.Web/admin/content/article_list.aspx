<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="article_list.aspx.cs" Inherits="DTCMS.Web.admin.article_list" %>
<%@ Register TagPrefix="DT" Assembly="DTCMS.Controls" Namespace="DTCMS.Controls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>文章列表</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <script type="text/javascript" src="../js/jquery.min.js"></script>
    <script type="text/javascript" src="../../inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="../js/public.js"></script>
    <script type="text/javascript" src="../js/datagrid.js"></script>
    <script type="text/javascript" src="../js/contextmenu.js"></script>
</head>
<body>
    <form id="form1" runat="server"><div id="container">
		<div id="tab_menu" class="tabs">
			<ul>
				<li class="tab_on"><a>文章管理</a></li>
			</ul>
		</div>
		<div id="content">
		    <div class="toolbar">
                <a href="article_add.aspx" class="button b4"><img src="../images/ico/i_add.gif" alt="" />添加文章</a>
                <a href="javascript:editData();" class="button b4"><img src="../images/ico/i_edit.gif" alt="" />编辑文章</a>
                <a href="javascript:verifyData(-1,true);" class="button b4"><img src="../images/ico/i_verify.gif" alt="" />审核文章</a>
                <a href="javascript:deleteData(-1,true);" class="button b4"><img src="../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
            <DT:DataGrid ID="dt_DataGrid" PrimaryKey="ID" BindAjaxMethod="DTCMS.Web.admin.article_list.GetArticleJsonData" 
                RowHandler="contextMenu(this)" IsPage="true" CssClass="table_data" runat="server">
                <Colunms>
                    <DT:CheckBox Visible="true" Width="4%" />
                    <DT:RowNumber HeaderText="文章ID" Increase="false" Visible="true" Width="6%" />
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
            return r.isverify == 1 ? "<a href='javascript:;' onclick='verifyData(\"" + r.id + "\",false,this)' style='color:green'>已审核</a>" : "<a href='javascript:;' onclick='verifyData(\"" + r.id + "\",false,this)' style='color:red'>未审核</a>";
        }
        function formatOperate(r) {
            return "<a href='article_add.aspx?Id=" + r.id + "'>编辑</a>&nbsp;&nbsp;<a href='javascript:deleteData(\"" + r.id + "\",false)'>删除</a>";
        }
        function contextMenu(row) {
            var menu = { items: [
                { text: "预览", icon: "view", alias: "view", action: menuItem_click },
                { text: "编辑", icon: "edit", alias: "edit", action: menuItem_click },
                { text: "删除", icon: "delete", alias: "delete", action: menuItem_click },
                { type: "split" },
                { text: "发布", alias: "create", action: menuItem_click },
                { text: "置顶", alias: "create"},
                { type: "split" },
                { text: "刷新", icon: "refresh", alias: "refresh", action: menuItem_click }
                ]};
            $(row).contextmenu(menu);
        }
        function menuItem_click(target) {
            var aid = target.id;
            var cmd = this.data.alias;
            switch (cmd) {
                case "view": window.location.href = "article.aspx?Id=" + aid; break;
                case "edit": editData(aid); break;
                case "delete": deleteData(aid); break;
                case "refresh": loadData(true); break;
            }
        }
        //编辑文章
        function editData(aid) {
            aid = aid || getSingleCheckID();
            if (aid != "") {
                window.location.href = "article_add.aspx?Id=" + aid;
            } else {
                Dialog.alert("请选择要编辑的文章!");
            }
        }
        //aid:文章编号
        //flag:是否批量删除，true批量删除，false单个删除
        function deleteData(aid, flag) {
            if (flag) {
                aid = getCheckId();
                if (aid == "") {
                    Dialog.alert("请选择要删除的文章!");
                    return;
                }
            }
            Dialog.confirm("确定要删除文章吗？", function() {
                var callback = function(res) {
                    if (res.error) {
                        alert("删除文章失败，请刷新本页面后重试！\n" + res.error.Message);
                        return;
                    }
                    if (res.value > 0) {
                        showSuccess("成功删除" + res.value + "篇文章！");
                        loadData();
                        return;
                    }
                    else {
                        showError("删除文章失败！");
                        return;
                    }
                }
                DTCMS.Web.admin.article_list.DeleteArticle(aid, callback);
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
            var callback = function(res) {
                if (res.value > 0) {
                    if (flag) {
                        showSuccess("批量审核文章成功！");
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
                    showError("审核文章失败！");
                }
            }
            DTCMS.Web.admin.article_list.VerifyArticle(aid, callback);
        }
    </script>
</body>
</html>
