using System;

namespace XHD.Model
{
    /// <summary>
    /// scm_msmsend:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class scm_msmsend
    {
        public scm_msmsend()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private int? _suppliers_id;
        private string _bustype;
        private string _tels;
        private string _sendmsm;
        private string _senddate;
        private int? _sendpersonid;
        private string _sendperson;
        private string _msgresults;
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
        public string sendMSM
        {
            set { _sendmsm = value; }
            get { return _sendmsm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sendDate
        {
            set { _senddate = value; }
            get { return _senddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? sendPersonid
        {
            set { _sendpersonid = value; }
            get { return _sendpersonid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sendPerson
        {
            set { _sendperson = value; }
            get { return _sendperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string msgresults
        {
            set { _msgresults = value; }
            get { return _msgresults; }
        }
        #endregion Model

    }
}
