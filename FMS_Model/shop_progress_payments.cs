using System;

namespace FMS_Model
{
    /// <summary>
    /// shop_progress_payments:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_progress_payments
    {
        public shop_progress_payments()
        { }
        #region Model
        private int _id;
        private int _type;
        private string _order_sn;
        private int _add_time;
        private decimal _money = 0.000M;
        private int _user_id;
        private int _employee_id;
        private string _emp_code;
        private string _msg;
        private int _status = 1;
        private int? _start_valid_time = 0;
        private decimal? _user_yingshou;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 1 发货(+)  2 打款(-) 3 退货(-) 4 调账
        /// </summary>
        public int type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 往来款相应的主表单号
        /// </summary>
        public string order_sn
        {
            set { _order_sn = value; }
            get { return _order_sn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 往来款金额,发货,调账加存正数; 打款,退货,调账减 存负数; 
        /// </summary>
        public decimal money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 管理员ID
        /// </summary>
        public int employee_id
        {
            set { _employee_id = value; }
            get { return _employee_id; }
        }
        /// <summary>
        /// 工号
        /// </summary>
        public string emp_code
        {
            set { _emp_code = value; }
            get { return _emp_code; }
        }
        /// <summary>
        /// 往来款备注
        /// </summary>
        public string msg
        {
            set { _msg = value; }
            get { return _msg; }
        }
        /// <summary>
        /// 1 有效 2 无效
        /// </summary>
        public int status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 记录开始生效日期,等于订单表中发货/发erp日期加临时账期
        /// </summary>
        public int? start_valid_time
        {
            set { _start_valid_time = value; }
            get { return _start_valid_time; }
        }
        /// <summary>
        /// 客户应收款 ---(客户余额的负值)
        /// </summary>
        public decimal? user_yingshou
        {
            set { _user_yingshou = value; }
            get { return _user_yingshou; }
        }
        #endregion Model

    }
}

