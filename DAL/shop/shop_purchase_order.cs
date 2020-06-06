/**  版本信息模板在安装目录下，可自行修改。
* shop_purchase_order.cs
*
* 功 能： N/A
* 类 名： shop_purchase_order
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/2 14:55:01   N/A    初版
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
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:shop_purchase_order
    /// </summary>
    public partial class shop_purchase_order
    {
        public shop_purchase_order()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int oid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_purchase_order");
            strSql.Append(" where oid=@oid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@oid", MySqlDbType.Int32,8)			};
            parameters[0].Value = oid;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.shop_purchase_order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_purchase_order(");
            strSql.Append("oid,purchase_sn,add_time,admin_id,p_status,last_update_time,arrive_time)");
            strSql.Append(" values (");
            strSql.Append("@oid,@purchase_sn,@add_time,@admin_id,@p_status,@last_update_time,@arrive_time)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@oid", MySqlDbType.Int32,8),
					new MySqlParameter("@purchase_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_id", MySqlDbType.VarChar,12),
					new MySqlParameter("@p_status", MySqlDbType.Int32,2),
					new MySqlParameter("@last_update_time", MySqlDbType.Int32,11),
					new MySqlParameter("@arrive_time", MySqlDbType.Int32,11)};
            parameters[0].Value = model.oid;
            parameters[1].Value = model.purchase_sn;
            parameters[2].Value = model.add_time;
            parameters[3].Value = model.admin_id;
            parameters[4].Value = model.p_status;
            parameters[5].Value = model.last_update_time;
            parameters[6].Value = model.arrive_time;

            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(XHD.Model.shop_purchase_order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_purchase_order set ");
            strSql.Append("purchase_sn=@purchase_sn,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("admin_id=@admin_id,");
            strSql.Append("p_status=@p_status,");
            strSql.Append("last_update_time=@last_update_time,");
            strSql.Append("arrive_time=@arrive_time");
            strSql.Append(" where oid=@oid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@purchase_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_id", MySqlDbType.VarChar,12),
					new MySqlParameter("@p_status", MySqlDbType.Int32,2),
					new MySqlParameter("@last_update_time", MySqlDbType.Int32,11),
					new MySqlParameter("@arrive_time", MySqlDbType.Int32,11),
					new MySqlParameter("@oid", MySqlDbType.Int32,8)};
            parameters[0].Value = model.purchase_sn;
            parameters[1].Value = model.add_time;
            parameters[2].Value = model.admin_id;
            parameters[3].Value = model.p_status;
            parameters[4].Value = model.last_update_time;
            parameters[5].Value = model.arrive_time;
            parameters[6].Value = model.oid;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int oid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_purchase_order ");
            strSql.Append(" where oid=@oid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@oid", MySqlDbType.Int32,8)			};
            parameters[0].Value = oid;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string oidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_purchase_order ");
            strSql.Append(" where oid in (" + oidlist + ")  ");
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public XHD.Model.shop_purchase_order GetModel(int oid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select oid,purchase_sn,add_time,admin_id,p_status,last_update_time,arrive_time from shop_purchase_order ");
            strSql.Append(" where oid=@oid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@oid", MySqlDbType.Int32,8)			};
            parameters[0].Value = oid;

            XHD.Model.shop_purchase_order model = new XHD.Model.shop_purchase_order();
            DataSet ds = Shop_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public XHD.Model.shop_purchase_order DataRowToModel(DataRow row)
        {
            XHD.Model.shop_purchase_order model = new XHD.Model.shop_purchase_order();
            if (row != null)
            {
                //model.oid=row["oid"].ToString();
                if (row["purchase_sn"] != null)
                {
                    model.purchase_sn = row["purchase_sn"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = int.Parse(row["add_time"].ToString());
                }
                if (row["admin_id"] != null)
                {
                    model.admin_id = row["admin_id"].ToString();
                }
                if (row["p_status"] != null && row["p_status"].ToString() != "")
                {
                    model.p_status = int.Parse(row["p_status"].ToString());
                }
                if (row["last_update_time"] != null && row["last_update_time"].ToString() != "")
                {
                    model.last_update_time = int.Parse(row["last_update_time"].ToString());
                }
                if (row["arrive_time"] != null && row["arrive_time"].ToString() != "")
                {
                    model.arrive_time = int.Parse(row["arrive_time"].ToString());
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
            strSql.Append("select oid,purchase_sn,add_time,admin_id,p_status,last_update_time,arrive_time ");
            strSql.Append(" FROM shop_purchase_order ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM shop_purchase_order ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
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
                strSql.Append("order by T.oid desc");
            }
            strSql.Append(")AS Row, T.*  from shop_purchase_order T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return Shop_DbHelperMySQL.Query(strSql.ToString());
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
            parameters[0].Value = "shop_purchase_order";
            parameters[1].Value = "oid";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return Shop_DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

