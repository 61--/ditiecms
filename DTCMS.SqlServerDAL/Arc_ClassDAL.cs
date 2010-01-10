//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-10 19:36:36
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
        /// <param name="model">栏目实体对象</param>
		/// <returns>返回影响行数</returns>
		public int Add(Arc_Class model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO " + tablePrefix + "Arc_Class(");
            strSql.Append("ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,ClassContent)");
			strSql.Append(" VALUES (");
            strSql.Append("@ParentID,@Attribute,@ClassName,@ClassEName,@ClassType,@ClassDomain,@ClassPath,@IndexTemplet,@ListTemplet,@ArchiveTemplet,@IndexRule,@ListRule,@ArchiveRule,@ClassPage,@Description,@IsHidden,@IsHtml,@CheckLevel,@IsContribute,@IsComment,@Readaccess,@SiteID,@AddDate,@Relation,@OrderID,@ImgUrl,@Keywords,@CrossID,@ClassContent)");
			SqlParameter[] cmdParms = {
				AddInParameter("@ParentID", SqlDbType.Int, 4, model.ParentID),
				AddInParameter("@Attribute", SqlDbType.TinyInt, 1, model.Attribute),
				AddInParameter("@ClassName", SqlDbType.NVarChar, 100, model.ClassName),
				AddInParameter("@ClassEName", SqlDbType.VarChar, 50, model.ClassEName),
				AddInParameter("@ClassType", SqlDbType.TinyInt, 1, model.ClassType),
				AddInParameter("@ClassDomain", SqlDbType.VarChar, 255, model.ClassDomain),
				AddInParameter("@ClassPath", SqlDbType.VarChar, 255, model.ClassPath),
				AddInParameter("@IndexTemplet", SqlDbType.VarChar, 255, model.IndexTemplet),
				AddInParameter("@ListTemplet", SqlDbType.VarChar, 255, model.ListTemplet),
				AddInParameter("@ArchiveTemplet", SqlDbType.VarChar, 255, model.ArchiveTemplet),
				AddInParameter("@IndexRule", SqlDbType.VarChar, 255, model.IndexRule),
				AddInParameter("@ListRule", SqlDbType.VarChar, 255, model.ListRule),
				AddInParameter("@ArchiveRule", SqlDbType.VarChar, 255, model.ArchiveRule),
				AddInParameter("@ClassPage", SqlDbType.TinyInt, 1, model.ClassPage),
				AddInParameter("@Description", SqlDbType.NVarChar, 500, model.Description),
				AddInParameter("@IsHidden", SqlDbType.TinyInt, 1, model.IsHidden),
				AddInParameter("@IsHtml", SqlDbType.TinyInt, 1, model.IsHtml),
				AddInParameter("@CheckLevel", SqlDbType.TinyInt, 1, model.CheckLevel),
				AddInParameter("@IsContribute", SqlDbType.TinyInt, 1, model.IsContribute),
				AddInParameter("@IsComment", SqlDbType.TinyInt, 1, model.IsComment),
				AddInParameter("@Readaccess", SqlDbType.SmallInt, 2, model.Readaccess),
				AddInParameter("@SiteID", SqlDbType.TinyInt, 1, model.SiteID),
				AddInParameter("@AddDate", SqlDbType.DateTime, 8, model.AddDate),
				AddInParameter("@Relation", SqlDbType.VarChar, 100, model.Relation),
				AddInParameter("@OrderID", SqlDbType.SmallInt, 2, model.OrderID),
				AddInParameter("@ImgUrl", SqlDbType.VarChar, 255, model.ImgUrl),
				AddInParameter("@Keywords", SqlDbType.NVarChar, 200, model.Keywords),
				AddInParameter("@CrossID", SqlDbType.VarChar, 200, model.CrossID),
				AddInParameter("@ClassContent", SqlDbType.NVarChar, 8, model.ClassContent)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		/// <param name="model">实体对象</param>
		/// <returns>返回影响行数</returns>
		public int Update(Arc_Class model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE " + tablePrefix + "Arc_Class SET ");
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
			strSql.Append("ClassContent=@ClassContent");
			strSql.Append(" WHERE CID=@CID");
			SqlParameter[] cmdParms = {
				AddInParameter("@ParentID", SqlDbType.Int, 4, model.ParentID),
				AddInParameter("@Attribute", SqlDbType.TinyInt, 1, model.Attribute),
				AddInParameter("@ClassName", SqlDbType.NVarChar, 100, model.ClassName),
				AddInParameter("@ClassEName", SqlDbType.VarChar, 50, model.ClassEName),
				AddInParameter("@ClassType", SqlDbType.TinyInt, 1, model.ClassType),
				AddInParameter("@ClassDomain", SqlDbType.VarChar, 255, model.ClassDomain),
				AddInParameter("@ClassPath", SqlDbType.VarChar, 255, model.ClassPath),
				AddInParameter("@IndexTemplet", SqlDbType.VarChar, 255, model.IndexTemplet),
				AddInParameter("@ListTemplet", SqlDbType.VarChar, 255, model.ListTemplet),
				AddInParameter("@ArchiveTemplet", SqlDbType.VarChar, 255, model.ArchiveTemplet),
				AddInParameter("@IndexRule", SqlDbType.VarChar, 255, model.IndexRule),
				AddInParameter("@ListRule", SqlDbType.VarChar, 255, model.ListRule),
				AddInParameter("@ArchiveRule", SqlDbType.VarChar, 255, model.ArchiveRule),
				AddInParameter("@ClassPage", SqlDbType.TinyInt, 1, model.ClassPage),
				AddInParameter("@Description", SqlDbType.NVarChar, 500, model.Description),
				AddInParameter("@IsHidden", SqlDbType.TinyInt, 1, model.IsHidden),
				AddInParameter("@IsHtml", SqlDbType.TinyInt, 1, model.IsHtml),
				AddInParameter("@CheckLevel", SqlDbType.TinyInt, 1, model.CheckLevel),
				AddInParameter("@IsContribute", SqlDbType.TinyInt, 1, model.IsContribute),
				AddInParameter("@IsComment", SqlDbType.TinyInt, 1, model.IsComment),
				AddInParameter("@Readaccess", SqlDbType.SmallInt, 2, model.Readaccess),
				AddInParameter("@SiteID", SqlDbType.TinyInt, 1, model.SiteID),
				AddInParameter("@AddDate", SqlDbType.DateTime, 8, model.AddDate),
				AddInParameter("@Relation", SqlDbType.VarChar, 100, model.Relation),
				AddInParameter("@OrderID", SqlDbType.SmallInt, 2, model.OrderID),
				AddInParameter("@ImgUrl", SqlDbType.VarChar, 255, model.ImgUrl),
				AddInParameter("@Keywords", SqlDbType.NVarChar, 200, model.Keywords),
				AddInParameter("@CrossID", SqlDbType.VarChar, 200, model.CrossID),
				AddInParameter("@ClassContent", SqlDbType.NVarChar, 8, model.ClassContent),
				AddInParameter("@CID", SqlDbType.Int, 4, model.CID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

        /// <summary>
        /// 根据ID和值更新一条数据
        /// </summary>
        /// <param name="CID">编号ID</param>
        /// <param name="value">更新值（fieldName=fieldValue）</param>
        /// <returns>返回影响行数</returns>
        public int Update(int CID, string value)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE " + tablePrefix + "Arc_Class SET ");
            strSql.Append(value);
            strSql.Append(" WHERE CID=");
            strSql.Append(CID);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString());
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		/// <param name="CID">编号ID</param>
		/// <returns>返回影响行数</returns>
		public int Delete(int CID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM " + tablePrefix + "Arc_Class");
			strSql.Append(" WHERE CID=@CID");
			SqlParameter[] cmdParms = {
				AddInParameter("@CID", SqlDbType.Int, 4, CID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		/// <param name="CID">编号ID</param>
		/// <param name="filedName">字段名称</param>
		/// <param name="filedValue">字段值</param>
		/// <returns>存在返回true，不存在返回false</returns>
		public bool Exists(int CID, string filedName, string filedValue)
		{
			StringBuilder strSql = new StringBuilder();
			if (filedName != "")
			{
				strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Arc_Class");
				strSql.Append(" WHERE CID<>{0} AND {1}={2}");
				return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), CID, filedName, filedValue))) > 0;
			}
			else
			{
				strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Arc_Class");
				strSql.Append(" WHERE CID={0}");
				return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), CID))) > 0;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		/// <param name="CID">编号ID</param>
		/// <returns>实体对象</returns>
		public Arc_Class GetModel(int CID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,ClassContent FROM " + tablePrefix + "Arc_Class");
			strSql.Append(" WHERE CID=@CID");
			SqlParameter[] cmdParms = {
				AddInParameter("@CID", SqlDbType.Int, 4, CID)};

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
		/// <param name="count">返回记录总数</param>
		/// <returns>对象泛型集合</returns>
		public List<Arc_Class> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,ClassContent FROM " + tablePrefix + "Arc_Class");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Arc_Class> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		/// <param name="pageSize">分页大小</param>
		/// <param name="pageIndex">当前页</param>
		/// <param name="count">返回记录数</param>
		/// <returns>分页对象泛型集合</returns>
		public List<Arc_Class> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,ClassContent FROM " + tablePrefix + "Arc_Class");
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
		/// <param name="dr">SqlDataReader对象</param>
		/// <returns>实体对象</returns>
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
			model.ClassContent = dbHelper.GetString(dr["ClassContent"]);
			return model;
		}

		/// <summary>
		/// 由SqlDataReader得到泛型数据列表
		/// </summary>
		/// <param name="dr">SqlDataReader对象</param>
		/// <param name="count">返回记录数</param>
		/// <returns>对象泛型集合</returns>
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
		/// <param name="dr">SqlDataReader对象</param>
		/// <param name="pageSize">分页大小</param>
		/// <param name="pageIndex">当前页数</param>
		/// <param name="count">返回记录总数</param>
		/// <returns>分页对象泛型集合</returns>
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
