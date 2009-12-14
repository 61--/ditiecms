// jQuery Dialogs Plugin
// Version 1.1
// Cory S.N. LaViska (http://abeautifulsite.net/)
// Edit by LinPanxing (http://www.91aspx.com/)
//
(function($) {
    $.popup = {
        ID: null,
        top: 0,
        left: 0,
        width: null,
        height: null,
        repositionOnResize: false,          // 窗口调整大小后是否重新定位
        //draggable: false,                 // 允许拖拽 (需要UI Draggables插件)
        okButton: '确 定',                  // 确定按钮
        cancelButton: '取 消',              // 取消按钮
        isButtonRow: true,                 // 是否显示按钮
        isPopup: true,                      // 是否为popup窗口
        autoClose: 0,                       // 窗口自动关闭 (大于0时窗口自动关闭)

        // 公共方法
        alert: function(message, title, callback) {
            if (title == null) title = 'Alert';
            $.popup._show(title, message, null, 'alert', function(result) {
                if (callback) callback(result);
            });
        },

        confirm: function(message, title, callback) {
            if (title == null) title = 'Confirm';
            $.popup._show(title, message, null, 'confirm', function(result) {
                if (callback) callback(result);
            });
        },

        prompt: function(message, value, title, callback) {
            if (title == null) title = 'Prompt';
            $.popup._show(title, message, value, 'prompt', function(result) {
                if (callback) callback(result);
            });
        },

        // 私有方法
        _show: function(title, msg, value, type, callback) {
            if (document.getElementById("_Popup_" + this.ID) == null) {
                //$.popup._hide();

                var html =
			    '<div class="popup_' + type + '" id="_Popup_' + this.ID + '" style="width:' + this.width + 'px">\
                  <div class="popup_header" id="_Title_"><h1>' + title + '</h1><div class="h_r"><div></div>\
                  <div class="popup_content">\
                    <div id="_Container_' + this.ID + '" style="height:' + this.height + 'px">' + msg + '</div>\
                    <div class="buttonRow" id="_ButtonRow_' + this.ID + '">\
                    </div>\
                  </div>\
                  <div class="popup_bottom"><div class="b_r"></div>\
                </div>';

                $("BODY").append(html);

                // IE6 Fix
                var pos = ($.browser.msie && parseInt($.browser.version) <= 6) ? 'absolute' : 'fixed';

                $("#_Popup_" + this.ID).css({
                    position: pos,
                    zIndex: 100,
                    padding: 0,
                    margin: 0
                });

                $("#_Popup_" + this.ID).css({
                    minWidth: $("#_Popup_" + this.ID).outerWidth(),
                    maxWidth: $("#_Popup_" + this.ID).outerWidth()
                });

                $.popup._reposition();
                $.popup._maintainPosition(true);

                $.popup._bindType(type);
            }
            else {
                $.popup._bindType(type);
                $("#_Popup_" + this.ID).show();
            }
            // Popup 窗口方法待测试
            /*if (this.isPopup) {
            $(document).bind("click", function(e) {
            $.popup._hide();
            });
            }*/
        },

        _bindType: function(type) {
            switch (type) {
                case 'help':
                    if (this.isButtonRow) {
                        $("#_ButtonRow_" + this.ID).after('<input type="button" value="' + $.popup.okButton + '" id="_ButtonOK_' + this.ID + '" />');
                        $("#_ButtonOK_" + this.ID).click(function() {
                            $.popup._hide();
                            callback(true);
                        });
                        $("#_ButtonOK_" + this.ID).keypress(function(e) {
                            if (e.keyCode == 13 || e.keyCode == 27) $("#_ButtonOK_" + this.ID).trigger('click');
                        });
                    }
                    break;
                case 'prompt':
                    if (this.isButtonRow) {
                        $("#_ButtonRow_" + this.ID).append('<input type="hidden" id="hid_' + this.ID + '" />\
                        <input type="button" value="' + $.popup.okButton + '" id="_ButtonOK_' + this.ID + '/>\
                        <input type="button" value="' + $.popup.cancelButton + '" id="_ButtonCancel_' + this.ID + '"/>');
                        $("#_ButtonOK_" + this.ID).click(function() {
                            var val = $("#hid_" + this.ID).val();
                            $.popup._hide();
                            if (callback) callback(val);
                        });
                        $("#_ButtonCancel_" + this.ID).click(function() {
                            $.popup._hide();
                            if (callback) callback(null);
                        });
                        $("#_ButtonOK_" + this.ID + ", #_ButtonCancel_" + this.ID).keypress(function(e) {
                            if (e.keyCode == 13) $("#_ButtonOK_" + this.ID).trigger('click');
                            if (e.keyCode == 27) $("#_ButtonCancel_" + this.ID).trigger('click');
                        });
                    }
                    break;
                case 'popup':
                    break;
                default:
                    break;
            }

        },

        _hide: function() {
            $("#_Popup_" + this.ID).fadeOut(500);
            //$("#popup_container").remove();
            $.popup._maintainPosition(false);
        },

        _reposition: function() {
            var top = $.popup.top || (($(document).height() / 2) - ($("#popup_container").outerHeight() / 2));
            var left = $.popup.left || (($(document).width() / 2) - ($("#popup_container").outerWidth() / 2));
            if (top < 0) top = 0;
            if (left < 0) left = 0;
            // IE6 fix
            if ($.browser.msie && parseInt($.browser.version) <= 6) top = top + $(window).scrollTop();
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

    // Shortuct functions
    jAlert = function(message, title, callback) {
        $.popup.alert(message, title, callback);
    }

    jConfirm = function(message, title, callback) {
        $.popup.confirm(message, title, callback);
    };

    jPrompt = function(message, value, title, callback) {
        $.popup.prompt(message, value, title, callback);
    };

})(jQuery);