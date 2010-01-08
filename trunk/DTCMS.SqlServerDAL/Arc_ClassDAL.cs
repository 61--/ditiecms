//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-9 0:23:01
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using DTCMS.Entity;
using DTCMS.IDAL;

namespace DTCMS.SqlServerDAL
{
	/// <summary>
	/// 数据访问类 Arc_Class
	/// </summary>
	public class Arc_ClassDAL : BaseDAL, IDAL_Arc_Class
	{
		public Arc_ClassDAL()
		{ }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Arc_Class model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO Arc_Class(");
            strSql.Append("Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content)");
			strSql.Append(" VALUES (");
            strSql.Append("@Attribute,@ClassName,@ClassEName,@ClassType,@ClassDomain,@ClassPath,@IndexTemplet,@ListTemplet,@ArchiveTemplet,@IndexRule,@ListRule,@ArchiveRule,@ClassPage,@Description,@IsHidden,@IsHtml,@CheckLevel,@IsContribute,@IsComment,@Readaccess,@SiteID,@AddDate,@Relation,@OrderID,@ImgUrl,@Keywords,@CrossID,@Content)");
			SqlParameter[] cmdParms = {
				AddInParameter("@Attribute", SqlDbType.Bit, model.Attribute),
				AddInParameter("@ClassName", SqlDbType.SmallInt, model.ClassName),
				AddInParameter("@ClassEName", SqlDbType.BigInt, model.ClassEName),
				AddInParameter("@ClassType", SqlDbType.Bit, model.ClassType),
				AddInParameter("@ClassDomain", SqlDbType.BigInt, model.ClassDomain),
				AddInParameter("@ClassPath", SqlDbType.BigInt, model.ClassPath),
				AddInParameter("@IndexTemplet", SqlDbType.BigInt, model.IndexTemplet),
				AddInParameter("@ListTemplet", SqlDbType.BigInt, model.ListTemplet),
				AddInParameter("@ArchiveTemplet", SqlDbType.BigInt, model.ArchiveTemplet),
				AddInParameter("@IndexRule", SqlDbType.BigInt, model.IndexRule),
				AddInParameter("@ListRule", SqlDbType.BigInt, model.ListRule),
				AddInParameter("@ArchiveRule", SqlDbType.BigInt, model.ArchiveRule),
				AddInParameter("@ClassPage", SqlDbType.Bit, model.ClassPage),
				AddInParameter("@Description", SqlDbType.SmallInt, model.Description),
				AddInParameter("@IsHidden", SqlDbType.Bit, model.IsHidden),
				AddInParameter("@IsHtml", SqlDbType.Bit, model.IsHtml),
				AddInParameter("@CheckLevel", SqlDbType.Bit, model.CheckLevel),
				AddInParameter("@IsContribute", SqlDbType.Bit, model.IsContribute),
				AddInParameter("@IsComment", SqlDbType.Bit, model.IsComment),
				AddInParameter("@Readaccess", SqlDbType.NChar, model.Readaccess),
				AddInParameter("@SiteID", SqlDbType.Bit, model.SiteID),
				AddInParameter("@AddDate", SqlDbType.Float, model.AddDate),
				AddInParameter("@Relation", SqlDbType.BigInt, model.Relation),
				AddInParameter("@OrderID", SqlDbType.NChar, model.OrderID),
				AddInParameter("@ImgUrl", SqlDbType.BigInt, model.ImgUrl),
				AddInParameter("@Keywords", SqlDbType.SmallInt, model.Keywords),
				AddInParameter("@CrossID", SqlDbType.BigInt, model.CrossID),
				AddInParameter("@Content", SqlDbType.SmallInt, model.Content)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Arc_Class model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE Arc_Class SET ");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("Attribute=@Attribute,");
			strSql.Append("ClassName=@ClassName,");
			strSql.Append("ClassEName=@ClassEName,");
			strSql.Append("ClassType=@ClassType,");
			strSql.Append("ClassDomain=@ClassDomain,");
			strSql.Append("ClassPath=@ClassPath,");
			strSql.Append("IndexTemplet=@IndexTemplet,");
			strSql.Append("ListTemplet=@ListTemplet,");
			strSql.Append("ArchiveTemplet=@ArchiveTemplet,");
			strSql.Append("IndexRule=@IndexRule,");
			strSql.Append("ListRule=@ListRule,");
			strSql.Append("ArchiveRule=@ArchiveRule,");
			strSql.Append("ClassPage=@ClassPage,");
			strSql.Append("Description=@Description,");
			strSql.Append("IsHidden=@IsHidden,");
			strSql.Append("IsHtml=@IsHtml,");
			strSql.Append("CheckLevel=@CheckLevel,");
			strSql.Append("IsContribute=@IsContribute,");
			strSql.Append("IsComment=@IsComment,");
			strSql.Append("Readaccess=@Readaccess,");
			strSql.Append("SiteID=@SiteID,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("Relation=@Relation,");
			strSql.Append("OrderID=@OrderID,");
			strSql.Append("ImgUrl=@ImgUrl,");
			strSql.Append("Keywords=@Keywords,");
			strSql.Append("CrossID=@CrossID,");
			strSql.Append("Content=@Content");
			strSql.Append(" WHERE CID=@CID");
			SqlParameter[] cmdParms = {
				AddInParameter("@ParentID", SqlDbType.NText, model.ParentID),
				AddInParameter("@Attribute", SqlDbType.Bit, model.Attribute),
				AddInParameter("@ClassName", SqlDbType.SmallInt, model.ClassName),
				AddInParameter("@ClassEName", SqlDbType.BigInt, model.ClassEName),
				AddInParameter("@ClassType", SqlDbType.Bit, model.ClassType),
				AddInParameter("@ClassDomain", SqlDbType.BigInt, model.ClassDomain),
				AddInParameter("@ClassPath", SqlDbType.BigInt, model.ClassPath),
				AddInParameter("@IndexTemplet", SqlDbType.BigInt, model.IndexTemplet),
				AddInParameter("@ListTemplet", SqlDbType.BigInt, model.ListTemplet),
				AddInParameter("@ArchiveTemplet", SqlDbType.BigInt, model.ArchiveTemplet),
				AddInParameter("@IndexRule", SqlDbType.BigInt, model.IndexRule),
				AddInParameter("@ListRule", SqlDbType.BigInt, model.ListRule),
				AddInParameter("@ArchiveRule", SqlDbType.BigInt, model.ArchiveRule),
				AddInParameter("@ClassPage", SqlDbType.Bit, model.ClassPage),
				AddInParameter("@Description", SqlDbType.SmallInt, model.Description),
				AddInParameter("@IsHidden", SqlDbType.Bit, model.IsHidden),
				AddInParameter("@IsHtml", SqlDbType.Bit, model.IsHtml),
				AddInParameter("@CheckLevel", SqlDbType.Bit, model.CheckLevel),
				AddInParameter("@IsContribute", SqlDbType.Bit, model.IsContribute),
				AddInParameter("@IsComment", SqlDbType.Bit, model.IsComment),
				AddInParameter("@Readaccess", SqlDbType.NChar, model.Readaccess),
				AddInParameter("@SiteID", SqlDbType.Bit, model.SiteID),
				AddInParameter("@AddDate", SqlDbType.Float, model.AddDate),
				AddInParameter("@Relation", SqlDbType.BigInt, model.Relation),
				AddInParameter("@OrderID", SqlDbType.NChar, model.OrderID),
				AddInParameter("@ImgUrl", SqlDbType.BigInt, model.ImgUrl),
				AddInParameter("@Keywords", SqlDbType.SmallInt, model.Keywords),
				AddInParameter("@CrossID", SqlDbType.BigInt, model.CrossID),
				AddInParameter("@Content", SqlDbType.SmallInt, model.Content),
				AddInParameter("@CID", SqlDbType.NText, model.CID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int CID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM Arc_Class ");
			strSql.Append(" WHERE CID=@CID");
			SqlParameter[] cmdParms = {
				AddInParameter("@CID", SqlDbType.NText, CID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT COUNT(1) FROM Arc_Class");
			strSql.Append(" WHERE CID=@CID");
			SqlParameter[] cmdParms = {
				AddInParameter("@CID", SqlDbType.NText, CID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Arc_Class GetModel(int CID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content FROM Arc_Class");
			strSql.Append(" WHERE CID=@CID");
			SqlParameter[] cmdParms = {
				AddInParameter("@CID", SqlDbType.NText, CID)};

			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), cmdParms))
			{
				if (dr.Read())
				{
					return GetModel(dr);
				}
				return null;
			}
		}

		/// <summary>
		/// 获取泛型数据列表
		/// </summary>
		public List<Arc_Class> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content FROM Arc_Class");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Arc_Class> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<Arc_Class> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content FROM Arc_Class");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Arc_Class> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region 私有方法，通常情况下无需修改
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Arc_Class GetModel(SqlDataReader dr)
		{
			Arc_Class model = new Arc_Class();
			model.CID = dbHelper.GetInt(dr["CID"]);
			model.ParentID = dbHelper.GetInt(dr["ParentID"]);
			model.Attribute = dbHelper.GetByte(dr["Attribute"]);
			model.ClassName = dbHelper.GetString(dr["ClassName"]);
			model.ClassEName = dbHelper.GetString(dr["ClassEName"]);
			model.ClassType = dbHelper.GetByte(dr["ClassType"]);
			model.ClassDomain = dbHelper.GetString(dr["ClassDomain"]);
			model.ClassPath = dbHelper.GetString(dr["ClassPath"]);
			model.IndexTemplet = dbHelper.GetString(dr["IndexTemplet"]);
			model.ListTemplet = dbHelper.GetString(dr["ListTemplet"]);
			model.ArchiveTemplet = dbHelper.GetString(dr["ArchiveTemplet"]);
			model.IndexRule = dbHelper.GetString(dr["IndexRule"]);
			model.ListRule = dbHelper.GetString(dr["ListRule"]);
			model.ArchiveRule = dbHelper.GetString(dr["ArchiveRule"]);
			model.ClassPage = dbHelper.GetByte(dr["ClassPage"]);
			model.Description = dbHelper.GetString(dr["Description"]);
			model.IsHidden = dbHelper.GetByte(dr["IsHidden"]);
			model.IsHtml = dbHelper.GetByte(dr["IsHtml"]);
			model.CheckLevel = dbHelper.GetByte(dr["CheckLevel"]);
			model.IsContribute = dbHelper.GetByte(dr["IsContribute"]);
			model.IsComment = dbHelper.GetByte(dr["IsComment"]);
			model.Readaccess = dbHelper.GetInt16(dr["Readaccess"]);
			model.SiteID = dbHelper.GetByte(dr["SiteID"]);
			model.AddDate = dbHelper.GetDateTime(dr["AddDate"]);
			model.Relation = dbHelper.GetString(dr["Relation"]);
			model.OrderID = dbHelper.GetInt16(dr["OrderID"]);
			model.ImgUrl = dbHelper.GetString(dr["ImgUrl"]);
			model.Keywords = dbHelper.GetString(dr["Keywords"]);
			model.CrossID = dbHelper.GetString(dr["CrossID"]);
			model.Content = dbHelper.GetString(dr["Content"]);
			return model;
		}

		/// <summary>
		/// 由SqlDataReader得到泛型数据列表
		/// </summary>
		private List<Arc_Class> GetList(SqlDataReader dr, out long count)
		{
			count = 0;
			List<Arc_Class> lst = new List<Arc_Class>();
			while (dr.Read())
			{
				count++;
				lst.Add(GetModel(dr));
			}
			return lst;
		}

		/// <summary>
		/// 由SqlDataReader得到分页泛型数据列表
		/// </summary>
		private List<Arc_Class> GetPageList(SqlDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

			count = 0;

			List<Arc_Class> lst = new List<Arc_Class>();
			while (dr.Read())
			{
				count++;
				if (count >= first && count <= last)
					lst.Add(GetModel(dr));
			}
			return lst;
		}
		#endregion
	}
}
