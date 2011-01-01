using System;

namespace Tuan.Entity
{
    /// <summary>
    /// 实体类 TuanGou
    /// </summary>
    public class TuanGou
    {
        public TuanGou(){ }
        
        #region 实体属性
        private int _tuanID;
        private int _categoryID;
        private int _cityID;
        private int _userID;
        private int _siteID;
        private string _title;
        private string _description;
        private string _tuanDetail;
        private string _tuanUrl;
        private string _imageThumbUrl;
        private string _imageUrl;
        private decimal _marketPrice;
        private decimal _tuanPrice;
        private float _rebate;
        private string _merchantName;
        private string _merchantPhone;
        private string _merchantAddress;
        private double _longitude;
        private double _latitude;
        private int _totalCount;
        private int _buyCount;
        private int _clickCount;
        private int _commentCount;
        private int _pointCount;
        private DateTime _beginTime;
        private DateTime _endTime;
        private byte _statu;
        private byte _rank;
        private DateTime _addDate;
        private int _orderID;
          
        /// <summary>
        /// TuanID
        /// </summary>
        public int TuanID
        {
            set { _tuanID = value; }
            get { return _tuanID; }
        }
                  
        /// <summary>
        /// 类别编号
        /// </summary>
        public int CategoryID
        {
            set { _categoryID = value; }
            get { return _categoryID; }
        }
                  
        /// <summary>
        /// 城市区号
        /// </summary>
        public int CityID
        {
            set { _cityID = value; }
            get { return _cityID; }
        }
                  
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID
        {
            set { _userID = value; }
            get { return _userID; }
        }
                  
        /// <summary>
        /// 团购站点ID
        /// </summary>
        public int SiteID
        {
            set { _siteID = value; }
            get { return _siteID; }
        }
                  
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
                  
        /// <summary>
        /// 团购描述
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
                  
        /// <summary>
        /// 团购内容
        /// </summary>
        public string TuanDetail
        {
            set { _tuanDetail = value; }
            get { return _tuanDetail; }
        }
                  
        /// <summary>
        /// 团购地址
        /// </summary>
        public string TuanUrl
        {
            set { _tuanUrl = value; }
            get { return _tuanUrl; }
        }

        public string ImageThumbUrl
        {
            set { _imageThumbUrl = value; }
            get { return _imageThumbUrl; }
        }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageUrl
        {
            set { _imageUrl = value; }
            get { return _imageUrl; }
        }
                  
        /// <summary>
        /// 市场价
        /// </summary>
        public decimal MarketPrice
        {
            set { _marketPrice = value; }
            get { return _marketPrice; }
        }
                  
        /// <summary>
        /// 团购价
        /// </summary>
        public decimal TuanPrice
        {
            set { _tuanPrice = value; }
            get { return _tuanPrice; }
        }
                  
        /// <summary>
        /// 折扣
        /// </summary>
        public float Rebate
        {
            set { _rebate = value; }
            get { return _rebate; }
        }
                  
        /// <summary>
        /// 商家名称
        /// </summary>
        public string MerchantName
        {
            set { _merchantName = value; }
            get { return _merchantName; }
        }
                  
        /// <summary>
        /// 商家电话
        /// </summary>
        public string MerchantPhone
        {
            set { _merchantPhone = value; }
            get { return _merchantPhone; }
        }
                  
        /// <summary>
        /// 商家地址
        /// </summary>
        public string MerchantAddress
        {
            set { _merchantAddress = value; }
            get { return _merchantAddress; }
        }
                  
        /// <summary>
        /// 商家经度
        /// </summary>
        public double Longitude
        {
            set { _longitude = value; }
            get { return _longitude; }
        }
                  
        /// <summary>
        /// 商家纬度
        /// </summary>
        public double Latitude
        {
            set { _latitude = value; }
            get { return _latitude; }
        }
                  
        /// <summary>
        /// 团购总数
        /// </summary>
        public int TotalCount
        {
            set { _totalCount = value; }
            get { return _totalCount; }
        }
                  
        /// <summary>
        /// 购买统计
        /// </summary>
        public int BuyCount
        {
            set { _buyCount = value; }
            get { return _buyCount; }
        }
                  
        /// <summary>
        /// 点击数
        /// </summary>
        public int ClickCount
        {
            set { _clickCount = value; }
            get { return _clickCount; }
        }
                  
        /// <summary>
        /// 评论数
        /// </summary>
        public int CommentCount
        {
            set { _commentCount = value; }
            get { return _commentCount; }
        }
                  
        /// <summary>
        /// 观点数
        /// </summary>
        public int PointCount
        {
            set { _pointCount = value; }
            get { return _pointCount; }
        }
                  
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime
        {
            set { _beginTime = value; }
            get { return _beginTime; }
        }
                  
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime
        {
            set { _endTime = value; }
            get { return _endTime; }
        }
                  
        /// <summary>
        /// 团购状态,1正常,2卖光了,3已结束
        /// </summary>
        public byte Statu
        {
            set { _statu = value; }
            get { return _statu; }
        }
                  
        /// <summary>
        /// 团购等级
        /// </summary>
        public byte Rank
        {
            set { _rank = value; }
            get { return _rank; }
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
        /// 排序ID
        /// </summary>
        public int OrderID
        {
            set { _orderID = value; }
            get { return _orderID; }
        }
        
        #endregion
    }
}
    