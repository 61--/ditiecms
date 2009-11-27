<%@ Page language="c#" Codebehind="Table_Tree_Share.aspx.cs" AutoEventWireup="false" Inherits="call_back_demo.Table_Tree_Share" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>Table_Tree_Share</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
<style type=text/css>A:link { COLOR: #5f506d; TEXT-DECORATION: none }
	A:visited { COLOR: #5f506d; TEXT-DECORATION: none }
	A:hover { COLOR: #5f506d; TEXT-DECORATION: underline }
	INPUT.bottomline { BORDER-RIGHT: medium none; BORDER-TOP: medium none; BORDER-LEFT: medium none; BORDER-BOTTOM: silver 1px solid; BACKGROUND-COLOR: transparent }
	</style>

<script language=javascript>
		<!--
	var treetable_rowstate = new Array();
	var	ie=document.all;
	var	dom=document.getElementById;

	
			function GetRowChildren(rowId) 
			{
				el = document.getElementById(rowId);
				var arr = new Array();
				i = 0;
				while (true) {
					childRowId = rowId + '_' + i;
					childEl = document.getElementById(childRowId);
					if (childEl) {
					arr[i] = childRowId;
					} else {
					break;
					}
					i++;
				}
				return (arr);
			}
			

			function ShowHideChildren(rowId)
			{
				row_state = ((treetable_rowstate[rowId]) ? (treetable_rowstate[rowId]) : 1);
				if (row_state == 1)  
				{
				treetable_rowstate[rowId]=-1;
				CollapseRow(rowId);
			    
				return (false);
				}
				if (row_state == -1) 
				{
				treetable_rowstate[rowId]=1;
				ExpandRow(rowId);
				}
				
			}

			function ExpandRow(rowId)
			{
				var rowChildren,row_state;
				var i;
				row_state = ((treetable_rowstate[rowId]) ? (treetable_rowstate[rowId]) : 1);
				
				rowChildren = GetRowChildren(rowId);
				  
				if (rowChildren.length == 0) return (false);
				for (i = 0; i < rowChildren.length; i++) 
				{
				if(row_state == 1){
						document.getElementById(rowChildren[i]).style.display = "";
						ExpandRow(rowChildren[i]);
					}
				}
				RowChanged(rowId,row_state);
				return (true);
				
			}

			function CollapseRow(rowId)
			{
				var rowChildren,row_state;
				var i;
				row_state = ((treetable_rowstate[rowId]) ? (treetable_rowstate[rowId]) : 1);
				
				rowChildren = GetRowChildren(rowId);
				if (rowChildren.length == 0) return (false);
				for (i = 0; i < rowChildren.length; i++) 
				{
					//if ((row_state == -1)||(treetable_rowstate[rowId]==null)) 
					{
						document.getElementById(rowChildren[i]).style.display = "none";
						CollapseRow(rowChildren[i]);
					} 
				}
				RowChanged(rowId,row_state);
				return (true);
				
			}
			
			function RowChanged(rowId, state) {
				img_count = document.getElementById(rowId).getElementsByTagName('td')[0].getElementsByTagName('img').length-1;
				
				img_ = document.getElementById(rowId).getElementsByTagName('td')[0].getElementsByTagName('img')[img_count];
				if (state == 1) {
					img_.src = 'expand.gif';
				} else {
					img_.src = 'collapse.gif';
				}
			 }  
		-->
	</script>

<style type=text/css>
    .treetable { }
    .treetable TH { FONT-WEIGHT: bold; FONT-SIZE: 90%; PADDING-BOTTOM: 0px; MARGIN: 1px; COLOR: white; PADDING-TOP: 0px; HEIGHT: 18px; BACKGROUND-COLOR: #a8d0e8; TEXT-ALIGN: left }
    .treetable TD { PADDING-RIGHT: 0px; PADDING-LEFT: 0px; FONT-SIZE: 90%; PADDING-BOTTOM: 0px; MARGIN: 1px; PADDING-TOP: 0px; HEIGHT: 18px }
    .treetable TD.number { TEXT-ALIGN: right }
    .button { BORDER-RIGHT: medium none; BORDER-TOP: medium none; MARGIN: 0px; BORDER-LEFT: medium none; BORDER-BOTTOM: medium none }
    .treeparent { CURSOR: hand }
    </style>
</HEAD>
<body MS_POSITIONING="GridLayout">
<form id=Form1 method=post runat="server"><asp:panel 
id=Panel1 style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 248px" runat="server" Height="72px" Width="100%"><FONT 
face=ËÎÌו></FONT></asp:panel><FONT face=ËÎÌו></FONT><FONT face=ËÎÌו></FONT></form>
	
  </body>
</HTML>
