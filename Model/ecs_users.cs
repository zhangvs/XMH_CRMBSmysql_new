using System;
namespace XHD.Model
{
	/// <summary>
	/// ecs_users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ecs_users
	{
		public ecs_users()
		{}
		#region Model
		private int _user_id;
		private string _aite_id;
		private string _email;
		private string _user_name;
		private int _is_user_name_checked=0;
		private string _u_company;
		private string _u_real_name;
		private string _erp_custom_code;
		private string _password;
		private string _question;
		private string _answer;
		private int _sex=0;
		private DateTime _birthday;
		private decimal _user_money=0.00M;
		private decimal _frozen_money=0.00M;
		private int _pay_points=0;
		private int _rank_points=0;
		private int _address_id;
		private int _reg_time=0;
		private int _last_login=0;
        private DateTime _last_time ;
		private string _last_ip;
		private int _visit_count=0;
		private int _user_rank=0;
		private int _is_special=0;
		private string _ec_salt;
		private string _salt= "0";
		private int _parent_id;
		private int _flag=0;
		private string _alias;
		private string _msn;
		private string _qq;
		private string _office_phone;
		private string _home_phone;
		private string _mobile_phone;
		private int _is_validated=0;
		private decimal _credit_line;
		private string _passwd_question;
		private string _passwd_answer;
		private string _mediauid;
		private int _mediaid;
		private string _user_market_area= "0";
		private string _admin_user_name;
		private int _admin_user_id;
		private string _admin_u_real_name;
		private int? _is_daifa=0;
		private string _send_user_name;
		private string _send_user_tel;
		private string _send_user_company;
		private string _send_user_address;
		private string _user_from;
		private string _user_beizhu;
		private int _is_erp_archives=1;
		private decimal _yes_invoiced_money=0.0000M;
		private decimal _no_invoiced_money=0.0000M;
		private string _aite_user_name;
		private decimal _dakuan;
		private int _dealer_id=0;
		private int _main_user_id;
		private int _user_status=1;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string aite_id
		{
			set{ _aite_id=value;}
			get{return _aite_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_user_name_checked
		{
			set{ _is_user_name_checked=value;}
			get{return _is_user_name_checked;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_company
		{
			set{ _u_company=value;}
			get{return _u_company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_real_name
		{
			set{ _u_real_name=value;}
			get{return _u_real_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string erp_custom_code
		{
			set{ _erp_custom_code=value;}
			get{return _erp_custom_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string question
		{
			set{ _question=value;}
			get{return _question;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string answer
		{
			set{ _answer=value;}
			get{return _answer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal user_money
		{
			set{ _user_money=value;}
			get{return _user_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal frozen_money
		{
			set{ _frozen_money=value;}
			get{return _frozen_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pay_points
		{
			set{ _pay_points=value;}
			get{return _pay_points;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int rank_points
		{
			set{ _rank_points=value;}
			get{return _rank_points;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int address_id
		{
			set{ _address_id=value;}
			get{return _address_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int reg_time
		{
			set{ _reg_time=value;}
			get{return _reg_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int last_login
		{
			set{ _last_login=value;}
			get{return _last_login;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime last_time
		{
			set{ _last_time=value;}
			get{return _last_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string last_ip
		{
			set{ _last_ip=value;}
			get{return _last_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int visit_count
		{
			set{ _visit_count=value;}
			get{return _visit_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int user_rank
		{
			set{ _user_rank=value;}
			get{return _user_rank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_special
		{
			set{ _is_special=value;}
			get{return _is_special;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ec_salt
		{
			set{ _ec_salt=value;}
			get{return _ec_salt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string salt
		{
			set{ _salt=value;}
			get{return _salt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int parent_id
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string alias
		{
			set{ _alias=value;}
			get{return _alias;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string msn
		{
			set{ _msn=value;}
			get{return _msn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string office_phone
		{
			set{ _office_phone=value;}
			get{return _office_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string home_phone
		{
			set{ _home_phone=value;}
			get{return _home_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mobile_phone
		{
			set{ _mobile_phone=value;}
			get{return _mobile_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_validated
		{
			set{ _is_validated=value;}
			get{return _is_validated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal credit_line
		{
			set{ _credit_line=value;}
			get{return _credit_line;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string passwd_question
		{
			set{ _passwd_question=value;}
			get{return _passwd_question;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string passwd_answer
		{
			set{ _passwd_answer=value;}
			get{return _passwd_answer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mediaUID
		{
			set{ _mediauid=value;}
			get{return _mediauid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mediaID
		{
			set{ _mediaid=value;}
			get{return _mediaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_market_area
		{
			set{ _user_market_area=value;}
			get{return _user_market_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string admin_user_name
		{
			set{ _admin_user_name=value;}
			get{return _admin_user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int admin_user_id
		{
			set{ _admin_user_id=value;}
			get{return _admin_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string admin_u_real_name
		{
			set{ _admin_u_real_name=value;}
			get{return _admin_u_real_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_daifa
		{
			set{ _is_daifa=value;}
			get{return _is_daifa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string send_user_name
		{
			set{ _send_user_name=value;}
			get{return _send_user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string send_user_tel
		{
			set{ _send_user_tel=value;}
			get{return _send_user_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string send_user_company
		{
			set{ _send_user_company=value;}
			get{return _send_user_company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string send_user_address
		{
			set{ _send_user_address=value;}
			get{return _send_user_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_from
		{
			set{ _user_from=value;}
			get{return _user_from;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_beizhu
		{
			set{ _user_beizhu=value;}
			get{return _user_beizhu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_erp_archives
		{
			set{ _is_erp_archives=value;}
			get{return _is_erp_archives;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal yes_invoiced_money
		{
			set{ _yes_invoiced_money=value;}
			get{return _yes_invoiced_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal no_invoiced_money
		{
			set{ _no_invoiced_money=value;}
			get{return _no_invoiced_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string aite_user_name
		{
			set{ _aite_user_name=value;}
			get{return _aite_user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal dakuan
		{
			set{ _dakuan=value;}
			get{return _dakuan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int dealer_id
		{
			set{ _dealer_id=value;}
			get{return _dealer_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int main_user_id
		{
			set{ _main_user_id=value;}
			get{return _main_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int user_status
		{
			set{ _user_status=value;}
			get{return _user_status;}
		}
		#endregion Model

	}
}

