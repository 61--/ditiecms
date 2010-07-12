/**
 * JSKit's FormValidate
 *
 * @type	    : class
 * @version : v1.0 build 20090817
 * @memo	    :
 * -----------------------------------
 * Copyright (c) cjj http://www.imcjj.com
 */
function FormValidate(){
	var validateList=[],tips=new Tip(), validateRules={
		"isNotNull":[/[\S]+/,"r","不能为空"],
		"isNumber":[/^\d+$/,"r","是否全部为数字"],
		"isLetter":[/^[A-Za-z0-9 ]+$/,"r","是否全部为字母?"],
		"isChinese":[/^[\u0391-\uFFE5]+$/,"r","是否全部为汉字?"],
		"isMail":[/^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/,"r","邮件地址是否正确?"], 
		"isMobile":[/^((\(\d{2,3}\))|(\d{3}\-))?13\d{9}$/,"r","手机号码是否正确?"],
		"isTel":[/^((\(\d{2,3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}(\-\d{1,4})?$/,"r","电话或传真号码是否正确?"],
		"isZip":[/^[1-9]\d{5}$/,"r","邮政编码是否正确?"],
		"isURL":[/^http|ftp:\/\/[A-Za-z0-9]+\.[A-Za-z0-9]+[\/=\?%\-&_~`@[\]\':+!]*([^<>\"\"])*$/,"r","网页地址是否正确?"],
		"ajaxValidate":[ajaxValidate,"f",""],
		"isLen":[isLen,"f","输入的字符长度不符合要求"],
		"isSame":[isSame,"f","输入的内容不同"]
	};

	/**
	 * 添加表单验证外部方法
	 *
	 * @type：公共方法
	 * @Parameter：validate:验证对象(name,handler,type,msg四个属性)
	 * @return：无
	 * @note：
	 */
	FormValidate.prototype.addValidate=function(validate) {
		if(!validate){return;}
		if(!validate.name){return;}

		validateRules[validate.name]=[validate.handler,validate.type, validate.tip];
	};

	/**
	 * 添加表单验证监听
	 *
	 * @type：公共方法
	 * @Parameter：options,验证规则对象
	 * @return：无
	 * @note：
	 */
	FormValidate.prototype.addListen=function(options){/*add listen form*/
		var form,name, rules, rule, elements=[], element, node, elementName, elementID, i, property, customProperty, msg;

		if(!options){return;}

		name=options.name;

		if(!name){return;}
		if(validateList[name]){return;}

		form=document.getElementById(name);

		if(!form){form=document.forms[name];}
		if(!form){return;}/*未找到表单*/

		rules=options.rules||null;

		if(!rules){return;}/*没有验证规则*/

		for(i=0;i<rules.length;i++){/*loop rules*/
			rule=rules[i];
			elementName=rule[0];
			elementID=elementName.replace(/\s/,"");
			property=elementID.split(".");
			customProperty=null;

			if(property.length>1){
				elementID=property[0];
				customProperty=property[1];
			}

			msg="";
			node=form.elements[elementID.replace("*","")];
			element={};
			element.index=elements.length;
			element.mustInput=false;

			if(elementName.substr(0,1)=="*"){element.mustInput=true};

			element.validateResult=null;
			element.obj=node;
			element.obj._elementIndex=elements.length;
			element.tagName=node.tagName.toUpperCase();
			element.className=node.className;
			element.customProperty=customProperty;
			element.rule=rule[1];
			element.elementStyle=options.elementStyle;

			if(rule.length>2){element.parameter=rule[2];}			
			if(rule.length>3){msg=rule[3];}
			else {msg=validateRules[rule[1]][2];}

			element.tip=tips.create({"id":elementID.replace("*","")+"_tip","style":options.tipStyle,"message":msg,"parent":node.parentNode});
			elements[elements.length]=element;

			if(node){
				blurEvent=node.onblur;

				node.onblur=function(){
					if(typeof(blurEvent)=="function"){blurEvent();}

					validateElement(elements[this._elementIndex]);
					blurEvent=null;
				};
			}
		}

		validateList[name]={'name':name,'elements':elements,'form':form};
	};

	/**
	 * 监听表单，当表单提交时，进行验证
	 *
	 * @type：公共函数
	 * @Parameter：无
	 * @return：无
	 * @note：
	 */
	FormValidate.prototype.listen=function(){
		var formName, form, validate, element, elements, blurEvent,_submit, i, j, k;

		if(!validateList){return;}

		for(formName in validateList){
			validate=validateList[formName];
			form=validate.form;
			form._submit=form.submit;

			if(!form){continue;}

			form.submit=function(){
				if(validateForm(formName)){this._submit();}
			};

			form.onsubmit=function(){
				if(validateForm(formName)){return true;}

				return false;
			};
		}
	};

	function validateElement(obj){/*表单项验证*/
		var result=false, str="", element, validateRule, elementID, parameter;

		if(!obj){return result;}

		element=obj.obj;

		if(!element){return result;}

		elementID=element.id;

		switch(obj.tagname) {
		case "SELECT":
			if(element.selectedIndex<0){break;}

			if(obj.customProperty!=null){eval('str=element.options[element.selectedIndex].'+obj.customProperty);}
			else{str=element.options[element.selectedIndex].value;}

			break;
		default:
			str=element.value;
			break;
		}

		if(!obj.mustInput) {/*选填*/
			validateRule=validateRules["isNotNull"];//是否输入内容

			if(!validateRule[0].test(str)){
				element.className=obj.className;
				obj.tip.hide();
				return result;
			}
		}

		validateRule=validateRules[obj.rule];
		str=str.replace(/\'/g,"\\'");
		parameter=obj.parameter;

		if(parameter){
			parameter.value=str;
			parameter.tip=obj.tip;
			parameter.name=obj.name;
			parameter.elementIndex=obj.index;
		}
		else {parameter=str;}

		switch(validateRule[1]) {
		case "f"://函数
			result=validateRule[0](parameter);
			break;
		default://"r"
			result=validateRule[0].test(str);
			break;
		}

		tip=obj.tip;

		if(result==null){return null;}

		if(!result) {//表单验证结果
			element.validateResult=false;
			element.className=obj.elementStyle;
			tip.show();
		}
		else{
			element.validateResult=true;
			element.className=obj.className;
			tip.hide();
		}// end if

		return result;
	}/*end of "validateElement"*/

	function validateForm(form){
		var i, elements,validateResult, result=true, element;

		if(validateList[form]){elements=validateList[form].elements;}
		if(!elements){return;}

		for(i=0;i<elements.length;i++){
			if(elements[i].validateResult==null){
				validateResult=validateElement(elements[i]);

				if(!validateResult){result=false;}
			}
			else {
				if(!elements[i].validateResult&&elements[i].mustInput==true){result=false;}
			}
		}

		return result;
	}/*end of "validateForm"*/

	/**
	 * ajax验证
	 *
	 * @type：函数
	 * @Parameter：options
	 * @return：验证结果
	 * @note：
	 */
	function ajaxValidate(options) {
		var url, method, async, result=null;
		var httpRequest=null;

		if(!options){return null;}
		if (window.XMLHttpRequest) {/*non IE*/
			httpRequest=new XMLHttpRequest();

			if(httpRequest.overrideMimeType){
				var docType=options.docType||"text/plain";
				httpRequest.overrideMimeType(docType);
			}
		}
		else if(window.ActiveXObject) { //IE
			try { httpRequest=new ActiveXObject("Msxml2.XMLHTTP"); }
			catch (e) {
				try { httpRequest=new ActiveXObject("Microsoft.XMLHTTP"); } 
				catch (e) {}
			}
		}

		url=options.url||"";
		method=options.method||"post";
		async=options.async||false;
		result=null;

		if(!url){return null;}

		url+=options.value+"&killcacheid="+Math.random();
		httpRequest.open(method,url,async);

		if(method=="post"){httpRequest.setRequestHeader("Content-Type","application/x-www-form-urlencoded");}

		httpRequest.setRequestHeader("Content-Length",options.value.length); 

		httpRequest.onreadystatechange=function(){
			if(httpRequest.readyState==4){
				if(httpRequest.status==200){
					if(options.callback){
						result=options.callback({"resultText":httpRequest.responseText,"resultXml":httpRequest.responseXML,"tip":options.tip});
					}
					else {result=httpRequest.responseText;}

					setValidateResult(options.name,options.elementIndex,result);
				}
			}
		};

		httpRequest.send(options.value);

		return result;
	}/*end of "ajaxValidate"*/

	function setValidateResult(name,elementId,result){
		var validate=validateList[name], element;

		if(!validate){return;}
		if(!validate.elements){return;}
		
		element=validate.elements[elementId];

		if(!element){return;}

		element.validateResult=result;
	}/*end of "setValidateResult"*/

	function isLen(options){/*验证内容长度*/
		var reg=new RegExp("^\\S{"+options.min+","+options.max+"}$","g");

		return reg.test(options.value);
	}

	function isSame(options){
		var result=false;
		var element=document.getElementById(options.id);

		if(!element){return false;}
		if(element.value==options.value){result=true;}

		return result;
	}
}

/**
 * JSKit's Tip
 *
 * @type       : class
 * @version : v1.0 build 20080723
 * @memo       : none 
 * -----------------------------------
 * Copyright (c) cjj http://www.imcjj.com
 */
function Tip(){
	var tipList=[];

	Tip.prototype.create=function(options){
		var element, tip, id=options.id;
		var tipTag=options.tag||"span";
		var direction=options.direction||1;
		var struct=options.struct||"{#text#}";/*this._struct='     <div class="content">{#text#}</div>\n    <div class="arrow">&nbsp;</div>\n';*/
		var msg=options.message||"";
		var parentObj=options.parent||null;
		var style=options.style||"";

		if(!id||!msg){return;}
		if(tipList[id]){return tipList[id];}

		element=document.getElementById(id);
		tip={};
		tip.oldStyle=style;

		if(element){
			element.className=style;

			if(element.getElementsByTagName("DIV").length<1){element.innerHTML=struct.replace(/\{#text#\}/g,msg);}
		}
		else{
			element=document.createElement(tipTag);
			element.className="hide";
			element.id=id;
			element.innerHTML=struct.replace(/\{#text#\}/g,msg);

			if(typeof(parentObj)!="object"||parentObj==null){document.body.appendChild(element);}
			else{
				switch(direction){
				case 0:parentObj.insertBefore(element,parentObj.firstChild);break;
				default:parentObj.appendChild(element);break;
				}
			}
		}

		tip.element=element;
		tip.show=function(){show(id);};
		tip.hide=function(){hide(id);};
		tipList[id]=tip;

		return tip;
	};/*end of "create"*/

	function show(id){/*show tip*/
	   var tip=tipList[id];

	   if(!tip){return;}
		if(!tip.element){return;}

	   tip.element.className=tip.oldStyle;
	};/*end of "show"*/

	function hide(id){/*hide tip*/
		var tip=tipList[id];

		if(!tip){return;}
		if(!tip.element){return;}

		tip.element.className='hide';
	};/*end of "hide"*/
}