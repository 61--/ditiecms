using System;

namespace DTCMS.Entity
{
    /// <summary>
	/// 实体类DT_Modules 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class Modules
	{
        public Modules()
		{}
		#region Entity
		private int _id;
		private int _moduleid;
		private int _parentid;
		private string _name;
		private string _ename;
		private int? _moduledepth;
		private string _moduleurl;
		private string _target;
		private string _description;
		private DateTime? _createtime;
		private int? _isquickmenu;
		private int? _issystem;
		private int? _isenable;
		private int? _orderid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 模块ID
		/// </summary>
		public int ModuleID
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		/// <summary>
		/// 模块父ID
		/// </summary>
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 模块名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 模块英文名
		/// </summary>
		public string EName
		{
			set{ _ename=value;}
			get{return _ename;}
		}
		/// <summary>
		/// 模块深度，1为顶级模块分类
		/// </summary>
		public int? ModuleDepth
		{
			set{ _moduledepth=value;}
			get{return _moduledepth;}
		}
		/// <summary>
		/// 模块URL地址
		/// </summary>
		public string ModuleURL
		{
			set{ _moduleurl=value;}
			get{return _moduleurl;}
		}
		/// <summary>
		/// 页面打开方式
		/// </summary>
		public string Target
		{
			set{ _target=value;}
			get{return _target;}
		}
		/// <summary>
		/// 模块说明
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 是否添加到快捷菜单
		/// </summary>
		public int? IsQuickMenu
		{
			set{ _isquickmenu=value;}
			get{return _isquickmenu;}
		}
		/// <summary>
		/// 是否系统导航
		/// </summary>
		public int? IsSystem
		{
			set{ _issystem=value;}
			get{return _issystem;}
		}
		/// <summary>
		/// 是否应用
		/// </summary>
		public int? IsEnable
		{
			set{ _isenable=value;}
			get{return _isenable;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
        }
        #endregion Entity

    }
}
