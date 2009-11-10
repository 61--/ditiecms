<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Class_add.aspx.cs" Inherits="DTCMS.Web.admin.news.Class_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>栏目添加</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="form_table">
            <table width="96%" align="center" cellpadding="10" cellspacing="1" class="tab1">
                 <tr>
                     <td class="main_bleft">是否隐藏栏目:</td>
                     <td class="main_bright">
                        <input type="radio" name="radIsHtml" id="rad_Show" value="" runat="server" />显示&nbsp;&nbsp;&nbsp;&nbsp; 
                       <input type="radio" name="radIsHtml" id="rad_Hide" runat="server" /> 隐藏 
                     </td>
                 </tr>   
                 <tr>
                     <td class="main_bleft">栏目名称:</td>
                     <td class="main_bright"><input type="text" id="txt_ClassName" runat="server" /></td>
                 </tr>   
                
                 <tr>
                     <td class="main_bleft">浏览权限:</td>
                     <td class="main_bright"><select id="sel_Readaccess" runat="server"></select></td>
                 </tr>   
                 <tr>
                      <td class="main_bleft">栏目属性:</td>
                      <td class="main_bright">
                          <input type="radio" name="radAttribute" id="rad_AttributeCover" /><label for="rad_AttributeCover">频道封面</label><br />  
                          <input type="radio" name="radAttribute" id="rad_AttributeList" />最终列表栏目<br />  
                          <input type="radio" name="radAttribute" id="rad_AttributeUrl" />外部连接<br />  
                      </td>
                 </tr>   
            </table>
    </div>
    </form>
</body>
</html>
