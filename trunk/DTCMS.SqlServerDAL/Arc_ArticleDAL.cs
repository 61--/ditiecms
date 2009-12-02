using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.IDAL;
using DTCMS.DBUtility;
using DTCMS.Entity;
namespace DTCMS.SqlServerDAL
{
    public class Arc_ArticleDAL:IDAL_Arc_Article
    {
        #region IDAL_Arc_Article 成员

        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int CID, string filedName, string filedValue)
        {
            string strSql = "select count(CID) from DT_Arc_Class where CID!={0} ";
            if (filedName != "")
            {
                strSql += " and {1}='{2}'";
                return SqlHelper.ExecuteNonQuery(string.Format(strSql, CID, filedName, filedValue)) > 0;
            }
            else
            {
                return SqlHelper.ExecuteNonQuery(string.Format(strSql, CID)) > 0;
            }
        }

        public int Add(Arc_Article model)
        {
            return 1;//throw new NotImplementedException();
        }

        public int Update(Arc_Article model)
        {
            return 1; //throw new NotImplementedException();
        }

        public int Delete(int ID)
        {
            return 1; //throw new NotImplementedException();
        }

        public Arc_Article GetModel(int ID)
        {
            Arc_Article model =new Arc_Article ();
            return model; //throw new NotImplementedException();
        }

        #endregion
    }
}
