using System;
namespace XHD.Model
{
    /// <summary>
    /// shop_region:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_region
    {
        public shop_region()
        { }
        #region Model
        private int _region_id;
        private int _parent_id = 0;
        private string _region_name;
        private int _region_type = 2;
        private int _agency_id = 0;
        /// <summary>
        /// 区域编码
        /// </summary>
        public int region_id
        {
            set { _region_id = value; }
            get { return _region_id; }
        }
        /// <summary>
        /// 区域父级编码
        /// </summary>
        public int parent_id
        {
            set { _parent_id = value; }
            get { return _parent_id; }
        }
        /// <summary>
        /// 区域名称
        /// </summary>
        public string region_name
        {
            set { _region_name = value; }
            get { return _region_name; }
        }
        /// <summary>
        /// 当前地区的级0一级，1=二级，2=三级以此类推 
        /// </summary>
        public int region_type
        {
            set { _region_type = value; }
            get { return _region_type; }
        }
        /// <summary>
        /// 办事处（机构）编码
        /// </summary>
        public int agency_id
        {
            set { _agency_id = value; }
            get { return _agency_id; }
        }
        #endregion Model

    }
}

