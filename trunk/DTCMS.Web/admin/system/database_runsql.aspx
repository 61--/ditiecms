<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="database_runsql.aspx.cs"
    Inherits="DTCMS.Web.admin.system.database_runsql" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>运行SQL语句</title>
    <link href="../css/blue_body.css" type="text/css" rel="StyleSheet" />
    <link href="/inc/dialog/dialog.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript" src="../js/jquery-1.3.2-vsdoc2.js"></script>

    <script type="text/javascript" src="/inc/dialog/dialog.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            名称(M)：</div>
        <div>
            <select id="slt_sysobject" runat="server" style="width: 320px; background: #F7FAFC;"
                onchange="getSysColumn(this.options[selectedIndex].value)">
            </select><br />
        </div>
        <div style="height: 3px;">
        </div>
        <div>
            列(O)：</div>
        <div id="column_name" style="border: solid 1px #000; width: 493px; height: 142px;
            float: left; overflow: auto;">
        </div>
    </div>    
    <div style="clear: both; height: 8px;">
    </div>
    <div>
        SQL语句：(L)</div>
    <div>
        <textarea id="txts_sql" rows="6" cols="68" style="background: #F7FAFC;"></textarea></div>
    <div>
        <div style="height: 3px;">
        </div>
        <button type="button" class="b1">
            确定</button>
        <button type="button" class="b1">
            取消</button></div>
    </form>

    <script type="text/javascript">
        function getSysColumn(tablename) {
            var callback = function(res) {
                if (res.error) {
                    alert("请求错误，请刷新页面重试！\n" + res.error.Message);
                    return;
                }
                showSysColumn(res.value);
            }
            DTCMS.Web.admin.system.database_runsql.GetSysObjectDataTable(tablename, callback);
        }
        function showSysColumn(html) {
            $("#column_name").html(html);
        }
    </script>

</body>
</html>
