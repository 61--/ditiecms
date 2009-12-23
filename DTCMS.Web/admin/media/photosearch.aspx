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
	    width:109px;
    }
     .txt_bg{
        background: url(../images/blue/login_input_bg.gif) no-repeat left top #F7FAFC;
    }   
    .button
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
    .button:hover
    {
        cursor:pointer;
        background-position:-99px -88px;
    } 
    
    #container{
		width:570px;
		text-align:left;
	}
	/*搜索*/
	#search
	{
	    float:left;
		padding-top:-3px;
	}
	#search ul
	{
	    list-style:none outside none;
	}
	#search ul li{
		float:left;
		display:inline;
		width:190px;
		height:22px;
		line-height:22px;		
	}	
	/*图片浏览*/
	#data	
	{
	    float:left;
		margin-top:8px;
	}
	#content ul
	{
	    list-style:none outside none;
	}
	#content ul li{
		float:left;
		color:#669900;
		border:solid 1px #E3E3E3;	
		margin:3px;
		overflow:hidden;
		width:100px;
		height:130px;
	}	
	#content li:hover{
		background-color:#FFFABF;
	}
	#content ul li dl dt a
	{
		display:table-cell;
		vertical-align:middle;
		text-align:center;
        width:100px;
		height:108px;
		line-height:90px;	
     	*display: block;
        *font-size:75px;
		color:#F9F9F9;
		border:0 none;
		background-color:transparent;
		text-decoration:none;	
		overflow:hidden;
	}
	#content dl dt a img{
		border:1px solid #FFFFFF;
		margin:3px;
		width:91px;
		height:100px;
		vertical-align:middle;
	}
</style>
    <script type="text/javascript">
        $(document).ready(function() {
            LoadData(1);
        });
        function LoadData(page) {
            var attachmentTypeVal = document.getElementById("slt_attachmentType").value;
            var attachmentNameVal = document.getElementById("txt_attachmentName").value;
            $.ajax({
                url: "../ajax/attachment_list.aspx",
                type: "GET",
                data: "page=" + page + "&type="+attachmentTypeVal+"&name="+attachmentNameVal+"&ran=" + Math.random(),
                success: function(responseText) {
                    document.getElementById("data").innerHTML = responseText;
                }
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
		<div id="search">
			<ul>
				<li>附件类型：<select id="slt_attachmentType" class="text txt_bg">
				        <option value="1">----图 片----</option>
				        <option value="2">----视 频----</option>
				        <option value="3">----音 频----</option>
				        <option value="4">----Flash----</option>
				        <option value="5">----附 件----</option>
				    </select>
				</li>
				<li>附件名称：<input type="text" id="txt_attachmentName"  class="text txt_bg" /></li>
				<li><button id="btn_search" class="button" onclick="LoadData(1);">搜索</button></li>			
			</ul>
		</div>
		<div id="data"></div>
	</div>
	<input type="hidden" id="returnVal" value="" />
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
    function upload() {
        var chks = document.getElementsByName("items");
        var hid = document.getElementById("returnVal");
        if (chks) {
            for (i = 0; i < chks.length; i++) {
                if (chks[i].checked) {
                    hid.value = chks[i].value;
                }
            }
        }
        window.parent.parent.Dialog.close();        
    }
    /**
    *返回图片地址
    */
    function returnPath() {
        return document.getElementById("returnVal").value;        
    }
    </script>
</body>
</html>
