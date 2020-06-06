using System;

namespace XHD.Model
{
    /// <summary>
    /// ssn_art:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ssn_art
    {
        public ssn_art()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _art_title;
        private string _art_title_en;
        private int? _art_menu_id;
        private string _art_content;
        private string _image_lst;
        private int? _art_order = 0;
        private int? _is_del = 0;
        private string _creater_uid;
        private string _creater_name;
        private DateTime? _create_date;
        private int? _creater_id;
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
        public string Art_title
        {
            set { _art_title = value; }
            get { return _art_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Art_title_en
        {
            set { _art_title_en = value; }
            get { return _art_title_en; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Art_Menu_Id
        {
            set { _art_menu_id = value; }
            get { return _art_menu_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Art_Content
        {
            set { _art_content = value; }
            get { return _art_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string image_lst
        {
            set { _image_lst = value; }
            get { return _image_lst; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Art_order
        {
            set { _art_order = value; }
            get { return _art_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_del
        {
            set { _is_del = value; }
            get { return _is_del; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Creater_Uid
        {
            set { _creater_uid = value; }
            get { return _creater_uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Creater_Name
        {
            set { _creater_name = value; }
            get { return _creater_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Create_Date
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Creater_Id
        {
            set { _creater_id = value; }
            get { return _creater_id; }
        }
        #endregion Model

    }
}

