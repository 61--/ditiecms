﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="DTCMS.Web.admin.dtree.Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
        <LINK href="DTTree/dtree.css" type=text/css rel=stylesheet>
        <script src="DTTree/dtree.js" type=text/javascript></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TreeView ID="tvTest" runat="server">
        </asp:TreeView>
        <%= A ()%>
    </div>
    </form>
</body>
</html>
