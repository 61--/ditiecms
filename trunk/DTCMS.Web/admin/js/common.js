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
function selectAll(elem,cid) {
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
function mouseCoords(ev) {
    ev = ev || window.event;
    if (ev.pageX || ev.pageY) {
        return { x: ev.pageX, y: ev.pageY };
    }
    return {
        x: ev.clientX + document.body.scrollLeft - document.body.clientLeft,
        y: ev.clientY + document.body.scrollTop - document.body.clientTop
    }
}
/*** 获取标签坐标 ***/
function getElementCoords(px, py) {
    return {
        x: event.clientX - event.offsetX + px,
        y: event.clientY - event.offsetY + py
    }
}
/*** 查看系统帮助 ***/
function showHelp(ID) {
    Dialog.alert("帮助主题" + ID);
}