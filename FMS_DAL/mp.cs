﻿using MySql.Data.MySqlClient;
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
    /// 数据访问类:mp
    /// </summary>
    public partial class mp
    {
        public mp()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("ID", "mp");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from mp");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,11)			};
            parameters[0].Value = ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.mp model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into mp(");
            strSql.Append("BM,DWMC,DH,ZTIDH,FAX,DZ,LXR,YB,QCJE,SRJE,FCJE,JCJE,YE,FCSL,ML,QCYE,HM,JB,XXDWMC,XXDZ,KHH,ZH,SH,SX,SPBH,LB,JYFW,SSBM,DS,RQ,RQ1,ID,KHZT,KHBM,WXHM,QQ,DZYJ,province_id,province_name,city_id,city_name,period_start,period_start_date,Is_stop)");
            strSql.Append(" values (");
            strSql.Append("@BM,@DWMC,@DH,@ZTIDH,@FAX,@DZ,@LXR,@YB,@QCJE,@SRJE,@FCJE,@JCJE,@YE,@FCSL,@ML,@QCYE,@HM,@JB,@XXDWMC,@XXDZ,@KHH,@ZH,@SH,@SX,@SPBH,@LB,@JYFW,@SSBM,@DS,@RQ,@RQ1,@ID,@KHZT,@KHBM,@WXHM,@QQ,@DZYJ,@province_id,@province_name,@city_id,@city_name,@period_start,@period_start_date,@Is_stop)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@BM", MySqlDbType.VarChar,50),
					new MySqlParameter("@DWMC", MySqlDbType.VarChar,60),
					new MySqlParameter("@DH", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,3),
					new MySqlParameter("@FAX", MySqlDbType.VarChar,50),
					new MySqlParameter("@DZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@LXR", MySqlDbType.VarChar,50),
					new MySqlParameter("@YB", MySqlDbType.VarChar,50),
					new MySqlParameter("@QCJE", MySqlDbType.Decimal,15),
					new MySqlParameter("@SRJE", MySqlDbType.Decimal,15),
					new MySqlParameter("@FCJE", MySqlDbType.Decimal,15),
					new MySqlParameter("@JCJE", MySqlDbType.Decimal,15),
					new MySqlParameter("@YE", MySqlDbType.Decimal,15),
					new MySqlParameter("@FCSL", MySqlDbType.Decimal,15),
					new MySqlParameter("@ML", MySqlDbType.Decimal,15),
					new MySqlParameter("@QCYE", MySqlDbType.Decimal,15),
					new MySqlParameter("@HM", MySqlDbType.Decimal,18),
					new MySqlParameter("@JB", MySqlDbType.VarChar,50),
					new MySqlParameter("@XXDWMC", MySqlDbType.VarChar,60),
					new MySqlParameter("@XXDZ", MySqlDbType.VarChar,60),
					new MySqlParameter("@KHH", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZH", MySqlDbType.VarChar,50),
					new MySqlParameter("@SH", MySqlDbType.VarChar,50),
					new MySqlParameter("@SX", MySqlDbType.Decimal,15),
					new MySqlParameter("@SPBH", MySqlDbType.VarChar,50),
					new MySqlParameter("@LB", MySqlDbType.VarChar,50),
					new MySqlParameter("@JYFW", MySqlDbType.VarChar,255),
					new MySqlParameter("@SSBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@DS", MySqlDbType.Decimal,15),
					new MySqlParameter("@RQ", MySqlDbType.DateTime),
					new MySqlParameter("@RQ1", MySqlDbType.DateTime),
					new MySqlParameter("@ID", MySqlDbType.Int32,11),
					new MySqlParameter("@KHZT", MySqlDbType.VarChar,50),
					new MySqlParameter("@KHBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@WXHM", MySqlDbType.VarChar,50),
					new MySqlParameter("@QQ", MySqlDbType.VarChar,50),
					new MySqlParameter("@DZYJ", MySqlDbType.VarChar,50),
					new MySqlParameter("@province_id", MySqlDbType.Int32,11),
					new MySqlParameter("@province_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@city_id", MySqlDbType.Int32,11),
					new MySqlParameter("@city_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@period_start", MySqlDbType.Decimal,18),
					new MySqlParameter("@period_start_date", MySqlDbType.DateTime),
					new MySqlParameter("@Is_stop", MySqlDbType.Int16,2)};
            parameters[0].Value = model.BM;
            parameters[1].Value = model.DWMC;
            parameters[2].Value = model.DH;
            parameters[3].Value = model.ZTIDH;
            parameters[4].Value = model.FAX;
            parameters[5].Value = model.DZ;
            parameters[6].Value = model.LXR;
            parameters[7].Value = model.YB;
            parameters[8].Value = model.QCJE;
            parameters[9].Value = model.SRJE;
            parameters[10].Value = model.FCJE;
            parameters[11].Value = model.JCJE;
            parameters[12].Value = model.YE;
            parameters[13].Value = model.FCSL;
            parameters[14].Value = model.ML;
            parameters[15].Value = model.QCYE;
            parameters[16].Value = model.HM;
            parameters[17].Value = model.JB;
            parameters[18].Value = model.XXDWMC;
            parameters[19].Value = model.XXDZ;
            parameters[20].Value = model.KHH;
            parameters[21].Value = model.ZH;
            parameters[22].Value = model.SH;
            parameters[23].Value = model.SX;
            parameters[24].Value = model.SPBH;
            parameters[25].Value = model.LB;
            parameters[26].Value = model.JYFW;
            parameters[27].Value = model.SSBM;
            parameters[28].Value = model.DS;
            parameters[29].Value = model.RQ;
            parameters[30].Value = model.RQ1;
            parameters[31].Value = model.ID;
            parameters[32].Value = model.KHZT;
            parameters[33].Value = model.KHBM;
            parameters[34].Value = model.WXHM;
            parameters[35].Value = model.QQ;
            parameters[36].Value = model.DZYJ;
            parameters[37].Value = model.province_id;
            parameters[38].Value = model.province_name;
            parameters[39].Value = model.city_id;
            parameters[40].Value = model.city_name;
            parameters[41].Value = model.period_start;
            parameters[42].Value = model.period_start_date;
            parameters[43].Value = model.Is_stop;

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
        public bool Update(FMS_Model.mp model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update mp set ");
            strSql.Append("BM=@BM,");
            strSql.Append("DWMC=@DWMC,");
            strSql.Append("DH=@DH,");
            strSql.Append("ZTIDH=@ZTIDH,");
            strSql.Append("FAX=@FAX,");
            strSql.Append("DZ=@DZ,");
            strSql.Append("LXR=@LXR,");
            strSql.Append("YB=@YB,");
            strSql.Append("QCJE=@QCJE,");
            strSql.Append("SRJE=@SRJE,");
            strSql.Append("FCJE=@FCJE,");
            strSql.Append("JCJE=@JCJE,");
            strSql.Append("YE=@YE,");
            strSql.Append("FCSL=@FCSL,");
            strSql.Append("ML=@ML,");
            strSql.Append("QCYE=@QCYE,");
            strSql.Append("HM=@HM,");
            strSql.Append("JB=@JB,");
            strSql.Append("XXDWMC=@XXDWMC,");
            strSql.Append("XXDZ=@XXDZ,");
            strSql.Append("KHH=@KHH,");
            strSql.Append("ZH=@ZH,");
            strSql.Append("SH=@SH,");
            strSql.Append("SX=@SX,");
            strSql.Append("SPBH=@SPBH,");
            strSql.Append("LB=@LB,");
            strSql.Append("JYFW=@JYFW,");
            strSql.Append("SSBM=@SSBM,");
            strSql.Append("DS=@DS,");
            strSql.Append("RQ=@RQ,");
            strSql.Append("RQ1=@RQ1,");
            strSql.Append("KHZT=@KHZT,");
            strSql.Append("KHBM=@KHBM,");
            strSql.Append("WXHM=@WXHM,");
            strSql.Append("QQ=@QQ,");
            strSql.Append("DZYJ=@DZYJ,");
            strSql.Append("province_id=@province_id,");
            strSql.Append("province_name=@province_name,");
            strSql.Append("city_id=@city_id,");
            strSql.Append("city_name=@city_name,");
            strSql.Append("period_start=@period_start,");
            strSql.Append("period_start_date=@period_start_date,");
            strSql.Append("Is_stop=@Is_stop");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@BM", MySqlDbType.VarChar,50),
					new MySqlParameter("@DWMC", MySqlDbType.VarChar,60),
					new MySqlParameter("@DH", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,3),
					new MySqlParameter("@FAX", MySqlDbType.VarChar,50),
					new MySqlParameter("@DZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@LXR", MySqlDbType.VarChar,50),
					new MySqlParameter("@YB", MySqlDbType.VarChar,50),
					new MySqlParameter("@QCJE", MySqlDbType.Decimal,15),
					new MySqlParameter("@SRJE", MySqlDbType.Decimal,15),
					new MySqlParameter("@FCJE", MySqlDbType.Decimal,15),
					new MySqlParameter("@JCJE", MySqlDbType.Decimal,15),
					new MySqlParameter("@YE", MySqlDbType.Decimal,15),
					new MySqlParameter("@FCSL", MySqlDbType.Decimal,15),
					new MySqlParameter("@ML", MySqlDbType.Decimal,15),
					new MySqlParameter("@QCYE", MySqlDbType.Decimal,15),
					new MySqlParameter("@HM", MySqlDbType.Decimal,18),
					new MySqlParameter("@JB", MySqlDbType.VarChar,50),
					new MySqlParameter("@XXDWMC", MySqlDbType.VarChar,60),
					new MySqlParameter("@XXDZ", MySqlDbType.VarChar,60),
					new MySqlParameter("@KHH", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZH", MySqlDbType.VarChar,50),
					new MySqlParameter("@SH", MySqlDbType.VarChar,50),
					new MySqlParameter("@SX", MySqlDbType.Decimal,15),
					new MySqlParameter("@SPBH", MySqlDbType.VarChar,50),
					new MySqlParameter("@LB", MySqlDbType.VarChar,50),
					new MySqlParameter("@JYFW", MySqlDbType.VarChar,255),
					new MySqlParameter("@SSBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@DS", MySqlDbType.Decimal,15),
					new MySqlParameter("@RQ", MySqlDbType.DateTime),
					new MySqlParameter("@RQ1", MySqlDbType.DateTime),
					new MySqlParameter("@KHZT", MySqlDbType.VarChar,50),
					new MySqlParameter("@KHBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@WXHM", MySqlDbType.VarChar,50),
					new MySqlParameter("@QQ", MySqlDbType.VarChar,50),
					new MySqlParameter("@DZYJ", MySqlDbType.VarChar,50),
					new MySqlParameter("@province_id", MySqlDbType.Int32,11),
					new MySqlParameter("@province_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@city_id", MySqlDbType.Int32,11),
					new MySqlParameter("@city_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@period_start", MySqlDbType.Decimal,18),
					new MySqlParameter("@period_start_date", MySqlDbType.DateTime),
					new MySqlParameter("@Is_stop", MySqlDbType.Int16,2),
					new MySqlParameter("@ID", MySqlDbType.Int32,11)};
            parameters[0].Value = model.BM;
            parameters[1].Value = model.DWMC;
            parameters[2].Value = model.DH;
            parameters[3].Value = model.ZTIDH;
            parameters[4].Value = model.FAX;
            parameters[5].Value = model.DZ;
            parameters[6].Value = model.LXR;
            parameters[7].Value = model.YB;
            parameters[8].Value = model.QCJE;
            parameters[9].Value = model.SRJE;
            parameters[10].Value = model.FCJE;
            parameters[11].Value = model.JCJE;
            parameters[12].Value = model.YE;
            parameters[13].Value = model.FCSL;
            parameters[14].Value = model.ML;
            parameters[15].Value = model.QCYE;
            parameters[16].Value = model.HM;
            parameters[17].Value = model.JB;
            parameters[18].Value = model.XXDWMC;
            parameters[19].Value = model.XXDZ;
            parameters[20].Value = model.KHH;
            parameters[21].Value = model.ZH;
            parameters[22].Value = model.SH;
            parameters[23].Value = model.SX;
            parameters[24].Value = model.SPBH;
            parameters[25].Value = model.LB;
            parameters[26].Value = model.JYFW;
            parameters[27].Value = model.SSBM;
            parameters[28].Value = model.DS;
            parameters[29].Value = model.RQ;
            parameters[30].Value = model.RQ1;
            parameters[31].Value = model.KHZT;
            parameters[32].Value = model.KHBM;
            parameters[33].Value = model.WXHM;
            parameters[34].Value = model.QQ;
            parameters[35].Value = model.DZYJ;
            parameters[36].Value = model.province_id;
            parameters[37].Value = model.province_name;
            parameters[38].Value = model.city_id;
            parameters[39].Value = model.city_name;
            parameters[40].Value = model.period_start;
            parameters[41].Value = model.period_start_date;
            parameters[42].Value = model.Is_stop;
            parameters[43].Value = model.ID;

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
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from mp ");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,11)			};
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
            strSql.Append("delete from mp ");
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
        public FMS_Model.mp GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select BM,DWMC,DH,ZTIDH,FAX,DZ,LXR,YB,QCJE,SRJE,FCJE,JCJE,YE,FCSL,ML,QCYE,HM,JB,XXDWMC,XXDZ,KHH,ZH,SH,SX,SPBH,LB,JYFW,SSBM,DS,RQ,RQ1,ID,KHZT,KHBM,WXHM,QQ,DZYJ,province_id,province_name,city_id,city_name,period_start,period_start_date,Is_stop from mp ");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,11)			};
            parameters[0].Value = ID;

            FMS_Model.mp model = new FMS_Model.mp();
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
        public FMS_Model.mp DataRowToModel(DataRow row)
        {
            FMS_Model.mp model = new FMS_Model.mp();
            if (row != null)
            {
                if (row["BM"] != null)
                {
                    model.BM = row["BM"].ToString();
                }
                if (row["DWMC"] != null)
                {
                    model.DWMC = row["DWMC"].ToString();
                }
                if (row["DH"] != null)
                {
                    model.DH = row["DH"].ToString();
                }
                if (row["ZTIDH"] != null && row["ZTIDH"].ToString() != "")
                {
                    model.ZTIDH = decimal.Parse(row["ZTIDH"].ToString());
                }
                if (row["FAX"] != null)
                {
                    model.FAX = row["FAX"].ToString();
                }
                if (row["DZ"] != null)
                {
                    model.DZ = row["DZ"].ToString();
                }
                if (row["LXR"] != null)
                {
                    model.LXR = row["LXR"].ToString();
                }
                if (row["YB"] != null)
                {
                    model.YB = row["YB"].ToString();
                }
                if (row["QCJE"] != null && row["QCJE"].ToString() != "")
                {
                    model.QCJE = decimal.Parse(row["QCJE"].ToString());
                }
                if (row["SRJE"] != null && row["SRJE"].ToString() != "")
                {
                    model.SRJE = decimal.Parse(row["SRJE"].ToString());
                }
                if (row["FCJE"] != null && row["FCJE"].ToString() != "")
                {
                    model.FCJE = decimal.Parse(row["FCJE"].ToString());
                }
                if (row["JCJE"] != null && row["JCJE"].ToString() != "")
                {
                    model.JCJE = decimal.Parse(row["JCJE"].ToString());
                }
                if (row["YE"] != null && row["YE"].ToString() != "")
                {
                    model.YE = decimal.Parse(row["YE"].ToString());
                }
                if (row["FCSL"] != null && row["FCSL"].ToString() != "")
                {
                    model.FCSL = decimal.Parse(row["FCSL"].ToString());
                }
                if (row["ML"] != null && row["ML"].ToString() != "")
                {
                    model.ML = decimal.Parse(row["ML"].ToString());
                }
                if (row["QCYE"] != null && row["QCYE"].ToString() != "")
                {
                    model.QCYE = decimal.Parse(row["QCYE"].ToString());
                }
                if (row["HM"] != null && row["HM"].ToString() != "")
                {
                    model.HM = decimal.Parse(row["HM"].ToString());
                }
                if (row["JB"] != null)
                {
                    model.JB = row["JB"].ToString();
                }
                if (row["XXDWMC"] != null)
                {
                    model.XXDWMC = row["XXDWMC"].ToString();
                }
                if (row["XXDZ"] != null)
                {
                    model.XXDZ = row["XXDZ"].ToString();
                }
                if (row["KHH"] != null)
                {
                    model.KHH = row["KHH"].ToString();
                }
                if (row["ZH"] != null)
                {
                    model.ZH = row["ZH"].ToString();
                }
                if (row["SH"] != null)
                {
                    model.SH = row["SH"].ToString();
                }
                if (row["SX"] != null && row["SX"].ToString() != "")
                {
                    model.SX = decimal.Parse(row["SX"].ToString());
                }
                if (row["SPBH"] != null)
                {
                    model.SPBH = row["SPBH"].ToString();
                }
                if (row["LB"] != null)
                {
                    model.LB = row["LB"].ToString();
                }
                if (row["JYFW"] != null)
                {
                    model.JYFW = row["JYFW"].ToString();
                }
                if (row["SSBM"] != null)
                {
                    model.SSBM = row["SSBM"].ToString();
                }
                if (row["DS"] != null && row["DS"].ToString() != "")
                {
                    model.DS = decimal.Parse(row["DS"].ToString());
                }
                if (row["RQ"] != null && row["RQ"].ToString() != "")
                {
                    model.RQ = DateTime.Parse(row["RQ"].ToString());
                }
                if (row["RQ1"] != null && row["RQ1"].ToString() != "")
                {
                    model.RQ1 = DateTime.Parse(row["RQ1"].ToString());
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["KHZT"] != null)
                {
                    model.KHZT = row["KHZT"].ToString();
                }
                if (row["KHBM"] != null)
                {
                    model.KHBM = row["KHBM"].ToString();
                }
                if (row["WXHM"] != null)
                {
                    model.WXHM = row["WXHM"].ToString();
                }
                if (row["QQ"] != null)
                {
                    model.QQ = row["QQ"].ToString();
                }
                if (row["DZYJ"] != null)
                {
                    model.DZYJ = row["DZYJ"].ToString();
                }
                if (row["province_id"] != null && row["province_id"].ToString() != "")
                {
                    model.province_id = int.Parse(row["province_id"].ToString());
                }
                if (row["province_name"] != null)
                {
                    model.province_name = row["province_name"].ToString();
                }
                if (row["city_id"] != null && row["city_id"].ToString() != "")
                {
                    model.city_id = int.Parse(row["city_id"].ToString());
                }
                if (row["city_name"] != null)
                {
                    model.city_name = row["city_name"].ToString();
                }
                if (row["period_start"] != null && row["period_start"].ToString() != "")
                {
                    model.period_start = decimal.Parse(row["period_start"].ToString());
                }
                if (row["period_start_date"] != null && row["period_start_date"].ToString() != "")
                {
                    model.period_start_date = DateTime.Parse(row["period_start_date"].ToString());
                }
                if (row["Is_stop"] != null && row["Is_stop"].ToString() != "")
                {
                    model.Is_stop = int.Parse(row["Is_stop"].ToString());
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
            strSql.Append("select BM,DWMC,DH,ZTIDH,FAX,DZ,LXR,YB,QCJE,SRJE,FCJE,JCJE,YE,FCSL,ML,QCYE,HM,JB,XXDWMC,XXDZ,KHH,ZH,SH,SX,SPBH,LB,JYFW,SSBM,DS,RQ,RQ1,ID,KHZT,KHBM,WXHM,QQ,DZYJ,province_id,province_name,city_id,city_name,period_start,period_start_date,Is_stop ");
            strSql.Append(" FROM mp ");
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
        //    strSql.Append("select count(1) FROM mp ");
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
            strSql.Append(")AS Row, T.*  from mp T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }




            
        /// <summary>
        /// 获取省份分组列表
        /// </summary>
        public DataSet GetListGroupByProvince(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ifnull(province_name,'未分配省份') as province_name,province_id,count(city_id) as city_count,count(id) as mp_count,sum(period_start) as period_start from mp  ");

            strSql1.Append(" select count(*) from (select  province_id from mp  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }

            strSql.Append(" group by province_id ");
            strSql1.Append(" group by province_id ) tt ");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetListGroupByCity(int PageSize, int PageIndex, string strWhere, string filedOrder, string province, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ifnull(city_name,'未分配城市') as city_name,city_id,count(id) as mp_count,sum(period_start) from mp  ");

            string pid_where = "";
            if (province == "Null"||string.IsNullOrEmpty(province))
            {
                pid_where = " province_id is null ";
               
            }
            else
            {
                pid_where = " province_id='" + province + "' ";
            }

            strSql1.Append(" select count(*) from (select  city_id from mp  ");
            if (strWhere.Trim() != "")
            {
                
                strSql.Append(" where " + strWhere + " and "+pid_where);
                strSql1.Append(" where " + strWhere + " and "+pid_where);
            }
            else
            {
                strSql.Append(" where " + pid_where);
                strSql1.Append(" where  " + pid_where);
            }

            strSql.Append(" group by city_id ");
            strSql1.Append(" group by city_id ) tt ");
            strSql.Append(" order by " + filedOrder);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetListByCity(int PageSize, int PageIndex, string strWhere, string filedOrder, string city_id, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select * from mp  ");

            string cid_where = "";
            if (city_id == "Null" || string.IsNullOrEmpty(city_id))
            {
                cid_where = " city_id is null ";

            }
            else
            {
                cid_where = " city_id='" + city_id + "' ";
            }

            strSql1.Append(" select count(*) from (select  * from mp  ");
            if (strWhere.Trim() != "")
            {

                strSql.Append(" where " + strWhere + " and " + cid_where);
                strSql1.Append(" where " + strWhere + " and " + cid_where);
            }
            else
            {
                strSql.Append(" where " + cid_where);
                strSql1.Append(" where  " + cid_where);
            }

            strSql.Append(" ");
            strSql1.Append(" ) tt ");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }




        //获取分页数据
        public DataSet GetPageData(int pageSize, int pageIndex,  string tableName,string city_where, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("Select *  From " + tableName);
            strSql1.Append(" select count(*) From  mp " + city_where);

            strSql.Append(" order by id  limit " + (pageIndex - 1) * pageSize + "," + pageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());

        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
