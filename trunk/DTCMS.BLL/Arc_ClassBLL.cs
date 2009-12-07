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
    public class Arc_ClassBLL
    {
        IDAL_Arc_Class dalArcClass = DataAccess.CreateFactoryDAL<IDAL_Arc_Class>("Arc_ClassDAL");

        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int CID, string filedName, string filedValue)
        {
           return dalArcClass.Exists(CID, filedName, filedValue);
        }

        /// <summary>
        /// 添加栏目
        /// </summary>
        /// <param name="Entity">栏目实体对象</param>
        /// <returns>返回影响行数,存在该栏目返回-3，否则返回影响的行数</returns>
        public int Add(Arc_Class model)
        {
            if (ExistsClassName(model.ClassName))
            {//存在该栏目
                return -3;
            }
            return dalArcClass.Add(model);
        }

        /// <summary>
        /// 更新栏目
        /// </summary>
        /// <param name="Entity">栏目实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Arc_Class model)
        {
            return dalArcClass.Update(model);
        }

        /// <summary>
        /// 更新排序
        /// </summary>
        /// <param name="cid">栏目ID</param>
        /// <param name="order">排序编号</param>
        /// <returns></returns>
        public int UpdateOrder(int cid, int order)
        {
            return dalArcClass.UpdateOrder(cid, order);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns>返回影响行数</returns>
        public int Delete(string CID)
        {
            return dalArcClass.Delete(CID);
        }

        /// <summary>
        /// 得到一条数据
        /// </summary>
        /// <param name="CID">栏目ID</param>
        /// <returns>栏目实体</returns>
        public Arc_Class GetModel(int CID)
        {
            return dalArcClass.GetModel(CID);
        }

        /// <summary>
        /// 获取栏目关系
        /// </summary>
        /// <param name="ParentID">父栏目ID</param>
        /// <returns>栏目关系</returns>
        public string GetRelation(int ParentID)
        {
            return dalArcClass.GetRelation(ParentID);
        }

        /// <summary>
        /// 获取栏目深度
        /// </summary>
        /// <returns>栏目深度</returns>
        public int GetClassDepth(int ParentID)
        {
            string iRelation = GetRelation(ParentID);

            if (iRelation == "")
            {
                return 1;
            }
            return iRelation.Split('.').Length + 1;
        }

        /// <summary>
        /// 获取父栏目名称
        /// </summary>
        /// <param name="ParentID">父栏目ID</param>
        /// <returns>栏目名称</returns>
        public string GetParentName(int ParentID)
        {
            return dalArcClass.GetParentName(ParentID);
        }

        /// <summary>
        /// 获取DataTable，并转换成Joson数据
        /// </summary>
        /// <returns>Joson数据</returns>
        public string  GetDataTableJoson()
        {
            DataTable dt= dalArcClass.GetDataTable("CID,ClassName,ClassType,AddDate,OrderID,ParentID");
            if (dt != null)
            {
              return  Utils.DataTableToJson(dt).ToString();
            }
            return "";
        }

        /// <summary>
        /// 判断当前节点是否存在子节点
        /// </summary>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        public bool ExistsChildNode(int CID)
        {
            return dalArcClass.ExistsChildNode(CID);
        }

        /// <summary>
        /// 判断栏目是否已经存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool ExistsClassName(string ClassName)
        {
            return dalArcClass.ExistsClassName(ClassName);
        }
    }
}
