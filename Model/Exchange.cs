using System;
namespace XHD.Model
{
    /// <summary>
    /// exchange:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Exchange
    {
        public Exchange()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _pronam;
        private int? _proid;
        private int? _empid;
        private string _createdate;
        private string _empname;
        private int? _ischange;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string proNam
        {
            set { _pronam = value; }
            get { return _pronam; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? proId
        {
            set { _proid = value; }
            get { return _proid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? empId
        {
            set { _empid = value; }
            get { return _empid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string createDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string empname
        {
            set { _empname = value; }
            get { return _empname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isChange
        {
            set { _ischange = value; }
            get { return _ischange; }
        }
        #endregion Model

    }
}


