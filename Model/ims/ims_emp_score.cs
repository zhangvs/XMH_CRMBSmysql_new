using System;

namespace XHD.Model.ims
{
    /// <summary>
    /// ims_emp_score:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ims_emp_score
    {
        public ims_emp_score()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _d_id;
        private string _d_name;
        private int? _emp_id;
        private string _emp_name;
        private int? _rule_id;
        private string _isplus;
        private decimal? _score;
        private int? _check_empid;
        private string _check_empname;
        private string _check_date;
        private string _check_remark;

        public string score_source { get; set; }
        public string rule_name { get; set; }
        public int complaint_id { get; set; }

        public DateTime operate_date { get; set; }

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
        public string Factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 部门id
        /// </summary>
        public int? d_id
        {
            set { _d_id = value; }
            get { return _d_id; }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string d_name
        {
            set { _d_name = value; }
            get { return _d_name; }
        }
        /// <summary>
        /// 员工id
        /// </summary>
        public int? emp_id
        {
            set { _emp_id = value; }
            get { return _emp_id; }
        }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string emp_name
        {
            set { _emp_name = value; }
            get { return _emp_name; }
        }
        /// <summary>
        /// 考核规则id
        /// </summary>
        public int? rule_id
        {
            set { _rule_id = value; }
            get { return _rule_id; }
        }
      
        /// <summary>
        /// 表示加分或减分：0：减分； 1：加分
        /// </summary>
        public string isPlus
        {
            set { _isplus = value; }
            get { return _isplus; }
        }
        /// <summary>
        /// 分值
        /// </summary>
        public decimal? score
        {
            set { _score = value; }
            get { return _score; }
        }
        /// <summary>
        /// 考核人
        /// </summary>
        public int? check_empId
        {
            set { _check_empid = value; }
            get { return _check_empid; }
        }
        /// <summary>
        /// 考核人姓名
        /// </summary>
        public string check_empName
        {
            set { _check_empname = value; }
            get { return _check_empname; }
        }
        /// <summary>
        /// 考核时间
        /// </summary>
        public string check_date
        {
            set { _check_date = value; }
            get { return _check_date; }
        }
        /// <summary>
        /// 考核注备
        /// </summary>
        public string check_remark
        {
            set { _check_remark = value; }
            get { return _check_remark; }
        }
        #endregion Model

    }
}

