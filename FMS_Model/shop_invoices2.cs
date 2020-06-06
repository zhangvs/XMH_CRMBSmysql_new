using System;

namespace FMS_Model
{
    /// <summary>
    /// shop_invoices2:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_invoices2
    {
        public shop_invoices2()
        { }
        #region Model
        private int _invoice_id;
        private string _invoice_type;
        private int _tax_rate = 17;
        private int _admin_id;
        private string _invoice_no;
        private int _user_id;
        private int _total_count = 0;
        private decimal _total_money = 0.0000M;
        private decimal _total_tax = 0.0000M;
        private int _invoice_create_time;
        private string _tax_account;
        private int _add_time;
        private string _note;
        private int? _invoice1_id;
        private int _update_time;

        /// <summary>
        /// 
        /// </summary>
        public int invoice_id
        {
            set { _invoice_id = value; }
            get { return _invoice_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string invoice_type
        {
            set { _invoice_type = value; }
            get { return _invoice_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int tax_rate
        {
            set { _tax_rate = value; }
            get { return _tax_rate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int admin_id
        {
            set { _admin_id = value; }
            get { return _admin_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string invoice_no
        {
            set { _invoice_no = value; }
            get { return _invoice_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int total_count
        {
            set { _total_count = value; }
            get { return _total_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal total_money
        {
            set { _total_money = value; }
            get { return _total_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal total_tax
        {
            set { _total_tax = value; }
            get { return _total_tax; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int invoice_create_time
        {
            set { _invoice_create_time = value; }
            get { return _invoice_create_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tax_account
        {
            set { _tax_account = value; }
            get { return _tax_account; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string note
        {
            set { _note = value; }
            get { return _note; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? invoice1_id
        {
            set { _invoice1_id = value; }
            get { return _invoice1_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int update_time
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        #endregion Model

    }
}

