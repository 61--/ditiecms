<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="authorlist.aspx.cs" Inherits="DTCMS.Web.admin.news.authorlist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>作者</title>
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <style type="text/css">
        *{ margin:0; padding:0; font-family:Arial; font-size:12px;}
        ul{ list-style:none outside none; float:left;}
        li{ height:22px; line-height:22px; cursor:pointer; float:left; padding-left:8px;}
        #continer{ width:380px; margin:0 auto; padding:10px 0 0 8px; text-align:left;}
    </style>
    <script type="text/javascript">
        $(document).ready(function() {
            LoadData();
        });
        function LoadData() {
            $.ajax({
                url: "/admin/ajax/basesetting_list.aspx",
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
