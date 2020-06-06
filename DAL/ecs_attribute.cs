﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_attribute
    /// </summary>
    public partial class ecs_attribute
    {
        public ecs_attribute()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int attr_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_attribute");
            strSql.Append(" where attr_id=@attr_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@attr_id", MySqlDbType.Int16)
			};
            parameters[0].Value = attr_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_attribute model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_attribute(");
            strSql.Append("cat_id,attr_name,attr_input_type,attr_type,attr_values,attr_index,sort_order,is_linked,attr_group,is_show,is_show_send)");
            strSql.Append(" values (");
            strSql.Append("@cat_id,@attr_name,@attr_input_type,@attr_type,@attr_values,@attr_index,@sort_order,@is_linked,@attr_group,@is_show,@is_show_send)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cat_id", MySqlDbType.Int16,5),
					new MySqlParameter("@attr_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@attr_input_type", MySqlDbType.Int16,1),
					new MySqlParameter("@attr_type", MySqlDbType.Int16,1),
					new MySqlParameter("@attr_values", MySqlDbType.Text),
					new MySqlParameter("@attr_index", MySqlDbType.Int16,1),
					new MySqlParameter("@sort_order", MySqlDbType.Int16,3),
					new MySqlParameter("@is_linked", MySqlDbType.Int16,1),
					new MySqlParameter("@attr_group", MySqlDbType.Int16,1),
					new MySqlParameter("@is_show", MySqlDbType.Int16,1),
					new MySqlParameter("@is_show_send", MySqlDbType.Int16,1)};
            parameters[0].Value = model.cat_id;
            parameters[1].Value = model.attr_name;
            parameters[2].Value = model.attr_input_type;
            parameters[3].Value = model.attr_type;
            parameters[4].Value = model.attr_values;
            parameters[5].Value = model.attr_index;
            parameters[6].Value = model.sort_order;
            parameters[7].Value = model.is_linked;
            parameters[8].Value = model.attr_group;
            parameters[9].Value = model.is_show;
            parameters[10].Value = model.is_show_send;

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
        public bool Update(XHD.Model.ecs_attribute model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_attribute set ");
            strSql.Append("cat_id=@cat_id,");
            strSql.Append("attr_name=@attr_name,");
            strSql.Append("attr_input_type=@attr_input_type,");
            strSql.Append("attr_type=@attr_type,");
            strSql.Append("attr_values=@attr_values,");
            strSql.Append("attr_index=@attr_index,");
            strSql.Append("sort_order=@sort_order,");
            strSql.Append("is_linked=@is_linked,");
            strSql.Append("attr_group=@attr_group,");
            strSql.Append("is_show=@is_show,");
            strSql.Append("is_show_send=@is_show_send");
            strSql.Append(" where attr_id=@attr_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cat_id", MySqlDbType.Int16,5),
					new MySqlParameter("@attr_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@attr_input_type", MySqlDbType.Int16,1),
					new MySqlParameter("@attr_type", MySqlDbType.Int16,1),
					new MySqlParameter("@attr_values", MySqlDbType.Text),
					new MySqlParameter("@attr_index", MySqlDbType.Int16,1),
					new MySqlParameter("@sort_order", MySqlDbType.Int16,3),
					new MySqlParameter("@is_linked", MySqlDbType.Int16,1),
					new MySqlParameter("@attr_group", MySqlDbType.Int16,1),
					new MySqlParameter("@is_show", MySqlDbType.Int16,1),
					new MySqlParameter("@is_show_send", MySqlDbType.Int16,1),
					new MySqlParameter("@attr_id", MySqlDbType.Int16,5)};
            parameters[0].Value = model.cat_id;
            parameters[1].Value = model.attr_name;
            parameters[2].Value = model.attr_input_type;
            parameters[3].Value = model.attr_type;
            parameters[4].Value = model.attr_values;
            parameters[5].Value = model.attr_index;
            parameters[6].Value = model.sort_order;
            parameters[7].Value = model.is_linked;
            parameters[8].Value = model.attr_group;
            parameters[9].Value = model.is_show;
            parameters[10].Value = model.is_show_send;
            parameters[11].Value = model.attr_id;

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
        public bool Delete(int attr_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_attribute ");
            strSql.Append(" where attr_id=@attr_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@attr_id", MySqlDbType.Int16)
			};
            parameters[0].Value = attr_id;

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
        public bool DeleteList(string attr_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_attribute ");
            strSql.Append(" where attr_id in (" + attr_idlist + ")  ");
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
        public XHD.Model.ecs_attribute GetModel(int attr_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select attr_id,cat_id,attr_name,attr_input_type,attr_type,attr_values,attr_index,sort_order,is_linked,attr_group,is_show,is_show_send from ecs_attribute ");
            strSql.Append(" where attr_id=@attr_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@attr_id", MySqlDbType.Int16)
			};
            parameters[0].Value = attr_id;

            XHD.Model.ecs_attribute model = new XHD.Model.ecs_attribute();
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
        public XHD.Model.ecs_attribute DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_attribute model = new XHD.Model.ecs_attribute();
            if (row != null)
            {
                if (row["attr_id"] != null && row["attr_id"].ToString() != "")
                {
                    model.attr_id = int.Parse(row["attr_id"].ToString());
                }
                if (row["cat_id"] != null && row["cat_id"].ToString() != "")
                {
                    model.cat_id = int.Parse(row["cat_id"].ToString());
                }
                if (row["attr_name"] != null)
                {
                    model.attr_name = row["attr_name"].ToString();
                }
                if (row["attr_input_type"] != null && row["attr_input_type"].ToString() != "")
                {
                    model.attr_input_type = int.Parse(row["attr_input_type"].ToString());
                }
                if (row["attr_type"] != null && row["attr_type"].ToString() != "")
                {
                    model.attr_type = int.Parse(row["attr_type"].ToString());
                }
                if (row["attr_values"] != null)
                {
                    model.attr_values = row["attr_values"].ToString();
                }
                if (row["attr_index"] != null && row["attr_index"].ToString() != "")
                {
                    model.attr_index = int.Parse(row["attr_index"].ToString());
                }
                if (row["sort_order"] != null && row["sort_order"].ToString() != "")
                {
                    model.sort_order = int.Parse(row["sort_order"].ToString());
                }
                if (row["is_linked"] != null && row["is_linked"].ToString() != "")
                {
                    model.is_linked = int.Parse(row["is_linked"].ToString());
                }
                if (row["attr_group"] != null && row["attr_group"].ToString() != "")
                {
                    model.attr_group = int.Parse(row["attr_group"].ToString());
                }
                if (row["is_show"] != null && row["is_show"].ToString() != "")
                {
                    model.is_show = int.Parse(row["is_show"].ToString());
                }
                if (row["is_show_send"] != null && row["is_show_send"].ToString() != "")
                {
                    model.is_show_send = int.Parse(row["is_show_send"].ToString());
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
            strSql.Append("select attr_id,cat_id,attr_name,attr_input_type,attr_type,attr_values,attr_index,sort_order,is_linked,attr_group,is_show,is_show_send ");
            strSql.Append(" FROM ecs_attribute ");
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
            strSql.Append("select count(1) FROM ecs_attribute ");
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
                strSql.Append("order by T.attr_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_attribute T ");
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
            parameters[0].Value = "ecs_attribute";
            parameters[1].Value = "attr_id";
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

