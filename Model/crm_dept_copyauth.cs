using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model
{
    /// <summary>
    /// crm_dept_copyauth:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_dept_copyauth
    {
        public crm_dept_copyauth()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _emp_id;
        private string _emp_name;
        private int? _dept_id;
        private string _dept_name;
        private string _c_valid_date = "1";
        private int? _c_createid;
        private string _c_createname;
        private DateTime? _c_createdate;
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
        public int? emp_Id
        {
            set { _emp_id = value; }
            get { return _emp_id; }
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
        public int? dept_Id
        {
            set { _dept_id = value; }
            get { return _dept_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dept_name
        {
            set { _dept_name = value; }
            get { return _dept_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_valid_Date
        {
            set { _c_valid_date = value; }
            get { return _c_valid_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? C_createId
        {
            set { _c_createid = value; }
            get { return _c_createid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_createName
        {
            set { _c_createname = value; }
            get { return _c_createname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? C_createDate
        {
            set { _c_createdate = value; }
            get { return _c_createdate; }
        }
        #endregion Model

    }
}

