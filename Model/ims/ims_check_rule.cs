using System;

namespace XHD.Model.ims
{
    /// <summary>
    /// ims_check_rule:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ims_check_rule
    {
        public ims_check_rule()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _rule_name;
        private int? _rule_categoryid;
        private string _rule_category;
        private string _rule_classify;
        private string _rule_object;
        private string _check_cycle;
        private string _check_empid;
        private string _check_empname;
        private string _check_emp_depid;
        private string _apply_depid;
        private string _apply_userid;
        private string _apply_username;
        private int? _creat_empid;
        private string _create_empname;
        private DateTime? _create_date;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 工厂ID
        /// </summary>
        public string Factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 考核规则名称
        /// </summary>
        public string rule_name
        {
            set { _rule_name = value; }
            get { return _rule_name; }
        }
        /// <summary>
        /// 类目ID
        /// </summary>
        public int? rule_categoryId
        {
            set { _rule_categoryid = value; }
            get { return _rule_categoryid; }
        }
        /// <summary>
        /// 类目
        /// </summary>
        public string rule_category
        {
            set { _rule_category = value; }
            get { return _rule_category; }
        }
        /// <summary>
        /// 分类：0：公共项（通用项） 1:特殊项(带标准的)，2：特殊项(不带标准的)
        /// </summary>
        public string rule_classify
        {
            set { _rule_classify = value; }
            get { return _rule_classify; }
        }
        /// <summary>
        /// 规则适用对象：1：普通员工；2：部门负责人
        /// </summary>
        public string rule_object
        {
            set { _rule_object = value; }
            get { return _rule_object; }
        }
        /// <summary>
        /// 考核周期：1:天、2:节点、3:月
        /// </summary>
        public string check_cycle
        {
            set { _check_cycle = value; }
            get { return _check_cycle; }
        }
        /// <summary>
        /// 考核人Id
        /// </summary>
        public string check_empId
        {
            set { _check_empid = value; }
            get { return _check_empid; }
        }
        /// <summary>
        /// 考核人
        /// </summary>
        public string check_empName
        {
            set { _check_empname = value; }
            get { return _check_empname; }
        }
        /// <summary>
        /// 考核人部门Id
        /// </summary>
        public string check_emp_depId
        {
            set { _check_emp_depid = value; }
            get { return _check_emp_depid; }
        }
        /// <summary>
        /// 适用部门Id：-1表示所有部门
        /// </summary>
        public string apply_depId
        {
            set { _apply_depid = value; }
            get { return _apply_depid; }
        }
        /// <summary>
        /// 适用人员Id：-1表示所有人员
        /// </summary>
        public string apply_userId
        {
            set { _apply_userid = value; }
            get { return _apply_userid; }
        }
        /// <summary>
        /// 适用人员：-1表示所有人员
        /// </summary>
        public string apply_userName
        {
            set { _apply_username = value; }
            get { return _apply_username; }
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

