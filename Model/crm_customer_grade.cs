using System;
namespace XHD.Model
{
    /// <summary>
    /// crm_customer_grade:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_customer_grade
    {
        public crm_customer_grade()
        { }
        #region Model
        private int _grade_id;
        private string _factory_id;
        private string _group_id;
        private string _grade_code;
        private string _grade_name;
        private int? _grade_order;
        private int? _create_id;
        private string _create_name;
        /// <summary>
        /// 自增id
        /// </summary>
        public int grade_id
        {
            set { _grade_id = value; }
            get { return _grade_id; }
        }
        /// <summary>
        /// 单位id
        /// </summary>
        public string factory_id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 所属群体
        /// </summary>
        public string group_id
        {
            set { _group_id = value; }
            get { return _group_id; }
        }
        /// <summary>
        /// 等级编码
        /// </summary>
        public string grade_code
        {
            set { _grade_code = value; }
            get { return _grade_code; }
        }
        /// <summary>
        /// 等级名称
        /// </summary>
        public string grade_name
        {
            set { _grade_name = value; }
            get { return _grade_name; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? grade_order
        {
            set { _grade_order = value; }
            get { return _grade_order; }
        }
        /// <summary>
        /// 创建id
        /// </summary>
        public int? create_id
        {
            set { _create_id = value; }
            get { return _create_id; }
        }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string create_name
        {
            set { _create_name = value; }
            get { return _create_name; }
        }
        #endregion Model

    }
}

