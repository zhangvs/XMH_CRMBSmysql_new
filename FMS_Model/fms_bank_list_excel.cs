using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_Model
{
   /// <summary>
	/// fms_bank_list_excel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [Serializable]
    public partial class fms_bank_list_excel
    {
        public fms_bank_list_excel()
        { }
        #region Model
        private int _id;
        private long _collection_bank_id;
        private string _collection_bank_code;
        private string _collection_bank_name;
        private string _collection_account;
        private string _dk_time;
        private string _dk_time_only;
        private string _dk_money;
        private string _dk_account;
        private string _dk_username;
        private string _dk_bank_name;
        private string _dk_channel;
        private string _dk_message_remarks;
        private long _start_line;
        private int? _excel_exist_collection_account;
        private int? _sort = 99;
        private string _excel_type = "1";
        private int? _is_use = 1;
        private int? _is_show_full = 1;
        private int? _acc_type = 0;
        private int? _is_collect = 0;

        public int is_send_out { get; set; }

        /// <summary>
        /// 自增ID
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// ERP_ID;收款银行ID(erp的Ac_Items表中):
        /// </summary>
        public long collection_bank_id
        {
            set { _collection_bank_id = value; }
            get { return _collection_bank_id; }
        }
        /// <summary>
        /// ERP代码;收款银行代码(erp中的代码)
        /// </summary>
        public string collection_bank_code
        {
            set { _collection_bank_code = value; }
            get { return _collection_bank_code; }
        }
        /// <summary>
        /// 收款银行名称，银行名称
        /// </summary>
        public string collection_bank_name
        {
            set { _collection_bank_name = value; }
            get { return _collection_bank_name; }
        }
        /// <summary>
        /// 收款账号，银行帐号
        /// </summary>
        public string collection_account
        {
            set { _collection_account = value; }
            get { return _collection_account; }
        }
        /// <summary>
        /// 打款时间;打款日期所在Excel中的列名
        /// </summary>
        public string dk_time
        {
            set { _dk_time = value; }
            get { return _dk_time; }
        }
        /// <summary>
        /// 打款时间所在Excel中的列名
        /// </summary>
        public string dk_time_only
        {
            set { _dk_time_only = value; }
            get { return _dk_time_only; }
        }
        /// <summary>
        /// 打款金额;打款金额所在Excel中的列名
        /// </summary>
        public string dk_money
        {
            set { _dk_money = value; }
            get { return _dk_money; }
        }
        /// <summary>
        /// 打款帐号;打款账号所在Excel中的列名
        /// </summary>
        public string dk_account
        {
            set { _dk_account = value; }
            get { return _dk_account; }
        }
        /// <summary>
        /// 打款户名;打款户名所在Excel中的列名
        /// </summary>
        public string dk_username
        {
            set { _dk_username = value; }
            get { return _dk_username; }
        }
        /// <summary>
        /// 打款银行;打款银行所在Excel中的列名
        /// </summary>
        public string dk_bank_name
        {
            set { _dk_bank_name = value; }
            get { return _dk_bank_name; }
        }
        /// <summary>
        /// 渠道;打款渠道所在Excel中的列名
        /// </summary>
        public string dk_channel
        {
            set { _dk_channel = value; }
            get { return _dk_channel; }
        }
        /// <summary>
        /// 打款备注;打款备注所在Excel中的列名
        /// </summary>
        public string dk_message_remarks
        {
            set { _dk_message_remarks = value; }
            get { return _dk_message_remarks; }
        }
        /// <summary>
        /// 有效数据起始行;有效数据起始行
        /// </summary>
        public long start_line
        {
            set { _start_line = value; }
            get { return _start_line; }
        }
        /// <summary>
        /// 表格中是否包含收款账号(便于验证银行)
        /// </summary>
        public int? excel_exist_collection_account
        {
            set { _excel_exist_collection_account = value; }
            get { return _excel_exist_collection_account; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? sort
        {
            set { _sort = value; }
            get { return _sort; }
        }
        /// <summary>
        /// 银行导出的表格版本;Excel版本
        /// </summary>
        public string excel_type
        {
            set { _excel_type = value; }
            get { return _excel_type; }
        }
        /// <summary>
        /// 是否启用;1-启用,0-不启用
        /// </summary>
        public int? is_use
        {
            set { _is_use = value; }
            get { return _is_use; }
        }
        /// <summary>
        /// 打款账号是否全部显示;1-是,0-否
        /// </summary>
        public int? is_show_full
        {
            set { _is_show_full = value; }
            get { return _is_show_full; }
        }
        /// <summary>
        /// 开户类型；0-个人帐户 默认，1-公司账户
        /// </summary>
        public int? acc_type
        {
            set { _acc_type = value; }
            get { return _acc_type; }
        }
        /// <summary>
        /// 是否代收款银行；0-非代收款银行 默认,1-代收款银行
        /// </summary>
        public int? is_collect
        {
            set { _is_collect = value; }
            get { return _is_collect; }
        }
        #endregion Model
    }

}
