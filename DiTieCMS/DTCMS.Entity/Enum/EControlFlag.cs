//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-17 16:32:43
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;

namespace DTCMS.Entity.Enum
{
    /// <summary>
    /// 系统操作权限枚举
    /// </summary>
    public enum EControlFlag : int
    {
        /// <summary>
        /// 浏览权限
        /// </summary>
        Browse = 1,

        /// <summary>
        /// 添加权限
        /// </summary>
        Add = 2,

        /// <summary>
        /// 编辑权限
        /// </summary>
        Edit = 4,

        /// <summary>
        /// 删除权限
        /// </summary>
        Delete = 8,

        /// <summary>
        /// 审核权限
        /// </summary>
        Verify = 16,

        /// <summary>
        /// 下载权限
        /// </summary>
        Download = 32,

        /// <summary>
        /// 备份权限
        /// </summary>
        Backup = 64,

        /// <summary>
        /// 授权权限
        /// </summary>
        Grant = 128,

        /// <summary>
        /// 系统设置权限
        /// </summary>
        System = 256
    }
}
