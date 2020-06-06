using System;
namespace XHD.Model
{
    /// <summary>
    /// crm_grab_notes:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_grab_notes
    {
        public crm_grab_notes()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _customer_id;
        private string _customer_name;
        private int? _emp_id;
        private string _emp_uid;
        private string _emp_name;
        private DateTime? _start_time;
        private DateTime? _end_time;
        private decimal? _cycle_feat;
        private int? _isdel = 0;
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
        public int? emp_id
        {
            set { _emp_id = value; }
            get { return _emp_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string emp_uid
        {
            set { _emp_uid = value; }
            get { return _emp_uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string emp_name
        {
            set { _emp_name = value; }
            get { return _emp_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? start_time
        {
            set { _start_time = value; }
            get { return _start_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? end_time
        {
            set { _end_time = value; }
            get { return _end_time; }
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
        public int? isdel
        {
            set { _isdel = value; }
            get { return _isdel; }
        }
        #endregion Model

    }
}

