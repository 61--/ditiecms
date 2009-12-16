<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Photo_add.aspx.cs" Inherits="DTCMS.Web.admin.Media.Photo_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>图片上传</title>  
<style type="text/css">
    body{
	    border:0;
	    padding:0;
	    margin:0;
	    font-size:12px;
    }
    .text{
	    width:119px;
    }
    .file{
	    cursor:pointer;
	    width:258px;
    }
     .txt_bg{
        background: url(../images/blue/login_input_bg.gif) no-repeat left top #F7FAFC;
    }
</style>
  
</head>
<body>
    <form id="form1" runat="server">
    <div id="content">
        <div id="upload" style="width:760px;">
	        <div id="left" style="width:75%;float:left;">
                <div id="top">
	                <fieldset>
		                <legend>图片上传</legend>
		                <table id="imagetable0" style="width:100%;" cellpadding="2" cellspacing="0">
			                <tr>
				                <td style="width:6%;" align="right"></td>
				                <td style="width:34%;">图片浏览</td>
				                <td style="width:30%;">图片名称</td>
				                <td style="width:30%;">图片描述</td>
			                </tr>
			                <tr>
				                <td align="right"><label>1:</label></td>
				                <td><input name='File1' id='File1' class="file txt_bg" type='file' value=''
					                size="26" /></td>
				                <td><input name="File1Name" id="File1Name" class="text txt_bg" type="text"
					                value="" /></td>
				                <td><input name="File1Info" id="File1Info" class="text txt_bg" type="text"
					                value="" /></td>
			                </tr>	
			                <tr>
				                <td align="right"><label>2:</label></td>
				                <td><input name='File2' id='File2' class="file txt_bg" type='file' value=''
					                size='26' /></td>
				                <td><input name="File2Name" id="File2Name"  class="text txt_bg" type="text"
					                value="" /></td>
				                <td><input name="File2Info" id="File2Info" class="text txt_bg" type="text"
					                value="" /></td>
			                </tr>
			                <tr>
				                <td align="right"><label>3:</label></td>
				                <td><input name='File3' id='File3' class="file txt_bg" type='file' value=''
					                size='26' /></td>
				                <td><input name="File3Name" id="File3Name" class="text txt_bg" type="text"
					                value=""/></td>
				                <td><input name="File3Info" id="File3Info" class="text txt_bg" type="text"
					                value="" /></td>
			                </tr>
			                <tr>
				                <td align="right"><label>4:</label></td>
				                <td><input name='File4' id='File4' class="file txt_bg" type='file' value=''
					                size='26' /></td>
				                <td><input name="File4Name" id="File4Name" class="text txt_bg" type="text"
					                value="" /></td>
				                <td><input name="File4Info" id="File4Info" class="text txt_bg" type="text"
					                value="" /></td>
			                </tr>
			                <tr>
				                <td align="right"><label>5:</label></td>
				                <td><input name='File5' id='File5' class="file txt_bg " type='file' value=''
					                size='26' /></td>
				                <td><input name="File5Name" id="File5Name" class="text txt_bg" type="text"
					                value="" /></td>
				                <td><input name="File5Info" id="File5Info" class="text txt_bg" type="text"
					                value="" /></td>
			                </tr>
            			
		                </table>
	                </fieldset>
                </div>
                <div id="bottom">
	                 <fieldset><legend>
	                 <label>参数设置</label></legend>
		                <table width="100%" cellpadding="2" cellspacing="0">
			                <tr>
				                <td style="width:53%;text-align:left; vertical-align:top;">
				                <table width="100%" cellpadding="2" cellspacing="0">
					                <tr>
						                <td style="width:18%;text-align:right;">所属主分类:</td>
						                <td style="width:82%;">
						                <input type="text"  class="txt_bg" />
						                </td>
					                </tr>
            						
					                <tr>
						                <td align="right"><label>原图水印:</label></td>
						                <td><input type="hidden" id="HasWaterMark"
							                name="HasWaterMark" value="0" /> <input
							                type="checkbox" id="chHasWaterMark" name="chHasWaterMark"  class="txt_bg />
						                <input type="hidden" id="Count" name="Count" value="1" /></td>
					                </tr>	
					                <tr id="AbbrImagesTable">
						                <td align="right"><label>缩略图:</label></td>
						                <td>
							                <input type="hidden" id="HasAbbrImage1"
							                name="HasAbbrImage1" value="1" /> <input
							                type="checkbox" id="boxHasAbbrImage1" class="txt_bg
							                name="boxHasAbbrImage1" />
            							
						                </td>
					                </tr>								
					                <tr>
						                <td style="vertical-align:top;text-align:right;">缩略图水印:</td>
						                <td>
						                 <label> <input type="hidden" id="HasWaterMark1"
							                name="HasWaterMark1" value="0" /> <input
							                type="checkbox" id="chHasWaterMark1" class="txt_bg
							                name="chHasWaterMark1" /></label>
            							
						                </td>
					                </tr>
					                <tr>
						                <td align="right" valign="top">缩略图宽:</td>
						                <td>
						                 <label> <input name="Width1" id="Width1" class="txt_bg
							                type="text" value="500" style="width:36px"
							                maxlength="4" /> </label> 
						                </td>
					                </tr>
					                <tr>
						                <td align="right" valign="top">缩略图高:</td>
						                <td>
						                 <label> <input name="Height1" id="Height1" class="txt_bg
							                type="text" value="500" style="width:36px"
							                maxlength="4" /> </label> 
						                </td>
					                </tr>

				                </table>
				                </td>						
			                </tr>

		                </table>		
	                </fieldset>

                </div>
            </div>
            <div id="right" style="width:25%;float:left;">
                <fieldset>
	                <legend>预览</legend>
	                <div style="overflow: auto;height:320px;*height:333px;">
		                <div id="Preview" style="overflow: visible;"></div>
	                </div>
                </fieldset>
            </div>
        </div>
        
        <div id="browse">
        
        </div>
    </div>
    </form>
</body>
</html>
