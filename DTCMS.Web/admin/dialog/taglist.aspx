<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="taglist.aspx.cs" Inherits="DTCMS.Web.admin.news.taglist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>TAG</title>
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <link href="../css/dialog.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript">
        $(document).ready(function() {
            LoadData();
        });
        function LoadData() {
            $.ajax({
                url: "/admin/ajax/dialog_list.aspx",
                type: "GET",
                data: "action=tagpage&ran=" + Math.random(),
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
        function getTags() {    //获取TAG
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
