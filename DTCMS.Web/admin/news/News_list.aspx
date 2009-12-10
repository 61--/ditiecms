﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News_list.aspx.cs" Inherits="DTCMS.Web.admin.news.News_list" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>文章列表</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="../Inc/Dialog/Dialog.js"></script>
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
			<table class="table_data">
				<thead>
					<tr>
						<th>ID </th>
						<th>
						<input onclick="selectAll(this,'tab')" type="checkbox" value="" name="test" title="全选/取消" />
						</th>
						<th>标题 </th>
						<th>栏目 </th>
						<th>浏览 </th>
						<th>是否生成 </th>
						<th>状态 </th>
						<th>创建者 </th>
						<th class="bleft">时间 </th>
					</tr>
				</thead>
				<tbody id="tab">
					<tr>
						<td>1 </td>
						<td><input type="checkbox" value="a" name="test" /> </td>
						<td class="tleft">DataGridView新特色、常用操作</td>
						<td>C#</td>
						<td>186</td>
						<td>已生成</td>
						<td>开放浏览</td>
						<td>admin</td>
						<td>2009-01-09</td>
					</tr>
				</tbody>
				<tfoot>
					<tr>
						<td colspan="9">
						<div class="grayr">
							<span class="disabled">&lt; </span>
							<span class="current">1</span>
							<a href="#?page=2" _fcksavedurl="#?page=2">2</a>
							<a href="#?page=3" _fcksavedurl="#?page=3">3</a>
							<a href="#?page=4" _fcksavedurl="#?page=4">4</a>
							<a href="#?page=5" _fcksavedurl="#?page=5">5</a>
							<a href="#?page=6" _fcksavedurl="#?page=6">6</a>
							<a href="#?page=7" _fcksavedurl="#?page=7">7</a>
							...<a href="#?page=199" _fcksavedurl="#?page=199">199</a>
							<a href="#?page=200" _fcksavedurl="#?page=200">200</a>
							<a href="#?page=2" _fcksavedurl="#?page=2"> &gt; </a></div>
						<!--<div id="page">
                        <a href="">首　页</a><a href="">上一页</a><a href="">下一页</a><a href="">末　页</a></div>-->
						</td>
					</tr>
				</tfoot>
			</table>
			<script type="text/javascript">
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
            </script>
		</div>
	</div>
    </form>
</body>
</html>