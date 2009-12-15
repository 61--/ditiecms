<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Photo_add.aspx.cs" Inherits="DTCMS.Web.admin.Media.Photo_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>图片上传</title>
    <style type="text/css">
        #content
        {
            width:760px;
        }
        #left
        {
            float:left;
            width:570px;
        }
        #right
        {
            float:right;
            width:188px;
        }
        .p_file
        {
            background: url(../images/blue/login_input_bg.gif) no-repeat left top #F7FAFC;
        }
        .p_info
        {
            background: url(../images/blue/login_input_bg.gif) no-repeat left top #F7FAFC;
            width:122px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="content">
        <div id="left">
            <div id="l_top">
                <fieldset><legend>图片上传</legend>
				    <table cellpadding="0" cellspacing="2" width="100%">
				        <tr>
				            <td width="6%"></td>
				            <td width="38%">图片浏览</td>
				            <td width="28%">图片名称</td>
				            <td width="28%">图片描述</td>				            
				        </tr>
				        <tr>
				            <td>1:</td>
				            <td><input type="file" name="file1" id="file1" class="p_file" /></td>
				            <td><input type="text"name="txt_photoName1" id="txt_photoName1" class="p_info" /></td>
				            <td><input type="text"name="txt_photoInfo1" id="txt_photoInfo1" class="p_info" /></td>
				        </tr>
				        <tr>
				            <td>2:</td>
				            <td><input type="file" name="file2" id="file2" class="p_file" /></td>
				            <td><input type="text"name="txt_photoName2" id="txt_photoName2" class="p_info" /></td>
				            <td><input type="text"name="txt_photoInfo2" id="txt_photoInfo2" class="p_info" /></td>
				        </tr>
				        <tr>
				            <td>3:</td>
				            <td><input type="file" name="file3" id="file3" class="p_file" /></td>
				            <td><input type="text"name="txt_photoName3" id="txt_photoName3" class="p_info" /></td>
				            <td><input type="text"name="txt_photoInfo3" id="txt_photoInfo3" class="p_info" /></td>
				        </tr>
				        <tr>
				            <td>4:</td>
				            <td><input type="file" name="file4" id="file4" class="p_file" /></td>
				            <td><input type="text"name="txt_photoName4" id="txt_photoName4" class="p_info" /></td>
				            <td><input type="text"name="txt_photoInfo4" id="txt_photoInfo4" class="p_info" /></td>
				        </tr>
				        <tr>
				            <td>5:</td>
				            <td><input type="file" name="file5" id="file5" class="p_file" /></td>
				            <td><input type="text"name="txt_photoName5" id="txt_photoName5" class="p_info" /></td>
				            <td><input type="text"name="txt_photoInfo5" id="txt_photoInfo5" class="p_info" /></td>
				        </tr>
				    </table>
				</fieldset>
			</div>
	        <div id="l_bottom">
	            <fieldset><legend>参数设置</legend></fieldset>
	        </div>
        </div>
        
        <div id="right">
            <fieldset><legend>预览</legend>
		    <div style="width:100%;overflow: auto;height:340px">
		    <div id="Preview" style="overflow: visible;"></div>
		    </div>
		    </fieldset>
        </div>
    </div>
    <input type="hidden" id="FileType" name="FileType" value="Image" />
    <input type="hidden" id="CatalogID" name="CatalogID" value="" />
    <input type="hidden" id="OtherIDs" name="OtherIDs" value="" />
    </form>
</body>
</html>
