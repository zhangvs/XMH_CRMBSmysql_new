using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:dms_salaryDAO
    /// </summary>
    public partial class dms_salaryDAO
    {
        public dms_salaryDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dms_salary");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.dms_salary model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dms_salary(");
            strSql.Append("year,month,admin_user_name,name,d_pid,d_pname,xy_1000,dy_1000,dy_5000,dy_10000,dy_20000,grade,basic,percentage_sum,personal_champion,personal_champion1,personal_bonus1,personal_champion2,personal_bonus2,personal_champion3,personal_bonus3,personal_champion4,personal_bonus4,team_carve_bonus,good_bonus,phone_bonus,point_bonus,seniority_bonus,bonus_sum,absence_days,basic2,leave_days,percentage_sum2,bonus_sum2,meals_deductions,social_deductions,late_deductions,shipping_deductions,other_deductions,deductions_sum,salary_sum,create_time,create_name,factory_id)");
            strSql.Append(" values (");
            strSql.Append("@year,@month,@admin_user_name,@name,@d_pid,@d_pname,@xy_1000,@dy_1000,@dy_5000,@dy_10000,@dy_20000,@grade,@basic,@percentage_sum,@personal_champion,@personal_champion1,@personal_bonus1,@personal_champion2,@personal_bonus2,@personal_champion3,@personal_bonus3,@personal_champion4,@personal_bonus4,@team_carve_bonus,@good_bonus,@phone_bonus,@point_bonus,@seniority_bonus,@bonus_sum,@absence_days,@basic2,@leave_days,@percentage_sum2,@bonus_sum2,@meals_deductions,@social_deductions,@late_deductions,@shipping_deductions,@other_deductions,@deductions_sum,@salary_sum,@create_time,@create_name,@factory_id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@year", MySqlDbType.VarChar,4),
					new MySqlParameter("@month", MySqlDbType.VarChar,2),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@name", MySqlDbType.VarChar,60),
					new MySqlParameter("@d_pid", MySqlDbType.VarChar,20),
					new MySqlParameter("@d_pname", MySqlDbType.VarChar,60),
					new MySqlParameter("@xy_1000", MySqlDbType.Int32,100),
					new MySqlParameter("@dy_1000", MySqlDbType.Int32,100),
					new MySqlParameter("@dy_5000", MySqlDbType.Int32,100),
					new MySqlParameter("@dy_10000", MySqlDbType.Int32,100),
					new MySqlParameter("@dy_20000", MySqlDbType.Int32,100),
					new MySqlParameter("@grade", MySqlDbType.VarChar,10),
					new MySqlParameter("@basic", MySqlDbType.Decimal,18),
					new MySqlParameter("@percentage_sum", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion1", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus1", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion2", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus2", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion3", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus3", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion4", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus4", MySqlDbType.Decimal,18),
					new MySqlParameter("@team_carve_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@good_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@phone_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@point_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@seniority_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@bonus_sum", MySqlDbType.Decimal,18),
					new MySqlParameter("@absence_days", MySqlDbType.Decimal,5),
					new MySqlParameter("@basic2", MySqlDbType.Decimal,18),
					new MySqlParameter("@leave_days", MySqlDbType.Decimal,5),
					new MySqlParameter("@percentage_sum2", MySqlDbType.Decimal,18),
					new MySqlParameter("@bonus_sum2", MySqlDbType.Decimal,18),
					new MySqlParameter("@meals_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@social_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@late_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@other_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@deductions_sum", MySqlDbType.Decimal,10),
					new MySqlParameter("@salary_sum", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,20)};
            parameters[0].Value = model.year;
            parameters[1].Value = model.month;
            parameters[2].Value = model.admin_user_name;
            parameters[3].Value = model.name;
            parameters[4].Value = model.d_pid;
            parameters[5].Value = model.d_pname;
            parameters[6].Value = model.xy_1000;
            parameters[7].Value = model.dy_1000;
            parameters[8].Value = model.dy_5000;
            parameters[9].Value = model.dy_10000;
            parameters[10].Value = model.dy_20000;
            parameters[11].Value = model.grade;
            parameters[12].Value = model.basic;
            parameters[13].Value = model.percentage_sum;
            parameters[14].Value = model.personal_champion;
            parameters[15].Value = model.personal_champion1;
            parameters[16].Value = model.personal_bonus1;
            parameters[17].Value = model.personal_champion2;
            parameters[18].Value = model.personal_bonus2;
            parameters[19].Value = model.personal_champion3;
            parameters[20].Value = model.personal_bonus3;
            parameters[21].Value = model.personal_champion4;
            parameters[22].Value = model.personal_bonus4;
            parameters[23].Value = model.team_carve_bonus;
            parameters[24].Value = model.good_bonus;
            parameters[25].Value = model.phone_bonus;
            parameters[26].Value = model.point_bonus;
            parameters[27].Value = model.seniority_bonus;
            parameters[28].Value = model.bonus_sum;
            parameters[29].Value = model.absence_days;
            parameters[30].Value = model.basic2;
            parameters[31].Value = model.leave_days;
            parameters[32].Value = model.percentage_sum2;
            parameters[33].Value = model.bonus_sum2;
            parameters[34].Value = model.meals_deductions;
            parameters[35].Value = model.social_deductions;
            parameters[36].Value = model.late_deductions;
            parameters[37].Value = model.shipping_deductions;
            parameters[38].Value = model.other_deductions;
            parameters[39].Value = model.deductions_sum;
            parameters[40].Value = model.salary_sum;
            parameters[41].Value = model.create_time;
            parameters[42].Value = model.create_name;
            parameters[43].Value = model.factory_id;

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
        public bool Update(XHD.Model.dms_salary model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_salary set ");
            strSql.Append("year=@year,");
            strSql.Append("month=@month,");
            strSql.Append("admin_user_name=@admin_user_name,");
            strSql.Append("name=@name,");
            strSql.Append("d_pid=@d_pid,");
            strSql.Append("d_pname=@d_pname,");
            strSql.Append("xy_1000=@xy_1000,");
            strSql.Append("dy_1000=@dy_1000,");
            strSql.Append("dy_5000=@dy_5000,");
            strSql.Append("dy_10000=@dy_10000,");
            strSql.Append("dy_20000=@dy_20000,");
            strSql.Append("grade=@grade,");
            strSql.Append("basic=@basic,");
            strSql.Append("percentage_sum=@percentage_sum,");
            strSql.Append("personal_champion=@personal_champion,");
            strSql.Append("personal_champion1=@personal_champion1,");
            strSql.Append("personal_bonus1=@personal_bonus1,");
            strSql.Append("personal_champion2=@personal_champion2,");
            strSql.Append("personal_bonus2=@personal_bonus2,");
            strSql.Append("personal_champion3=@personal_champion3,");
            strSql.Append("personal_bonus3=@personal_bonus3,");
            strSql.Append("personal_champion4=@personal_champion4,");
            strSql.Append("personal_bonus4=@personal_bonus4,");
            strSql.Append("team_carve_bonus=@team_carve_bonus,");
            strSql.Append("good_bonus=@good_bonus,");
            strSql.Append("phone_bonus=@phone_bonus,");
            strSql.Append("point_bonus=@point_bonus,");
            strSql.Append("seniority_bonus=@seniority_bonus,");
            strSql.Append("bonus_sum=@bonus_sum,");
            strSql.Append("absence_days=@absence_days,");
            strSql.Append("basic2=@basic2,");
            strSql.Append("leave_days=@leave_days,");
            strSql.Append("percentage_sum2=@percentage_sum2,");
            strSql.Append("bonus_sum2=@bonus_sum2,");
            strSql.Append("meals_deductions=@meals_deductions,");
            strSql.Append("social_deductions=@social_deductions,");
            strSql.Append("late_deductions=@late_deductions,");
            strSql.Append("shipping_deductions=@shipping_deductions,");
            strSql.Append("other_deductions=@other_deductions,");
            strSql.Append("deductions_sum=@deductions_sum,");
            strSql.Append("salary_sum=@salary_sum,");
            strSql.Append("create_time=@create_time,");
            strSql.Append("create_name=@create_name,");
            strSql.Append("factory_id=@factory_id");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@year", MySqlDbType.VarChar,4),
					new MySqlParameter("@month", MySqlDbType.VarChar,2),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@name", MySqlDbType.VarChar,60),
					new MySqlParameter("@d_pid", MySqlDbType.VarChar,20),
					new MySqlParameter("@d_pname", MySqlDbType.VarChar,60),
					new MySqlParameter("@xy_1000", MySqlDbType.Int32,100),
					new MySqlParameter("@dy_1000", MySqlDbType.Int32,100),
					new MySqlParameter("@dy_5000", MySqlDbType.Int32,100),
					new MySqlParameter("@dy_10000", MySqlDbType.Int32,100),
					new MySqlParameter("@dy_20000", MySqlDbType.Int32,100),
					new MySqlParameter("@grade", MySqlDbType.VarChar,10),
					new MySqlParameter("@basic", MySqlDbType.Decimal,18),
					new MySqlParameter("@percentage_sum", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion1", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus1", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion2", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus2", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion3", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus3", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion4", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus4", MySqlDbType.Decimal,18),
					new MySqlParameter("@team_carve_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@good_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@phone_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@point_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@seniority_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@bonus_sum", MySqlDbType.Decimal,18),
					new MySqlParameter("@absence_days", MySqlDbType.Decimal,5),
					new MySqlParameter("@basic2", MySqlDbType.Decimal,18),
					new MySqlParameter("@leave_days", MySqlDbType.Decimal,5),
					new MySqlParameter("@percentage_sum2", MySqlDbType.Decimal,18),
					new MySqlParameter("@bonus_sum2", MySqlDbType.Decimal,18),
					new MySqlParameter("@meals_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@social_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@late_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@other_deductions", MySqlDbType.Decimal,10),
					new MySqlParameter("@deductions_sum", MySqlDbType.Decimal,10),
					new MySqlParameter("@salary_sum", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.year;
            parameters[1].Value = model.month;
            parameters[2].Value = model.admin_user_name;
            parameters[3].Value = model.name;
            parameters[4].Value = model.d_pid;
            parameters[5].Value = model.d_pname;
            parameters[6].Value = model.xy_1000;
            parameters[7].Value = model.dy_1000;
            parameters[8].Value = model.dy_5000;
            parameters[9].Value = model.dy_10000;
            parameters[10].Value = model.dy_20000;
            parameters[11].Value = model.grade;
            parameters[12].Value = model.basic;
            parameters[13].Value = model.percentage_sum;
            parameters[14].Value = model.personal_champion;
            parameters[15].Value = model.personal_champion1;
            parameters[16].Value = model.personal_bonus1;
            parameters[17].Value = model.personal_champion2;
            parameters[18].Value = model.personal_bonus2;
            parameters[19].Value = model.personal_champion3;
            parameters[20].Value = model.personal_bonus3;
            parameters[21].Value = model.personal_champion4;
            parameters[22].Value = model.personal_bonus4;
            parameters[23].Value = model.team_carve_bonus;
            parameters[24].Value = model.good_bonus;
            parameters[25].Value = model.phone_bonus;
            parameters[26].Value = model.point_bonus;
            parameters[27].Value = model.seniority_bonus;
            parameters[28].Value = model.bonus_sum;
            parameters[29].Value = model.absence_days;
            parameters[30].Value = model.basic2;
            parameters[31].Value = model.leave_days;
            parameters[32].Value = model.percentage_sum2;
            parameters[33].Value = model.bonus_sum2;
            parameters[34].Value = model.meals_deductions;
            parameters[35].Value = model.social_deductions;
            parameters[36].Value = model.late_deductions;
            parameters[37].Value = model.shipping_deductions;
            parameters[38].Value = model.other_deductions;
            parameters[39].Value = model.deductions_sum;
            parameters[40].Value = model.salary_sum;
            parameters[41].Value = model.create_time;
            parameters[42].Value = model.create_name;
            parameters[43].Value = model.factory_id;
            parameters[44].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dms_salary ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dms_salary ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public XHD.Model.dms_salary GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,year,month,admin_user_name,name,d_pid,d_pname,xy_1000,dy_1000,dy_5000,dy_10000,dy_20000,grade,basic,percentage_sum,personal_champion,personal_champion1,personal_bonus1,personal_champion2,personal_bonus2,personal_champion3,personal_bonus3,personal_champion4,personal_bonus4,team_carve_bonus,good_bonus,phone_bonus,point_bonus,seniority_bonus,bonus_sum,absence_days,basic2,leave_days,percentage_sum2,bonus_sum2,meals_deductions,social_deductions,late_deductions,shipping_deductions,other_deductions,deductions_sum,salary_sum,create_time,create_name,factory_id from dms_salary ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.dms_salary model = new XHD.Model.dms_salary();
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
        public XHD.Model.dms_salary DataRowToModel(DataRow row)
        {
            XHD.Model.dms_salary model = new XHD.Model.dms_salary();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["year"] != null)
                {
                    model.year = row["year"].ToString();
                }
                if (row["month"] != null)
                {
                    model.month = row["month"].ToString();
                }
                if (row["admin_user_name"] != null)
                {
                    model.admin_user_name = row["admin_user_name"].ToString();
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["d_pid"] != null)
                {
                    model.d_pid = row["d_pid"].ToString();
                }
                if (row["d_pname"] != null)
                {
                    model.d_pname = row["d_pname"].ToString();
                }
                if (row["xy_1000"] != null && row["xy_1000"].ToString() != "")
                {
                    model.xy_1000 = int.Parse(row["xy_1000"].ToString());
                }
                if (row["dy_1000"] != null && row["dy_1000"].ToString() != "")
                {
                    model.dy_1000 = int.Parse(row["dy_1000"].ToString());
                }
                if (row["dy_5000"] != null && row["dy_5000"].ToString() != "")
                {
                    model.dy_5000 = int.Parse(row["dy_5000"].ToString());
                }
                if (row["dy_10000"] != null && row["dy_10000"].ToString() != "")
                {
                    model.dy_10000 = int.Parse(row["dy_10000"].ToString());
                }
                if (row["dy_20000"] != null && row["dy_20000"].ToString() != "")
                {
                    model.dy_20000 = int.Parse(row["dy_20000"].ToString());
                }
                if (row["grade"] != null)
                {
                    model.grade = row["grade"].ToString();
                }
                if (row["basic"] != null && row["basic"].ToString() != "")
                {
                    model.basic = decimal.Parse(row["basic"].ToString());
                }
                if (row["percentage_sum"] != null && row["percentage_sum"].ToString() != "")
                {
                    model.percentage_sum = decimal.Parse(row["percentage_sum"].ToString());
                }
                if (row["personal_champion"] != null && row["personal_champion"].ToString() != "")
                {
                    model.personal_champion = decimal.Parse(row["personal_champion"].ToString());
                }
                if (row["personal_champion1"] != null && row["personal_champion1"].ToString() != "")
                {
                    model.personal_champion1 = decimal.Parse(row["personal_champion1"].ToString());
                }
                if (row["personal_bonus1"] != null && row["personal_bonus1"].ToString() != "")
                {
                    model.personal_bonus1 = decimal.Parse(row["personal_bonus1"].ToString());
                }
                if (row["personal_champion2"] != null && row["personal_champion2"].ToString() != "")
                {
                    model.personal_champion2 = decimal.Parse(row["personal_champion2"].ToString());
                }
                if (row["personal_bonus2"] != null && row["personal_bonus2"].ToString() != "")
                {
                    model.personal_bonus2 = decimal.Parse(row["personal_bonus2"].ToString());
                }
                if (row["personal_champion3"] != null && row["personal_champion3"].ToString() != "")
                {
                    model.personal_champion3 = decimal.Parse(row["personal_champion3"].ToString());
                }
                if (row["personal_bonus3"] != null && row["personal_bonus3"].ToString() != "")
                {
                    model.personal_bonus3 = decimal.Parse(row["personal_bonus3"].ToString());
                }
                if (row["personal_champion4"] != null && row["personal_champion4"].ToString() != "")
                {
                    model.personal_champion4 = decimal.Parse(row["personal_champion4"].ToString());
                }
                if (row["personal_bonus4"] != null && row["personal_bonus4"].ToString() != "")
                {
                    model.personal_bonus4 = decimal.Parse(row["personal_bonus4"].ToString());
                }
                if (row["team_carve_bonus"] != null && row["team_carve_bonus"].ToString() != "")
                {
                    model.team_carve_bonus = decimal.Parse(row["team_carve_bonus"].ToString());
                }
                if (row["good_bonus"] != null && row["good_bonus"].ToString() != "")
                {
                    model.good_bonus = decimal.Parse(row["good_bonus"].ToString());
                }
                if (row["phone_bonus"] != null && row["phone_bonus"].ToString() != "")
                {
                    model.phone_bonus = decimal.Parse(row["phone_bonus"].ToString());
                }
                if (row["point_bonus"] != null && row["point_bonus"].ToString() != "")
                {
                    model.point_bonus = decimal.Parse(row["point_bonus"].ToString());
                }
                if (row["seniority_bonus"] != null && row["seniority_bonus"].ToString() != "")
                {
                    model.seniority_bonus = decimal.Parse(row["seniority_bonus"].ToString());
                }
                if (row["bonus_sum"] != null && row["bonus_sum"].ToString() != "")
                {
                    model.bonus_sum = decimal.Parse(row["bonus_sum"].ToString());
                }
                if (row["absence_days"] != null && row["absence_days"].ToString() != "")
                {
                    model.absence_days = decimal.Parse(row["absence_days"].ToString());
                }
                if (row["basic2"] != null && row["basic2"].ToString() != "")
                {
                    model.basic2 = decimal.Parse(row["basic2"].ToString());
                }
                if (row["leave_days"] != null && row["leave_days"].ToString() != "")
                {
                    model.leave_days = decimal.Parse(row["leave_days"].ToString());
                }
                if (row["percentage_sum2"] != null && row["percentage_sum2"].ToString() != "")
                {
                    model.percentage_sum2 = decimal.Parse(row["percentage_sum2"].ToString());
                }
                if (row["bonus_sum2"] != null && row["bonus_sum2"].ToString() != "")
                {
                    model.bonus_sum2 = decimal.Parse(row["bonus_sum2"].ToString());
                }
                if (row["meals_deductions"] != null && row["meals_deductions"].ToString() != "")
                {
                    model.meals_deductions = decimal.Parse(row["meals_deductions"].ToString());
                }
                if (row["social_deductions"] != null && row["social_deductions"].ToString() != "")
                {
                    model.social_deductions = decimal.Parse(row["social_deductions"].ToString());
                }
                if (row["late_deductions"] != null && row["late_deductions"].ToString() != "")
                {
                    model.late_deductions = decimal.Parse(row["late_deductions"].ToString());
                }
                if (row["shipping_deductions"] != null && row["shipping_deductions"].ToString() != "")
                {
                    model.shipping_deductions = decimal.Parse(row["shipping_deductions"].ToString());
                }
                if (row["other_deductions"] != null && row["other_deductions"].ToString() != "")
                {
                    model.other_deductions = decimal.Parse(row["other_deductions"].ToString());
                }
                if (row["deductions_sum"] != null && row["deductions_sum"].ToString() != "")
                {
                    model.deductions_sum = decimal.Parse(row["deductions_sum"].ToString());
                }
                if (row["salary_sum"] != null && row["salary_sum"].ToString() != "")
                {
                    model.salary_sum = decimal.Parse(row["salary_sum"].ToString());
                }
                if (row["create_time"] != null && row["create_time"].ToString() != "")
                {
                    model.create_time = DateTime.Parse(row["create_time"].ToString());
                }
                if (row["create_name"] != null)
                {
                    model.create_name = row["create_name"].ToString();
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
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
            strSql.Append("select id,year,month,admin_user_name,name,d_pid,d_pname,xy_1000,dy_1000,dy_5000,dy_10000,dy_20000,grade,basic,percentage_sum,personal_champion,personal_champion1,personal_bonus1,personal_champion2,personal_bonus2,personal_champion3,personal_bonus3,personal_champion4,personal_bonus4,team_carve_bonus,good_bonus,phone_bonus,point_bonus,seniority_bonus,bonus_sum,absence_days,basic2,leave_days,percentage_sum2,bonus_sum2,meals_deductions,social_deductions,late_deductions,shipping_deductions,other_deductions,deductions_sum,salary_sum,create_time,create_name,factory_id ");
            strSql.Append(" FROM dms_salary ");
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
            strSql.Append("select count(1) FROM dms_salary ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from dms_salary T ");
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
            parameters[0].Value = "dms_salary";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 更新团队奖励，单品，电话，积分，id
        /// </summary>
        public bool UpdateTeamBonus(decimal team_carve_bonus, decimal good_bonus, decimal phone_bonus, decimal point_bonus, string name, int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_salary set ");
            strSql.Append("team_carve_bonus=" + team_carve_bonus + ",");
            strSql.Append("good_bonus=" + good_bonus + ",");
            strSql.Append("phone_bonus=" + phone_bonus + ",");
            strSql.Append("point_bonus=" + point_bonus + ",");
            strSql.Append("bonus_sum=personal_champion+personal_champion1+personal_bonus1+personal_champion2+personal_bonus2+personal_champion3+personal_bonus3+personal_champion4+personal_bonus4+" + team_carve_bonus + "+" + good_bonus + "+" + phone_bonus + "+" + point_bonus + ",");
            strSql.Append("salary_sum=basic+percentage_sum+bonus_sum,");
            strSql.Append("create_name='" + name + "'");
            strSql.Append(" where id=" + id);
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
        /// 更新团队奖励，单品，电话，积分，id
        /// </summary>
        public bool Update_Team_Carvebonus_FromExcel(decimal team_carve_bonus, decimal good_bonus, decimal phone_bonus, decimal point_bonus, string admin_user_name, string year, string month)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_salary set ");
            strSql.Append("team_carve_bonus=" + team_carve_bonus + ",");
            strSql.Append("good_bonus=" + good_bonus + ",");
            strSql.Append("phone_bonus=" + phone_bonus + ",");
            strSql.Append("point_bonus=" + point_bonus + ",");
            strSql.Append("bonus_sum=personal_champion+personal_champion1+personal_bonus1+personal_champion2+personal_bonus2+personal_champion3+personal_bonus3+personal_champion4+personal_bonus4+" + team_carve_bonus + "+" + good_bonus + "+" + phone_bonus + "+" + point_bonus + ",");
            strSql.Append("salary_sum=basic+percentage_sum+bonus_sum ");
            strSql.Append(" where admin_user_name=" + admin_user_name);
            strSql.Append(" and year=" + year);
            strSql.Append(" and  month=" + month);
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteBySql(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dms_salary ");
            strSql.Append(" where " + sqlWhere);
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
        /// 计算工资合计
        /// </summary>
        public bool Update_Attendance_SeniorityBonus(decimal leave_days, decimal absence_days, decimal seniority_bonus, decimal meals_deductions, decimal social_deductions, decimal late_deductions, decimal shipping_deductions, decimal other_deductions, string admin_user_name, string year, string month)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_salary set ");
            strSql.Append("seniority_bonus=" + seniority_bonus + ",");
            strSql.Append("bonus_sum=personal_champion+personal_champion1+personal_bonus1+personal_champion2+personal_bonus2+personal_champion3+personal_bonus3+personal_champion4+personal_bonus4+");
            strSql.Append("(case when team_carve_bonus is null then 0 else team_carve_bonus end)  + (case when good_bonus is null then 0 else good_bonus end)  + (case when phone_bonus is null then 0 else phone_bonus end)  + (case when point_bonus is null then 0 else point_bonus end)  + (case when seniority_bonus is null then 0 else seniority_bonus end) ,");
            strSql.Append("absence_days=" + absence_days + ",");
            strSql.Append("basic2=basic-ABS(basic/30*" + absence_days + "),");
            strSql.Append("leave_days=" + leave_days + ",");
            strSql.Append("percentage_sum2=percentage_sum-ABS(percentage_sum/30*" + leave_days + "),");
            strSql.Append("bonus_sum2=bonus_sum-ABS(bonus_sum/30*" + leave_days + "),");
            strSql.Append("meals_deductions=" + meals_deductions + ",");
            strSql.Append("social_deductions=" + social_deductions + ",");
            strSql.Append("late_deductions=" + late_deductions + ",");
            strSql.Append("shipping_deductions=" + shipping_deductions + ",");
            strSql.Append("other_deductions=" + other_deductions + ",");
            strSql.Append("deductions_sum=meals_deductions+social_deductions+late_deductions+shipping_deductions+other_deductions,");
            strSql.Append("salary_sum=basic2+percentage_sum2+bonus_sum2+deductions_sum");
            strSql.Append(" where admin_user_name=" + admin_user_name);
            strSql.Append(" and year=" + year);
            strSql.Append(" and  month=" + month);

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
        /// 获得未分配团队奖
        /// </summary>
        public DataSet GetListTeamBonusUndistributed(string year, string month)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT d_pname from dms_team_bonus where (team_bonus<>0 or team_champion<>0) and d_pid in( ");
            strSql.Append(" SELECT d_pid from dms_salary ");
            strSql.Append(" where  year=" + year + " and  month=" + month + " and team_carve_bonus is null and good_bonus is null and phone_bonus is null and point_bonus is null ");
            strSql.Append(" group by d_pid) ");
            strSql.Append(" group by d_pname ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 导入考勤数据，就不能再分配团队奖
        /// </summary>
        public DataSet GetListImportAttendance(string year, string month)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * from dms_salary where year=" + year + " and  month=" + month + " and leave_days is not null and absence_days is not null ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 已分配团队奖
        /// </summary>
        public DataSet GetListAssignedTeamBonus(string year, string month, string d_pid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT sum(team_carve_bonus) yfp from dms_salary where year=" + year + " and  month=" + month + " and d_pid=" + d_pid);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  ExtensionMethod
    }
}

