using System;

namespace DTCMS.Entity
{
    /// <summary>
	/// 实体类DT_SYS_QNavigate 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class DT_SYS_QNavigate
	{
		public DT_SYS_QNavigate()
		{}
		#region Model
		private int _qid;
		private string _qname;
		private string _filepath;
		private int? _issys;
		private int? _orderid;
		/// <summary>
		/// 
		/// </summary>
		public int QID
		{
			set{ _qid=value;}
			get{return _qid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QName
		{
			set{ _qname=value;}
			get{return _qname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FilePath
		{
			set{ _filepath=value;}
			get{return _filepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ISSys
		{
			set{ _issys=value;}
			get{return _issys;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		#endregion Model

	}
}
