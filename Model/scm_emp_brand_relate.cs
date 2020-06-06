using System;

namespace XHD.Model
{
    /// <summary>
    /// scm_emp_brand_relate:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class scm_emp_brand_relate
    {
        public scm_emp_brand_relate()
        { }
        #region Model
        private string _factory_id;
        private int _empid;
        private string _brandid;
        private int? _create_id;
        private string _create_name;
        private DateTime? _create_date;
        /// <summary>
        /// 
        /// </summary>
        public string factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int empId
        {
            set { _empid = value; }
            get { return _empid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string brandId
        {
            set { _brandid = value; }
            get { return _brandid; }
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
        public DateTime? create_date
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        #endregion Model

    }
}

