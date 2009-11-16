/*
 *@Generator -> Menu Plugins - Build 2009-5-21
 *@Copyright (c) 2009 LiHuiGang - lhgmenu.js
 *@Download http://www.codefans.net
 */

J.exend({
    menu :
	{
	    item : {}, list : [], active : false
	}
});

J.exend( J.menu, {
    init : function()
	{
	    if(J.ie){ document.execCommand('BackgroundImageCache',false,true); };
		J('doc').aevt( 'click', this.clickhdl );
		if(lhgcore.clean) lhgcore.clean.items( this, this.m_clean );
	},
	
	add : function(e,w,p,d)
	{
		var mp = this.crmeu(this.item[e],w,p,d); this.list.push(mp);
		J(e).addentex( 'click', this.rshow, mp );
		J(e).addentex( 'mouseover', this.rover, mp ); return this;
	},
	
	crmeu : function(e,w,p,d)
	{
		var mp = new J.panel(p,d), ul = J(mp._doc).crte('ul'); mp.applnk( J.path() + 'lhgmenu/lhgmenu.css' );
		J(mp._main).acls('MN_menu'); w = w || 120; J(ul).stcs( 'width', w + 'px' );
		
		for( var i = 0; i < e.length; i++ )
		{
		    var r = e[i], li = J(mp._doc).crte('li'), a = J(mp._doc).crte('a');
			
			if( r.txt == '-' )
			{
			    J(li).stcs({ height: '3px', lineHeight: '3px', fontSize: '0' });
				J(a).acls('MN_line');
			}
			else
			{
				J(li).msover(function(e)
				{
					var lies = J(this.parentNode).gtag('li'); J.menu.iover(this);
					for( var i = 0; i < lies.length; i++ )
					{
						var ite = lies[i];
						if( ite != this ){ J.menu.iout(ite); if(ite.subMN) J.menu.chide(ite.subMN); }
					}
				});
				
				if(r.ico)
				{
				    J(li).stcs({
					    backgroundImage: 'url(images/' + r.ico + ')',
						backgroundRepeat: 'no-repeat', backgroundPosition: '2% 60%'
					});
				}
				
				if(r.sub)
				{
					var smp = this.crmeu( r.sub, r.wdh, li ); li.subMN = smp;
					
					J(a).stcs({
						backgroundImage: 'url(images/arrow.gif)',
						backgroundRepeat: 'no-repeat', backgroundPosition: '93% 50%'
					});
					
					J(li).click(function(e){
					    var ev = e || window.event;
						ev.stopPropagation ? ev.stopPropagation() : (ev.cancelBubble = true);
					}).addentex( 'mouseover', this.rshow, [smp,true] );
				}
				else
				{
				    J(li).msout( function(){ J.menu.iout(this); } );
					if( typeof r.cmd != 'function' ) r.cmd = this.temp_cmd;
					
					J(li).click( (function(r){
					    return function()
						{
							for( var i = 0; i < J.menu.list.length; i++ )
								J.menu.chide(J.menu.list[i]);
							r.cmd(this); J.menu.active = false;
						}
					})(r) );
				}
			}
			
			J(a).html(r.txt).attr('src',J.gtvod()); J(li).apch(a); J(ul).apch(li);
		}
		
		if(p)
		    J(mp._win.document).aevt( 'click', this.clickhdl );
		
		if(d)
		    for( var i = 0; i < d.length; i++ )
			    J(d[i].document).aevt( 'click', this.clickhdl );

		J(mp._main).apch(ul); return mp;
	},
	
	clickhdl : function()
	{
		for( var i = 0; i < J.menu.list.length; i++ )
		{
			var r = J.menu.list[i]; J.menu.chide(r); J.menu.active = false;
		}
	},
	
	temp_cmd : function()
	{
	    alert( '您点的是：' + this.txt + '菜单项' );
	},
	
	chide : function(e)
	{
	    e.hide(this,e);
		var ite = J(e._main.firstChild).gtag('li');
		for( var i = 0; i < ite.length; i++ )
		{
		    var r = ite[i]; J.menu.iout(r);
			if(r.subMN) J.menu.chide(r.subMN);
		}
	},
	
	iover : function(e)
	{
		e.style.backgroundColor = '#737357';
		e.firstChild.style.backgroundColor = '#8f8f73';
		e.firstChild.style.color = '#fff';
	},
	
	iout : function(e)
	{
		e.style.backgroundColor = '';
		e.firstChild.style.backgroundColor = '';
		if( J(e.firstChild).html() == '-' )
		    e.firstChild.style.backgroundColor = '#b9b99d';
		e.firstChild.style.color = '#000';
	},
	
	rover : function(e,M,b)
	{
	    if(J.menu.active)
		{
		    for( var i = 0; i < J.menu.list.length; i++ )
			    J.menu.chide(J.menu.list[i]); J.menu.rshow(e,M,b);
		}
	},
	
	rshow : function(e,M,b)
	{
	    var ev = e || window.event, el = ev.srcElement || ev.target;
		
		if(b) M.show( el.offsetWidth, 0, el );
		else M.show( 0, el.offsetHeight, el );
		
		ev.stopPropagation ? ev.stopPropagation() : (ev.cancelBubble = true); J.menu.active = true;
	},
	
	m_clean : function()
	{
	    this.item = null; this.list = null; this.active = null;
	}
});