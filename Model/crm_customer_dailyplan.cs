using System;
namespace XHD.Model
{
    /// <summary>
    /// crm_customer_dailyplan:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_customer_dailyplan
    {
        public crm_customer_dailyplan()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _customer_id;
        private string _customer_name;
        private int? _empid;
        private string _empname;
        private int? _did;
        private string _dname;
        private DateTime? _daily;
        private decimal? _plan_feat;
        private string _plan_source;
        private string _plan_5w1h;
        private DateTime? _createtime;
        private int? _isdel;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? customer_id
        {
            set { _customer_id = value; }
            get { return _customer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string customer_name
        {
            set { _customer_name = value; }
            get { return _customer_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? empid
        {
            set { _empid = value; }
            get { return _empid; }
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
        public int? did
        {
            set { _did = value; }
            get { return _did; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dname
        {
            set { _dname = value; }
            get { return _dname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? daily
        {
            set { _daily = value; }
            get { return _daily; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? plan_feat
        {
            set { _plan_feat = value; }
            get { return _plan_feat; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plan_source
        {
            set { _plan_source = value; }
            get { return _plan_source; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plan_5w1h
        {
            set { _plan_5w1h = value; }
            get { return _plan_5w1h; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? createtime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isdel
        {
            set { _isdel = value; }
            get { return _isdel; }
        }
        #endregion Model

    }
}

