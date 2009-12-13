/*滑动条定义--GooPieChart类*/
//pieDiv :要被绑定的已被JQUERY封装的DOM对象，必须要有其ID
//property  :JSON变量，SLIDER的详细参数设
function GooPieChart(pieDiv,property){
	this.$div=pieDiv;
	this.$div.addClass("pie_bg");
	this.$content=$("<div class='pie_content' style='width:"+property.con_width+"px;height:"+property.con_height+"px'></div>");
	this.$div.append(this.$content);
	this.$tip=$("<div class='tip'></div>");
	this.$div.append(this.$tip);
	this.$content.append("<li id='total_"+this.$div.attr("id")+"' style='font-weight:bold;display:block;position:absolute;right:16px;bottom:16px;'></li>");
	this.$canvas=document.createElement("canvas");
	this.$canvas.setAttribute("width",property.canvas_width);
	this.$canvas.setAttribute("height",property.canvas_height);
	this.$div.children(".pie_content").append(this.$canvas);
	if($.browser.msie){
		this.$canvas=window.G_vmlCanvasManager.initElement(this.$canvas);
	}
	this.$canvas_left=property.canvas_left;
	this.$canvas_top=property.canvas_top;
	$(this.$canvas).css({left:this.$canvas_left+"px",top:this.$canvas_top+"px"});
	this.$ctx=this.$canvas.getContext('2d');
	this.$canvas_width=property.canvas_width;
	this.$canvas_height=property.canvas_height;
	this.$painted=false;//判断原来CANVAS中是否已经画过
	this.$core_x=0;
	this.$core_y=0;
	this.$radius=150;
	this.$items=[];//数据内容列表
	this.$note=null;//数据种类列表
	//设置/初始化饼图的标题及单位说明
	this.setTitle=function(title,units){
		if(this.$div.children(".pie_title").length==0){
			this.$div.prepend("<div class='pie_title'><span class='title'></span><span class='unit'></span></div>");
		}
		var Label=this.$div.children(".pie_title");
		if(title!=null){
			//初始化柱状图的标题JQUERY对象
			Label.children(".title").html(title);
		}
		if(units!=null){
			//初始化 柱状图的单位提示JQUERY对象
			Label.children(".unit").html("　单位:("+units+")");
		}
	};
	this.$total=0;
	//设置圆饼的外观，三个参数，为饼的中心在CANVAS中的顶距、左边距，半径
	this.setPieShow=function(core_x,core_y,radius){
		this.$core_x=core_x;
		this.$core_y=core_y;
		this.$radius=radius;
	};
	if(property.core_x&property.core_y&&property.radius)
		this.setPieShow(property.core_x,property.core_y,property.radius);
//初始化饼图的数据种类数量，以及数据类型说明框
	this.setDataKind=function(dataKind){
		this.$note=[];
		var noteDiv;
		if(this.$div.children(".pie_note").length==0){
			noteDiv=$("<div class='pie_note' style='width:"+dataKind.note_width+"px;height:"+
							   dataKind.note_height+"px;top:"+dataKind.note_top+"px;left:"+dataKind.note_left+"px'></div>");
			this.$content.append(noteDiv);
		}
		else
			noteDiv=this.$content.children(".pie_note");
		var noteHtml="";
		for(i=0;i<dataKind.items.length;++i){
			if(dataKind.sort_type=="h")
				noteHtml+="<b class='icon' style='background-color:"+dataKind.items[i].color+"'></b>"
					+"<b>:"+dataKind.items[i].label+"</b>";
			else if(dataKind.sort_type=="v")
				noteHtml+="<div><b class='icon' style='background-color:"+dataKind.items[i].color+"'></b>"
					+"<b>:"+dataKind.items[i].label+"</b></div>";
			this.$note[dataKind.items[i].id]={color:dataKind.items[i].color,label:dataKind.items[i].label};
		}
		noteDiv.html(noteHtml);
	};
	//显示提示栏
	this.showTip=function(x,y,index){
		this.$tip.html("<b>"+this.$note[this.$items[index].id].label+"</b><br/>"+this.$items[index].num+"("+this.$items[index].percent+")");
		this.$tip.css({display:"block",top:(y+10)+"px",left:(x+10)+"px"});
	};
	//隐藏提示栏
	this.hideTip=function(){
		if(this.$tip.css("display")!="none")	this.$tip.css("display","none");
	};
	//清除CANVAS上的内容数据
	this.clearCanvas=function(){
		this.$items=null;
		this.$items=[];
		this.$ctx.clearRect(0,0,this.$canvas_width,this.$canvas_height);//清空原来已画的饼图
		this.$painted=false;
		this.$content.children("#total_"+this.$div.attr("id")).html("");
		this.$total=0;
	};
	//载入具体内容，并渲染饼图传参//data为一个JSON变量数组,show决定了饼图里直接显示的是具体数值还是百分比,值只有"percent"，"num"两种
	this.loadPieData=function(data,show,totalUnit){
		if(this.$painted)	this.clearCanvas();
		this.$items=data;
		//算出总数
		for(i=0;i<data.length;++i){
			this.$total+=data[i].num;
		}
		//先画边框
		this.$ctx.lineWidth=1;
		this.$ctx.beginPath();
		this.$ctx.strokeStyle='#898A91';
		this.$ctx.arc(this.$core_x,this.$core_y,this.$radius,0,2*Math.PI,false);
		this.$ctx.closePath();
		this.$ctx.stroke();
		//再根据载入的数据，按比例渲染各个部分
		startAngle=0;
		for(i=0;i<data.length;++i){
			this.$ctx.beginPath();
			this.$ctx.moveTo(this.$core_x,this.$core_y);
			this.$ctx.fillStyle=this.$note[data[i].id].color;
			temp=data[i].num/this.$total;
			endAngle=startAngle+2*Math.PI*temp;
			middleAngle=startAngle+Math.PI*temp;//角中线的弧度
			this.$ctx.arc(this.$core_x,this.$core_y,this.$radius,startAngle,endAngle,false);
			startAngle=endAngle;
			this.$ctx.fill();
			/*保存百分比，取小数点后两位*/
			this.$items[i].percent=(Math.round(temp*10000)/100)+"%";
			this.$items[i].endAngle=endAngle;//保存截止角度
			//确定显示数值的的定位，求出显示数值标签的中心的坐标
			ro_x=0.8*this.$radius*Math.cos(middleAngle)+this.$core_x+this.$canvas_left;
			ro_y=0.8*this.$radius*Math.sin(middleAngle)+this.$core_y+this.$canvas_top;
			span=$("<span>"+data[i][show]+"</span>");
			this.$content.append(span);
			span.css({top:ro_y-6+"px",left:ro_x-0.5*span.attr("offsetWidth")+"px"});
		}
		if(totalUnit&&totalUnit.indexOf("&d")>-1)	this.$content.children("#total_"+this.$div.attr("id")).html(totalUnit.replace(/\&d/g,this.$total));
		this.$painted=true;
		//绑定鼠标事件
		this.$canvas.onmousemove=null;
		inthis=this;
		cv=getElCoordinate(this.$canvas);
		ro_x=cv.left+this.$core_x;
		ro_y=cv.top+this.$core_y;
		this.$canvas.onmousemove=function(e){
			if(!e) e=window.event;
			ev=mousePosition(e);
			dx=ev.x-ro_x;
			dy=ev.y-ro_y;
			r2=dx*dx+dy*dy;
			if(r2<inthis.$radius*inthis.$radius){
				Radian=Math.asin(dy/Math.sqrt(r2));
				if(dy>0&&dx<0)	Radian=Math.PI-Radian;
				else if(dy<=0){
					if(dx>0)	Radian=2*Math.PI+Radian;
					else	Radian=Math.PI-Radian;
				}
				for(i=0;i<inthis.$items.length;++i){
					if(inthis.$items[i].endAngle>=Radian){
						inthis.showTip(ev.x,ev.y,i); break;
					}
				}
			}
			else	inthis.hideTip();
		};
	};
	//远程载入数据
	this.loadPieDataAjax=function(url,para,type,dataType,show,totalUnit){
		inthis=this;
		$.ajax({type: type,url: url,data: para,dataType:dataType,
		success: function(result){inthis.loadPieData(result,show,totalUnit);}
		}); 
	};
}
//将此类的构造函数加入至JQUERY对象中
jQuery.extend({
	createGooPieChart: function(pieDiv,property) {
		return new GooPieChart(pieDiv,property);
  }
});