<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="classpagelist.aspx.cs" Inherits="DTCMS.Web.admin.news.classpagelist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>   
    <script type="text/javascript" src="/inc/treetable/TableTree4J.js"></script>
    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>
    <style type="text/css">
        *{ padding:0; margin:0;}
        #continer{ width:380px; margin:0 auto; padding:10px 0 0 8px; text-align:left;}
        .GridView {font-size:9pt;}
        .GridHead td {font-size:9pt;background-color:#999966;/**you can change the header BG here*/font-weight:bold;color: white;}
        .GridHead a {color: white;white-space: nowrap;text-decoration: none;}
        .GridHead a:hover{color: white;}
        .GridHighLightRow td {/*dafult name*/background-color: #EFF3FF;}
        .GRIDTREESTYLE{font-size:9pt;}
        .GRIDTREESTYLE a{white-space: nowrap;color: #0000FF;text-decoration: none;}
        .GRIDTREESTYLE a:hover{color: #0000FF;text-decoration: underline;}
        .GRIDTREESTYLE a.nodeSel{background-color: #DEEFEF;}
        .MenuRoot td {font-size:9pt;/*font-weight:bold;*/}
        .MenuRoot a {color: #333;white-space: nowrap;text-decoration: none;	}
        .MenuRoot a:hover{color: #333;}
        .MENUTREESTYLE{color:#666;font-size:9pt;}
        .MENUTREESTYLE a{white-space: nowrap;color: #333;text-decoration: none;}
        .MENUTREESTYLE a:hover{color: #333;	border:#83C2C2 solid;border-width:0px 0px 1px;	/*text-decoration: underline;*/}
        .MENUTREESTYLE a.nodeSel{background-color: #DEEFEF;}
        .treeCurBg{ background:transparent url(/admin/images/treeItemBgCur.gif) repeat-x scroll 0 0;}
    </style>
    <script type="text/javascript">
        $(document).ready(function() {
            LoadData();
        });
        function LoadData() {
            $.ajax({
                url: "/admin/ajax/class_list.aspx",
                type: "GET",
                data: "action=listpage&ran=" + Math.random(),
                success: function(json) {
                    showMenuTree(json);
                }
            });
        }
        var classTree;
        function showMenuTree(json) {
            classTree = new TableTree4J("classTree", "/inc/treetable/");
            classTree.toMenuMode();
            classTree.setMenuRoot("<a id='root' style=\"cursor:pointer;\" onclick=\"onClick_GetClass('-1','root[顶级栏目]','root')\">栏目</a>", -1, true, "MenuRoot");
            var data = eval("data=" + json);
            //参数: menuName,id,pid,booleanOpen,order,url,target,hrefTip,hrefStatusText,classStyle,icon,iconOpen
            $.each(data, function(i, n) {
            var classname = "<a id=\"a_" + i + "\" style=\"cursor:pointer;\" onclick=\"onClick_GetClass('" + n.cid + "','" + n.classname + "','a_" + i + "')\">" + n.classname + "</a>";
                classTree.addMenuNode(classname, n.cid, n.parentid == 0 ? -1 : n.parentid);
            });

            classTree.printTableTreeToElement("classTreeDiv");
        }	
</script>	

</head>
<body>
    <div id="continer">
        <div id="classTreeDiv">			
		</div>
		<input type="hidden" id="hidden_perclassid" value="" />
		<input type="hidden" id="hidden_classid" value="" />
		<input type="hidden" id="hidden_classname" value="" />
    </div>
    <script type="text/javascript">        
        function onClick_GetClass(classid, classname,a_id) {
            $("#hidden_classid").val(classid);
            $("#hidden_classname").val(classname);
            
            var preclass = $("#hidden_perclassid").val();
            if (preclass != "") {
                $("#" + preclass).parent().removeClass("treeCurBg");
            }
            var width = 35 + $("#" + a_id).width()+20;
            $("#" + a_id).parent().parent().parent().parent().attr("width", width);
            $("#" + a_id).parent().addClass("treeCurBg");
            $("#hidden_perclassid").val(a_id);
        }
        function getClasses() {    //获取栏目
            var classID=$("#hidden_classid").val();
            var className=$("#hidden_classname").val();
            var classObj = { "classid": classID, "classname": className };
            return classObj;
        }
    </script>
</body>
</html>
