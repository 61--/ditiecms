/*
*此插件用于将xml格式化成html中的table，并可加入行或列的事件，使用了服务器端分页（分页方式需自定义）
*作者：wyongzhi  http://wyz.67ge.com
*最后更新：2009年9月16日14:20:35  alpha3
*/
(function($) {
    $.fn.gridview = function(p) {
        p = $.extend({
            jsondata: null,
            fields: null,
            rowhandler: null,
            usepager: true,
            pagesize: 15
        }, p);

        //this.empty();
        var tab = $("#dataList");
        var tbhtml = [];

        //格式化json数据
        $.each(p.jsondata, function(i, n) {
            tbhtml.push('<tr onmouseover="changeClassName(this,\'highLightRow\')" onmouseout="changeClassName(this,\'\')"');
            if (p.rowhandler != null) {
                tbhtml.push(' onmousedown="', p.rowhandler, '"');
            }
            tbhtml.push('>');
            if (p.checkbox.visible) {
                tbhtml.push('<td><input type="checkbox" name="items" value="', n[p.checkbox.id], '" /></td>');
            }
            if (p.rowsindex.visible) {
                if (p.rowsindex.id == null) {
                    tbhtml.push('<td>', i + 1, '</td>');
                } else {
                    tbhtml.push('<td>', n[p.rowsindex.id], '</td>');
                }
            }
            $.each(p.fields, function(x, m) {
                tbhtml.push('<td>');
                tbhtml.push(m.dataFormat == null ? n[m.name] : m.dataFormat(n));
                tbhtml.push('</td>');
            });
            tbhtml.push('</tr>');
            if (p.rowhandler != null) {
                _rowhandler = p.rowhandler;
                $(this).bind("" + _rowhandler.event + "", function(e) {
                    _rowhandler.fn();
                    e.preventDefault();
                    e.stopPropagation();
                });
            }
        });
        tab.html(tbhtml.join(''));
        //alert(tab.html())
        /*
        //end 格式化json数据
        if (_rowcount == -1) $("<tr><td colspan=\"" + _fieldslength.toString() + "\" class=\"NoRecordTip\">无记录</td></tr>").appendTo(tab);
        //tab.appendTo(this);
        //this.prepend(fieldsmenu);
        pager = $.extend({ display: false, pagesize: 5, pageNav: 8, curPage: parseInt(_curpage) - 1 }, pager);
        var tis = this; //传递指向dom的this，否则this会指向ajax
        if (pager.display) {
        $("<div class=\"pagination\"></div>").appendTo(tis).pagination(parseInt(_totalcount), {
        num_edge_entries: 2,
        num_display_entries: pager.pageNav,
        items_per_page: pager.pagesize,
        current_page: pager.curPage,
        callback: function(page_id, jq) {
        var o = pager.objAjax;
        var ajaxdata = (typeof (o.data) == "undefined" ? "" : o.data);
        //如果url中没有pagenum参数
        ajaxdata = ((ajaxdata).indexOf("pagenum") <= 0 ? ajaxdata + "&pagenum=1" : ajaxdata).toString();
        //替换url中的pagenum=
        ajaxdata = ajaxdata.replace(/\bpagenum=\d*\b/g, "pagenum=" + (parseInt(page_id) + 1).toString());
        var ajaxOpt = {
        url: o.url
        , type: o.type
        , success: function(x) { tis.gridview(x, opt, $.extend(pager, { curPage: page_id })); }
        , global: o.global
        , contentType: o.contentType
        , processData: o.processData
        , async: o.async
        , dataType: o.dataType
        , data: ajaxdata
        , error: o.error
        , timeout: o.timeout
        , cache: o.cache
        };
        $.ajax(ajaxOpt);
        }
        });
        };*/
    };
})(jQuery);

//jquery pagination
/**
* This jQuery plugin displays pagination links inside the selected elements.
*
* @author Gabriel Birke (birke *at* d-scribe *dot* de)
* @version 1.1
* @param {int} maxentries Number of entries to paginate
* @param {Object} opts Several options (see README for documentation)
* @return {Object} jQuery Object
*/
jQuery.fn.pagination = function(maxentries, opts) {
    opts = jQuery.extend({
        items_per_page: 10,
        num_display_entries: 10,
        current_page: 0,
        num_edge_entries: 0,
        link_to: "#",
        prev_text: "Prev",
        next_text: "Next",
        ellipse_text: "...",
        prev_show_always: true,
        next_show_always: true,
        callback: function() { return false; }
    }, opts || {});

    return this.each(function() {
        /**
        * Calculate the maximum number of pages
        */
        function numPages() {
            return Math.ceil(maxentries / opts.items_per_page);
        }

        /**
        * Calculate start and end point of pagination links depending on 
        * current_page and num_display_entries.
        * @return {Array}
        */
        function getInterval() {
            var ne_half = Math.ceil(opts.num_display_entries / 2);
            var np = numPages();
            var upper_limit = np - opts.num_display_entries;
            var start = current_page > ne_half ? Math.max(Math.min(current_page - ne_half, upper_limit), 0) : 0;
            var end = current_page > ne_half ? Math.min(current_page + ne_half, np) : Math.min(opts.num_display_entries, np);
            return [start, end];
        }

        /**
        * This is the event handling function for the pagination links. 
        * @param {int} page_id The new page number
        */
        function pageSelected(page_id, evt) {
            current_page = page_id;
            drawLinks();
            var continuePropagation = opts.callback(page_id, panel);
            if (!continuePropagation) {
                if (evt.stopPropagation) {
                    evt.stopPropagation();
                }
                else {
                    evt.cancelBubble = true;
                }
            }
            return continuePropagation;
        }

        /**
        * This function inserts the pagination links into the container element
        */
        function drawLinks() {
            panel.empty();
            var interval = getInterval();
            var np = numPages();
            // This helper function returns a handler function that calls pageSelected with the right page_id
            var getClickHandler = function(page_id) {
                return function(evt) { return pageSelected(page_id, evt); }
            }
            // Helper function for generating a single link (or a span tag if it'S the current page)
            var appendItem = function(page_id, appendopts) {
                page_id = page_id < 0 ? 0 : (page_id < np ? page_id : np - 1); // Normalize page id to sane value
                appendopts = jQuery.extend({ text: page_id + 1, classes: "" }, appendopts || {});
                if (page_id == current_page) {
                    var lnk = $("<span class='current'>" + (appendopts.text) + "</span>");
                }
                else {
                    var lnk = $("<a>" + (appendopts.text) + "</a>")
						.bind("click", getClickHandler(page_id))
						.attr('href', opts.link_to.replace(/__id__/, page_id));


                }
                if (appendopts.classes) { lnk.addClass(appendopts.classes); }
                panel.append(lnk);
            }
            // Generate "Previous"-Link
            if (opts.prev_text && (current_page > 0 || opts.prev_show_always)) {
                appendItem(current_page - 1, { text: opts.prev_text, classes: "prev" });
            }
            // Generate starting points
            if (interval[0] > 0 && opts.num_edge_entries > 0) {
                var end = Math.min(opts.num_edge_entries, interval[0]);
                for (var i = 0; i < end; i++) {
                    appendItem(i);
                }
                if (opts.num_edge_entries < interval[0] && opts.ellipse_text) {
                    jQuery("<span>" + opts.ellipse_text + "</span>").appendTo(panel);
                }
            }
            // Generate interval links
            for (var i = interval[0]; i < interval[1]; i++) {
                appendItem(i);
            }
            // Generate ending points
            if (interval[1] < np && opts.num_edge_entries > 0) {
                if (np - opts.num_edge_entries > interval[1] && opts.ellipse_text) {
                    jQuery("<span>" + opts.ellipse_text + "</span>").appendTo(panel);
                }
                var begin = Math.max(np - opts.num_edge_entries, interval[1]);
                for (var i = begin; i < np; i++) {
                    appendItem(i);
                }

            }
            // Generate "Next"-Link
            if (opts.next_text && (current_page < np - 1 || opts.next_show_always)) {
                appendItem(current_page + 1, { text: opts.next_text, classes: "next" });
            }
        }

        // Extract current_page from options
        var current_page = opts.current_page;
        // Create a sane value for maxentries and items_per_page
        maxentries = (!maxentries || maxentries < 0) ? 1 : maxentries;
        opts.items_per_page = (!opts.items_per_page || opts.items_per_page < 0) ? 1 : opts.items_per_page;
        // Store DOM element for easy access from all inner functions
        var panel = jQuery(this);
        // Attach control functions to the DOM element 
        this.selectPage = function(page_id) { pageSelected(page_id); }
        this.prevPage = function() {
            if (current_page > 0) {
                pageSelected(current_page - 1);
                return true;
            }
            else {
                return false;
            }
        }
        this.nextPage = function() {
            if (current_page < numPages() - 1) {
                pageSelected(current_page + 1);
                return true;
            }
            else {
                return false;
            }
        }
        // When all initialisation is done, draw the links
        drawLinks();
    });
}