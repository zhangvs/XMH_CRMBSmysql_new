using System;

namespace XHD.Model.ims
{
    /// <summary>
    /// ims_lead_score_average:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ims_lead_score_average
    {
        public ims_lead_score_average()
        { }
        #region Model
        private int _id;
        private int? _year;
        private int? _month;
        private int? _rule_id;
        private int? _emp_id;
        private string _emp_name;
        private int? _d_id;
        private string _d_name;
        private int? _d_emp_total;
        private int? _real_check_num;
        private decimal? _score_total;
        private decimal? _score_average;

        public string Factory_Id { get; set; }
        public string check_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 年
        /// </summary>
        public int? year
        {
            set { _year = value; }
            get { return _year; }
        }
        /// <summary>
        /// 月
        /// </summary>
        public int? month
        {
            set { _month = value; }
            get { return _month; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? rule_id
        {
            set { _rule_id = value; }
            get { return _rule_id; }
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
        /// 部门Id
        /// </summary>
        public int? d_id
        {
            set { _d_id = value; }
            get { return _d_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string d_name
        {
            set { _d_name = value; }
            get { return _d_name; }
        }
        /// <summary>
        /// 部门所拥有的员工数
        /// </summary>
        public int? d_emp_total
        {
            set { _d_emp_total = value; }
            get { return _d_emp_total; }
        }
        /// <summary>
        /// 实际打分人数
        /// </summary>
        public int? real_check_num
        {
            set { _real_check_num = value; }
            get { return _real_check_num; }
        }
        /// <summary>
        /// 总分
        /// </summary>
        public decimal? score_total
        {
            set { _score_total = value; }
            get { return _score_total; }
        }
        /// <summary>
        /// 平均分
        /// </summary>
        public decimal? score_average
        {
            set { _score_average = value; }
            get { return _score_average; }
        }
        #endregion Model

    }
}

