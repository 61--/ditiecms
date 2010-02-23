<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DTGridView.ascx.cs" Inherits="DTCMS.Web.controls.DTGridView" %>
<table class="table_data">
    <tr class="thead">
        <td width="4%"><input type="checkbox" onclick="CheckSelAll(this)" name="title" /></td>
        <td width="4%">ID</td>
        <td width="32%">文章标题</td>
        <td width="20%">所属栏目</td>
        <td width="20%">创建时间</td>
        <td width="10%">是否审核</td>
        <td class="bleft" width="10%">操作</td>
    </tr>
</table>