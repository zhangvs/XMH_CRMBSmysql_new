using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_set_pripub_detail
    /// </summary>
    public partial class crm_set_pripub_detail
    {
        public crm_set_pripub_detail()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "crm_set_pripub_detail");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_set_pripub_detail");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 判断时间是否重叠
        /// </summary>
        public bool CkeckDate(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_set_pripub_detail");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_set_pripub_detail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_set_pripub_detail(");
            strSql.Append("Id,factory_Id,current_year,pripub_type,date_start,date_end,feat,C_createId,C_createName,C_createDate,move_Qty)");
            strSql.Append(" values (");
            strSql.Append("@Id,@factory_Id,@current_year,@pripub_type,@date_start,@date_end,@feat,@C_createId,@C_createName,@C_createDate,@move_Qty)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@current_year", MySqlDbType.Int32,4),
					new MySqlParameter("@pripub_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@date_start", MySqlDbType.Int32,11),
					new MySqlParameter("@date_end", MySqlDbType.Int32,11),
					new MySqlParameter("@feat", MySqlDbType.Float,20),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@move_Qty", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.factory_Id;
            parameters[2].Value = model.current_year;
            parameters[3].Value = model.pripub_type;
            parameters[4].Value = model.date_start;
            parameters[5].Value = model.date_end;
            parameters[6].Value = model.feat;
            parameters[7].Value = model.C_createId;
            parameters[8].Value = model.C_createName;
            parameters[9].Value = model.C_createDate;
            parameters[10].Value = model.move_Qty;

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
        public bool Update(XHD.Model.crm_set_pripub_detail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_set_pripub_detail set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("current_year=@current_year,");
            strSql.Append("pripub_type=@pripub_type,");
            strSql.Append("date_start=@date_start,");
            strSql.Append("date_end=@date_end,");
            strSql.Append("feat=@feat,");
            strSql.Append("C_createId=@C_createId,");
            strSql.Append("C_createName=@C_createName,");
            strSql.Append("C_createDate=@C_createDate,");
            strSql.Append("move_Qty=@move_Qty");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@current_year", MySqlDbType.Int32,4),
					new MySqlParameter("@pripub_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@date_start", MySqlDbType.Int32,11),
					new MySqlParameter("@date_end", MySqlDbType.Int32,11),
					new MySqlParameter("@feat", MySqlDbType.Float,20),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@move_Qty", MySqlDbType.Int32,11),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.current_year;
            parameters[2].Value = model.pripub_type;
            parameters[3].Value = model.date_start;
            parameters[4].Value = model.date_end;
            parameters[5].Value = model.feat;
            parameters[6].Value = model.C_createId;
            parameters[7].Value = model.C_createName;
            parameters[8].Value = model.C_createDate;
            parameters[9].Value = model.move_Qty;
            parameters[10].Value = model.Id;

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
        public bool Update(int id,string factory_id,decimal money)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_set_pripub_detail set ");
            strSql.Append("feat=@feat");
            strSql.Append(" where Id=@Id ");
            strSql.Append(" and factory_Id=@factory_Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@feat", MySqlDbType.Float,20),
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60)};
            parameters[0].Value = money;
            parameters[1].Value = id;
            parameters[2].Value = factory_id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_set_pripub_detail ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_set_pripub_detail ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        public XHD.Model.crm_set_pripub_detail GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,current_year,pripub_type,date_start,date_end,feat,C_createId,C_createName,C_createDate,move_Qty from crm_set_pripub_detail ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            XHD.Model.crm_set_pripub_detail model = new XHD.Model.crm_set_pripub_detail();
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
        public XHD.Model.crm_set_pripub_detail DataRowToModel(DataRow row)
        {
            XHD.Model.crm_set_pripub_detail model = new XHD.Model.crm_set_pripub_detail();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["current_year"] != null && row["current_year"].ToString() != "")
                {
                    model.current_year = int.Parse(row["current_year"].ToString());
                }
                if (row["pripub_type"] != null)
                {
                    model.pripub_type = row["pripub_type"].ToString();
                }
                if (row["date_start"] != null && row["date_start"].ToString() != "")
                {
                    model.date_start = int.Parse(row["date_start"].ToString());
                }
                if (row["date_end"] != null && row["date_end"].ToString() != "")
                {
                    model.date_end = int.Parse(row["date_end"].ToString());
                }
                if (row["feat"] != null && row["feat"].ToString() != "")
                {
                    model.feat = decimal.Parse(row["feat"].ToString());
                }
                if (row["C_createId"] != null && row["C_createId"].ToString() != "")
                {
                    model.C_createId = int.Parse(row["C_createId"].ToString());
                }
                if (row["C_createName"] != null)
                {
                    model.C_createName = row["C_createName"].ToString();
                }
                if (row["C_createDate"] != null && row["C_createDate"].ToString() != "")
                {
                    model.C_createDate = DateTime.Parse(row["C_createDate"].ToString());
                }
                if (row["move_Qty"] != null && row["move_Qty"].ToString() != "")
                {
                    model.move_Qty = int.Parse(row["move_Qty"].ToString());
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
            strSql.Append("select Id,factory_Id,current_year,pripub_type,date_start,date_end,feat,C_createId,C_createName,C_createDate,move_Qty ");
            strSql.Append(" FROM crm_set_pripub_detail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取年限
        /// </summary>
        public DataSet GetYear(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct current_year ");
            strSql.Append(" FROM crm_set_pripub_detail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select Id,factory_Id,current_year,pripub_type,date_start,date_end,feat,C_createId,C_createName,C_createDate,move_Qty FROM crm_set_pripub_detail ");
            strSql1.Append(" select count(Id) FROM crm_set_pripub_detail ");
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM crm_set_pripub_detail ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from crm_set_pripub_detail T ");
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
            parameters[0].Value = "crm_set_pripub_detail";
            parameters[1].Value = "Id";
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

