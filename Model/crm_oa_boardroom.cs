using System;
namespace XHD.Model
{
	/// <summary>
	/// crm_oa_boardroom:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class crm_oa_boardroom
	{
		public crm_oa_boardroom()
		{}
		#region Model
		private int _id=0;
		private string _factory_id;
		private string _room_name;
		private int? _n_room_seat=0;
		private int? _n_projector=0;
		private int? _n_whiteboard=0;
		private int? _c_room_manageid;
		private string _c_room_managename;
		private int? _c_createid;
		private string _c_createname;
		private DateTime? _c_createdate;
        private double _F_room_acreage;
        private string _room_status;
        private int? _need_score;

        public int? Need_score
        {
            get { return _need_score; }
            set { _need_score = value; }
        }
        public string Room_status
        {
            get { return _room_status; }
            set { _room_status = value; }
        }
      
    
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
        public double F_room_acreage
        {
            set { _F_room_acreage = value; }
            get { return _F_room_acreage; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string factory_Id
		{
			set{ _factory_id=value;}
			get{return _factory_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string room_name
		{
			set{ _room_name=value;}
			get{return _room_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? N_room_seat
		{
			set{ _n_room_seat=value;}
			get{return _n_room_seat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? N_projector
		{
			set{ _n_projector=value;}
			get{return _n_projector;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? N_whiteboard
		{
			set{ _n_whiteboard=value;}
			get{return _n_whiteboard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? C_room_manageId
		{
			set{ _c_room_manageid=value;}
			get{return _c_room_manageid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_room_manageName
		{
			set{ _c_room_managename=value;}
			get{return _c_room_managename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? C_createId
		{
			set{ _c_createid=value;}
			get{return _c_createid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_createName
		{
			set{ _c_createname=value;}
			get{return _c_createname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? C_createDate
		{
			set{ _c_createdate=value;}
			get{return _c_createdate;}
		}
		#endregion Model

	}
}

