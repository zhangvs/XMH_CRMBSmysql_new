using System;
namespace XHD.Model
{
    /// <summary>
    /// sys_manage:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class sys_manage
    {
        public sys_manage()
        { }
        #region Model
        private int _id;
        private string _sys_name;
        private string _sys_shorthand;
        private string _sys_sdesc;
        private int _sys_order;
        private string _sys_url;
        private string _sys_handler;
        private string _sys_type;
        private string _sys_icon;
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
        public string sys_name
        {
            set { _sys_name = value; }
            get { return _sys_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sys_shorthand
        {
            set { _sys_shorthand = value; }
            get { return _sys_shorthand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sys_sdesc
        {
            set { _sys_sdesc = value; }
            get { return _sys_sdesc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sys_order
        {
            set { _sys_order = value; }
            get { return _sys_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sys_url
        {
            set { _sys_url = value; }
            get { return _sys_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sys_handler
        {
            set { _sys_handler = value; }
            get { return _sys_handler; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sys_type
        {
            set { _sys_type = value; }
            get { return _sys_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sys_icon
        {
            set { _sys_icon = value; }
            get { return _sys_icon; }
        }
        #endregion Model

    }
}

