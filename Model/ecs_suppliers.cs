using System;
namespace XHD.Model
{
    /// <summary>
    /// ecs_suppliers:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ecs_suppliers
    {
        public ecs_suppliers()
        { }
        #region Model
        private int _suppliers_id;
        private string _scm_factoryid;
        private string _suppliers_code;
        private string _suppliers_erp_code;
        private string _suppliers_name;
        private string _suppliers_desc;
        private string _suppliers_tel;
        private int _dealer_id = 0;
        private int _is_check = 1;
        private string _add_time;
        private int? _add_empid;
        private string _add_empname;
        private string _update_time;
        private int? _update_empid;
        private string _update_empname;
        private string _type_grade;
        private int? _provinces_id;
        private string _provinces;
        private int? _city_id;
        private string _city;
        private int? _district_id;
        private string _district;
        private int? _factory_usernum;
        private string _wms_suppliers_id;
        private string _operate_brands;
        private int? _is_enable = 1;
        private int? _sync_outKingdee = 0;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int suppliers_id
        {
            set { _suppliers_id = value; }
            get { return _suppliers_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string scm_factoryId
        {
            set { _scm_factoryid = value; }
            get { return _scm_factoryid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suppliers_code
        {
            set { _suppliers_code = value; }
            get { return _suppliers_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suppliers_erp_code
        {
            set { _suppliers_erp_code = value; }
            get { return _suppliers_erp_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suppliers_name
        {
            set { _suppliers_name = value; }
            get { return _suppliers_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suppliers_desc
        {
            set { _suppliers_desc = value; }
            get { return _suppliers_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suppliers_tel
        {
            set { _suppliers_tel = value; }
            get { return _suppliers_tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int dealer_id
        {
            set { _dealer_id = value; }
            get { return _dealer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_check
        {
            set { _is_check = value; }
            get { return _is_check; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? add_empId
        {
            set { _add_empid = value; }
            get { return _add_empid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string add_empName
        {
            set { _add_empname = value; }
            get { return _add_empname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string update_time
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? update_empId
        {
            set { _update_empid = value; }
            get { return _update_empid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string update_empName
        {
            set { _update_empname = value; }
            get { return _update_empname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string type_grade
        {
            set { _type_grade = value; }
            get { return _type_grade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Provinces_id
        {
            set { _provinces_id = value; }
            get { return _provinces_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Provinces
        {
            set { _provinces = value; }
            get { return _provinces; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? City_id
        {
            set { _city_id = value; }
            get { return _city_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string City
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? District_id
        {
            set { _district_id = value; }
            get { return _district_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string District
        {
            set { _district = value; }
            get { return _district; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? factory_UserNum
        {
            set { _factory_usernum = value; }
            get { return _factory_usernum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string wms_suppliers_id
        {
            set { _wms_suppliers_id = value; }
            get { return _wms_suppliers_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string operate_brands
        {
            set { _operate_brands = value; }
            get { return _operate_brands; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_enable
        {
            set { _is_enable = value; }
            get { return _is_enable; }
        }

        public int? sync_outKingdee
        {
            set { _sync_outKingdee = value; }
            get { return _sync_outKingdee; }
        }

        public decimal period_start { get; set; }
        public DateTime period_start_date { get; set; }
        public int Is_stop { get; set; }
        #endregion Model

    }
}

