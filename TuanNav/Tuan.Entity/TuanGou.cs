using System;

namespace Tuan.Entity
{
    /// <summary>
    /// ʵ���� TuanGou
    /// </summary>
    public class TuanGou
    {
        public TuanGou(){ }
        
        #region ʵ������
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
        /// �����
        /// </summary>
        public int CategoryID
        {
            set { _categoryID = value; }
            get { return _categoryID; }
        }
                  
        /// <summary>
        /// ��������
        /// </summary>
        public int CityID
        {
            set { _cityID = value; }
            get { return _cityID; }
        }
                  
        /// <summary>
        /// �û�ID
        /// </summary>
        public int UserID
        {
            set { _userID = value; }
            get { return _userID; }
        }
                  
        /// <summary>
        /// �Ź�վ��ID
        /// </summary>
        public int SiteID
        {
            set { _siteID = value; }
            get { return _siteID; }
        }
                  
        /// <summary>
        /// ����
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
                  
        /// <summary>
        /// �Ź�����
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
                  
        /// <summary>
        /// �Ź�����
        /// </summary>
        public string TuanDetail
        {
            set { _tuanDetail = value; }
            get { return _tuanDetail; }
        }
                  
        /// <summary>
        /// �Ź���ַ
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
        /// ͼƬ��ַ
        /// </summary>
        public string ImageUrl
        {
            set { _imageUrl = value; }
            get { return _imageUrl; }
        }
                  
        /// <summary>
        /// �г���
        /// </summary>
        public decimal MarketPrice
        {
            set { _marketPrice = value; }
            get { return _marketPrice; }
        }
                  
        /// <summary>
        /// �Ź���
        /// </summary>
        public decimal TuanPrice
        {
            set { _tuanPrice = value; }
            get { return _tuanPrice; }
        }
                  
        /// <summary>
        /// �ۿ�
        /// </summary>
        public float Rebate
        {
            set { _rebate = value; }
            get { return _rebate; }
        }
                  
        /// <summary>
        /// �̼�����
        /// </summary>
        public string MerchantName
        {
            set { _merchantName = value; }
            get { return _merchantName; }
        }
                  
        /// <summary>
        /// �̼ҵ绰
        /// </summary>
        public string MerchantPhone
        {
            set { _merchantPhone = value; }
            get { return _merchantPhone; }
        }
                  
        /// <summary>
        /// �̼ҵ�ַ
        /// </summary>
        public string MerchantAddress
        {
            set { _merchantAddress = value; }
            get { return _merchantAddress; }
        }
                  
        /// <summary>
        /// �̼Ҿ���
        /// </summary>
        public double Longitude
        {
            set { _longitude = value; }
            get { return _longitude; }
        }
                  
        /// <summary>
        /// �̼�γ��
        /// </summary>
        public double Latitude
        {
            set { _latitude = value; }
            get { return _latitude; }
        }
                  
        /// <summary>
        /// �Ź�����
        /// </summary>
        public int TotalCount
        {
            set { _totalCount = value; }
            get { return _totalCount; }
        }
                  
        /// <summary>
        /// ����ͳ��
        /// </summary>
        public int BuyCount
        {
            set { _buyCount = value; }
            get { return _buyCount; }
        }
                  
        /// <summary>
        /// �����
        /// </summary>
        public int ClickCount
        {
            set { _clickCount = value; }
            get { return _clickCount; }
        }
                  
        /// <summary>
        /// ������
        /// </summary>
        public int CommentCount
        {
            set { _commentCount = value; }
            get { return _commentCount; }
        }
                  
        /// <summary>
        /// �۵���
        /// </summary>
        public int PointCount
        {
            set { _pointCount = value; }
            get { return _pointCount; }
        }
                  
        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public DateTime BeginTime
        {
            set { _beginTime = value; }
            get { return _beginTime; }
        }
                  
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime EndTime
        {
            set { _endTime = value; }
            get { return _endTime; }
        }
                  
        /// <summary>
        /// �Ź�״̬,1����,2������,3�ѽ���
        /// </summary>
        public byte Statu
        {
            set { _statu = value; }
            get { return _statu; }
        }
                  
        /// <summary>
        /// �Ź��ȼ�
        /// </summary>
        public byte Rank
        {
            set { _rank = value; }
            get { return _rank; }
        }
                  
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime AddDate
        {
            set { _addDate = value; }
            get { return _addDate; }
        }
                  
        /// <summary>
        /// ����ID
        /// </summary>
        public int OrderID
        {
            set { _orderID = value; }
            get { return _orderID; }
        }
        
        #endregion
    }
}
    