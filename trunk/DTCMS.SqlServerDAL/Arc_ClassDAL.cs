using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.IDAL;
using DTCMS.Entity;
namespace DTCMS.SqlServerDAL
{
    public class Arc_ClassDAL:IDAL_Arc_Class
    {

        #region IDAL_Arc_Class 成员
        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns></returns>
        public  bool Exists(int CID, string filedName, string filedValue)
        {
            return true;
        }
        /// <summary>
        /// 添加栏目
        /// </summary>
        /// <param name="model">栏目实体对象</param>
        /// <returns></returns>
        public int Add(Arc_Class model)
        {
            return 1;
        }
        /// <summary>
        /// 更新栏目
        /// </summary>
        /// <param name="model">栏目实体对象</param>
        /// <returns></returns>
        public int Update(Arc_Class model)
        {
            return 1;
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns></returns>
        public int Delete(int CID)
        {
            return 1;
        }
        /// <summary>
        /// 得到一条数据
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        public   Arc_Class GetModel(int CID)
        {
            Arc_Class model=new  Arc_Class();
            return model;
        }

        #endregion
    }
}
