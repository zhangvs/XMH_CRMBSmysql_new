using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model
{
    /// <summary>
    /// crm_sys_param:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_sys_param
    {
        public crm_sys_param()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _key_code;
        private string _key_value;
        private string _key_des;
        private int? _key_sort = 0;
        private string _key_type;
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
        public string factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string key_Code
        {
            set { _key_code = value; }
            get { return _key_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string key_Value
        {
            set { _key_value = value; }
            get { return _key_value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string key_Des
        {
            set { _key_des = value; }
            get { return _key_des; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? key_Sort
        {
            set { _key_sort = value; }
            get { return _key_sort; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string key_Type
        {
            set { _key_type = value; }
            get { return _key_type; }
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


