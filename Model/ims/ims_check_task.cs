using System;

namespace XHD.Model.ims
{
    /// <summary>
    /// ims_check_task:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ims_check_task
    {
        public ims_check_task()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _rule_id;
        private string _task_name;
        private string _task_remark;
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
        /// 表ims_check_rule中的id
        /// </summary>
        public int? rule_id
        {
            set { _rule_id = value; }
            get { return _rule_id; }
        }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string task_name
        {
            set { _task_name = value; }
            get { return _task_name; }
        }
        /// <summary>
        /// 项目备注
        /// </summary>
        public string task_remark
        {
            set { _task_remark = value; }
            get { return _task_remark; }
        }
        #endregion Model

    }
}

