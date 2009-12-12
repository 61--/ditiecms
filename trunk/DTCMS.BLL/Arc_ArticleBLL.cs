using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Common;
using DTCMS.DALFactory;
using DTCMS.IDAL;
using DTCMS.Entity;
namespace DTCMS.BLL
{
    public class Arc_ArticleBLL
    {
        IDAL_Arc_Article dalArticle = DataAccess.CreateFactoryDAL<IDAL_Arc_Article>("Arc_ArticleDAL");
        IDAL_Arc_Class dalClass = DataAccess.CreateFactoryDAL<IDAL_Arc_Class>("Arc_ClassDAL");

        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int CID, string filedName, string filedValue)
        {
            return dalArticle.Exists(CID, filedName, filedValue);
        }

        /// <summary>
        /// 添加文章
        /// </summary>
        /// <param name="Entity">栏目实体对象</param>
        /// <returns>返回影响行数，-1：栏目ID不存在，-2：文章标题为空,-3：文章已经存在</returns>
        public int Add(Arc_Article model)
        {            
            return dalArticle.Add(model);
        }

        /// <summary>
        /// 更新文章
        /// </summary>
        /// <param name="Entity">栏目实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Arc_Article model)
        {
            return dalArticle.Update(model);
        }

        /// <summary>
        /// 删除文章数据
        /// </summary>
        /// <param name="ID">文章编号</param>
        /// <returns>返回影响行数</returns>
        public int Delete(string ID)
        {
            return dalArticle.Delete(ID);
        }

        /// <summary>
        /// 得到文章一条数据
        /// </summary>
        /// <param name="CID">文章ID</param>
        /// <returns>文章实体</returns>
        public Arc_Article GetModel(int ID)
        {
            return dalArticle.GetModel(ID);
        }
        /// <summary>
        /// 根据栏目id 判断此栏目是否存在文章
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns>true存在,false不存在</returns>
        public bool ExistAtricleToClass(int CID)
        {
            return dalArticle.ExistAtricleToClass(CID);
        }
        /// <summary>
        /// 判断文章是否已经存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool ExistsArticleName(int ArticleID, string Title)
        {
            return dalArticle.ExistsArticleName(ArticleID, Title);
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="colist">-要查询出的字段列表,*表示全部字段</param>
        /// <param name="top">最多读取记录数 </param>
        /// <param name="pagesize">每页记录数</param>
        /// <param name="page">指定页</param>
        /// <param name="condition">查询条件</param>
        /// <param name="sql_key">用于排序的主键</param>
        /// <param name="col">-用于排序，如：id desc (多个id desc,dt asc)</param>
        /// <param name="orderby">排序,0-顺序,1-倒序</param>
        /// <param name="pages">总页数</param>
        /// <returns>数据表</returns>
        public DataTable GetDataTable(string collist, int top, int pagesize, int page
            , string condition, string sql_key, string col, int orderby, out int pagesum)
        {
            return dalArticle.GetDataTable("V_DT_Arc_Article", collist, top, pagesize, page, condition, sql_key, col, orderby, out pagesum);
        }

        /// <summary>
        /// 获取DataTable，并转换成Joson数据
        /// </summary>
        public string CreateArticleTableJoan()
        {
            int pagesum;
            DataTable dt = GetDataTable("ID,Title,ClassName,AddDate,IsChecked", 20, 20, 1, null, "ID", "id desc", 1, out pagesum);
            if (dt != null)
            {
                return Utils.DataTableToJson(dt).ToString();
            }
            else
            {
                return "";
            }
        }

    }
}
