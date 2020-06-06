using System;
namespace XHD.Model
{
    /// <summary>
    /// scm_dear_relate:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class scm_dear_relate
    {
        public scm_dear_relate()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _suppliers_name;
        private int? _suppliers_id;
        private int? _dear_id;
        private string _dear_name;
        private int? _children_id;
        private string _children_name;
        private DateTime? _cerate_time;
        private int? _create_id;
        private string _create_name;
        /// <summary>
        /// 
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
        public string suppliers_name
        {
            set { _suppliers_name = value; }
            get { return _suppliers_name; }
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
        public int? children_id
        {
            set { _children_id = value; }
            get { return _children_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string children_name
        {
            set { _children_name = value; }
            get { return _children_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? cerate_time
        {
            set { _cerate_time = value; }
            get { return _cerate_time; }
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
        #endregion Model

    }
}

