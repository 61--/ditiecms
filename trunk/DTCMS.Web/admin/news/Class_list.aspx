<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Class_list.aspx.cs" Inherits="DTCMS.Web.admin.news.Class_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>栏目列表</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <link href="../component/treetable/css/tabletree4j.css" type="text/css" />
    <script type="text/javascript" src="/js/J.min2.js"></script>
    <script type="text/javascript" src="../component/treetable/TableTree4J.js"></script>
    <script type="text/javascript">

        J(document).ready(function(){
           LoadData();
        });
        function LoadData(){
            J.ajax({
                url:"/admin/ajax/class_list.aspx",
                type:"get",              
                data:"action=load",
                fn:function(json){ 
                    //debugger;
                    var data=eval("data="+json);
                    showGridTree(data);  
                }
            });
        }
        var gridTree;	
	    function showGridTree(json){

		    gridTree=new TableTree4J("gridTree","../component/treetable/");	
		    gridTree.config.useIcon=true;
		    gridTree.tableDesc="<table class=\"table_data\">";	
		    var headerDataList=new Array("栏目名称","创建时间","所属类型","排序");
		    var widthList=new Array("50%","20%","20%","10%");
		    //参数: arrayHeader,id,headerWidthList,booleanOpen,classStyle,hrefTip,hrefStatusText,icon,iconOpen
		    gridTree.setHeader(headerDataList,-1,widthList,true,"GridHead","This is a tipTitle of head href!","header status text","","");				

		    //设置列样式
		    gridTree.gridHeaderColStyleArray=new Array("","","","centerClo");
		    gridTree.gridDataCloStyleArray=new Array("","","","centerClo");	
    	  
	       J.each(json,function(i,n){
	   
	           var dataList=new Array(n.classname,n.classtype,n.adddate,n.orderid);
	           gridTree.addGirdNode(dataList,n.cid,n.parentid==0?-1:n.parentid,null,n.orderid);
	       });
	       gridTree.printTableTreeToElement("content");		
    	
	    }
	
        
    </script>
    
</head>
<body>
    <div id="container">
		<div id="tab_menu" class="tabs">
			<ul>
				<li class="tab_on"><a href="javascript:;">栏目管理</a></li>
			</ul>
		</div>
		<div id="content">

	
		</div>
	</div>
</body>
</html>
		<%--<script type="text/javascript">

                var Ptr = document.getElementById("tab").getElementsByTagName("tr");
                function $() {
                    for (i = 1; i < Ptr.length + 1; i++) {
                        Ptr[i - 1].className = (i % 2 > 0) ? "t1" : "t2";
                    }
                }
                window.onload = $;
                for (var i = 0; i < Ptr.length; i++) {
                    Ptr[i].onmouseover = function() {
                        this.tmpClass = this.className;
                        this.className = "t3";

                    };
                    Ptr[i].onmouseout = function() {
                        this.className = this.tmpClass;
                    };
                }

            </script>--%>