using System;
namespace XHD.Model
{
    /// <summary>
    /// hr_Wage_Info:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class hr_Wage_Info
    {
        #region Model
        private int _id;
        private int? _emp_id;
        private string _emp_name;
        private int? _emp_dept_id;
        private string _date_emp;
        private long? _wage_month;
        private decimal? _wage_runday;
        private decimal? _wage_base;
        private decimal? _wage_miss;
        private decimal? _wage_full;
        private decimal? _wage_late;
        private decimal? _wage_runno_debit;
        private decimal? _wage_real;
        private decimal? _wage_base_actual;
        private decimal? _wage_jixiao;
        private decimal? _wage_bonus;
        private decimal? _wage_work_years;
        private decimal? _wage_grant_phone;
        private decimal? _wage_grant_othe;
        private decimal? _wage_total_should;
        private decimal? _wage_debit_meals;
        private decimal? _wage_debit_social;
        private decimal? _wage_debit_othe;
        private decimal? _wage_debit_total;
        private int? _emp_score;
        private decimal? _wage_score;
        private decimal? _wage_total_all;
        private string _wage_remark;
        private string _wage_date;
        private string _creat_date;
        private string _creat_userid;
        private string _creat_username;

        public string Factory_Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Emp_Id
        {
            set { _emp_id = value; }
            get { return _emp_id; }
        }

        public string Emp_Name
        {
            set { _emp_name = value; }
            get { return _emp_name; }
        }
        /// <summary>
        /// 所属部门
        /// </summary>
        public int? Emp_Dept_Id
        {
            set { _emp_dept_id = value; }
            get { return _emp_dept_id; }
        }

        public string Date_Emp
        {
            set { _date_emp = value; }
            get { return _date_emp; }
        }
        /// <summary>
        /// 
        /// </summary>
        ///
        public long? Wage_Month
        {
            set { _wage_month = value; }
            get { return _wage_month; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Wage_RunDay
        {
            set { _wage_runday = value; }
            get { return _wage_runday; }
        }
        /// <summary>
        /// 基本工资标准
        /// </summary>
        public decimal? Wage_Base
        {
            set { _wage_base = value; }
            get { return _wage_base; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Wage_Miss
        {
            set { _wage_miss = value; }
            get { return _wage_miss; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Wage_Full
        {
            set { _wage_full = value; }
            get { return _wage_full; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Wage_Late
        {
            set { _wage_late = value; }
            get { return _wage_late; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Wage_RunNo_Debit
        {
            set { _wage_runno_debit = value; }
            get { return _wage_runno_debit; }
        }
        /// <summary>
        /// 正式工资，转正工资
        /// </summary>
        public decimal? Wage_Real
        {
            set { _wage_real = value; }
            get { return _wage_real; }
        }
        /// <summary>
        /// 实发基本工资
        /// </summary>
        public decimal? Wage_Base_Actual
        {
            set { _wage_base_actual = value; }
            get { return _wage_base_actual; }
        }
        /// <summary>
        /// 绩效工资
        /// </summary>
        public decimal? Wage_JiXiao
        {
            set { _wage_jixiao = value; }
            get { return _wage_jixiao; }
        }
        /// <summary>
        /// 奖金
        /// </summary>
        public decimal? Wage_Bonus
        {
            set { _wage_bonus = value; }
            get { return _wage_bonus; }
        }
        /// <summary>
        /// 工龄工资
        /// </summary>
        public decimal? Wage_Work_Years
        {
            set { _wage_work_years = value; }
            get { return _wage_work_years; }
        }
        /// <summary>
        /// 通讯补助
        /// </summary>
        public decimal? Wage_Grant_Phone
        {
            set { _wage_grant_phone = value; }
            get { return _wage_grant_phone; }
        }
        /// <summary>
        /// 其他补助
        /// </summary>
        public decimal? Wage_Grant_Othe
        {
            set { _wage_grant_othe = value; }
            get { return _wage_grant_othe; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Wage_Total_Should
        {
            set { _wage_total_should = value; }
            get { return _wage_total_should; }
        }
        /// <summary>
        /// 餐费
        /// </summary>
        public decimal? Wage_Debit_Meals
        {
            set { _wage_debit_meals = value; }
            get { return _wage_debit_meals; }
        }
        /// <summary>
        /// 社保扣款
        /// </summary>
        public decimal? Wage_Debit_Social
        {
            set { _wage_debit_social = value; }
            get { return _wage_debit_social; }
        }
        /// <summary>
        /// 其他扣款
        /// </summary>
        public decimal? Wage_Debit_Othe
        {
            set { _wage_debit_othe = value; }
            get { return _wage_debit_othe; }
        }
        /// <summary>
        /// 应扣合计
        /// </summary>
        public decimal? Wage_Debit_Total
        {
            set { _wage_debit_total = value; }
            get { return _wage_debit_total; }
        }
        /// <summary>
        /// 员工积分
        /// </summary>
        public int? Emp_Score
        {
            set { _emp_score = value; }
            get { return _emp_score; }
        }
        /// <summary>
        /// 积分工资
        /// </summary>
        public decimal? Wage_Score
        {
            set { _wage_score = value; }
            get { return _wage_score; }
        }
        /// <summary>
        /// 实发工资，实发总工资
        /// </summary>
        public decimal? Wage_Total_All
        {
            set { _wage_total_all = value; }
            get { return _wage_total_all; }
        }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string Wage_Remark
        {
            set { _wage_remark = value; }
            get { return _wage_remark; }
        }
        /// <summary>
        /// 工资时间
        /// </summary>
        public string Wage_Date
        {
            set { _wage_date = value; }
            get { return _wage_date; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string Creat_Date
        {
            set { _creat_date = value; }
            get { return _creat_date; }
        }
        /// <summary>
        /// 创建人员工编号
        /// </summary>
        public string Creat_UserID
        {
            set { _creat_userid = value; }
            get { return _creat_userid; }
        }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string Creat_UserName
        {
            set { _creat_username = value; }
            get { return _creat_username; }
        }
        #endregion Model
    }
}
