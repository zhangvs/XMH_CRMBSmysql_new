using System;

namespace XHD.Model
{
    /// <summary>
    /// crm_customer_end:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_customer_end
    {
        public crm_customer_end()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _dealer_id;
        private string _dealer_code;
        private string _dealer_name;
        private string _serialnumber_end;
        private string _customer_end;
        private string _address;
        private string _tel;
        private string _fax;
        private string _site;
        private int? _industry_id;
        private string _industry;
        private int? _nation_id;
        private string _nation;
        private int? _provinces_id;
        private string _provinces;
        private int? _city_id;
        private string _city;
        private int? _district_id;
        private string _district;
        private int? _customertype_id;
        private string _customertype;
        private int? _customerlevel_id;
        private string _customerlevel;
        private int? _customersource_id;
        private string _customersource;
        private string _descripe;
        private string _remarks;
        private int? _department_id;
        private string _department;
        private int? _employee_id;
        private string _employee_uid;
        private string _employee;
        private int? _followup_id;
        private string _followup;
        private int? _customervalue_id;
        private string _customervalue;
        private int? _phoneisvalid_id;
        private string _phoneisvalid;
        private int? _beseats_id;
        private string _beseats_uid;
        private string _beseats;
        private int? _beseats_depid;
        private string _beseats_depname;
        private int? _privatecustomer_id;
        private string _privatecustomer;
        private DateTime? _lastfollow;
        private int? _create_id;
        private string _create_name;
        private DateTime? _create_date;
        private int? _isdelete;
        private DateTime? _delete_time;
        private int? _emp_handnum = 1;
        private string _state_allot = "0";
        private string _type_belong = "0";
        private string _state_allot_end = "0";
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
        public int? Dealer_Id
        {
            set { _dealer_id = value; }
            get { return _dealer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Dealer_Code
        {
            set { _dealer_code = value; }
            get { return _dealer_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Dealer_Name
        {
            set { _dealer_name = value; }
            get { return _dealer_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Serialnumber_end
        {
            set { _serialnumber_end = value; }
            get { return _serialnumber_end; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Customer_end
        {
            set { _customer_end = value; }
            get { return _customer_end; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fax
        {
            set { _fax = value; }
            get { return _fax; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string site
        {
            set { _site = value; }
            get { return _site; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? industry_id
        {
            set { _industry_id = value; }
            get { return _industry_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string industry
        {
            set { _industry = value; }
            get { return _industry; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Nation_id
        {
            set { _nation_id = value; }
            get { return _nation_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Nation
        {
            set { _nation = value; }
            get { return _nation; }
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
        public int? CustomerType_id
        {
            set { _customertype_id = value; }
            get { return _customertype_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerType
        {
            set { _customertype = value; }
            get { return _customertype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CustomerLevel_id
        {
            set { _customerlevel_id = value; }
            get { return _customerlevel_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerLevel
        {
            set { _customerlevel = value; }
            get { return _customerlevel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CustomerSource_id
        {
            set { _customersource_id = value; }
            get { return _customersource_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerSource
        {
            set { _customersource = value; }
            get { return _customersource; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DesCripe
        {
            set { _descripe = value; }
            get { return _descripe; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks
        {
            set { _remarks = value; }
            get { return _remarks; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Department_id
        {
            set { _department_id = value; }
            get { return _department_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Department
        {
            set { _department = value; }
            get { return _department; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Employee_id
        {
            set { _employee_id = value; }
            get { return _employee_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Employee_uid
        {
            set { _employee_uid = value; }
            get { return _employee_uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Employee
        {
            set { _employee = value; }
            get { return _employee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FollowUp_id
        {
            set { _followup_id = value; }
            get { return _followup_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FollowUp
        {
            set { _followup = value; }
            get { return _followup; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CustomerValue_id
        {
            set { _customervalue_id = value; }
            get { return _customervalue_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerValue
        {
            set { _customervalue = value; }
            get { return _customervalue; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PhoneIsValid_id
        {
            set { _phoneisvalid_id = value; }
            get { return _phoneisvalid_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneIsValid
        {
            set { _phoneisvalid = value; }
            get { return _phoneisvalid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BeSeats_id
        {
            set { _beseats_id = value; }
            get { return _beseats_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BeSeats_uid
        {
            set { _beseats_uid = value; }
            get { return _beseats_uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BeSeats
        {
            set { _beseats = value; }
            get { return _beseats; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BeSeats_depid
        {
            set { _beseats_depid = value; }
            get { return _beseats_depid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BeSeats_depname
        {
            set { _beseats_depname = value; }
            get { return _beseats_depname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? privatecustomer_Id
        {
            set { _privatecustomer_id = value; }
            get { return _privatecustomer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string privatecustomer
        {
            set { _privatecustomer = value; }
            get { return _privatecustomer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? lastfollow
        {
            set { _lastfollow = value; }
            get { return _lastfollow; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Create_id
        {
            set { _create_id = value; }
            get { return _create_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Create_name
        {
            set { _create_name = value; }
            get { return _create_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Create_date
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isDelete
        {
            set { _isdelete = value; }
            get { return _isdelete; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Delete_time
        {
            set { _delete_time = value; }
            get { return _delete_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? emp_handnum
        {
            set { _emp_handnum = value; }
            get { return _emp_handnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string state_allot
        {
            set { _state_allot = value; }
            get { return _state_allot; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string type_belong
        {
            set { _type_belong = value; }
            get { return _type_belong; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string state_allot_end
        {
            set { _state_allot_end = value; }
            get { return _state_allot_end; }
        }
        #endregion Model

    }
}

