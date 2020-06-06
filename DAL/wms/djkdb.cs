/**  版本信息模板在安装目录下，可自行修改。
* djkdb.cs
*
* 功 能： N/A
* 类 名： djkdb
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
	/// 数据访问类:djkdb
	/// </summary>
	public partial class djkdb
	{
		public djkdb()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("ID", "djkdb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) from xmh_wms.djkdb");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,11)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.wms.djkdb model)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into xmh_wms.djkdb(");
			strSql.Append("RQ,BM,ZTIDH,DW,YHW,SL,DJ,HW,BZ,DJHM,JL,JE,DJS,XSJ,NIAN,YF,BZSL,BZDJ,BZDW,ID,PCH,XQ,GLID,YL,goods_sn,goods_name,pos_code,isdelete)");
			strSql.Append(" values (");
			strSql.Append("@RQ,@BM,@ZTIDH,@DW,@YHW,@SL,@DJ,@HW,@BZ,@DJHM,@JL,@JE,@DJS,@XSJ,@NIAN,@YF,@BZSL,@BZDJ,@BZDW,@ID,@PCH,@XQ,@GLID,@YL,@goods_sn,@goods_name,@pos_code,@isdelete)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RQ", MySqlDbType.DateTime),
					new MySqlParameter("@BM", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,3),
					new MySqlParameter("@DW", MySqlDbType.VarChar,50),
					new MySqlParameter("@YHW", MySqlDbType.VarChar,50),
					new MySqlParameter("@SL", MySqlDbType.Decimal,15),
					new MySqlParameter("@DJ", MySqlDbType.Decimal,18),
					new MySqlParameter("@HW", MySqlDbType.VarChar,50),
					new MySqlParameter("@BZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@DJHM", MySqlDbType.VarChar,18),
					new MySqlParameter("@JL", MySqlDbType.Int64,20),
					new MySqlParameter("@JE", MySqlDbType.Decimal,18),
					new MySqlParameter("@DJS", MySqlDbType.VarChar,50),
					new MySqlParameter("@XSJ", MySqlDbType.Decimal,12),
					new MySqlParameter("@NIAN", MySqlDbType.Decimal,12),
					new MySqlParameter("@YF", MySqlDbType.Decimal,12),
					new MySqlParameter("@BZSL", MySqlDbType.Decimal,18),
					new MySqlParameter("@BZDJ", MySqlDbType.Decimal,18),
					new MySqlParameter("@BZDW", MySqlDbType.VarChar,50),
					new MySqlParameter("@ID", MySqlDbType.Int32,11),
					new MySqlParameter("@PCH", MySqlDbType.VarChar,50),
					new MySqlParameter("@XQ", MySqlDbType.DateTime),
					new MySqlParameter("@GLID", MySqlDbType.Int64,20),
					new MySqlParameter("@YL", MySqlDbType.Decimal,18),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,50),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@pos_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@isdelete", MySqlDbType.Bit)};
			parameters[0].Value = model.RQ;
			parameters[1].Value = model.BM;
			parameters[2].Value = model.ZTIDH;
			parameters[3].Value = model.DW;
			parameters[4].Value = model.YHW;
			parameters[5].Value = model.SL;
			parameters[6].Value = model.DJ;
			parameters[7].Value = model.HW;
			parameters[8].Value = model.BZ;
			parameters[9].Value = model.DJHM;
			parameters[10].Value = model.JL;
			parameters[11].Value = model.JE;
			parameters[12].Value = model.DJS;
			parameters[13].Value = model.XSJ;
			parameters[14].Value = model.NIAN;
			parameters[15].Value = model.YF;
			parameters[16].Value = model.BZSL;
			parameters[17].Value = model.BZDJ;
			parameters[18].Value = model.BZDW;
			parameters[19].Value = model.ID;
			parameters[20].Value = model.PCH;
			parameters[21].Value = model.XQ;
			parameters[22].Value = model.GLID;
			parameters[23].Value = model.YL;
			parameters[24].Value = model.goods_sn;
			parameters[25].Value = model.goods_name;
			parameters[26].Value = model.pos_code;
			parameters[27].Value = model.isdelete;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(XHD.Model.wms.djkdb model)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("update xmh_wms.djkdb set ");
			strSql.Append("RQ=@RQ,");
			strSql.Append("BM=@BM,");
			strSql.Append("ZTIDH=@ZTIDH,");
			strSql.Append("DW=@DW,");
			strSql.Append("YHW=@YHW,");
			strSql.Append("SL=@SL,");
			strSql.Append("DJ=@DJ,");
			strSql.Append("HW=@HW,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("DJHM=@DJHM,");
			strSql.Append("JL=@JL,");
			strSql.Append("JE=@JE,");
			strSql.Append("DJS=@DJS,");
			strSql.Append("XSJ=@XSJ,");
			strSql.Append("NIAN=@NIAN,");
			strSql.Append("YF=@YF,");
			strSql.Append("BZSL=@BZSL,");
			strSql.Append("BZDJ=@BZDJ,");
			strSql.Append("BZDW=@BZDW,");
			strSql.Append("PCH=@PCH,");
			strSql.Append("XQ=@XQ,");
			strSql.Append("GLID=@GLID,");
			strSql.Append("YL=@YL,");
			strSql.Append("goods_sn=@goods_sn,");
			strSql.Append("goods_name=@goods_name,");
			strSql.Append("pos_code=@pos_code,");
			strSql.Append("isdelete=@isdelete");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RQ", MySqlDbType.DateTime),
					new MySqlParameter("@BM", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZTIDH", MySqlDbType.Decimal,3),
					new MySqlParameter("@DW", MySqlDbType.VarChar,50),
					new MySqlParameter("@YHW", MySqlDbType.VarChar,50),
					new MySqlParameter("@SL", MySqlDbType.Decimal,15),
					new MySqlParameter("@DJ", MySqlDbType.Decimal,18),
					new MySqlParameter("@HW", MySqlDbType.VarChar,50),
					new MySqlParameter("@BZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@DJHM", MySqlDbType.VarChar,18),
					new MySqlParameter("@JL", MySqlDbType.Int64,20),
					new MySqlParameter("@JE", MySqlDbType.Decimal,18),
					new MySqlParameter("@DJS", MySqlDbType.VarChar,50),
					new MySqlParameter("@XSJ", MySqlDbType.Decimal,12),
					new MySqlParameter("@NIAN", MySqlDbType.Decimal,12),
					new MySqlParameter("@YF", MySqlDbType.Decimal,12),
					new MySqlParameter("@BZSL", MySqlDbType.Decimal,18),
					new MySqlParameter("@BZDJ", MySqlDbType.Decimal,18),
					new MySqlParameter("@BZDW", MySqlDbType.VarChar,50),
					new MySqlParameter("@PCH", MySqlDbType.VarChar,50),
					new MySqlParameter("@XQ", MySqlDbType.DateTime),
					new MySqlParameter("@GLID", MySqlDbType.Int64,20),
					new MySqlParameter("@YL", MySqlDbType.Decimal,18),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,50),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@pos_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@isdelete", MySqlDbType.Bit),
					new MySqlParameter("@ID", MySqlDbType.Int32,11)};
			parameters[0].Value = model.RQ;
			parameters[1].Value = model.BM;
			parameters[2].Value = model.ZTIDH;
			parameters[3].Value = model.DW;
			parameters[4].Value = model.YHW;
			parameters[5].Value = model.SL;
			parameters[6].Value = model.DJ;
			parameters[7].Value = model.HW;
			parameters[8].Value = model.BZ;
			parameters[9].Value = model.DJHM;
			parameters[10].Value = model.JL;
			parameters[11].Value = model.JE;
			parameters[12].Value = model.DJS;
			parameters[13].Value = model.XSJ;
			parameters[14].Value = model.NIAN;
			parameters[15].Value = model.YF;
			parameters[16].Value = model.BZSL;
			parameters[17].Value = model.BZDJ;
			parameters[18].Value = model.BZDW;
			parameters[19].Value = model.PCH;
			parameters[20].Value = model.XQ;
			parameters[21].Value = model.GLID;
			parameters[22].Value = model.YL;
			parameters[23].Value = model.goods_sn;
			parameters[24].Value = model.goods_name;
			parameters[25].Value = model.pos_code;
			parameters[26].Value = model.isdelete;
			parameters[27].Value = model.ID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("delete from xmh_wms.djkdb ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,11)			};
			parameters[0].Value = ID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("delete from xmh_wms.djkdb ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public XHD.Model.wms.djkdb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select RQ,BM,ZTIDH,DW,YHW,SL,DJ,HW,BZ,DJHM,JL,JE,DJS,XSJ,NIAN,YF,BZSL,BZDJ,BZDW,ID,PCH,XQ,GLID,YL,goods_sn,goods_name,pos_code,isdelete from xmh_wms.djkdb ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,11)			};
			parameters[0].Value = ID;

			XHD.Model.wms.djkdb model=new XHD.Model.wms.djkdb();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public XHD.Model.wms.djkdb DataRowToModel(DataRow row)
		{
			XHD.Model.wms.djkdb model=new XHD.Model.wms.djkdb();
			if (row != null)
			{
				if(row["RQ"]!=null && row["RQ"].ToString()!="")
				{
					model.RQ=DateTime.Parse(row["RQ"].ToString());
				}
				if(row["BM"]!=null)
				{
					model.BM=row["BM"].ToString();
				}
				if(row["ZTIDH"]!=null && row["ZTIDH"].ToString()!="")
				{
					model.ZTIDH=decimal.Parse(row["ZTIDH"].ToString());
				}
				if(row["DW"]!=null)
				{
					model.DW=row["DW"].ToString();
				}
				if(row["YHW"]!=null)
				{
					model.YHW=row["YHW"].ToString();
				}
				if(row["SL"]!=null && row["SL"].ToString()!="")
				{
					model.SL=decimal.Parse(row["SL"].ToString());
				}
				if(row["DJ"]!=null && row["DJ"].ToString()!="")
				{
					model.DJ=decimal.Parse(row["DJ"].ToString());
				}
				if(row["HW"]!=null)
				{
					model.HW=row["HW"].ToString();
				}
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
				}
				if(row["DJHM"]!=null)
				{
					model.DJHM=row["DJHM"].ToString();
				}
				if(row["JL"]!=null && row["JL"].ToString()!="")
				{
					model.JL=long.Parse(row["JL"].ToString());
				}
				if(row["JE"]!=null && row["JE"].ToString()!="")
				{
					model.JE=decimal.Parse(row["JE"].ToString());
				}
				if(row["DJS"]!=null)
				{
					model.DJS=row["DJS"].ToString();
				}
				if(row["XSJ"]!=null && row["XSJ"].ToString()!="")
				{
					model.XSJ=decimal.Parse(row["XSJ"].ToString());
				}
				if(row["NIAN"]!=null && row["NIAN"].ToString()!="")
				{
					model.NIAN=decimal.Parse(row["NIAN"].ToString());
				}
				if(row["YF"]!=null && row["YF"].ToString()!="")
				{
					model.YF=decimal.Parse(row["YF"].ToString());
				}
				if(row["BZSL"]!=null && row["BZSL"].ToString()!="")
				{
					model.BZSL=decimal.Parse(row["BZSL"].ToString());
				}
				if(row["BZDJ"]!=null && row["BZDJ"].ToString()!="")
				{
					model.BZDJ=decimal.Parse(row["BZDJ"].ToString());
				}
				if(row["BZDW"]!=null)
				{
					model.BZDW=row["BZDW"].ToString();
				}
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["PCH"]!=null)
				{
					model.PCH=row["PCH"].ToString();
				}
				if(row["XQ"]!=null && row["XQ"].ToString()!="")
				{
					model.XQ=DateTime.Parse(row["XQ"].ToString());
				}
				if(row["GLID"]!=null && row["GLID"].ToString()!="")
				{
					model.GLID=long.Parse(row["GLID"].ToString());
				}
				if(row["YL"]!=null && row["YL"].ToString()!="")
				{
					model.YL=decimal.Parse(row["YL"].ToString());
				}
				if(row["goods_sn"]!=null)
				{
					model.goods_sn=row["goods_sn"].ToString();
				}
				if(row["goods_name"]!=null)
				{
					model.goods_name=row["goods_name"].ToString();
				}
				if(row["pos_code"]!=null)
				{
					model.pos_code=row["pos_code"].ToString();
				}
				if(row["isdelete"]!=null && row["isdelete"].ToString()!="")
				{
					if((row["isdelete"].ToString()=="1")||(row["isdelete"].ToString().ToLower()=="true"))
					{
						model.isdelete=true;
					}
					else
					{
						model.isdelete=false;
					}
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RQ,BM,ZTIDH,DW,YHW,SL,DJ,HW,BZ,DJHM,JL,JE,DJS,XSJ,NIAN,YF,BZSL,BZDJ,BZDW,ID,PCH,XQ,GLID,YL,goods_sn,goods_name,pos_code,isdelete ");
            strSql.Append(" FROM xmh_wms.djkdb ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) FROM xmh_wms.djkdb ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
            strSql.Append(")AS Row, T.*  from xmh_wms.djkdb T ");
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
			parameters[0].Value = "djkdb";
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

