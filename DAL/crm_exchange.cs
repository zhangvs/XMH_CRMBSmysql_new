using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_exchange
    /// </summary>
    public partial class crm_exchange
    {
        public crm_exchange()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_exchange");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_exchange model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_exchange(");
            strSql.Append("Factory_Id,proId,proNam,empId,empcode,empname,createDate,verify_empId,verify_empName,verify_Date,sendee_Name,sendee_way,use_score,isChange)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@proId,@proNam,@empId,@empcode,@empname,@createDate,@verify_empId,@verify_empName,@verify_Date,@sendee_Name,@sendee_way,@use_score,@isChange)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@proId", MySqlDbType.Int32,11),
					new MySqlParameter("@proNam", MySqlDbType.VarChar,10),
					new MySqlParameter("@empId", MySqlDbType.Int32,11),
					new MySqlParameter("@empcode", MySqlDbType.VarChar,10),
					new MySqlParameter("@empname", MySqlDbType.VarChar,50),
					new MySqlParameter("@createDate", MySqlDbType.VarChar,50),
					new MySqlParameter("@verify_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@verify_empName", MySqlDbType.VarChar,60),
					new MySqlParameter("@verify_Date", MySqlDbType.VarChar,50),
					new MySqlParameter("@sendee_Name", MySqlDbType.VarChar,30),
					new MySqlParameter("@sendee_way", MySqlDbType.VarChar,500),
                    new MySqlParameter("@use_score", MySqlDbType.Decimal,16),
					new MySqlParameter("@isChange",MySqlDbType.Int16,4)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.proId;
            parameters[2].Value = model.proNam;
            parameters[3].Value = model.empId;
            parameters[4].Value = model.empcode;
            parameters[5].Value = model.empname;
            parameters[6].Value = model.createDate;
            parameters[7].Value = model.verify_empId;
            parameters[8].Value = model.verify_empName;
            parameters[9].Value = model.verify_Date;
            parameters[10].Value = model.sendee_Name;
            parameters[11].Value = model.sendee_way;
            parameters[12].Value = model.use_score;
            parameters[13].Value = model.isChange;

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
        public bool Update(XHD.Model.crm_exchange model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_exchange set ");
            strSql.Append("Factory_Id=@Factory_Id,");     
            strSql.Append("verify_empId=@verify_empId,");
            strSql.Append("verify_empName=@verify_empName,");
            strSql.Append("verify_Date=@verify_Date,");
            strSql.Append("sendee_Name=@sendee_Name,");
            strSql.Append("sendee_way=@sendee_way,");
            strSql.Append("isChange=@isChange");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),					
					new MySqlParameter("@verify_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@verify_empName", MySqlDbType.VarChar,60),
					new MySqlParameter("@verify_Date", MySqlDbType.VarChar,50),
					new MySqlParameter("@sendee_Name", MySqlDbType.VarChar,30),
					new MySqlParameter("@sendee_way", MySqlDbType.VarChar,500),
					new MySqlParameter("@isChange",MySqlDbType.Int16,4),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.verify_empId;
            parameters[2].Value = model.verify_empName;
            parameters[3].Value = model.verify_Date;
            parameters[4].Value = model.sendee_Name;
            parameters[5].Value = model.sendee_way;
            parameters[6].Value = model.isChange;
            parameters[7].Value = model.Id;

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
            strSql.Append("delete from crm_exchange ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
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
            strSql.Append("delete from crm_exchange ");
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
        public XHD.Model.crm_exchange GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Factory_Id,proId,proNam,empId,empcode,empname,createDate,verify_empId,verify_empName,verify_Date,sendee_Name,sendee_way,use_score,isChange from crm_exchange ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.crm_exchange model = new XHD.Model.crm_exchange();
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
        public XHD.Model.crm_exchange DataRowToModel(DataRow row)
        {
            XHD.Model.crm_exchange model = new XHD.Model.crm_exchange();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["proId"] != null && row["proId"].ToString() != "")
                {
                    model.proId = int.Parse(row["proId"].ToString());
                }
                if (row["proNam"] != null)
                {
                    model.proNam = row["proNam"].ToString();
                }
                if (row["empId"] != null && row["empId"].ToString() != "")
                {
                    model.empId = int.Parse(row["empId"].ToString());
                }
                if (row["empcode"] != null)
                {
                    model.empcode = row["empcode"].ToString();
                }
                if (row["empname"] != null)
                {
                    model.empname = row["empname"].ToString();
                }
                if (row["createDate"] != null)
                {
                    model.createDate = row["createDate"].ToString();
                }
                if (row["verify_empId"] != null && row["verify_empId"].ToString() != "")
                {
                    model.verify_empId = int.Parse(row["verify_empId"].ToString());
                }
                if (row["verify_empName"] != null)
                {
                    model.verify_empName = row["verify_empName"].ToString();
                }
                if (row["verify_Date"] != null)
                {
                    model.verify_Date = row["verify_Date"].ToString();
                }
                if (row["sendee_Name"] != null)
                {
                    model.sendee_Name = row["sendee_Name"].ToString();
                }
                if (row["sendee_way"] != null)
                {
                    model.sendee_way = row["sendee_way"].ToString();
                }
                if (row["use_score"] != null && row["use_score"].ToString() != "")
                {
                    model.use_score = int.Parse(row["use_score"].ToString());
                }
                if (row["isChange"] != null && row["isChange"].ToString() != "")
                {
                    model.isChange = int.Parse(row["isChange"].ToString());
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
            strSql.Append("select Id,Factory_Id,proId,proNam,empId,empcode,empname,createDate,verify_empId,verify_empName,verify_Date,sendee_Name,sendee_way,use_score,isChange ");
            strSql.Append(" FROM crm_exchange ");
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
            strSql.Append(" select Id,Factory_Id,proId,proNam,empId,empcode,empname,createDate,verify_empId,verify_empName,verify_Date,sendee_Name,sendee_way,use_score,isChange FROM crm_exchange ");
            strSql1.Append(" select count(Id) FROM crm_exchange ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
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
            parameters[0].Value = "crm_exchange";
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

