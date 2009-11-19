using System;
namespace DTCMS.Entity
{
	/// <summary>
	/// ʵ����DT_Arc_Class ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class Arc_Class
	{
		public Arc_Class()
		{ }
        #region Entity
        private int _cid;
        private int _parentid;
        private int _attribute;
        private string _classname;
        private string _classename;
        private int _classtype;
        private string _classdomain;
        private string _classpath;
        private string _indextemplet;
        private string _listtemplet;
        private string _archivetemplet;
        private string _indexrule;
        private string _listrule;
        private string _archiverule;
        private int? _classpage;
        private string _description;
        private int _ishidden;
        private int _ishtml;
        private int _checklevel;
        private int _iscontribute;
        private int _iscomment;
        private int? _readaccess;
        private int? _siteid;
        private DateTime _adddate;
        private string _relation;
        private int _orderid;
        private string _imgurl;
        private string _keywords;
        private string _crossid;
        private string _content;
        /// <summary>
        /// ��ĿID
        /// </summary>
        public int CID
        {
            set { _cid = value; }
            get { return _cid; }
        }
        /// <summary>
        /// ��Ŀ��ID��Ĭ��0Ϊ������Ŀ
        /// </summary>
        public int ParentID
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// ��Ŀ���ԣ�1���棬2�б�3���ӵ�ַ
        /// </summary>
        public int Attribute
        {
            set { _attribute = value; }
            get { return _attribute; }
        }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string ClassName
        {
            set { _classname = value; }
            get { return _classname; }
        }
        /// <summary>
        /// ��ĿӢ������
        /// </summary>
        public string ClassEName
        {
            set { _classename = value; }
            get { return _classename; }
        }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public int ClassType
        {
            set { _classtype = value; }
            get { return _classtype; }
        }
        /// <summary>
        /// ��Ŀ��������
        /// </summary>
        public string ClassDomain
        {
            set { _classdomain = value; }
            get { return _classdomain; }
        }
        /// <summary>
        /// ��ĿĿ¼��{#CmsPath}/Archive/
        /// </summary>
        public string ClassPath
        {
            set { _classpath = value; }
            get { return _classpath; }
        }
        /// <summary>
        /// ����ģ��
        /// </summary>
        public string IndexTemplet
        {
            set { _indextemplet = value; }
            get { return _indextemplet; }
        }
        /// <summary>
        /// �б�ģ��
        /// </summary>
        public string ListTemplet
        {
            set { _listtemplet = value; }
            get { return _listtemplet; }
        }
        /// <summary>
        /// �ĵ�ģ��
        /// </summary>
        public string ArchiveTemplet
        {
            set { _archivetemplet = value; }
            get { return _archivetemplet; }
        }
        /// <summary>
        /// ����ҳ����
        /// </summary>
        public string IndexRule
        {
            set { _indexrule = value; }
            get { return _indexrule; }
        }
        /// <summary>
        /// �б�ҳ���򣬷���·��
        /// </summary>
        public string ListRule
        {
            set { _listrule = value; }
            get { return _listrule; }
        }
        /// <summary>
        /// �ĵ�ҳ���򣬷���·��
        /// </summary>
        public string ArchiveRule
        {
            set { _archiverule = value; }
            get { return _archiverule; }
        }
        /// <summary>
        /// ��Ŀ��ҳ��С,�б�����
        /// </summary>
        public int? ClassPage
        {
            set { _classpage = value; }
            get { return _classpage; }
        }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// �Ƿ����أ�1���ã�0����
        /// </summary>
        public int IsHidden
        {
            set { _ishidden = value; }
            get { return _ishidden; }
        }
        /// <summary>
        /// �Ƿ��������ɾ�̬ҳ��1���ɾ�̬��0��̬����
        /// </summary>
        public int IsHtml
        {
            set { _ishtml = value; }
            get { return _ishtml; }
        }
        /// <summary>
        /// ��˻���
        /// </summary>
        public int CheckLevel
        {
            set { _checklevel = value; }
            get { return _checklevel; }
        }
        /// <summary>
        /// �Ƿ�����Ͷ�壬1����0������
        /// </summary>
        public int IsContribute
        {
            set { _iscontribute = value; }
            get { return _iscontribute; }
        }
        /// <summary>
        /// ����Ŀ�����Ƿ��������ۣ�1����0������
        /// </summary>
        public int IsComment
        {
            set { _iscomment = value; }
            get { return _iscomment; }
        }
        /// <summary>
        /// �Ķ�Ȩ��
        /// </summary>
        public int? Readaccess
        {
            set { _readaccess = value; }
            get { return _readaccess; }
        }
        /// <summary>
        /// վ��ID
        /// </summary>
        public int? SiteID
        {
            set { _siteid = value; }
            get { return _siteid; }
        }
        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// ��Ŀ��ϵ
        /// </summary>
        public string Relation
        {
            set { _relation = value; }
            get { return _relation; }
        }
        /// <summary>
        /// ��Ŀ������������
        /// </summary>
        public int OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// ��ĿͼƬ��ַ
        /// </summary>
        public string ImgUrl
        {
            set { _imgurl = value; }
            get { return _imgurl; }
        }
        /// <summary>
        /// ��Ŀ�ؼ���
        /// </summary>
        public string Keywords
        {
            set { _keywords = value; }
            get { return _keywords; }
        }
        /// <summary>
        /// ������Ŀ�������Ŀ��,�Ÿ���
        /// </summary>
        public string CrossID
        {
            set { _crossid = value; }
            get { return _crossid; }
        }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        #endregion Entity

    }
}

