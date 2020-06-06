using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;//Please add references

namespace XHD.DAL.ims
{
    /// <summary>
    /// 数据访问类:ims_check_cycle
    /// </summary>
    public partial class ims_check_cycle
    {
        public ims_check_cycle()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "ims_check_cycle");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ims_check_cycle");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ims.ims_check_cycle model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ims_check_cycle(");
            strSql.Append("id,cycle_name,cycle_day,cycle_remark,creat_empId,create_empName,create_date,cycle_Id)");
            strSql.Append(" values (");
            strSql.Append("@id,@cycle_name,@cycle_day,@cycle_remark,@creat_empId,@create_empName,@create_date,@cycle_Id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@cycle_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@cycle_day", MySqlDbType.Int32,11),
					new MySqlParameter("@cycle_remark", MySqlDbType.VarChar,500),
					new MySqlParameter("@creat_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@create_empName", MySqlDbType.VarChar,50),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
                    new MySqlParameter("@cycle_Id",MySqlDbType.Int32,11)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.cycle_name;
            parameters[2].Value = model.cycle_day;
            parameters[3].Value = model.cycle_remark;
            parameters[4].Value = model.creat_empId;
            parameters[5].Value = model.create_empName;
            parameters[6].Value = model.create_date;
            parameters[7].Value = model.cycle_Id;

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
        public bool Update(XHD.Model.ims.ims_check_cycle model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ims_check_cycle set ");
            strSql.Append("cycle_Id=@cycle_Id,");
            strSql.Append("cycle_name=@cycle_name,");
            strSql.Append("cycle_day=@cycle_day,");
            strSql.Append("cycle_remark=@cycle_remark,");
            strSql.Append("creat_empId=@creat_empId,");
            strSql.Append("create_empName=@create_empName,");
            strSql.Append("create_date=@create_date");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@cycle_Id",MySqlDbType.Int32,11),
					new MySqlParameter("@cycle_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@cycle_day", MySqlDbType.Int32,11),
					new MySqlParameter("@cycle_remark", MySqlDbType.VarChar,500),
					new MySqlParameter("@creat_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@create_empName", MySqlDbType.VarChar,50),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.cycle_Id;
            parameters[1].Value = model.cycle_name;
            parameters[2].Value = model.cycle_day;
            parameters[3].Value = model.cycle_remark;
            parameters[4].Value = model.creat_empId;
            parameters[5].Value = model.create_empName;
            parameters[6].Value = model.create_date;
            parameters[7].Value = model.id;

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
            strSql.Append("delete from ims_check_cycle ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
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
            strSql.Append("delete from ims_check_cycle ");
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
        public XHD.Model.ims.ims_check_cycle GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,cycle_Id,cycle_name,cycle_day,cycle_remark,creat_empId,create_empName,create_date from ims_check_cycle ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.ims.ims_check_cycle model = new XHD.Model.ims.ims_check_cycle();
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
        public XHD.Model.ims.ims_check_cycle DataRowToModel(DataRow row)
        {
            XHD.Model.ims.ims_check_cycle model = new XHD.Model.ims.ims_check_cycle();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["cycle_Id"] != null && row["cycle_Id"].ToString() != "")
                {
                    model.cycle_Id = int.Parse(row["cycle_Id"].ToString());
                }
                if (row["cycle_name"] != null)
                {
                    model.cycle_name = row["cycle_name"].ToString();
                }
                if (row["cycle_day"] != null && row["cycle_day"].ToString() != "")
                {
                    model.cycle_day = int.Parse(row["cycle_day"].ToString());
                }
                if (row["cycle_remark"] != null)
                {
                    model.cycle_remark = row["cycle_remark"].ToString();
                }
                if (row["creat_empId"] != null && row["creat_empId"].ToString() != "")
                {
                    model.creat_empId = int.Parse(row["creat_empId"].ToString());
                }
                if (row["create_empName"] != null)
                {
                    model.create_empName = row["create_empName"].ToString();
                }
                if (row["create_date"] != null && row["create_date"].ToString() != "")
                {
                    model.create_date = DateTime.Parse(row["create_date"].ToString());
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
            strSql.Append("select id,cycle_Id,cycle_name,cycle_day,cycle_remark,creat_empId,create_empName,create_date ");
            strSql.Append(" FROM ims_check_cycle ");
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
            strSql.Append(" select id,cycle_Id,cycle_name,cycle_day,cycle_remark,creat_empId,create_empName,create_date FROM ims_check_cycle ");
            strSql1.Append(" select count(id) FROM ims_check_cycle ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

