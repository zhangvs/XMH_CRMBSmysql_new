using System;
namespace XHD.Model
{
    /// <summary>
    /// dms_monthnode_sale:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class dms_monthnode_sale
    {
        public dms_monthnode_sale()
        { }
        #region Model
        private int _id;
        private string _year;
        private string _monthnode;
        private string _admin_user_name;
        private string _name;
        private string _d_pid;
        private string _d_pname;
        private decimal? _salemoney_personal;
        private decimal? _backmoney_personal;
        private decimal? _realmoney_personal;
        private decimal? _base_personal;
        private decimal? _plan_personal;
        private decimal? _cha_personal;
        private decimal? _wcl_personal;
        private decimal? _personal_bonus;
        private decimal? _personal_champion;
        private DateTime? _create_time;
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
        public string year
        {
            set { _year = value; }
            get { return _year; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string monthnode
        {
            set { _monthnode = value; }
            get { return _monthnode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string admin_user_name
        {
            set { _admin_user_name = value; }
            get { return _admin_user_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string d_pid
        {
            set { _d_pid = value; }
            get { return _d_pid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string d_pname
        {
            set { _d_pname = value; }
            get { return _d_pname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? salemoney_personal
        {
            set { _salemoney_personal = value; }
            get { return _salemoney_personal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? backmoney_personal
        {
            set { _backmoney_personal = value; }
            get { return _backmoney_personal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? realmoney_personal
        {
            set { _realmoney_personal = value; }
            get { return _realmoney_personal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? base_personal
        {
            set { _base_personal = value; }
            get { return _base_personal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? plan_personal
        {
            set { _plan_personal = value; }
            get { return _plan_personal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_personal
        {
            set { _cha_personal = value; }
            get { return _cha_personal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? wcl_personal
        {
            set { _wcl_personal = value; }
            get { return _wcl_personal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? personal_bonus
        {
            set { _personal_bonus = value; }
            get { return _personal_bonus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? personal_champion
        {
            set { _personal_champion = value; }
            get { return _personal_champion; }
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

