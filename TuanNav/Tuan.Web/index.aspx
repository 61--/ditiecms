<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Tuan.Web.index" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>团来了 - <%=cityname %>站——您的团购生活导航专家！</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta content="Panxing Lin E-mail:support@tuanlet.com" name="Author" />
    <meta content="tuanlet.com" name="Copyright" />
    <meta content="<%=cityname %>团购网,<%=cityname %>团购导航网,<%=cityname %>团购导航大全,团购网站,团购网大全,团购网站导航,团购网,团购大全,团购导航,团购,网络团购网站" name="keywords"/>
    <meta content="团来了(tuanlet.com),打造国内最好最大的团购导航大全,荟萃全国各大中小城市团购网站，让用户在繁杂的团购市场看清商家信用，放心团购，享受团购生活。" name="description"/>
    <link type="text/css" rel="stylesheet" href="/css/gobal.css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
    <script src="/js/jquery.plugin.js" type="text/javascript"></script>
    <script src="/js/base.js" type="text/javascript"></script>
</head>
<body>
<!--#include file="header.aspx"-->
<div id="content" class="bodywidth">
    <div id="recommend">
        <%--<div class="main">
        <table width="100%" height="100%" cellspacing="6">
            <tr>
                <td colspan="2" height="30"><h3><a href="/">【美团客】</a><a href="/">冬装新款甜美女童棉衣 原价158元现价79元包邮</a></h3></td>
            </tr>
            <tr>
                <td width="240">
                    <dl class="meta">
                        <dt class="price">原 价</dt>
                        <dt class="rebate">折 扣</dt>
                        <dt class="save">节 省</dt>
                        <dd class="price"><code>￥</code>65.00</dd>
                        <dd class="rebate">4.4折</dd>
                        <dd class="save"><code>￥</code>36.00</dd>
                    </dl>
                </td>
                <td rowspan="4" width="260" height="204" align="center"><img src="http://img.taobaocdn.com/bao/uploaded/i4/T1FKFPXaXmXXb1upjX.jpg_670x670.jpg" height="198" width="240" /></td>
            </tr>
            <tr>
                <td class="nums"><p>共有 <strong>957</strong> 人购买</p>
                    <p>评论：0 观点：0</p>
                </td>
            </tr>
            <tr>
                <td class="timer">
                    <p>剩余时间: </p>
                    <div>
                        <p class="hour">1</p>
                        <span class="label">小时</span>
                        <p class="min">10</p>
                        <span class="label">分</span>
                        <p class="sec">4</p>
                        <p class="dsec">.4</p>
                        <span class="label">秒</span>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="buy">
                    <p><code>￥</code>29.00</p>
                </td>
            </tr>
        </table>
        </div>
        <div class="list">
        	<dl><dt><img src="http://img.taobaocdn.com/bao/uploaded/i4/T1FKFPXaXmXXb1upjX.jpg_670x670.jpg" width="73" height="73" /></dt>
        		<dd class="tprice">现 价:<span><code>￥</code>629.00</span></dd>
        		<dd class="price">原 价:<span><code>￥</code>5065.00</span></dd>
        		<dd class="info">手剥奶油小白杏</dd>
        	</dl>
        	<dl><dt><img src="http://img.taobaocdn.com/bao/uploaded/i4/T1FKFPXaXmXXb1upjX.jpg_670x670.jpg" width="73" height="73" /></dt>
        		<dd class="tprice">现 价:<span><code>￥</code>629.00</span></dd>
        		<dd class="price">原 价:<span><code>￥</code>5065.00</span></dd>
        		<dd class="info">手剥奶油小白杏</dd>
        	</dl>
			<dl class="hover" style="border-bottom:0"><dt><img src="http://img.taobaocdn.com/bao/uploaded/i4/T1FKFPXaXmXXb1upjX.jpg_670x670.jpg" width="73" height="73" /></dt>
        		<dd class="tprice">现 价:<span><code>￥</code>629.00</span></dd>
        		<dd class="price">原 价:<span><code>￥</code>5065.00</span></dd>
        		<dd class="info">手剥奶油小白杏</dd>
        	</dl>
        </div>--%>
        <%=recommend %>
    </div>
    <div id="tools"><div id="share"><div id="ckepop"><a href="http://www.jiathis.com/share/?uid=97610" class="jiathis jtico jtico_jiathis" target="_blank">这么多的优惠信息，怎敢独享？</a><div class="links"><a title="分享到淘江湖" class="jiathis_button_taobao"></a><a title="分享到新浪微博" class="jiathis_button_tsina"></a><a title="分享到QQ空间" class="jiathis_button_qzone"></a><a title="分享到QQ收藏" class="jiathis_button_qq"></a><a title="分享到开心网" class="jiathis_button_kaixin001"></a><a title="分享到人人网" class="jiathis_button_renren"></a><a title="分享到豆瓣" class="jiathis_button_douban"></a><a title="分享到百度搜藏" class="jiathis_button_baidu"></a><a title="分享到邮件" class="jiathis_button_email"></a></div></div><div style="clear:left"></div><div id="scroll_ad"><ul><li><a target="_blank" href="">团来了（TuanLet）今日上线了！希望大家多多支持。</a></li><li><a target="_blank" href="">团来了API接口推出，请各团购网做好接口我们将自动收录。</a></li></ul></div></div>
		<div id="take"><dl><dt></dt><dd class="form"><input type="text" id="mail_take" style="vertical-align:middle;" value="本功能开通中,敬请期待！" /><button style="vertical-align:middle;">邮件订阅</button></dd><dd>*此服务完全免费并随时可以取消。<br />*我们不会泄漏您的帐户信息。</dd></dl></div>
    </div>
    <div id="banner"></div>
    <div id="tuan"><div id="tuan_content"><div class="tuan_list"><h2>最新团购</h2><div class="title new"></div><div class="select"><dl><dt>价 &nbsp; 格:</dt><dd class="cur"><a href="list.aspx?lp=0&hp=0">全部</a></dd><dd><a href="list.aspx?lp=0&hp=50">0-50元</a></dd><dd><a href="list.aspx?lp=50&hp=100">50-100元</a></dd><dd><a href="list.aspx?lp=100&hp=150">100-150元</a></dd><dd><a href="list.aspx?lp=150&hp=200">150-200元</a></dd><dd><a href="list.aspx?lp=200&hp=0">200元以上</a></dd></dl><dl><dt>排 &nbsp; 序:</dt><dd class="cur"><a href="list.aspx?order=default&mode=desc">默认排序</a></dd><dd><a href="list.aspx?order=date&mode=desc">时间排序</a></dd><dd><a href="list.aspx?order=price&mode=desc">价格排序</a></dd><dd><a href="list.aspx?order=hot&mode=desc">人气排序</a></dd><dd><a href="list.aspx?order=rebate&mode=desc">折扣排序</a></dd></dl></div><div class="category"><ul><li class="cur"><a href="list.aspx?cate=0">所有分类</a></li><li><a href="list.aspx?cate=1">美食天地</a></li><li><a href="list.aspx?cate=2">休闲生活</a></li><li><a href="list.aspx?cate=3">美容保健</a></li><li><a href="list.aspx?cate=4">精品购物</a></li><li><a href="list.aspx?cate=5">其他团购</a></li><li><a href="list.aspx?cate=6">自定义</a></li></ul></div>
    	<div class="list_3col" id="new_tuan"><%=newTuan %></div></div></div>
    	<div id="tuan_bar">
    	
    	</div>
    	<div id="tuan_nav">
    	
    	</div>
    </div>
</div>
<!--#include file="footer.aspx"-->
</body>
</html>