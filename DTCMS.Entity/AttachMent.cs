//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-7 23:34:18
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;

namespace DTCMS.Entity
{
	/// <summary>
	/// 实体类 AttachMent
	/// </summary>
	public class AttachMent
	{
		public AttachMent()
		{ }

		#region Model
		private int _attachMentID;
		private int _attachMentAttribute;
		private string _attachMentDisplayName;
		private string _attachMentPath;
		private string _attachMentSize;
		private string _abbrPhotoPath;
		private string _pubLisher;
		private DateTime _addDate;
		private string _photoDescription;
		/// <summary>
		/// 附件ID
		/// </summary>
		public int AttachMentID
		{
			set { _attachMentID = value; }
			get { return _attachMentID; }
		}
		/// <summary>
		/// 附件类型属性，1图片、2视频、3音频、4flash、5附件、6其它
		/// </summary>
		public int AttachMentAttribute
		{
			set { _attachMentAttribute = value; }
			get { return _attachMentAttribute; }
		}
		/// <summary>
		/// 附件显示名称，上传文件名称
		/// </summary>
		public string AttachMentDisplayName
		{
			set { _attachMentDisplayName = value; }
			get { return _attachMentDisplayName; }
		}
		/// <summary>
		/// 附件地址
		/// </summary>
		public string AttachMentPath
		{
			set { _attachMentPath = value; }
			get { return _attachMentPath; }
		}
		/// <summary>
		/// 附件大小
		/// </summary>
		public string AttachMentSize
		{
			set { _attachMentSize = value; }
			get { return _attachMentSize; }
		}
		/// <summary>
		/// 缩略图地址
		/// </summary>
		public string AbbrPhotoPath
		{
			set { _abbrPhotoPath = value; }
			get { return _abbrPhotoPath; }
		}
		/// <summary>
		/// 发布者
		/// </summary>
		public string PubLisher
		{
			set { _pubLisher = value; }
			get { return _pubLisher; }
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime AddDate
		{
			set { _addDate = value; }
			get { return _addDate; }
		}
		/// <summary>
		/// 附件描述
		/// </summary>
		public string PhotoDescription
		{
			set { _photoDescription = value; }
			get { return _photoDescription; }
		}
		#endregion
	}
}
