using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace XHD.Model
{
    /// <summary>
    /// crm_customer_grab:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_customer_grab
    {
        public crm_customer_grab()
        { }
        #region Model
        private int _id;
        private int? _pubpri_detail_id;
        private string _factory_id;
        private int? _customer_id;
        private string _customer_name;
        private int? _c_createid;
        private string _c_createname;
        private DateTime? _c_createdate;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pubpri_detail_Id
        {
            set { _pubpri_detail_id = value; }
            get { return _pubpri_detail_id; }
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
        public int? Customer_Id
        {
            set { _customer_id = value; }
            get { return _customer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Customer_name
        {
            set { _customer_name = value; }
            get { return _customer_name; }
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
        #endregion Model

    }
}

