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
                sb.Append("    <dt><a href=\"javascript:;\" onclick=\"showHide('items1');\" target=\"_self\">快捷菜单</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append(" </dl>\r\n");
                sb.Append("</div>\r\n");
                break;
            }
        case 1:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"javascript:;\" onclick=\"showHide('items1');\" target=\"_self\">频道管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                break;
            }
        case 2:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"javascript:;\" onclick=\"showHide('items1');\" target=\"_self\">内容管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">文章发布</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">文章管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">评论管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                break;
            }
        case 3:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"javascript:;\" onclick=\"showHide('items1');\" target=\"_self\">生成管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                break;
            }
        case 4:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"javascript:;\" onclick=\"showHide('items1');\" target=\"_self\">采集管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                break;
            }
        case 5:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"javascript:;\" onclick=\"showHide('items1');\" target=\"_self\">用户管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                break;
            }
        case 6:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"javascript:;\" onclick=\"showHide('items1');\" target=\"_self\">插件管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("  	        </ul>\r\n");
                sb.Append("		 </dd>\r\n");
                sb.Append("	</dl>\r\n");
                sb.Append("</div>\r\n");
                break;
            }
        case 7:
            {
                sb.Append("    <dl>\r\n");
                sb.Append("        <dt><a href=\"javascript:;\" onclick=\"showHide('items1');\" target=\"_self\">系统管理</a></dt>\r\n");
                sb.Append("        <dd id=\"items1\" style=\"display:block;\">\r\n");
                sb.Append("	        <ul>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('sys/BaseSetting.aspx')\">数据字典</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('sys/AttachMentSetting.aspx')\">附件设置</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('news/class_list.aspx')\">栏目管理</a></li>\r\n");
                sb.Append("                <li><a href=\"javascript:frameRedirect('sys/AttachMentSetting.aspx')\">栏目管理</a></li>\r\n");
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