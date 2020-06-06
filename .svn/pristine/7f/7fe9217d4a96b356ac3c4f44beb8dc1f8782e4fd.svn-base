using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_sale_parametersDAO
    /// </summary>
    public partial class ecs_sale_parametersDAO
    {
        public ecs_sale_parametersDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int sale_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_sale_parameters");
            strSql.Append(" where sale_id=@sale_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sale_id", MySqlDbType.Int32)
			};
            parameters[0].Value = sale_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_sale_parameters model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_sale_parameters(");
            strSql.Append("c1,c2,szone,sone,stwo,sthree,sfour,sfive,ssix,zdy,cus_num1,sale_num1,cus_num2,sale_num2,cus_num3,sale_num3,cus_num4,sale_num4,cus_num5,sale_num5,sale_num6,cus_num6,cus_num7,sale_num7,cus_num0,sale_num0,cus_numc1,cus_numc2,sale_numc1,sale_numc2,cus_num1_2,sale_num1_2,cus_num2_2,sale_num2_2,cus_num3_2,sale_num3_2,cus_num4_2,sale_num4_2,cus_num5_2,sale_num5_2,sale_num6_2,cus_num6_2,cus_num0_2,sale_num0_2)");
            strSql.Append(" values (");
            strSql.Append("@c1,@c2,@szone,@sone,@stwo,@sthree,@sfour,@sfive,@ssix,@zdy,@cus_num1,@sale_num1,@cus_num2,@sale_num2,@cus_num3,@sale_num3,@cus_num4,@sale_num4,@cus_num5,@sale_num5,@sale_num6,@cus_num6,@cus_num7,@sale_num7,@cus_num0,@sale_num0,@cus_numc1,@cus_numc2,@sale_numc1,@sale_numc2,@cus_num1_2,@sale_num1_2,@cus_num2_2,@sale_num2_2,@cus_num3_2,@sale_num3_2,@cus_num4_2,@sale_num4_2,@cus_num5_2,@sale_num5_2,@sale_num6_2,@cus_num6_2,@cus_num0_2,@sale_num0_2)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@c1", MySqlDbType.Int32,10),
					new MySqlParameter("@c2", MySqlDbType.Int32,10),
					new MySqlParameter("@szone", MySqlDbType.Int32,10),
					new MySqlParameter("@sone", MySqlDbType.Int32,10),
					new MySqlParameter("@stwo", MySqlDbType.Int32,10),
					new MySqlParameter("@sthree", MySqlDbType.Int32,10),
					new MySqlParameter("@sfour", MySqlDbType.Int32,10),
					new MySqlParameter("@sfive", MySqlDbType.Int32,10),
					new MySqlParameter("@ssix", MySqlDbType.Int32,10),
					new MySqlParameter("@zdy", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num1", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num1", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num3", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num3", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num4", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num4", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num5", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num5", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num6", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num6", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num7", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num7", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num0", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num0", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_numc1", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_numc2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_numc1", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_numc2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num1_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num1_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num2_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num2_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num3_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num3_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num4_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num4_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num5_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num5_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num6_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num6_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num0_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num0_2", MySqlDbType.Int32,10)};
            parameters[0].Value = model.c1;
            parameters[1].Value = model.c2;
            parameters[2].Value = model.szone;
            parameters[3].Value = model.sone;
            parameters[4].Value = model.stwo;
            parameters[5].Value = model.sthree;
            parameters[6].Value = model.sfour;
            parameters[7].Value = model.sfive;
            parameters[8].Value = model.ssix;
            parameters[9].Value = model.zdy;
            parameters[10].Value = model.cus_num1;
            parameters[11].Value = model.sale_num1;
            parameters[12].Value = model.cus_num2;
            parameters[13].Value = model.sale_num2;
            parameters[14].Value = model.cus_num3;
            parameters[15].Value = model.sale_num3;
            parameters[16].Value = model.cus_num4;
            parameters[17].Value = model.sale_num4;
            parameters[18].Value = model.cus_num5;
            parameters[19].Value = model.sale_num5;
            parameters[20].Value = model.sale_num6;
            parameters[21].Value = model.cus_num6;
            parameters[22].Value = model.cus_num7;
            parameters[23].Value = model.sale_num7;
            parameters[24].Value = model.cus_num0;
            parameters[25].Value = model.sale_num0;
            parameters[26].Value = model.cus_numc1;
            parameters[27].Value = model.cus_numc2;
            parameters[28].Value = model.sale_numc1;
            parameters[29].Value = model.sale_numc2;
            parameters[30].Value = model.cus_num1_2;
            parameters[31].Value = model.sale_num1_2;
            parameters[32].Value = model.cus_num2_2;
            parameters[33].Value = model.sale_num2_2;
            parameters[34].Value = model.cus_num3_2;
            parameters[35].Value = model.sale_num3_2;
            parameters[36].Value = model.cus_num4_2;
            parameters[37].Value = model.sale_num4_2;
            parameters[38].Value = model.cus_num5_2;
            parameters[39].Value = model.sale_num5_2;
            parameters[40].Value = model.sale_num6_2;
            parameters[41].Value = model.cus_num6_2;
            parameters[42].Value = model.cus_num0_2;
            parameters[43].Value = model.sale_num0_2;

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
        public bool Update(XHD.Model.ecs_sale_parameters model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_sale_parameters set ");
            strSql.Append("c1=@c1,");
            strSql.Append("c2=@c2,");
            strSql.Append("szone=@szone,");
            strSql.Append("sone=@sone,");
            strSql.Append("stwo=@stwo,");
            strSql.Append("sthree=@sthree,");
            strSql.Append("sfour=@sfour,");
            strSql.Append("sfive=@sfive,");
            strSql.Append("ssix=@ssix,");
            strSql.Append("zdy=@zdy,");
            strSql.Append("cus_num1=@cus_num1,");
            strSql.Append("sale_num1=@sale_num1,");
            strSql.Append("cus_num2=@cus_num2,");
            strSql.Append("sale_num2=@sale_num2,");
            strSql.Append("cus_num3=@cus_num3,");
            strSql.Append("sale_num3=@sale_num3,");
            strSql.Append("cus_num4=@cus_num4,");
            strSql.Append("sale_num4=@sale_num4,");
            strSql.Append("cus_num5=@cus_num5,");
            strSql.Append("sale_num5=@sale_num5,");
            strSql.Append("sale_num6=@sale_num6,");
            strSql.Append("cus_num6=@cus_num6,");
            strSql.Append("cus_num7=@cus_num7,");
            strSql.Append("sale_num7=@sale_num7,");
            strSql.Append("cus_num0=@cus_num0,");
            strSql.Append("sale_num0=@sale_num0,");
            strSql.Append("cus_numc1=@cus_numc1,");
            strSql.Append("cus_numc2=@cus_numc2,");
            strSql.Append("sale_numc1=@sale_numc1,");
            strSql.Append("sale_numc2=@sale_numc2,");
            strSql.Append("cus_num1_2=@cus_num1_2,");
            strSql.Append("sale_num1_2=@sale_num1_2,");
            strSql.Append("cus_num2_2=@cus_num2_2,");
            strSql.Append("sale_num2_2=@sale_num2_2,");
            strSql.Append("cus_num3_2=@cus_num3_2,");
            strSql.Append("sale_num3_2=@sale_num3_2,");
            strSql.Append("cus_num4_2=@cus_num4_2,");
            strSql.Append("sale_num4_2=@sale_num4_2,");
            strSql.Append("cus_num5_2=@cus_num5_2,");
            strSql.Append("sale_num5_2=@sale_num5_2,");
            strSql.Append("sale_num6_2=@sale_num6_2,");
            strSql.Append("cus_num6_2=@cus_num6_2,");
            strSql.Append("cus_num0_2=@cus_num0_2,");
            strSql.Append("sale_num0_2=@sale_num0_2");
            strSql.Append(" where sale_id=@sale_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@c1", MySqlDbType.Int32,10),
					new MySqlParameter("@c2", MySqlDbType.Int32,10),
					new MySqlParameter("@szone", MySqlDbType.Int32,10),
					new MySqlParameter("@sone", MySqlDbType.Int32,10),
					new MySqlParameter("@stwo", MySqlDbType.Int32,10),
					new MySqlParameter("@sthree", MySqlDbType.Int32,10),
					new MySqlParameter("@sfour", MySqlDbType.Int32,10),
					new MySqlParameter("@sfive", MySqlDbType.Int32,10),
					new MySqlParameter("@ssix", MySqlDbType.Int32,10),
					new MySqlParameter("@zdy", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num1", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num1", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num3", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num3", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num4", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num4", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num5", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num5", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num6", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num6", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num7", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num7", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num0", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num0", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_numc1", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_numc2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_numc1", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_numc2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num1_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num1_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num2_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num2_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num3_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num3_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num4_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num4_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num5_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num5_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num6_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num6_2", MySqlDbType.Int32,10),
					new MySqlParameter("@cus_num0_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_num0_2", MySqlDbType.Int32,10),
					new MySqlParameter("@sale_id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.c1;
            parameters[1].Value = model.c2;
            parameters[2].Value = model.szone;
            parameters[3].Value = model.sone;
            parameters[4].Value = model.stwo;
            parameters[5].Value = model.sthree;
            parameters[6].Value = model.sfour;
            parameters[7].Value = model.sfive;
            parameters[8].Value = model.ssix;
            parameters[9].Value = model.zdy;
            parameters[10].Value = model.cus_num1;
            parameters[11].Value = model.sale_num1;
            parameters[12].Value = model.cus_num2;
            parameters[13].Value = model.sale_num2;
            parameters[14].Value = model.cus_num3;
            parameters[15].Value = model.sale_num3;
            parameters[16].Value = model.cus_num4;
            parameters[17].Value = model.sale_num4;
            parameters[18].Value = model.cus_num5;
            parameters[19].Value = model.sale_num5;
            parameters[20].Value = model.sale_num6;
            parameters[21].Value = model.cus_num6;
            parameters[22].Value = model.cus_num7;
            parameters[23].Value = model.sale_num7;
            parameters[24].Value = model.cus_num0;
            parameters[25].Value = model.sale_num0;
            parameters[26].Value = model.cus_numc1;
            parameters[27].Value = model.cus_numc2;
            parameters[28].Value = model.sale_numc1;
            parameters[29].Value = model.sale_numc2;
            parameters[30].Value = model.cus_num1_2;
            parameters[31].Value = model.sale_num1_2;
            parameters[32].Value = model.cus_num2_2;
            parameters[33].Value = model.sale_num2_2;
            parameters[34].Value = model.cus_num3_2;
            parameters[35].Value = model.sale_num3_2;
            parameters[36].Value = model.cus_num4_2;
            parameters[37].Value = model.sale_num4_2;
            parameters[38].Value = model.cus_num5_2;
            parameters[39].Value = model.sale_num5_2;
            parameters[40].Value = model.sale_num6_2;
            parameters[41].Value = model.cus_num6_2;
            parameters[42].Value = model.cus_num0_2;
            parameters[43].Value = model.sale_num0_2;
            parameters[44].Value = model.sale_id;

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
        public bool Delete(int sale_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_sale_parameters ");
            strSql.Append(" where sale_id=@sale_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sale_id", MySqlDbType.Int32)
			};
            parameters[0].Value = sale_id;

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
        public bool DeleteList(string sale_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_sale_parameters ");
            strSql.Append(" where sale_id in (" + sale_idlist + ")  ");
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
        public XHD.Model.ecs_sale_parameters GetModel(int sale_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sale_id,c1,c2,szone,sone,stwo,sthree,sfour,sfive,ssix,zdy,cus_num1,sale_num1,cus_num2,sale_num2,cus_num3,sale_num3,cus_num4,sale_num4,cus_num5,sale_num5,sale_num6,cus_num6,cus_num7,sale_num7,cus_num0,sale_num0,cus_numc1,cus_numc2,sale_numc1,sale_numc2,cus_num1_2,sale_num1_2,cus_num2_2,sale_num2_2,cus_num3_2,sale_num3_2,cus_num4_2,sale_num4_2,cus_num5_2,sale_num5_2,sale_num6_2,cus_num6_2,cus_num0_2,sale_num0_2 from ecs_sale_parameters ");
            strSql.Append(" where sale_id=@sale_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sale_id", MySqlDbType.Int32)
			};
            parameters[0].Value = sale_id;

            XHD.Model.ecs_sale_parameters model = new XHD.Model.ecs_sale_parameters();
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
        public XHD.Model.ecs_sale_parameters DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_sale_parameters model = new XHD.Model.ecs_sale_parameters();
            if (row != null)
            {
                if (row["sale_id"] != null && row["sale_id"].ToString() != "")
                {
                    model.sale_id = int.Parse(row["sale_id"].ToString());
                }
                if (row["c1"] != null && row["c1"].ToString() != "")
                {
                    model.c1 = int.Parse(row["c1"].ToString());
                }
                if (row["c2"] != null && row["c2"].ToString() != "")
                {
                    model.c2 = int.Parse(row["c2"].ToString());
                }
                if (row["szone"] != null && row["szone"].ToString() != "")
                {
                    model.szone = int.Parse(row["szone"].ToString());
                }
                if (row["sone"] != null && row["sone"].ToString() != "")
                {
                    model.sone = int.Parse(row["sone"].ToString());
                }
                if (row["stwo"] != null && row["stwo"].ToString() != "")
                {
                    model.stwo = int.Parse(row["stwo"].ToString());
                }
                if (row["sthree"] != null && row["sthree"].ToString() != "")
                {
                    model.sthree = int.Parse(row["sthree"].ToString());
                }
                if (row["sfour"] != null && row["sfour"].ToString() != "")
                {
                    model.sfour = int.Parse(row["sfour"].ToString());
                }
                if (row["sfive"] != null && row["sfive"].ToString() != "")
                {
                    model.sfive = int.Parse(row["sfive"].ToString());
                }
                if (row["ssix"] != null && row["ssix"].ToString() != "")
                {
                    model.ssix = int.Parse(row["ssix"].ToString());
                }
                if (row["zdy"] != null && row["zdy"].ToString() != "")
                {
                    model.zdy = int.Parse(row["zdy"].ToString());
                }
                if (row["cus_num1"] != null && row["cus_num1"].ToString() != "")
                {
                    model.cus_num1 = int.Parse(row["cus_num1"].ToString());
                }
                if (row["sale_num1"] != null && row["sale_num1"].ToString() != "")
                {
                    model.sale_num1 = int.Parse(row["sale_num1"].ToString());
                }
                if (row["cus_num2"] != null && row["cus_num2"].ToString() != "")
                {
                    model.cus_num2 = int.Parse(row["cus_num2"].ToString());
                }
                if (row["sale_num2"] != null && row["sale_num2"].ToString() != "")
                {
                    model.sale_num2 = int.Parse(row["sale_num2"].ToString());
                }
                if (row["cus_num3"] != null && row["cus_num3"].ToString() != "")
                {
                    model.cus_num3 = int.Parse(row["cus_num3"].ToString());
                }
                if (row["sale_num3"] != null && row["sale_num3"].ToString() != "")
                {
                    model.sale_num3 = int.Parse(row["sale_num3"].ToString());
                }
                if (row["cus_num4"] != null && row["cus_num4"].ToString() != "")
                {
                    model.cus_num4 = int.Parse(row["cus_num4"].ToString());
                }
                if (row["sale_num4"] != null && row["sale_num4"].ToString() != "")
                {
                    model.sale_num4 = int.Parse(row["sale_num4"].ToString());
                }
                if (row["cus_num5"] != null && row["cus_num5"].ToString() != "")
                {
                    model.cus_num5 = int.Parse(row["cus_num5"].ToString());
                }
                if (row["sale_num5"] != null && row["sale_num5"].ToString() != "")
                {
                    model.sale_num5 = int.Parse(row["sale_num5"].ToString());
                }
                if (row["sale_num6"] != null && row["sale_num6"].ToString() != "")
                {
                    model.sale_num6 = int.Parse(row["sale_num6"].ToString());
                }
                if (row["cus_num6"] != null && row["cus_num6"].ToString() != "")
                {
                    model.cus_num6 = int.Parse(row["cus_num6"].ToString());
                }
                if (row["cus_num7"] != null && row["cus_num7"].ToString() != "")
                {
                    model.cus_num7 = int.Parse(row["cus_num7"].ToString());
                }
                if (row["sale_num7"] != null && row["sale_num7"].ToString() != "")
                {
                    model.sale_num7 = int.Parse(row["sale_num7"].ToString());
                }
                if (row["cus_num0"] != null && row["cus_num0"].ToString() != "")
                {
                    model.cus_num0 = int.Parse(row["cus_num0"].ToString());
                }
                if (row["sale_num0"] != null && row["sale_num0"].ToString() != "")
                {
                    model.sale_num0 = int.Parse(row["sale_num0"].ToString());
                }
                if (row["cus_numc1"] != null && row["cus_numc1"].ToString() != "")
                {
                    model.cus_numc1 = int.Parse(row["cus_numc1"].ToString());
                }
                if (row["cus_numc2"] != null && row["cus_numc2"].ToString() != "")
                {
                    model.cus_numc2 = int.Parse(row["cus_numc2"].ToString());
                }
                if (row["sale_numc1"] != null && row["sale_numc1"].ToString() != "")
                {
                    model.sale_numc1 = int.Parse(row["sale_numc1"].ToString());
                }
                if (row["sale_numc2"] != null && row["sale_numc2"].ToString() != "")
                {
                    model.sale_numc2 = int.Parse(row["sale_numc2"].ToString());
                }
                if (row["cus_num1_2"] != null && row["cus_num1_2"].ToString() != "")
                {
                    model.cus_num1_2 = int.Parse(row["cus_num1_2"].ToString());
                }
                if (row["sale_num1_2"] != null && row["sale_num1_2"].ToString() != "")
                {
                    model.sale_num1_2 = int.Parse(row["sale_num1_2"].ToString());
                }
                if (row["cus_num2_2"] != null && row["cus_num2_2"].ToString() != "")
                {
                    model.cus_num2_2 = int.Parse(row["cus_num2_2"].ToString());
                }
                if (row["sale_num2_2"] != null && row["sale_num2_2"].ToString() != "")
                {
                    model.sale_num2_2 = int.Parse(row["sale_num2_2"].ToString());
                }
                if (row["cus_num3_2"] != null && row["cus_num3_2"].ToString() != "")
                {
                    model.cus_num3_2 = int.Parse(row["cus_num3_2"].ToString());
                }
                if (row["sale_num3_2"] != null && row["sale_num3_2"].ToString() != "")
                {
                    model.sale_num3_2 = int.Parse(row["sale_num3_2"].ToString());
                }
                if (row["cus_num4_2"] != null && row["cus_num4_2"].ToString() != "")
                {
                    model.cus_num4_2 = int.Parse(row["cus_num4_2"].ToString());
                }
                if (row["sale_num4_2"] != null && row["sale_num4_2"].ToString() != "")
                {
                    model.sale_num4_2 = int.Parse(row["sale_num4_2"].ToString());
                }
                if (row["cus_num5_2"] != null && row["cus_num5_2"].ToString() != "")
                {
                    model.cus_num5_2 = int.Parse(row["cus_num5_2"].ToString());
                }
                if (row["sale_num5_2"] != null && row["sale_num5_2"].ToString() != "")
                {
                    model.sale_num5_2 = int.Parse(row["sale_num5_2"].ToString());
                }
                if (row["sale_num6_2"] != null && row["sale_num6_2"].ToString() != "")
                {
                    model.sale_num6_2 = int.Parse(row["sale_num6_2"].ToString());
                }
                if (row["cus_num6_2"] != null && row["cus_num6_2"].ToString() != "")
                {
                    model.cus_num6_2 = int.Parse(row["cus_num6_2"].ToString());
                }
                if (row["cus_num0_2"] != null && row["cus_num0_2"].ToString() != "")
                {
                    model.cus_num0_2 = int.Parse(row["cus_num0_2"].ToString());
                }
                if (row["sale_num0_2"] != null && row["sale_num0_2"].ToString() != "")
                {
                    model.sale_num0_2 = int.Parse(row["sale_num0_2"].ToString());
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
            strSql.Append("select sale_id,c1,c2,szone,sone,stwo,sthree,sfour,sfive,ssix,zdy,cus_num1,sale_num1,cus_num2,sale_num2,cus_num3,sale_num3,cus_num4,sale_num4,cus_num5,sale_num5,sale_num6,cus_num6,cus_num7,sale_num7,cus_num0,sale_num0,cus_numc1,cus_numc2,sale_numc1,sale_numc2,cus_num1_2,sale_num1_2,cus_num2_2,sale_num2_2,cus_num3_2,sale_num3_2,cus_num4_2,sale_num4_2,cus_num5_2,sale_num5_2,sale_num6_2,cus_num6_2,cus_num0_2,sale_num0_2 ");
            strSql.Append(" FROM ecs_sale_parameters ");
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
            strSql.Append("select count(1) FROM ecs_sale_parameters ");
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
                strSql.Append("order by T.sale_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_sale_parameters T ");
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
            parameters[0].Value = "ecs_sale_parameters";
            parameters[1].Value = "sale_id";
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

