using System;
namespace DTCMS.Entity
{
	/// <summary>
	/// ʵ����DT_Arc_Article ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class Arc_Article
	{
        public Arc_Article()
		{ }
        #region Entity
        private int _id;
		private int _classid;
		private string _title;
		private string _shorttitle;
		private string _titlestyle;
		private string _tags;
		private string _imgurl;
		private string _author;
		private string _editor;
		private string _publisher;
		private string _source;
		private string _templet;
		private string _keywords;
		private string _description;
		private string _content;
		private int _click;
		private int _good;
		private int _bad;
		private int? _readaccess;
		private int? _money;
		private string _attribute;
		private int? _iscomment;
		private int _ischecked;
		private int _isrecycle;
		private int _isredirect;
		private int? _ishtml;
		private int? _ispaging;
		private string _filepath;
		private DateTime _adddate;
		private DateTime _pubdate;
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
		/// ��ĿID
		/// </summary>
		public int ClassID
		{
			set{ _classid=value;}
			get{return _classid;}
		}
		/// <summary>
		/// ���±���
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// �������Ա���
		/// </summary>
		public string ShortTitle
		{
			set{ _shorttitle=value;}
			get{return _shorttitle;}
		}
		/// <summary>
		/// ������ʽ
		/// </summary>
		public string TitleStyle
		{
			set{ _titlestyle=value;}
			get{return _titlestyle;}
		}
		/// <summary>
		/// ����TAG
		/// </summary>
		public string Tags
		{
			set{ _tags=value;}
			get{return _tags;}
		}
		/// <summary>
		/// ��������ͼ
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string Author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// ���α༭
		/// </summary>
		public string Editor
		{
			set{ _editor=value;}
			get{return _editor;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string PubLisher
		{
			set{ _publisher=value;}
			get{return _publisher;}
		}
		/// <summary>
		/// ������Դ
		/// </summary>
		public string Source
		{
			set{ _source=value;}
			get{return _source;}
		}
		/// <summary>
		/// ����ģ��
		/// </summary>
		public string Templet
		{
			set{ _templet=value;}
			get{return _templet;}
		}
		/// <summary>
		/// �ؼ���
		/// </summary>
		public string Keywords
		{
			set{ _keywords=value;}
			get{return _keywords;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// ���µ��
		/// </summary>
		public int Click
		{
			set{ _click=value;}
			get{return _click;}
		}
		/// <summary>
		/// ��
		/// </summary>
		public int Good
		{
			set{ _good=value;}
			get{return _good;}
		}
		/// <summary>
		/// ��
		/// </summary>
		public int Bad
		{
			set{ _bad=value;}
			get{return _bad;}
		}
		/// <summary>
		/// �Ķ�Ȩ�ޣ���Ա��
		/// </summary>
		public int? Readaccess
		{
			set{ _readaccess=value;}
			get{return _readaccess;}
		}
		/// <summary>
		/// ���ѵ���
		/// </summary>
		public int? Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// �������ԣ�hͷ����c�Ƽ���pͼƬ��f�ƻã�s����
		/// </summary>
		public string Attribute
		{
			set{ _attribute=value;}
			get{return _attribute;}
		}
		/// <summary>
		/// �Ƿ��������ۣ�1����0������
		/// </summary>
		public int? IsComment
		{
			set{ _iscomment=value;}
			get{return _iscomment;}
		}
		/// <summary>
		/// �Ƿ���ˣ�0δ��ˣ�1���
		/// </summary>
		public int IsChecked
		{
			set{ _ischecked=value;}
			get{return _ischecked;}
		}
		/// <summary>
		/// �Ƿ�������վ��0������1����վ
		/// </summary>
		public int IsRecycle
		{
			set{ _isrecycle=value;}
			get{return _isrecycle;}
		}
		/// <summary>
		/// �Ƿ���ת��ַ��1�ǣ�0��
		/// </summary>
		public int IsRedirect
		{
			set{ _isredirect=value;}
			get{return _isredirect;}
		}
		/// <summary>
		/// �Ƿ����ɾ�̬ҳ��1���ɾ�̬��0��̬����
		/// </summary>
		public int? IsHtml
		{
			set{ _ishtml=value;}
			get{return _ishtml;}
		}
		/// <summary>
		/// �Ƿ��ҳ
		/// </summary>
		public int? IsPaging
		{
			set{ _ispaging=value;}
			get{return _ispaging;}
		}
		/// <summary>
		/// �洢·��
		/// </summary>
		public string FilePath
		{
			set{ _filepath=value;}
			get{return _filepath;}
		}
		/// <summary>
		/// ���ʱ��
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime PubDate
		{
			set{ _pubdate=value;}
			get{return _pubdate;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public int? OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
        }
        #endregion Entity

    }
}

