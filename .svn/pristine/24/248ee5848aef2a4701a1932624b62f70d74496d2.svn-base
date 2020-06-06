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
    /// 数据访问类:fkdw
    /// </summary>
    public partial class fkdw
    {
        public fkdw()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string SKDW_MC, decimal ZTIDH, decimal ID, string XJ, string VIP)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from fkdw");
            strSql.Append(" where SKDW_MC=@SKDW_MC and ZTIDH=@ZTIDH and ID=@ID and XJ=@XJ and VIP=@VIP ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@SKDW_MC", MySqlDbType.VarChar,40),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,18),
					new MySqlParameter("@ID", MySqlDbType.Decimal,18),
					new MySqlParameter("@XJ", MySqlDbType.VarChar,30),
					new MySqlParameter("@VIP", MySqlDbType.VarChar,30)			};
            parameters[0].Value = SKDW_MC;
            parameters[1].Value = ZTIDH;
            parameters[2].Value = ID;
            parameters[3].Value = XJ;
            parameters[4].Value = VIP;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.fkdw model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fkdw(");
            strSql.Append("SKDW_MC,ZTIDH,ID,XJ,VIP)");
            strSql.Append(" values (");
            strSql.Append("@SKDW_MC,@ZTIDH,@ID,@XJ,@VIP)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@SKDW_MC", MySqlDbType.VarChar,40),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,18),
					new MySqlParameter("@ID", MySqlDbType.Decimal,18),
					new MySqlParameter("@XJ", MySqlDbType.VarChar,30),
					new MySqlParameter("@VIP", MySqlDbType.VarChar,30)};
            parameters[0].Value = model.SKDW_MC;
            parameters[1].Value = model.ZTIDH;
            parameters[2].Value = model.ID;
            parameters[3].Value = model.XJ;
            parameters[4].Value = model.VIP;

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
        public bool Update(FMS_Model.fkdw model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fkdw set ");
            strSql.Append("SKDW_MC=@SKDW_MC,");
            strSql.Append("ZTIDH=@ZTIDH,");
            strSql.Append("ID=@ID,");
            strSql.Append("XJ=@XJ,");
            strSql.Append("VIP=@VIP");
            strSql.Append(" where SKDW_MC=@SKDW_MC and ZTIDH=@ZTIDH and ID=@ID and XJ=@XJ and VIP=@VIP ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@SKDW_MC", MySqlDbType.VarChar,40),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,18),
					new MySqlParameter("@ID", MySqlDbType.Decimal,18),
					new MySqlParameter("@XJ", MySqlDbType.VarChar,30),
					new MySqlParameter("@VIP", MySqlDbType.VarChar,30)};
            parameters[0].Value = model.SKDW_MC;
            parameters[1].Value = model.ZTIDH;
            parameters[2].Value = model.ID;
            parameters[3].Value = model.XJ;
            parameters[4].Value = model.VIP;

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
        public bool Delete(string SKDW_MC, decimal ZTIDH, decimal ID, string XJ, string VIP)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from fkdw ");
            strSql.Append(" where SKDW_MC=@SKDW_MC and ZTIDH=@ZTIDH and ID=@ID and XJ=@XJ and VIP=@VIP ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@SKDW_MC", MySqlDbType.VarChar,40),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,18),
					new MySqlParameter("@ID", MySqlDbType.Decimal,18),
					new MySqlParameter("@XJ", MySqlDbType.VarChar,30),
					new MySqlParameter("@VIP", MySqlDbType.VarChar,30)			};
            parameters[0].Value = SKDW_MC;
            parameters[1].Value = ZTIDH;
            parameters[2].Value = ID;
            parameters[3].Value = XJ;
            parameters[4].Value = VIP;

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
        /// 得到一个对象实体
        /// </summary>
        public FMS_Model.fkdw GetModel(string SKDW_MC, decimal ZTIDH, decimal ID, string XJ, string VIP)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SKDW_MC,ZTIDH,ID,XJ,VIP from fkdw ");
            strSql.Append(" where SKDW_MC=@SKDW_MC and ZTIDH=@ZTIDH and ID=@ID and XJ=@XJ and VIP=@VIP ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@SKDW_MC", MySqlDbType.VarChar,40),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,18),
					new MySqlParameter("@ID", MySqlDbType.Decimal,18),
					new MySqlParameter("@XJ", MySqlDbType.VarChar,30),
					new MySqlParameter("@VIP", MySqlDbType.VarChar,30)			};
            parameters[0].Value = SKDW_MC;
            parameters[1].Value = ZTIDH;
            parameters[2].Value = ID;
            parameters[3].Value = XJ;
            parameters[4].Value = VIP;

            FMS_Model.fkdw model = new FMS_Model.fkdw();
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
        public FMS_Model.fkdw DataRowToModel(DataRow row)
        {
            FMS_Model.fkdw model = new FMS_Model.fkdw();
            if (row != null)
            {
                if (row["SKDW_MC"] != null)
                {
                    model.SKDW_MC = row["SKDW_MC"].ToString();
                }
                if (row["ZTIDH"] != null && row["ZTIDH"].ToString() != "")
                {
                    model.ZTIDH = decimal.Parse(row["ZTIDH"].ToString());
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = decimal.Parse(row["ID"].ToString());
                }
                if (row["XJ"] != null)
                {
                    model.XJ = row["XJ"].ToString();
                }
                if (row["VIP"] != null)
                {
                    model.VIP = row["VIP"].ToString();
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
            strSql.Append("select SKDW_MC,ZTIDH,ID,XJ,VIP ");
            strSql.Append(" FROM fkdw ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        ///// <summary>
        ///// 获取记录总数
        ///// </summary>
        //public int GetRecordCount(string strWhere)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select count(1) FROM fkdw ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //    }
        //    object obj = DbHelperSQL.GetSingle(strSql.ToString());
        //    if (obj == null)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return Convert.ToInt32(obj);
        //    }
        //}
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
                strSql.Append("order by T.VIP desc");
            }
            strSql.Append(")AS Row, T.*  from fkdw T ");
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
            parameters[0].Value = "fkdw";
            parameters[1].Value = "VIP";
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
