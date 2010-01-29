//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-9 0:23:01
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;

namespace DTCMS.Entity
{
	/// <summary>
	/// 实体类 Sys_Template
	/// </summary>
	public class Sys_Template
	{
		public Sys_Template()
		{ }

		#region Model
		private int _templateID;
		private string _templateName;
		private string _templateDirectory;
		private byte _isEnable;
		private DateTime _createDateTime;
		private string _templateImg;
		private string _author;

		/// <summary>
		/// 模板主键
		/// </summary>
		public int TemplateID
		{
			set { _templateID = value; }
			get { return _templateID; }
		}
		/// <summary>
		/// 模板名称
		/// </summary>
		public string TemplateName
		{
			set { _templateName = value; }
			get { return _templateName; }
		}
		/// <summary>
		/// 模板目录
		/// </summary>
		public string TemplateDirectory
		{
			set { _templateDirectory = value; }
			get { return _templateDirectory; }
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public byte IsEnable
		{
			set { _isEnable = value; }
			get { return _isEnable; }
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateDateTime
		{
			set { _createDateTime = value; }
			get { return _createDateTime; }
		}
		/// <summary>
		/// 模板缩略图
		/// </summary>
		public string TemplateImg
		{
			set { _templateImg = value; }
			get { return _templateImg; }
		}
		/// <summary>
		/// 作者
		/// </summary>
		public string Author
		{
			set { _author = value; }
			get { return _author; }
		}
		#endregion
	}
}
