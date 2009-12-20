using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.DALFactory;
using DTCMS.IDAL;
using DTCMS.Entity;

namespace DTCMS.BLL
{
    public class Atr_AttachMentBLL
    {
        IDAL_Atr_AttachMent dalAttachMent = DataAccess.CreateFactoryDAL<IDAL_Atr_AttachMent>("Atr_AttachMentDAL");

        /// <summary>
        /// 增加附件数据
        /// </summary>
        public int Add(Atr_AttachMent model)
        {
            return dalAttachMent.Add(model);
        }

        /// <summary>
        /// 更新附件数据
        /// </summary>
        public int Update(Atr_AttachMent model)
        {
            return dalAttachMent.Update(model);
        }

        /// <summary>
        /// 删除附件数据
        /// </summary>
        public int Delete(string AttachMentID)
        {
            return dalAttachMent.Delete(AttachMentID);
        }
        /// <summary>
        /// 获取一个附件
        /// </summary>
        /// <param name="AttachMentID">附件ID</param>
        public Atr_AttachMent GetModel(int AttachMentID)
        {
            return dalAttachMent.GetModel(AttachMentID);
        }

        
    }
}
