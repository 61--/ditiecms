using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.DALFactory;
using DTCMS.IDAL;
using DTCMS.Entity;
using System.Data;

namespace DTCMS.BLL
{
    public class AttachMentBLL
    {
        IDAL_AttachMent dalAttachMent = DataAccess.CreateFactoryDAL<IDAL_AttachMent>("AttachMentDAL");

        /// <summary>
        /// 增加附件数据
        /// </summary>
        public int Add(AttachMent model)
        {
            return dalAttachMent.Add(model);
        }

        /// <summary>
        /// 更新附件数据
        /// </summary>
        public int Update(AttachMent model)
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
        public AttachMent GetModel(int AttachMentID) 
        {
            return dalAttachMent.GetModel(AttachMentID);
        }

        /// <summary>
        /// 获取附件-图片
        /// </summary>
        /// <param name="pageCurrent">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="where">查询条件</param>
        /// <param name="pagecount">总页数</param>
        /// <returns></returns>
        public DataTable GetAttachmentList(int pageCurrent,int pageSize,string where,out int pagecount)
        {
            return dalAttachMent.GetDataTable("DT_AttachMent","AttachMentID",pageCurrent,pageSize
                ,"AttachMentDisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription"
                , "AddDate desc", where,out pagecount);
        }
        
    }
}
