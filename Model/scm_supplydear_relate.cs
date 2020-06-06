using System;
namespace XHD.Model
{
    /// <summary>
    /// scm_supplydear_relate:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class scm_supplydear_relate
    {
        public scm_supplydear_relate()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _suppliers_id;
        private string _suppliers_name;
        private int? _dear_id;
        private string _dear_name;
        private string _descpt;
        private string _type;
        private string _handle_name;
        private int? _handle_id;
        private DateTime? _handle_time;
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
        public int? suppliers_id
        {
            set { _suppliers_id = value; }
            get { return _suppliers_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suppliers_name
        {
            set { _suppliers_name = value; }
            get { return _suppliers_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? dear_id
        {
            set { _dear_id = value; }
            get { return _dear_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dear_name
        {
            set { _dear_name = value; }
            get { return _dear_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string descpt
        {
            set { _descpt = value; }
            get { return _descpt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string handle_name
        {
            set { _handle_name = value; }
            get { return _handle_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? handle_id
        {
            set { _handle_id = value; }
            get { return _handle_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? handle_time
        {
            set { _handle_time = value; }
            get { return _handle_time; }
        }
        #endregion Model

    }
}

