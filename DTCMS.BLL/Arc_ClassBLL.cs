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
    /// 业务逻辑类 Arc_Class
    /// </summary>
    public class Arc_ClassBLL
    {
        private readonly IDAL_Arc_Class dal = DataAccess.CreateFactoryDAL<IDAL_Arc_Class>("Arc_ClassDAL");

        public Arc_ClassBLL()
        { }

        /// <summary>
        /// 添加栏目
        /// </summary>
        /// <param name="model">栏目实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Add(Arc_Class model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一个栏目
        /// </summary>
        /// <param name="model">栏目实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Arc_Class model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新栏目排序
        /// </summary>
        /// <param name="cid">栏目ID</param>
        /// <param name="order">排序编号</param>
        /// <returns></returns>
        public int UpdateOrder(int cid, int order)
        {
            return dal.Update(cid, "OrderID=" + order);
        }

        /// <summary>
        /// 删除一个栏目
        /// </summary>
        /// <param name="CID">栏目ID</param>
        /// <returns>返回影响行数</returns>
        public int Delete(int CID)
        {
            return dal.Delete(CID);
        }

        /// <summary>
        /// 批量删除栏目
        /// </summary>
        /// <param name="ID">栏目ID，多个ID用,号隔开</param>
        /// <returns>返回影响行数</returns>
        public int Delete(string CID)
        {
            return dal.Delete(CID);
        }

        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="CID">CID</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int CID, string filedName, string filedValue)
        {
            return dal.Exists(CID, filedName, filedValue);
        }

        /// <summary>
        /// 得到一个栏目对象实体
        /// </summary>
        /// <param name="CID">栏目ID</param>
        /// <returns>栏目实体</returns>
        public Arc_Class GetModel(int CID)
        {
            return dal.GetModel(CID);
        }

        /// <summary>
        /// 获取栏目关系
        /// </summary>
        /// <param name="ParentID">父栏目ID</param>
        /// <returns>栏目关系</returns>
        public string GetRelation(int ParentID)
        {
            return dal.GetSingle("Relation", "Cid=" + ParentID) as string;
        }

        /// <summary>
        /// 获取栏目深度
        /// </summary>
        /// <returns>栏目深度</returns>
        public int GetClassDepth(int ParentID)
        {
            string sRelation = GetRelation(ParentID);

            if (sRelation == "")
            {
                return 1;
            }
            return sRelation.Split('.').Length + 1;
        }

        /// <summary>
        /// 获取父栏目名称
        /// </summary>
        /// <param name="ParentID">父栏目ID</param>
        /// <returns>栏目名称</returns>
        public string GetClassName(int CID)
        {
            return dal.GetSingle("ClassName", "Cid=" + CID) as string;
        }

        /// <summary>
        /// 获取栏目DataTable，并转换成Joson数据
        /// </summary>
        /// <returns>Joson数据</returns>
        public string GetClassListToJson()
        {
            DataTable dt = dal.GetDataTable("CID,ClassName,ClassType,AddDate,OrderID,ParentID", "");
            if (dt != null)
            {
                return Utils.DataTableToJson(dt, dt.Rows.Count).ToString();
            }
            return "";
        }

        /// <summary>
        /// 获取DataTable，并转换成Joson数据，前台调用
        /// </summary>
        /// <returns>Joson数据</returns>
        public string GetDataTableToJsonAsHtml(string where)
        {
            DataTable dt = dal.GetDataTable("CID,ClassName,ParentID", where);
            if (dt != null)
            {
                return Utils.DataTableToJson(dt, dt.Rows.Count).ToString();
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
            return dal.ExistsChildNode(CID);
        }

        /// <summary>
        /// 判断栏目是否已经存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool ExistsClassName(int CID, string ClassName)
        {
            return dal.Exists(CID, "ClassName", ClassName);
        }

        /// <summary>
        /// 获取栏目下啦树列表
        /// </summary>
        /// <param name="parentID">父节点</param>
        /// <param name="count">返回记录总素</param>
        /// <returns></returns>
        public DataTable GetDropList(string where)
        {
            return dal.GetDataTable("CID as ID,ClassName as NAME,ParentID", where);
        }
        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        public List<Arc_Class> GetList(out int count)
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
        public List<Arc_Class> GetPageList(int pageSize, int pageIndex, out int count)
        {
            if (pageSize <= 0)
                throw new Exception("每页数据条数必须大于0。");

            if (pageIndex <= 0)
                throw new Exception("页索引必须大于0。");

            return dal.GetPageList(pageSize, pageIndex, out count);
        }

        /// <summary>
        /// 获取模板路径
        /// </summary>
        /// <param name="cid">栏目主键</param>
        /// <param name="tempType">模板类型（0封面，1列表，2详细页）</param>
        /// <returns></returns>
        public string GetTemplate(int cid, int tempType)
        {
            string filed = string.Empty;
            switch (tempType)
            {
                case 0:
                    filed = "IndexTemplet";
                    break;
                case 1:
                    filed = "ListTemplet";
                    break;
                case 2:
                    filed = "ArchiveTemplet";
                    break;
            }

            if (filed == string.Empty)
                return string.Empty;
            else
                return dal.GetSingle(filed, string.Format(" CID={0}", cid)) as string;
        }

        /// <summary>
        /// 获取单个字段数据
        /// </summary>
        /// <param name="cid">栏目编号</param>
        /// <param name="filed">要查询的栏目表字段</param>
        /// <returns></returns>
        public string GetSingle(string filed, int cid)
        {
            return dal.GetSingle(filed, string.Format(" CID={0}", cid)) as string;
        }
    }
}
