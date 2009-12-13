/*右键菜单定义--RightMenu类*/
//contextDiv:JQUERY对象，要渲染的DOM
//menuWidth 数字，菜单的宽度;
//menuContent,JSON数据，格式在DEMO页面中
//bindingFun要绑定的函数方法组合,JSON数据
//行高一律定为22PX+2px的边框
//分隔符的高一律定为5px
//构造完后，还需要行另外的初始化才能用
function RightMenu(contextDiv,menuWidth,menuContent,bindingFun){
	this.$contextDiv=contextDiv;
	this.$menuWidth=menuWidth;
	this.$numList=0;
	this.$numHr=0;
	this.$contextDiv.toggleClass("contextMenu");
	this.$contextDiv.css({width: menuWidth+"px"});
	this.$target=null;
	this.$funBind=bindingFun.$bindings;
	var innerList="<div class='menuLists' style='width:"+(menuWidth-8)+"px'>";
	for(i=0;i<menuContent.length;++i){
		if(menuContent[i].id!=null){
			innerList+="<a class='";
			this.$numList+=1;
			if(menuContent[i].disable)
				innerList+="disable' ";
			else
				innerList+="item' href='javascript:' ";
			innerList+="><p id='"+menuContent[i].id;
			if(menuContent[i].cls!=null)
				innerList+="' class='"+menuContent[i].cls;
			innerList+="'>";
			innerList+=menuContent[i].text+"</p></a>";
		}
		else if(menuContent[i].hr==''){
			innerList+="<p class='hr'></p>";
			this.$numHr+=1;
		}
	}
	this.$listHeight=24*this.$numList+5*this.$numHr+4;
	innerList+="<div class='stroke' style='height:"+this.$listHeight+"px'></div></div>";
	this.$menuDiv=$(innerList);
	this.$contextDiv.append(this.$menuDiv);
	this.$contextDiv.append("<div class='rightShadow' style='height:"+(this.$listHeight-1)+"px'></div><div class='bottomShadow' style='width:"+(menuWidth-4)+"px'></div>");
	var temp=this.$contextDiv;
	$(document).bind("click",function(e){
		temp.hide();
	});
	/*以上为构造方法，下面开始类内其它方法的定义*/
	
	this.show=function(e){
		e = e || window.documnt.event;
		this.$contextDiv.css({left:e.pageX+"px",top:e.pageY+"px"});
		this.$contextDiv.show(25);
	};

	this.hide=function(){
		temp.hide();
	};
	//加入一个菜单项()方法可选
	this.appendItem=function(newItem,seq,order,fun){
		innerList="";
		if(newItem.id!=null){
			innerList+="<a class='";
			this.$numList+=1;
			if(newItem.disable)
				innerList+="disable' ";
			else
				innerList+="item' href='javascript:' ";
			innerList+="><p id='"+newItem.id;
			if(newItem.cls!=null)
				innerList+="' class='"+newItem.cls;
			innerList+="'>";
			innerList+=newItem.text+"</p></a>";
			this.$listHeight+=24;
			this.$contextDiv.children(".rightShadow").css({height:(this.$listHeight-1)+'px'});
		}
		else if(newItem.hr==''){
			innerList+="<p class='hr'></p>";
			this.$numHr+=1;
			this.$listHeight+=5;
			this.$contextDiv.children(".rightShadow").css({height:(this.$listHeight-1)+'px'});
		}
		if(order=="before")
			this.$menuDiv.children("a:eq("+(seq-1)+")").before(innerList);
		else if(order=="first")
			this.$menuDiv.append(innerList);
		else
			this.$menuDiv.children("a:eq("+(seq-1)+")").after(innerList);
		this.$funBind[newItem.id]=fun;
	};
	//删除一个菜单项
	this.removeItem=function(seq){
		var id=this.$menuDiv.children("a:eq("+(seq-1)+")").children("p").attr("id");
		if(id!=null){
			this.$menuDiv.children("a:eq("+(seq-1)+")").remove();
			this.$funBind[id]=null;
			this.$listHeight-=24;
			this.$contextDiv.children(".rightShadow").css({height:(this.$listHeight-1)+'px'});
		}
	};
	//删除一上分隔符
	this.removeHr=function(seq){
		temp=this.$menuDiv.children("p:eq("+(seq-1)+")");
		if(temp!=null){
			temp.remove();
			this.$listHeight-=5;
			this.$contextDiv.children(".rightShadow").css({height:(this.$listHeight-1)+'px'});
		}
	};
	//使一个菜单项能使用/作废不能使用但仍显示,方法不删除
	this.ableItem=function(seq,able){
		var temp=this.$menuDiv.children("a:eq("+(seq-1)+")");
		temp.removeClass();
		if(able)
			temp.addClass("item");
		else
			temp.addClass("disable");
	};
	//在目标的JQUERY对象上取消绑定右键
	this.unbind=function(jq){
		jq.unbind();
	};
}



//绑定一个父框架以操作里面的多项子元素（只需绑定一次），用来代替对每个子元素都绑定一次的方法，
//(参数jq为一个JQUERY对象)
//attrName,attrValue : 是用来作判断右键菜单是否弹出的条件，条件来自于绑定对象的属性中.
RightMenu.prototype.bindParent=function(jq,attrName,attrValue){
	var inthis=this;
	jq.bind('contextmenu',function(e){
		var $clicked = $(e.target);
		if($clicked.attr("id")==$(this).attr("id")) return true;
		else if(attrName&&$clicked.attr(attrName)!=attrValue)return true;
		else{
			inthis.$target=$clicked;
			inthis.show(e);
			return false;
		}
	});
}

//绑定右键菜单栏中,当一个项目被点击时触发的事件
RightMenu.prototype.bindClick=function(){
	var inthis=this;
	this.$menuDiv.bind('click',function(e){
		var $clicked = $(e.target);
		var parent=$clicked.parent();
		//document.write(parent.attr("class")||parent.attr("className"));
		if(parent.attr("class")=='item'||parent.attr("className")=='item'){
			inthis.hide();
			if(inthis.$funBind[$clicked.attr("id")])
				inthis.$funBind[$clicked.attr("id")](inthis.$target);
		}
	});
}
//单单只绑定一个DOM元素(参数jq为一个JQUERY对象)
RightMenu.prototype.bingObject=function(jq){
	var inthis=this;
	jq.bind('contextmenu',function(e){
		inthis.$target=$(this);
		inthis.show(e);
		return false;
	});
}

//将此类的构造函数加入至JQUERY对象中
jQuery.extend({
	createContextMenu: function(contextDiv,menuWidth,menuContent,bindingFun) {
		var obj = new RightMenu(contextDiv,menuWidth,menuContent,bindingFun);
		obj.bindClick();
		return obj;
  }
}); 