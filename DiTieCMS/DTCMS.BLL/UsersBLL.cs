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
using DTCMS.Common;
using DTCMS.Entity;
using DTCMS.IDAL;
using DTCMS.DALFactory;

namespace DTCMS.BLL
{
    /// <summary>
    /// 业务逻辑类 Users
    /// </summary>
    public class UsersBLL
    {
        private readonly IDAL_Users dal = DataAccess.CreateFactoryDAL<IDAL_Users>("UsersDAL");
        public UsersBLL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Add(Users model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Users model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条用户数据
        /// </summary>
        /// <param name="UID">UID</param>
        /// <returns>返回影响行数</returns>
        public int Delete(int UID)
        {
            return dal.Delete(UID);
        }

        /// <summary>
        /// 批量删除用户
        /// </summary>
        /// <param name="UID">用户ID，多个ID用,号隔开</param>
        /// <returns>返回影响行数</returns>
        public int Delete(string UID)
        {
            return dal.Delete(UID);
        }

        /// <summary>
        /// 批量审核用户
        /// </summary>
        /// <param name="UID">用户ID，多个ID用,号隔开</param>
        /// <returns>返回影响行数</returns>
        public int VerifyUsers(string UID)
        {
            return dal.VerifyUsers(UID);
        }

        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="UID">UID</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int UID, string filedName, string filedValue)
        {
            return dal.Exists(UID, filedName, filedValue);
        }

        /// <summary>
        /// 用户登录检测
        /// </summary>
        public Users CheckLogin(string userName, string pwd, bool isAdmin)
        {
            return dal.CheckLogin(userName, pwd, isAdmin);
        }

        /// <summary>
        /// 更新用户登录信息
        /// </summary>
        public void UpdateLoginInfo(int userID, string lastloginIP)
        {
            dal.UpdateLoginInfo(userID, lastloginIP, DateTime.Now);
        }

        /// <summary>
        /// 得到一个用户对象实体
        /// </summary>
        /// <param name="UID">UID</param>
        /// <returns>实体对象</returns>
        public Users GetModel(int UID)
        {
            return dal.GetModel(UID);
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        public List<Users> GetList(out int count)
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
        public List<Users> GetPageList(int pageSize, int pageIndex, out int count)
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
        public string GetUserJsonData(int curPage, int pageSize, string sortValue)
        {
            int pagecount;
            if (sortValue == null || sortValue.Length == 0)
            {
                sortValue = "UID DESC";
            }
            DataTable dt = GetPageList("UID", curPage, pageSize, "UID,UserName,Email,RoleName,RegisterIP,RegisterTime,IsVerify", sortValue, null, out pagecount);
            if (dt != null)
            {
                return Utils.DataTableToJson(dt, pagecount).ToString();
            }
            else
            {
                return "{totalRecord:0,dataTable:[]}";
            }
        }
    }
}
