<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="DTCMS.Web.Test" %>
<%@ Register Assembly="DTCMS.Controls" Namespace="DTCMS.Controls" TagPrefix="DT" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function f() {
            var value = document.getElementById("tid").value;
            if ((event.keyCode < 48 || event.keyCode > 57) && event.keyCode != 46 || /\.\d\d$/.test(value)) event.returnValue = false
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <DT:DTTextBox ID="dtTxtTest" runat="server"></DT:DTTextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />文本框只能输入数字代码(小数点也不能输入)<input onkeyup="this.value=this.value.replace(/\D/g,'')" onafterpaste="this.value=this.value.replace(/\D/g,'')">
    <br />只能输入数字,能输小数点.
    <input onkeyup="if(isNaN(value))execCommand('undo')" onafterpaste="if(isNaN(value))execCommand('undo')">
    <input name=txt1 onchange="if(/\D/.test(this.value)){alert('只能输入数字');this.value='';}">
    
    <br />小数点后只能有最多两位(数字,中文都可输入),不能输入字母和运算符号:
<input type="text" id="tid" onKeyPress="javascript:f();">
    
    
    </div>
    </form>
</body>
</html>
