using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_brand_checkDAO
    /// </summary>
    public partial class ecs_brand_checkDAO
    {
        public ecs_brand_checkDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bc_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_brand_check");
            strSql.Append(" where bc_id=@bc_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@bc_id", MySqlDbType.Int32)
			};
            parameters[0].Value = bc_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_brand_check model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_brand_check(");
            strSql.Append("bc_brand_id,bc_brand_name,bc_year,bc_user_id,bc_user_name,bc_real_name,bc_base,bc_task,b_1,b_2,b_3,b_4,b_5,b_6,b_7,b_8,b_9,b_10,b_11,b_12,a_1,a_2,a_3,a_4,a_5,a_6,a_7,a_8,a_9,a_10,a_11,a_12,create_time,create_name,factory_id)");
            strSql.Append(" values (");
            strSql.Append("@bc_brand_id,@bc_brand_name,@bc_year,@bc_user_id,@bc_user_name,@bc_real_name,@bc_base,@bc_task,@b_1,@b_2,@b_3,@b_4,@b_5,@b_6,@b_7,@b_8,@b_9,@b_10,@b_11,@b_12,@a_1,@a_2,@a_3,@a_4,@a_5,@a_6,@a_7,@a_8,@a_9,@a_10,@a_11,@a_12,@create_time,@create_name,@factory_id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@bc_brand_id", MySqlDbType.Int32,10),
					new MySqlParameter("@bc_brand_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@bc_year", MySqlDbType.VarChar,4),
					new MySqlParameter("@bc_user_id", MySqlDbType.Int32,10),
					new MySqlParameter("@bc_user_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@bc_real_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@bc_base", MySqlDbType.Int32,100),
					new MySqlParameter("@bc_task", MySqlDbType.Int32,10),
					new MySqlParameter("@b_1", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_2", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_3", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_4", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_5", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_6", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_7", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_8", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_9", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_10", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_11", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_12", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_1", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_2", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_3", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_4", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_5", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_6", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_7", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_8", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_9", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_10", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_11", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_12", MySqlDbType.Decimal,10),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,20)};
            parameters[0].Value = model.bc_brand_id;
            parameters[1].Value = model.bc_brand_name;
            parameters[2].Value = model.bc_year;
            parameters[3].Value = model.bc_user_id;
            parameters[4].Value = model.bc_user_name;
            parameters[5].Value = model.bc_real_name;
            parameters[6].Value = model.bc_base;
            parameters[7].Value = model.bc_task;
            parameters[8].Value = model.b_1;
            parameters[9].Value = model.b_2;
            parameters[10].Value = model.b_3;
            parameters[11].Value = model.b_4;
            parameters[12].Value = model.b_5;
            parameters[13].Value = model.b_6;
            parameters[14].Value = model.b_7;
            parameters[15].Value = model.b_8;
            parameters[16].Value = model.b_9;
            parameters[17].Value = model.b_10;
            parameters[18].Value = model.b_11;
            parameters[19].Value = model.b_12;
            parameters[20].Value = model.a_1;
            parameters[21].Value = model.a_2;
            parameters[22].Value = model.a_3;
            parameters[23].Value = model.a_4;
            parameters[24].Value = model.a_5;
            parameters[25].Value = model.a_6;
            parameters[26].Value = model.a_7;
            parameters[27].Value = model.a_8;
            parameters[28].Value = model.a_9;
            parameters[29].Value = model.a_10;
            parameters[30].Value = model.a_11;
            parameters[31].Value = model.a_12;
            parameters[32].Value = model.create_time;
            parameters[33].Value = model.create_name;
            parameters[34].Value = model.factory_id;

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
        public bool Update(XHD.Model.ecs_brand_check model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_brand_check set ");
            strSql.Append("bc_brand_id=@bc_brand_id,");
            strSql.Append("bc_brand_name=@bc_brand_name,");
            strSql.Append("bc_year=@bc_year,");
            strSql.Append("bc_user_id=@bc_user_id,");
            strSql.Append("bc_user_name=@bc_user_name,");
            strSql.Append("bc_real_name=@bc_real_name,");
            strSql.Append("bc_base=@bc_base,");
            strSql.Append("bc_task=@bc_task,");
            strSql.Append("b_1=@b_1,");
            strSql.Append("b_2=@b_2,");
            strSql.Append("b_3=@b_3,");
            strSql.Append("b_4=@b_4,");
            strSql.Append("b_5=@b_5,");
            strSql.Append("b_6=@b_6,");
            strSql.Append("b_7=@b_7,");
            strSql.Append("b_8=@b_8,");
            strSql.Append("b_9=@b_9,");
            strSql.Append("b_10=@b_10,");
            strSql.Append("b_11=@b_11,");
            strSql.Append("b_12=@b_12,");
            strSql.Append("a_1=@a_1,");
            strSql.Append("a_2=@a_2,");
            strSql.Append("a_3=@a_3,");
            strSql.Append("a_4=@a_4,");
            strSql.Append("a_5=@a_5,");
            strSql.Append("a_6=@a_6,");
            strSql.Append("a_7=@a_7,");
            strSql.Append("a_8=@a_8,");
            strSql.Append("a_9=@a_9,");
            strSql.Append("a_10=@a_10,");
            strSql.Append("a_11=@a_11,");
            strSql.Append("a_12=@a_12,");
            strSql.Append("create_time=@create_time,");
            strSql.Append("create_name=@create_name,");
            strSql.Append("factory_id=@factory_id");
            strSql.Append(" where bc_id=@bc_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@bc_brand_id", MySqlDbType.Int32,10),
					new MySqlParameter("@bc_brand_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@bc_year", MySqlDbType.VarChar,4),
					new MySqlParameter("@bc_user_id", MySqlDbType.Int32,10),
					new MySqlParameter("@bc_user_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@bc_real_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@bc_base", MySqlDbType.Int32,100),
					new MySqlParameter("@bc_task", MySqlDbType.Int32,10),
					new MySqlParameter("@b_1", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_2", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_3", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_4", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_5", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_6", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_7", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_8", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_9", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_10", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_11", MySqlDbType.Decimal,10),
					new MySqlParameter("@b_12", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_1", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_2", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_3", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_4", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_5", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_6", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_7", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_8", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_9", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_10", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_11", MySqlDbType.Decimal,10),
					new MySqlParameter("@a_12", MySqlDbType.Decimal,10),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@bc_id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.bc_brand_id;
            parameters[1].Value = model.bc_brand_name;
            parameters[2].Value = model.bc_year;
            parameters[3].Value = model.bc_user_id;
            parameters[4].Value = model.bc_user_name;
            parameters[5].Value = model.bc_real_name;
            parameters[6].Value = model.bc_base;
            parameters[7].Value = model.bc_task;
            parameters[8].Value = model.b_1;
            parameters[9].Value = model.b_2;
            parameters[10].Value = model.b_3;
            parameters[11].Value = model.b_4;
            parameters[12].Value = model.b_5;
            parameters[13].Value = model.b_6;
            parameters[14].Value = model.b_7;
            parameters[15].Value = model.b_8;
            parameters[16].Value = model.b_9;
            parameters[17].Value = model.b_10;
            parameters[18].Value = model.b_11;
            parameters[19].Value = model.b_12;
            parameters[20].Value = model.a_1;
            parameters[21].Value = model.a_2;
            parameters[22].Value = model.a_3;
            parameters[23].Value = model.a_4;
            parameters[24].Value = model.a_5;
            parameters[25].Value = model.a_6;
            parameters[26].Value = model.a_7;
            parameters[27].Value = model.a_8;
            parameters[28].Value = model.a_9;
            parameters[29].Value = model.a_10;
            parameters[30].Value = model.a_11;
            parameters[31].Value = model.a_12;
            parameters[32].Value = model.create_time;
            parameters[33].Value = model.create_name;
            parameters[34].Value = model.factory_id;
            parameters[35].Value = model.bc_id;

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
        public bool Delete(int bc_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_brand_check ");
            strSql.Append(" where bc_id=@bc_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@bc_id", MySqlDbType.Int32)
			};
            parameters[0].Value = bc_id;

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
        public bool DeleteList(string bc_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_brand_check ");
            strSql.Append(" where bc_id in (" + bc_idlist + ")  ");
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
        public XHD.Model.ecs_brand_check GetModel(int bc_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select bc_id,bc_brand_id,bc_brand_name,bc_year,bc_user_id,bc_user_name,bc_real_name,bc_base,bc_task,b_1,b_2,b_3,b_4,b_5,b_6,b_7,b_8,b_9,b_10,b_11,b_12,a_1,a_2,a_3,a_4,a_5,a_6,a_7,a_8,a_9,a_10,a_11,a_12,create_time,create_name,factory_id from ecs_brand_check ");
            strSql.Append(" where bc_id=@bc_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@bc_id", MySqlDbType.Int32)
			};
            parameters[0].Value = bc_id;

            XHD.Model.ecs_brand_check model = new XHD.Model.ecs_brand_check();
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
        public XHD.Model.ecs_brand_check DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_brand_check model = new XHD.Model.ecs_brand_check();
            if (row != null)
            {
                if (row["bc_id"] != null && row["bc_id"].ToString() != "")
                {
                    model.bc_id = int.Parse(row["bc_id"].ToString());
                }
                if (row["bc_brand_id"] != null && row["bc_brand_id"].ToString() != "")
                {
                    model.bc_brand_id = int.Parse(row["bc_brand_id"].ToString());
                }
                if (row["bc_brand_name"] != null)
                {
                    model.bc_brand_name = row["bc_brand_name"].ToString();
                }
                if (row["bc_year"] != null)
                {
                    model.bc_year = row["bc_year"].ToString();
                }
                if (row["bc_user_id"] != null && row["bc_user_id"].ToString() != "")
                {
                    model.bc_user_id = int.Parse(row["bc_user_id"].ToString());
                }
                if (row["bc_user_name"] != null)
                {
                    model.bc_user_name = row["bc_user_name"].ToString();
                }
                if (row["bc_real_name"] != null)
                {
                    model.bc_real_name = row["bc_real_name"].ToString();
                }
                if (row["bc_base"] != null && row["bc_base"].ToString() != "")
                {
                    model.bc_base = int.Parse(row["bc_base"].ToString());
                }
                if (row["bc_task"] != null && row["bc_task"].ToString() != "")
                {
                    model.bc_task = int.Parse(row["bc_task"].ToString());
                }
                if (row["b_1"] != null && row["b_1"].ToString() != "")
                {
                    model.b_1 = decimal.Parse(row["b_1"].ToString());
                }
                if (row["b_2"] != null && row["b_2"].ToString() != "")
                {
                    model.b_2 = decimal.Parse(row["b_2"].ToString());
                }
                if (row["b_3"] != null && row["b_3"].ToString() != "")
                {
                    model.b_3 = decimal.Parse(row["b_3"].ToString());
                }
                if (row["b_4"] != null && row["b_4"].ToString() != "")
                {
                    model.b_4 = decimal.Parse(row["b_4"].ToString());
                }
                if (row["b_5"] != null && row["b_5"].ToString() != "")
                {
                    model.b_5 = decimal.Parse(row["b_5"].ToString());
                }
                if (row["b_6"] != null && row["b_6"].ToString() != "")
                {
                    model.b_6 = decimal.Parse(row["b_6"].ToString());
                }
                if (row["b_7"] != null && row["b_7"].ToString() != "")
                {
                    model.b_7 = decimal.Parse(row["b_7"].ToString());
                }
                if (row["b_8"] != null && row["b_8"].ToString() != "")
                {
                    model.b_8 = decimal.Parse(row["b_8"].ToString());
                }
                if (row["b_9"] != null && row["b_9"].ToString() != "")
                {
                    model.b_9 = decimal.Parse(row["b_9"].ToString());
                }
                if (row["b_10"] != null && row["b_10"].ToString() != "")
                {
                    model.b_10 = decimal.Parse(row["b_10"].ToString());
                }
                if (row["b_11"] != null && row["b_11"].ToString() != "")
                {
                    model.b_11 = decimal.Parse(row["b_11"].ToString());
                }
                if (row["b_12"] != null && row["b_12"].ToString() != "")
                {
                    model.b_12 = decimal.Parse(row["b_12"].ToString());
                }
                if (row["a_1"] != null && row["a_1"].ToString() != "")
                {
                    model.a_1 = decimal.Parse(row["a_1"].ToString());
                }
                if (row["a_2"] != null && row["a_2"].ToString() != "")
                {
                    model.a_2 = decimal.Parse(row["a_2"].ToString());
                }
                if (row["a_3"] != null && row["a_3"].ToString() != "")
                {
                    model.a_3 = decimal.Parse(row["a_3"].ToString());
                }
                if (row["a_4"] != null && row["a_4"].ToString() != "")
                {
                    model.a_4 = decimal.Parse(row["a_4"].ToString());
                }
                if (row["a_5"] != null && row["a_5"].ToString() != "")
                {
                    model.a_5 = decimal.Parse(row["a_5"].ToString());
                }
                if (row["a_6"] != null && row["a_6"].ToString() != "")
                {
                    model.a_6 = decimal.Parse(row["a_6"].ToString());
                }
                if (row["a_7"] != null && row["a_7"].ToString() != "")
                {
                    model.a_7 = decimal.Parse(row["a_7"].ToString());
                }
                if (row["a_8"] != null && row["a_8"].ToString() != "")
                {
                    model.a_8 = decimal.Parse(row["a_8"].ToString());
                }
                if (row["a_9"] != null && row["a_9"].ToString() != "")
                {
                    model.a_9 = decimal.Parse(row["a_9"].ToString());
                }
                if (row["a_10"] != null && row["a_10"].ToString() != "")
                {
                    model.a_10 = decimal.Parse(row["a_10"].ToString());
                }
                if (row["a_11"] != null && row["a_11"].ToString() != "")
                {
                    model.a_11 = decimal.Parse(row["a_11"].ToString());
                }
                if (row["a_12"] != null && row["a_12"].ToString() != "")
                {
                    model.a_12 = decimal.Parse(row["a_12"].ToString());
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
            strSql.Append("select bc_id,bc_brand_id,bc_brand_name,bc_year,bc_user_id,bc_user_name,bc_real_name,bc_base,bc_task,b_1,b_2,b_3,b_4,b_5,b_6,b_7,b_8,b_9,b_10,b_11,b_12,a_1,a_2,a_3,a_4,a_5,a_6,a_7,a_8,a_9,a_10,a_11,a_12,create_time,create_name,factory_id ");
            strSql.Append(" FROM ecs_brand_check ");
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
            strSql.Append("select count(1) FROM ecs_brand_check ");
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
                strSql.Append("order by T.bc_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_brand_check T ");
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
            parameters[0].Value = "ecs_brand_check";
            parameters[1].Value = "bc_id";
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
        /// 获得数据列表,根据哪个月份
        /// </summary>
        public DataSet GetPlanBaseList(string monthColumms, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + monthColumms + " bc_brand_name,bc_base,bc_task");
            strSql.Append(" FROM ecs_brand_check ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表,根据哪个月份
        /// </summary>
        public DataSet GetYearPlanBaseList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select bc_brand_name,bc_base,bc_task");
            strSql.Append(" FROM ecs_brand_check ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表,根据哪个月份,部门和，多人
        /// </summary>
        public DataSet GetPlanBaseList_Manager(string monthColumms, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + monthColumms + " sum(bc_base) bc_base,sum(bc_task) bc_task,bc_brand_name");
            strSql.Append(" FROM ecs_brand_check ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" GROUP BY bc_brand_id ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表,根据哪个月份,部门和，多人
        /// </summary>
        public DataSet GetYearPlanBaseList_Manager(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select bc_brand_name, sum(bc_base) bc_base,sum(bc_task) bc_task");
            strSql.Append(" FROM ecs_brand_check ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" GROUP BY bc_brand_id ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select * FROM ecs_brand_check ");
            strSql1.Append(" select count(*) FROM ecs_brand_check ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update2(XHD.Model.ecs_brand_check model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_brand_check set ");
            strSql.Append("bc_base=@bc_base,");
            strSql.Append("bc_task=@bc_task,");
            strSql.Append("b_1=@b_1,");
            strSql.Append("b_2=@b_2,");
            strSql.Append("b_3=@b_3,");
            strSql.Append("b_4=@b_4,");
            strSql.Append("b_5=@b_5,");
            strSql.Append("b_6=@b_6,");
            strSql.Append("b_7=@b_7,");
            strSql.Append("b_8=@b_8,");
            strSql.Append("b_9=@b_9,");
            strSql.Append("b_10=@b_10,");
            strSql.Append("b_11=@b_11,");
            strSql.Append("b_12=@b_12,");
            strSql.Append("a_1=@a_1,");
            strSql.Append("a_2=@a_2,");
            strSql.Append("a_3=@a_3,");
            strSql.Append("a_4=@a_4,");
            strSql.Append("a_5=@a_5,");
            strSql.Append("a_6=@a_6,");
            strSql.Append("a_7=@a_7,");
            strSql.Append("a_8=@a_8,");
            strSql.Append("a_9=@a_9,");
            strSql.Append("a_10=@a_10,");
            strSql.Append("a_11=@a_11,");
            strSql.Append("a_12=@a_12");
            strSql.Append(" where bc_id=@bc_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@bc_base", MySqlDbType.Int32,100),
					new MySqlParameter("@bc_task", MySqlDbType.Int32,10),
					new MySqlParameter("@b_1", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_2", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_3", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_4", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_5", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_6", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_7", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_8", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_9", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_10", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_11", MySqlDbType.Decimal,18),
					new MySqlParameter("@b_12", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_1", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_2", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_3", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_4", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_5", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_6", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_7", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_8", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_9", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_10", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_11", MySqlDbType.Decimal,18),
					new MySqlParameter("@a_12", MySqlDbType.Decimal,18),
					new MySqlParameter("@bc_id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.bc_base;
            parameters[1].Value = model.bc_task;
            parameters[2].Value = model.b_1;
            parameters[3].Value = model.b_2;
            parameters[4].Value = model.b_3;
            parameters[5].Value = model.b_4;
            parameters[6].Value = model.b_5;
            parameters[7].Value = model.b_6;
            parameters[8].Value = model.b_7;
            parameters[9].Value = model.b_8;
            parameters[10].Value = model.b_9;
            parameters[11].Value = model.b_10;
            parameters[12].Value = model.b_11;
            parameters[13].Value = model.b_12;
            parameters[14].Value = model.a_1;
            parameters[15].Value = model.a_2;
            parameters[16].Value = model.a_3;
            parameters[17].Value = model.a_4;
            parameters[18].Value = model.a_5;
            parameters[19].Value = model.a_6;
            parameters[20].Value = model.a_7;
            parameters[21].Value = model.a_8;
            parameters[22].Value = model.a_9;
            parameters[23].Value = model.a_10;
            parameters[24].Value = model.a_11;
            parameters[25].Value = model.a_12;
            parameters[26].Value = model.bc_id;

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
        #endregion  ExtensionMethod
    }
}

