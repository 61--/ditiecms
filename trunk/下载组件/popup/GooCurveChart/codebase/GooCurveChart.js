//定义一个曲线图类：
function GooCurveChart(bgDiv,property){
//初始化柱状图的对象
	this.$bgDiv=bgDiv;													//最父框架的DIV
	this.$bgDiv.addClass("curve_bg");
	this.$bgDiv.append("<div class='left_grade'></div><div class='coor_bg'><div class='y_coor'></div><div class='x_coor'></div></div><div class='bottom_grade'></div><div class='point_bg'></div>");
	this.$coor_bg=this.$bgDiv.children(".coor_bg");
	this.$maxValue=property.maxValue;//Y轴最大值
	this.$minValue=property.minValue;//Y轴最小值
	this.$stepValue=property.stepValue;//Y轴每两个刻度间距所表示的单元步进值
	this.$valueP=property.valueP;//表示Y轴每个单元步进值所用的像素高度
	this.$maxNorm=property.maxNorm;//X轴最大值
	this.$minNorm=property.minNorm;//X轴最小值
	this.$stepNorm=property.stepNorm;////X轴每两个刻度间距所表示的单元步进值
	this.$normP=property.normP;//表示X轴每个单元步进值所用的像素宽度
	this.$normFormat=property.normFormat||"&d";//X轴上坐标值的显示单位格式，其中必须包含&d占位符，用来被X轴的真实值替换，默认为"&d"
	this.$point_radius=property.point_radius;//圈点的半径，单位像素
	this.$curve_border=property.curve_border||3;//曲线的粗细，单位像素
	this.$coorWidth=0;this.$coorHeight=0;//坐标系的宽和高，初始都为0
	this.$kindNum=0;//数据总类的数量
	this.$note=[];//保存数据总类描述详细的JSON数组:单元内容有文字说明，颜色，以ID为索引
	this.$data=[];//数据本身
	this.$tipX=property.tipX||"X";//浮动提示框中的X轴显示文字说明
	this.$tipY=property.tipY||"Y";//浮动提示框中的Y轴显示文字说明
	//初始化坐标系
	this.initCoorAndGrage=function(){
		yCoor=this.$coor_bg.children(".y_coor");//坐标图的DIV对象
		xCoor=this.$coor_bg.children(".x_coor");//坐标图的DIV对象
		leftGrade=this.$bgDiv.children(".left_grade");
		bottomGrade=this.$bgDiv.children(".bottom_grade");
		var yNum=(this.$maxValue-this.$minValue)/this.$stepValue;
		var xNum=(this.$maxNorm-this.$minNorm)/this.$stepNorm;
		this.$coorHeight=yNum*this.$valueP;
		this.$coorWidth=xNum*this.$normP;
		this.$coor_bg.css({width:this.$coorWidth+"px",height:this.$coorHeight+"px"});
		yCoor.css({width:this.$coorWidth+"px"});
		xCoor.css({width:this.$coorWidth+"px"});
		//先画水平线和Y轴
		strGrade="<b style='padding-top:0px'>"+this.$maxValue+"</b>";
		strCoor="<span style='height:"+(this.$valueP-1)+"px'></span>";
		for(i=yNum-1;i>0;--i){
			strGrade+="<b style='padding-top:"+(this.$valueP-12)+"px'>"+(i*this.$stepValue)+"</b>";
			strCoor+="<span style='height:"+(this.$valueP-1)+"px'></span>";
		}
		strGrade+="<b style='padding-top:"+(this.$valueP-12)+"px'>"+(this.$minValue)+"</b>";
		leftGrade.append(strGrade);
		yCoor.append(strCoor);
		//再画垂直线和X轴
		bottomGrade.css({width:(this.$normP*(xNum+1))+"px","padding-left":(60-0.5*this.$normP)+"px"});
		strGrade="";
		strCoor="";
		for(i=1;i<=xNum;++i){
			strGrade+="<b style='width:"+this.$normP+"px'>"+(this.$normFormat.replace(/\&d/g,i*this.$stepNorm))+"</b>";
			strCoor+="<span style='width:"+(this.$normP-1)+"px'></span>";
		}
		strGrade+="<b style='width:"+this.$normP+"px'>"+(this.$normFormat.replace(/\&d/g,this.$maxNorm))+"</b>";
		bottomGrade.append(strGrade);
		xCoor.append(strCoor);
	};
	this.initCoorAndGrage();
	
	//用JS动态初始化CANVAS
	this.$canvas=document.createElement("canvas");
	this.$canvas.setAttribute("width",this.$coorWidth);
	this.$canvas.setAttribute("height",this.$coorHeight);
	this.$coor_bg.append(this.$canvas);
	if($.browser.msie){
		this.$canvas=window.G_vmlCanvasManager.initElement(this.$canvas);
	}
	this.$coor_bg.append(this.$canvas);
	$(this.$canvas).css({position:"relative",top:"0px",left:"0px"});
	this.$point_bg=$("<div style='position:absolute;top:0px;left:0px;width:100%;height:100%;background:#ffffff;filter:alpha(opacity=0);opacity: 0;'></div>");
	this.$coor_bg.append(this.$point_bg);
	
	//设置/初始化曲线图的标题及单位说明
	this.setTitle=function(title,units){
		if(this.$bgDiv.children(".curve_title").length==0){
			this.$bgDiv.prepend("<div class='curve_title'><span class='title'></span><span class='unit'></span></div>");
		}
		var Label=this.$bgDiv.children(".curve_title");
		if(title!=null){
			//初始化曲线图的标题JQUERY对象
			Label.children(".title").html(title);
		}
		if(units!=null){
			//初始曲线图的单位提示JQUERY对象
			Label.children(".unit").html("　单位:("+units+")");
		}
	}
	
//初始化曲线图的数据种类数量
	this.setDataKind=function(dataKind,noteWide,divWidth,type){
		//设置提示框的宽度
		this.$notice=dataKind;
		if(this.$bgDiv.children(".curve_note").length==0){
			this.$bgDiv.append("<div class='curve_note'></div>");
		}
		noticeDiv=this.$bgDiv.children(".curve_note").css({width:noteWide+"px"});
		var noticeHtml="";
		for(key=0;key<dataKind.length;key++){
			noticeHtml+="<div style='width:"+divWidth+"px'><span class='icon' style='background-color:"+dataKind[key].color+"'></span>"
					+"<span>:"+dataKind[key].label+"</span></div>";
			this.$note[dataKind[key].id]={color:dataKind[key].color,label:dataKind[key].label};
		}
		noticeDiv.append(noticeHtml);
		if(type=="right") noticeDiv.css({"margin-top":"7px"});
		else if(type=="bottom") noticeDiv.css("clear","both");
		this.$kindNum=dataKind.length;//数据种类的数量
		this.$tip=$("<div class='tip'></div>");
		this.$bgDiv.append(this.$tip);
	};
	//也可以通过远程读取JS文件来获得dataKind然后再初始化
	this.setDataKindFromJs=function(url,noteWide,divWidth,type){
		tempFn=this.setDataKind;
		$.getScript(url,function(){
			tempFn(dataKind,noteWide,divWidth,type);
		}); 
	};
	//载入一条具体数据（必须在setDataKind之后）
	this.loadSimpleData=function(simple){
		this.$data[simple.id]=simple.items;
		ctx=this.$canvas.getContext('2d');
		ctx.lineWidth=this.$curve_border;
		ctx.strokeStyle=this.$note[simple.id].color;
		ctx.fillStyle=this.$note[simple.id].color;
		label=this.$note[simple.id].label;
		color=this.$note[simple.id].color;
		tipX=this.$tipX;
		tipY=this.$tipY;
		//画笔移至起点
		px=(simple.items[0][0]-this.$minNorm)*(this.$normP/this.$stepNorm);
		py=this.$coorHeight-(simple.items[0][1]-this.$minValue)*(this.$valueP/this.$stepValue);
		for(j=0;j<simple.items.length;++j){
			ctx.beginPath();
			ctx.moveTo(px,py);
			px=(simple.items[j][0]-this.$minNorm)*(this.$normP/this.$stepNorm);
			py=this.$coorHeight-(simple.items[j][1]-this.$minValue)*(this.$valueP/this.$stepValue);
			if(j>0){
				ctx.lineTo(px,py);
				ctx.closePath();
				ctx.stroke();
			}
			if(simple.items[j][2]){
				ctx.beginPath();
				ctx.arc(px,py,this.$point_radius,0,2*Math.PI,false);
				ctx.fill();
				tempJQ=$("<div class='point' style='width:"+(this.$point_radius*2)+"px;height:"+(this.$point_radius*2)+"px;left:"+(px-this.$point_radius)+"px;top:"+(py-this.$point_radius)+"px'></div>");
				this.$point_bg.append(tempJQ);
				tempJQ.bind("mousemove",{tip:this.$tip,label:label,color:color,x:simple.items[j][0],y:simple.items[j][1]},function(e){
					mouse=mousePosition(e);
					if(e.data.tip.css("display")=="none"){
						e.data.tip.html("<b>"+e.data.label+"</b><br/>"+tipX+":"+e.data.x+"<br/>"+tipY+":"+e.data.y);
						e.data.tip.css({display:"block","border-color":e.data.color});
					}
					e.data.tip.css({left:mouse.x+"px",top:mouse.y+14+"px"});
				});
				tempJQ.bind("mouseout",{tip:this.$tip},function(e){
					e.data.tip.css({display:"none"});
				});
			}
		}
	};
	//载入多条数据
	this.loadDataList=function(data){
		for(i=0;i<data.length;++i){
			this.loadSimpleData(data[i]);
		}
	};
	//用AJAX方式，远程读取单条数据
	this.loadSimpleDataAjax=function(url,type,para){
		tempFn=this.loadSimpleData;
		$.ajax({
			type: type,
			url: url,
			data: para,
			dataType: "json",
			success: function(simple){
				tempFn(simple);
			}
		});
	};
	//用AJAX方式，远程读取多条数据
	this.$loadDataListAjax=function(url,type,para){
		tempFn=this.loadDataList;
		$.ajax({
			type: type,
			url: url,
			data: para,
			dataType: "json",
			success: function(data){
				tempFn(data);
			}
		}); 
	};
	//清空所有载入的具体数据信息
	this.clearAllData=function(){
		this.$data=[];
		ctx=this.$canvas.getContext('2d');
		ctx.clearRect(0,0,this.$coorWidth,this.$coorHeight);//清空原来已画的曲线图
		this.$coor_bg.children(".point").remove();
	};
}

//将此类的构造函数加入至JQUERY对象中
jQuery.extend({
	createGooCurveChart: function(bgDiv,maxLevel,minLevel,step,stepPy,coorWidth,intervalGroup) {
		return new GooCurveChart(bgDiv,maxLevel,minLevel,step,stepPy,coorWidth,intervalGroup);
  }
}); 
