using System;
namespace XHD.Model
{
    /// <summary>
    /// dms_brand_percentage:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class dms_brand_percentage
    {
        public dms_brand_percentage()
        { }
        #region Model
        private int _id;
        private string _year;
        private string _month;
        private string _bc_user_name;
        private string _bc_real_name;
        private string _bc_brand_id;
        private string _bc_brand_name;
        private decimal? _base_brand;
        private decimal? _plan_brand;
        private decimal? _bp_percentage;
        private decimal? _salemoney_brand;
        private decimal? _backmoney_brand;
        private decimal? _realmoney_brand;
        private decimal? _cha_brand;
        private decimal? _wcl_brand;
        private decimal? _percentage_brand;
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
        public string month
        {
            set { _month = value; }
            get { return _month; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bc_user_name
        {
            set { _bc_user_name = value; }
            get { return _bc_user_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bc_real_name
        {
            set { _bc_real_name = value; }
            get { return _bc_real_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bc_brand_id
        {
            set { _bc_brand_id = value; }
            get { return _bc_brand_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bc_brand_name
        {
            set { _bc_brand_name = value; }
            get { return _bc_brand_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? base_brand
        {
            set { _base_brand = value; }
            get { return _base_brand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? plan_brand
        {
            set { _plan_brand = value; }
            get { return _plan_brand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? bp_percentage
        {
            set { _bp_percentage = value; }
            get { return _bp_percentage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? salemoney_brand
        {
            set { _salemoney_brand = value; }
            get { return _salemoney_brand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? backmoney_brand
        {
            set { _backmoney_brand = value; }
            get { return _backmoney_brand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? realmoney_brand
        {
            set { _realmoney_brand = value; }
            get { return _realmoney_brand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_brand
        {
            set { _cha_brand = value; }
            get { return _cha_brand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? wcl_brand
        {
            set { _wcl_brand = value; }
            get { return _wcl_brand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? percentage_brand
        {
            set { _percentage_brand = value; }
            get { return _percentage_brand; }
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

