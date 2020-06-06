using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:bzsldygx
    /// </summary>
    public partial class bzsldygx
    {
        public bzsldygx()
        { }

        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from bzsldygx");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int64)
			};
            parameters[0].Value = ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.bzsldygx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into bzsldygx(");
            strSql.Append("BM,ZTIDH,GX,XSJ1,XSJ2,XSJ3,XSJ4,XSJ5,BZDW,BZSM,HSGX,TXM,txm8)");
            strSql.Append(" values (");
            strSql.Append("@BM,@ZTIDH,@GX,@XSJ1,@XSJ2,@XSJ3,@XSJ4,@XSJ5,@BZDW,@BZSM,@HSGX,@TXM,@txm8)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@BM", MySqlDbType.VarChar,30),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,18),
					new MySqlParameter("@GX", MySqlDbType.Int32,11),
					new MySqlParameter("@XSJ1", MySqlDbType.Decimal,18),
					new MySqlParameter("@XSJ2", MySqlDbType.Decimal,18),
					new MySqlParameter("@XSJ3", MySqlDbType.Decimal,18),
					new MySqlParameter("@XSJ4", MySqlDbType.Decimal,18),
					new MySqlParameter("@XSJ5", MySqlDbType.Decimal,18),
					new MySqlParameter("@BZDW", MySqlDbType.VarChar,10),
					new MySqlParameter("@BZSM", MySqlDbType.VarChar,10),
					new MySqlParameter("@HSGX", MySqlDbType.VarChar,10),
					new MySqlParameter("@TXM", MySqlDbType.VarChar,150),
					new MySqlParameter("@txm8", MySqlDbType.VarChar,255)};
            parameters[0].Value = model.BM;
            parameters[1].Value = model.ZTIDH;
            parameters[2].Value = model.GX;
            parameters[3].Value = model.XSJ1;
            parameters[4].Value = model.XSJ2;
            parameters[5].Value = model.XSJ3;
            parameters[6].Value = model.XSJ4;
            parameters[7].Value = model.XSJ5;
            parameters[8].Value = model.BZDW;
            parameters[9].Value = model.BZSM;
            parameters[10].Value = model.HSGX;
            parameters[11].Value = model.TXM;
            parameters[12].Value = model.txm8;

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
        public bool Update(XHD.Model.bzsldygx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update bzsldygx set ");
            strSql.Append("BM=@BM,");
            strSql.Append("ZTIDH=@ZTIDH,");
            strSql.Append("GX=@GX,");
            strSql.Append("XSJ1=@XSJ1,");
            strSql.Append("XSJ2=@XSJ2,");
            strSql.Append("XSJ3=@XSJ3,");
            strSql.Append("XSJ4=@XSJ4,");
            strSql.Append("XSJ5=@XSJ5,");
            strSql.Append("BZDW=@BZDW,");
            strSql.Append("BZSM=@BZSM,");
            strSql.Append("HSGX=@HSGX,");
            strSql.Append("TXM=@TXM,");
            strSql.Append("txm8=@txm8");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@BM", MySqlDbType.VarChar,30),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,18),
					new MySqlParameter("@GX", MySqlDbType.Int32,11),
					new MySqlParameter("@XSJ1", MySqlDbType.Decimal,18),
					new MySqlParameter("@XSJ2", MySqlDbType.Decimal,18),
					new MySqlParameter("@XSJ3", MySqlDbType.Decimal,18),
					new MySqlParameter("@XSJ4", MySqlDbType.Decimal,18),
					new MySqlParameter("@XSJ5", MySqlDbType.Decimal,18),
					new MySqlParameter("@BZDW", MySqlDbType.VarChar,10),
					new MySqlParameter("@BZSM", MySqlDbType.VarChar,10),
					new MySqlParameter("@HSGX", MySqlDbType.VarChar,10),
					new MySqlParameter("@TXM", MySqlDbType.VarChar,150),
					new MySqlParameter("@txm8", MySqlDbType.VarChar,255),
					new MySqlParameter("@ID", MySqlDbType.Int32,18)};
            parameters[0].Value = model.BM;
            parameters[1].Value = model.ZTIDH;
            parameters[2].Value = model.GX;
            parameters[3].Value = model.XSJ1;
            parameters[4].Value = model.XSJ2;
            parameters[5].Value = model.XSJ3;
            parameters[6].Value = model.XSJ4;
            parameters[7].Value = model.XSJ5;
            parameters[8].Value = model.BZDW;
            parameters[9].Value = model.BZSM;
            parameters[10].Value = model.HSGX;
            parameters[11].Value = model.TXM;
            parameters[12].Value = model.txm8;
            parameters[13].Value = model.ID;

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
        public bool Delete(long ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from bzsldygx ");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int64)
			};
            parameters[0].Value = ID;

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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from bzsldygx ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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
        public XHD.Model.bzsldygx GetModel(long ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select BM,ZTIDH,ID,GX,XSJ1,XSJ2,XSJ3,XSJ4,XSJ5,BZDW,BZSM,HSGX,TXM,txm8 from bzsldygx ");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int64)
			};
            parameters[0].Value = ID;

            XHD.Model.bzsldygx model = new XHD.Model.bzsldygx();
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
        public XHD.Model.bzsldygx DataRowToModel(DataRow row)
        {
            XHD.Model.bzsldygx model = new XHD.Model.bzsldygx();
            if (row != null)
            {
                if (row["BM"] != null)
                {
                    model.BM = row["BM"].ToString();
                }
                if (row["ZTIDH"] != null && row["ZTIDH"].ToString() != "")
                {
                    model.ZTIDH = decimal.Parse(row["ZTIDH"].ToString());
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = long.Parse(row["ID"].ToString());
                }
                if (row["GX"] != null && row["GX"].ToString() != "")
                {
                    model.GX = int.Parse(row["GX"].ToString());
                }
                if (row["XSJ1"] != null && row["XSJ1"].ToString() != "")
                {
                    model.XSJ1 = decimal.Parse(row["XSJ1"].ToString());
                }
                if (row["XSJ2"] != null && row["XSJ2"].ToString() != "")
                {
                    model.XSJ2 = decimal.Parse(row["XSJ2"].ToString());
                }
                if (row["XSJ3"] != null && row["XSJ3"].ToString() != "")
                {
                    model.XSJ3 = decimal.Parse(row["XSJ3"].ToString());
                }
                if (row["XSJ4"] != null && row["XSJ4"].ToString() != "")
                {
                    model.XSJ4 = decimal.Parse(row["XSJ4"].ToString());
                }
                if (row["XSJ5"] != null && row["XSJ5"].ToString() != "")
                {
                    model.XSJ5 = decimal.Parse(row["XSJ5"].ToString());
                }
                if (row["BZDW"] != null)
                {
                    model.BZDW = row["BZDW"].ToString();
                }
                if (row["BZSM"] != null)
                {
                    model.BZSM = row["BZSM"].ToString();
                }
                if (row["HSGX"] != null)
                {
                    model.HSGX = row["HSGX"].ToString();
                }
                if (row["TXM"] != null)
                {
                    model.TXM = row["TXM"].ToString();
                }
                if (row["txm8"] != null)
                {
                    model.txm8 = row["txm8"].ToString();
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
            strSql.Append("select BM,ZTIDH,ID,GX,XSJ1,XSJ2,XSJ3,XSJ4,XSJ5,BZDW,BZSM,HSGX,TXM,txm8 ");
            strSql.Append(" FROM bzsldygx ");
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
            strSql.Append("select count(1) FROM bzsldygx ");
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
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from bzsldygx T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

