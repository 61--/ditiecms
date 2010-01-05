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
    public class Sys_NavigateBLL
    {
        IDAL_Sys_Navigate dalSysNavigate = DataAccess.CreateFactoryDAL<IDAL_Sys_Navigate>("Sys_NavigateDAL");

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int NvaID)
        {
            return dalSysNavigate.Exists(NvaID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DT_SYS_Navigate model)
        {
            return dalSysNavigate.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(DT_SYS_Navigate model)
        {
            return dalSysNavigate.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string NID)
        {
            return dalSysNavigate.Delete(NID);
        }

        /// <summary>
        /// 获取导航菜单ID
        /// </summary>
        /// <returns></returns>
        public string GetNvaID()
        {
            string nvaid = Common.Utils.Sequence(10000000, 99999999);
            while (!Exists(Common.TypeConvert.StrToInt(nvaid)))
            {
                nvaid = Common.Utils.Sequence(10000000, 99999999);
            }
            return nvaid;
        }

        /// <summary>
        ///  获取导航菜单名称
        /// </summary>
        public string GetNvaName(string NvaID)
        {
            return dalSysNavigate.GetSingleFileName("Name", NvaID);
        }

        /// <summary>
        /// 获取导航菜单权限码
        /// </summary>
        /// <param name="NvaID"></param>
        /// <returns></returns>
        public string CopyrightCode(string NvaID)
        {
            return dalSysNavigate.GetSingleFileName("CopyrightCode", NvaID);
        }

    }
}
