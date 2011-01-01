$(document).ready(function($) {
    if ($("#scroll_ad li").length > 1) {
        $("#scroll_ad").jCarouselLite({
            auto: 2000,
            speed: 500,
            vertical: true,
            visible: 1,
            over: true
        });
    }
    if ($(".settime").length > 0)
        updateEndTime();
});

function updateEndTime() {
    var date = new Date();
    var time = date.getTime();

    $(".settime").each(function(i) {
        var endDate = new Date(this.getAttribute("endTime"));
        var endTime = endDate.getTime();
        var lag = (endTime - time) / 1000;
        if (lag > 0) {
            var second = Math.floor(lag % 60);
            var minite = Math.floor((lag / 60) % 60);
            var hour = Math.floor((lag / 3600) % 24);
            var day = Math.floor((lag / 3600) / 24);
            $(this).html(day + "天" + hour + "小时" + minite + "分" + second + "秒");
        }
        else
            $(this).html("团购已经结束啦！");
    });
    setTimeout("updateEndTime()", 1000);
}

(function($){$.fn.jCarouselLite=function(o){o=$.extend({btnPrev:null,btnNext:null,btnGo:null,mouseWheel:false,auto:null,speed:200,easing:null,space:0,ie6:false,ie7:false,ie8:false,ff:false,vertical:false,circular:true,visible:3,start:0,scroll:1,over:false,beforeStart:null,afterEnd:null},o||{});return this.each(function(){var running=false,animCss=o.vertical?"top":"left",sizeCss=o.vertical?"height":"width";var div=$(this),ul=$("ul",div),tLi=$("li",ul),tl=tLi.size(),v=o.visible;if(o.circular){ul.prepend(tLi.slice(tl-v-1+1).clone()).append(tLi.slice(0,v).clone());o.start+=v}var li=$("li",ul),itemLength=li.size(),curr=o.start;div.css("visibility","visible");li.css({overflow:"hidden",float:o.vertical?"none":"left"});ul.css({margin:"0",padding:"0",position:"relative","list-style-type":"none","z-index":"1"});div.css({overflow:"hidden",position:"relative","z-index":"2",left:"0px"});var liSize=o.vertical?height(li):width(li);if($.browser.msie){switch($.browser.version){case"6.0":if(o.ie6)liSize+=o.space;break;case"7.0":if(o.ie7)liSize+=o.space;break;case"8.0":if(o.ie8)liSize+=o.space;break}}if($.browser.mozilla){if(o.ff)liSize+=o.space}var ulSize=liSize*itemLength;var divSize=liSize*v;li.css({width:li.width(),height:li.height()});ul.css(sizeCss,ulSize+"px").css(animCss,-(curr*liSize));div.css(sizeCss,divSize+"px");if(o.btnPrev)$(o.btnPrev).click(function(){return go(curr-o.scroll)});if(o.btnNext)$(o.btnNext).click(function(){return go(curr+o.scroll)});if(o.btnGo)$.each(o.btnGo,function(i,val){$(val).click(function(){return go(o.circular?o.visible+i:i)})});if(o.mouseWheel&&div.mousewheel)div.mousewheel(function(e,d){return d>0?go(curr-o.scroll):go(curr+o.scroll)});if(o.auto)setInterval(function(){go(curr+o.scroll)},o.auto+o.speed);function vis(){return li.slice(curr).slice(0,v)};if(o.over){div.hover(function(){running=true},function(){running=false})}function go(to){if(!running){if(o.beforeStart)o.beforeStart.call(this,vis());if(o.circular){if(to<=o.start-v-1){ul.css(animCss,-((itemLength-(v*2))*liSize)+"px");curr=to==o.start-v-1?itemLength-(v*2)-1:itemLength-(v*2)-o.scroll}else if(to>=itemLength-v+1){ul.css(animCss,-((v)*liSize)+"px");curr=to==itemLength-v+1?v+1:v+o.scroll}else curr=to}else{if(to<0||to>itemLength-v)return;else curr=to}running=true;ul.animate(animCss=="left"?{left:-(curr*liSize)}:{top:-(curr*liSize)},o.speed,o.easing,function(){if(o.afterEnd)o.afterEnd.call(this,vis());running=false});if(!o.circular){$(o.btnPrev+","+o.btnNext).removeClass("disabled");$((curr-o.scroll<0&&o.btnPrev)||(curr+o.scroll>itemLength-v&&o.btnNext)||[]).addClass("disabled")}}return false}})};function css(el,prop){return parseInt($.css(el[0],prop))||0};function width(el){return el[0].offsetWidth+css(el,'marginLeft')+css(el,'marginRight')};function height(el){return el[0].offsetHeight+css(el,'marginTop')+css(el,'marginBottom')}})(jQuery);