//-------------------------------------------------
// jQuery Dialogs Plugin
// Version 1.1
// Author S.N. LaViska (http://abeautifulsite.net/)
// Edit by LinPanxing (http://www.91aspx.com/)
//-------------------------------------------------
(function($) {
    $.popup = {
        ID: null,
        title: "",
        top: 0,
        left: 0,
        width: 0,
        height: 0,
        repositionOnResize: false,          // 窗口调整大小后是否重新定位
        autoClose: 0,                       // 窗口自动关闭 (大于0时窗口自动关闭)

        // 公共方法
        message: function(msg, top, left, autoClose) {
            this.ID = 'msg';
            this.popType = 'msg';
            this.title = '';
            this.isPopup = false;
            this.autoClose = autoClose || 0;
            this.width = 240;
            this.height = 30;
            this.top = top || (document.documentElement.clientHeight / 2 + document.documentElement.scrollTop - this.height / 2);
            this.left = left || (document.documentElement.clientWidth / 2 + document.documentElement.scrollLeft - this.width / 2);
            $.popup._show(msg, null);
        },

        help: function(elem, title, msg, height) {
            this.ID = 'help';
            this.title = title || this.title;
            this.width = 271;
            this.height = height || 40;
            this.autoClose = 0;
            var top = $(elem).offset().top;
            if (top - 60 - this.height > 0) {
                this.top = $(elem).offset().top - 60 - this.height;
                this.popType = 'help_up';
            }
            else {
                this.top = top + 16;
                this.popType = 'help_down';
            }
            this.left = $(elem).offset().left - 60;
            $.popup._show(msg);
        },

        // 私有方法
        _show: function(msg, callback) {
            if ($("#_Popup_" + this.ID).length < 1) {
                //$.popup._hide();
                var html =
                '<div class="popup_' + this.popType + '" id="_Popup_' + this.ID + (this.width == 0 ? '">' : '" style="width:' + this.width + 'px">') +
                  '<div class="popup_header" id="_Title_"><h1>' + this.title + '</h1><div class="h_r"></div></div>\
                  <div class="popup_content"' + (this.height == 0 ? '>' : ' style="height:' + this.height + 'px">') +
                    '<div id="_Container_' + this.ID + '">' + msg + '</div></div>' +
                  '<div class="popup_bottom"><div class="b_r"></div>\
                </div>';

                $("BODY").append(html);

                // IE6 Fix
                //var pos = ($.browser.msie && parseInt($.browser.version) <= 6) ? 'absolute' : 'fixed';

                $("#_Popup_" + this.ID).css({
                    position: 'absolute',
                    zIndex: 100,
                    padding: 0,
                    margin: 0
                });

                $.popup._reposition();
                $.popup._maintainPosition(true);

                if (this.autoClose > 0) {
                    $.popup._autoClose();
                }
            }
            else {
                $("#_Container_" + this.ID).html(msg);
                $("#_Popup_" + this.ID).show();
                if (this.autoClose > 0) {
                    $.popup._autoClose();
                }
            }
        },

        _hide: function() {
            if ($("#_Popup_" + this.ID).length > 0) {
                $("#_Popup_" + this.ID).fadeOut(500);
                $.popup._maintainPosition(false);
            }
        },

        _autoClose: function() {
            setTimeout("$.popup._hide()", this.autoClose * 1000);
        },

        _reposition: function() {
            var top = this.top || (($(document).height() / 2) - ($("#popup_container").outerHeight() / 2));
            var left = this.left || (($(document).width() / 2) - ($("#popup_container").outerWidth() / 2));
            if (top < 0) top = 0;
            if (left < 0) left = 0;
            // IE6 fix
            //if ($.browser.msie && parseInt($.browser.version) <= 6) top = top + $(window).scrollTop();
            $("#_Popup_" + this.ID).css({
                top: top + 'px',
                left: left + 'px'
            });
        },

        _maintainPosition: function(status) {
            if ($.popup.repositionOnResize) {
                switch (status) {
                    case true:
                        $(window).bind('resize', $.popup._reposition);
                        break;
                    case false:
                        $(window).unbind('resize', $.popup._reposition);
                        break;
                }
            }
        }
    }

    // 公共调用方法
    _showMessage = function(msg, elem, autoClose) {
        var top;
        if (elem == null) {
            top = null;
        } else {
            var middle = ($(elem).height() - 30) / 2;
            top = $(elem).offset().top + (middle > 0 ? middle : 0);
        }
        $.popup.message(msg, top, null, autoClose);
    }

    showSuccess = function(msg, elem, autoClose) {
        _showMessage('<img src="/admin/images/blue/success.gif" /> ' + msg, elem, autoClose || 1.5);
        $("#_Popup_msg").css({ color: "#000", background: "#FCFFF0", border: "1px #98D87D solid" });
    }

    showError = function(msg, elem, autoClose) {
        _showMessage('<img src="/admin/images/blue/error.gif" /> ' + msg, elem, autoClose || 1.5);
        $("#_Popup_msg").css({ color: "#C00", background: "#FFF0ED", border: "1px #E89494 solid" });
    }

    showLoading = function(msg, elem) {
        var loadingMsg = msg || '正在加载数据，请稍候...';
        _showMessage('<img src="/admin/images/blue/loading.gif" /> ' + loadingMsg, elem, 0);
        $("#_Popup_msg").css({ color: "#000", background: "#FCFBE0", border: "1px #684E02 solid" });
    }

    hideMessage = function() {
        $("#_Popup_msg").fadeOut(500);
    }

    showHelper = function(elem, title, msg, height) {
        $.popup.help(elem, title, msg, height);
    }

    hideHelper = function() {
        setTimeout("$('#_Popup_help').hide()", 1000);
    }
})(jQuery);