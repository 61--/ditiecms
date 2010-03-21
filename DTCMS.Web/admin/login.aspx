<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="DTCMS.Web.admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>DTCMS内容管理系统后台登陆</title>
    <link rel="stylesheet" type="text/css" href="css/login.css" />
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="../inc/dialog/dialog.js"></script>
    <link href="../inc/dialog/dialog.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
    function CheckLogin(){
        if($("#txt_username").val()==""){
            alert('用户名不能为空！');
            return false;
        }
        if($("#txt_password").val()==""){
            alert('用户密码不能为空！');
            return false;
        }
        if($("#txt_checkcode").val()==""){
            alert('验证码不能为空！');
            return false;
        } 
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <div class="title">
                <em style="text-align: center"><a href="/Default.aspx" target="_top">返回首页</a></em> <em style="text-align: center"><a href="javascript:alert('请联系网站管理员！')">
                    忘记密码？</a></em>
            </div>
            <div class="login">
                <div class="inputbox">
                    <dl>
                        <dt>用户名：</dt>
                        <dd>
                            <input type="text" id="txt_username" size="23" runat="server" onfocus="this.style.borderColor='#239fe3'"
                                onblur="this.style.borderColor='#dcdcdc'" />
                        </dd>
                    </dl>
                    <dl>
                        <dt>密 码：</dt>
                        <dd>
                            <input type="password" id="txt_password" size="23" runat="server" onfocus="this.style.borderColor='#239fe3'"
                                onblur="this.style.borderColor='#dcdcdc'" />
                        </dd>
                    </dl>
                    <dl>
                        <dt>验证码：</dt>
                        <dd>
                            <input type="text" id="txt_checkcode" runat="server" style="width: 60px;" onfocus="this.style.borderColor='#239fe3'"
                                onblur="this.style.borderColor='#dcdcdc'" />&nbsp;
                            <img src="../ValidateCode.ashx" alt="看不清楚验证码？单击图片换一个" onclick="src='../ValidateCode.ashx?r='+Math.random()"
                                style="cursor: pointer" />
                        </dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd style="margin-top: 3px;">
                            <asp:Button ID="btnLogin" runat="server" CssClass="input" OnClick="btnLogin_Click" OnClientClick="return CheckLogin()" /></dd></dl>
                </div>
                <div class="butbox">
                    <dl>
                        <dt></dt>
                        <dd>
                        </dd>
                    </dl>
                </div>
                <div class="clear">
                </div>
            </div>
            <div class="copyright">
                Copyright &copy; 2006-2009 All Rights Reserved.
            </div>
        </div>
    </form>
</body>
</html>
