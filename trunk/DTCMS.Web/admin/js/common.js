/*** tab菜单 ***/
function selectTab(showContent, selfObj) {
    // 操作标签
    var tab = document.getElementById("tab_menu").getElementsByTagName("li");
    for (var i = 0; i < tab.length; i++) {
        tab[i].className = "";
    }
    selfObj.parentNode.className = "tab_on";
    // 操作内容
    for (var j = 1; j <= tab.length; j++) {
        document.getElementById('tab' + j).style.display = "none";
    }
    document.getElementById(showContent).style.display = "block";
    selfObj.blur();
}
/*** 全选反选 ***/
function selectAll(elem, cid) {
    var input = document.getElementById(cid).getElementsByTagName('input');
    var len = input.length;
    for (var i = 0; i < len; i++) {
        if ((input[i].type == "checkbox") && elem.checked) {
            input[i].checked = true;
        }
        else {
            input[i].checked = false;
        }
    }
}

/*** 全选反选*name=items ***/
function CheckSelAll(elem) {
    var input = document.getElementsByName("items");
    var len = input.length;
    for (var i = 0; i < len; i++) {
        if (elem.checked) {
            input[i].checked = true;
        }
        else {
            input[i].checked = false;
        }
    }
}

/*** 获取鼠标坐标 ***/
function mousePosition(ev) {
    if (!ev) ev = window.event;
    if (ev.pageX || ev.pageY) {
        return { x: ev.pageX, y: ev.pageY };
    }
    return {
        x: ev.clientX + document.documentElement.scrollLeft - document.body.clientLeft,
        y: ev.clientY + document.documentElement.scrollTop - document.body.clientTop
    };
}
/*** 获取标签坐标 ***/
function getElemCoords(elem) {
    var dom = document.getElementById(elem);
    var t = dom.offsetTop;
    var l = dom.offsetLeft;
    dom = dom.offsetParent;
    while (dom) {
        t += dom.offsetTop;
        l += dom.offsetLeft;
        dom = dom.offsetParent;
    }; return {
        top: t,
        left: l
    };
}
/*** 查看系统帮助 ***/
function showHelp(ID) {
    Dialog.alert("帮助主题" + ID);
}
/*** IP Count ***/

