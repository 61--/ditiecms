<div id="header">
	<div id="top" class="bodywidth">
		<div id="site_nav">
			<%=GetLoginInfo() %><span class="n_b">��Ա���� |
			<a href="/user/site_add.aspx">��ַ�ύ</a> | ��������</span></div>
		<table class="site_basic">
			<tr>
				<td width="320"><a href="/">
				<img src="/images/blue/logo.gif" alt="������" width="285" height="100" /></a></td>
				<td style="text-align: left;"><span id="city"><%=cityname %>վ</span>
				<span class="changecity">
				<a href="javascript:;" onclick="$('#citylist ul').toggle();">�л�����</a></span>
				<div id="citylist"><ul><%for(int i=0;i<cityList.Rows.Count;i++){ %><li><a href="/<%=cityList.Rows[i]["ECity"] %>/index.aspx"><%=cityList.Rows[i]["City"] %></a></li><%} %></ul></div>
				</td>
				<td width="450">
				<div class="search">
					<input type="text" name="keyword" class="input" id="keyword" /><button type="button" id="btn_search">�� ��</button>
					<span class="text">���Źؼ��֣�ʳȫ���� �������� ���ݱ��� ��Ʒ���� ��ױƷ ����</span></div>
				</td>
			</tr>
		</table>
	</div>
</div>
<div id="nav">
	<ul class="nav_link bodywidth">
		<li class="hover"><a href="index.aspx">�� ҳ</a></li>
		<li><a href="site_list.aspx">��վ����</a></li>
		<li><a href="tuan_list.aspx">�Ź�����</a></li>
		<li><a href="user_list.aspx">�û�����</a></li>
		<li><a href="comment_list.aspx">���۹���</a></li>
		<li><a href="tuangou_get.aspx">�ɼ�����</a></li>
		<li><a href="system.aspx">ϵͳ����</a></li>
	</ul>
</div>