using System;
namespace XHD.Model
{
    /// <summary>
    /// ecs_market:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ecs_market
    {
        public ecs_market()
        { }
        #region Model
        private int _market_id;
        private string _market_name;
        private int? _market_role_id;
        private int? _is_branch_company = 0;
        private string _default_phone = "0";
        private int? _default_job_number;
        private string _company_name;
        private string _company_tel;
        private string _company_address;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int market_id
        {
            set { _market_id = value; }
            get { return _market_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string market_name
        {
            set { _market_name = value; }
            get { return _market_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? market_role_id
        {
            set { _market_role_id = value; }
            get { return _market_role_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_branch_company
        {
            set { _is_branch_company = value; }
            get { return _is_branch_company; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string default_phone
        {
            set { _default_phone = value; }
            get { return _default_phone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? default_job_number
        {
            set { _default_job_number = value; }
            get { return _default_job_number; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string company_name
        {
            set { _company_name = value; }
            get { return _company_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string company_tel
        {
            set { _company_tel = value; }
            get { return _company_tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string company_address
        {
            set { _company_address = value; }
            get { return _company_address; }
        }
        #endregion Model

    }
}

