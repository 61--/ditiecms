using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Globalization;

namespace call_back_demo
{
	/// <summary>
	/// Table_Tree_Share ��ժҪ˵����
	/// </summary>
	public class Table_Tree_Share : System.Web.UI.Page
	{
		string   strProvider   =   "packet size=4096;user id=tmp;data source=COFLY-CWZ;persist security info=True;initial catalog=test;password=tmp"; 
		private string rlt = string.Empty;
		protected System.Web.UI.WebControls.Panel Panel1;
		private string viewStateString= string.Empty;
		
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{

				Table tblItem = new Table();
				tblItem.ID = "table_1";			
				TableRow rowTitle_ = new TableRow();
				rowTitle_.ID = "tr_title";

				tblItem.Rows.Add(rowTitle_);

				Panel1.Controls.Add(tblItem);

				TableHeaderCell cell1_ = new TableHeaderCell();	
				cell1_.ID = "Cell1_title";
				TableHeaderCell cell2_ = new TableHeaderCell();	
				cell2_.ID = "Cell2_title";
				TableHeaderCell cell3_ = new TableHeaderCell();	
				cell3_.ID = "Cell3_title";

				rowTitle_.Cells.Add(cell1_);	
				rowTitle_.Cells.Add(cell2_);	
				rowTitle_.Cells.Add(cell3_);

				tblItem.CssClass = "treetable";				
				tblItem.Width = Unit.Percentage(100);
				cell1_.Text = "������1";					
				cell2_.Text = "������2";
				cell3_.Text = "������3";
				cell1_.Width = Unit.Percentage(30);
				cell2_.Width = Unit.Percentage(50);
				cell3_.Width = Unit.Percentage(20);
			
				GetData_TableTree("",tblItem,"0");


			}
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		///////////////////////////////////////////////////////////////////////////////


		private void GetData_TableTree(string P_Recursion_Count,Table P_Table,string P_Ind_ID)
		{
			SqlConnection myConnection = new SqlConnection(strProvider);

			SqlCommand myCommand = new SqlCommand();
			myCommand.Connection = myConnection;
			myCommand.CommandText = "select * from Tabletree where parent_id ="+P_Ind_ID;
			//myCommand.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter adp = new SqlDataAdapter(myCommand);
			DataSet mds = new DataSet();
			adp.Fill(mds, "Values");
			myConnection.Close();

			for(int i=0;i<mds.Tables[0].Rows.Count;i++)
			{
				
				TableRow myrow = new TableRow();
				
				myrow.ID = "TR"+P_Recursion_Count + "_"+i.ToString();
				P_Table.Rows.Add(myrow);

				
				TableCell cell_1 = new TableCell();	
				cell_1.ID = "CellOne"+P_Recursion_Count + "_"+i.ToString();
				TableCell cell_2 = new TableCell();	
				cell_2.ID = "CellTwo"+P_Recursion_Count + "_"+i.ToString();
				TableCell cell_3 = new TableCell();	
				cell_3.ID = "CellThree"+P_Recursion_Count + "_"+i.ToString();

				myrow.Cells.Add(cell_1);	
				myrow.Cells.Add(cell_2);	
				myrow.Cells.Add(cell_3);

				if((mds.Tables[0].Rows[i]["has_child"].ToString() == "1"))
				{//���ӽڵ�
					cell_1.Text = BlankImageCount(P_Recursion_Count,"_")+
						"<img src='expand.gif' width='16' height='16' align='absmiddle'/>"+ 
						mds.Tables[0].Rows[i]["node_text"].ToString();
					cell_2.Text = "\\";
					cell_3.Text = "\\";
					myrow.Attributes.Add("style","CURSOR: pointer;");
					myrow.Attributes.Add("onclick","ShowHideChildren('" + myrow.ID + "');");

					GetData_TableTree(P_Recursion_Count + "_"+i.ToString(),P_Table,mds.Tables[0].Rows[i]["node_id"].ToString());					
				}
				else
				{//���ӽڵ�
					cell_1.Text = BlankImageCount(P_Recursion_Count,"_") +
						"<img src='blank.gif' width='16' height='100%' align='absmiddle'/>"+
						mds.Tables[0].Rows[i]["node_text"].ToString();
					cell_2.Text = "\\";
					cell_3.Text = "\\";

					//DrawCellDetail( mds.Tables[0].Rows[i],myrow,P_Recursion_Count + "_"+i.ToString());

				}
				myrow.Style["background"] = "#" +  ColorCount(P_Recursion_Count,"_");
			}			
		}


		private string BlankImageCount(string Source,string SubStr)
		{
			int i,width;
			string BlankCount,buf;
			buf = Source; 
			BlankCount = "";
			width = 0;
			i = buf.IndexOf(SubStr);
			while (i >= 0)
			{
				width = width + 16;
				buf = buf.Remove(i,1);
				i = buf.IndexOf(SubStr);
			}
			BlankCount = "<img src='blank_1.gif' height='22' width='"+width.ToString()+"' class='button' align='absmiddle'/>";
				 
			return BlankCount;
		}

		private string ColorCount(string Source,string SubStr)
		{
			int i,count,RecNum;
			string buf,mycolor;
			buf = Source; 
			count = 0;
			mycolor = "";
			i = buf.IndexOf(SubStr);
			while (i >= 0)
			{
				count = count + 1;
				buf = buf.Remove(i,1);
				i = buf.IndexOf(SubStr);
			}
			RecNum = (count/2)*20;
			if((count % 2) == 0)
				mycolor = Convert.ToString(168+ RecNum,16)+Convert.ToString(208 + RecNum,16)+Convert.ToString(232 + RecNum,16);
			else
				mycolor = Convert.ToString(254 - RecNum,16)+Convert.ToString(248 - RecNum,16)+Convert.ToString(232,16);
			return mycolor;

		}
	}
}
