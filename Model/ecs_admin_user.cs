using System;
namespace XHD.Model
{
    /// <summary>
    /// ecs_admin_user:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ecs_admin_user
    {
        public ecs_admin_user()
        { }
        #region Model
        private int _user_id;
        private string _user_name;
        private string _real_name;
        private string _email;
        private string _password;
        private string _ec_salt;
        private int _add_time = 0;
        private int _last_login = 0;
        private string _last_ip;
        private int _points = 0;
        private string _action_list;
        private string _nav_list;
        private string _lang_type;
        private int _agency_id;
        private int? _suppliers_id = 0;
        private string _todolist;
        private int? _role_id;
        private string _admin_market_area = "0";
        private string _user_tel;
        private string _user_qq;
        private string _nickname;
        private int _status = 1;
        private int _is_lockable = 1;
        private string _higher;
        private int? _unix_timestamp;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
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
        public string real_name
        {
            set { _real_name = value; }
            get { return _real_name; }
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
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ec_salt
        {
            set { _ec_salt = value; }
            get { return _ec_salt; }
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
        public int last_login
        {
            set { _last_login = value; }
            get { return _last_login; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string last_ip
        {
            set { _last_ip = value; }
            get { return _last_ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int points
        {
            set { _points = value; }
            get { return _points; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string action_list
        {
            set { _action_list = value; }
            get { return _action_list; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nav_list
        {
            set { _nav_list = value; }
            get { return _nav_list; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string lang_type
        {
            set { _lang_type = value; }
            get { return _lang_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int agency_id
        {
            set { _agency_id = value; }
            get { return _agency_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? suppliers_id
        {
            set { _suppliers_id = value; }
            get { return _suppliers_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string todolist
        {
            set { _todolist = value; }
            get { return _todolist; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? role_id
        {
            set { _role_id = value; }
            get { return _role_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string admin_market_area
        {
            set { _admin_market_area = value; }
            get { return _admin_market_area; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string user_tel
        {
            set { _user_tel = value; }
            get { return _user_tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string user_qq
        {
            set { _user_qq = value; }
            get { return _user_qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nickname
        {
            set { _nickname = value; }
            get { return _nickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_lockable
        {
            set { _is_lockable = value; }
            get { return _is_lockable; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string higher
        {
            set { _higher = value; }
            get { return _higher; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? unix_timestamp
        {
            set { _unix_timestamp = value; }
            get { return _unix_timestamp; }
        }
        #endregion Model

    }
}

