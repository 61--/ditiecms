//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-8 11:52:52
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;

namespace DTCMS.Entity
{
	/// <summary>
	/// 实体类 SYS_Template
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
		/// TemplateID
		/// </summary>
		public int TemplateID
		{
			set { _templateID = value; }
			get { return _templateID; }
		}
		/// <summary>
		/// TemplateName
		/// </summary>
		public string TemplateName
		{
			set { _templateName = value; }
			get { return _templateName; }
		}
		/// <summary>
		/// TemplateDirectory
		/// </summary>
		public string TemplateDirectory
		{
			set { _templateDirectory = value; }
			get { return _templateDirectory; }
		}
		/// <summary>
		/// isEnable
		/// </summary>
		public byte isEnable
		{
			set { _isEnable = value; }
			get { return _isEnable; }
		}
		/// <summary>
		/// CreateDateTime
		/// </summary>
		public DateTime CreateDateTime
		{
			set { _createDateTime = value; }
			get { return _createDateTime; }
		}
		/// <summary>
		/// TemplateImg
		/// </summary>
		public string TemplateImg
		{
			set { _templateImg = value; }
			get { return _templateImg; }
		}
		/// <summary>
		/// Author
		/// </summary>
		public string Author
		{
			set { _author = value; }
			get { return _author; }
		}
		#endregion
	}
}
