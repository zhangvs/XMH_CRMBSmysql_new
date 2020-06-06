using System;
namespace XHD.Model
{
    /// <summary>
    /// ecs_shop_config:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ecs_shop_config
    {
        public ecs_shop_config()
        { }
        #region Model
        private int _id;
        private int _parent_id = 0;
        private string _code;
        private string _type;
        private string _store_range;
        private string _store_dir;
        private string _value;
        private int _sort_order = 1;
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
        public int parent_id
        {
            set { _parent_id = value; }
            get { return _parent_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string code
        {
            set { _code = value; }
            get { return _code; }
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
        public string store_range
        {
            set { _store_range = value; }
            get { return _store_range; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string store_dir
        {
            set { _store_dir = value; }
            get { return _store_dir; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string value
        {
            set { _value = value; }
            get { return _value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sort_order
        {
            set { _sort_order = value; }
            get { return _sort_order; }
        }
        #endregion Model

    }
}

