/*下拉框定义--GooCombo类*/
//dom :要被绑定的DOM对象，必须要有其ID或者NAME，且未被JQUERY对象化
//property  :JSON变量，SLIDER的详细参数设置
//目前，构造函数可接受用普通DOM容器或者直接传送SELECT控件来进行渲染
function GooCombo(dom,property){
	this.$div=null;//渲染完毕后最父框架的DIV
	this.$id=null;//this.$div中SELECT控件的ID
	this.$name=null;//this.$div中SELECT控件的NAME
	this.$width=property.width;//下拉框控件的宽度，必填项
	this.$haveIcon=property.haveIcon||false;
	this.$input=$("<input type='text' value='' "+(property.readOnly? " readonly='readonly'" : "" )+(this.$haveIcon? " style='margin-left:20px;width:"+(this.$width-39)+"px'" : "" )+"/>");//下拉框控件中始终显示的文本框INPUT
	this.$btn=$("<div class='btn_up'></div>");//下拉框右部的按钮
	this.$data=[];//下拉框控件的所有显示文字和值,二维数组
	this.$type="basic";//下拉框控件的运行模式，有basic基本,multiple可多选,filter过滤显示 三种,默认为basic
	this.$selectHeight=property.selectHeight||0;
	this.$list=$("<ul style='width:"+(this.$width-2)+"px;height:"+property.selectHeight+"px;'></ul>");//下拉框的列表JQUERY对象
	this.$lastSelect=null;//当前最近一次被选中的单元,在this.$type="multiple"时，它将不发挥其记录作用
	this.$select=null;//保存所选值的单元一般为select控件
	this.$autoLoad=false;//是否动设置为动态载入数据，既下拉动作触发时再载入数据，默认为FALSE()
	this.$alreadyLoad=false;//是否已经载入完了数据,默认为false
	//设置为动态自动获取数据(渲染后Combo中的input框被选中后载入数据)
	this.setAutoLoad=function(bool){
		this.$autoLoad=bool;
	};
	if(property.autoLoad) this.setAutoLoad(property.autoLoad);
	this.$ajaxType=null;//，其变量为一个远程链接参数的JSON数组，格式例如：{url:"website/pp.php",type:"POST",para:(与JQUERY中的AJAX方法中传参DATA一样)}默认为空
	this.setAjaxType=function(json){
		this.$ajaxType.url=json.url;
		this.$ajaxType.type=json.type;
		this.$ajaxType.para=json.para;
		this.$ajaxType.dataType=json.dataType;
	};
	if(property.ajaxType)	this.setAjaxType(property.ajaxType);

	//开始构造函数主要内容
	if(dom.tagName=="SELECT"){
		var temp="";
		for(var i=0;i<dom.length;i++){
			this.$data[i]=[(dom.options[i].value||dom.options[i].text),dom.options[i].text,""];
			temp+="<a href='#'><p "+"value='"+this.$data[i][0]+"'>"+this.$data[i][1]+"</p></a>";
		}
		this.$list.append(temp);
		this.$id=dom.id;
		this.$name=dom.name;
		if(dom.multiple) this.$type="multiple";
		this.$select=$(dom);
		this.$select.wrap("<div class='Combo' id='Combo_"+this.$id+"'></div>")
		this.$div=this.$select.parent(".Combo");
	}
	else{
		this.$div=$(dom);
		this.$div.addClass("Combo");
		this.$select=$("<select></select>");
		this.$div.append(this.$select);
	}
	//this.$div.before(this.$septum);
	this.$div.css({width:this.$width+"px"});
	this.$div.append("<div class='text' style='width:"+(this.$width-19)+"px;'></div>").append(this.$btn).append(this.$list);
	this.$div.children("div:eq(0)").append("<div class='top_border'></div>").append(this.$input);
	
	//如果DOM为一个SELECT控件，则property中的属性还可以覆盖掉原来的ID，NAME ,type="multple"的默认设置
	//ID,NAME,TYPE如果在传入SELECT时就已经通过SELECT来定义，则PROPERTY中可以不用再写
	if(property.id)		{this.$id=property.id;this.$select.attr("id",property.id);}
	if(property.name)	{this.$name=property.name;this.$select.attr("name",property.name);}
	if(property.type){
		this.$type=property.type;
		if(property.type=="multiple") {this.$select.attr("size",1);this.$select.attr("multiple",property.type);}
		else	this.$select.removeAttr("multiple");
	}
	//载入一组数据的方法
	this.loadListData=function(data){
		this.$data=[];
		if(this.$list.children("a").length>0){
			this.$list.empty();
			this.$select.empty();
		}
		temp="",temp2="";
		for(i=0;i<data.length;++i){
			this.$data[i]=[data[i][0],data[i][1],data[i][2]||""];
			if(this.$type!="filter")
				temp+="<a href='#'><p "+(this.$haveIcon? "style='text-indent:19px;background:"+this.$data[i][2]+"' " : "")+"value='"+this.$data[i][0]+"'>"+this.$data[i][1]+"</p></a>";
			temp2+="<option value='"+this.$data[i][0]+"'>"+this.$data[i][1]+"</option>";
		}
		if(this.$type!="filter")
			this.$list.append(temp);
		this.$select.append(temp2);
		this.$alreadyLoad=true;
	};
	if(property.data)	this.loadListData(property.data);
	//动态远程载入数据，AJAX请求的参数将读取this.$ajaxType中的设置
	this.loadListDataAjax=function(){
		var inthis=this;
		$.ajax({
			   type:this.$ajaxType.type,
			   url:this.$ajaxType.url,
			   dataType:this.$ajaxType.dataType,
			   data:this.$ajaxType.para,
		success:function(data){
			inthis.loadListData(data);
		}});
		
	};

	//绑定当INPUT框被选中时的事件
	this.$input.bind("focus",{inthis:this},//如果this.$autoLoad或!this.$alreadyLoad有一个为FALSE，则ajaxType将无效，可不传
	function(e){
		if ( e && e.preventDefault )	e.preventDefault();//阻止默认浏览器动作(W3C)
		else	window.event.returnValue = false;//IE中阻止函数器默认动作的方式
		var inthis=e.data.inthis;
		if(!inthis.$alreadyLoad&&inthis.$autoLoad){
			if(inthis.$ajaxType){//如果是远程AJAX获取数据
				inthis.loadListDataAjax();
			}
			else if(inthis.$data&&inthis.$data[0]){//如果是本地已经定义好的一个符合格式的JSON数组
				inthis.loadListData(inthis.$data);
			}
		}
		var list=inthis.$list;
		var height=inthis.$selectHeight;
		var width=inthis.$width;
		list.css("display","block");
		$(document).bind("mouseup",function(e){
			var locate=getElCoordinate(list.get(0));
			var ev=mousePosition(e);
			if(locate.left+width<ev.x||locate.left>ev.x||locate.top-22>ev.y||locate.top+height+2<ev.y){
				list.css("display","none");
			}
			this.onmouseup=null;
			return false;
		});
		return false;
	});
	//绑定当INPUT框中的内容被改变时的事件
	if(!this.$readOnly){
		if(this.$type=="filter"){//当type=="filter"时
			this.$input.bind("change",{inthis:this},function(e){
				var inthis=e.data.inthis;
				var text=""+this.value;
				var data=inthis.$data;
				var temp="";

				if(inthis.$ajaxType){//如果ajaxType属性有设置，则filter模式下，下拉框控件将在每次change时，动态从获取数据
					inthis.$ajaxType.para["search"]=text;//后台需要对REQUEST传入的search变量有一个向前模糊匹配的查询功能
					inthis.loadListDataAjax();
				}
				else{
					for(var i=0;i<data.length;++i){
						if(data[i][1].indexOf(text)==0)
							temp+="<a href='#'><p "+(inthis.$haveIcon? "style='text-indent:19px;background:"+data[i][2]+"' " : "")+"value='"+data[i][0]+"'>"+data[i][1]+"</p></a>";
					}
					inthis.$list.empty();
					inthis.$list.append(temp);
				}
			});
		}
		else{
			this.$input.bind("change",{inthis:this},function(e){
				var text=this.value;
				var inthis=e.data.inthis;
				var data=e.data.inthis.$data;
				for(var i=0;i<data.length;++i){
					if(data[i][1]==text){
						if(inthis.$lastSelect)
							inthis.$lastSelect.removeClass("active");
						inthis.$lastSelect=inthis.$list.children("a:eq("+i+")").addClass("active");
						now=inthis.$list.children("a:eq("+i+")").children("p");
						inthis.$select.val(data[i][0]);
						if(inthis.$haveIcon){
							$(this).parent(".text").css({
							background:now.css("background"),
							"background-image":"url(codebase/img/combo_icon.gif)",
							"background-position":now.css("background-position"),
							"background-repeat":now.css("background-repeat")	
							});
						}
						break;
					}
				}
			});
		}
		var once=null;
		this.$input.bind("keyup",{input:this.$input,list:this.$list},function(e){
			if(!e)	e=window.event;
			if(e.keyCode==13)
				e.data.list.css("display","none");
			else if(e.keyCode==40){
				var temp=e.data.list.children("a:eq(0)");
				temp.focus();
				temp.toggleClass("focus");
			}
			else{
				once=null;
				once=setTimeout(function(){e.data.input.change();},1000);
			}
		});
	}
	//绑定下拉按钮的事件
	this.$btn.bind("mousedown",function(){
		inthis=$(this);
		inthis.removeClass("btn_up");
		inthis.addClass("btn_down");
	});
	this.$btn.bind("mouseup",{input:this.$input},function(e){
		inthis=$(this);
		inthis.removeClass("btn_down");
		inthis.addClass("btn_up");
		e.data.input.focus();
	});
	//选中下拉框中一个指定索引的值（如果是multiple模式，且这个值原来已经被选定，则运行此函数后将会取消该选定）
	this.selectValue=function(index){
		if(index>0&&index<this.$data.length){
			var p=this.$list.children("a:eq("+index+")");
			if(this.$lastSelect)	this.$lastSelect.removeClass("active");
			this.$lastSelect=p;
			p.click();
		}
	};
	//绑定下拉列表单元被点击时的事件
	this.$list.bind("click",{inthis:this},function(e){
		if ( e && e.preventDefault )	e.preventDefault();//阻止默认浏览器动作(W3C)
		else	window.event.returnValue = false;//IE中阻止函数器默认动作的方式
		if(!e) e=window.event;
		var clicked=$(e.target);
		var inthis=e.data.inthis;
		if(clicked.attr("tagName")=="A")	clicked=clicked.children("p");
		else if(clicked.attr("tagName")=="UL"){
			this.style.display="none";
			return;
		}				
		if(inthis.$haveIcon){
			inthis.$input.parent(".text").css({
			background:clicked.css("background"),
			"background-image":"url(codebase/img/combo_icon.gif)",
			"background-position":clicked.css("background-position"),
			"background-repeat":clicked.css("background-repeat")	
			});
		}
		if(inthis.$type!="multiple"){
			if(inthis.$lastSelect)	inthis.$lastSelect.removeClass("active");
			inthis.$lastSelect=clicked.parent("a").addClass("active");
			this.style.display="none";
			inthis.$select.val(clicked.attr("value"));
			inthis.$input.val(clicked.text());
		}
		else{
			clicked.parent("a").toggleClass("active");
			var optionList=inthis.$select.get(0).options;
			for(var i=0;i<optionList.length;++i){
				if(optionList[i].value==clicked.attr("value")){
					optionList[i].selected=!optionList[i].selected;
					break;
				}
			}
			inthis.$input.val(clicked.text()+" , ……");
		}
		inthis.$select.change();
		//alert(inthis.$select.val());
		return false;
	});
	//绑定当用户用鼠标上/下滑过选择列表内容时的事件
	this.$list.bind("mouseover",{list:this.$list},function(e){
		if(!e) e=window.event;
		var clicked=$(e.target);
		if(clicked.attr("tagName")=="P")	clicked=clicked.parent("a");
		else if(clicked.attr("tagName")=="UL"){
			return;
		}
		clicked.focus();
		clicked.addClass("focus");
	});
	this.$list.bind("mouseout",{list:this.$list},function(e){
		if(!e) e=window.event;
		var clicked=$(e.target);
		if(clicked.attr("tagName")=="P")	clicked=clicked.parent("a");
		else if(clicked.attr("tagName")=="UL")	return;
		clicked.removeClass("focus");
	});
	//绑定当用户用上/下方向键选择列表内容时的事件
	this.$list.bind("keydown",{inthis:this},function(e){
		if(!e) e=window.event;
		var inthis=e.data.inthis;
		if(e.keyCode==13){//回车
			if ( e && e.preventDefault )	e.preventDefault();//阻止默认浏览器动作(W3C)
			else	window.event.returnValue = false;//IE中阻止函数器默认动作的方式
			var clicked=$(e.target);
			if(clicked.attr("tagName")=="P")	clicked=clicked.parent("a");
			else if(clicked.attr("tagName")=="UL")	return;
			clicked.focus();
			clicked.click();
			return false;
		}
		else if(e.keyCode==40){
			var clicked=$(e.target);
			if(clicked.attr("tagName")=="P")	clicked=clicked.parent("a");
			else if(clicked.attr("tagName")=="UL")	return;
			var now=$(e.target);
			var next=$(e.target).next("a:eq(0)");
			if(next.length>0){
				now.removeClass("focus");
				next.addClass("focus");
				next.focus();
			}
		}
		else if(e.keyCode==38){
			var clicked=$(e.target);
			if(clicked.attr("tagName")=="P")	clicked=clicked.parent("a");
			else if(clicked.attr("tagName")=="UL")	return;
			var now=$(e.target);
			var prev=$(e.target).prev("a");
			if(prev.length>0){
				now.removeClass("focus");
				prev.addClass("focus");
				prev.focus();
			}
		}
	});
	//返回下拉框的被选值//如果是多选，则会返回一串值构成的字符串，以逗号隔开
	//此下拉框也可放在一般的FORM之中，并像普通的SELECT下拉菜单控件一样操作，当FORM提交时，后台可request获取一个被选取值的数组
	this.getValue=function(){
		return this.$select.val();
	};

	//绑定当控件中隐藏的SELECT的值变化以后,触发的方法,通过对其设置，可达到drop-on-drop的多个下拉框相互联动功能,参数Fn为要触发执行的函数
	this.bindValueChange=function(Fn){
		this.$select.bind("change",Fn);
	};
	//删除一个选择项,index为定位参数，从0开始（即第一行的选择项）
	this.delItem=function(index){
		if(index>-1&&index<this.$data.length){
			this.$data.splice(index,1);
			this.$select.get(0).options.remove(index);
			this.$list.children("a:eq("+index+")").remove();
		}
	};
	//增加一个选择项，项,index为定位参数，从0开始（即第一行的选择项）
	this.addItem=function(index,Item){
		if(index=this.$data.length){//如果是加在最末尾
			this.$data[index]=Item;
			this.$list.append("<a href='#'><p "+(this.$haveIcon? "style='text-indent:19px;background:"+Item[2]+"' " : "")+"value='"+Item[0]+"'>"+Item[1]+"</p></a>");
		}
		else{
			this.$data.splice(index,0,Item);
			this.$list.children("a:eq("+index+")").before("<a href='#'><p "+(this.$haveIcon? "style='text-indent:19px;background:"+Item[2]+"' " : "")+"value='"+Item[0]+"'>"+Item[1]+"</p></a>");
		}
		this.$select.get(0).options.add(new Option(Item[1], Item[0]));
	};
	//清除所有选项
	this.clearItems=function(){
		this.$data=null;
		this.$data=[];
		this.$list.empty();
		this.$select.get(0).options.length=0;
		this.$select.empty();
		this.$alreadyLoad=false;
	};
}

//将此类的构造函数加入至JQUERY对象中
jQuery.extend({
	createGooCombo: function(dom,property) {
		return new GooCombo(dom,property);
  }
}); 