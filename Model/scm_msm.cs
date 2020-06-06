using System;

namespace XHD.Model
{
    /// <summary>
    /// scm_msm:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class scm_msm
    {
        public scm_msm()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _suppliers_id;
        private string _bustype;
        private string _tels;
        private string _msm;
        private string _remark;
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
        public string factory_id
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
        public string bustype
        {
            set { _bustype = value; }
            get { return _bustype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tels
        {
            set { _tels = value; }
            get { return _tels; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MSM
        {
            set { _msm = value; }
            get { return _msm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model

    }
}

