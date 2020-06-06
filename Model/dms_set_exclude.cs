using System;
namespace XHD.Model
{
    /// <summary>
    /// dms_set_exclude:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class dms_set_exclude
    {
        public dms_set_exclude()
        { }
        #region Model
        private int _id;
        private string _exclude_did;
        private string _exclude_dname;
        private string _exclude_emp_code;
        private string _exclude_emp_name;
        private DateTime? _create_time;
        private string _create_name;
        private string _factory_id;
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
        public string exclude_did
        {
            set { _exclude_did = value; }
            get { return _exclude_did; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string exclude_dname
        {
            set { _exclude_dname = value; }
            get { return _exclude_dname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string exclude_emp_code
        {
            set { _exclude_emp_code = value; }
            get { return _exclude_emp_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string exclude_emp_name
        {
            set { _exclude_emp_name = value; }
            get { return _exclude_emp_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? create_time
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string create_name
        {
            set { _create_name = value; }
            get { return _create_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string factory_id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        #endregion Model

    }
}

