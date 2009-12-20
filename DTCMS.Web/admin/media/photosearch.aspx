<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="photosearch.aspx.cs" Inherits="DTCMS.Web.admin.PhotoSearch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>附件浏览</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
    <style type="text/css">
    *{
	    padding:0px;
	    margin:0 auto;
	    font-family:Verdana, Arial, Helvetica, sans-serif;
	    font-size:12px;
    }
    
    .text{
	    width:119px;
    }
     .txt_bg{
        background: url(../images/blue/login_input_bg.gif) no-repeat left top #F7FAFC;
    }   
    button
    {
        margin-left:20px;
	    border: 0px;
	    height: 22px;
	    width:51px;
	    letter-spacing: 2px;
	    color: #555;
	    overflow:hidden;
	    background: url(../images/blue/button.jpg) no-repeat left top transparent;
    }
    button:hover
    {
        cursor:pointer;
        background-position:-99px -88px;
    } 
    #container{
		width:570px;
		text-align:left;
	}
	#search{
		float:left;
		margin-top:3px;
	}
	#search ul li{
		float:left;
		list-style:none;
		width:190px;
	}	
	#content	
	{
	    float:left;	
		margin-top:8px;
	}
	#content ul li{
		float:left;
		color:#669900;
		list-style:none outside none;
		border-style:solid;
		border-width:1px;
		border-color:#EEEEEE #E3E3E3 #DDDDDD #E9E9E9;
		margin:5px;
		overflow:hidden;
		width:130px;
		height:160px;
	}
	#content ul li dl{
		clear:both;	
		margin:3px;
	}
	#content ul li dl dt a{
		display: table-cell;   
		text-align:center;
		vertical-align:middle;
     	*display:block;
		*font-size:105px;
		*font-family:Arial;
		color:#F9F9F9;
		border:0 none;
		background-color:transparent;
		text-decoration:none;
		width:130px;
		height:130px;
		line-height:120px;	
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
	#ajaxpage
	{
	    float:right;
	    padding-top:8px;
	    padding-bottom:3px;
</style>
    <script type="text/javascript">
        $(document).ready(function() {
            LoadData(1);
        });
        function LoadData(page) {
            $.ajax({
                url: "../ajax/attachment_list.aspx",
                type: "GET",
                data: "action=image&page="+page+"&ran=" + Math.random(),
                success: function(responseText) {
                    document.getElementById("data").innerHTML = responseText;
                }
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container" style="width:570px;">
		<div id="search">
			<ul>
				<li>附件类型：<input type="text" id="txt_attachmentType" class="text txt_bg" /></li>
				<li>附件名称：<input type="text" id="txt_attachmentName"  class="text txt_bg" /></li>
				<li><button id="btn_search">搜索</button></li>			
			</ul>
		</div>
		<div id="data"></div>
	</div>

    </form>
    <script type="text/javascript">
    /**
    *选择图片
    */
    function selectImage(chk_id) {
        var chk = document.getElementById(chk_id);
        if (chk) {
            chk.checked = !chk.checked;
        }           
    }
    </script>
</body>
</html>
