using System;
namespace XHD.Model
{
    /// <summary>
    /// crm_set_shoplockip:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_set_shoplockip
    {
        public crm_set_shoplockip()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _shop_lockip;
        private string _shop_lockipdes;
        private int? _c_createid;
        private string _c_createname;
        private DateTime? _c_createdate;
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
        public string factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string shop_lockIp
        {
            set { _shop_lockip = value; }
            get { return _shop_lockip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string shop_lockIpDes
        {
            set { _shop_lockipdes = value; }
            get { return _shop_lockipdes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? C_createId
        {
            set { _c_createid = value; }
            get { return _c_createid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_createName
        {
            set { _c_createname = value; }
            get { return _c_createname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? C_createDate
        {
            set { _c_createdate = value; }
            get { return _c_createdate; }
        }
        #endregion Model

    }
}

