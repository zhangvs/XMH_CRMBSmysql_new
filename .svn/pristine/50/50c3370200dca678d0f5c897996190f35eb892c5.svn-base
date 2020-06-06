using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_set_shoplockip
    /// </summary>
    public partial class crm_set_shoplockip
    {
        public crm_set_shoplockip()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_set_shoplockip");
            strSql.Append(" where Id=" + Id + " ");
            return DbHelperMySQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_set_shoplockip model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.factory_Id != null)
            {
                strSql1.Append("factory_Id,");
                strSql2.Append("'" + model.factory_Id + "',");
            }
            if (model.shop_lockIp != null)
            {
                strSql1.Append("shop_lockIp,");
                strSql2.Append("'" + model.shop_lockIp + "',");
            }
            if (model.shop_lockIpDes != null)
            {
                strSql1.Append("shop_lockIpDes,");
                strSql2.Append("'" + model.shop_lockIpDes + "',");
            }
            if (model.C_createId != null)
            {
                strSql1.Append("C_createId,");
                strSql2.Append("" + model.C_createId + ",");
            }
            if (model.C_createName != null)
            {
                strSql1.Append("C_createName,");
                strSql2.Append("'" + model.C_createName + "',");
            }
            if (model.C_createDate != null)
            {
                strSql1.Append("C_createDate,");
                strSql2.Append("'" + model.C_createDate + "',");
            }
            strSql.Append("insert into crm_set_shoplockip(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
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
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_set_shoplockip model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_set_shoplockip set ");
            if (model.factory_Id != null)
            {
                strSql.Append("factory_Id='" + model.factory_Id + "',");
            }
            else
            {
                strSql.Append("factory_Id= null ,");
            }
            if (model.shop_lockIp != null)
            {
                strSql.Append("shop_lockIp='" + model.shop_lockIp + "',");
            }
            else
            {
                strSql.Append("shop_lockIp= null ,");
            }
            if (model.shop_lockIpDes != null)
            {
                strSql.Append("shop_lockIpDes='" + model.shop_lockIpDes + "',");
            }
            else
            {
                strSql.Append("shop_lockIpDes= null ,");
            }
            if (model.C_createId != null)
            {
                strSql.Append("C_createId=" + model.C_createId + ",");
            }
            else
            {
                strSql.Append("C_createId= null ,");
            }
            if (model.C_createName != null)
            {
                strSql.Append("C_createName='" + model.C_createName + "',");
            }
            else
            {
                strSql.Append("C_createName= null ,");
            }
            if (model.C_createDate != null)
            {
                strSql.Append("C_createDate='" + model.C_createDate + "',");
            }
            else
            {
                strSql.Append("C_createDate= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Id=" + model.Id + "");
            int rowsAffected = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
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
            strSql.Append("delete from crm_set_shoplockip ");
            strSql.Append(" where Id=" + Id + "");
            int rowsAffected = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }		/// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_set_shoplockip ");
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
        public XHD.Model.crm_set_shoplockip GetModel(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ");
            strSql.Append(" Id,factory_Id,shop_lockIp,shop_lockIpDes,C_createId,C_createName,C_createDate ");
            strSql.Append(" from crm_set_shoplockip ");
            strSql.Append(" where Id=" + Id + "");
            XHD.Model.crm_set_shoplockip model = new XHD.Model.crm_set_shoplockip();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
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
        public XHD.Model.crm_set_shoplockip DataRowToModel(DataRow row)
        {
            XHD.Model.crm_set_shoplockip model = new XHD.Model.crm_set_shoplockip();
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
                if (row["shop_lockIp"] != null)
                {
                    model.shop_lockIp = row["shop_lockIp"].ToString();
                }
                if (row["shop_lockIpDes"] != null)
                {
                    model.shop_lockIpDes = row["shop_lockIpDes"].ToString();
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,shop_lockIp,shop_lockIpDes,C_createId,C_createName,C_createDate ");
            strSql.Append(" FROM crm_set_shoplockip ");
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
            strSql.Append("select count(1) FROM crm_set_shoplockip ");
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
            strSql.Append(")AS Row, T.*  from crm_set_shoplockip T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  Method
        #region  MethodEx

        #endregion  MethodEx
    }
}

