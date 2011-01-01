<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="authorlist.aspx.cs" Inherits="DTCMS.Web.admin.news.authorlist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>作者</title>
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
                data: "action=authorpage&ran=" + Math.random(),
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
        function getAuthors() {    //获取TAG
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
