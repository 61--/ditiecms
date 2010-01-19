/*
 *	jRaiser Javascript Library v1.2.0
 *	http://code.google.com/p/jraiser
 *
 *	Copyright (c) 2008-2009 heero
 *	licensed under MIT license
 *
 *	Date: 2009-11-28
 */
(function() {
 
var version = "1.2.0 Build 20091128";
		  
// 防止重复加载
if (window.jRaiser && window.jRaiser.version === version) { return; }

var undefined, 	// 加速对undefined变量的判断
	_$,			// 临时记录当前框架

/// @overload 根据上下文及CSS选择器获取HTML元素;
///		@param {String} CSS选择器
///		@param {HtmlElement,HtmlElementArray,HtmlCollection} 上下文
///		@return {HtmlElement,HtmlElementArray} 匹配到的经扩展的HTML元素
/// @overload 扩展普通HTML元素(数组/集合)
///		@param {HtmlElement,HtmlElementArray,HtmlCollection} 要扩展的Html元素
///		@return {HtmlElement,HtmlElementArray} 经扩展的HTML元素
jRaiser = window.jRaiser = window.$ = function(selector, context) {
	if (null == selector || selector.$) {		// 如果selector不存在或已扩展（包含$方法），直接返回
		return selector;
	}

	var elems;
	if ("string" === typeof selector) {
		// 上下文优先级：context -> this -> document
		context = context || (this.alert ? document : this);
		// 通过选择器引擎获取元素
		elems = SelDom.query(selector, context);
	} else {
		elems = selector;
	}
	if (elems && !elems.$) {
		if (elems.nodeType) {	// 扩展Html元素和非IE下的XML元素
			if ("unknown" !== typeof elems.getAttribute) {
				elems = extend(elems, jRaiser.element);
			}
		} else {	// Html Collection Or Array
			elems = extend(toArray(elems), jRaiser.element);
		}
	}
	return elems;
};


/// 标识当前版本
jRaiser.version = version;


/// 恢复$和NTES全局变量的占用
/// @return {Mixed} 原$变量
jRaiser.resume = function() {
	_$ = window.$;
	
	window.$ = jRaiser;
	window.jRaiser = jRaiser;
	
	return _$;
};


/// 恢复最近一次本类库加载前或jRaiser.resume方法调用前的$变量
/// @return {Object} jRaiser对象
jRaiser.retire = function() {
	window.$ = _$;
	
	return jRaiser;
};


/// SelDom选择器解析引擎
var SelDom = {

	SPACE : /\s*([\s>~+,])\s*/g, // 用于去空格
	ISSIMPLE : /^#?([\w\u00c0-\uFFFF_-]+)$/, 	// 判断是否简单选择器(只有id或tagname)
	IMPLIEDALL : /([>\s~\+,]|^)([#\.\[:])/g, 	// 用于补全选择器
	ATTRVALUES : /=(["'])([^'"]*)\1]/g, 			// 用于替换引号括起来的属性值
	ATTR : /\[\s*([\w\u00c0-\uFFFF_-]+)\s*(?:(\S?\=)\s*(.*?))?\s*\]/g, // 用于替换属性选择器
	PSEUDOSEQ : /\(([^\(\)]*)\)$/g, 	// 用于匹配伪类选择器最后的序号
	BEGINIDAPART : /^(?:\*#([\w\u00c0-\uFFFF_-]+))/, 	// 用于分离开头的id选择器
	STANDARD : /^[>\s~\+:]/, 	// 判断是否标准选择器(以空格、>、~或+开头)
	STREAM : /[#\.>\s\[\]:~\+]+|[^#\.>\s\[\]:~\+]+/g, // 用于把选择器表达式分离成操作符/操作数 数组
	ISINT : /^\d+$/, // 判断是否整数

	tempAttrValues : [], // 临时记录引号/双引号间的属性值
	tempAttrs: [], 	// 临时记录属性表达式

	idName : "uniqueIdForJRaiser",
	id : 0,

	/// 解析CSS选择器获取元素
	/// @param {String} 选择器
	/// @param {HtmlElement,HtmlElementArray,HtmlCollection} 上下文
	/// @return {HtmlElement,HtmlElementArray,HtmlCollection} 匹配到的元素
	query : function(selector, context) {

		var result, 	// 最后结果
			selectors, 	// selector数组
			selCount, 	// selector数组长度
			i, j, 		// 循环变量
			temp, 		// 一个selector中每个操作符和操作数的搜索结果
			matchs, 	// 操作符/操作数 数组
			streamLen, 	// 操作符/操作数 数组长度
			token, 		// 操作符
			filter, 	// 操作数
			t = this;

		// 清除多余的空白
		selector = selector.trim();

		if ("" === selector) {
			return;
		}

		// 对简单选择符的优化操作
		if (t.ISSIMPLE.test(selector)) {
			if (0 === selector.indexOf("#") && typeof context.getElementById !== "undefined") {
				//alert("simple id: " + selector);	// @debug
				return t.getElemById(context, selector.substr(1));
			} else if (typeof context.getElementsByTagName !== "undefined") {
				//alert("simple tagname: " + selector);	// @debug
				return toArray(context.getElementsByTagName(selector));
			}
		}

		// 转换成数组，统一处理
		if (!isArray(context)) {
			context = context.nodeType ? [context] : toArray(context);
		}

		selectors = selector.replace(t.SPACE, "$1")		// 去空白
						.replace(t.ATTRVALUES, t.analyzeAttrValues)	// 替换属性值
						.replace(t.ATTR, t.analyzeAttrs)	// 替换属性选择符
						.replace(t.IMPLIEDALL, "$1*$2")		// 添加必要的"*"(例如.class1 => *.class1)
						.split(","); // 分离多个选择器
		selCount = selectors.length;

		i = -1; result = [];

		while (++i < selCount) {
			// 重置上下文
			temp = context;

			selector = selectors[i];

			// 优化以id选择器开头且上下文是document的情况
			if (t.BEGINIDAPART.test(selector)) {
				if (typeof context[0].getElementById !== "undefined") {
					//alert("begin with id selector: " + RegExp.$1);	// @debug
					temp = [t.getElemById(context[0], RegExp.$1)];
					//alert("result: " + temp); // @debug
					if (!temp[0]) {
						continue;
					}
					selector = RegExp.rightContext;
				} else {	// 上下文不是document, 恢复常规查找
					selector = selectors[i];
				}
			}

			// 处理后续的部分
			if (selector !== "") {
				if (!t.STANDARD.test(selector)) {
					selector = " " + selector;
				}

				// 分离换成字符串数组，从0开始双数是操作符，单数是操作数(例如 " *.class1" => [" ", "*", ".", "class1"])
				matchs = selector.match(t.STREAM) || []; streamLen = matchs.length; j = 0;
				//alert("stream: " + matchs);	// @debug
				while (j < streamLen) {
					token = matchs[j++]; filter = matchs[j++];
					//alert(token + (this.operators[token] ? " is " : " is not ") + "exist"); 	// @debug
					//alert("filter: " + filter);	// @debug
					//alert("context: " + temp);	// @debug
					temp = t.operators[token] ? t.operators[token](temp, filter) : [];
					if (0 === temp.length) {
						break;
					}
				}
			}

			merge(result, temp);
		}

		// 清空临时数组
		t.tempAttrValues.length = t.tempAttrs.length = 0;

		return result.length > 1 ? t.unique(result) : result;
	},

	/// 属性替换处理函数
	analyzeAttrs : function($1, $2, $3, $4) {
		return "[]" + (SelDom.tempAttrs.push([$2, $3, $4]) - 1);
	},

	/// 属性值替换处理函数
	analyzeAttrValues : function($1, $2, $3) {
		return "=" + (SelDom.tempAttrValues.push($3) - 1) + "]";
	},

	/// 获取不重复的元素id
	/// @param {HtmlElement} 元素
	/// @return {Number} id
	generateId : function(elem) {
		var idName = this.idName, id;
		try {
			id = elem[idName] = elem[idName] || new Number(++this.id);
		} catch (e) {
			id = elem.getAttribute(idName);
			if (!id) {
				id = new Number(++this.id);
				elem.setAttribute(idName, id);
			}
		}
		return id.valueOf();
	},

	/// 去除数组中的重复元素
	/// @param {HtmlElementArray} 元素数组
	/// @return {HtmlElementArray} 已去重复的元素数组
	unique : function(elems) {
		var result = [], i = 0, flags = {}, elem, id;
		while (elem = elems[i++]) {
			if (1 === elem.nodeType) {
				id = this.generateId(elem);
				if (!flags[id]) {
					flags[id] = true;
					result.push(elem);
				}
			}
		}
		return result;
	},

	/// 属性名映射
	attrMap : {
		"class" : "className",
		"for" : "htmlFor"
	},

	/// 获取元素属性
	/// @param {HtmlElement} 元素
	/// @param {String} 属性名
	/// @return {String} 属性值
	getAttribute : function(elem, attrName) {
		var trueName = this.attrMap[attrName] || attrName, attrValue = elem[trueName];
		if ("string" !== typeof attrValue) {
			if ("undefined" !== typeof elem.getAttributeNode) {
				attrValue = elem.getAttributeNode(attrName);
				attrValue = undefined == attrValue ? attrValue : attrValue.value;
			} else if (elem.attributes) {		// for IE5.5
				attrValue = String(elem.attributes[attrName]);
			}
		}
		return null == attrValue ? "" : attrValue;
	},

	/// 通过id获取元素
	/// @param {HtmlElement} 上下文，一般是document
	/// @param {String} id
	/// @return {HtmlElement} 元素
	getElemById : function(context, id) {
		var result = context.getElementById(id);
		if (result && result.id !== id && context.all) {	// 修复IE下的id/name bug
			result = context.all[id];
			if (result) {
			    for (var i = 0; i < result.length; i++) {
				    if (this.getAttribute(result[i], "id") === id) {
					    return result[i];
				    }
			    }
			    result = undefined;
			}
		}
		return result;
	},

	/// 搜索指定位置的某标签名元素
	/// @param {HtmlElementArray} 上下文
	/// @param {String} 第一个元素相对位置
	/// @param {String} 下一个元素相对位置
	/// @param {String} 标签名
	/// @param {Number} 数量限制
	/// @return {HtmlElementArray} 搜索结果
	getElemsByTagName : function(context, first, next, tagName, limit) {
		var result = [], i = -1, len = context.length, elem, counter, tagNameUpper;

		if (tagName !== "*") {
			tagNameUpper = tagName.toUpperCase();
		}

		while (++i < len) {
			elem = context[i][first]; counter = 0;
			while (elem && (!limit || counter < limit)) {
				if (elem.nodeName.toUpperCase() === tagNameUpper || (!tagNameUpper && 1 === elem.nodeType)) {
					result.push(elem);
					counter++;
				}
				elem = elem[next];
			}
		}

		return result;
	},

	/// 根据指定顺序检查上下文父元素的第n个子元素是否该上下文元素
	/// @param {HtmlElementArray} 上下文
	/// @param {Number} 序号
	/// @param {String} 第一个元素相对位置
	/// @param {String} 下一个元素相对位置
	/// @return {HtmlElementArray} 搜索结果
	checkElemPosition : function(context, seq, first, next) {
		var result = [];
		if (!isNaN(seq)) {
			var len = context.length, i = -1,
				cache = {},		// 节点缓存
				parent, id, current, child;
				
			while (++i < len) {
				parent = context[i].parentNode;		// 找到父节点
				id = this.generateId(parent);		// 为父节点生成一个id作为缓存键值
				
				if (undefined === cache[id]) {	// 如果缓存中没有，则重新寻找父元素的第N个子元素
					current = 0;			// 重置当前序号
					child = parent[first];	// 第一个元素
					while (child) {
						if (1 === child.nodeType) {
							current++;		// 序号加1
						}
						if (current < seq) {
							child = child[next];	// 还没到指定序号，继续找
						} else {
							break;	// 已经到指定序号，中断循环
						}
					}
					cache[id] = child === undefined ? 0 : child;	// 记下本次搜索结果
				} else {
					child = cache[id];
				}
				if (context[i] === child) {		// 搜索结果与节点相符
					result.push(context[i]);
				}
			}
		}
		return result;
	},
	
	/// 获取特定位置的元素
	/// @param {HtmlElementArray} 上下文
	/// @param {Number} 第一个位置
	/// @param {Number} 下一个位置递增量
	/// @return {HtmlElementArray} 过滤结果
	getElemsByPosition : function(context, first, next) {
		var i = first, len = context.length, result = [];
		for (; i >= 0 && i < len; i += next) {
			result.push(context[i]);
		}
		return result;
	},

	/// 根据属性值过滤元素
	/// @param {HtmlElementArray} 上下文
	/// @param {Array} 属性数组
	/// @return {HtmlElementArray} 过滤结果
	getElemsByAttribute : function(context, filter) {
		var result = [], elem, i = 0,
		check = this.attrOperators[filter[1] || ""], attrValue = "~=" === filter[1] ? " " + filter[2] + " " : filter[2];
		while (elem = context[i++]) {
			check(this.getAttribute(elem, filter[0]), attrValue) && result.push(elem);
		}
		return result;
	},

	/// 操作符
	operators : {

		/// id选择符
		/// @param {HtmlElementArray} 上下文
		/// @param {String} id
		/// @return {HtmlElementArray} 过滤结果
		"#" : function(context, id) {
			return SelDom.getElemsByAttribute(context, ["id", "=", id]);
		},

		/// 后代选择符
		/// @param {HtmlElementArray} 上下文
		/// @param {String} 标签名
		/// @return {HtmlElementArray} 过滤结果
		" " : function(context, tagName) {
			var len = context.length;
			if (1 === len) {
				return context[0].getElementsByTagName(tagName);
			} else {
				var result = [], i = -1;
				while (++i < len) {
					merge(result, context[i].getElementsByTagName(tagName));
				}
			}
			return result;
		},

		/// 类名选择器
		/// @param {HtmlElementArray} 上下文
		/// @param {String} 样式类名
		/// @return {HtmlElementArray} 过滤结果
		"." : function(context, className) {
			return SelDom.getElemsByAttribute(context, ["class", "~=", className]);
		},

		/// 子元素选择符
		/// @param {HtmlElementArray} 上下文
		/// @param {String} 标签名
		/// @return {HtmlElementArray} 过滤结果
		">" : function(context, tagName) {
			return SelDom.getElemsByTagName(context, "firstChild", "nextSibling", tagName);
		},

		/// 同级元素选择符
		/// @param {HtmlElementArray} 上下文
		/// @param {String} 标签名
		/// @return {HtmlElementArray} 过滤结果
		"+" : function(context, tagName) {
			return SelDom.getElemsByTagName(context, "nextSibling", "nextSibling", tagName, 1);
		},

		/// 同级元素选择符
		/// @param {HtmlElementArray} 上下文
		/// @param {String} 标签名
		/// @return {HtmlElementArray} 过滤结果
		"~" : function(context, tagName) {
			return SelDom.getElemsByTagName(context, "nextSibling", "nextSibling", tagName);
		},

		/// 属性选择符
		/// @param {HtmlElementArray} 上下文
		/// @param {Array} 属性条件
		/// @return {HtmlElementArray} 过滤结果
		"[]" : function(context, filter) {
			filter = SelDom.tempAttrs[filter];
			if (filter) {
				if (SelDom.ISINT.test(filter[2])) {
					filter[2] = SelDom.tempAttrValues[filter[2]];
				}
				return SelDom.getElemsByAttribute(context, filter);
			} else {
				return context;
			}
		},

		/// 伪类选择符
		/// @param {HtmlElementArray} 上下文
		/// @param {String} 伪类
		/// @return {HtmlElementArray} 过滤结果
		":" : function(context, filter) {
			var seq;
			if (SelDom.PSEUDOSEQ.test(filter)) {
				seq = parseInt(RegExp.$1);
				filter = RegExp.leftContext;
			}
			return SelDom.pseOperators[filter] ? SelDom.pseOperators[filter](context, seq) : [];
		}
	},

	/// 属性操作符
	attrOperators : {

		/// 是否包含指定属性值
		/// @param {String} 实际属性值
		/// @return {Boolean} 是否符合条件
		"" : function(value) { return value !== ""; },

		/// 是否与指定属性值相等
		/// @param {String} 实际属性值
		/// @param {String} 受检测属性值
		/// @return {Boolean} 是否符合条件
		"=" : function(value, input) { return input === value; },

		/// 是否包含指定属性值
		/// @param {String} 实际属性值
		/// @param {String} 受检测属性值
		/// @return {Boolean} 是否符合条件
		"~=" : function(value, input) { return (" " + value + " ").indexOf(input) >= 0; },

		/// 是否与指定属性值不等
		/// @param {String} 实际属性值
		/// @param {String} 受检测属性值
		/// @return {Boolean} 是否符合条件
		"!=" : function(value, input) { return input !== value; },
		
		/// 属性值是否以某段字符串开头
		/// @param {String} 实际属性值
		/// @param {String} 受检测属性值
		/// @return {Boolean} 是否符合条件
		"^=" : function(value, input) { return value.indexOf(input) === 0; },

		/// 属性值是否以某段字符串结尾
		/// @param {String} 实际属性值
		/// @param {String} 受检测属性值
		/// @return {Boolean} 是否符合条件
		"$=" : function(value, input) { return value.substr(value.length - input.length) === input; },

		/// 属性值是否包含某段子字符串
		/// @param {String} 实际属性值
		/// @param {String} 受检测属性值
		/// @return {Boolean} 是否符合条件
		"*=" : function(value, input) { return value.indexOf(input) >= 0; }
	},

	/// 伪类选择符
	pseOperators : {

		/// 获取第一个子元素
		/// @param {HtmlElementArray} 上下文
		/// @return {HtmlElementArray} 搜索结果
		"first-child" : function(context) {
			return SelDom.checkElemPosition(context, 1, "firstChild", "nextSibling");
		},

		/// 获取第n个子元素
		/// @param {HtmlElementArray} 上下文
		/// @param {Number} 子元素序号
		/// @return {HtmlElementArray} 搜索结果
		"nth-child" : function(context, seq) {
			return SelDom.checkElemPosition(context, seq, "firstChild", "nextSibling");
		},

		/**
		 * 获取最后一个子元素
		 * @param {HtmlElementArray} 上下文
		 * @return {HtmlElementArray} 搜索结果
		 */
		"last-child" : function(context) {
			return SelDom.checkElemPosition(context, 1, "lastChild", "previousSibling");
		},

		/// 获取倒数第n个子元素
		/// @param {HtmlElementArray} 上下文
		/// @param {Number} 子元素序号(倒数)
		/// @return {HtmlElementArray} 搜索结果
		"nth-last-child" : function(context, seq) {
			return SelDom.checkElemPosition(context, seq, "lastChild", "previousSibling");
		},
		
		/// 获取第奇数个元素
		/// @param {HtmlElementArray} 上下文
		/// @return {HtmlElementArray} 过滤结果
		"odd" : function(context) {
			return SelDom.getElemsByPosition(context, 0, 2);
		},
		
		/// 获取第偶数个元素
		/// @param {HtmlElementArray} 上下文
		/// @return {HtmlElementArray} 过滤结果
		"even": function(context) {
			return SelDom.getElemsByPosition(context, 1, 2);
		},
		
		/// 获取第N个元素前的元素
		/// @param {HtmlElementArray} 上下文
		/// @return {HtmlElementArray} 过滤结果
		"lt" : function(context, seq) {
			return SelDom.getElemsByPosition(context, seq - 2, -1);
		},
		
		/// 获取第N个元素后的元素
		/// @param {HtmlElementArray} 上下文
		/// @return {HtmlElementArray} 过滤结果
		"gt" : function(context, seq) {
			return SelDom.getElemsByPosition(context, seq, 1);
		}
	}
};


// HTML元素扩展操作，用于继承
jRaiser.element = {

	/// 以当前元素为上下文通过CSS选择器获取元素
	/// @param {String} CSS选择器
	/// @return {HtmlElement,HtmlElementArray} 匹配到的经扩展的HTML元素
	$ : function(selector) { return jRaiser(selector, this); },

	/// 添加样式
	/// @param {String} 类名或内联样式，多个类名用空格隔开
	/// @return {HtmlElement,HtmlElmentArray} 当前元素
	addCss : function(css) { return jRaiser.style.addCss(this, css); },

	/// 移除样式
	/// @param {String} 类名或内联样式，多个类名用空格隔开
	/// @return {HtmlElement,HtmlElmentArray} 当前元素
	removeCss : function(css) { return jRaiser.style.removeCss(this, css); },

	/// 添加事件委托函数
	/// @param {String} 事件名，多个事件用逗号隔开
	/// @param {Function} 事件委托函数
	/// @param {Mixed} data
	/// @return {HtmlElement,HtmlElmentArray} 当前元素
	addEvent : function(eventName, handler, data) { return jRaiser.event.addEvent(this, eventName, handler, data); },

	/// 移除事件委托函数
	/// @param {String} 事件名，多个事件用逗号隔开
	/// @param {Function} 事件委托函数
	/// @return {HtmlElement,HtmlElementArray} 当前元素
	removeEvent : function(eventName, handler) { return jRaiser.event.removeEvent(this, eventName, handler); },

	/// @overload 获取当前元素的属性值
	///		@param {String} 属性名
	///		@param {Mixed} 属性值
	/// @overload 设置当前元素的属性值
	///		@param {String} 属性名
	///		@param {String,Function} 属性值或用于计算属性值的函数
	///		@return {HtmlElement,HtmlElementArray} 当前元素
	attr : function(name, value) {
		var t = this;
		name = SelDom.attrMap[name] || name;
		if (value !== undefined) {
			return jRaiser.dom.eachNode(t, function(name, value) {
				this[name] = jRaiser.util.isFunction(value) ? value.call(this) : value;
			}, arguments);
		} else {
			return isArray(t) ? (t[0] ? t[0][name] : undefined) : t[name];
		}
	}
};

// window对象、document对象的添加、移除事件方法
window.addEvent = document.addEvent = jRaiser.element.addEvent;
window.removeEvent = document.removeEvent = jRaiser.element.removeEvent;


var tplCache = {},		// 模板缓存
	toString = Object.prototype.toString;	// 简写toString

/// 工具类、工具函数
jRaiser.util = {
	
	/// 检查变量是否Array类型
	/// @param {Mixed} 待测变量
	/// @return {Boolean} 待测变量是否Array类型
	isArray : function(value) { return toString.call(value) === "[object Array]"; },
	
	/// 检查变量是否函数类型
	/// @param {Mixed} 待测变量
	/// @return {Boolean} 待测变量是否函数
	isFunction : function(value) { return toString.call(value) === "[object Function]"; },

	/// 把集合转换为数组
	/// @param {Array,Collection} 集合
	/// @return {Array} 数组
	toArray : function(col) {
		if (isArray(col)) {
			return col;
		} else if (col.toArray) {
			return col.toArray();
		} else {
			var arr = [], i = col.length;
			while (i) {
				arr[--i] = col[i];
			}
			return arr;
		}
	},

	/// 合并数组
	/// @param {Array} 目标数组
	/// @param {Array,Collection} 源数组
	/// @return {Array} 混合后的目标数组
	merge : function(first, second) {
		var i = second.length, pos = first.length;
		while (--i >= 0) {
			first[pos + i] = second[i];
		}
		return first;
	},

	/// 模板转换
	/// @param {String} 模板代码
	/// @param {Object} 值集合
	/// @param {Boolean} 是否缓存模板，默认为缓存
	/// @return {String} 转换后的代码
	parseTpl : function(tpl, values, isCached) {
		var func = tplCache[tpl]; values = null == values ? {} : values;
		if (!func) {
			var strFunc = "var _=[];with(obj){_.push('" +
					tpl.replace(/[\r\t\n]/g, " ")
					.replace(/'(?=[^#]*#>)/g, "\t")
					.split("'").join("\\'")
					.split("\t").join("'")
					.replace(/<#=(.+?)#>/g, "',$1,'")
					.split("<#").join("');")
					.split("#>").join("_.push('")
					+ "');}return _.join('');";
			func = new Function("obj", strFunc);
			if (null == isCached || true === isCached) {
				tplCache[tpl] = func;
			}
		}
		
		return func(values);
	},

	/// 把源对象的属性和方法扩展到目标对象上
	/// @param {Mixed} 目标对象
	/// @param {Mixed} 源对象
	/// @return {Mixed} 已扩展的目标对象
	extend : function(des, src) {
		for (var p in src) {
			des[p] = src[p];
		}
		return des;
	}
};


/// DOM操作
jRaiser.dom = {

	/// 对指定节点执行某个函数
	/// @param {HtmlElement,HtmlElementArray} 指定节点
	/// @param {Function} 处理函数
	/// @param {Array} 参数
	/// @return {HtmlElement,HtmlElementArray} 指定节点
	eachNode : function(nodes, callback, args) {
		if (!nodes) {
			return;
		}
		if (nodes.nodeType || nodes.alert) {
			callback.apply(nodes, args);
		} else {
			var i = -1, len = nodes.length;
			// 递归执行
			while (++i < len) {
				callback.apply(nodes[i], args);
			}
		}
		return nodes;
	}
};


// 加速内部访问
var isArray = jRaiser.util.isArray, toArray = jRaiser.util.toArray, merge = jRaiser.util.merge, extend = jRaiser.util.extend, testElem = document.createElement("div");


// 对CSS样式字符串进行解释的正则表达式
var FIXCSSNAME = /\-([a-z])/gi,
	FLOATNAME = testElem.style.styleFloat !== undefined ? "styleFloat" : "cssFloat",
	STYLESPLITER = /([^:;]+)/g,
	CLASSSPLITER = /[^\s]+/g,
	CSSSPACE = /\s*([:;\s])\s*/g,
	STYLENAME = /([^:;]+?)(?=:)/g,
	ISFLOAT = /^float$/i;
	
// 转换为js标准的样式属性名
function toJsStyleName($0, $1) {
	return $1.toUpperCase();
}
// 修复样式名
function fixStyleName($0, $1) {
	return ISFLOAT.test($1) ? FLOATNAME : $1.replace(FIXCSSNAME, toJsStyleName);
}
// 添加样式类
function addClasses(classes, len) {
	var className = " " + this.className + " ", i = -1;
	while (++i < len) {
		if (-1 === className.indexOf(" " + classes[i] + " ")) {
			className += (classes[i] + " ");
		}
	}
	this.className = className.trim();
}
// 添加样式
function addStyles(styles, len) {
	var i = 0;
	while (i < len) {
		this.style[styles[i++]] = styles[i++].replace(/^NULL$/i, "");
	}
}
// 删除样式类
function removeClasses(classes, len) {
	var className = " " + this.className + " ", i = -1;
	while (++i < len) {
		className = className.replace(" " + classes[i] + " ", " ");
	}
	this.className = className.trim();
}
// 删除样式
function removeStyles(styles, len) {
	for (var i = 0; i < len; i++) {
		this.style[styles[i]] !== undefined && (this.style[styles[i]] = "");
	}
}

/// 样式控制
jRaiser.style = {

	/// 识别CSS样式
	/// @param {String} 样式
	/// @return {Array} 标记了样式类型的样式流
	parse : function(css) {
		var hasSemi = css.indexOf(";") >= 0, hasColon = css.indexOf(":") >= 0;

		if (hasSemi || hasColon) {
			css = css.trim().replace(CSSSPACE, "$1").replace(hasColon ? STYLENAME : STYLESPLITER, fixStyleName).match(STYLESPLITER);
			if (hasColon && css.length % 2 !== 0) {
				throw "invalid inline style";
			}
			css.styleType = "style";
		} else {
			css = css.match(CLASSSPLITER);
			css.styleType = "class";
		}
		
		return css;
	},

	/// 为指定HTML元素添加样式
	/// @param {HtmlElement,HtmlElementArray,HtmlCollection} 指定元素
	/// @param {String} 样式
	/// @return {HtmlElement,HtmlElementArray,HtmlCollection} 指定元素
	addCss : function(elems, css) {
		css = jRaiser.style.parse(css);
		return jRaiser.dom.eachNode(
			elems, "class" === css.styleType ? addClasses : addStyles, [css, css.length]);
	},

	/// 为指定HTML元素移除样式
	/// @param {HtmlElement,HtmlElementArray,HtmlCollection} 指定元素
	/// @param {String} 样式
	/// @return {HtmlElement,HtmlElementArray,HtmlCollection} 指定元素
	removeCss : function(elems, css) {
		css = jRaiser.style.parse(css);
		return jRaiser.dom.eachNode(
			elems, "class" === css.styleType ? removeClasses : removeStyles, [css, css.length]);
	},
	
	/// 获取指定元素的当前样式
	/// @param {HtmlElement,HtmlElementArray,HtmlCollection} 指定元素
	/// @param {String} 样式名
	/// @param {Object} 元素所在的页面的window对象，默认为当前window对象
	/// @return {String} 样式值
	getCurrentStyle : function(nodes, styleName, w) {
		if (null == nodes) {
			return undefined;
		}
		var node = nodes.nodeType ? nodes : nodes[0];
		return (node.currentStyle || (w || window).getComputedStyle(node, null))[fixStyleName(undefined, styleName)];
	}
};


// 添加事件
function newEvent(eventName, handler, data) {
	var t = this;
	handler = jRaiser.event.delegate(t, eventName, handler, data);
	if (t.attachEvent) {
		t.attachEvent("on" + eventName, handler);
	} else if (t.addEventListener) {
		t.addEventListener(eventName, handler, false);
	}
}
// 移除事件
function disposeEvent(eventName, handler, data) {
	var t = this;
	handler = jRaiser.event.getDelegate(t, eventName, handler);
	if (t.detachEvent) {
		t.detachEvent("on" + eventName, handler);
	} else if (t.removeEventListener) {
		t.removeEventListener(eventName, handler, false);
	}
}

var EVENTSPLITER = /\s*,\s*/;	// 事件名分隔符

/// 事件处理
jRaiser.event = {
	
	// 事件Id属性名
	idName : "eventIdForJRaiser",

	// 事件容器名
	eventsWrapper : "eventsForJRaiser",

	// 事件编号基值
	eventId : 0,

	/// 为指定HTML元素添加事件委托函数
	/// @param {HtmlElement,HtmlElementArray,HtmlCollection} 指定元素
	/// @param {String} 事件名，多个事件名用逗号隔开
	/// @param {Function} 事件委托函数
	/// @param {Object} 额外传入的数据
	/// @return {HtmlElement,HtmlElementArray,HtmlCollection} 指定元素
	addEvent : function(elems, eventNames, handler, data) {
		eventNames = eventNames.split(EVENTSPLITER);
		for (var i = eventNames.length - 1; i >= 0; i--) {
			jRaiser.dom.eachNode(elems, newEvent, [eventNames[i], handler, data]);
		}
		return elems;
	},

	/// 为指定HTML元素移除事件委托函数
	/// @param {HtmlElement,HtmlElementArray,HtmlCollection} 指定元素
	/// @param {String} 事件名，多个事件名用逗号隔开
	/// @param {Function} 事件处理函数
	/// @return {HtmlElement,HtmlElementArray,HtmlCollection} 指定元素
	removeEvent : function(elems, eventNames, handler, data) {
		eventNames = eventNames.split(EVENTSPLITER);
		for (var i = eventNames.length - 1; i >= 0; i--) {
			jRaiser.dom.eachNode(elems, disposeEvent, [eventNames[i], handler, data]);
		}
		return elems;
	},

	/// 生成事件代理
	/// @param {HtmlElement} 元素
	/// @param {String} 事件名
	/// @param {Function} 事件处理函数
	/// @param {Object} 额外传入的数据
	/// @return {Function} 事件代理
	delegate : function(elem, eventName, handler, data) {
		var t = jRaiser.event, events = elem[t.eventsWrapper] = elem[t.eventsWrapper] || {}, 	// 取得事件Hash表引用
			id = handler[t.idName] = handler[t.idName] || ++t.eventId; 	// 获取不重复的事件编号
		// 生成特定事件Hash表
		events[eventName] = events[eventName] || {};

		var trueHandler = events[eventName][id];
		if (!trueHandler) {
			trueHandler = function(e) {
				e = jRaiser.event.fix(e);
				false === handler.call(elem, e, data || {}) && e.preventDefault();
			};
			events[eventName][id] = trueHandler;
		}

		return trueHandler;
	},

	/// 获取事件代理
	/// @param {HtmlElement} 元素
	/// @param {String} 事件名
	/// @param {Function} 事件处理函数
	/// @return {Function} 事件代理
	getDelegate : function(elem, eventName, handler) {
		try {
			return elem[this.eventsWrapper][eventName][handler[this.idName]];
		} catch (e) {

		}
		return handler;
	},

	/// 修复不同浏览器的事件兼容性
	/// @param {Event} 事件对象
	/// @return {Event} 修复后的事件对象
	fix : function(e) {
		if (!e.target) {
			e.target = e.srcElement || document;
		}
		if (3 == e.target.nodeType) {
			e.target = e.target.parentNode;
		}
		e.timestamp = e.timeStamp || Date.now();
		e.preventDefault = e.preventDefault || function() {
			e.returnValue = false;
		};
		if (undefined === e.pageX && undefined !== e.clientX) {
			var doc = document.documentElement, body = document.body;
			e.pageX = e.clientX + (doc.scrollLeft || body.scrollLeft || 0) - (doc.clientLeft || 0);
			e.pageY = e.clientY + (doc.scrollTop || body.scrollTop || 0) - (doc.clientTop || 0);
		}
		if (!e.which) {
			e.which = e.charCode || e.keyCode;
		}
		// 鼠标单击：1 == 左键; 2 == 中键; 3 == 右键
		if (!e.which && e.button) {
			e.which = (e.button & 1 ? 1 : (e.button & 2 ? 3 : (e.button & 4 ? 2 : 0)));
		}
		return e;
	}
};


// 获取客户端信息
var userAgent = navigator.userAgent.toLowerCase();

/// 浏览器检测对象
jRaiser.browser = {
	
	/// {String} 浏览器版本
	version: (userAgent.match(/.+(?:rv|it|ra|ie)[\/: ]([\d.]+)/) || [0,'0'])[1],
	
	/// {Boolean} 是否Safari浏览器
	safari: /webkit/.test(userAgent),
	
	/// {Boolean} 是否Opera浏览器
	opera: /opera/.test(userAgent),
	
	/// {Boolean} 是否IE浏览器
	msie: /msie/.test(userAgent) && !/opera/.test(userAgent),
	
	/// {Boolean} 是否Mozilla浏览器
	mozilla: /mozilla/.test(userAgent) && !/(compatible|webkit)/.test(userAgent)
};


/// Ajax操作
jRaiser.ajax = {

	/// 创建XmlHttpRequest对象
	/// @return {XMLHttpRequest} XmlHttpRequest对象
	createXhr : function() {
		var xhr;
		try {
			xhr = window.ActiveXObject ? new ActiveXObject("Microsoft.XMLHTTP") : new XMLHttpRequest();
		} catch (e) { }
		if (!xhr) {
			throw "failed to create an XMLHttpRequest object";
		}
		return xhr;
	},

	/// 发送Ajax请求
	/// @param {String} 请求地址
	/// @param {String} 发送方式，"GET"或"POST"，默认为GET
	/// @param {Object} 发送的数据
	/// @param {Object} 其他可选参数
	/// @param {XMLHttpRequest} 用于发送请求的XmlHttpRequest对象，如不指定则自动创建
	/// @return {XMLHttpRequest} XmlHttpRequest对象
	send : function(url, method, data, options, xhr) {
		// 创建XMLHttpRequest对象
		xhr = xhr || jRaiser.ajax.createXhr();
		var hasCompleted;
		
		// 修正参数
		method = method.toUpperCase();
		method = method !== "GET" && method !== "POST" ? "GET" : method;		// 默认为GET
		options = options || {};
		options.async = "boolean" === typeof options.async ? options.async : true;
		
		// 连接参数键值对
		var postData;
		if (data) {
			postData = [];
			for (var d in data) {
				if (d != null) {
					postData.push(d + "=" + encodeURIComponent(data[d]));
				}
			}
			postData = postData.join("&").replace(/%20/g, "+");
		}
		
		// 超时处理(异步处理时才有效)
		if (options.async && !isNaN(options.timeout) && options.timeout > 0) {
			setTimeout(
				function() {
					if (!hasCompleted) {
						xhr.abort();
						if (options.onTimeout) {
							options.onTimeout(xhr);
						}
					}
				},
				options.timeout
			);
		}
		
		// 设定状态变换时的事件
		xhr.onreadystatechange = function() {
			if (4 == xhr.readyState) {
				hasCompleted = true;
				var eventName = 200 == xhr.status ? "onSuccess" : "onError";
				options[eventName] && options[eventName](xhr);
			}
		};
		
		if (postData && "GET" === method) {
			url += ("?" + postData);
			postData = null;
		}
		
		// 打开连接并发送数据
		xhr.open(method, url, options.async, options.username, options.password);
		
		var contentType = [];
		if ("POST" === method) {
			contentType.push("application/x-www-form-urlencoded");
		}
		// 设置header
		if (options.headers) {
			for (var h in options.headers) {
				if ("content-type" === h.toLowerCase()) {
					contentType.push(options.headers[h]);
				} else {
					xhr.setRequestHeader(h, options.headers[h]);
				}
			}
		}
		if (contentType.length) {
			xhr.setRequestHeader("Content-Type", contentType.join(";").replace(/;+/g, ";").replace(/;$/, ""));
		}
		
		//"POST" === method && xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
		xhr.send(postData);
		return xhr;
	},

	/// 动态加载外部Javascript文件
	/// @param {String} URL
	/// @param {Function} 加载完成后执行的回调函数
	/// @param {String} 编码
	/// @param {Object} 文档对象，默认为当前文档
	importJs : function(url, onComplete, charset, doc) {
		doc = doc || document;
		
		var script = doc.createElement("script");
		script.language = "javascript"; script.type = "text/javascript";
		
		if (charset) {
			script.charset = charset;
		}

		// 读取完后的操作
		script.onload = script.onreadystatechange = function() {
			if (!script.readyState || "loaded" == script.readyState || "complete" == script.readyState) {
				onComplete && onComplete(script);
				script.onload = script.onreadystatechange = null;
				script.parentNode.removeChild(script);
			}
		};
		
		script.src = url;
		doc.getElementsByTagName("head")[0].appendChild(script);
	}
};


// Cookie过期时间格式
var EXPIRESWITHUNIT = /[smhdMy]$/,
	TIMEUNITS = {
		"s" : 1,
		"m" : 60,
		"h" : 60 * 60,
		"d" : 24 * 60 * 60,
		"M" : 30 * 24 * 60 * 60,
		"y" : 365 * 24 * 60 * 60
	};

/// Cookie操作
jRaiser.cookie = {
	
	/// 编码函数
	encoder : window.encodeURIComponent,
	
	/// 解码函数
	decoder : window.decodeURIComponent,

	/// 获取Cookie值
	/// @param {String} Cookie名
	/// @return {String} Cookie值
	get : function(name) {
		var t = jRaiser.cookie;
		name = t.encoder(name) + "=";
		var cookie = document.cookie, beginPos = cookie.indexOf(name), endPos;
		if (-1 === beginPos) {
			return undefined;
		}
		beginPos += name.length; endPos = cookie.indexOf(";", beginPos);
		if (endPos === -1) {
			endPos = cookie.length;
		}
		return t.decoder(cookie.substring(beginPos, endPos));
	},

	/// 设置Cookie值
	/// @param {String} Cookie名
	/// @param {Mixed} Cookie值
	/// @param {Number,Date,String} 过期时间
	/// @param {String} 域
	/// @param {String} 路径
	/// @param {Boolean} 是否仅把Cookie发送给受保护的服务器连接(https)
	set : function(name, value, expires, domain, path, secure) {
		var t = jRaiser.cookie, cookieStr = [t.encoder(name) + "=" + t.encoder(value)];
		if (expires) {
			var date, unit;
			if ("[object Date]" === toString.call(expires)) {
				date = expires;
			} else {
				if ("string" === typeof expires && EXPIRESWITHUNIT.test(expires)) {
					expires = expires.substring(0, expires.length - 1);
					unit = RegExp.lastMatch;
				}
				if (!isNaN(expires)) {
					date = new Date();
					date.setTime(date.getTime() + expires * TIMEUNITS[unit || "m"] * 1000);
				}
			}
			date && cookieStr.push("expires=" + date.toUTCString());
		}
		path != null && path !== "" && cookieStr.push("path=" + path);
		domain && cookieStr.push("domain=" + domain);
		secure && cookieStr.push("secure");
		document.cookie = cookieStr.join(";");
	},

	/// 删除Cookie
	/// @param {String} Cookie名
	/// @param {String} 域
	/// @param {String} 路径
	del : function(name, domain, path) {
		document.cookie = jRaiser.cookie.encoder(name) + "=" + (path != null && path !== "" ? ";path=" + path : "") + (domain ? ";domain=" + domain : "") + ";expires=Thu, 01-Jan-1970 00:00:01 GMT";
	}

};


var whiteSpaces = /^\s+|\s+$/g;
/// 去掉当前字符串两端的某段字符串
/// @param {String} 要去掉的字符串，默认为空白
/// @return {String} 修整后的字符串
String.prototype.trim = function(str) {
	return this.replace(null == str ? whiteSpaces : new RegExp("^" + str + "+|" + str + "+$", "g"), "");
};

/// 从左边开始截取一定长度的子字符串
/// @param {Number} 长度
/// @return {String} 子字符串
String.prototype.left = function(n) { return this.substr(0, n); };

/// 从右边开始截取一定长度的子字符串
/// @param {Number} 长度
/// @return {String} 子字符串
String.prototype.right = function(n) { return this.slice(-n); };

/// 检查当前字符串中是否存在以指定分隔符隔开的一段子字符串
/// @param {String} 要查找的子字符串
/// @param {String} 分隔符
/// @return {Boolean} 是否包含子字符串
String.prototype.has = function(str, spliter) {
	return "string" === typeof spliter ? (spliter + this + spliter).indexOf(spliter + str + spliter) >= 0 : this.indexOf(str) >= 0;
};

/// 格式化字符串
/// @param {String} 要格式化的字符串
/// @param {String} 参数
/// @return {String} 格式化后的字符串
String.format = function(str) {
	var args = arguments, re = new RegExp("%([1-" + args.length + "])", "g");
	return String(str).replace(re, function($1, $2) {
		return args[$2];
	});
};

/// 为函数绑定this和参数
/// @param {Mixed} 需绑定为this的对象
/// @param {Mixed} 参数
/// @return {Function} 绑定this和参数的函数
Function.prototype.bind = function() {
	if (!arguments.length) { return this; }
	var method = this, args = Array.prototype.slice.call(arguments), object = args.shift();
	return function() {
		return method.apply(object, args.concat(Array.prototype.slice.call(arguments)));
	};
};

/// 在当前数组中检索指定元素
/// @param {Mixed} 指定元素
/// @param {Number} 开始搜索的位置，默认为0
/// @return {Number} 指定元素在数组中第一个匹配项的索引；如果该元素不存在于数组中，返回-1
Array.prototype.indexOf = Array.prototype.indexOf || function(elem, startPos) {
	var i = isNaN(startPos) || startPos < 0 ? -1 : startPos - 1, len = this.length;
	while (++i < len) {
		if (this[i] === elem) {
			return i;
		}
	}
	return -1;
};

/// 删除当前数组指定位置的元素
/// @param {Number} 指定位置
/// @return {Array} 当前数组
Array.prototype.remove = function(n) {
	if (n >= 0) {
		this.splice(n, 1);
	}
	return this;
};


// 把数字转换成两位数的字符串
function toTwoDigit(num) { return num < 10 ? "0" + num : num; }

// 临时记录正在转换的日期
var tempYear, tempMonth, tempDate, tempHour, tempMinute, tempSecond;

// 格式替换函数
function getDatePart(part) {
	switch (part) {
		case "yyyy": return tempYear;
		case "yy": return tempYear.toString().slice(-2);
		case "MM": return toTwoDigit(tempMonth);
		case "M": return tempMonth;
		case "dd": return toTwoDigit(tempDate);
		case "d": return tempDate;
		case "HH": return toTwoDigit(tempHour);
		case "H": return tempHour;
		case "hh": return toTwoDigit(tempHour > 12 ? tempHour - 12 : tempHour);
		case "h": return tempHour > 12 ? tempHour - 12 : tempHour;
		case "mm": return toTwoDigit(tempMinute);
		case "m": return tempMinute;
		case "ss": return toTwoDigit(tempSecond);
		case "s": return tempSecond;
		default: return part;
	}
}

/// 返回当前日期的毫秒表示
/// @param {Number} 当前日期的毫秒表示
Date.now = Date.now || function() { return +new Date; }

/// 返回指定格式的日期字符串
/// @param {String} 格式
/// @return {String} 指定格式的日期字符串
Date.prototype.format = function(formation) {
	tempYear = this.getFullYear();
	tempMonth = this.getMonth() + 1;
	tempDate = this.getDate();
	tempHour = this.getHours();
	tempMinute = this.getMinutes();
	tempSecond = this.getSeconds();

	return formation.replace(/y+|m+|d+|h+|s+|H+|M+/g, getDatePart);
};


// 回收资源
testElem = null;

})();