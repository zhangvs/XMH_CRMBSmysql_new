using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;//Please add references
namespace FMS_DAL
{

    /// <summary>
    /// 数据访问类:wms_invoice_detial
    /// </summary>
    public partial class wms_invoice_detial
    {
        public wms_invoice_detial()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from wms_invoice_detial");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64,20)			};
            parameters[0].Value = id;

            return Wms_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.wms_invoice_detial model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into wms_invoice_detial(");
            strSql.Append("id,inv_sn,record,inv_time,set_time,goods_id,goods_sn,goods_name,goods_price,ntax_price,goods_num,goods_unit,money,batch_no,go_sn,go_record,tax_money,ntax_money)");
            strSql.Append(" values (");
            strSql.Append("@id,@inv_sn,@record,@inv_time,@set_time,@goods_id,@goods_sn,@goods_name,@goods_price,@ntax_price,@goods_num,@goods_unit,@money,@batch_no,@go_sn,@go_record,@tax_money,@ntax_money)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64,20),
					new MySqlParameter("@inv_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@record", MySqlDbType.Int32,11),
					new MySqlParameter("@inv_time", MySqlDbType.DateTime),
					new MySqlParameter("@set_time", MySqlDbType.DateTime),
					new MySqlParameter("@goods_id", MySqlDbType.Int64,20),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@goods_price", MySqlDbType.Decimal,15),
					new MySqlParameter("@ntax_price", MySqlDbType.Decimal,15),
					new MySqlParameter("@goods_num", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_unit", MySqlDbType.VarChar,20),
					new MySqlParameter("@money", MySqlDbType.Decimal,15),
					new MySqlParameter("@batch_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@go_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@go_record", MySqlDbType.Int32,11),
					new MySqlParameter("@tax_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@ntax_money", MySqlDbType.Decimal,15)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.inv_sn;
            parameters[2].Value = model.record;
            parameters[3].Value = model.inv_time;
            parameters[4].Value = model.set_time;
            parameters[5].Value = model.goods_id;
            parameters[6].Value = model.goods_sn;
            parameters[7].Value = model.goods_name;
            parameters[8].Value = model.goods_price;
            parameters[9].Value = model.ntax_price;
            parameters[10].Value = model.goods_num;
            parameters[11].Value = model.goods_unit;
            parameters[12].Value = model.money;
            parameters[13].Value = model.batch_no;
            parameters[14].Value = model.go_sn;
            parameters[15].Value = model.go_record;
            parameters[16].Value = model.tax_money;
            parameters[17].Value = model.ntax_money;

            int rows = Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(FMS_Model.wms_invoice_detial model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update wms_invoice_detial set ");
            strSql.Append("inv_sn=@inv_sn,");
            strSql.Append("record=@record,");
            strSql.Append("inv_time=@inv_time,");
            strSql.Append("set_time=@set_time,");
            strSql.Append("goods_id=@goods_id,");
            strSql.Append("goods_sn=@goods_sn,");
            strSql.Append("goods_name=@goods_name,");
            strSql.Append("goods_price=@goods_price,");
            strSql.Append("ntax_price=@ntax_price,");
            strSql.Append("goods_num=@goods_num,");
            strSql.Append("goods_unit=@goods_unit,");
            strSql.Append("money=@money,");
            strSql.Append("batch_no=@batch_no,");
            strSql.Append("go_sn=@go_sn,");
            strSql.Append("go_record=@go_record,");
            strSql.Append("tax_money=@tax_money,");
            strSql.Append("ntax_money=@ntax_money");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@inv_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@record", MySqlDbType.Int32,11),
					new MySqlParameter("@inv_time", MySqlDbType.DateTime),
					new MySqlParameter("@set_time", MySqlDbType.DateTime),
					new MySqlParameter("@goods_id", MySqlDbType.Int64,20),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@goods_price", MySqlDbType.Decimal,15),
					new MySqlParameter("@ntax_price", MySqlDbType.Decimal,15),
					new MySqlParameter("@goods_num", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_unit", MySqlDbType.VarChar,20),
					new MySqlParameter("@money", MySqlDbType.Decimal,15),
					new MySqlParameter("@batch_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@go_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@go_record", MySqlDbType.Int32,11),
					new MySqlParameter("@tax_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@ntax_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@id", MySqlDbType.Int64,20)};
            parameters[0].Value = model.inv_sn;
            parameters[1].Value = model.record;
            parameters[2].Value = model.inv_time;
            parameters[3].Value = model.set_time;
            parameters[4].Value = model.goods_id;
            parameters[5].Value = model.goods_sn;
            parameters[6].Value = model.goods_name;
            parameters[7].Value = model.goods_price;
            parameters[8].Value = model.ntax_price;
            parameters[9].Value = model.goods_num;
            parameters[10].Value = model.goods_unit;
            parameters[11].Value = model.money;
            parameters[12].Value = model.batch_no;
            parameters[13].Value = model.go_sn;
            parameters[14].Value = model.go_record;
            parameters[15].Value = model.tax_money;
            parameters[16].Value = model.ntax_money;
            parameters[17].Value = model.id;

            int rows = Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(long id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from wms_invoice_detial ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64,20)			};
            parameters[0].Value = id;

            int rows = Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from wms_invoice_detial ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = Wms_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public FMS_Model.wms_invoice_detial GetModel(long id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,inv_sn,record,inv_time,set_time,goods_id,goods_sn,goods_name,goods_price,ntax_price,goods_num,goods_unit,money,batch_no,go_sn,go_record,tax_money,ntax_money from wms_invoice_detial ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64,20)			};
            parameters[0].Value = id;

            FMS_Model.wms_invoice_detial model = new FMS_Model.wms_invoice_detial();
            DataSet ds = Wms_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public FMS_Model.wms_invoice_detial DataRowToModel(DataRow row)
        {
            FMS_Model.wms_invoice_detial model = new FMS_Model.wms_invoice_detial();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = long.Parse(row["id"].ToString());
                }
                if (row["inv_sn"] != null)
                {
                    model.inv_sn = row["inv_sn"].ToString();
                }
                if (row["record"] != null && row["record"].ToString() != "")
                {
                    model.record = int.Parse(row["record"].ToString());
                }
                if (row["inv_time"] != null && row["inv_time"].ToString() != "")
                {
                    model.inv_time = DateTime.Parse(row["inv_time"].ToString());
                }
                if (row["set_time"] != null && row["set_time"].ToString() != "")
                {
                    model.set_time = DateTime.Parse(row["set_time"].ToString());
                }
                if (row["goods_id"] != null && row["goods_id"].ToString() != "")
                {
                    model.goods_id = long.Parse(row["goods_id"].ToString());
                }
                if (row["goods_sn"] != null)
                {
                    model.goods_sn = row["goods_sn"].ToString();
                }
                if (row["goods_name"] != null)
                {
                    model.goods_name = row["goods_name"].ToString();
                }
                if (row["goods_price"] != null && row["goods_price"].ToString() != "")
                {
                    model.goods_price = decimal.Parse(row["goods_price"].ToString());
                }
                if (row["ntax_price"] != null && row["ntax_price"].ToString() != "")
                {
                    model.ntax_price = decimal.Parse(row["ntax_price"].ToString());
                }
                if (row["goods_num"] != null && row["goods_num"].ToString() != "")
                {
                    model.goods_num = int.Parse(row["goods_num"].ToString());
                }
                if (row["goods_unit"] != null)
                {
                    model.goods_unit = row["goods_unit"].ToString();
                }
                if (row["money"] != null && row["money"].ToString() != "")
                {
                    model.money = decimal.Parse(row["money"].ToString());
                }
                if (row["batch_no"] != null)
                {
                    model.batch_no = row["batch_no"].ToString();
                }
                if (row["go_sn"] != null)
                {
                    model.go_sn = row["go_sn"].ToString();
                }
                if (row["go_record"] != null && row["go_record"].ToString() != "")
                {
                    model.go_record = int.Parse(row["go_record"].ToString());
                }
                if (row["tax_money"] != null && row["tax_money"].ToString() != "")
                {
                    model.tax_money = decimal.Parse(row["tax_money"].ToString());
                }
                if (row["ntax_money"] != null && row["ntax_money"].ToString() != "")
                {
                    model.ntax_money = decimal.Parse(row["ntax_money"].ToString());
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
            strSql.Append("select id,inv_sn,record,inv_time,set_time,goods_id,goods_sn,goods_name,goods_price,ntax_price,goods_num,goods_unit,money,batch_no,go_sn,go_record,tax_money,ntax_money ");
            strSql.Append(" FROM wms_invoice_detial ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Wms_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// model_list获取数据集
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<FMS_Model.wms_invoice_detial> NewGetList(string strWhere)
        {
            List<FMS_Model.wms_invoice_detial> list = new List<FMS_Model.wms_invoice_detial>();
            DataSet ds = GetList(strWhere);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    FMS_Model.wms_invoice_detial tempbill = new FMS_Model.wms_invoice_detial();
                    tempbill = DataRowToModel(dr);
                    list.Add(tempbill);
                }
                return list;
            }
            else
                return null;

        }

        ///// <summary>
        ///// 获取记录总数
        ///// </summary>
        //public int GetRecordCount(string strWhere)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select count(1) FROM wms_invoice_detial ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from wms_invoice_detial T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return Wms_DbHelperMySQL.Query(strSql.ToString());
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
            parameters[0].Value = "wms_invoice_detial";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return Wms_DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
