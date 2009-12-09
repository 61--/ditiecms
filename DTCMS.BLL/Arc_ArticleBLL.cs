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
            if (model.ClassID < 0 || (model.ClassID!=0 && !dalClass.Exists(model.ClassID,"","")))
            {//栏目不存在
                return -1;
            }
            if (model.Title.Trim() == "")
            {//文章标题为空
                return -2;
            }
            if (ExistsArticleName(-1, model.Title))
            {//文章已经存在
                return -3;
            }
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

    }
}
