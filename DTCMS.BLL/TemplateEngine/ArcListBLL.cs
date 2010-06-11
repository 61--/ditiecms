//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-04-15 22:54:33
// 功能描述: 
// 修改标识: 
// 修改描述: LinPanxing 修改于 2010-05-23 23:51:04
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Common;
using DTCMS.Entity.TemplateEngine;
using DTCMS.IDAL.TemplateEngine;
using DTCMS.DALFactory;

namespace DTCMS.BLL.TemplateEngine
{
    /// <summary>
    /// 业务逻辑类 ArcListBLL
    /// </summary>
    public class ArcListBLL
    {
        private readonly IDAL_ArcList dal = DataAccess.CreateFactoryDAL<IDAL_ArcList>("TemplateEngine.ArcListDAL");

        public ArcListBLL() { }

        /// <summary>
        /// 获取文章列表
        /// </summary>
        /// <param name="firstRecort">第一条记录</param>
        /// <param name="lastRecort">最后一条记录</param>
        /// <param name="channelType">栏目类型</param>
        /// <param name="strWhere">获取条件</param>
        /// <param name="orderBy">排序字段</param>
        /// <returns>文章泛型实体</returns>
        public List<Archive> GetArcList(int firstRecort, int lastRecort, string channelType, string strWhere, string orderBy)
        {
            switch (channelType)
            {
                case "1":
                case "article":
                    channelType = "Arc_Article";
                    break;
                case "2":
                case "soft":
                    channelType = "Arc_Soft";
                    break;
                default:
                    channelType = "Arc_Article";
                    break;
            }
            return dal.GetArcList(firstRecort, lastRecort, channelType, strWhere, orderBy);
        }

        /// <summary>
        /// 获取分页文档泛型数据列表
        /// </summary>
        /// <param name="channelID">栏目ID</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="pageIndex">当前页数</param>
        /// <returns></returns>
        public List<Archive> GetPageList(int channelID, int pageSize, int pageIndex)
        {
            return dal.GetPageList(channelID, "Arc_Article", pageSize, pageIndex);
        }

        /// <summary>
        /// 获取栏目列表
        /// </summary>
        /// <param name="row">获取条数</param>
        /// <param name="channelType">栏目类型</param>
        /// <param name="strWhere">获取条件</param>
        /// <returns>栏目泛型实体</returns>
        public List<Channel> GetChannelList(int row, string channelType, string strWhere)
        {
            switch (channelType)
            {
                case "1":
                case "article":
                    channelType = "1";
                    break;
                case "2":
                case "soft":
                    channelType = "2";
                    break;
            }
            if (channelType.Length != 0)
            {
                strWhere += " AND ClassType=" + channelType;
            }
            return dal.GetChannelList(row, strWhere);
        }

        /// <summary>
        /// 获取指定栏目下的文档总数（不包含未审核和回收站中的文档）
        /// </summary>
        /// <param name="channelID">栏目ID</param>
        /// <returns>文档总数</returns>
        public int GetArcCount(int channelID, string channelType)
        {
            switch (channelType)
            {
                case "1":
                case "article":
                    channelType = "Arc_Article";
                    break;
                case "2":
                case "soft":
                    channelType = "Arc_Soft";
                    break;
                default:
                    channelType = "Arc_Article";
                    break;
            }
            return dal.GetArcCount(channelID, channelType);
        }

        /// <summary>
        /// 获取指定栏目的类型
        /// </summary>
        /// <param name="channelID">栏目ID</param>
        /// <returns>栏目类型</returns>
        public string GetChannelType(int channelID)
        {
            int channelType = dal.GetChannelType(channelID);
            switch (channelType)
            {
                case 1:
                    return "Arc_Article";
                case 2:
                    return "Arc_Soft";
                default:
                    return "Arc_Article";
            }
        }
    }
}
