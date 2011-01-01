(function($) {
  $.fn.formToArray = function(semantic) {
    var a = [];
    if (this.length == 0) return a;

    var form = this[0];
    var els = semantic ? form.getElementsByTagName('*') : form.elements;
    if (!els) return a;
    for(var i=0, max=els.length; i < max; i++) {
      var el = els[i];
      var n = el.name;
      if (!n) continue;

      if (semantic && form.clk && el.type == "image") {
        // handle image inputs on the fly when semantic == true
        if(!el.disabled && form.clk == el) {
          a.push({name: n, value: $(el).val()});
          a.push({name: n+'.x', value: form.clk_x}, {name: n+'.y', value: form.clk_y});
        }
        continue;
      }

      var v = $.fieldValue(el, true);
      if (v && v.constructor == Array) {
        for(var j=0, jmax=v.length; j < jmax; j++)
          a.push({name: n, value: v[j]});
      }
      else if (v !== null && typeof v != 'undefined')
        a.push({name: n, value: v});
    }

    if (!semantic && form.clk) {
      // input type=='image' are not found in elements array! handle it here
      var $input = $(form.clk), input = $input[0], n = input.name;
      if (n && !input.disabled && input.type == 'image') {
        a.push({name: n, value: $input.val()});
        a.push({name: n+'.x', value: form.clk_x}, {name: n+'.y', value: form.clk_y});
      }
    }
    return a;
  };

  $.fieldValue = function(el, successful) {
    var n = el.name, t = el.type, tag = el.tagName.toLowerCase();
    if (typeof successful == 'undefined') successful = true;

    if (successful && (!n || el.disabled || t == 'reset' || t == 'button' ||
      (t == 'checkbox' || t == 'radio') && !el.checked ||
      (t == 'submit' || t == 'image') && el.form && el.form.clk != el ||
      tag == 'select' && el.selectedIndex == -1))
        return null;

    if (tag == 'select') {
      var index = el.selectedIndex;
      if (index < 0) return null;
      var a = [], ops = el.options;
      var one = (t == 'select-one');
      var max = (one ? index+1 : ops.length);
      for(var i=(one ? index : 0); i < max; i++) {
        var op = ops[i];
        if (op.selected) {
          var v = op.value;
          if (!v) // extra pain for IE...
            v = (op.attributes && op.attributes['value'] && !(op.attributes['value'].specified)) ? op.text : op.value;
          if (one) return v;
          a.push(v);
        }
      }
      return a;
    }
    return el.value;
  };
})(jQuery);
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
        message: function(msg, top, left, autoClose, callback) {
            this.ID = 'msg';
            this.popType = 'msg';
            this.title = '';
            this.isPopup = false;
            this.autoClose = autoClose || 0;
            this.width = 240;
            this.height = 30;
            this.top = top || (document.documentElement.clientHeight / 2 + document.documentElement.scrollTop - this.height / 2);
            this.left = left || (document.documentElement.clientWidth / 2 + document.documentElement.scrollLeft - this.width / 2);
            this.callback = callback;
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
                $.popup._reposition();
            }
        },

        _hide: function() {
            if ($("#_Popup_" + this.ID).length > 0) {
                $("#_Popup_" + this.ID).fadeOut(500);
                $.popup._maintainPosition(false);
            }
            if (this.callback) {
                this.callback();
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
    _showMessage = function(msg, elem, autoClose, callback) {
        var top;
        var left;
        if (elem == null) {
            top = null;
        } else {
            var middle = ($(elem).height() - 30) / 2;
            top = $(elem).offset().top + (middle > 0 ? middle : 0);
            var center = ($(elem).width() - 240) / 2;
            left = $(elem).offset().left + (center > 0 ? center : 0);
        }
        $.popup.message(msg, top, left, autoClose, callback);
    }

    showSuccess = function(msg, elem, autoClose, callback) {
        _showMessage('<img src="/images/admin/success.gif" /> ' + msg, elem, autoClose || 2, callback);
        $("#_Popup_msg").css({ color: "#000", background: "#FCFFF5", border: "1px #62C202 solid" });
    }

    showError = function(msg, elem, autoClose) {
        _showMessage('<img src="/images/admin/error.gif" /> ' + msg, elem, autoClose || 2);
        $("#_Popup_msg").css({ color: "#C00", background: "#FFF0ED", border: "1px #E89494 solid" });
    }

    showLoading = function(msg, elem) {
        var loadingMsg = msg || '正在加载数据，请稍候...';
        _showMessage('<img src="/images/admin/loading.gif" /> ' + loadingMsg, elem, 0);
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