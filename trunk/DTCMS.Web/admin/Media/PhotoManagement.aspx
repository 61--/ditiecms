<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhotoManagement.aspx.cs" Inherits="DTCMS.Web.admin.Media.PhotoManagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>图片管理</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="tab_menu" class="tabs">
                <ul>
                    <li class="tab_on"><a onclick="showFrameImageUpload();" href="javascript:void(0)">图片上传</a></li>
                    <li><a onclick="showFrameImageBrowse();" href="javascript:void(0)">图片浏览</a></li>
                </ul>
            </div>
            <div id="content">
                <iframe src="Photo_add.aspx" width="100%" height="0" id="Frame_ImageUpload" frameborder="0" scrolling="auto" ></iframe>
                <iframe src="Photo_add.aspx" width="100%" height="0" id="Frame_ImageBrowse" frameborder="0" scrolling="auto"></iframe>
            </div>
		</div>
	</form>
	
	<script type="text/javascript">
	    /**
	    *图片上传
	    */
	    function showFrameImageUpload() {
	        $("#Frame_ImageUpload").css({ "height": "370px"});
	        $("#Frame_ImageBrowse").css({ "height": 0 });
	    }
	    /**
	    *图片浏览
	    */
	    function showFrameImageBrowse(){
	        $("#Frame_ImageUpload").css({ "height": 0 });
	        $("#Frame_ImageBrowse").css({ "height": "370px" });
	    }
	</script>
</body>
</html>
