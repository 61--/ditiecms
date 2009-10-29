<%@ Page Language="C#" %>
<script runat="server">
protected void Page_Load(object sender, EventArgs e)
{
    StringBuilder sb = new StringBuilder();
    sb.Append("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n");
    sb.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
    sb.Append("<head>\r\n");
    sb.Append("<title>小分类栏目</title>\r\n");
    sb.Append("<link href=\"css/blue_left.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n");
    sb.Append("<script type=\"text/javascript\">\r\n");
    sb.Append("function getObject(objectId) {\r\n");
    sb.Append(" if(document.getElementById && document.getElementById(objectId)) {\r\n");
    sb.Append(" return document.getElementById(objectId);\r\n");
    sb.Append(" }\r\n");
    sb.Append(" else if (document.all && document.all(objectId)) {\r\n");
    sb.Append(" return document.all(objectId);\r\n");
    sb.Append(" }\r\n");
    sb.Append(" else if (document.layers && document.layers[objectId]) {\r\n");
    sb.Append(" return document.layers[objectId];\r\n");
    sb.Append(" }\r\n");
    sb.Append(" else {\r\n");
    sb.Append(" return false;\r\n");
    sb.Append(" }\r\n");
    sb.Append("}\r\n");
    sb.Append("function showHide(objname){\r\n");
    sb.Append("    var obj = getObject(objname);\r\n");
    sb.Append("    if(obj.style.display == \"none\"){\r\n");
    sb.Append("		obj.style.display = \"block\";\r\n");
    sb.Append("	}else{\r\n");
    sb.Append("		obj.style.display = \"none\";\r\n");
    sb.Append("	}\r\n");
    sb.Append("}\r\n");
    sb.Append("<" + "/script>\r\n");
    sb.Append("</head>\r\n");
    sb.Append("<body>\r\n");
    sb.Append("<div class=\"menu\">\r\n");

    //GET提交，c为栏目ID
    int col = 0;
    col = Convert.ToInt32(Request.QueryString["c"]);
    switch (col)
    {
        case 0:
            {
                sb.Append(" <dl>\r\n");
                sb.Append("    <dt><a href=\"###\" onclick=\"showHide('items1');\" target=\"_self\">房产管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼盘信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼阁信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>单元信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>小区成员管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append(" </dl>\r\n");
                sb.Append("</div>\r\n");
                sb.Append("</body>\r\n");
                sb.Append("</html>\r\n");
                break;
            }
        case 1:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"###\" onclick=\"showHide('items1');\" target=\"_self\">房产管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href='BuildInfo.aspx' target='main'>楼宇信息管理</a></li>\r\n");
                sb.Append("                <li><a href='UnitInfo.aspx' target='main'>单元信息管理</a></li>\r\n");
                sb.Append("                <li><a href='MemberInfo.aspx' target='main'>小区人员管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                sb.Append("</body>\r\n");
                sb.Append("</html>\r\n");
                break;
            }
        case 2:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"###\" onclick=\"showHide('items1');\" target=\"_self\">房产管理2</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼盘信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼阁信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>单元信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>小区成员管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                sb.Append("</body>\r\n");
                sb.Append("</html>\r\n");
                break;
            }
        case 3:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"###\" onclick=\"showHide('items1');\" target=\"_self\">房产管理3</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼盘信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼阁信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>单元信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>小区成员管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                sb.Append("</body>\r\n");
                sb.Append("</html>\r\n");
                break;
            }
        case 4:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"###\" onclick=\"showHide('items1');\" target=\"_self\">房产管理4</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼盘信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼阁信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>单元信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>小区成员管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                sb.Append("</body>\r\n");
                sb.Append("</html>\r\n");
                break;
            }
        case 5:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"###\" onclick=\"showHide('items1');\" target=\"_self\">房产管理5</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼盘信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼阁信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>单元信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>小区成员管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                sb.Append("</body>\r\n");
                sb.Append("</html>\r\n");
                break;
            }
        case 6:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"###\" onclick=\"showHide('items1');\" target=\"_self\">房产管理6</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼盘信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼阁信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>单元信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>小区成员管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                sb.Append("</body>\r\n");
                sb.Append("</html>\r\n");
                break;
            }
        case 7:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"###\" onclick=\"showHide('items1');\" target=\"_self\">房产管理7</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼盘信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼阁信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>单元信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>小区成员管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                sb.Append("</body>\r\n");
                sb.Append("</html>\r\n");
                break;
            }
    }
    Response.Write(sb.ToString());
}
</script>