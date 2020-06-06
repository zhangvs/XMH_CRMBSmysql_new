using System;

namespace XHD.Model.ims
{
    /// <summary>
    /// ims_check_cycle:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ims_check_cycle
    {
        public ims_check_cycle()
        { }

        #region Model
        private int _id;
        private string _cycle_name;
        private int? _cycle_day;
        private string _cycle_remark;
        private int? _creat_empid;
        private string _create_empname;
        private DateTime? _create_date;
        public int cycle_Id { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 考核周期名称
        /// </summary>
        public string cycle_name
        {
            set { _cycle_name = value; }
            get { return _cycle_name; }
        }
        /// <summary>
        /// 考核周期
        /// </summary>
        public int? cycle_day
        {
            set { _cycle_day = value; }
            get { return _cycle_day; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string cycle_remark
        {
            set { _cycle_remark = value; }
            get { return _cycle_remark; }
        }
        /// <summary>
        /// 创建者ID
        /// </summary>
        public int? creat_empId
        {
            set { _creat_empid = value; }
            get { return _creat_empid; }
        }
        /// <summary>
        /// 创建者姓名
        /// </summary>
        public string create_empName
        {
            set { _create_empname = value; }
            get { return _create_empname; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_date
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        #endregion Model

    }
}

