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
	/// 实体类 AttachMent
	/// </summary>
	public class AttachMent
	{
		public AttachMent()
		{ }

		#region Model
		private int _attachMentID;
		private byte _attribute;
		private string _displayName;
		private string _attachMentPath;
		private int _attachMentSize;
		private string _abbrPhotoPath;
		private string _pubLisher;
		private DateTime _addDate;
		private string _photoDescription;
		/// <summary>
		/// AttachMentID
		/// </summary>
		public int AttachMentID
		{
			set { _attachMentID = value; }
			get { return _attachMentID; }
		}
		/// <summary>
		/// Attribute
		/// </summary>
		public byte Attribute
		{
			set { _attribute = value; }
			get { return _attribute; }
		}
		/// <summary>
		/// DisplayName
		/// </summary>
		public string DisplayName
		{
			set { _displayName = value; }
			get { return _displayName; }
		}
		/// <summary>
		/// AttachMentPath
		/// </summary>
		public string AttachMentPath
		{
			set { _attachMentPath = value; }
			get { return _attachMentPath; }
		}
		/// <summary>
		/// AttachMentSize
		/// </summary>
		public int AttachMentSize
		{
			set { _attachMentSize = value; }
			get { return _attachMentSize; }
		}
		/// <summary>
		/// AbbrPhotoPath
		/// </summary>
		public string AbbrPhotoPath
		{
			set { _abbrPhotoPath = value; }
			get { return _abbrPhotoPath; }
		}
		/// <summary>
		/// PubLisher
		/// </summary>
		public string PubLisher
		{
			set { _pubLisher = value; }
			get { return _pubLisher; }
		}
		/// <summary>
		/// AddDate
		/// </summary>
		public DateTime AddDate
		{
			set { _addDate = value; }
			get { return _addDate; }
		}
		/// <summary>
		/// PhotoDescription
		/// </summary>
		public string PhotoDescription
		{
			set { _photoDescription = value; }
			get { return _photoDescription; }
		}
		#endregion
	}
}
