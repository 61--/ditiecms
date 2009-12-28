<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WaterImageSetting.aspx.cs" Inherits="DTCMS.Web.admin.sys.WaterImageSetting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>水印图片设置</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>
    <script type="text/javascript" src="../js/common.js"></script>    
    <style type="text/css">
        #continer{ margin:0 auto; width:760px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="continer">
        <table cellpadding="10" cellspacing="0" class="table_form">
             <tbody>
                <tr>
                    <td class="main_bleft split">
                        水印类型:
                    </td>
                    <td class="main_bright split">
                       <input type="radio" id="rdo_FontWater" name="rdo_Water" runat="server" checked="true" />
                       <label for="rdo_fontwater">文字水印</label>
                       <input type="radio" id="rdo_ImageWater" name="rdo_Water" runat="server" />
                       <label for="rdo_imagewater">图片水印</label>
                    </td>
                </tr>                    
                <tr>
                    <td class="main_bleft split">
                        水印文字:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_WaterFont" class="textbox short" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        水印文字颜色:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_WaterFontColor" class="textbox short" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        水印文字类型:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_WaterFontType" class="textbox short" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        水印文字大小:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_WaterFontSize" class="textbox short" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        水印图片地址:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_WaterImageUrl" class="textbox" runat="server" /><img src="../images/blue/s.gif" class="select" alt="选取" onclick="add_Image();" />
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        水印图片透明度:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_WaterImageUrlTran" class="textbox short" runat="server" />
                    </td>
                </tr>
                <tr>
                     <td class="main_bleft split">
                        水印位置:
                    </td>
                    <td class="main_bright split">
                        
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    </form>
    <script type="text/javascript">
        function add_Image() {  //缩略图
            dialogAttachmentUpload('/admin/attachment/attachmentmanage.aspx', attachment_onCancel);
        }
        function attachment_onCancel(returnPath) {
            if (returnPath) {
                $("#txt_ImageUrl").val(returnPath);
            }
        }
    </script>
</body>
</html>
