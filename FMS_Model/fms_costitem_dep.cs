using System;

namespace FMS_Model
{
    /// <summary>
    /// fms_costitem_dep:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class fms_costitem_dep
    {
        public fms_costitem_dep()
        { }
        #region Model
        private int _id;
        private int _dep_id;
        private string _code_str;
        private string _creater;
        private DateTime? _create_time;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 部门编号
        /// </summary>
        public int dep_id
        {
            set { _dep_id = value; }
            get { return _dep_id; }
        }
        /// <summary>
        /// costitem  code以","隔开
        /// </summary>
        public string code_str
        {
            set { _code_str = value; }
            get { return _code_str; }
        }
        /// <summary>
        /// 工号
        /// </summary>
        public string creater
        {
            set { _creater = value; }
            get { return _creater; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? create_time
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        #endregion Model

    }
}

