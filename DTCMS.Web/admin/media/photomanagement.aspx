﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="photomanagement.aspx.cs" Inherits="DTCMS.Web.admin.PhotoManagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>图片管理</title>
    <style type="text/css">
	    body{
	    margin:0 auto;
	    border:0;
	    padding:0;
	    text-align:center;
	    font-family:"Arial Unicode MS";
	    font-size:16px;
    }
    ul{
	    list-style:none;
	    margin:0px;
    }

	    #container{	
	    width:570px;
    }
	    #menu{
	    width:100%;
	    margin:5px 0 6px 0;
    }
	    #menu ul li{	   
	    float:left;
	    width:80px;		
    }
	    #menu ul li a{
	    display:block;
	    text-decoration:none;
	    cursor:pointer;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
	        <div id="menu">
		        <ul>
			        <li><a href="javascript:void(0)" onclick="attachmentUpload(this)">附件上传</a></li>
			        <li><a href="javascript:void(0)" onclick="attachmentSearch(this)">附件浏览</a></li>
		        </ul>
	        </div>
	        <div id="main">
		        <iframe src="photoupload.aspx" width="100%" height="340px" id="FrmUpload" name="FrmUpload" frameborder="0" scrolling="no"></iframe>
	        </div>
        </div>
	</form>
	<script type="text/javascript">
	    function attachmentUpload(obj) {
	        document.getElementById("FrmUpload").src = "photoupload.aspx";
	        obj.blur();
	    }
	    function attachmentSearch(obj) {
	        document.getElementById("FrmUpload").src = "photosearch.aspx";
	        obj.blur();
	    }
	</script>
</body>
</html>
