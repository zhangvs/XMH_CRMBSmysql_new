using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XHD.DBUtility;

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:fms_costitem
    /// </summary>
    public partial class fms_costitem
    {
        public fms_costitem()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return FMS_DbHelperMySQL.GetMaxID("id", "fms_costitem");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from fms_costitem");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return FMS_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FMS_Model.fms_costitem model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fms_costitem(");
            strSql.Append("id,Factory_Id,code,title,creater,createtime,item_order,parent_code)");
            strSql.Append(" values (");
            strSql.Append("@id,@Factory_Id,@code,@title,@creater,@createtime,@item_order,@parent_code)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@code", MySqlDbType.VarChar,255),
					new MySqlParameter("@title", MySqlDbType.VarChar,255),
					new MySqlParameter("@creater", MySqlDbType.VarChar,255),
					new MySqlParameter("@createtime", MySqlDbType.DateTime),
                    new MySqlParameter("@item_order",MySqlDbType.Int32,11),
                    new MySqlParameter("@parent_code", MySqlDbType.VarChar,255)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.Factory_Id;
            parameters[2].Value = model.code;
            parameters[3].Value = model.title;
            parameters[4].Value = model.creater;
            parameters[5].Value = model.createtime;
            parameters[6].Value = model.item_order;
            parameters[7].Value = model.parent_code;

            object obj = FMS_DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.fms_costitem model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_costitem set ");
            strSql.Append("title=@title,");
            strSql.Append("item_order=@item_order,");
            strSql.Append("creater=@creater,");
            strSql.Append("createtime=@createtime");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@title", MySqlDbType.VarChar,255),
                    new MySqlParameter("@item_order", MySqlDbType.Int32,11),
					new MySqlParameter("@creater", MySqlDbType.VarChar,255),
					new MySqlParameter("@createtime", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.title;
            parameters[1].Value = model.item_order;
            parameters[2].Value = model.creater;
            parameters[3].Value = model.createtime;
            parameters[4].Value = model.id;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
            strSql.Append("delete from fms_costitem ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
            strSql.Append("delete from fms_costitem ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public FMS_Model.fms_costitem GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,code,title,item_order,creater,createtime,parent_code from fms_costitem ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            FMS_Model.fms_costitem model = new FMS_Model.fms_costitem();
            DataSet ds = FMS_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public FMS_Model.fms_costitem DataRowToModel(DataRow row)
        {
            FMS_Model.fms_costitem model = new FMS_Model.fms_costitem();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["code"] != null)
                {
                    model.code = row["code"].ToString();
                }
                if (row["title"] != null)
                {
                    model.title = row["title"].ToString();
                }
                if (row["item_order"] != null && row["item_order"].ToString() != "")
                {
                    model.item_order = int.Parse(row["item_order"].ToString());
                }
                if (row["creater"] != null)
                {
                    model.creater = row["creater"].ToString();
                }
                if (row["createtime"] != null && row["createtime"].ToString() != "")
                {
                    model.createtime = DateTime.Parse(row["createtime"].ToString());
                }
                if (row["parent_code"] != null)
                {
                    model.code = row["parent_code"].ToString();
                }
            }
            return model;
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select id,Factory_Id,code,title,item_order,creater,createtime,parent_code ");
            strSql.Append(" FROM fms_costitem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
            }
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,code,title,item_order,creater,createtime,parent_code ");
            strSql.Append(" FROM fms_costitem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetMaxList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(code) as code ");
            strSql.Append(" FROM fms_costitem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
