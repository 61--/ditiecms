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
        /// -- 字符串缓存实现的通用分页存储过程(转自邹建)  
        /// </summary>
        /// <param name="tbname">要分页显示的表名，可以使用表联合  </param>
        /// <param name="FieldKey">用于定位记录的主键(惟一键)字段,只能是单个字段  </param>
        /// <param name="PageCurrent">要显示的页码  </param>
        /// <param name="PageSize">每页的大小(记录数)  </param>
        /// <param name="FieldShow">以逗号分隔的要显示的字段列表,如果不指定,则显示所有字段  </param>
        /// <param name="FieldOrder">用于指定排序顺序  </param>
        /// <param name="Where">查询条件  </param>
        /// <param name="PageCount">总页数  </param>
        /// <returns></returns>
        public DataTable GetDataTable(string FieldKey, int PageCurrent, int PageSize
            , string FieldShow, string FieldOrder, string Where, out int PageCount)
        {
            return dalArticle.GetDataTable("V_DT_Arc_Article",FieldKey,PageCurrent,PageSize
                ,FieldShow,FieldOrder,Where,out PageCount);
        }

        /// <summary>
        /// 获取DataTable，并转换成Joson数据
        /// </summary>
        public string CreateArticleTableJoan()
        {
            int pagecount;
            DataTable dt = GetDataTable("ID", 1, 20, "ID,Title,ClassName,AddDate,IsChecked", "ID DESC", null, out pagecount); 
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
