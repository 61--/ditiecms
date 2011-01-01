using System;

namespace Tuan.Entity
{
	/// <summary>
	/// 实体类 SubTuan
	/// </summary>
	public class SubTuan
	{
		public SubTuan()
		{ }

		#region Model
		private int _subTuanID;
		private int _siteID;
		private int _cityID;
		private string _subTuanUrl;
		/// <summary>
		/// SubTuanID
		/// </summary>
		public int SubTuanID
		{
			set { _subTuanID = value; }
			get { return _subTuanID; }
		}
		/// <summary>
		/// SiteID
		/// </summary>
		public int SiteID
		{
			set { _siteID = value; }
			get { return _siteID; }
		}
		/// <summary>
		/// CityID
		/// </summary>
		public int CityID
		{
			set { _cityID = value; }
			get { return _cityID; }
		}
		/// <summary>
		/// SubTuanUrl
		/// </summary>
		public string SubTuanUrl
		{
			set { _subTuanUrl = value; }
			get { return _subTuanUrl; }
		}
		#endregion
	}
}
