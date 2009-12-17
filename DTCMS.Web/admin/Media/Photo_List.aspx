<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Photo_List.aspx.cs" Inherits="DTCMS.Web.admin.Media.Photo_List" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script type="text/javascript" src="/Inc/Dialog/Dialog.js"></script>
    <script type="text/javascript">

        var diag = new Dialog();
        diag.Title = "设置确定按钮及取消按钮的属性";
        diag.ShowButtonRow = true;
        diag.URL = "test.html";
        diag.show();
        diag.okButton.value = " OK ";
        diag.cancelButton.value = "Cancel";


    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
