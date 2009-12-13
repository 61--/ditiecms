/*本系列框架中,一些用得上的小功能函数,一些UI必须使用到它们,用户也可以单独拿出来用*/

//获取一个DIV的绝对坐标的功能函数,即使是非绝对定位,一样能获取到
function getElCoordinate(dom) {
  var t = dom.offsetTop;
  var l = dom.offsetLeft;
  //dom=dom.offsetParent;
  while (dom.offsetParent) {
	dom=dom.offsetParent;
    t += dom.offsetTop;
    l += dom.offsetLeft;
  }; return {
    top: t,
    left: l
  };
}
//兼容各种浏览器的,获取鼠标真实位置
function mousePosition(ev){
    if(ev.pageX || ev.pageY){
        return {x:ev.pageX, y:ev.pageY};
    }
    return {
        x:ev.clientX + document.documentElement.scrollLeft - document.body.clientLeft,
        y:ev.clientY + document.documentElement.scrollTop  - document.body.clientTop
    };
}