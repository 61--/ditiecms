using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Entity
{    
   /// <summary>
	/// 实体类DT_Atr_AttachMent 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class Atr_AttachMent
	{
        public Atr_AttachMent()
		{ }
        #region Entity
        private int _attachmentid;
		private int _attachmentattribute;
		private string _attachmentdisplayname;
		private string _attachmentpath;
		private string _attachmentsize;
		private string _abbrphotopath;
		private string _publisher;
		private DateTime? _adddate;
		private string _photodescription;
		/// <summary>
		/// 附件ID
		/// </summary>
		public int AttachMentID
		{
			set{ _attachmentid=value;}
			get{return _attachmentid;}
		}
		/// <summary>
		/// 附件类型属性，1图片、2视频、3音频、4flash、5附件、6其它
		/// </summary>
		public int AttachMentAttribute
		{
			set{ _attachmentattribute=value;}
			get{return _attachmentattribute;}
		}
		/// <summary>
		/// 附件显示名称，上传文件名称
		/// </summary>
		public string AttachMentDisplayName
		{
			set{ _attachmentdisplayname=value;}
			get{return _attachmentdisplayname;}
		}
		/// <summary>
		/// 附件地址
		/// </summary>
		public string AttachMentPath
		{
			set{ _attachmentpath=value;}
			get{return _attachmentpath;}
		}
		/// <summary>
		/// 附件大小
		/// </summary>
		public string AttachMentSize
		{
			set{ _attachmentsize=value;}
			get{return _attachmentsize;}
		}
		/// <summary>
		/// 缩略图地址
		/// </summary>
		public string AbbrPhotoPath
		{
			set{ _abbrphotopath=value;}
			get{return _abbrphotopath;}
		}
		/// <summary>
		/// 发布者
		/// </summary>
		public string PubLisher
		{
			set{ _publisher=value;}
			get{return _publisher;}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 附件描述
		/// </summary>
		public string PhotoDescription
		{
			set{ _photodescription=value;}
			get{return _photodescription;}
        }
        #endregion Entity

    }
}
