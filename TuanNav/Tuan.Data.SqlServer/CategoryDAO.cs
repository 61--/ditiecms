using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Tuan.Data;
using Tuan.Entity;

namespace Tuan.Data.SqlServer
{
    /// <summary>
    /// ���ݷ����� CategoryDAO
    /// </summary>
    public class CategoryDAO : Tuan.Data.DAO.CategoryDAO
    {
        /// <summary>
        /// ��ȡָ����ID��Ʒ���-1Ϊ��ȡ����
        /// </summary>
        public override IList<Category> GetList(int pid)
        {
            string strSql = "SELECT CategoryID,Ename,CName FROM TN_Category";

            if (pid > -1)
                strSql += " WHERE IsEnabled=1 AND PID=" + pid;

            using (SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, strSql))
            {
                IList<Category> list = new List<Category>();
                while (dr.Read())
                {
                    Category model = new Category();
                    model.CategoryID = SqlHelper.GetInt(dr["CategoryID"]);
                    model.Ename = SqlHelper.GetString(dr["Ename"]);
                    model.CName = SqlHelper.GetString(dr["CName"]);

                    list.Add(model);
                }
                return list;
            }
        }

        /// <summary>
        /// ��ȡ������Ʒ���
        /// </summary>
        public override DataTable GetDataList()
        {
            string strSql = "SELECT CategoryID AS ID,PID AS parentId,CName AS NAME FROM TN_Category WHERE IsEnabled=1 ORDER BY OrderID ASC";

            DataSet ds = SqlHelper.ExecuteQuery(CommandType.Text, strSql);
            if (ds != null & ds.Tables.Count > 0)
                return ds.Tables[0];
            else
                return null;
        }
    }
}