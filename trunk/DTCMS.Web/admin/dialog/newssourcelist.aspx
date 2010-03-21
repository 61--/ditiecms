<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newssourcelist.aspx.cs" Inherits="DTCMS.Web.admin.dialog.newssourcelist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>文章来源</title>
    <script type="text/javascript" src="../js/jquery.min.js"></script>
    <link href="../css/dialog.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript">
        $(document).ready(function() {
            LoadData();
        });
        function LoadData() {
            $.ajax({
                url: "/admin/ajax/dialog_list.aspx",
                type: "GET",
                data: "action=sourcepage&ran=" + Math.random(),
                success: function(responseText) {
                    $("#continer").html(responseText);
                }
            });
        }
    </script>
</head>
<body>
    <div id="continer">
        
    </div>
    <script type="text/javascript">
        function getnews() {    //获取文章来源
            var returnVal = "";
            var items = $("#continer :checkbox");
            $.each(items, function(i, n) {
                if (n.checked) {
                    if (returnVal != "") {
                        returnVal += ",";
                    }
                    returnVal += n.value;
                }
            })
            return returnVal;
        }
    </script>
</body>
</html>
