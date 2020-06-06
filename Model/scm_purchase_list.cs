using System;

namespace XHD.Model
{
    /// <summary>
    /// scm_purchase_list:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class scm_purchase_list
    {
        public scm_purchase_list()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _suppliers_id;
        private int _goods_id;
        private string _goods_sn2;
        private string _goods_name;
        private int? _purchase_total;
        private string _dhxlk_djhm;
        private string _suppliers_erp_code;
        private DateTime? _purchase_data;

        public string purchase_order { get; set; }

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
        public int? suppliers_id
        {
            set { _suppliers_id = value; }
            get { return _suppliers_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int goods_id
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_sn2
        {
            set { _goods_sn2 = value; }
            get { return _goods_sn2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? purchase_Total
        {
            set { _purchase_total = value; }
            get { return _purchase_total; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dhxlk_DJHM
        {
            set { _dhxlk_djhm = value; }
            get { return _dhxlk_djhm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suppliers_erp_code
        {
            set { _suppliers_erp_code = value; }
            get { return _suppliers_erp_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? purchase_Data
        {
            set { _purchase_data = value; }
            get { return _purchase_data; }
        }
        #endregion Model

    }
}

