using System;

namespace XHD.Model
{
    /// <summary>
    /// crm_task:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_task
    {
        public crm_task()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _task_title;
        private string _task_content;
        private int? _task_type_id;
        private string _task_type_name;
        private int? _customer_id;
        private string _customer_name;
        private int? _executive_id;
        private string _executive_name;
        private int? _executive_time;
        private int? _task_status_id;
        private string _task_status_name;
        private string _priority;
        private int? _remind_time;
        private int? _ischeck = 0;
        private int? _create_id;
        private int? _create_time;
        private string _create_name;
        private int? _update_id;
        private string _update_name;
        private int? _update_time;
        private int? _pre_time;
        private int? _real_time;
        private int? _delay_time;
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
        public string factory_id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string task_title
        {
            set { _task_title = value; }
            get { return _task_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string task_content
        {
            set { _task_content = value; }
            get { return _task_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? task_type_id
        {
            set { _task_type_id = value; }
            get { return _task_type_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string task_type_name
        {
            set { _task_type_name = value; }
            get { return _task_type_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? customer_id
        {
            set { _customer_id = value; }
            get { return _customer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string customer_name
        {
            set { _customer_name = value; }
            get { return _customer_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? executive_id
        {
            set { _executive_id = value; }
            get { return _executive_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string executive_name
        {
            set { _executive_name = value; }
            get { return _executive_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? executive_time
        {
            set { _executive_time = value; }
            get { return _executive_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? task_status_id
        {
            set { _task_status_id = value; }
            get { return _task_status_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string task_status_name
        {
            set { _task_status_name = value; }
            get { return _task_status_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string priority
        {
            set { _priority = value; }
            get { return _priority; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? remind_time
        {
            set { _remind_time = value; }
            get { return _remind_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ischeck
        {
            set { _ischeck = value; }
            get { return _ischeck; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? create_id
        {
            set { _create_id = value; }
            get { return _create_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? create_time
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
        public int? update_id
        {
            set { _update_id = value; }
            get { return _update_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string update_name
        {
            set { _update_name = value; }
            get { return _update_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? update_time
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pre_time
        {
            set { _pre_time = value; }
            get { return _pre_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? real_time
        {
            set { _real_time = value; }
            get { return _real_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? delay_time
        {
            set { _delay_time = value; }
            get { return _delay_time; }
        }
        #endregion Model

    }
}

