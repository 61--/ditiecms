/***tab菜单***/
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
/***全选反选***/
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