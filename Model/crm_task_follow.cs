using System;

namespace XHD.Model
{
    /// <summary>
    /// crm_task_follow:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_task_follow
    {
        public crm_task_follow()
        { }
        #region Model
        private int _id = 0;
        private string _factory_id;
        private int? _task_id;
        private string _task_type;
        private int? _follow_time;
        private string _follow_content;
        private int? _follow_status = 0;
        private string _follow_status_name;
        private int? _follow_empid;
        private string _follow_empname;
        /// <summary>
        /// 
        /// </summary>
        public int id
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
        public int? task_id
        {
            set { _task_id = value; }
            get { return _task_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string task_type
        {
            set { _task_type = value; }
            get { return _task_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? follow_time
        {
            set { _follow_time = value; }
            get { return _follow_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string follow_content
        {
            set { _follow_content = value; }
            get { return _follow_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? follow_status
        {
            set { _follow_status = value; }
            get { return _follow_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string follow_status_name
        {
            set { _follow_status_name = value; }
            get { return _follow_status_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? follow_empid
        {
            set { _follow_empid = value; }
            get { return _follow_empid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string follow_empname
        {
            set { _follow_empname = value; }
            get { return _follow_empname; }
        }
        #endregion Model

    }
}
