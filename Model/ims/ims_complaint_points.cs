using System;

namespace XHD.Model.ims
{
    /// <summary>
    /// ims_complaint_points:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ims_complaint_points
    {
        public ims_complaint_points()
        { }
        #region Model
        private int _id;
        private int? _apply_empid;
        private string _apply_empname;
        private int? _apply_managerid;
        private string _apply_managername;
        private int? _sued_empid;
        private string _sued_empname;
        private int? _sued_managerid;
        private string _sued_managername;
        private DateTime? _sued_data;
        private string _sued_remark;
        private int? _hand_empid;
        private string _hand_empname;
        private DateTime? _deal_date;
        private DateTime? _hand_data;
        private string _hand_remark;
        private string _state;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 申请投诉人ID
        /// </summary>
        public int? apply_empId
        {
            set { _apply_empid = value; }
            get { return _apply_empid; }
        }
        /// <summary>
        /// 申请投诉人姓名
        /// </summary>
        public string apply_empName
        {
            set { _apply_empname = value; }
            get { return _apply_empname; }
        }
        /// <summary>
        /// 申请投诉人部门经理ID
        /// </summary>
        public int? apply_managerId
        {
            set { _apply_managerid = value; }
            get { return _apply_managerid; }
        }
        /// <summary>
        /// 申请投诉人部门经理姓名
        /// </summary>
        public string apply_managerName
        {
            set { _apply_managername = value; }
            get { return _apply_managername; }
        }
        /// <summary>
        /// 被投诉人ID
        /// </summary>
        public int? sued_empId
        {
            set { _sued_empid = value; }
            get { return _sued_empid; }
        }
        /// <summary>
        /// 被投诉人姓名
        /// </summary>
        public string sued_empName
        {
            set { _sued_empname = value; }
            get { return _sued_empname; }
        }
        /// <summary>
        /// 被投诉人部门经理ID
        /// </summary>
        public int? sued_managerId
        {
            set { _sued_managerid = value; }
            get { return _sued_managerid; }
        }
        /// <summary>
        /// 被投诉人部门经理姓名
        /// </summary>
        public string sued_managerName
        {
            set { _sued_managername = value; }
            get { return _sued_managername; }
        }
        /// <summary>
        /// 投诉时间
        /// </summary>
        public DateTime? sued_data
        {
            set { _sued_data = value; }
            get { return _sued_data; }
        }
        /// <summary>
        /// 投诉内容
        /// </summary>
        public string sued_remark
        {
            set { _sued_remark = value; }
            get { return _sued_remark; }
        }
        /// <summary>
        /// 诉投受理人ID
        /// </summary>
        public int? hand_empId
        {
            set { _hand_empid = value; }
            get { return _hand_empid; }
        }
        /// <summary>
        /// 投诉受理人姓名
        /// </summary>
        public string hand_empName
        {
            set { _hand_empname = value; }
            get { return _hand_empname; }
        }
        /// <summary>
        /// 受理时间
        /// </summary>
        public DateTime? deal_date
        {
            set { _deal_date = value; }
            get { return _deal_date; }
        }
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime? hand_data
        {
            set { _hand_data = value; }
            get { return _hand_data; }
        }
        /// <summary>
        /// 处理意见
        /// </summary>
        public string hand_remark
        {
            set { _hand_remark = value; }
            get { return _hand_remark; }
        }
        /// <summary>
        /// 态状：0：申请 1：受理  2：处理完成
        /// </summary>
        public string state
        {
            set { _state = value; }
            get { return _state; }
        }
        #endregion Model

    }
}

