<%@ Page Language="C#" %>
<script runat="server">
protected void Page_Load(object sender, EventArgs e)
{
    StringBuilder sb = new StringBuilder();
    sb.Append("<div class=\"menu\">\r\n");

    //GET提交，c为栏目ID
    int col = 0;
    col = Convert.ToInt32(Request.QueryString["cid"]);
    switch (col)
    {
        case 0:
            {
                sb.Append(" <dl>\r\n");
                sb.Append("    <dt><a href=\"###\" onclick=\"showHide('items1');\" target=\"_self\">房产管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href='http://www.zving.com/demo/Site/CatalogDialog.jsp?Type=1&ParentID=0' target='main'>楼盘信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>楼阁信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>单元信息管理</a></li>\r\n");
                sb.Append("                <li><a href='#' target='main'>小区成员管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append(" </dl>\r\n");
                sb.Append("</div>\r\n");
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
                break;
            }
    }
    Response.Write(sb.ToString());
}
</script>