<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News_list.aspx.cs" Inherits="DTCMS.Web.admin.news.News_list" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>文章列表</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/jquery.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="../Inc/Dialog/Dialog.js"></script>
    <script type="text/javascript">
        $(function() {
            LoadData();
        });

        function LoadData() {
            $.ajax({
                url: "/admin/ajax/news_list.aspx",
                type: "GET",
                data: "action=load&ran=" + Math.random(),
                success: function(responseText) {
                    $("#table").html(responseText);
                    alert(responseText);
                }
            }); 
        }
    </script>
</head>
<body>
    <form id="form1" runat="server"><div id="container">
		<div id="tab_menu" class="tabs">
			<ul>
				<li class="tab_on"><a href="javascript:;">后台首页</a></li>
			</ul>
		</div>
		<div id="content">
		    <div class="toolbar">
                <a href="News_Add.aspx" class="button b4"><img src="../images/ico/i_add.gif" alt="" />添加文章</a>
                <a href="javascript:Dialog.alert('您没有权限编辑文章！');" class="button b4"><img src="../images/ico/i_edit.gif" alt="" />编辑文章</a>
                <a href="javascript:DeleteData(-1,true);" class="button b4"><img src="../images/ico/i_allDelete.gif" alt="" />批量删除</a>
            </div>
			<div id="table"></div>
			
			<%--<script type="text/javascript">
			    var Ptr = document.getElementById("tab").getElementsByTagName("tr");
			    function $() {
			        for (i = 1; i < Ptr.length + 1; i++) {
			            Ptr[i - 1].className = (i % 2 > 0) ? "t1" : "t2";
			        }
			    }
			    window.onload = $;
			    for (var i = 0; i < Ptr.length; i++) {
			        Ptr[i].onmouseover = function() {
			            this.tmpClass = this.className;
			            this.className = "t3";

			        };
			        Ptr[i].onmouseout = function() {
			            this.className = this.tmpClass;
			        };
			    }
            </script>--%>
		</div>
	</div>
    </form>
</body>
</html>
