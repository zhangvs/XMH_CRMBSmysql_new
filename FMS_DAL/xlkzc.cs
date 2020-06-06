using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:xlkzc
    /// </summary>
    public partial class xlkzc
    {
        public xlkzc()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from xlkzc");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int64,20)			};
            parameters[0].Value = ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.xlkzc model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into xlkzc(");
            strSql.Append("RQ,DWMC,JE,DJHM,ZTIDH,BMBM,XM,ZH,BZ,JZ,LSH,ZD,YHJE,NIAN,YF,HSLX,SKSM,YSDH,ID,IsInsert,d_confirm,f_confirm,emp_check,emp_dc,emp_fc,red_rush)");
            strSql.Append(" values (");
            strSql.Append("@RQ,@DWMC,@JE,@DJHM,@ZTIDH,@BMBM,@XM,@ZH,@BZ,@JZ,@LSH,@ZD,@YHJE,@NIAN,@YF,@HSLX,@SKSM,@YSDH,@ID,@IsInsert,@d_confirm,@f_confirm,@emp_check,@emp_dc,@emp_fc,@red_rush)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@RQ", MySqlDbType.DateTime),
					new MySqlParameter("@DWMC", MySqlDbType.VarChar,60),
					new MySqlParameter("@JE", MySqlDbType.Decimal,15),
					new MySqlParameter("@DJHM", MySqlDbType.Int64,20),
					new MySqlParameter("@ZTIDH", MySqlDbType.Int64,20),
					new MySqlParameter("@BMBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@XM", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZH", MySqlDbType.VarChar,50),
					new MySqlParameter("@BZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@JZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@LSH", MySqlDbType.Int64,20),
					new MySqlParameter("@ZD", MySqlDbType.VarChar,50),
					new MySqlParameter("@YHJE", MySqlDbType.Decimal,12),
					new MySqlParameter("@NIAN", MySqlDbType.Int64,20),
					new MySqlParameter("@YF", MySqlDbType.Int64,20),
					new MySqlParameter("@HSLX", MySqlDbType.VarChar,50),
					new MySqlParameter("@SKSM", MySqlDbType.VarChar,60),
					new MySqlParameter("@YSDH", MySqlDbType.VarChar,50),
					new MySqlParameter("@ID", MySqlDbType.Int64,20),
					new MySqlParameter("@IsInsert", MySqlDbType.Int32,11),
					new MySqlParameter("@d_confirm", MySqlDbType.Int16,2),
					new MySqlParameter("@f_confirm", MySqlDbType.Int16,2),
					new MySqlParameter("@emp_check", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_dc", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_fc", MySqlDbType.VarChar,60),
					new MySqlParameter("@red_rush", MySqlDbType.Int16,2)};
            parameters[0].Value = model.RQ;
            parameters[1].Value = model.DWMC;
            parameters[2].Value = model.JE;
            parameters[3].Value = model.DJHM;
            parameters[4].Value = model.ZTIDH;
            parameters[5].Value = model.BMBM;
            parameters[6].Value = model.XM;
            parameters[7].Value = model.ZH;
            parameters[8].Value = model.BZ;
            parameters[9].Value = model.JZ;
            parameters[10].Value = model.LSH;
            parameters[11].Value = model.ZD;
            parameters[12].Value = model.YHJE;
            parameters[13].Value = model.NIAN;
            parameters[14].Value = model.YF;
            parameters[15].Value = model.HSLX;
            parameters[16].Value = model.SKSM;
            parameters[17].Value = model.YSDH;
            parameters[18].Value = model.ID;
            parameters[19].Value = model.IsInsert;
            parameters[20].Value = model.d_confirm;
            parameters[21].Value = model.f_confirm;
            parameters[22].Value = model.emp_check;
            parameters[23].Value = model.emp_dc;
            parameters[24].Value = model.emp_fc;
            parameters[25].Value = model.red_rush;

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
        public bool Update(FMS_Model.xlkzc model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update xlkzc set ");
            strSql.Append("RQ=@RQ,");
            strSql.Append("DWMC=@DWMC,");
            strSql.Append("JE=@JE,");
            strSql.Append("DJHM=@DJHM,");
            strSql.Append("ZTIDH=@ZTIDH,");
            strSql.Append("BMBM=@BMBM,");
            strSql.Append("XM=@XM,");
            strSql.Append("ZH=@ZH,");
            strSql.Append("BZ=@BZ,");
            strSql.Append("JZ=@JZ,");
            strSql.Append("LSH=@LSH,");
            strSql.Append("ZD=@ZD,");
            strSql.Append("YHJE=@YHJE,");
            strSql.Append("NIAN=@NIAN,");
            strSql.Append("YF=@YF,");
            strSql.Append("HSLX=@HSLX,");
            strSql.Append("SKSM=@SKSM,");
            strSql.Append("YSDH=@YSDH,");
            strSql.Append("IsInsert=@IsInsert,");
            strSql.Append("d_confirm=@d_confirm,");
            strSql.Append("f_confirm=@f_confirm,");
            strSql.Append("emp_check=@emp_check,");
            strSql.Append("emp_dc=@emp_dc,");
            strSql.Append("emp_fc=@emp_fc,");
            strSql.Append("red_rush=@red_rush");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@RQ", MySqlDbType.DateTime),
					new MySqlParameter("@DWMC", MySqlDbType.VarChar,60),
					new MySqlParameter("@JE", MySqlDbType.Decimal,15),
					new MySqlParameter("@DJHM", MySqlDbType.Int64,20),
					new MySqlParameter("@ZTIDH", MySqlDbType.Int64,20),
					new MySqlParameter("@BMBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@XM", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZH", MySqlDbType.VarChar,50),
					new MySqlParameter("@BZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@JZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@LSH", MySqlDbType.Int64,20),
					new MySqlParameter("@ZD", MySqlDbType.VarChar,50),
					new MySqlParameter("@YHJE", MySqlDbType.Decimal,12),
					new MySqlParameter("@NIAN", MySqlDbType.Int64,20),
					new MySqlParameter("@YF", MySqlDbType.Int64,20),
					new MySqlParameter("@HSLX", MySqlDbType.VarChar,50),
					new MySqlParameter("@SKSM", MySqlDbType.VarChar,60),
					new MySqlParameter("@YSDH", MySqlDbType.VarChar,50),
					new MySqlParameter("@IsInsert", MySqlDbType.Int32,11),
					new MySqlParameter("@d_confirm", MySqlDbType.Int16,2),
					new MySqlParameter("@f_confirm", MySqlDbType.Int16,2),
					new MySqlParameter("@emp_check", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_dc", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_fc", MySqlDbType.VarChar,60),
					new MySqlParameter("@red_rush", MySqlDbType.Int16,2),
					new MySqlParameter("@ID", MySqlDbType.Int64,20)};
            parameters[0].Value = model.RQ;
            parameters[1].Value = model.DWMC;
            parameters[2].Value = model.JE;
            parameters[3].Value = model.DJHM;
            parameters[4].Value = model.ZTIDH;
            parameters[5].Value = model.BMBM;
            parameters[6].Value = model.XM;
            parameters[7].Value = model.ZH;
            parameters[8].Value = model.BZ;
            parameters[9].Value = model.JZ;
            parameters[10].Value = model.LSH;
            parameters[11].Value = model.ZD;
            parameters[12].Value = model.YHJE;
            parameters[13].Value = model.NIAN;
            parameters[14].Value = model.YF;
            parameters[15].Value = model.HSLX;
            parameters[16].Value = model.SKSM;
            parameters[17].Value = model.YSDH;
            parameters[18].Value = model.IsInsert;
            parameters[19].Value = model.d_confirm;
            parameters[20].Value = model.f_confirm;
            parameters[21].Value = model.emp_check;
            parameters[22].Value = model.emp_dc;
            parameters[23].Value = model.emp_fc;
            parameters[24].Value = model.red_rush;
            parameters[25].Value = model.ID;

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
            strSql.Append("delete from xlkzc ");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int64,20)			};
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
            strSql.Append("delete from xlkzc ");
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
        public FMS_Model.xlkzc GetModel(long ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RQ,DWMC,JE,DJHM,ZTIDH,BMBM,XM,ZH,BZ,JZ,LSH,ZD,YHJE,NIAN,YF,HSLX,SKSM,YSDH,ID,IsInsert,d_confirm,f_confirm,emp_check,emp_dc,emp_fc,red_rush from xlkzc ");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int64,20)			};
            parameters[0].Value = ID;

            FMS_Model.xlkzc model = new FMS_Model.xlkzc();
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
        public FMS_Model.xlkzc DataRowToModel(DataRow row)
        {
            FMS_Model.xlkzc model = new FMS_Model.xlkzc();
            if (row != null)
            {
                if (row["RQ"] != null && row["RQ"].ToString() != "")
                {
                    model.RQ = DateTime.Parse(row["RQ"].ToString());
                }
                if (row["DWMC"] != null)
                {
                    model.DWMC = row["DWMC"].ToString();
                }
                if (row["JE"] != null && row["JE"].ToString() != "")
                {
                    model.JE = decimal.Parse(row["JE"].ToString());
                }
                if (row["DJHM"] != null && row["DJHM"].ToString() != "")
                {
                    model.DJHM = long.Parse(row["DJHM"].ToString());
                }
                if (row["ZTIDH"] != null && row["ZTIDH"].ToString() != "")
                {
                    model.ZTIDH = long.Parse(row["ZTIDH"].ToString());
                }
                if (row["BMBM"] != null)
                {
                    model.BMBM = row["BMBM"].ToString();
                }
                if (row["XM"] != null)
                {
                    model.XM = row["XM"].ToString();
                }
                if (row["ZH"] != null)
                {
                    model.ZH = row["ZH"].ToString();
                }
                if (row["BZ"] != null)
                {
                    model.BZ = row["BZ"].ToString();
                }
                if (row["JZ"] != null)
                {
                    model.JZ = row["JZ"].ToString();
                }
                if (row["LSH"] != null && row["LSH"].ToString() != "")
                {
                    model.LSH = long.Parse(row["LSH"].ToString());
                }
                if (row["ZD"] != null)
                {
                    model.ZD = row["ZD"].ToString();
                }
                if (row["YHJE"] != null && row["YHJE"].ToString() != "")
                {
                    model.YHJE = decimal.Parse(row["YHJE"].ToString());
                }
                if (row["NIAN"] != null && row["NIAN"].ToString() != "")
                {
                    model.NIAN = long.Parse(row["NIAN"].ToString());
                }
                if (row["YF"] != null && row["YF"].ToString() != "")
                {
                    model.YF = long.Parse(row["YF"].ToString());
                }
                if (row["HSLX"] != null)
                {
                    model.HSLX = row["HSLX"].ToString();
                }
                if (row["SKSM"] != null)
                {
                    model.SKSM = row["SKSM"].ToString();
                }
                if (row["YSDH"] != null)
                {
                    model.YSDH = row["YSDH"].ToString();
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = long.Parse(row["ID"].ToString());
                }
                if (row["IsInsert"] != null && row["IsInsert"].ToString() != "")
                {
                    model.IsInsert = int.Parse(row["IsInsert"].ToString());
                }
                if (row["d_confirm"] != null && row["d_confirm"].ToString() != "")
                {
                    model.d_confirm = int.Parse(row["d_confirm"].ToString());
                }
                if (row["f_confirm"] != null && row["f_confirm"].ToString() != "")
                {
                    model.f_confirm = int.Parse(row["f_confirm"].ToString());
                }
                if (row["emp_check"] != null)
                {
                    model.emp_check = row["emp_check"].ToString();
                }
                if (row["emp_dc"] != null)
                {
                    model.emp_dc = row["emp_dc"].ToString();
                }
                if (row["emp_fc"] != null)
                {
                    model.emp_fc = row["emp_fc"].ToString();
                }
                if (row["red_rush"] != null && row["red_rush"].ToString() != "")
                {
                    model.red_rush = int.Parse(row["red_rush"].ToString());
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
            strSql.Append("select RQ,DWMC,JE,DJHM,ZTIDH,BMBM,XM,ZH,BZ,JZ,LSH,ZD,YHJE,NIAN,YF,HSLX,SKSM,YSDH,ID,IsInsert,d_confirm,f_confirm,emp_check,emp_dc,emp_fc,red_rush ");
            strSql.Append(" FROM xlkzc ");
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
        //    strSql.Append("select count(1) FROM xlkzc ");
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
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from xlkzc T ");
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
            parameters[0].Value = "xlkzc";
            parameters[1].Value = "ID";
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

