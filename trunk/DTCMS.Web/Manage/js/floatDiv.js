function ShowFloatDiv(title,content,width,height,isbackDiv){
	if($('#floatDiv')==null){
		var floatDiv = document.createElement('div');
		floatDiv.id = "floatDiv";
		floatDiv.style.position = "absolute";
		floatDiv.style.width = width + "px";
		floatDiv.style.height = height + "px";
		floatDiv.style.left = (document.documentElement.clientWidth/2 + document.documentElement.scrollLeft - width/2) +"px";
		floatDiv.style.top = (document.documentElement.clientHeight/2 + document.documentElement.scrollTop - height/2) +"px";
		floatDiv.style.zIndex = 1001;
		floatDiv.innerHTML = "<div id=\"headDiv\" onmousedown=\"moveDiv(event,'floatDiv');\"><h3>"+ title +"</h3><span><a href=\"javascript:void(null)\" onclick=\"CloseFloatDiv('floatDiv')\"><img src=\"images/close.gif\" onmouseover=\"this.src='images/close_hover.gif'\" onmouseout=\"this.src='images/close.gif'\" /></a></span></div>";
		document.body.appendChild(floatDiv);
		var bodyDiv = document.createElement('div');
		bodyDiv.id = "bodyDiv";
		bodyDiv.style.width = (width - 22)+ "px";
		bodyDiv.style.height = (height - 60)+ "px";
		bodyDiv.innerHTML = content;
		$('#floatDiv').appendChild(bodyDiv);
	}
	else{
		var floatDiv = $('#floatDiv');
		floatDiv.style.display = "block";
		floatDiv.style.position = "absolute";
		floatDiv.style.width = width + "px";
		floatDiv.style.height = height + "px";
		floatDiv.style.left = (document.documentElement.clientWidth/2 + document.documentElement.scrollLeft - width/2) +"px";
		floatDiv.style.top = (document.documentElement.clientHeight/2 + document.documentElement.scrollTop - height/2) +"px";
		floatDiv.style.zIndex = 1001;
		$('#bodyDiv').innerHTML = content;
	}
	if($('#backDiv')==null && isbackDiv == true){
		var backDiv = document.createElement('div');
		backDiv.id = "backDiv";
		backDiv.style.backgroundColor = "Black";
		backDiv.style.filter = "alpha(opacity=70)";
		backDiv.style.MozOpacity = "0.70";
		backDiv.style.position = "absolute";
		backDiv.style.left = "0px";
		backDiv.style.top = "0px";
		backDiv.style.width = Math.max(document.body.scrollWidth, document.documentElement.clientWidth) +"px";
		backDiv.style.height = Math.max(document.body.scrollHeight, document.documentElement.clientHeight)+"px";
		document.body.appendChild(backDiv);
		$('#backDiv').style.zIndex = 1000;
	}
	else if(isbackDiv == true){
		$('#backDiv').style.display = "block";
	}
}
function moveDiv(event, elem)
{
	$('#floatDiv').style.filter = "alpha(opacity=70)";
	var oObj = $(elem);	
	oObj.onmousemove = mousemove;
	oObj.onmouseup = mouseup;
	oObj.setCapture ? oObj.setCapture() : function(){};
	oEvent = window.event ? window.event : event;
	var dragData = {x : oEvent.clientX, y : oEvent.clientY};
	var backData = {x : parseInt(oObj.style.top), y : parseInt(oObj.style.left)};
	function mousemove()
	{
		var oEvent = window.event ? window.event : event;
		var iLeft = oEvent.clientX - dragData["x"] + parseInt(oObj.style.left);
		var iTop = oEvent.clientY - dragData["y"] + parseInt(oObj.style.top);
		oObj.style.left = iLeft;
		oObj.style.top = iTop;
		dragData = {x: oEvent.clientX, y: oEvent.clientY};
	}
	function mouseup()
	{
		var oEvent = window.event ? window.event : event;
		oObj.onmousemove = null;
		oObj.onmouseup = null;
		$('#floatDiv').style.filter = "";
		if(oEvent.clientX < 1 || oEvent.clientY < 1)
		{
			oObj.style.left = backData.y;
			oObj.style.top = backData.x;
		}
			oObj.releaseCapture ? oObj.releaseCapture() : function(){};
	}
}
function CloseFloatDiv(){
	$('#floatDiv').style.display = "none";
	if($('#backDiv')){
		$('#backDiv').style.display = "none";
	}
}