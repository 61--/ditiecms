<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News_list.aspx.cs" Inherits="DTCMS.Web.admin.news.News_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表格</title>
    <link href="../css/blue_body.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        *
        {
            font-family: Tahoma, Arial, Helvetica, Sans-serif;
        }
        table
        {
            width: 700px;
            margin: 0px auto;
            font: Georgia 11px;
            font-size: 12px;
            color: #333333;
            text-align: center;
            border-collapse: collapse; /*细线表格*/
        }
        table td
        {
            border: 1px solid #999; /*细线条颜色*/
            height: 22px;
        }
        caption
        {
            text-align: center;
            font-size: 12px;
            font-weight: bold;
            margin: 0 auto;
        }
        tr.t1 td
        {
            background-color: #fff;
        }
        /* 交替行第一行的背景色 */tr.t2 td
        {
            background-color: #eee;
        }
        /* 交替行第二行的背景色 */tr.t3 td
        {
            background-color: #ccc;
        }
        /* 鼠标经过时的背景色 */th, tfoot tr td
        {
            font-weight: bold;
            text-align: center;
            background: #c5c5c5;
        }
        th
        {
            line-height: 30px;
            height: 30px;
        }
        tfoot tr td
        {
            background: #fff;
            line-height: 26px;
            height: 26px;
        }
        thead
        {
            border: 1px solid #999;
        }
        thead tr td
        {
            text-align: center;
        }
        #page
        {
            text-align: center;
            float: right;
        }
        #page a, #page a:visited
        {
            width: 60px;
            height: 22px;
            line-height: 22px;
            border: 1px black solid;
            display: block;
            float: left;
            margin: 0 3px;
            background: #c9c9c9;
            text-decoration: none;
        }
        #page a:hover
        {
            background: #c1c1c1;
            text-decoration: none;
        }
        .grayr
        {
            padding: 2px;
            font-size: 11px;
            background: #fff;
            float: right;
        }
        .grayr a
        {
            padding: 2px 5px;
            margin: 2px;
            color: #000;
            text-decoration: none; ;border:1px#c0c0c0solid;}
        .grayr a:hover
        {
            color: #000;
            border: 1px orange solid;
        }
        .grayr a:active
        {
            color: #000;
            background: #99ffff;
        }
        .grayr span.current
        {
            padding: 2px 5px;
            font-weight: bold;
            margin: 2px;
            color: #303030;
            background: #fff;
            border: 1px orange solid;
        }
        .grayr span.disabled
        {
            padding: 2px 5px;
            margin: 2px;
            color: #797979;
            background: #c1c1c1;
            border: 1px #c1c1c1 solid;
        }
        .style1
        {
            height: 30px;
        }
    </style>

    <script type="text/javascript">
<!--
        function selectAll() {
            if (this.checked == true) {
                checkAll('test');
            }
            else {
                clearAll('test');
            }
        }
        function checkAll(name) {
            var el = document.getElementsByTagName('input');
            var len = el.length;
            for (var i = 0; i < len; i++) {
                if ((el[i].type == "checkbox") && (el[i].name == name)) {
                    el[i].checked = true;
                }
            }
        }
        function clearAll(name) {
            var el = document.getElementsByTagName('input');
            var len = el.length;
            for (var i = 0; i < len; i++) {
                if ((el[i].type == "checkbox") && (el[i].name == name)) {
                    el[i].checked = false;
                }
            }
        }
-->
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="tab_menu" class="tabs">
            <ul>
                <li class="tab_on"><a href="javascript:;">后台首页</a></li>
            </ul>
        </div>
        <div id="content">
            <table>
                <thead>
                    <tr>
                        <th class="style1">
                            <input onclick="if(this.checked==true) { checkAll('test'); } else { clearAll('test'); }"
                                type="checkbox" value="" name="test" title="全选/取消" />
                        </th>
                        <th class="style1">
                            姓名
                        </th>
                        <th class="style1">
                            性别
                        </th>
                        <th class="style1">
                            年龄
                        </th>
                        <th class="style1">
                            生日
                        </th>
                        <th class="style1">
                            住址
                        </th>
                        <th class="style1">
                            电话
                        </th>
                        <th class="style1">
                            电邮
                        </th>
                        <th class="style1">
                            网址
                        </th>
                    </tr>
                </thead>
                <tbody id="tab">
                    <tr>
                        <td>
                            <input type="checkbox" value="a" name="test" />
                        </td>
                        <td>
                            刘四
                        </td>
                        <td>
                            男
                        </td>
                        <td>
                            29
                        </td>
                        <td>
                            1990/12/22
                        </td>
                        <td>
                            中国北京
                        </td>
                        <td>
                            13700000000
                        </td>
                        <td>
                            email@163.com
                        </td>
                        <td>
                            /
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="checkbox" value="a" name="test" />
                        </td>
                        <td>
                            刘四
                        </td>
                        <td>
                            男
                        </td>
                        <td>
                            29
                        </td>
                        <td>
                            1990/12/22
                        </td>
                        <td>
                            中国北京
                        </td>
                        <td>
                            13700000000
                        </td>
                        <td>
                            email@163.com
                        </td>
                        <td>
                            /
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="checkbox" value="a" name="test" />
                        </td>
                        <td>
                            刘四
                        </td>
                        <td>
                            男
                        </td>
                        <td>
                            29
                        </td>
                        <td>
                            1990/12/22
                        </td>
                        <td>
                            中国北京
                        </td>
                        <td>
                            13700000000
                        </td>
                        <td>
                            email@163.com
                        </td>
                        <td>
                            /
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="checkbox" value="a" name="test" />
                        </td>
                        <td>
                            刘四
                        </td>
                        <td>
                            男
                        </td>
                        <td>
                            29
                        </td>
                        <td>
                            1990/12/22
                        </td>
                        <td>
                            中国北京
                        </td>
                        <td>
                            13700000000
                        </td>
                        <td>
                            email@163.com
                        </td>
                        <td>
                            /
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="checkbox" value="a" name="test" />
                        </td>
                        <td>
                            刘四
                        </td>
                        <td>
                            男
                        </td>
                        <td>
                            29
                        </td>
                        <td>
                            1990/12/22
                        </td>
                        <td>
                            中国北京
                        </td>
                        <td>
                            13700000000
                        </td>
                        <td>
                            email@163.com
                        </td>
                        <td>
                            /
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="checkbox" value="a" name="test" />
                        </td>
                        <td>
                            刘四
                        </td>
                        <td>
                            男
                        </td>
                        <td>
                            29
                        </td>
                        <td>
                            1990/12/22
                        </td>
                        <td>
                            中国北京
                        </td>
                        <td>
                            13700000000
                        </td>
                        <td>
                            email@163.com
                        </td>
                        <td>
                            /
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="checkbox" value="a" name="test" />
                        </td>
                        <td>
                            刘四
                        </td>
                        <td>
                            男
                        </td>
                        <td>
                            29
                        </td>
                        <td>
                            1990/12/22
                        </td>
                        <td>
                            中国北京
                        </td>
                        <td>
                            13700000000
                        </td>
                        <td>
                            email@163.com
                        </td>
                        <td>
                            /
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="checkbox" value="a" name="test" />
                        </td>
                        <td>
                            刘四
                        </td>
                        <td>
                            男
                        </td>
                        <td>
                            29
                        </td>
                        <td>
                            1990/12/22
                        </td>
                        <td>
                            中国北京
                        </td>
                        <td>
                            13700000000
                        </td>
                        <td>
                            email@163.com
                        </td>
                        <td>
                            /
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="checkbox" value="a" name="test" />
                        </td>
                        <td>
                            刘四
                        </td>
                        <td>
                            男
                        </td>
                        <td>
                            29
                        </td>
                        <td>
                            1990/12/22
                        </td>
                        <td>
                            中国北京
                        </td>
                        <td>
                            13700000000
                        </td>
                        <td>
                            email@163.com
                        </td>
                        <td>
                            /
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <td>
                            <input onclick="if(this.checked==true) { checkAll('test'); } else { clearAll('test'); }"
                                type="checkbox" value="" name="test" title="全选/取消" />
                        </td>
                        <td colspan="8">
                           
                        </td>
                    </tr>
                </tfoot>
            </table>

            <script type="text/javascript">
<!--
                var Ptr = document.getElementById("tab").getElementsByTagName("tr");
                function $() {
                    for (i = 1; i < Ptr.length + 1; i++) {
                        Ptr[i - 1].className = (i % 2 > 0) ? "t1" : "t2";
                    }
                }
                window.onload = $;
                for (var i = 0; i < Ptr.length; i++) {
                    Ptr[i].onmouseover = function() {
                        this.tmpClass = this.className;
                        this.className = "t3";

                    };
                    Ptr[i].onmouseout = function() {
                        this.className = this.tmpClass;
                    };
                }
//-->
            </script>

        </div>
    </div>
    </form>
</body>
</html>
