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
    /// 数据访问类:shop_return_goods
    /// </summary>
    public partial class shop_return_goods
    {
        public shop_return_goods()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("sid", "shop_return_goods");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int sid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_return_goods");
            strSql.Append(" where sid=@sid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sid", MySqlDbType.Int32,11)			};
            parameters[0].Value = sid;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.shop_return_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_return_goods(");
            strSql.Append("sid,return_id,ck_admin_id,rec_id,goods_name,goods_id,goods_sn,goods_number,goods_price,order_price,goods_unit,note,return_goods_status,goods_reason,receive_num,allow_sale,noallow_sale,back_factory,allow_nosale,noallow,is_tax,order_id,erp_time,erp_code_as,erp_code_bf,erp_code_an,erp_code_n,is_invoice)");
            strSql.Append(" values (");
            strSql.Append("@sid,@return_id,@ck_admin_id,@rec_id,@goods_name,@goods_id,@goods_sn,@goods_number,@goods_price,@order_price,@goods_unit,@note,@return_goods_status,@goods_reason,@receive_num,@allow_sale,@noallow_sale,@back_factory,@allow_nosale,@noallow,@is_tax,@order_id,@erp_time,@erp_code_as,@erp_code_bf,@erp_code_an,@erp_code_n,@is_invoice)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sid", MySqlDbType.Int32,11),
					new MySqlParameter("@return_id", MySqlDbType.Int32,10),
					new MySqlParameter("@ck_admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@rec_id", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_id", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@goods_number", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_price", MySqlDbType.Float,10),
					new MySqlParameter("@order_price", MySqlDbType.Float,10),
					new MySqlParameter("@goods_unit", MySqlDbType.VarChar,10),
					new MySqlParameter("@note", MySqlDbType.VarChar,255),
					new MySqlParameter("@return_goods_status", MySqlDbType.Int16,2),
					new MySqlParameter("@goods_reason", MySqlDbType.VarChar,255),
					new MySqlParameter("@receive_num", MySqlDbType.Int32,6),
					new MySqlParameter("@allow_sale", MySqlDbType.Int32,6),
					new MySqlParameter("@noallow_sale", MySqlDbType.Int32,6),
					new MySqlParameter("@back_factory", MySqlDbType.Int32,6),
					new MySqlParameter("@allow_nosale", MySqlDbType.Int32,6),
					new MySqlParameter("@noallow", MySqlDbType.Int32,6),
					new MySqlParameter("@is_tax", MySqlDbType.Int16,2),
					new MySqlParameter("@order_id", MySqlDbType.Int32,10),
					new MySqlParameter("@erp_time", MySqlDbType.Int32,11),
					new MySqlParameter("@erp_code_as", MySqlDbType.VarChar,30),
					new MySqlParameter("@erp_code_bf", MySqlDbType.VarChar,30),
					new MySqlParameter("@erp_code_an", MySqlDbType.VarChar,30),
					new MySqlParameter("@erp_code_n", MySqlDbType.VarChar,30),
					new MySqlParameter("@is_invoice", MySqlDbType.Int16,2)};
            parameters[0].Value = model.sid;
            parameters[1].Value = model.return_id;
            parameters[2].Value = model.ck_admin_id;
            parameters[3].Value = model.rec_id;
            parameters[4].Value = model.goods_name;
            parameters[5].Value = model.goods_id;
            parameters[6].Value = model.goods_sn;
            parameters[7].Value = model.goods_number;
            parameters[8].Value = model.goods_price;
            parameters[9].Value = model.order_price;
            parameters[10].Value = model.goods_unit;
            parameters[11].Value = model.note;
            parameters[12].Value = model.return_goods_status;
            parameters[13].Value = model.goods_reason;
            parameters[14].Value = model.receive_num;
            parameters[15].Value = model.allow_sale;
            parameters[16].Value = model.noallow_sale;
            parameters[17].Value = model.back_factory;
            parameters[18].Value = model.allow_nosale;
            parameters[19].Value = model.noallow;
            parameters[20].Value = model.is_tax;
            parameters[21].Value = model.order_id;
            parameters[22].Value = model.erp_time;
            parameters[23].Value = model.erp_code_as;
            parameters[24].Value = model.erp_code_bf;
            parameters[25].Value = model.erp_code_an;
            parameters[26].Value = model.erp_code_n;
            parameters[27].Value = model.is_invoice;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(FMS_Model.shop_return_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_return_goods set ");
            strSql.Append("return_id=@return_id,");
            strSql.Append("ck_admin_id=@ck_admin_id,");
            strSql.Append("rec_id=@rec_id,");
            strSql.Append("goods_name=@goods_name,");
            strSql.Append("goods_id=@goods_id,");
            strSql.Append("goods_sn=@goods_sn,");
            strSql.Append("goods_number=@goods_number,");
            strSql.Append("goods_price=@goods_price,");
            strSql.Append("order_price=@order_price,");
            strSql.Append("goods_unit=@goods_unit,");
            strSql.Append("note=@note,");
            strSql.Append("return_goods_status=@return_goods_status,");
            strSql.Append("goods_reason=@goods_reason,");
            strSql.Append("receive_num=@receive_num,");
            strSql.Append("allow_sale=@allow_sale,");
            strSql.Append("noallow_sale=@noallow_sale,");
            strSql.Append("back_factory=@back_factory,");
            strSql.Append("allow_nosale=@allow_nosale,");
            strSql.Append("noallow=@noallow,");
            strSql.Append("is_tax=@is_tax,");
            strSql.Append("order_id=@order_id,");
            strSql.Append("erp_time=@erp_time,");
            strSql.Append("erp_code_as=@erp_code_as,");
            strSql.Append("erp_code_bf=@erp_code_bf,");
            strSql.Append("erp_code_an=@erp_code_an,");
            strSql.Append("erp_code_n=@erp_code_n,");
            strSql.Append("is_invoice=@is_invoice");
            strSql.Append(" where sid=@sid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@return_id", MySqlDbType.Int32,10),
					new MySqlParameter("@ck_admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@rec_id", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_id", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@goods_number", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_price", MySqlDbType.Float,10),
					new MySqlParameter("@order_price", MySqlDbType.Float,10),
					new MySqlParameter("@goods_unit", MySqlDbType.VarChar,10),
					new MySqlParameter("@note", MySqlDbType.VarChar,255),
					new MySqlParameter("@return_goods_status", MySqlDbType.Int16,2),
					new MySqlParameter("@goods_reason", MySqlDbType.VarChar,255),
					new MySqlParameter("@receive_num", MySqlDbType.Int32,6),
					new MySqlParameter("@allow_sale", MySqlDbType.Int32,6),
					new MySqlParameter("@noallow_sale", MySqlDbType.Int32,6),
					new MySqlParameter("@back_factory", MySqlDbType.Int32,6),
					new MySqlParameter("@allow_nosale", MySqlDbType.Int32,6),
					new MySqlParameter("@noallow", MySqlDbType.Int32,6),
					new MySqlParameter("@is_tax", MySqlDbType.Int16,2),
					new MySqlParameter("@order_id", MySqlDbType.Int32,10),
					new MySqlParameter("@erp_time", MySqlDbType.Int32,11),
					new MySqlParameter("@erp_code_as", MySqlDbType.VarChar,30),
					new MySqlParameter("@erp_code_bf", MySqlDbType.VarChar,30),
					new MySqlParameter("@erp_code_an", MySqlDbType.VarChar,30),
					new MySqlParameter("@erp_code_n", MySqlDbType.VarChar,30),
					new MySqlParameter("@is_invoice", MySqlDbType.Int16,2),
					new MySqlParameter("@sid", MySqlDbType.Int32,11)};
            parameters[0].Value = model.return_id;
            parameters[1].Value = model.ck_admin_id;
            parameters[2].Value = model.rec_id;
            parameters[3].Value = model.goods_name;
            parameters[4].Value = model.goods_id;
            parameters[5].Value = model.goods_sn;
            parameters[6].Value = model.goods_number;
            parameters[7].Value = model.goods_price;
            parameters[8].Value = model.order_price;
            parameters[9].Value = model.goods_unit;
            parameters[10].Value = model.note;
            parameters[11].Value = model.return_goods_status;
            parameters[12].Value = model.goods_reason;
            parameters[13].Value = model.receive_num;
            parameters[14].Value = model.allow_sale;
            parameters[15].Value = model.noallow_sale;
            parameters[16].Value = model.back_factory;
            parameters[17].Value = model.allow_nosale;
            parameters[18].Value = model.noallow;
            parameters[19].Value = model.is_tax;
            parameters[20].Value = model.order_id;
            parameters[21].Value = model.erp_time;
            parameters[22].Value = model.erp_code_as;
            parameters[23].Value = model.erp_code_bf;
            parameters[24].Value = model.erp_code_an;
            parameters[25].Value = model.erp_code_n;
            parameters[26].Value = model.is_invoice;
            parameters[27].Value = model.sid;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int sid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_return_goods ");
            strSql.Append(" where sid=@sid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sid", MySqlDbType.Int32,11)			};
            parameters[0].Value = sid;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string sidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_return_goods ");
            strSql.Append(" where sid in (" + sidlist + ")  ");
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public FMS_Model.shop_return_goods GetModel(int sid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sid,return_id,ck_admin_id,rec_id,goods_name,goods_id,goods_sn,goods_number,goods_price,order_price,goods_unit,note,return_goods_status,goods_reason,receive_num,allow_sale,noallow_sale,back_factory,allow_nosale,noallow,is_tax,order_id,erp_time,erp_code_as,erp_code_bf,erp_code_an,erp_code_n,is_invoice from shop_return_goods ");
            strSql.Append(" where sid=@sid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sid", MySqlDbType.Int32,11)			};
            parameters[0].Value = sid;

            FMS_Model.shop_return_goods model = new FMS_Model.shop_return_goods();
            DataSet ds = Shop_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public FMS_Model.shop_return_goods DataRowToModel(DataRow row)
        {
            FMS_Model.shop_return_goods model = new FMS_Model.shop_return_goods();
            if (row != null)
            {
                if (row["sid"] != null && row["sid"].ToString() != "")
                {
                    model.sid = int.Parse(row["sid"].ToString());
                }
                if (row["return_id"] != null && row["return_id"].ToString() != "")
                {
                    model.return_id = int.Parse(row["return_id"].ToString());
                }
                if (row["ck_admin_id"] != null && row["ck_admin_id"].ToString() != "")
                {
                    model.ck_admin_id = int.Parse(row["ck_admin_id"].ToString());
                }
                if (row["rec_id"] != null && row["rec_id"].ToString() != "")
                {
                    model.rec_id = int.Parse(row["rec_id"].ToString());
                }
                if (row["goods_name"] != null)
                {
                    model.goods_name = row["goods_name"].ToString();
                }
                if (row["goods_id"] != null && row["goods_id"].ToString() != "")
                {
                    model.goods_id = int.Parse(row["goods_id"].ToString());
                }
                if (row["goods_sn"] != null)
                {
                    model.goods_sn = row["goods_sn"].ToString();
                }
                if (row["goods_number"] != null && row["goods_number"].ToString() != "")
                {
                    model.goods_number = int.Parse(row["goods_number"].ToString());
                }
                if (row["goods_price"] != null && row["goods_price"].ToString() != "")
                {
                    model.goods_price = decimal.Parse(row["goods_price"].ToString());
                }
                if (row["order_price"] != null && row["order_price"].ToString() != "")
                {
                    model.order_price = decimal.Parse(row["order_price"].ToString());
                }
                if (row["goods_unit"] != null)
                {
                    model.goods_unit = row["goods_unit"].ToString();
                }
                if (row["note"] != null)
                {
                    model.note = row["note"].ToString();
                }
                if (row["return_goods_status"] != null && row["return_goods_status"].ToString() != "")
                {
                    model.return_goods_status = int.Parse(row["return_goods_status"].ToString());
                }
                if (row["goods_reason"] != null)
                {
                    model.goods_reason = row["goods_reason"].ToString();
                }
                if (row["receive_num"] != null && row["receive_num"].ToString() != "")
                {
                    model.receive_num = int.Parse(row["receive_num"].ToString());
                }
                if (row["allow_sale"] != null && row["allow_sale"].ToString() != "")
                {
                    model.allow_sale = int.Parse(row["allow_sale"].ToString());
                }
                if (row["noallow_sale"] != null && row["noallow_sale"].ToString() != "")
                {
                    model.noallow_sale = int.Parse(row["noallow_sale"].ToString());
                }
                if (row["back_factory"] != null && row["back_factory"].ToString() != "")
                {
                    model.back_factory = int.Parse(row["back_factory"].ToString());
                }
                if (row["allow_nosale"] != null && row["allow_nosale"].ToString() != "")
                {
                    model.allow_nosale = int.Parse(row["allow_nosale"].ToString());
                }
                if (row["noallow"] != null && row["noallow"].ToString() != "")
                {
                    model.noallow = int.Parse(row["noallow"].ToString());
                }
                if (row["is_tax"] != null && row["is_tax"].ToString() != "")
                {
                    model.is_tax = int.Parse(row["is_tax"].ToString());
                }
                if (row["order_id"] != null && row["order_id"].ToString() != "")
                {
                    model.order_id = int.Parse(row["order_id"].ToString());
                }
                if (row["erp_time"] != null && row["erp_time"].ToString() != "")
                {
                    model.erp_time = int.Parse(row["erp_time"].ToString());
                }
                if (row["erp_code_as"] != null)
                {
                    model.erp_code_as = row["erp_code_as"].ToString();
                }
                if (row["erp_code_bf"] != null)
                {
                    model.erp_code_bf = row["erp_code_bf"].ToString();
                }
                if (row["erp_code_an"] != null)
                {
                    model.erp_code_an = row["erp_code_an"].ToString();
                }
                if (row["erp_code_n"] != null)
                {
                    model.erp_code_n = row["erp_code_n"].ToString();
                }
                if (row["is_invoice"] != null && row["is_invoice"].ToString() != "")
                {
                    model.is_invoice = int.Parse(row["is_invoice"].ToString());
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
            strSql.Append("select sid,return_id,ck_admin_id,rec_id,goods_name,goods_id,goods_sn,goods_number,goods_price,order_price,goods_unit,note,return_goods_status,goods_reason,receive_num,allow_sale,noallow_sale,back_factory,allow_nosale,noallow,is_tax,order_id,erp_time,erp_code_as,erp_code_bf,erp_code_an,erp_code_n,is_invoice ");
            strSql.Append(" FROM shop_return_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetLists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select o.return_id,o.return_sn,o.user_id,o.add_date,g.sid,g.return_id,g.ck_admin_id,g.rec_id,g.goods_name,g.goods_id,g.goods_sn,");
            strSql.Append(" g.goods_number,(ifnull(g.allow_sale,0) + ifnull(g.back_factory,0) + ifnull(g.allow_nosale,0)) as num,g.goods_price,g.order_price,g.goods_unit,g.note,g.return_goods_status,g.goods_reason,g.receive_num,g.allow_sale,g.noallow_sale,g.back_factory,g.allow_nosale, ");
            strSql.Append(" g.noallow,g.is_tax,g.order_id,g.erp_time,g.erp_code_as,g.erp_code_bf,g.erp_code_an,g.erp_code_n,g.is_invoice,((ifnull(g.allow_sale,0) + ifnull(g.back_factory,0) + ifnull(g.allow_nosale,0))*g.goods_price) total from shop_return_order o ");
            strSql.Append(" left join  shop_return_goods  g on o.return_id=g.return_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得未抵扣的所有退货总金额
        /// </summary>
        public DataSet GetReturnTotal(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum((ifnull(g.allow_sale,0) + ifnull(g.back_factory,0) + ifnull(g.allow_nosale,0))*g.goods_price) total from shop_return_order o ");
            strSql.Append(" left join  shop_return_goods  g on o.return_id=g.return_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        //获得客户的调账金额
        public string GetReturnAmoun(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum((ifnull(g.allow_sale,0) + ifnull(g.back_factory,0) + ifnull(g.allow_nosale,0))*g.goods_price) total from shop_return_order o ");
            strSql.Append(" left join  shop_return_goods  g on o.return_id=g.return_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }

            else
            {
                return obj.ToString();
            }
        }



        public DataSet GetReturnTotalMoney(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum((ifnull(g.allow_sale,0) + ifnull(g.back_factory,0) + ifnull(g.allow_nosale,0))*g.goods_price) as total from shop_return_order o ");
            strSql.Append(" left join  shop_return_goods  g on o.return_id=g.return_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得客户的所有未抵扣的退货商品
        /// </summary>
        public DataSet GetReByUserId(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select g.*,r.add_date from shop_return_goods g inner join shop_return_order r on g.return_id=r.return_id ");
            strSql.Append(" where g.rec_id in (select ordergood_id from shop_order_goods where " + strWhere + " ) and g.is_invoice!='2' ");
            strSql1.Append(" select count(g.sid) from shop_return_goods g inner join shop_return_order r on g.return_id=r.return_id");
            strSql1.Append(" where g.rec_id in (select ordergood_id from shop_order_goods where " + strWhere + " ) and g.is_invoice!='2' ");

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        //单个更改状态
        public bool UpdateInvoice(string sid, string is_invoice)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_return_goods set is_invoice='" + is_invoice + "' ");
            strSql.Append(" where sid=@sid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sid", MySqlDbType.Int32,11)};
            parameters[0].Value = sid;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 获得客户的退货主表信息
        /// </summary>
        public DataSet GetReturnOrder(int PageSize, int PageIndex, int mark, string strWhere, DataTable dt, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            if (mark == 1)
            {
                strSql.Append(" select distinct * from ( ");
                strSql1.Append(" select count(distinct return_id) from ( ");

                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            strSql.Append(" select o.return_id,o.return_sn,CONCAT(o.return_id,',',o.return_sn) as return_sn_id,CONCAT(c.C_name,',',c.C_tel,',',s.Customer) as customer,o.add_date,o.ret_money_total  from  xmh_shop.shop_return_order o  ");
                            strSql.Append(" left join crm_contact c on c.id=o.user_id ");
                            strSql.Append(" left join crm_customer s on s.id=c.C_customerid ");
                            strSql.Append(" where o.is_delete='0' and o.user_id ='" + dt.Rows[i]["userId"].ToString() + "' and o.add_date>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                            strSql1.Append(" select o.* from xmh_shop.shop_return_order o ");
                            strSql1.Append(" where o.is_delete='0' and o.user_id ='" + dt.Rows[i]["userId"].ToString() + "' and o.add_date>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        }
                        else
                        {
                            strSql.Append(" union all select o.return_id,o.return_sn,CONCAT(o.return_id,',',o.return_sn) as return_sn_id,CONCAT(c.C_name,',',c.C_tel,',',s.Customer) as customer,o.add_date,o.ret_money_total  from  xmh_shop.shop_return_order o  ");
                            strSql.Append(" left join crm_contact c on c.id=o.user_id ");
                            strSql.Append(" left join crm_customer s on s.id=c.C_customerid ");
                            strSql.Append(" where o.is_delete='0' and o.user_id ='" + dt.Rows[i]["userId"].ToString() + "' and o.add_date>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                            strSql1.Append(" union all select o.* from xmh_shop.shop_return_order o ");
                            strSql1.Append(" where o.is_delete='0' and o.user_id ='" + dt.Rows[i]["userId"].ToString() + "' and o.add_date>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        }
                    }
                }

                strSql.Append(" ) as g ");
                strSql1.Append(" ) as g ");
            }
            else if (mark == 2)
            {
                strSql.Append(" select o.return_id,o.return_sn,CONCAT(o.return_id,',',o.return_sn) as return_sn,CONCAT(c.C_name,',',c. C_tel,',',s.Customer) as customer,o.add_date,o.ret_money_total  from  xmh_shop.shop_return_order o  ");
                strSql.Append(" left join crm_contact c on c.id=o.user_id ");
                strSql.Append(" left join crm_customer s on s.id=c.C_customerid ");

                strSql1.Append(" select count(o.return_id) from xmh_shop.shop_return_order o  ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" where " + strWhere);
                    strSql1.Append(" where " + strWhere);
                }
            }
          
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得客户的退货商品详情
        /// </summary>
        public DataSet GetReturnDetail(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select g.sid,g.goods_name,o.add_date,sum((ifnull(g.allow_sale,0) + ifnull(g.back_factory,0) + ifnull(g.allow_nosale,0))*g.goods_price) total,g.note ");
            strSql.Append(" from  xmh_shop.shop_return_goods  g left join  xmh_shop.shop_return_order o  on o.return_id=g.return_id  ");
            //strSql.Append(" left join shop_order_info oi on oi.order_id=");

            //strSql.Append(" select i.* ,e.name,CONCAT(c.C_name,',',c. C_tel,',',s.Customer) as customer,s.privatecustomer,s.BeSeats_id  FROM  xmh_shop.shop_invoices  i ");
            //strSql.Append(" left join xmh_crm_al.hr_employee e  on i.admin_id=e.ID ");
            //strSql.Append(" left join xmh_crm_al.crm_contact c on c.id=i.user_id ");
            //strSql.Append(" left join xmh_crm_al.crm_customer s on s.id=c.C_customerid ");


            strSql1.Append(" select count(o.*) from shop_return_order o left join  shop_return_goods  g on o.return_id=g.return_id   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

