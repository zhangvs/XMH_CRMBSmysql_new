/**  版本信息模板在安装目录下，可自行修改。
* Exchange.cs
*
* 功 能： N/A
* 类 名： Exchange
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/10/6 11:10:53   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:Exchange
    /// </summary>
    public partial class Exchange
    {
        public Exchange()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "Exchange");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Exchange");
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
        public int Add(XHD.Model.Exchange model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Exchange(");
            strSql.Append("Factory_Id,proNam,proId,empId,createDate,empname,isChange)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@proNam,@proId,@empId,@createDate,@empname,@isChange)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@proNam", MySqlDbType.VarChar,10),
					new MySqlParameter("@proId", MySqlDbType.Int32,11),
					new MySqlParameter("@empId", MySqlDbType.Int32,11),
					new MySqlParameter("@createDate", MySqlDbType.VarChar,50),
					new MySqlParameter("@empname", MySqlDbType.VarChar,50),
					new MySqlParameter("@isChange", MySqlDbType.Int16,4)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.proNam;
            parameters[2].Value = model.proId;
            parameters[3].Value = model.empId;
            parameters[4].Value = model.createDate;
            parameters[5].Value = model.empname;
            parameters[6].Value = model.isChange;

            object obj = DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(XHD.Model.Exchange model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Exchange set ");
            strSql.Append("proNam=@proNam,");
            strSql.Append("proId=@proId,");
            strSql.Append("empId=@empId,");
            strSql.Append("createDate=@createDate,");
            strSql.Append("empname=@empname,");
            strSql.Append("isChange=@isChange");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@proNam", MySqlDbType.VarChar,10),
					new MySqlParameter("@proId", MySqlDbType.Int32,11),
					new MySqlParameter("@empId", MySqlDbType.Int32,11),
					new MySqlParameter("@createDate", MySqlDbType.VarChar,50),
					new MySqlParameter("@empname", MySqlDbType.VarChar,50),
					new MySqlParameter("@isChange", MySqlDbType.Int16,4),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.proNam;
            parameters[1].Value = model.proId;
            parameters[2].Value = model.empId;
            parameters[3].Value = model.createDate;
            parameters[4].Value = model.empname;
            parameters[5].Value = model.isChange;
            parameters[6].Value = model.Id;

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
            strSql.Append("delete from Exchange ");
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
            strSql.Append("delete from Exchange ");
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
        public XHD.Model.Exchange GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  Id,proNam,proId,empId,createDate,empname,isChange from Exchange ");
            strSql.Append(" where Id=@Id limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.Exchange model = new XHD.Model.Exchange();
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
        public XHD.Model.Exchange DataRowToModel(DataRow row)
        {
            XHD.Model.Exchange model = new XHD.Model.Exchange();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["proNam"] != null)
                {
                    model.proNam = row["proNam"].ToString();
                }
                if (row["proId"] != null && row["proId"].ToString() != "")
                {
                    model.proId = int.Parse(row["proId"].ToString());
                }
                if (row["empId"] != null && row["empId"].ToString() != "")
                {
                    model.empId = int.Parse(row["empId"].ToString());
                }
                if (row["createDate"] != null)
                {
                    model.createDate = row["createDate"].ToString();
                }
                if (row["empname"] != null)
                {
                    model.empname = row["empname"].ToString();
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
            strSql.Append("select Id,proNam,proId,empId,createDate,empname,isChange ");
            strSql.Append(" FROM Exchange ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            
            strSql.Append(" Id,proNam,proId,empId,createDate,empname,isChange ");
            strSql.Append(" FROM Exchange ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Exchange ");
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
            strSql.Append(")AS Row, T.*  from Exchange T ");
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
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Exchange";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
