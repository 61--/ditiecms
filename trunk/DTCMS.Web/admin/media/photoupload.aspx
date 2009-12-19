<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="photoupload.aspx.cs" Inherits="DTCMS.Web.admin.PhotoUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title>图片上传</title>  
<link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
<link href="/Inc/Dialog/dialog.css" rel="stylesheet" type="text/css" />        
<script type="text/javascript" src="/Inc/Dialog/Dialog.js"></script>
<style type="text/css">
    *{
	    padding:0px;
	    margin:0px;
	    font-family:Verdana, Arial, Helvetica, sans-serif;
	    font-size:12px;
    }      
    tr
    {
        height:24px;
        line-height:24px;        
    }
    td
    {
        padding-left:6px;         
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
    <div style="display:none;"><iframe name="formTarget" src="javascript:void(0)" height="0"></iframe></div>	
    <form enctype="multipart/form-data" id="form1" name="Form1" target="formTarget" method="post" action="SimpleUploader.aspx?type=image">
    <div id="content" style="text-align:center; width:100%;">
        <div id="upload" style="width:570px;">
            <div id="top" style="float:left; text-align:left;">
                <div id="div_attachmentAttribute" style="margin-bottom:4px;">
                    <input type="radio" id="rdo_photo" name="rdo" checked="checked" value="1" onclick="setAttachmentAttribute(this)" /><label for="rdo_photo">图片</label>
                    <input type="radio" id="rdo_video" name="rdo" value="2" onclick="setAttachmentAttribute(this)" /><label for="rdo_video">视频</label>
                    <input type="radio" id="rdo_audio" name="rdo" value="3" onclick="setAttachmentAttribute(this)" /><label for="rdo_audio">音频</label>
                    <input type="radio" id="rdo_flash" name="rdo" value="4" onclick="setAttachmentAttribute(this)" /><label for="rdo_flash">Flash</label>
                    <input type="radio" id="rdo_attachment" name="rdo"  value="5" onclick="setAttachmentAttribute(this)" /><label for="rdo_attachment">附件</label>
                    <input type="hidden" id="hid_attachmentAttribute" name="hid_attachmentAttribute" value="1" />
                </div>
                <fieldset>
                    <legend>附件上传</legend>
                    <table id="imagetable0" style="width:100%;empty-cells:show ;" cellpadding="0" cellspacing="0" >
                        <tr>
                            <td style="width:6%;" align="right"></td>
                            <td style="width:34%;">附件浏览</td>
                            <td style="width:30%;">附件名称</td>
                            <td style="width:30%;">附件描述</td>
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
            <div id="bottom" style="float:left; margin-top:6px; ">
                 <fieldset><legend>
                 <label>图片参数设置</label></legend>
                    <table width="100%" cellpadding="2" cellspacing="0">
                        <tr>
                            <td style="width:53%;text-align:left; vertical-align:top;">
                            <table width="100%" cellpadding="2" cellspacing="0">                                  						
                                <tr>
                                    <td style="width:18%;text-align:right;"><label>原图水印:</label></td>
                                    <td style="width:82%;"><input type="hidden" id="HasWaterMark"
                                        name="HasWaterMark" value="0" /> <input
                                        type="checkbox" id="chHasWaterMark" name="chHasWaterMark"  class="txt_bg" value="true" />
                                    <input type="hidden" id="Count" name="Count" value="1" /></td>
                                </tr>	
                                <tr id="AbbrImagesTable">
                                    <td align="right"><label>缩略图:</label></td>
                                    <td>
                                        <input type="checkbox" id="chHasAbbrImage1" class="txt_bg" name="chHasAbbrImage1" checked="checked" value="true"/>
                                    </td>
                                </tr>								
                                <tr>
                                    <td style="vertical-align:top;text-align:right;">缩略图水印:</td>
                                    <td>
                                        <input type="checkbox" id="chHasWaterMark1" class="txt_bg" name="chHasWaterMark1" value="true" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">缩略图宽:</td>
                                    <td>
                                        <input name="abbrImageWidth1" id="abbrImageWidth1" class="txt_bg"
                                        type="text" value="500" style="width:36px"
                                        maxlength="4" /> 
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">缩略图高:</td>
                                    <td>
                                        <input name="abbrImageHeight1" id="abbrImageHeight1" class="txt_bg"
                                        type="text" value="0" style="width:36px"
                                        maxlength="4" />
                                    </td>
                                </tr>
                             </table>
                            </td>						
                        </tr>
                     </table>		
                    </fieldset>
                </div>
        </div>
        <div style="clear:both;" id="msg"></div>
        <div id="browse">        
        </div>
    </div>
    </form>
    <script type="text/javascript">
        /**
        *上传完成
        */
        function onUploadCompleted(returnVal, errorMsg, returnImgPath) {
            switch (returnVal) {
                case "1": // 上传成功
                    try {
                        if (window.parent.parent.document.getElementById("imgDisplay"))
                            window.parent.parent.document.getElementById("imgDisplay").src = returnImgPath;
                        if (window.parent.parent.document.getElementById("imgPath"))
                            window.parent.parent.document.getElementById("imgPath").value = returnImgPath;
                        window.parent.parent.Dialog.close();
                    } catch (ex) { }
                    break;
                case "202":
                    Dialog.alert('无效的文件类型！以下文件上传失败:' + errorMessage);
                    return;
                case "203":
                    Dialog.alert("您没有权限上传此文件，请检查服务器设置");
                    return;
                default:
                    Dialog.alert('上传失败，错误代码: ' + returnVal);
                    return;
            }
        }
        /**
        *开始上传
        */
        function upload() {
            var flag = false;
            var count = 5;

            for (var i = 1; i <= count; i++) {
                var imgName = document.getElementById("File" + i).value;
                if (imgName == "") {
                    continue;
                }
                var ext = imgName.substring(imgName.lastIndexOf(".") + 1).toLowerCase();
                if (hasAttachmentFormat(ext)) {
                    flag = true;
                } else {
                    Dialog.alert("附件上传不支持" + ext + "文件！请重新选择。");
                    return;
                }
            }
            if (flag) {
                msg();
                document.getElementById("form1").submit();
            } else {
                Dialog.alert("请先浏览选择文件！");
                return;
            }
        }
        /**
        *附件格式判断
        */
        function hasAttachmentFormat(ext) {
        switch (getAttachmentAttribute()) {
        case "1":
        return hasImage(ext);
        case "5":
        return hasAttachment(ext);
        return 
        default:
        return false;
        }
        }
        /**
        *判断图片是否正确
        */
        function hasImage(ext) {
            return (ext == "jpg" || ext == "jpeg" || ext == "bmp" || ext == "gif" || ext == "png");
        }
        /**
        *附件上传是否正确
        */
        function hasAttachment(ext) {
             return (ext == "doc" || ext == "txt");
        }
        /**
        *上传进度条
        */   	    	
    	function msg() {
    	    var txt = "正在上传处理中，请稍候...耗时";
    	    var counter = 1;
    	    setInterval(function() { document.getElementById("msg").innerHTML = "<font color=red>" + txt + counter + "秒</font>"; counter++ }, 1000);
    	}
    	/**
    	*设置附件属性
    	*/
    	function setAttachmentAttribute(obj) {
    	    document.getElementById("hid_attachmentAttribute").value = (obj.value || 1);
    	}
    	/**
    	*获取附件属性
    	*/
    	function getAttachmentAttribute() {
    	    return (document.getElementById("hid_attachmentAttribute").value||1);
    	}
    </script>
</body>
</html>
