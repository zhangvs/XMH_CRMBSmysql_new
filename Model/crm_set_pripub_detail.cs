using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model
{
    /// <summary>
    /// crm_set_pripub_detail:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_set_pripub_detail
    {
        public crm_set_pripub_detail()
        { }
        #region Model
        private int _id = 0;
        private string _factory_id;
        private int? _current_year;
        private string _pripub_type;
        private int? _date_start;
        private int? _date_end;
        private decimal? _feat;
        private int? _c_createid;
        private string _c_createname;
        private DateTime? _c_createdate;
        private int? _move_qty;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? current_year
        {
            set { _current_year = value; }
            get { return _current_year; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pripub_type
        {
            set { _pripub_type = value; }
            get { return _pripub_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? date_start
        {
            set { _date_start = value; }
            get { return _date_start; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? date_end
        {
            set { _date_end = value; }
            get { return _date_end; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? feat
        {
            set { _feat = value; }
            get { return _feat; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? C_createId
        {
            set { _c_createid = value; }
            get { return _c_createid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_createName
        {
            set { _c_createname = value; }
            get { return _c_createname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? C_createDate
        {
            set { _c_createdate = value; }
            get { return _c_createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? move_Qty
        {
            set { _move_qty = value; }
            get { return _move_qty; }
        }
        #endregion Model

    }
}

