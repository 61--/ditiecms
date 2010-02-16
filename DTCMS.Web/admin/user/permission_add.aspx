<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="permission_add.aspx.cs" Inherits="DTCMS.Web.admin.permission_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加、编辑权限</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="../js/public.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>
    <style type="text/css">
        body{_overflow-y: auto;}
    </style>
    <script type="text/javascript">
        function getAddData(){
            var id=$("#txt_RoleID").val();
            var roleName=$("#txt_RoleName").val();
            var description=$("#txt_Description").val();
            var orderID=$("#txt_OrderID").val();
            var action="<%=action %>";
            $.ajax({
                url: "../ajax/permission_ajax.aspx?action="+action,
                type: "POST",
                data: "Id=" + id + "&RoleName=" + roleName + "&Description=" + description + "&OrderID=" + orderID + "&ran=" + Math.random(),
                success: function(responseText) {//提示
                    if (responseText>0) {
                        if(action=="add"){
                            return 1;
                        }else{
                            return 2;
                        }
                    }else{
                        if(action=="add"){
                            return -1;
                        }else{
                            return -2;
                        }
                    }
                }
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <table cellpadding="10" cellspacing="0" class="table_form" style="border:0">
            <tr>
                <td style="width:80px;text-align:right;">
                    角色ID:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_RoleID" class="textbox short" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    角色名称:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_RoleName" class="textbox short" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    角色描述:
                </td>
                <td class="main_bright">
                    <textarea id="txt_Description" class="textbox" cols="10" rows="4" style="width:260px;height:75px;" runat="server"></textarea>
                </td>
            </tr>
            <tr>
                <td style="width:80px;text-align:right;">
                    排序:
                </td>
                <td class="main_bright">
                    <input type="text" id="txt_OrderID" class="textbox short" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
