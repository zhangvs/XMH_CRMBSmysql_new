using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace XHD.DAL.shop
{
    /// <summary>
    /// 数据访问类:shop_locked_goods
    /// </summary>
    public partial class shop_locked_goods
    {
        public shop_locked_goods()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("id", "shop_locked_goods");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_locked_goods");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop.shop_locked_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_locked_goods(");
            strSql.Append("id,goods_id,order_id,rec_id,admin_id,goods_num,add_time,locked_num,match_time,match_num,is_use,wms_storage)");
            strSql.Append(" values (");
            strSql.Append("@id,@goods_id,@order_id,@rec_id,@admin_id,@goods_num,@add_time,@locked_num,@match_time,@match_num,@is_use,@wms_storage)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_id", MySqlDbType.Int32,11),
					new MySqlParameter("@rec_id", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_num", MySqlDbType.Int32,11),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@locked_num", MySqlDbType.Int32,11),
					new MySqlParameter("@match_time", MySqlDbType.Int32,11),
					new MySqlParameter("@match_num", MySqlDbType.Int32,11),
					new MySqlParameter("@is_use", MySqlDbType.Int16,2),
					new MySqlParameter("@wms_storage", MySqlDbType.VarChar,10)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.goods_id;
            parameters[2].Value = model.order_id;
            parameters[3].Value = model.rec_id;
            parameters[4].Value = model.admin_id;
            parameters[5].Value = model.goods_num;
            parameters[6].Value = model.add_time;
            parameters[7].Value = model.locked_num;
            parameters[8].Value = model.match_time;
            parameters[9].Value = model.match_num;
            parameters[10].Value = model.is_use;
            parameters[11].Value = model.wms_storage;

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
        public bool Update(XHD.Model.shop.shop_locked_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_locked_goods set ");
            strSql.Append("goods_id=@goods_id,");
            strSql.Append("order_id=@order_id,");
            strSql.Append("rec_id=@rec_id,");
            strSql.Append("admin_id=@admin_id,");
            strSql.Append("goods_num=@goods_num,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("locked_num=@locked_num,");
            strSql.Append("match_time=@match_time,");
            strSql.Append("match_num=@match_num,");
            strSql.Append("is_use=@is_use,");
            strSql.Append("wms_storage=@wms_storage");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_id", MySqlDbType.Int32,11),
					new MySqlParameter("@rec_id", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_num", MySqlDbType.Int32,11),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@locked_num", MySqlDbType.Int32,11),
					new MySqlParameter("@match_time", MySqlDbType.Int32,11),
					new MySqlParameter("@match_num", MySqlDbType.Int32,11),
					new MySqlParameter("@is_use", MySqlDbType.Int16,2),
					new MySqlParameter("@wms_storage", MySqlDbType.VarChar,10),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.goods_id;
            parameters[1].Value = model.order_id;
            parameters[2].Value = model.rec_id;
            parameters[3].Value = model.admin_id;
            parameters[4].Value = model.goods_num;
            parameters[5].Value = model.add_time;
            parameters[6].Value = model.locked_num;
            parameters[7].Value = model.match_time;
            parameters[8].Value = model.match_num;
            parameters[9].Value = model.is_use;
            parameters[10].Value = model.wms_storage;
            parameters[11].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_locked_goods ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_locked_goods ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public XHD.Model.shop.shop_locked_goods GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,goods_id,order_id,rec_id,admin_id,goods_num,add_time,locked_num,match_time,match_num,is_use,wms_storage from shop_locked_goods ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.shop.shop_locked_goods model = new XHD.Model.shop.shop_locked_goods();
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
        public XHD.Model.shop.shop_locked_goods DataRowToModel(DataRow row)
        {
            XHD.Model.shop.shop_locked_goods model = new XHD.Model.shop.shop_locked_goods();
            if (row != null)
            {
                //if (row["id"] != null && row["id"].ToString() != "")
                //{
                //    model.id = int.Parse(row["id"].ToString());
                //}
                if (row["goods_id"] != null && row["goods_id"].ToString() != "")
                {
                    model.goods_id = int.Parse(row["goods_id"].ToString());
                }
                //if (row["order_id"] != null && row["order_id"].ToString() != "")
                //{
                //    model.order_id = int.Parse(row["order_id"].ToString());
                //}
                //if (row["rec_id"] != null && row["rec_id"].ToString() != "")
                //{
                //    model.rec_id = int.Parse(row["rec_id"].ToString());
                //}
                //if (row["admin_id"] != null && row["admin_id"].ToString() != "")
                //{
                //    model.admin_id = int.Parse(row["admin_id"].ToString());
                //}
                //if (row["goods_num"] != null && row["goods_num"].ToString() != "")
                //{
                //    model.goods_num = int.Parse(row["goods_num"].ToString());
                //}
                //if (row["add_time"] != null && row["add_time"].ToString() != "")
                //{
                //    model.add_time = int.Parse(row["add_time"].ToString());
                //}
                if (row["locked_num"] != null && row["locked_num"].ToString() != "")
                {
                    model.locked_num = int.Parse(row["locked_num"].ToString());
                }
                //if (row["match_time"] != null && row["match_time"].ToString() != "")
                //{
                //    model.match_time = int.Parse(row["match_time"].ToString());
                //}
                //if (row["match_num"] != null && row["match_num"].ToString() != "")
                //{
                //    model.match_num = int.Parse(row["match_num"].ToString());
                //}
                ////if (row["is_use"] != null && row["is_use"].ToString() != "")
                ////{
                ////    model.is_use = int.Parse(row["is_use"].ToString());
                ////}
                //if (row["wms_storage"] != null)
                //{
                //    model.wms_storage = row["wms_storage"].ToString();
                //}
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,goods_id,order_id,rec_id,admin_id,goods_num,add_time,locked_num,match_time,match_num,is_use,wms_storage ");
            strSql.Append(" FROM shop_locked_goods ");
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
            strSql.Append("select goods_id,sum(locked_num) as locked_num ");
            strSql.Append(" FROM shop_locked_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" group by  goods_id ");

            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM shop_locked_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        //分页获取占货信息
        public DataSet GetLockGoods(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select l.*,g.goods_sn,g.goods_name,e.name,i.order_sn from xmh_shop.shop_locked_goods l");
            strSql.Append(" INNER JOIN xmh_shop.shop_goods as g on l.goods_id =g.goods_id ");
            strSql.Append(" INNER JOIN xmh_shop.shop_order_info as i on i.order_id =l.order_id ");
            strSql.Append(" INNER JOIN hr_employee as e on e.emp_code =l.admin_id ");

            strSql1.Append(" select count(l.goods_id) from xmh_shop.shop_locked_goods l");
            strSql1.Append(" INNER JOIN xmh_shop.shop_goods as g on l.goods_id =g.goods_id ");
            strSql1.Append(" INNER JOIN xmh_shop.shop_order_info as i on i.order_id =l.order_id ");
            strSql1.Append(" INNER JOIN hr_employee as e on e.emp_code =l.admin_id ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

