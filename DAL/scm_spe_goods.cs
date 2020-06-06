/**  版本信息模板在安装目录下，可自行修改。
* scm_spe_goods.cs
*
* 功 能： N/A
* 类 名： scm_spe_goods
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/26 10:17:48   N/A    初版
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
	/// 数据访问类:scm_spe_goods
	/// </summary>
	public partial class scm_spe_goods
	{
		public scm_spe_goods()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "scm_spe_goods"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from scm_spe_goods");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.scm_spe_goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into scm_spe_goods(");
			strSql.Append("id,spe_order_id,order_goodsid,order_goodssn,goods_num,goods_price,split_num)");
			strSql.Append(" values (");
			strSql.Append("@id,@spe_order_id,@order_goodsid,@order_goodssn,@goods_num,@goods_price,@split_num)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@spe_order_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_goodsid", MySqlDbType.Int32,11),
					new MySqlParameter("@order_goodssn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_num", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@split_num", MySqlDbType.Int32,11)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.spe_order_id;
			parameters[2].Value = model.order_goodsid;
			parameters[3].Value = model.order_goodssn;
			parameters[4].Value = model.goods_num;
			parameters[5].Value = model.goods_price;
			parameters[6].Value = model.split_num;

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
		public bool Update(XHD.Model.scm_spe_goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update scm_spe_goods set ");
			strSql.Append("spe_order_id=@spe_order_id,");
			strSql.Append("order_goodsid=@order_goodsid,");
			strSql.Append("order_goodssn=@order_goodssn,");
			strSql.Append("goods_num=@goods_num,");
			strSql.Append("goods_price=@goods_price,");
			strSql.Append("split_num=@split_num");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@spe_order_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_goodsid", MySqlDbType.Int32,11),
					new MySqlParameter("@order_goodssn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_num", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@split_num", MySqlDbType.Int32,11),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.spe_order_id;
			parameters[1].Value = model.order_goodsid;
			parameters[2].Value = model.order_goodssn;
			parameters[3].Value = model.goods_num;
			parameters[4].Value = model.goods_price;
			parameters[5].Value = model.split_num;
			parameters[6].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from scm_spe_goods ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from scm_spe_goods ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public XHD.Model.scm_spe_goods GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,spe_order_id,order_goodsid,order_goodssn,goods_num,goods_price,split_num from scm_spe_goods ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			XHD.Model.scm_spe_goods model=new XHD.Model.scm_spe_goods();
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
        /// 获得数据列表
        /// </summary>
        public XHD.Model.scm_spe_goods GetModel(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,spe_order_id,order_goodsid,order_goodssn,goods_num,goods_price,split_num ");
            strSql.Append(" FROM scm_spe_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            XHD.Model.scm_spe_goods model = new XHD.Model.scm_spe_goods();
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
		public XHD.Model.scm_spe_goods DataRowToModel(DataRow row)
		{
			XHD.Model.scm_spe_goods model=new XHD.Model.scm_spe_goods();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["spe_order_id"]!=null && row["spe_order_id"].ToString()!="")
				{
					model.spe_order_id=int.Parse(row["spe_order_id"].ToString());
				}
				if(row["order_goodsid"]!=null && row["order_goodsid"].ToString()!="")
				{
					model.order_goodsid=int.Parse(row["order_goodsid"].ToString());
				}
				if(row["order_goodssn"]!=null)
				{
					model.order_goodssn=row["order_goodssn"].ToString();
				}
				if(row["goods_num"]!=null && row["goods_num"].ToString()!="")
				{
					model.goods_num=int.Parse(row["goods_num"].ToString());
				}
				if(row["goods_price"]!=null && row["goods_price"].ToString()!="")
				{
					model.goods_price=decimal.Parse(row["goods_price"].ToString());
				}
				if(row["split_num"]!=null && row["split_num"].ToString()!="")
				{
					model.split_num=int.Parse(row["split_num"].ToString());
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
			strSql.Append("select id,spe_order_id,order_goodsid,order_goodssn,goods_num,goods_price,split_num ");
			strSql.Append(" FROM scm_spe_goods ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,spe_order_id,order_goodsid,order_goodssn,goods_num,goods_price,split_num,g.goods_name ");
            strSql.Append(" FROM scm_spe_goods as sg inner join ecs_goods g on g.goods_id=sg.order_goodsid");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 增加数据
        /// </summary>
        public bool AddInfo(int suppliers_id)
        {
            string strSql = @"INSERT INTO scm_spe_goods(spe_order_id,order_goodsid,order_goodssn,goods_num,goods_price,split_num)
                            SELECT spe.id,og.goods_id,og.goods_sn,og.goods_number,g.inv_warn_price,'0' 
                            FROM ecs_order_goods og 
                            INNER JOIN (
                            	SELECT * FROM scm_spe_order 
                            	WHERE Id NOT IN (SELECT spe_order_id FROM scm_spe_goods) 
                                AND order_suppliersid={0}
                            ) spe  ON og.order_id=spe.order_id_old
                            INNER JOIN ecs_goods g ON g.goods_id=og.goods_id AND g.suppliers_id={1}";
            strSql = String.Format(strSql, suppliers_id, suppliers_id);

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
        /// 修改数据
        /// </summary>
        public bool UpdateInfo(int suppliers_id)
        {
            string strSql = @"UPDATE scm_spe_goods sg
                              SET split_num = goods_num
                              WHERE
                              	spe_order_id IN (
                              		SELECT
                              			spe_order_id
                              		FROM
                              			scm_spe_order_detail
                              		WHERE
                              			order_suppliersid = {0}
                              	) AND split_num=0";
            strSql = String.Format(strSql, suppliers_id);

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
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM scm_spe_goods ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from scm_spe_goods T ");
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
			parameters[0].Value = "scm_spe_goods";
			parameters[1].Value = "id";
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

