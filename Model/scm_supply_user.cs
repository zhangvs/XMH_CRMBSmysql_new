using System;
namespace XHD.Model
{
    /// <summary>
    /// scm_supply_user:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class scm_supply_user
    {
        public scm_supply_user()
        { }
        #region Model
        private int _id;
        private int? _factory_id;
        private int? _supply_id;
        private string _suppliers_erp_code;
        private string _supply_name;
        private string _user_uid;
        private string _user_name;
        private string _user_pwd;
        private string _email;
        private string _sex;
        private string _tel;
        private string _remarks;
        private int? _canlogin = 1;
        private int? _create_id;
        private DateTime? _create_date;
        private string _create_name;
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
        public int? factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? supply_Id
        {
            set { _supply_id = value; }
            get { return _supply_id; }
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
        public string supply_Name
        {
            set { _supply_name = value; }
            get { return _supply_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string user_uid
        {
            set { _user_uid = value; }
            get { return _user_uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string user_name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string user_pwd
        {
            set { _user_pwd = value; }
            get { return _user_pwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sex
        {
            set { _sex = value; }
            get { return _sex; }
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
        public string remarks
        {
            set { _remarks = value; }
            get { return _remarks; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? canlogin
        {
            set { _canlogin = value; }
            get { return _canlogin; }
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
        public DateTime? Create_date
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Create_name
        {
            set { _create_name = value; }
            get { return _create_name; }
        }
        #endregion Model

    }
}

