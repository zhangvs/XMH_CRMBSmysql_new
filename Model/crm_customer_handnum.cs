using System;

namespace XHD.Model
{
    /// <summary>
    /// crm_customer_handnum:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_customer_handnum
    {
        public crm_customer_handnum()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _customer_id;
        private string _customer;
        private int? _beseats_id_old;
        private string _beseats_old;
        private string _beseats_uid_old;
        private int? _beseats_depid_old;
        private string _beseats_depname_old;
        private int? _emp_id;
        private string _emp_uid;
        private string _emp_name;
        private DateTime? _start_date;
        private DateTime? _end_date;
        private int? _operation_emp_id;
        private string _operation_emp_uid;
        private string _operation_emp_name;
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
        public string Factory_Id
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
        public string customer
        {
            set { _customer = value; }
            get { return _customer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BeSeats_id_old
        {
            set { _beseats_id_old = value; }
            get { return _beseats_id_old; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BeSeats_old
        {
            set { _beseats_old = value; }
            get { return _beseats_old; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BeSeats_uid_old
        {
            set { _beseats_uid_old = value; }
            get { return _beseats_uid_old; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BeSeats_depid_old
        {
            set { _beseats_depid_old = value; }
            get { return _beseats_depid_old; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BeSeats_depname_old
        {
            set { _beseats_depname_old = value; }
            get { return _beseats_depname_old; }
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
        public DateTime? Start_date
        {
            set { _start_date = value; }
            get { return _start_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? End_date
        {
            set { _end_date = value; }
            get { return _end_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? operation_emp_id
        {
            set { _operation_emp_id = value; }
            get { return _operation_emp_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string operation_emp_uid
        {
            set { _operation_emp_uid = value; }
            get { return _operation_emp_uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string operation_emp_name
        {
            set { _operation_emp_name = value; }
            get { return _operation_emp_name; }
        }
        #endregion Model

    }
}

