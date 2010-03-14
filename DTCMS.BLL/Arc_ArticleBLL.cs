//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-10 19:36:36
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Entity;
using DTCMS.Common;
using DTCMS.IDAL;
using DTCMS.DALFactory;

namespace DTCMS.BLL
{
    /// <summary>
    /// 业务逻辑类 Arc_Article
    /// </summary>
    public class Arc_ArticleBLL
    {
        private readonly IDAL_Arc_Article dal = DataAccess.CreateFactoryDAL<IDAL_Arc_Article>("Arc_ArticleDAL");

        public Arc_ArticleBLL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Add(Arc_Article model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Arc_Article model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns>返回影响行数</returns>
        public int Delete(int ID)
        {
            return dal.Delete(ID);
        }

        /// <summary>
        /// 批量删除文章
        /// </summary>
        /// <param name="ID">文章ID，多个ID用,号隔开</param>
        /// <returns>返回影响行数</returns>
        public int Delete(string ID)
        {
            return dal.Delete(ID);
        }

        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int ID, string filedName, string filedValue)
        {
            return dal.Exists(ID, filedName, filedValue);
        }

        /// <summary>
        /// 根据栏目ID判断此栏目是否存在文章
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns>true存在,false不存在</returns>
        public bool ExistAtricleToClass(int CID)
        {

            return dal.ExistAtricleToClass(CID);
        }

        /// <summary>
        /// 判断文章是否已经存在
        /// </summary>
        /// <param name="ArticleID">添加ArticleID：-1</param>
        /// <param name="Title">文章标题</param>
        /// <returns>true存在,false不存在</returns>
        public bool ExistsArticleName(int ArticleID, string Title)
        {

            return dal.ExistsArticleName(ArticleID, Title);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns>实体对象</returns>
        public Arc_Article GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        public List<Arc_Article> GetList(out int count)
        {
            return dal.GetList(out count);
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="count">返回记录数</param>
        /// <returns>分页对象泛型集合</returns>
        public List<Arc_Article> GetPageList(int pageSize, int pageIndex, out int count)
        {
            if (pageSize <= 0)
                throw new Exception("每页数据条数必须大于0。");

            if (pageIndex <= 0)
                throw new Exception("页索引必须大于0。");

            return dal.GetPageList(pageSize, pageIndex, out count);
        }


        /// <summary>
        /// 字符串缓存实现的通用分页存储过程
        /// </summary>
        /// <param name="fieldKey">用于定位记录的主键(惟一键)字段,只能是单个字段</param>
        /// <param name="pageCurrent">要显示的页码</param>
        /// <param name="pageSize">每页的大小(记录数)</param>
        /// <param name="fieldShow">以逗号分隔的要显示的字段列表,如果不指定,则显示所有字段</param>
        /// <param name="fieldOrder">用于指定排序顺序</param>
        /// <param name="where">查询条件</param>
        /// <param name="pageCount">总页数</param>
        /// <returns></returns>
        public DataTable GetPageList(string fieldKey, int pageCurrent, int pageSize
            , string fieldShow, string fieldOrder, string where, out int pageCount)
        {
            return dal.GetPageList(fieldKey, pageCurrent, pageSize
                , fieldShow, fieldOrder, where, out pageCount);
        }

        /// <summary>
        /// 获取DataTable，并转换成Json格式数据
        /// </summary>
        public string GetArticleJsonData(int currentPage)
        {
            int pagecount;
            DataTable dt = GetPageList("ID", currentPage, 10, "A.ID,A.Title,C.ClassName,A.AddDate,A.IsVerify", "A.ID DESC", null, out pagecount);
            if (dt != null)
            {
                return Utils.DataTableToJson(dt, pagecount).ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
