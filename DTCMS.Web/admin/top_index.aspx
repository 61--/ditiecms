<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="top_index.aspx.cs" Inherits="DTCMS.Web.Admin.top_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<title>物业管理系统</title>
<link href="css/blue_top.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
function $Nav(){
	if(window.navigator.userAgent.indexOf("MSIE")>0) return 'IE';
  else if(window.navigator.userAgent.indexOf("Firefox")>0) return 'FF';
  else return "OT";
}

var preID = 0;

function OpenMenu(cid,lurl,rurl,bid){
   if($Nav()=='IE'){
     if(rurl!='') top.document.frames.main.location = rurl;
     if(cid > -1) top.document.frames.menu.location = 'left_index.aspx?c='+cid;
     else if(lurl!='') top.document.frames.menu.location = lurl;
     if(bid>0) document.getElementById("d"+bid).className = 'thisclass';
     if(preID>0 && preID!=bid) document.getElementById("d"+preID).className = '';
     preID = bid;
   }else{
     if(rurl!='') top.document.getElementById("main").src = rurl;
     if(cid > -1) top.document.getElementById("menu").src = 'left_index.aspx?c='+cid;
     else if(lurl!='') top.document.getElementById("menu").src = lurl;
     if(bid>0 && bid!=9) document.getElementById("d"+bid).className = 'thisclass';
     if(preID>0) document.getElementById("d"+preID).className = '';
     preID = bid;
   }
}

var preFrameW = '160,*';
var FrameHide = 0;
function ChangeMenu(way){
	var addwidth = 10;
	var fcol = top.document.all.bodyFrame.cols;
	if(way==1) addwidth = 10;
	else if(way==-1) addwidth = -10;
	else if(way==0){
		if(FrameHide == 0){
			preFrameW = top.document.all.bodyFrame.cols;
			top.document.all.bodyFrame.cols = '0,*';
			FrameHide = 1;
			return;
		}else{
			top.document.all.bodyFrame.cols = preFrameW;
			FrameHide = 0;
			return;
		}
	}
	fcols = fcol.split(',');
	fcols[0] = parseInt(fcols[0]) + addwidth;
	top.document.all.bodyFrame.cols = fcols[0]+',*';
}

function resetBT(){
	if(preID>0) document.getElementById("d"+preID).className = 'bdd';
	preID = 0;
}
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="topnav">
	    <div class="sitenav">
		    <div class="welcome">
			    你好<span class="username"></span>
		    </div>
		    <div class="welcome">
		    <a href="javascript:ChangeMenu(-1)"><img src='images/blue/frame-l.gif' alt="减小左框架" /></a>
        <a href="javascript:ChangeMenu(0)"><img src='images/blue/frame_on.gif' alt="隐藏/显示左框架" /></a>
        <a href="javascript:ChangeMenu(1)" title="增大左框架"><img src='images/blue/frame-r.gif' alt="增大左框架" /></a>
        </div>
		    <div class="sitelink">
			    <a href="javascript:OpenMenu(0,'','main_index.aspx',0)">管理主页</a> |  
                <asp:LinkButton ID="hlkExi" runat="server" OnClick="hlkExi_Click">注销登陆</asp:LinkButton>
            </div>
	    </div>
	    <div class="leftnav">
		    <ul>
			    <li class="navleft"></li>
			    <li id='d1' style="margin-left:-1px"><a href="javascript:OpenMenu(1,'','news/Class_list.aspx',1)">频道管理</a></li>
			    <li id='d2'><a href="javascript:OpenMenu(2,'','news/News_list.aspx',2)">内容管理</a></li>
			    <li id='d3'><a href="javascript:OpenMenu(3,'','news/news_list.html',3)">生成管理</a></li>
			    <li id='d4'><a href="javascript:OpenMenu(4,'','main_index.aspx',4)">采集管理</a></li>
                <li id='d5'><a href="javascript:OpenMenu(5,'','main_index.aspx',5)">用户管理</a></li>
			    <li id='d6'><a href="javascript:OpenMenu(6,'','main_index.aspx',6)">插件管理</a></li>
			    <li id='d7' style="margin-right:-1px"><a href="javascript:OpenMenu(7,'','main_index.aspx',7)">系统管理</a></li>
			    <li class="navright"></li>
		    </ul>
	    </div>
    </div>
    </form>
</body>
</html>
