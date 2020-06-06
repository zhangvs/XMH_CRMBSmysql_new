using System;
namespace XHD.Model
{
    /// <summary>
    /// ssn_question:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ssn_question
    {
        public ssn_question()
        { }
        #region Model
        private long _id;
        private DateTime? _q_time;
        private string _title;
        private int? _q_uid = -1;
        private string _q_name;
        private int? _type = 0;
        private string _content;
        private int? _score = 0;
        private string _sp_uid = ",all,";
        private string _sp_name;
        private string _att_file;
        private int? _re_uid = -1;
        private string _re_name;
        private DateTime? _move_time;
        private int? _status=0;
        private string _tel;
        private string _e_mail;
        private int? _receive_type = 0;
        private int? _isdeleted = 0;
        /// <summary>
        /// auto_increment
        /// </summary>
        public long id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? q_time
        {
            set { _q_time = value; }
            get { return _q_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? q_uid
        {
            set { _q_uid = value; }
            get { return _q_uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string q_name
        {
            set { _q_name = value; }
            get { return _q_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? score
        {
            set { _score = value; }
            get { return _score; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sp_uid
        {
            set { _sp_uid = value; }
            get { return _sp_uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sp_name
        {
            set { _sp_name = value; }
            get { return _sp_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string att_file
        {
            set { _att_file = value; }
            get { return _att_file; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? re_uid
        {
            set { _re_uid = value; }
            get { return _re_uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string re_name
        {
            set { _re_name = value; }
            get { return _re_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? move_time
        {
            set { _move_time = value; }
            get { return _move_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? status
        {
            set { _status = value; }
            get { return _status; }
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
        public string e_mail
        {
            set { _e_mail = value; }
            get { return _e_mail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? receive_type
        {
            set { _receive_type = value; }
            get { return _receive_type; }
        }
        public int? isdeleted
        {
            set { _isdeleted = value; }
            get { return _isdeleted; }
        }
        #endregion Model

    }

    [Serializable]
    public partial class question
    {
        public question()
        { }
        #region Model
        private long _id;
        private DateTime? _q_time;
        private string _title;
        private int? _status;
      
        /// <summary>
        /// auto_increment
        /// </summary>
        public long id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? q_time
        {
            set { _q_time = value; }
            get { return _q_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
     
        /// <summary>
        /// 
        /// </summary>
        public int? status
        {
            set { _status = value; }
            get { return _status; }
        }
   
        #endregion Model

    }
}

