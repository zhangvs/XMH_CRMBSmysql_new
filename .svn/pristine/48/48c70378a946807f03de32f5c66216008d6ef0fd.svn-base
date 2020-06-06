using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_users
    /// </summary>
    public partial class ecs_users
    {
        public ecs_users()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int user_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_users");
            strSql.Append(" where user_id=@user_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32)
			};
            parameters[0].Value = user_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        public bool CheckUserExists(string tel, int dealer_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_users where user_name like '%" + tel + "' and dealer_id='"+dealer_id+"'");

            //strSql.Append("select count(1) from ecs_users");
            //strSql.Append(" where user_name=@user_name");
           

            return DbHelperMySQL.Exists(strSql.ToString());
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_users(");
            strSql.Append("aite_id,email,user_name,is_user_name_checked,u_company,u_real_name,erp_custom_code,password,question,answer,sex,birthday,user_money,frozen_money,pay_points,rank_points,address_id,reg_time,last_login,last_time,last_ip,visit_count,user_rank,is_special,ec_salt,salt,parent_id,flag,alias,msn,qq,office_phone,home_phone,mobile_phone,is_validated,credit_line,passwd_question,passwd_answer,mediaUID,mediaID,user_market_area,admin_user_name,admin_user_id,admin_u_real_name,is_daifa,send_user_name,send_user_tel,send_user_company,send_user_address,user_from,user_beizhu,is_erp_archives,yes_invoiced_money,no_invoiced_money,aite_user_name,dakuan,dealer_id,main_user_id,user_status)");
            strSql.Append(" values (");
            strSql.Append("@aite_id,@email,@user_name,@is_user_name_checked,@u_company,@u_real_name,@erp_custom_code,@password,@question,@answer,@sex,@birthday,@user_money,@frozen_money,@pay_points,@rank_points,@address_id,@reg_time,@last_login,@last_time,@last_ip,@visit_count,@user_rank,@is_special,@ec_salt,@salt,@parent_id,@flag,@alias,@msn,@qq,@office_phone,@home_phone,@mobile_phone,@is_validated,@credit_line,@passwd_question,@passwd_answer,@mediaUID,@mediaID,@user_market_area,@admin_user_name,@admin_user_id,@admin_u_real_name,@is_daifa,@send_user_name,@send_user_tel,@send_user_company,@send_user_address,@user_from,@user_beizhu,@is_erp_archives,@yes_invoiced_money,@no_invoiced_money,@aite_user_name,@dakuan,@dealer_id,@main_user_id,@user_status)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@aite_id", MySqlDbType.Text),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@is_user_name_checked", MySqlDbType.Int32,1),
					new MySqlParameter("@u_company", MySqlDbType.VarChar,60),
					new MySqlParameter("@u_real_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@erp_custom_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@password", MySqlDbType.VarChar,32),
					new MySqlParameter("@question", MySqlDbType.VarChar,255),
					new MySqlParameter("@answer", MySqlDbType.VarChar,255),
					new MySqlParameter("@sex", MySqlDbType.Int32,1),
					new MySqlParameter("@birthday", MySqlDbType.Date),
					new MySqlParameter("@user_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@frozen_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@pay_points", MySqlDbType.Int32,10),
					new MySqlParameter("@rank_points", MySqlDbType.Int32,10),
					new MySqlParameter("@address_id", MySqlDbType.Int32,8),
					new MySqlParameter("@reg_time", MySqlDbType.Int32,10),
					new MySqlParameter("@last_login", MySqlDbType.Int32,11),
					new MySqlParameter("@last_time", MySqlDbType.DateTime),
					new MySqlParameter("@last_ip", MySqlDbType.VarChar,15),
					new MySqlParameter("@visit_count", MySqlDbType.Int32,5),
					new MySqlParameter("@user_rank", MySqlDbType.Int32,3),
					new MySqlParameter("@is_special", MySqlDbType.Int32,3),
					new MySqlParameter("@ec_salt", MySqlDbType.VarChar,10),
					new MySqlParameter("@salt", MySqlDbType.VarChar,10),
					new MySqlParameter("@parent_id", MySqlDbType.Int32,9),
					new MySqlParameter("@flag", MySqlDbType.Int32,3),
					new MySqlParameter("@alias", MySqlDbType.VarChar,60),
					new MySqlParameter("@msn", MySqlDbType.VarChar,60),
					new MySqlParameter("@qq", MySqlDbType.VarChar,20),
					new MySqlParameter("@office_phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@home_phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@mobile_phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@is_validated", MySqlDbType.Int32,3),
					new MySqlParameter("@credit_line", MySqlDbType.Decimal,10),
					new MySqlParameter("@passwd_question", MySqlDbType.VarChar,50),
					new MySqlParameter("@passwd_answer", MySqlDbType.VarChar,255),
					new MySqlParameter("@mediaUID", MySqlDbType.VarChar,50),
					new MySqlParameter("@mediaID", MySqlDbType.Int32,4),
					new MySqlParameter("@user_market_area", MySqlDbType.VarChar,30),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@admin_user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_u_real_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@is_daifa", MySqlDbType.Int32,2),
					new MySqlParameter("@send_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_tel", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_company", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_address", MySqlDbType.VarChar,30),
					new MySqlParameter("@user_from", MySqlDbType.VarChar,30),
					new MySqlParameter("@user_beizhu", MySqlDbType.Text),
					new MySqlParameter("@is_erp_archives", MySqlDbType.Int32,1),
					new MySqlParameter("@yes_invoiced_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@no_invoiced_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@aite_user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@dakuan", MySqlDbType.Decimal,10),
					new MySqlParameter("@dealer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@main_user_id", MySqlDbType.Int32,8),
					new MySqlParameter("@user_status", MySqlDbType.Int32,1)};
            parameters[0].Value = model.aite_id;
            parameters[1].Value = model.email;
            parameters[2].Value = model.user_name;
            parameters[3].Value = model.is_user_name_checked;
            parameters[4].Value = model.u_company;
            parameters[5].Value = model.u_real_name;
            parameters[6].Value = model.erp_custom_code;
            parameters[7].Value = model.password;
            parameters[8].Value = model.question;
            parameters[9].Value = model.answer;
            parameters[10].Value = model.sex;
            parameters[11].Value = model.birthday;
            parameters[12].Value = model.user_money;
            parameters[13].Value = model.frozen_money;
            parameters[14].Value = model.pay_points;
            parameters[15].Value = model.rank_points;
            parameters[16].Value = model.address_id;
            parameters[17].Value = model.reg_time;
            parameters[18].Value = model.last_login;
            parameters[19].Value = model.last_time;
            parameters[20].Value = model.last_ip;
            parameters[21].Value = model.visit_count;
            parameters[22].Value = model.user_rank;
            parameters[23].Value = model.is_special;
            parameters[24].Value = model.ec_salt;
            parameters[25].Value = model.salt;
            parameters[26].Value = model.parent_id;
            parameters[27].Value = model.flag;
            parameters[28].Value = model.alias;
            parameters[29].Value = model.msn;
            parameters[30].Value = model.qq;
            parameters[31].Value = model.office_phone;
            parameters[32].Value = model.home_phone;
            parameters[33].Value = model.mobile_phone;
            parameters[34].Value = model.is_validated;
            parameters[35].Value = model.credit_line;
            parameters[36].Value = model.passwd_question;
            parameters[37].Value = model.passwd_answer;
            parameters[38].Value = model.mediaUID;
            parameters[39].Value = model.mediaID;
            parameters[40].Value = model.user_market_area;
            parameters[41].Value = model.admin_user_name;
            parameters[42].Value = model.admin_user_id;
            parameters[43].Value = model.admin_u_real_name;
            parameters[44].Value = model.is_daifa;
            parameters[45].Value = model.send_user_name;
            parameters[46].Value = model.send_user_tel;
            parameters[47].Value = model.send_user_company;
            parameters[48].Value = model.send_user_address;
            parameters[49].Value = model.user_from;
            parameters[50].Value = model.user_beizhu;
            parameters[51].Value = model.is_erp_archives;
            parameters[52].Value = model.yes_invoiced_money;
            parameters[53].Value = model.no_invoiced_money;
            parameters[54].Value = model.aite_user_name;
            parameters[55].Value = model.dakuan;
            parameters[56].Value = model.dealer_id;
            parameters[57].Value = model.main_user_id;
            parameters[58].Value = model.user_status;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ecs_users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_users set ");
            strSql.Append("aite_id=@aite_id,");
            strSql.Append("email=@email,");
            strSql.Append("user_name=@user_name,");
            strSql.Append("is_user_name_checked=@is_user_name_checked,");
            strSql.Append("u_company=@u_company,");
            strSql.Append("u_real_name=@u_real_name,");
            strSql.Append("erp_custom_code=@erp_custom_code,");
            strSql.Append("password=@password,");
            strSql.Append("question=@question,");
            strSql.Append("answer=@answer,");
            strSql.Append("sex=@sex,");
            strSql.Append("birthday=@birthday,");
            strSql.Append("user_money=@user_money,");
            strSql.Append("frozen_money=@frozen_money,");
            strSql.Append("pay_points=@pay_points,");
            strSql.Append("rank_points=@rank_points,");
            strSql.Append("address_id=@address_id,");
            strSql.Append("reg_time=@reg_time,");
            strSql.Append("last_login=@last_login,");
            strSql.Append("last_time=@last_time,");
            strSql.Append("last_ip=@last_ip,");
            strSql.Append("visit_count=@visit_count,");
            strSql.Append("user_rank=@user_rank,");
            strSql.Append("is_special=@is_special,");
            strSql.Append("ec_salt=@ec_salt,");
            strSql.Append("salt=@salt,");
            strSql.Append("parent_id=@parent_id,");
            strSql.Append("flag=@flag,");
            strSql.Append("alias=@alias,");
            strSql.Append("msn=@msn,");
            strSql.Append("qq=@qq,");
            strSql.Append("office_phone=@office_phone,");
            strSql.Append("home_phone=@home_phone,");
            strSql.Append("mobile_phone=@mobile_phone,");
            strSql.Append("is_validated=@is_validated,");
            strSql.Append("credit_line=@credit_line,");
            strSql.Append("passwd_question=@passwd_question,");
            strSql.Append("passwd_answer=@passwd_answer,");
            strSql.Append("mediaUID=@mediaUID,");
            strSql.Append("mediaID=@mediaID,");
            strSql.Append("user_market_area=@user_market_area,");
            strSql.Append("admin_user_name=@admin_user_name,");
            strSql.Append("admin_user_id=@admin_user_id,");
            strSql.Append("admin_u_real_name=@admin_u_real_name,");
            strSql.Append("is_daifa=@is_daifa,");
            strSql.Append("send_user_name=@send_user_name,");
            strSql.Append("send_user_tel=@send_user_tel,");
            strSql.Append("send_user_company=@send_user_company,");
            strSql.Append("send_user_address=@send_user_address,");
            strSql.Append("user_from=@user_from,");
            strSql.Append("user_beizhu=@user_beizhu,");
            strSql.Append("is_erp_archives=@is_erp_archives,");
            strSql.Append("yes_invoiced_money=@yes_invoiced_money,");
            strSql.Append("no_invoiced_money=@no_invoiced_money,");
            strSql.Append("aite_user_name=@aite_user_name,");
            strSql.Append("dakuan=@dakuan,");
            strSql.Append("dealer_id=@dealer_id,");
            strSql.Append("main_user_id=@main_user_id,");
            strSql.Append("user_status=@user_status");
            strSql.Append(" where user_id=@user_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@aite_id", MySqlDbType.Text),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@is_user_name_checked", MySqlDbType.Int32,1),
					new MySqlParameter("@u_company", MySqlDbType.VarChar,60),
					new MySqlParameter("@u_real_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@erp_custom_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@password", MySqlDbType.VarChar,32),
					new MySqlParameter("@question", MySqlDbType.VarChar,255),
					new MySqlParameter("@answer", MySqlDbType.VarChar,255),
					new MySqlParameter("@sex", MySqlDbType.Int32,1),
					new MySqlParameter("@birthday", MySqlDbType.Int32),
					new MySqlParameter("@user_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@frozen_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@pay_points", MySqlDbType.Int32,10),
					new MySqlParameter("@rank_points", MySqlDbType.Int32,10),
					new MySqlParameter("@address_id", MySqlDbType.Int32,8),
					new MySqlParameter("@reg_time", MySqlDbType.Int32,10),
					new MySqlParameter("@last_login", MySqlDbType.Int32,11),
					new MySqlParameter("@last_time", MySqlDbType.DateTime),
					new MySqlParameter("@last_ip", MySqlDbType.VarChar,15),
					new MySqlParameter("@visit_count", MySqlDbType.Int32,5),
					new MySqlParameter("@user_rank", MySqlDbType.Int32,3),
					new MySqlParameter("@is_special", MySqlDbType.Int32,3),
					new MySqlParameter("@ec_salt", MySqlDbType.VarChar,10),
					new MySqlParameter("@salt", MySqlDbType.VarChar,10),
					new MySqlParameter("@parent_id", MySqlDbType.Int32,9),
					new MySqlParameter("@flag", MySqlDbType.Int32,3),
					new MySqlParameter("@alias", MySqlDbType.VarChar,60),
					new MySqlParameter("@msn", MySqlDbType.VarChar,60),
					new MySqlParameter("@qq", MySqlDbType.VarChar,20),
					new MySqlParameter("@office_phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@home_phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@mobile_phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@is_validated", MySqlDbType.Int32,3),
					new MySqlParameter("@credit_line", MySqlDbType.Decimal,10),
					new MySqlParameter("@passwd_question", MySqlDbType.VarChar,50),
					new MySqlParameter("@passwd_answer", MySqlDbType.VarChar,255),
					new MySqlParameter("@mediaUID", MySqlDbType.VarChar,50),
					new MySqlParameter("@mediaID", MySqlDbType.Int32,4),
					new MySqlParameter("@user_market_area", MySqlDbType.VarChar,30),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@admin_user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_u_real_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@is_daifa", MySqlDbType.Int32,2),
					new MySqlParameter("@send_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_tel", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_company", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_address", MySqlDbType.VarChar,30),
					new MySqlParameter("@user_from", MySqlDbType.VarChar,30),
					new MySqlParameter("@user_beizhu", MySqlDbType.Text),
					new MySqlParameter("@is_erp_archives", MySqlDbType.Int32,1),
					new MySqlParameter("@yes_invoiced_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@no_invoiced_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@aite_user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@dakuan", MySqlDbType.Decimal,10),
					new MySqlParameter("@dealer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@main_user_id", MySqlDbType.Int32,8),
					new MySqlParameter("@user_status", MySqlDbType.Int32,1),
					new MySqlParameter("@user_id", MySqlDbType.Int32,8)};
            parameters[0].Value = model.aite_id;
            parameters[1].Value = model.email;
            parameters[2].Value = model.user_name;
            parameters[3].Value = model.is_user_name_checked;
            parameters[4].Value = model.u_company;
            parameters[5].Value = model.u_real_name;
            parameters[6].Value = model.erp_custom_code;
            parameters[7].Value = model.password;
            parameters[8].Value = model.question;
            parameters[9].Value = model.answer;
            parameters[10].Value = model.sex;
            parameters[11].Value = model.birthday;
            parameters[12].Value = model.user_money;
            parameters[13].Value = model.frozen_money;
            parameters[14].Value = model.pay_points;
            parameters[15].Value = model.rank_points;
            parameters[16].Value = model.address_id;
            parameters[17].Value = model.reg_time;
            parameters[18].Value = model.last_login;
            parameters[19].Value = model.last_time;
            parameters[20].Value = model.last_ip;
            parameters[21].Value = model.visit_count;
            parameters[22].Value = model.user_rank;
            parameters[23].Value = model.is_special;
            parameters[24].Value = model.ec_salt;
            parameters[25].Value = model.salt;
            parameters[26].Value = model.parent_id;
            parameters[27].Value = model.flag;
            parameters[28].Value = model.alias;
            parameters[29].Value = model.msn;
            parameters[30].Value = model.qq;
            parameters[31].Value = model.office_phone;
            parameters[32].Value = model.home_phone;
            parameters[33].Value = model.mobile_phone;
            parameters[34].Value = model.is_validated;
            parameters[35].Value = model.credit_line;
            parameters[36].Value = model.passwd_question;
            parameters[37].Value = model.passwd_answer;
            parameters[38].Value = model.mediaUID;
            parameters[39].Value = model.mediaID;
            parameters[40].Value = model.user_market_area;
            parameters[41].Value = model.admin_user_name;
            parameters[42].Value = model.admin_user_id;
            parameters[43].Value = model.admin_u_real_name;
            parameters[44].Value = model.is_daifa;
            parameters[45].Value = model.send_user_name;
            parameters[46].Value = model.send_user_tel;
            parameters[47].Value = model.send_user_company;
            parameters[48].Value = model.send_user_address;
            parameters[49].Value = model.user_from;
            parameters[50].Value = model.user_beizhu;
            parameters[51].Value = model.is_erp_archives;
            parameters[52].Value = model.yes_invoiced_money;
            parameters[53].Value = model.no_invoiced_money;
            parameters[54].Value = model.aite_user_name;
            parameters[55].Value = model.dakuan;
            parameters[56].Value = model.dealer_id;
            parameters[57].Value = model.main_user_id;
            parameters[58].Value = model.user_status;
            parameters[59].Value = model.user_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int user_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_users ");
            strSql.Append(" where user_id=@user_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32)
			};
            parameters[0].Value = user_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string user_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_users ");
            strSql.Append(" where user_id in (" + user_idlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ecs_users GetModel(int user_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select user_id,aite_id,email,user_name,is_user_name_checked,u_company,u_real_name,erp_custom_code,password,question,answer,sex,birthday,user_money,frozen_money,pay_points,rank_points,address_id,reg_time,last_login,last_time,last_ip,visit_count,user_rank,is_special,ec_salt,salt,parent_id,flag,alias,msn,qq,office_phone,home_phone,mobile_phone,is_validated,credit_line,passwd_question,passwd_answer,mediaUID,mediaID,user_market_area,admin_user_name,admin_user_id,admin_u_real_name,is_daifa,send_user_name,send_user_tel,send_user_company,send_user_address,user_from,user_beizhu,is_erp_archives,yes_invoiced_money,no_invoiced_money,aite_user_name,dakuan,dealer_id,main_user_id,user_status from ecs_users ");
            strSql.Append(" where user_id=@user_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32)
			};
            parameters[0].Value = user_id;

            XHD.Model.ecs_users model = new XHD.Model.ecs_users();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ecs_users DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_users model = new XHD.Model.ecs_users();
            if (row != null)
            {
                //model.user_id=row["user_id"].ToString();
                if (row["aite_id"] != null)
                {
                    model.aite_id = row["aite_id"].ToString();
                }
                if (row["email"] != null)
                {
                    model.email = row["email"].ToString();
                }
                if (row["user_name"] != null)
                {
                    model.user_name = row["user_name"].ToString();
                }
                if (row["is_user_name_checked"] != null && row["is_user_name_checked"].ToString() != "")
                {
                    model.is_user_name_checked = int.Parse(row["is_user_name_checked"].ToString());
                }
                if (row["u_company"] != null)
                {
                    model.u_company = row["u_company"].ToString();
                }
                if (row["u_real_name"] != null)
                {
                    model.u_real_name = row["u_real_name"].ToString();
                }
                if (row["erp_custom_code"] != null)
                {
                    model.erp_custom_code = row["erp_custom_code"].ToString();
                }
                if (row["password"] != null)
                {
                    model.password = row["password"].ToString();
                }
                if (row["question"] != null)
                {
                    model.question = row["question"].ToString();
                }
                if (row["answer"] != null)
                {
                    model.answer = row["answer"].ToString();
                }
                if (row["sex"] != null && row["sex"].ToString() != "")
                {
                    model.sex = int.Parse(row["sex"].ToString());
                }
                if (row["birthday"] != null && row["birthday"].ToString() != "")
                {
                    model.birthday = DateTime.Parse(row["birthday"].ToString());
                }
                if (row["user_money"] != null && row["user_money"].ToString() != "")
                {
                    model.user_money = decimal.Parse(row["user_money"].ToString());
                }
                if (row["frozen_money"] != null && row["frozen_money"].ToString() != "")
                {
                    model.frozen_money = decimal.Parse(row["frozen_money"].ToString());
                }
                if (row["pay_points"] != null && row["pay_points"].ToString() != "")
                {
                    model.pay_points = int.Parse(row["pay_points"].ToString());
                }
                if (row["rank_points"] != null && row["rank_points"].ToString() != "")
                {
                    model.rank_points = int.Parse(row["rank_points"].ToString());
                }
                //model.address_id=row["address_id"].ToString();
                if (row["reg_time"] != null && row["reg_time"].ToString() != "")
                {
                    model.reg_time = int.Parse(row["reg_time"].ToString());
                }
                if (row["last_login"] != null && row["last_login"].ToString() != "")
                {
                    model.last_login = int.Parse(row["last_login"].ToString());
                }
                if (row["last_time"] != null && row["last_time"].ToString() != "")
                {
                    model.last_time = DateTime.Parse(row["last_time"].ToString());
                }
                if (row["last_ip"] != null)
                {
                    model.last_ip = row["last_ip"].ToString();
                }
                if (row["visit_count"] != null && row["visit_count"].ToString() != "")
                {
                    model.visit_count = int.Parse(row["visit_count"].ToString());
                }
                if (row["user_rank"] != null && row["user_rank"].ToString() != "")
                {
                    model.user_rank = int.Parse(row["user_rank"].ToString());
                }
                if (row["is_special"] != null && row["is_special"].ToString() != "")
                {
                    model.is_special = int.Parse(row["is_special"].ToString());
                }
                if (row["ec_salt"] != null)
                {
                    model.ec_salt = row["ec_salt"].ToString();
                }
                if (row["salt"] != null)
                {
                    model.salt = row["salt"].ToString();
                }
                //model.parent_id=row["parent_id"].ToString();
                if (row["flag"] != null && row["flag"].ToString() != "")
                {
                    model.flag = int.Parse(row["flag"].ToString());
                }
                if (row["alias"] != null)
                {
                    model.alias = row["alias"].ToString();
                }
                if (row["msn"] != null)
                {
                    model.msn = row["msn"].ToString();
                }
                if (row["qq"] != null)
                {
                    model.qq = row["qq"].ToString();
                }
                if (row["office_phone"] != null)
                {
                    model.office_phone = row["office_phone"].ToString();
                }
                if (row["home_phone"] != null)
                {
                    model.home_phone = row["home_phone"].ToString();
                }
                if (row["mobile_phone"] != null)
                {
                    model.mobile_phone = row["mobile_phone"].ToString();
                }
                if (row["is_validated"] != null && row["is_validated"].ToString() != "")
                {
                    model.is_validated = int.Parse(row["is_validated"].ToString());
                }
                if (row["credit_line"] != null && row["credit_line"].ToString() != "")
                {
                    model.credit_line = decimal.Parse(row["credit_line"].ToString());
                }
                if (row["passwd_question"] != null)
                {
                    model.passwd_question = row["passwd_question"].ToString();
                }
                if (row["passwd_answer"] != null)
                {
                    model.passwd_answer = row["passwd_answer"].ToString();
                }
                if (row["mediaUID"] != null)
                {
                    model.mediaUID = row["mediaUID"].ToString();
                }
                if (row["mediaID"] != null && row["mediaID"].ToString() != "")
                {
                    model.mediaID = int.Parse(row["mediaID"].ToString());
                }
                if (row["user_market_area"] != null)
                {
                    model.user_market_area = row["user_market_area"].ToString();
                }
                if (row["admin_user_name"] != null)
                {
                    model.admin_user_name = row["admin_user_name"].ToString();
                }
                if (row["admin_user_id"] != null && row["admin_user_id"].ToString() != "")
                {
                    model.admin_user_id = int.Parse(row["admin_user_id"].ToString());
                }
                if (row["admin_u_real_name"] != null)
                {
                    model.admin_u_real_name = row["admin_u_real_name"].ToString();
                }
                if (row["is_daifa"] != null && row["is_daifa"].ToString() != "")
                {
                    model.is_daifa = int.Parse(row["is_daifa"].ToString());
                }
                if (row["send_user_name"] != null)
                {
                    model.send_user_name = row["send_user_name"].ToString();
                }
                if (row["send_user_tel"] != null)
                {
                    model.send_user_tel = row["send_user_tel"].ToString();
                }
                if (row["send_user_company"] != null)
                {
                    model.send_user_company = row["send_user_company"].ToString();
                }
                if (row["send_user_address"] != null)
                {
                    model.send_user_address = row["send_user_address"].ToString();
                }
                if (row["user_from"] != null)
                {
                    model.user_from = row["user_from"].ToString();
                }
                if (row["user_beizhu"] != null)
                {
                    model.user_beizhu = row["user_beizhu"].ToString();
                }
                if (row["is_erp_archives"] != null && row["is_erp_archives"].ToString() != "")
                {
                    model.is_erp_archives = int.Parse(row["is_erp_archives"].ToString());
                }
                if (row["yes_invoiced_money"] != null && row["yes_invoiced_money"].ToString() != "")
                {
                    model.yes_invoiced_money = decimal.Parse(row["yes_invoiced_money"].ToString());
                }
                if (row["no_invoiced_money"] != null && row["no_invoiced_money"].ToString() != "")
                {
                    model.no_invoiced_money = decimal.Parse(row["no_invoiced_money"].ToString());
                }
                if (row["aite_user_name"] != null)
                {
                    model.aite_user_name = row["aite_user_name"].ToString();
                }
                if (row["dakuan"] != null && row["dakuan"].ToString() != "")
                {
                    model.dakuan = decimal.Parse(row["dakuan"].ToString());
                }
                if (row["dealer_id"] != null && row["dealer_id"].ToString() != "")
                {
                    model.dealer_id = int.Parse(row["dealer_id"].ToString());
                }
                //model.main_user_id=row["main_user_id"].ToString();
                if (row["user_status"] != null && row["user_status"].ToString() != "")
                {
                    model.user_status = int.Parse(row["user_status"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select user_id,aite_id,email,user_name,is_user_name_checked,u_company,u_real_name,erp_custom_code,password,question,answer,sex,birthday,user_money,frozen_money,pay_points,rank_points,address_id,reg_time,last_login,last_time,last_ip,visit_count,user_rank,is_special,ec_salt,salt,parent_id,flag,alias,msn,qq,office_phone,home_phone,mobile_phone,is_validated,credit_line,passwd_question,passwd_answer,mediaUID,mediaID,user_market_area,admin_user_name,admin_user_id,admin_u_real_name,is_daifa,send_user_name,send_user_tel,send_user_company,send_user_address,user_from,user_beizhu,is_erp_archives,yes_invoiced_money,no_invoiced_money,aite_user_name,dakuan,dealer_id,main_user_id,user_status ");
            strSql.Append(" FROM ecs_users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListId(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select user_id,aite_id,email,user_name ");
            strSql.Append(" FROM ecs_users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ecs_users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.user_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_users T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            MySqlParameter[] parameters = {
                    new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@PageSize", MySqlDbType.Int32),
                    new MySqlParameter("@PageIndex", MySqlDbType.Int32),
                    new MySqlParameter("@IsReCount", MySqlDbType.Bit),
                    new MySqlParameter("@OrderType", MySqlDbType.Bit),
                    new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "ecs_users";
            parameters[1].Value = "user_id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

