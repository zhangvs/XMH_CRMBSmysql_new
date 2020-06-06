using System;
namespace XHD.Model
{
    /// <summary>
    /// crm_using_feedback:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CRM_using_feedback
    {
        public CRM_using_feedback()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _usefeedback_title;
        private string _usefeedback_content;
        private int? _create_id;
        private string _create_name;
        private DateTime? _create_time;
        private int? _ischanged;
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
        public string usefeedback_title
        {
            set { _usefeedback_title = value; }
            get { return _usefeedback_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string usefeedback_content
        {
            set { _usefeedback_content = value; }
            get { return _usefeedback_content; }
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
        public string create_name
        {
            set { _create_name = value; }
            get { return _create_name; }
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
        public int? isChanged
        {
            set { _ischanged = value; }
            get { return _ischanged; }
        }
        #endregion Model

    }
}
