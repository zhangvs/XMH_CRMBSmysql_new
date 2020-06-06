using System;
namespace XHD.Model
{
    /// <summary>
    /// dms_set_bonus_team:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class dms_set_bonus_team
    {
        public dms_set_bonus_team()
        { }
        #region Model
        private int _id;
        private int? _d_id;
        private string _d_name;
        private int? _db_100;
        private int? _db_90;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? d_id
        {
            set { _d_id = value; }
            get { return _d_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string d_name
        {
            set { _d_name = value; }
            get { return _d_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? db_100
        {
            set { _db_100 = value; }
            get { return _db_100; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? db_90
        {
            set { _db_90 = value; }
            get { return _db_90; }
        }
        #endregion Model

    }
}

