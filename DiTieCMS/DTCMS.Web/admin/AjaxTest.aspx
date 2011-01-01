<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxTest.aspx.cs" Inherits="DTCMS.Web.admin.AjaxTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AjaxPro测试</title>
    <link href="css/blue_body.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/public.js"></script>
    <script type="text/javascript" src="js/common.js"></script>
    <style type="text/css">
        body{_overflow-y: auto;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <asp:Button ID="btn_delete" runat="server" Text="删除" CssClass="button b2" onclick="btn_delete_Click" />
        <input id="btn_add" type="button" value="当前为编辑" onclick="add(this)" class="button b5" />
        <table cellpadding="10" cellspacing="0" class="table_form" style="border:0">
            <tr>
                <td style="width:80px;text-align:right;">
                    模块父ID:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_PID" class="textbox" value="M" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    模块ID:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_ID" class="textbox" value="M" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    模块名称:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_Name" class="textbox" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    模块英文名:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_EName" class="textbox" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    模块深度:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_Deep" class="textbox" value="3" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    模块地址:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_URL" class="textbox" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    模块描述:
                </td>
                <td class="main_bright">
                    <textarea id="txt_Description" class="textbox" cols="10" rows="4" style="width:260px;height:50px;" runat="server"></textarea>
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    排序:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_OrderID" class="textbox" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
    <script type="text/javascript">
        var action = "<%=action %>";
        function getAddData() {
            var myid=<%=myid %>
            var id = $("#txt_ID").val();
            var pid = $("#txt_PID").val();
            var Name = $("#txt_Name").val();
            var EName = $("#txt_EName").val();
            var Deep = $("#txt_Deep").val();
            var URL = $("#txt_URL").val();
            var description = $("#txt_Description").val();
            var orderID = $("#txt_OrderID").val();
            if (action == "add") {
                var res = DTCMS.Web.admin.AjaxTest.Add(id,pid,Name,EName,Deep,URL,description,orderID).value;
                if (res > 0) {
                    return 1;
                } else {
                    return -1;
                }
            } else {
            var res = DTCMS.Web.admin.AjaxTest.Edit(myid,id, pid, Name, EName, Deep, URL, description, orderID).value;
                if (res > 0) {
                    return 2;
                } else {
                    return -2;
                }
            }
        }
        function add(obj){
            if (action == "add"){
                action="edit";
                obj.value="当前为编辑";
            }
            else{
                action="add";
                obj.value="当前为添加";
            }
        }
    </script>
</body>
</html>
