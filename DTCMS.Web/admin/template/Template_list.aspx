<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Template_list.aspx.cs" Inherits="DTCMS.Web.admin.Template_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>风格管理</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
     <style type="text/css">
        #content ul li{
		float:left;
		color:#669900;
		list-style:none outside none;
		border-style:solid;
		border-width:1px;
		border-color:#EEEEEE #E3E3E3 #DDDDDD #E9E9E9;
		margin:3px;
		overflow:hidden;
		width:105px;
		height:130px;
	}
	#content ul li dl{
		clear:both;	
		margin:5px;
	}
	#content ul li dl dt a{
		display:table-cell;
		text-align:center;
		vertical-align:middle;
     	*display:block;
		*font-size:75px;
		*font-family:Arial;
		color:#F9F9F9;
		border:0 none;
		background-color:transparent;
		text-decoration:none;
		width:105px;
		height:100px;
		line-height:90px;	
		overflow:hidden;
	}
	#content dl dt a:hover{
		background-color:#FFFABF;
	}
	#content dl dt a img{
		border:1px solid #FFFFFF;
		display:inline;
		margin:3px;
		vertical-align:middle;
		overflow:hidden
	}
	#content dl dd{
		clear:both;
		margin:0 4px 4px;	
	}
    </style>
    <script type="text/javascript">
         $(document).ready(function() {
            LoadData(1);
        });
        function LoadData(page) {
            $.ajax({
                url: "../ajax/template_list.aspx",
                type: "GET",
                data: "action=load&ran=" + Math.random(),
                success: function(responseText) {
                    $("#data").innerHTML = responseText;
                }
            });
        }
    </script>
</head>
<body>
    
        <div id="tab_menu" class="tabs">
			<ul>
				<li class="tab_on"><a href="javascript:;" >后台首页</a></li>
			</ul>
		</div>
		<div id="content">
		    <div class="toolbar">
                <a href="template_add.aspx" class="button b4"><img src="../images/ico/i_add.gif" alt="" />添加风格</a>
           </div>   
           <div id="data">
                
           </div>
        </div>
    
</body>
</html>
