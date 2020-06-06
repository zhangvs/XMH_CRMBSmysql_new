using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_Model
{
    /// <summary>
    /// fms_supply_bank:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class fms_supply_bank
    {
        public fms_supply_bank()
        { }
        #region Model
        private int _id;
        private string _factoryid;
        private int? _suppliers_id;
        private string _suppliers_code;
        private string _suppliers_name;
        private string _supply_bank;
        private string _supply_bankcode;
        private int? _pay_count = 0;
        private int? _create_id;
        private string _create_code;
        private string _create_name;
        private DateTime? _create_date;
        private int? _is_stop = 0;
        /// <summary>
        /// 供应商银行帐号自增ID
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 所属单位
        /// </summary>
        public string factoryId
        {
            set { _factoryid = value; }
            get { return _factoryid; }
        }
        /// <summary>
        /// 供应商编号ID
        /// </summary>
        public int? suppliers_id
        {
            set { _suppliers_id = value; }
            get { return _suppliers_id; }
        }
        /// <summary>
        /// 供应商编码
        /// </summary>
        public string suppliers_code
        {
            set { _suppliers_code = value; }
            get { return _suppliers_code; }
        }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string suppliers_name
        {
            set { _suppliers_name = value; }
            get { return _suppliers_name; }
        }
        /// <summary>
        /// 供应商开户行
        /// </summary>
        public string supply_bank
        {
            set { _supply_bank = value; }
            get { return _supply_bank; }
        }
        /// <summary>
        /// 供应商银行账户
        /// </summary>
        public string supply_bankCode
        {
            set { _supply_bankcode = value; }
            get { return _supply_bankcode; }
        }
        /// <summary>
        /// 支付次数，收款次数
        /// </summary>
        public int? pay_count
        {
            set { _pay_count = value; }
            get { return _pay_count; }
        }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public int? create_Id
        {
            set { _create_id = value; }
            get { return _create_id; }
        }
        /// <summary>
        /// 创建人工号
        /// </summary>
        public string create_code
        {
            set { _create_code = value; }
            get { return _create_code; }
        }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string create_name
        {
            set { _create_name = value; }
            get { return _create_name; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_date
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        /// <summary>
        /// 是否停用标志；0-启用,默认，1-停用
        /// </summary>
        public int? Is_stop
        {
            set { _is_stop = value; }
            get { return _is_stop; }
        }
        #endregion Model
    }
}
