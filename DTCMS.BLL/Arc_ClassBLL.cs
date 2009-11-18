using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.DALFactory;
using DTCMS.IDAL;
using DTCMS.Entity;
namespace DTCMS.BLL
{
    public class Arc_ClassBLL : BaseBLL
    {
        IDAL_Arc_Class dalArcClass = DataAccess.CreateFactoryDAL<IDAL_Arc_Class>("Arc_ClassDAL");
         /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns></returns>
        public bool Exists(int CID, string filedName, string filedValue)
        {
            try
            {
                return dalArcClass.Exists(CID, filedName, filedValue);
            }
            catch(Exception ex)
            {
                SetErrorMessage(ex);
                return false;
            }
        }
        public Arc_Class GetModel(int CID)
        {
           return   dalArcClass.GetModel(CID);
        }

        public int Add(Arc_Class model)
        {
            return dalArcClass.Add(model);
        }

        public int Update(Arc_Class model)
        {
            return dalArcClass.Update(model);
        }
    }
}
