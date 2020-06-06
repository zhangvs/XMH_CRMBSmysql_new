using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model
{
    /// <summary>
    /// crm_follow_end:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_follow_end
    {
        public crm_follow_end()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _customer_id_end;
        private string _customer_name_end;
        private string _follow;
        private DateTime? _follow_date;
        private int? _follow_type_id;
        private string _follow_type;
        private int? _department_id;
        private string _department_name;
        private int? _employee_id;
        private string _employee_name;
        private int? _isdelete;
        private DateTime? _delete_time;
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
        public int? Customer_id_end
        {
            set { _customer_id_end = value; }
            get { return _customer_id_end; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Customer_name_end
        {
            set { _customer_name_end = value; }
            get { return _customer_name_end; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Follow
        {
            set { _follow = value; }
            get { return _follow; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Follow_date
        {
            set { _follow_date = value; }
            get { return _follow_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Follow_Type_id
        {
            set { _follow_type_id = value; }
            get { return _follow_type_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Follow_Type
        {
            set { _follow_type = value; }
            get { return _follow_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? department_id
        {
            set { _department_id = value; }
            get { return _department_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string department_name
        {
            set { _department_name = value; }
            get { return _department_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? employee_id
        {
            set { _employee_id = value; }
            get { return _employee_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string employee_name
        {
            set { _employee_name = value; }
            get { return _employee_name; }
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
        #endregion Model

    }
}

