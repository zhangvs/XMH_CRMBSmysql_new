using System;
namespace XHD.Model
{
    /// <summary>
    /// ecs_goods_activity:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ecs_goods_activity
    {
        public ecs_goods_activity()
        { }
        #region Model
        private int _act_id;
        private string _act_name;
        private string _act_desc;
        private int _act_type;
        private int _goods_id;
        private int _product_id;
        private string _goods_name;
        private int _start_time;
        private int _end_time;
        private int _is_finished;
        private string _ext_info;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int act_id
        {
            set { _act_id = value; }
            get { return _act_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string act_name
        {
            set { _act_name = value; }
            get { return _act_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string act_desc
        {
            set { _act_desc = value; }
            get { return _act_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int act_type
        {
            set { _act_type = value; }
            get { return _act_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int goods_id
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int product_id
        {
            set { _product_id = value; }
            get { return _product_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int start_time
        {
            set { _start_time = value; }
            get { return _start_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int end_time
        {
            set { _end_time = value; }
            get { return _end_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_finished
        {
            set { _is_finished = value; }
            get { return _is_finished; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext_info
        {
            set { _ext_info = value; }
            get { return _ext_info; }
        }
        #endregion Model

    }
}

