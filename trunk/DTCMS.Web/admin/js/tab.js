
/*tab菜单*/
onload = function() {
    var e, i = 0;
    while (e = document.getElementById("tab_menu").getElementsByTagName('DIV')[i++]) {
        if (e.className == 'tab_on' || e.className == 'tab_off') {
            e.onclick = function() {
                var getEls = document.getElementsByTagName('DIV');
                for (var z = 0; z < getEls.length; z++) {
                    getEls[z].className = getEls[z].className.replace('tab_show', 'tab_hiden');
                    getEls[z].className = getEls[z].className.replace('tab_on', 'tab_off');
                }
                this.className = 'tab_on';
                var max = this.getAttribute('title');
                document.getElementById(max).className = "tab_show";
            }
        }
    }
} 