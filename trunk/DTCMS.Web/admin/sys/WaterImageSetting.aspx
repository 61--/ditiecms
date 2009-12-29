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
        .hr{ height:12px; line-height:12px; overflow:hidden; clear:both;}
        .caption{ margin:0 0 0 3px; height:28px; line-height:28px;}
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
                        <input type="text" id="txt_WaterFontColor" class="textbox short" runat="server" /><img src="../images/blue/s.gif" class="select" alt="选取" />
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        水印文字类型:
                    </td>
                    <td class="main_bright split">
                        <select id="slt_WaterFontType" runat="server" style="width: 185px; background: #F7FAFC;"></select>
                    </td>
                </tr>
                <tr>
                    <td class="main_bleft split">
                        水印文字大小:
                    </td>
                    <td class="main_bright split">
                        <input type="text" id="txt_WaterFontSize" class="textbox short" runat="server" /><span class="caption">(单位:像素)</span>
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
                        <input type="text" id="txt_WaterImageUrlTran" class="textbox short" runat="server" /><span class="caption">(1到100)</span>
                    </td>
                </tr>
                <tr>
                     <td class="main_bleft split">
                        水印位置:
                    </td>
                    <td class="main_bright split">
                        <table id="tb_percent" cellpadding="0" cellspacing="0" border="0">
                            <tbody>
                                <tr>
                                    <td><input type="radio" id="rdo_top_left" name="percent"/><label for="rdo_top_left">左上</label></td>
                                    <td><input type="radio" id="rdo_top_center" name="percent" /><label for="rdo_top_center">中上</label></td>
                                    <td><input type="radio" id="rdo_top_right" name="percent" /><label for="rdo_top_right">右上</label></td>
                                </tr>
                                <tr>
                                    <td><input type="radio" id="rdo_center_left" name="percent"/><label for="rdo_center_left">左中</label></td>
                                    <td><input type="radio" id="rdo_center_center" name="percent" /><label for="rdo_center_center">局中</label></td>
                                    <td><input type="radio" id="rdo_center_right" name="percent" /><label for="rdo_center_right">右中</label></td>
                                </tr>
                                <tr>
                                    <td><input type="radio" id="rdo_bottom_left" name="percent"/><label for="rdo_bottom_left">左下</label></td>
                                    <td><input type="radio" id="rdo_bottom_center" name="percent" /><label for="rdo_bottom_center">中下</label></td>
                                    <td><input type="radio" id="rdo_bottom_right" name="percent" /><label for="rdo_bottom_right">右下</label></td>
                                </tr>
                            </tbody>
                        </table>  
                        <input type="hidden" id="hidden_XPercent" value="0" runat="server" />  
                        <input type="hidden" id="hidden_YPercent" value="0" runat="server" />  
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="hr"></div>
        <div style="text-align:center;">
        <button type="button" id="btn_Save" class="b1" runat="server">保存</button>
        <button id="btn_Cancel" type="button" class="b1" onclick="history.back(-1);"> 取消</button></div>
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
