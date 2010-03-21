//-------------------------------------------------
// jQuery DataGrid Plugin
// Version 1.0
// Author LinPanxing (http://www.91aspx.com/)
// LastUpdate 2009-3-16
//-------------------------------------------------
(function($) {
    $.fn.gridview = function(p) {
        p = $.extend({
            jsondata: null,
            fields: null,
            rowhandler: null,
            usepager: true,
            pagesize: 15,
            curpage: 1
        }, p);

        //生成数据列表
        var tab = $("#dataList");
        var totalRecord = p.totalrecord;
        if (totalRecord > 0) {
            var tbhtml = [];
            //格式化json数据
            $.each(p.jsondata, function(i, n) {
                tbhtml.push('<tr onmouseover="changeClassName(this,\'highLightRow\')" onmouseout="changeClassName(this,\'\')"');
                if (p.rowhandler != null) {
                    tbhtml.push(' onmousedown="', p.rowhandler, '"');
                }
                tbhtml.push(' id="', n[p.primarykey], '">');
                if (p.checkbox.visible) {
                    tbhtml.push('<td><input type="checkbox" name="items" value="', n[p.primarykey], '" /></td>');
                }
                if (p.rownumber.visible) {
                    if (p.rownumber.increase) {
                        tbhtml.push('<td>', i + 1, '</td>');
                    }
                    else {
                        tbhtml.push('<td>', n[p.primarykey], '</td>');
                    }
                }
                $.each(p.fields, function(x, m) {
                    tbhtml.push('<td');
                    tbhtml.push(m.align == null ? '>' : ' align="' + m.align + '">');
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
        } else {
            $("#dataList").html("<tr><td colspan=" + p.colspan + " style='height:" + p.pagesize * 27 + "px' class='nodata'>没有要加载的数据！</td></tr>");
        }

        //生成分页按钮
        if (p.usepager) {
            var curPage = p.curpage;
            var pageSize = p.pagesize;
            var totalPage = Math.ceil(totalRecord / pageSize);
            if (totalPage > 0) {
                $("#totalPage").html(totalPage);
                //设置开始、结束记录
                var startRecord;
                var endRecord;
                $("#curPage").val(curPage);
                startRecord = (curPage - 1) * pageSize + 1;
                endRecord = Math.min(curPage * pageSize, totalRecord);
                $("#pPageStat").html("显示第" + startRecord + "条&nbsp;-&nbsp;第" + endRecord + "条记录，共" + totalRecord + "条记录");
                //设置按钮
                if (curPage == 1) {
                    $("#pFirst").attr("class", "pFirst_dis");
                    $("#pPrev").attr("class", "pPrev_dis");
                } else {
                    $("#pFirst").attr("class", "pFirst");
                    $("#pPrev").attr("class", "pPrev");
                }
                if (curPage == totalPage) {
                    $("#pNext").attr("class", "pNext_dis");
                    $("#pLast").attr("class", "pLast_dis");
                } else {
                    $("#pNext").attr("class", "pNext");
                    $("#pLast").attr("class", "pLast");
                }
            } else {
                $("#pPageStat").html("");
                $("#curPage").val(0);
                $("#pNext").attr("class", "pNext_dis");
                $("#pLast").attr("class", "pLast_dis");
            }
        } else {
            if (totalRecord > 0) {
                $("#pPageStat").html("显示第1条&nbsp;-&nbsp;第" + totalRecord + "条记录，共" + totalRecord + "条记录");
            } else {
                $("#pPageStat").html("");
            }
        }
    };
})(jQuery);
