/**  版本信息模板在安装目录下，可自行修改。
* xlkdb.cs
*
* 功 能： N/A
* 类 名： xlkdb
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/1/16 11:53:43   N/A    初版
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
namespace XHD.DAL.wms
{
    /// <summary>
    /// 数据访问类:xlkdb
    /// </summary>
    public partial class xlkdb
    {
        public xlkdb()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from xmh_wms.xlkdb");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int64,20)			};
            parameters[0].Value = ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.wms.xlkdb model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into xmh_wms.xlkdb(");
            strSql.Append("RQ,BMBM,XM,JE,DJHM,ZY,BZ,HW,YHW,ZD,JZ,LSH,YSDH,LOCKBZ,DYCS,JHDH,SH,NIAN,YF,YWSM,ID,DDBH,DDSL,ZZPBM,SHENJI,IsInsert,has_send,send_time,check_user,check_date,emp_name,isdelete,driver_id,driver_name,syn_sgz,cancel_sgz,has_sync,binded_shop_order,scan_status,kingdee_code,syn_cancel_kingdee)");
            strSql.Append(" values (");
            strSql.Append("@RQ,@BMBM,@XM,@JE,@DJHM,@ZY,@BZ,@HW,@YHW,@ZD,@JZ,@LSH,@YSDH,@LOCKBZ,@DYCS,@JHDH,@SH,@NIAN,@YF,@YWSM,@ID,@DDBH,@DDSL,@ZZPBM,@SHENJI,@IsInsert,@has_send,@send_time,@check_user,@check_date,@emp_name,@isdelete,@driver_id,@driver_name,@syn_sgz,@cancel_sgz,@has_sync,@binded_shop_order,@scan_status,@kingdee_code,@syn_cancel_kingdee)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@RQ", MySqlDbType.DateTime),
					new MySqlParameter("@BMBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@XM", MySqlDbType.VarChar,50),
					new MySqlParameter("@JE", MySqlDbType.Decimal,15),
					new MySqlParameter("@DJHM", MySqlDbType.VarChar,18),
					new MySqlParameter("@ZY", MySqlDbType.VarChar,50),
					new MySqlParameter("@BZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@HW", MySqlDbType.VarChar,50),
					new MySqlParameter("@YHW", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZD", MySqlDbType.VarChar,50),
					new MySqlParameter("@JZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@LSH", MySqlDbType.Decimal,18),
					new MySqlParameter("@YSDH", MySqlDbType.VarChar,50),
					new MySqlParameter("@LOCKBZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@DYCS", MySqlDbType.Decimal,12),
					new MySqlParameter("@JHDH", MySqlDbType.Int32,11),
					new MySqlParameter("@SH", MySqlDbType.VarChar,50),
					new MySqlParameter("@NIAN", MySqlDbType.Decimal,12),
					new MySqlParameter("@YF", MySqlDbType.Decimal,12),
					new MySqlParameter("@YWSM", MySqlDbType.VarChar,50),
					new MySqlParameter("@ID", MySqlDbType.Int64,20),
					new MySqlParameter("@DDBH", MySqlDbType.VarChar,50),
					new MySqlParameter("@DDSL", MySqlDbType.Decimal,18),
					new MySqlParameter("@ZZPBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@SHENJI", MySqlDbType.VarChar,50),
					new MySqlParameter("@IsInsert", MySqlDbType.Int32,11),
					new MySqlParameter("@has_send", MySqlDbType.Int32,2),
					new MySqlParameter("@send_time", MySqlDbType.DateTime),
					new MySqlParameter("@check_user", MySqlDbType.VarChar,255),
					new MySqlParameter("@check_date", MySqlDbType.DateTime),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@isdelete", MySqlDbType.Bit),
					new MySqlParameter("@driver_id", MySqlDbType.Int32,11),
					new MySqlParameter("@driver_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@syn_sgz", MySqlDbType.Int32,2),
					new MySqlParameter("@cancel_sgz", MySqlDbType.Int32,2),
					new MySqlParameter("@has_sync", MySqlDbType.Int32,4),
					new MySqlParameter("@binded_shop_order", MySqlDbType.VarChar,18),
					new MySqlParameter("@scan_status", MySqlDbType.Int32,2),
					new MySqlParameter("@kingdee_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@syn_cancel_kingdee", MySqlDbType.Int32,2)};
            parameters[0].Value = model.RQ;
            parameters[1].Value = model.BMBM;
            parameters[2].Value = model.XM;
            parameters[3].Value = model.JE;
            parameters[4].Value = model.DJHM;
            parameters[5].Value = model.ZY;
            parameters[6].Value = model.BZ;
            parameters[7].Value = model.HW;
            parameters[8].Value = model.YHW;
            parameters[9].Value = model.ZD;
            parameters[10].Value = model.JZ;
            parameters[11].Value = model.LSH;
            parameters[12].Value = model.YSDH;
            parameters[13].Value = model.LOCKBZ;
            parameters[14].Value = model.DYCS;
            parameters[15].Value = model.JHDH;
            parameters[16].Value = model.SH;
            parameters[17].Value = model.NIAN;
            parameters[18].Value = model.YF;
            parameters[19].Value = model.YWSM;
            parameters[20].Value = model.ID;
            parameters[21].Value = model.DDBH;
            parameters[22].Value = model.DDSL;
            parameters[23].Value = model.ZZPBM;
            parameters[24].Value = model.SHENJI;
            parameters[25].Value = model.IsInsert;
            parameters[26].Value = model.has_send;
            parameters[27].Value = model.send_time;
            parameters[28].Value = model.check_user;
            parameters[29].Value = model.check_date;
            parameters[30].Value = model.emp_name;
            parameters[31].Value = model.isdelete;
            parameters[32].Value = model.driver_id;
            parameters[33].Value = model.driver_name;
            parameters[34].Value = model.syn_sgz;
            parameters[35].Value = model.cancel_sgz;
            parameters[36].Value = model.has_sync;
            parameters[37].Value = model.binded_shop_order;
            parameters[38].Value = model.scan_status;
            parameters[39].Value = model.kingdee_code;
            parameters[40].Value = model.syn_cancel_kingdee;

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
        public bool Update(XHD.Model.wms.xlkdb model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update xmh_wms.xlkdb set ");
            strSql.Append("RQ=@RQ,");
            strSql.Append("BMBM=@BMBM,");
            strSql.Append("XM=@XM,");
            strSql.Append("JE=@JE,");
            strSql.Append("DJHM=@DJHM,");
            strSql.Append("ZY=@ZY,");
            strSql.Append("BZ=@BZ,");
            strSql.Append("HW=@HW,");
            strSql.Append("YHW=@YHW,");
            strSql.Append("ZD=@ZD,");
            strSql.Append("JZ=@JZ,");
            strSql.Append("LSH=@LSH,");
            strSql.Append("YSDH=@YSDH,");
            strSql.Append("LOCKBZ=@LOCKBZ,");
            strSql.Append("DYCS=@DYCS,");
            strSql.Append("JHDH=@JHDH,");
            strSql.Append("SH=@SH,");
            strSql.Append("NIAN=@NIAN,");
            strSql.Append("YF=@YF,");
            strSql.Append("YWSM=@YWSM,");
            strSql.Append("DDBH=@DDBH,");
            strSql.Append("DDSL=@DDSL,");
            strSql.Append("ZZPBM=@ZZPBM,");
            strSql.Append("SHENJI=@SHENJI,");
            strSql.Append("IsInsert=@IsInsert,");
            strSql.Append("has_send=@has_send,");
            strSql.Append("send_time=@send_time,");
            strSql.Append("check_user=@check_user,");
            strSql.Append("check_date=@check_date,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("isdelete=@isdelete,");
            strSql.Append("driver_id=@driver_id,");
            strSql.Append("driver_name=@driver_name,");
            strSql.Append("syn_sgz=@syn_sgz,");
            strSql.Append("cancel_sgz=@cancel_sgz,");
            strSql.Append("has_sync=@has_sync,");
            strSql.Append("binded_shop_order=@binded_shop_order,");
            strSql.Append("scan_status=@scan_status,");
            strSql.Append("kingdee_code=@kingdee_code,");
            strSql.Append("syn_cancel_kingdee=@syn_cancel_kingdee");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@RQ", MySqlDbType.DateTime),
					new MySqlParameter("@BMBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@XM", MySqlDbType.VarChar,50),
					new MySqlParameter("@JE", MySqlDbType.Decimal,15),
					new MySqlParameter("@DJHM", MySqlDbType.VarChar,18),
					new MySqlParameter("@ZY", MySqlDbType.VarChar,50),
					new MySqlParameter("@BZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@HW", MySqlDbType.VarChar,50),
					new MySqlParameter("@YHW", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZD", MySqlDbType.VarChar,50),
					new MySqlParameter("@JZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@LSH", MySqlDbType.Decimal,18),
					new MySqlParameter("@YSDH", MySqlDbType.VarChar,50),
					new MySqlParameter("@LOCKBZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@DYCS", MySqlDbType.Decimal,12),
					new MySqlParameter("@JHDH", MySqlDbType.Int32,11),
					new MySqlParameter("@SH", MySqlDbType.VarChar,50),
					new MySqlParameter("@NIAN", MySqlDbType.Decimal,12),
					new MySqlParameter("@YF", MySqlDbType.Decimal,12),
					new MySqlParameter("@YWSM", MySqlDbType.VarChar,50),
					new MySqlParameter("@DDBH", MySqlDbType.VarChar,50),
					new MySqlParameter("@DDSL", MySqlDbType.Decimal,18),
					new MySqlParameter("@ZZPBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@SHENJI", MySqlDbType.VarChar,50),
					new MySqlParameter("@IsInsert", MySqlDbType.Int32,11),
					new MySqlParameter("@has_send", MySqlDbType.Int32,2),
					new MySqlParameter("@send_time", MySqlDbType.DateTime),
					new MySqlParameter("@check_user", MySqlDbType.VarChar,255),
					new MySqlParameter("@check_date", MySqlDbType.DateTime),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@isdelete", MySqlDbType.Bit),
					new MySqlParameter("@driver_id", MySqlDbType.Int32,11),
					new MySqlParameter("@driver_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@syn_sgz", MySqlDbType.Int32,2),
					new MySqlParameter("@cancel_sgz", MySqlDbType.Int32,2),
					new MySqlParameter("@has_sync", MySqlDbType.Int32,4),
					new MySqlParameter("@binded_shop_order", MySqlDbType.VarChar,18),
					new MySqlParameter("@scan_status", MySqlDbType.Int32,2),
					new MySqlParameter("@kingdee_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@syn_cancel_kingdee", MySqlDbType.Int32,2),
					new MySqlParameter("@ID", MySqlDbType.Int64,20)};
            parameters[0].Value = model.RQ;
            parameters[1].Value = model.BMBM;
            parameters[2].Value = model.XM;
            parameters[3].Value = model.JE;
            parameters[4].Value = model.DJHM;
            parameters[5].Value = model.ZY;
            parameters[6].Value = model.BZ;
            parameters[7].Value = model.HW;
            parameters[8].Value = model.YHW;
            parameters[9].Value = model.ZD;
            parameters[10].Value = model.JZ;
            parameters[11].Value = model.LSH;
            parameters[12].Value = model.YSDH;
            parameters[13].Value = model.LOCKBZ;
            parameters[14].Value = model.DYCS;
            parameters[15].Value = model.JHDH;
            parameters[16].Value = model.SH;
            parameters[17].Value = model.NIAN;
            parameters[18].Value = model.YF;
            parameters[19].Value = model.YWSM;
            parameters[20].Value = model.DDBH;
            parameters[21].Value = model.DDSL;
            parameters[22].Value = model.ZZPBM;
            parameters[23].Value = model.SHENJI;
            parameters[24].Value = model.IsInsert;
            parameters[25].Value = model.has_send;
            parameters[26].Value = model.send_time;
            parameters[27].Value = model.check_user;
            parameters[28].Value = model.check_date;
            parameters[29].Value = model.emp_name;
            parameters[30].Value = model.isdelete;
            parameters[31].Value = model.driver_id;
            parameters[32].Value = model.driver_name;
            parameters[33].Value = model.syn_sgz;
            parameters[34].Value = model.cancel_sgz;
            parameters[35].Value = model.has_sync;
            parameters[36].Value = model.binded_shop_order;
            parameters[37].Value = model.scan_status;
            parameters[38].Value = model.kingdee_code;
            parameters[39].Value = model.syn_cancel_kingdee;
            parameters[40].Value = model.ID;

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
            strSql.Append("delete from xmh_wms.xlkdb ");
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
            strSql.Append("delete from xmh_wms.xlkdb ");
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
        public XHD.Model.wms.xlkdb GetModel(long ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RQ,BMBM,XM,JE,DJHM,ZY,BZ,HW,YHW,ZD,JZ,LSH,YSDH,LOCKBZ,DYCS,JHDH,SH,NIAN,YF,YWSM,ID,DDBH,DDSL,ZZPBM,SHENJI,IsInsert,has_send,send_time,check_user,check_date,emp_name,isdelete,driver_id,driver_name,syn_sgz,cancel_sgz,has_sync,binded_shop_order,scan_status,kingdee_code,syn_cancel_kingdee from xmh_wms.xlkdb ");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int64,20)			};
            parameters[0].Value = ID;

            XHD.Model.wms.xlkdb model = new XHD.Model.wms.xlkdb();
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
        public XHD.Model.wms.xlkdb DataRowToModel(DataRow row)
        {
            XHD.Model.wms.xlkdb model = new XHD.Model.wms.xlkdb();
            if (row != null)
            {
                if (row["RQ"] != null && row["RQ"].ToString() != "")
                {
                    model.RQ = DateTime.Parse(row["RQ"].ToString());
                }
                if (row["BMBM"] != null)
                {
                    model.BMBM = row["BMBM"].ToString();
                }
                if (row["XM"] != null)
                {
                    model.XM = row["XM"].ToString();
                }
                if (row["JE"] != null && row["JE"].ToString() != "")
                {
                    model.JE = decimal.Parse(row["JE"].ToString());
                }
                if (row["DJHM"] != null)
                {
                    model.DJHM = row["DJHM"].ToString();
                }
                if (row["ZY"] != null)
                {
                    model.ZY = row["ZY"].ToString();
                }
                if (row["BZ"] != null)
                {
                    model.BZ = row["BZ"].ToString();
                }
                if (row["HW"] != null)
                {
                    model.HW = row["HW"].ToString();
                }
                if (row["YHW"] != null)
                {
                    model.YHW = row["YHW"].ToString();
                }
                if (row["ZD"] != null)
                {
                    model.ZD = row["ZD"].ToString();
                }
                if (row["JZ"] != null)
                {
                    model.JZ = row["JZ"].ToString();
                }
                if (row["LSH"] != null && row["LSH"].ToString() != "")
                {
                    model.LSH = decimal.Parse(row["LSH"].ToString());
                }
                if (row["YSDH"] != null)
                {
                    model.YSDH = row["YSDH"].ToString();
                }
                if (row["LOCKBZ"] != null)
                {
                    model.LOCKBZ = row["LOCKBZ"].ToString();
                }
                if (row["DYCS"] != null && row["DYCS"].ToString() != "")
                {
                    model.DYCS = decimal.Parse(row["DYCS"].ToString());
                }
                if (row["JHDH"] != null && row["JHDH"].ToString() != "")
                {
                    model.JHDH = int.Parse(row["JHDH"].ToString());
                }
                if (row["SH"] != null)
                {
                    model.SH = row["SH"].ToString();
                }
                if (row["NIAN"] != null && row["NIAN"].ToString() != "")
                {
                    model.NIAN = decimal.Parse(row["NIAN"].ToString());
                }
                if (row["YF"] != null && row["YF"].ToString() != "")
                {
                    model.YF = decimal.Parse(row["YF"].ToString());
                }
                if (row["YWSM"] != null)
                {
                    model.YWSM = row["YWSM"].ToString();
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = long.Parse(row["ID"].ToString());
                }
                if (row["DDBH"] != null)
                {
                    model.DDBH = row["DDBH"].ToString();
                }
                if (row["DDSL"] != null && row["DDSL"].ToString() != "")
                {
                    model.DDSL = decimal.Parse(row["DDSL"].ToString());
                }
                if (row["ZZPBM"] != null)
                {
                    model.ZZPBM = row["ZZPBM"].ToString();
                }
                if (row["SHENJI"] != null)
                {
                    model.SHENJI = row["SHENJI"].ToString();
                }
                if (row["IsInsert"] != null && row["IsInsert"].ToString() != "")
                {
                    model.IsInsert = int.Parse(row["IsInsert"].ToString());
                }
                if (row["has_send"] != null && row["has_send"].ToString() != "")
                {
                    model.has_send = int.Parse(row["has_send"].ToString());
                }
                if (row["send_time"] != null && row["send_time"].ToString() != "")
                {
                    model.send_time = DateTime.Parse(row["send_time"].ToString());
                }
                if (row["check_user"] != null)
                {
                    model.check_user = row["check_user"].ToString();
                }
                if (row["check_date"] != null && row["check_date"].ToString() != "")
                {
                    model.check_date = DateTime.Parse(row["check_date"].ToString());
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["isdelete"] != null && row["isdelete"].ToString() != "")
                {
                    if ((row["isdelete"].ToString() == "1") || (row["isdelete"].ToString().ToLower() == "true"))
                    {
                        model.isdelete = true;
                    }
                    else
                    {
                        model.isdelete = false;
                    }
                }
                if (row["driver_id"] != null && row["driver_id"].ToString() != "")
                {
                    model.driver_id = int.Parse(row["driver_id"].ToString());
                }
                if (row["driver_name"] != null)
                {
                    model.driver_name = row["driver_name"].ToString();
                }
                if (row["syn_sgz"] != null && row["syn_sgz"].ToString() != "")
                {
                    model.syn_sgz = int.Parse(row["syn_sgz"].ToString());
                }
                if (row["cancel_sgz"] != null && row["cancel_sgz"].ToString() != "")
                {
                    model.cancel_sgz = int.Parse(row["cancel_sgz"].ToString());
                }
                if (row["has_sync"] != null && row["has_sync"].ToString() != "")
                {
                    model.has_sync = int.Parse(row["has_sync"].ToString());
                }
                if (row["binded_shop_order"] != null)
                {
                    model.binded_shop_order = row["binded_shop_order"].ToString();
                }
                if (row["scan_status"] != null && row["scan_status"].ToString() != "")
                {
                    model.scan_status = int.Parse(row["scan_status"].ToString());
                }
                if (row["kingdee_code"] != null)
                {
                    model.kingdee_code = row["kingdee_code"].ToString();
                }
                if (row["syn_cancel_kingdee"] != null && row["syn_cancel_kingdee"].ToString() != "")
                {
                    model.syn_cancel_kingdee = int.Parse(row["syn_cancel_kingdee"].ToString());
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
            strSql.Append("select RQ,BMBM,XM,JE,DJHM,ZY,BZ,HW,YHW,ZD,JZ,LSH,YSDH,LOCKBZ,DYCS,JHDH,SH,NIAN,YF,YWSM,ID,DDBH,DDSL,ZZPBM,SHENJI,IsInsert,has_send,send_time,check_user,check_date,emp_name,isdelete,driver_id,driver_name,syn_sgz,cancel_sgz,has_sync,binded_shop_order,scan_status,kingdee_code,syn_cancel_kingdee ");
            strSql.Append(" FROM xmh_wms.xlkdb ");
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
            strSql.Append("select count(1) FROM xmh_wms.xlkdb ");
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
            strSql.Append(")AS Row, T.*  from xmh_wms.xlkdb T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取调拨单单号
        /// </summary>
        /// <returns></returns>
        public string GetOrderNo()
        {
            //EF 调用存储过程用法
            DataSet ds = DbHelperMySQL.Query("call xmh_wms.GetOrderSN(2);");
            string orderNo = 2 + DateTime.Now.ToString("yyMMdd") + ds.Tables[0].Rows[0][0].ToString().PadLeft(4, '0');
            return orderNo;
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
            parameters[0].Value = "xlkdb";
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

