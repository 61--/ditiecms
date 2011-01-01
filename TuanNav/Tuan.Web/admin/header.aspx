<div id="header">
	<div id="top" class="bodywidth">
		<div id="site_nav">
			<%=GetLoginInfo() %><span class="n_b">会员中心 |
			<a href="/user/site_add.aspx">网址提交</a> | 帮助中心</span></div>
		<table class="site_basic">
			<tr>
				<td width="320"><a href="/">
				<img src="/images/blue/logo.gif" alt="团来了" width="285" height="100" /></a></td>
				<td style="text-align: left;"><span id="city"><%=cityname %>站</span>
				<span class="changecity">
				<a href="javascript:;" onclick="$('#citylist ul').toggle();">切换城市</a></span>
				<div id="citylist"><ul><%for(int i=0;i<cityList.Rows.Count;i++){ %><li><a href="/<%=cityList.Rows[i]["ECity"] %>/index.aspx"><%=cityList.Rows[i]["City"] %></a></li><%} %></ul></div>
				</td>
				<td width="450">
				<div class="search">
					<input type="text" name="keyword" class="input" id="keyword" /><button type="button" id="btn_search">搜 索</button>
					<span class="text">热门关键字：食全酒美 休闲娱乐 美容保健 精品购物 化妆品 其他</span></div>
				</td>
			</tr>
		</table>
	</div>
</div>
<div id="nav">
	<ul class="nav_link bodywidth">
		<li class="hover"><a href="index.aspx">首 页</a></li>
		<li><a href="site_list.aspx">网站管理</a></li>
		<li><a href="tuan_list.aspx">团购管理</a></li>
		<li><a href="user_list.aspx">用户管理</a></li>
		<li><a href="comment_list.aspx">评论管理</a></li>
		<li><a href="tuangou_get.aspx">采集管理</a></li>
		<li><a href="system.aspx">系统管理</a></li>
	</ul>
</div>