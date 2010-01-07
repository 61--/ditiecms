//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-7 23:34:18
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DTCMS.Entity;
using DTCMS.IDAL;

namespace DTCMS.SqlServerDAL
{
	/// <summary>
	/// 数据访问类 Arc_Class
	/// </summary>
	public class Arc_ClassDAL : BaseDAL, IDAL_Arc_Class
	{
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
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@Attribute", DbType.Byte, model.Attribute),
				dbHelper.CreateInDbParameter("@ClassName", DbType.String, model.ClassName),
				dbHelper.CreateInDbParameter("@ClassEName", DbType.String, model.ClassEName),
				dbHelper.CreateInDbParameter("@ClassType", DbType.Byte, model.ClassType),
				dbHelper.CreateInDbParameter("@ClassDomain", DbType.String, model.ClassDomain),
				dbHelper.CreateInDbParameter("@ClassPath", DbType.String, model.ClassPath),
				dbHelper.CreateInDbParameter("@IndexTemplet", DbType.String, model.IndexTemplet),
				dbHelper.CreateInDbParameter("@ListTemplet", DbType.String, model.ListTemplet),
				dbHelper.CreateInDbParameter("@ArchiveTemplet", DbType.String, model.ArchiveTemplet),
				dbHelper.CreateInDbParameter("@IndexRule", DbType.String, model.IndexRule),
				dbHelper.CreateInDbParameter("@ListRule", DbType.String, model.ListRule),
				dbHelper.CreateInDbParameter("@ArchiveRule", DbType.String, model.ArchiveRule),
				dbHelper.CreateInDbParameter("@ClassPage", DbType.Byte, model.ClassPage),
				dbHelper.CreateInDbParameter("@Description", DbType.String, model.Description),
				dbHelper.CreateInDbParameter("@IsHidden", DbType.Byte, model.IsHidden),
				dbHelper.CreateInDbParameter("@IsHtml", DbType.Byte, model.IsHtml),
				dbHelper.CreateInDbParameter("@CheckLevel", DbType.Byte, model.CheckLevel),
				dbHelper.CreateInDbParameter("@IsContribute", DbType.Byte, model.IsContribute),
				dbHelper.CreateInDbParameter("@IsComment", DbType.Byte, model.IsComment),
				dbHelper.CreateInDbParameter("@Readaccess", DbType.Int16, model.Readaccess),
				dbHelper.CreateInDbParameter("@SiteID", DbType.Byte, model.SiteID),
				dbHelper.CreateInDbParameter("@AddDate", DbType.String, model.AddDate),
				dbHelper.CreateInDbParameter("@Relation", DbType.String, model.Relation),
				dbHelper.CreateInDbParameter("@OrderID", DbType.Int16, model.OrderID),
				dbHelper.CreateInDbParameter("@ImgUrl", DbType.String, model.ImgUrl),
				dbHelper.CreateInDbParameter("@Keywords", DbType.String, model.Keywords),
				dbHelper.CreateInDbParameter("@CrossID", DbType.String, model.CrossID),
				dbHelper.CreateInDbParameter("@Content", DbType.String, model.Content)};

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
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ParentID", DbType.Int32, model.ParentID),
				dbHelper.CreateInDbParameter("@Attribute", DbType.Byte, model.Attribute),
				dbHelper.CreateInDbParameter("@ClassName", DbType.String, model.ClassName),
				dbHelper.CreateInDbParameter("@ClassEName", DbType.String, model.ClassEName),
				dbHelper.CreateInDbParameter("@ClassType", DbType.Byte, model.ClassType),
				dbHelper.CreateInDbParameter("@ClassDomain", DbType.String, model.ClassDomain),
				dbHelper.CreateInDbParameter("@ClassPath", DbType.String, model.ClassPath),
				dbHelper.CreateInDbParameter("@IndexTemplet", DbType.String, model.IndexTemplet),
				dbHelper.CreateInDbParameter("@ListTemplet", DbType.String, model.ListTemplet),
				dbHelper.CreateInDbParameter("@ArchiveTemplet", DbType.String, model.ArchiveTemplet),
				dbHelper.CreateInDbParameter("@IndexRule", DbType.String, model.IndexRule),
				dbHelper.CreateInDbParameter("@ListRule", DbType.String, model.ListRule),
				dbHelper.CreateInDbParameter("@ArchiveRule", DbType.String, model.ArchiveRule),
				dbHelper.CreateInDbParameter("@ClassPage", DbType.Byte, model.ClassPage),
				dbHelper.CreateInDbParameter("@Description", DbType.String, model.Description),
				dbHelper.CreateInDbParameter("@IsHidden", DbType.Byte, model.IsHidden),
				dbHelper.CreateInDbParameter("@IsHtml", DbType.Byte, model.IsHtml),
				dbHelper.CreateInDbParameter("@CheckLevel", DbType.Byte, model.CheckLevel),
				dbHelper.CreateInDbParameter("@IsContribute", DbType.Byte, model.IsContribute),
				dbHelper.CreateInDbParameter("@IsComment", DbType.Byte, model.IsComment),
				dbHelper.CreateInDbParameter("@Readaccess", DbType.Int16, model.Readaccess),
				dbHelper.CreateInDbParameter("@SiteID", DbType.Byte, model.SiteID),
				dbHelper.CreateInDbParameter("@AddDate", DbType.String, model.AddDate),
				dbHelper.CreateInDbParameter("@Relation", DbType.String, model.Relation),
				dbHelper.CreateInDbParameter("@OrderID", DbType.Int16, model.OrderID),
				dbHelper.CreateInDbParameter("@ImgUrl", DbType.String, model.ImgUrl),
				dbHelper.CreateInDbParameter("@Keywords", DbType.String, model.Keywords),
				dbHelper.CreateInDbParameter("@CrossID", DbType.String, model.CrossID),
				dbHelper.CreateInDbParameter("@Content", DbType.String, model.Content),
				dbHelper.CreateInDbParameter("@CID", DbType.Int32, model.CID)};

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
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@CID", DbType.Int32, CID)};

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
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@CID", DbType.Int32, CID)};

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
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@CID", DbType.Int32, CID)};

			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), cmdParms))
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
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
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
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Arc_Class> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region -------- 私有方法，通常情况下无需修改 --------
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Arc_Class GetModel(DbDataReader dr)
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
		/// 由DbDataReader得到泛型数据列表
		/// </summary>
		private List<Arc_Class> GetList(DbDataReader dr, out long count)
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
		/// 由DbDataReader得到分页泛型数据列表
		/// </summary>
		private List<Arc_Class> GetPageList(DbDataReader dr, int pageSize, int pageIndex, out long count)
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
