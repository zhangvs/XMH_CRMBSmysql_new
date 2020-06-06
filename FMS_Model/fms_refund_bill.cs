using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_Model
{
    /// <summary>
    /// fms_refund_bill:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class fms_refund_bill
    {
        public fms_refund_bill()
        { }
        #region Model
        private int _refund_id;
        private string _refund_sn;
        private int _refund_type = 0;
        private int _refund_status = 0;
        private int? _emp_id;
        private string _emp_code;
        private string _emp_name;
        private DateTime? _apply_date;
        private int? _user_id;
        private int? _customer_id;
        private string _customer_name;
        private decimal _refund_money = 0.00M;
        private string _refund_capital_money;
        private string _refund_remark;
        private string _refund_bank_name;
        private string _refund_bank_account;
        private string _pay_method;
        private string _pay_method_name;
        private int? _pay_id;
        private string _pay_code;
        private string _pay_name;
        private DateTime? _pay_date;
        private int? _approvalone_id;
        private string _approvalone_code;
        private string _approvalone_name;
        private DateTime? _approvalone_date;
        private int? _approvaltwo_id;
        private string _approvaltwo_code;
        private string _approvaltwo_name;
        private DateTime? _approvaltwo_date;
        private int? _approvalthree_id;
        private string _approvalthree_code;
        private string _approvalthree_name;
        private DateTime? _approvalthree_date;
        private int? _approvalfour_id;
        private string _approvalfour_code;
        private string _approvalfour_name;
        private DateTime? _approvalfour_date;
        private int _is_del = 0;
        private string _kingdee_current_account;
        private int _is_send_out = 0;
        private string _kingdee_in_code;
        private string _kingdee_out_code;
        private int? _print_num = 0;

        public int send_out_reason { get; set; }

        /// <summary>
        /// 自增ID
        /// </summary>
        public int refund_id
        {
            set { _refund_id = value; }
            get { return _refund_id; }
        }
        /// <summary>
        /// 退款单号
        /// </summary>
        public string refund_sn
        {
            set { _refund_sn = value; }
            get { return _refund_sn; }
        }
        /// <summary>
        /// 退款审核级数：0：三级审核；1：四级审核
        /// </summary>
        public int refund_type
        {
            set { _refund_type = value; }
            get { return _refund_type; }
        }
        /// <summary>
        /// 退款状态：0.待审核，1：客服经理通过审核，2：客服经理未通过审核，3：财务通过审核，4：财务未通过审核，5：财务经理通过审核，6：财务经理未通过审核，7：最终通过审核，8：最终为通过审核 9：待付款；10：已付款
        /// </summary>
        public int refund_status
        {
            set { _refund_status = value; }
            get { return _refund_status; }
        }
        /// <summary>
        /// 申请人id
        /// </summary>
        public int? emp_id
        {
            set { _emp_id = value; }
            get { return _emp_id; }
        }
        /// <summary>
        /// 申请人工号
        /// </summary>
        public string emp_code
        {
            set { _emp_code = value; }
            get { return _emp_code; }
        }
        /// <summary>
        /// 申请人姓名
        /// </summary>
        public string emp_name
        {
            set { _emp_name = value; }
            get { return _emp_name; }
        }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime? apply_date
        {
            set { _apply_date = value; }
            get { return _apply_date; }
        }
        /// <summary>
        /// 联系人ID
        /// </summary>
        public int? user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 客户ID
        /// </summary>
        public int? customer_id
        {
            set { _customer_id = value; }
            get { return _customer_id; }
        }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string customer_name
        {
            set { _customer_name = value; }
            get { return _customer_name; }
        }
        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal refund_money
        {
            set { _refund_money = value; }
            get { return _refund_money; }
        }
        /// <summary>
        /// 退款金额大写
        /// </summary>
        public string refund_capital_money
        {
            set { _refund_capital_money = value; }
            get { return _refund_capital_money; }
        }
        /// <summary>
        /// 退款原因
        /// </summary>
        public string refund_remark
        {
            set { _refund_remark = value; }
            get { return _refund_remark; }
        }
        /// <summary>
        /// 退款开户行
        /// </summary>
        public string refund_bank_name
        {
            set { _refund_bank_name = value; }
            get { return _refund_bank_name; }
        }
        /// <summary>
        /// 退款开户账号户名
        /// </summary>
        public string refund_bank_account
        {
            set { _refund_bank_account = value; }
            get { return _refund_bank_account; }
        }
        /// <summary>
        /// 付款方式，fms_bank_list_excel表中collection_bank_code
        /// </summary>
        public string pay_method
        {
            set { _pay_method = value; }
            get { return _pay_method; }
        }
        /// <summary>
        /// 付款方式名称，fms_bank_list_excel表中collection_bank_name
        /// </summary>
        public string pay_method_name
        {
            set { _pay_method_name = value; }
            get { return _pay_method_name; }
        }
        /// <summary>
        /// 付款人ID
        /// </summary>
        public int? pay_id
        {
            set { _pay_id = value; }
            get { return _pay_id; }
        }
        /// <summary>
        /// 付款人工号
        /// </summary>
        public string pay_code
        {
            set { _pay_code = value; }
            get { return _pay_code; }
        }
        /// <summary>
        /// 付款人姓名
        /// </summary>
        public string pay_name
        {
            set { _pay_name = value; }
            get { return _pay_name; }
        }
        /// <summary>
        /// 付款时间
        /// </summary>
        public DateTime? pay_date
        {
            set { _pay_date = value; }
            get { return _pay_date; }
        }
        /// <summary>
        /// 一级审核：客服经理ID
        /// </summary>
        public int? approvalOne_id
        {
            set { _approvalone_id = value; }
            get { return _approvalone_id; }
        }
        /// <summary>
        /// 一级审核：客服经理工号
        /// </summary>
        public string approvalOne_code
        {
            set { _approvalone_code = value; }
            get { return _approvalone_code; }
        }
        /// <summary>
        /// 一级审核：客服经理姓名
        /// </summary>
        public string approvalOne_name
        {
            set { _approvalone_name = value; }
            get { return _approvalone_name; }
        }
        /// <summary>
        /// 一级审核时间
        /// </summary>
        public DateTime? approvalOne_date
        {
            set { _approvalone_date = value; }
            get { return _approvalone_date; }
        }
        /// <summary>
        /// 二级审核：财务一级审核人ID
        /// </summary>
        public int? approvalTwo_id
        {
            set { _approvaltwo_id = value; }
            get { return _approvaltwo_id; }
        }
        /// <summary>
        /// 二级审核：财务一级审核人工号
        /// </summary>
        public string approvalTwo_code
        {
            set { _approvaltwo_code = value; }
            get { return _approvaltwo_code; }
        }
        /// <summary>
        /// 二级审核：财务一级审核人姓名
        /// </summary>
        public string approvalTwo_name
        {
            set { _approvaltwo_name = value; }
            get { return _approvaltwo_name; }
        }
        /// <summary>
        /// 二级审核时间
        /// </summary>
        public DateTime? approvalTwo_date
        {
            set { _approvaltwo_date = value; }
            get { return _approvaltwo_date; }
        }
        /// <summary>
        /// 三级审核：财务经理ID
        /// </summary>
        public int? approvalThree_id
        {
            set { _approvalthree_id = value; }
            get { return _approvalthree_id; }
        }
        /// <summary>
        /// 三级审核：财务经理工号
        /// </summary>
        public string approvalThree_code
        {
            set { _approvalthree_code = value; }
            get { return _approvalthree_code; }
        }
        /// <summary>
        /// 三级审核：财务经理姓名
        /// </summary>
        public string approvalThree_name
        {
            set { _approvalthree_name = value; }
            get { return _approvalthree_name; }
        }
        /// <summary>
        /// 三级审核时间
        /// </summary>
        public DateTime? approvalThree_date
        {
            set { _approvalthree_date = value; }
            get { return _approvalthree_date; }
        }
        /// <summary>
        /// 四级审核人ID
        /// </summary>
        public int? approvalFour_id
        {
            set { _approvalfour_id = value; }
            get { return _approvalfour_id; }
        }
        /// <summary>
        /// 四级审核人工号
        /// </summary>
        public string approvalFour_code
        {
            set { _approvalfour_code = value; }
            get { return _approvalfour_code; }
        }
        /// <summary>
        /// 四级审核人姓名
        /// </summary>
        public string approvalFour_name
        {
            set { _approvalfour_name = value; }
            get { return _approvalfour_name; }
        }
        /// <summary>
        /// 四级审核时间
        /// </summary>
        public DateTime? approvalFour_date
        {
            set { _approvalfour_date = value; }
            get { return _approvalfour_date; }
        }
        /// <summary>
        /// 删除标志：0：未删除；1：已删除
        /// </summary>
        public int is_del
        {
            set { _is_del = value; }
            get { return _is_del; }
        }
        /// <summary>
        /// 金蝶中的往来科目
        /// </summary>
        public string kingdee_current_account
        {
            set { _kingdee_current_account = value; }
            get { return _kingdee_current_account; }
        }
        /// <summary>
        /// 是否需要发送外账：0：不需要，1：需要
        /// </summary>
        public int is_send_out
        {
            set { _is_send_out = value; }
            get { return _is_send_out; }
        }
        /// <summary>
        /// 内账金蝶号
        /// </summary>
        public string kingdee_in_code
        {
            set { _kingdee_in_code = value; }
            get { return _kingdee_in_code; }
        }
        /// <summary>
        /// 外账金蝶号
        /// </summary>
        public string kingdee_out_code
        {
            set { _kingdee_out_code = value; }
            get { return _kingdee_out_code; }
        }
        /// <summary>
        /// 打印次数
        /// </summary>
        public int? print_num
        {
            set { _print_num = value; }
            get { return _print_num; }
        }
        #endregion Model

    }
}


