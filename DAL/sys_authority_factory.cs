﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:sys_authority_factory
    /// </summary>
    public partial class sys_authority_factory
    {
        public sys_authority_factory()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Factory_Id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from sys_authority_factory");
            strSql.Append(" where Factory_Id=@Factory_Id and App_ids=@App_ids and Menu_ids=@Menu_ids and Button_ids=@Button_ids and Create_id=@Create_id and Create_date=@Create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@App_ids", MySqlDbType.VarChar,250),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,10000),
					new MySqlParameter("@Button_ids", MySqlDbType.VarChar,10000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = Factory_Id;
            parameters[1].Value = App_ids;
            parameters[2].Value = Menu_ids;
            parameters[3].Value = Button_ids;
            parameters[4].Value = Create_id;
            parameters[5].Value = Create_date;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.sys_authority_factory model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into sys_authority_factory(");
            strSql.Append("Factory_Id,App_ids,Menu_ids,Button_ids,Create_id,Create_date)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@App_ids,@Menu_ids,@Button_ids,@Create_id,@Create_date)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@App_ids", MySqlDbType.VarChar,250),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,10000),
					new MySqlParameter("@Button_ids", MySqlDbType.VarChar,10000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.App_ids;
            parameters[2].Value = model.Menu_ids;
            parameters[3].Value = model.Button_ids;
            parameters[4].Value = model.Create_id;
            parameters[5].Value = model.Create_date;

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
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet authList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  max(Sys_view),max(Sys_add),max(Sys_edit),max(Sys_del)  ");
            strSql.Append(" FROM Sys_data_authority ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.sys_authority_factory model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update sys_authority_factory set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("App_ids=@App_ids,");
            strSql.Append("Menu_ids=@Menu_ids,");
            strSql.Append("Button_ids=@Button_ids");
            strSql.Append(" where Factory_Id=@Factory_Id and App_ids=@App_ids and Menu_ids=@Menu_ids and Button_ids=@Button_ids ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@App_ids", MySqlDbType.VarChar,250),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,500),
					new MySqlParameter("@Button_ids", MySqlDbType.VarChar,500)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.App_ids;
            parameters[2].Value = model.Menu_ids;
            parameters[3].Value = model.Button_ids;

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
        public bool Delete(string Factory_Id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from sys_authority_factory ");
            strSql.Append(" where Factory_Id=@Factory_Id and App_ids=@App_ids and Menu_ids=@Menu_ids and Button_ids=@Button_ids and Create_id=@Create_id and Create_date=@Create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@App_ids", MySqlDbType.VarChar,250),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,500),
					new MySqlParameter("@Button_ids", MySqlDbType.VarChar,500),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = Factory_Id;
            parameters[1].Value = App_ids;
            parameters[2].Value = Menu_ids;
            parameters[3].Value = Button_ids;
            parameters[4].Value = Create_id;
            parameters[5].Value = Create_date;

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
        public bool DeleteWhere(string wherestr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from sys_authority_factory ");
            strSql.Append(" where " + wherestr + "  ");
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
        public XHD.Model.sys_authority_factory GetModel(string Factory_Id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Factory_Id,App_ids,Menu_ids,Button_ids,Create_id,Create_date from sys_authority_factory ");
            strSql.Append(" where Factory_Id=@Factory_Id and App_ids=@App_ids and Menu_ids=@Menu_ids and Button_ids=@Button_ids and Create_id=@Create_id and Create_date=@Create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@App_ids", MySqlDbType.VarChar,250),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,500),
					new MySqlParameter("@Button_ids", MySqlDbType.VarChar,500),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = Factory_Id;
            parameters[1].Value = App_ids;
            parameters[2].Value = Menu_ids;
            parameters[3].Value = Button_ids;
            parameters[4].Value = Create_id;
            parameters[5].Value = Create_date;

            XHD.Model.sys_authority_factory model = new XHD.Model.sys_authority_factory();
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
        public XHD.Model.sys_authority_factory DataRowToModel(DataRow row)
        {
            XHD.Model.sys_authority_factory model = new XHD.Model.sys_authority_factory();
            if (row != null)
            {
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["App_ids"] != null)
                {
                    model.App_ids = row["App_ids"].ToString();
                }
                if (row["Menu_ids"] != null)
                {
                    model.Menu_ids = row["Menu_ids"].ToString();
                }
                if (row["Button_ids"] != null)
                {
                    model.Button_ids = row["Button_ids"].ToString();
                }
                if (row["Create_id"] != null && row["Create_id"].ToString() != "")
                {
                    model.Create_id = int.Parse(row["Create_id"].ToString());
                }
                if (row["Create_date"] != null && row["Create_date"].ToString() != "")
                {
                    model.Create_date = DateTime.Parse(row["Create_date"].ToString());
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
            strSql.Append("select Factory_Id,App_ids,Menu_ids,Button_ids,Create_id,Create_date ");
            strSql.Append(" FROM sys_authority_factory ");
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
            strSql.Append("select count(1) FROM sys_authority_factory ");
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
                strSql.Append("order by T.Create_date desc");
            }
            strSql.Append(")AS Row, T.*  from sys_authority_factory T ");
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
            parameters[0].Value = "sys_authority_factory";
            parameters[1].Value = "Create_date";
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

