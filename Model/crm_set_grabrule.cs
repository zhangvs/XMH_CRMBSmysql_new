using System;
namespace XHD.Model
{
    /// <summary>
    /// crm_set_grabrule:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_set_grabrule
    {
        public crm_set_grabrule()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _cycle_day;
        private decimal? _cycle_feat;
        private DateTime? _update_time;
        private int? _update_empid;
        private string _update_empuid;
        private string _update_empname;
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
        public int? cycle_day
        {
            set { _cycle_day = value; }
            get { return _cycle_day; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cycle_feat
        {
            set { _cycle_feat = value; }
            get { return _cycle_feat; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? update_time
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? update_empid
        {
            set { _update_empid = value; }
            get { return _update_empid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string update_empuid
        {
            set { _update_empuid = value; }
            get { return _update_empuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string update_empname
        {
            set { _update_empname = value; }
            get { return _update_empname; }
        }
        #endregion Model

    }
}

