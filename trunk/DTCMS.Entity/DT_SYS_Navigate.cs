using System;
namespace DTCMS.Entity
{
    /// <summary>
    /// 实体类DT_SYS_Navigate 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class DT_SYS_Navigate
    {
        public DT_SYS_Navigate()
        { }
        #region Model
        private int _nid;
        private string _nvaid;
        private string _parentid;
        private string _name;
        private string _ename;
        private string _filepath;
        private string _mainurl;
        private string _target;
        private int? _copyrightcode;
        private DateTime? _createtime;
        private int? _orderid;
        private int? _issys;
        private int? _isenable;
        /// <summary>
        /// 
        /// </summary>
        public int NID
        {
            set { _nid = value; }
            get { return _nid; }
        }
        /// <summary>
        /// 导航ID，随机生成
        /// </summary>
        public string NvaID
        {
            set { _nvaid = value; }
            get { return _nvaid; }
        }
        /// <summary>
        /// 导航父ID，0：父导航
        /// </summary>
        public string ParentID
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 导航名称
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 导航英文名
        /// </summary>
        public string EName
        {
            set { _ename = value; }
            get { return _ename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FilePath
        {
            set { _filepath = value; }
            get { return _filepath; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MainURL
        {
            set { _mainurl = value; }
            get { return _mainurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Target
        {
            set { _target = value; }
            get { return _target; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 权限代码
        /// </summary>
        public int? CopyrightCode
        {
            set { _copyrightcode = value; }
            get { return _copyrightcode; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 是否系统导航
        /// </summary>
        public int? ISSys
        {
            set { _issys = value; }
            get { return _issys; }
        }
        /// <summary>
        /// 是否应用
        /// </summary>
        public int? ISEnable
        {
            set { _isenable = value; }
            get { return _isenable; }
        }
        #endregion Model

    }
}
