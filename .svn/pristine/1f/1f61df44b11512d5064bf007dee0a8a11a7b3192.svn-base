using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references

namespace XHD.DAL
{
    // <summary>
    /// 数据访问类:ecs_brand
    /// </summary>
    public partial class ecs_brand
    {
        public ecs_brand()
        { }


        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int brand_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_brand");
            strSql.Append(" where brand_id=@brand_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@brand_id", MySqlDbType.Int16)
			};
            parameters[0].Value = brand_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        public bool New_Exists(string where_str)
        {
            string sqlStr = "select count(1) from ecs_brand where " + where_str;
            return DbHelperMySQL.Exists(sqlStr);
        }


        /// <summary>
        /// 获得品牌数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select brand_id,brand_name,brand_logo,brand_desc2,brand_desc,site_url,sort_order,is_show,brand_keywords,keywords,admin_user_name,warehouse_admin_user_name,goods_admin_user_name,suppliers_id ");
            strSql.Append(" FROM ecs_brand ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ecs_brand DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_brand model = new XHD.Model.ecs_brand();
            if (row != null)
            {
                if (row["brand_id"] != null && row["brand_id"].ToString() != "")
                {
                    model.brand_id = int.Parse(row["brand_id"].ToString());
                }
                if (row["brand_name"] != null)
                {
                    model.brand_name = row["brand_name"].ToString();
                }
                if (row["brand_logo"] != null)
                {
                    model.brand_logo = row["brand_logo"].ToString();
                }
                if (row["brand_desc2"] != null)
                {
                    model.brand_desc2 = row["brand_desc2"].ToString();
                }
                if (row["brand_desc"] != null)
                {
                    model.brand_desc = row["brand_desc"].ToString();
                }
                if (row["site_url"] != null)
                {
                    model.site_url = row["site_url"].ToString();
                }
                if (row["sort_order"] != null && row["sort_order"].ToString() != "")
                {
                    model.sort_order = int.Parse(row["sort_order"].ToString());
                }
                if (row["is_show"] != null && row["is_show"].ToString() != "")
                {
                    model.is_show = int.Parse(row["is_show"].ToString());
                }
                if (row["brand_keywords"] != null)
                {
                    model.brand_keywords = row["brand_keywords"].ToString();
                }
                if (row["keywords"] != null)
                {
                    model.keywords = row["keywords"].ToString();
                }
                if (row["admin_user_name"] != null)
                {
                    model.admin_user_name = row["admin_user_name"].ToString();
                }
                if (row["warehouse_admin_user_name"] != null)
                {
                    model.warehouse_admin_user_name = row["warehouse_admin_user_name"].ToString();
                }
                if (row["goods_admin_user_name"] != null)
                {
                    model.goods_admin_user_name = row["goods_admin_user_name"].ToString();
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
            }
            return model;
        }



        /// <summary>
        /// 获得商品分类数据列表
        /// </summary>
        public DataSet GetListCategory(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select cat_id,cat_name,keywords,parent_id,sort_order,is_show");
            strSql.Append(" FROM ecs_category ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select * FROM ecs_brand");
            strSql1.Append(" select count(brand_id) FROM ecs_brand ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 关联
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool RelatedBrand(string brandId, string supplyId)
        {
            string strSql = string.Format(@" update ecs_brand set suppliers_id='{0}' where brand_id in ({1})", supplyId, brandId);
            int rows = DbHelperMySQL.ExecuteSql(strSql);
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 解除
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool UnRelatedBrand(string brandId, string supplyId)
        {
            string strSql = string.Format(@" update ecs_brand set suppliers_id='{0}' where brand_id in ({1})", 0, brandId);
            int rows = DbHelperMySQL.ExecuteSql(strSql);
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据品牌计算业绩(经理)
        /// djtime：单据时间，ordertime：订单时间
        /// </summary>
        public DataSet GetSale(int PageSize, int PageIndex, string strWhere, string ordertime, string djtime, string brand_id, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append("  select sale.sumMoney,back.returnMoney,sale.sumMoney+ifnull(back.returnMoney,0) as realMoney,sale.admin_user_name,emp.name,emp.d_id,emp.dname,emp.emp_code   ");
            strSql.Append("   from hr_employee as emp");
            strSql.Append("  left join ");
            strSql.Append("  (select sum(og.goods_price*og.goods_number) as sumMoney ,oi.admin_user_name");
            strSql.Append("  from  ecs_order_goods as og ");
            strSql.Append("  inner join ecs_goods as g on g.goods_id=og.goods_id and g.brand_id=" + brand_id);
            strSql.Append("  inner join ecs_order_info as oi on oi.order_id=og.order_id  and oi.order_status !=9 " + ordertime);
            //strSql.Append("  inner join ecs_users as u on u.user_id=oi.user_id");
            strSql.Append("  group by oi.admin_user_name) as sale on emp.emp_code=sale.admin_user_name");
            strSql.Append("  left join ");
            strSql.Append("  (select sum(d.je) as returnMoney,x.xm as admin_user_name");
            strSql.Append("  from djkck as d");
            strSql.Append("  inner join ecs_goods as g on d.bm=g.goods_id and g.brand_id=" + brand_id);
            //strSql.Append("  inner join xlkck as x on x.djhm=d.djhm and x.jz='√'");
            strSql.Append("  inner join xlkck as x on x.djhm=d.djhm  ");
            //strSql.Append("  inner join ecs_users as u on u.user_id=x.dwmc");
            strSql.Append("  where " + djtime + " and d.je<0");
            strSql.Append("  group by x.xm) as back on emp.emp_code=back.admin_user_name");
            strSql1.Append(" select count(id) FROM hr_employee as emp ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据品牌计算业绩(总金额)
        /// djtime：单据时间，ordertime：订单时间
        /// </summary>
        public DataSet getSumSales(string strWhere, string ordertime, string djtime, string brand_id)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("  select sum(sale.sumMoney),sum(back.returnMoney),ifnull(sum(sale.sumMoney),0)+ifnull(sum(back.returnMoney),0) as realMoney");
            strSql.Append("   from hr_employee as emp");
            strSql.Append("  left join ");
            strSql.Append("  (select sum(og.goods_price*og.goods_number) as sumMoney ,oi.admin_user_name");
            strSql.Append("  from  ecs_order_goods as og ");
            strSql.Append("  inner join ecs_goods as g on g.goods_id=og.goods_id and g.brand_id=" + brand_id);
            strSql.Append("  inner join ecs_order_info as oi on oi.order_id=og.order_id  and oi.order_status !=9 " + ordertime);
            //strSql.Append("  inner join ecs_users as u on u.user_id=oi.user_id");
            strSql.Append("  group by oi.admin_user_name) as sale on emp.emp_code=sale.admin_user_name");
            strSql.Append("  left join ");
            strSql.Append("  (select sum(d.je) as returnMoney,x.xm as admin_user_name");
            strSql.Append("  from djkck as d");
            strSql.Append("  inner join ecs_goods as g on d.bm=g.goods_id and g.brand_id=" + brand_id);
            //strSql.Append("  inner join xlkck as x on x.djhm=d.djhm and x.jz='√'");
            strSql.Append("  inner join xlkck as x on x.djhm=d.djhm ");
            //strSql.Append("  inner join ecs_users as u on u.user_id=x.dwmc");
            strSql.Append("  where " + djtime + " and d.je<0");
            strSql.Append("  group by x.xm) as back on emp.emp_code=back.admin_user_name");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据品牌计算业绩(全部)
        /// djtime：单据时间，ordertime：订单时间
        /// </summary>
        public DataSet GetSaleAll(int PageSize, int PageIndex, string sqlWhere, string strWhere, string ordertime, string djtime, string brand_id, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append("    select dep.id,dep.d_name,dep.parentid,dep.parentname,sum(sale.sumMoney) as sumMoney,sum(back.returnMoney) as returnMoney,sum(sale.sumMoney)+ifnull(sum(back.returnMoney),0) as realMoney  ");
            strSql.Append("   from hr_department as dep left join hr_employee as emp on dep.id=emp.d_id  and " + sqlWhere);
            strSql.Append("  left join ");
            strSql.Append("  (select sum(og.goods_price*og.goods_number) as sumMoney ,oi.admin_user_name");
            strSql.Append("  from  ecs_order_goods as og ");
            strSql.Append("  inner join ecs_goods as g on g.goods_id=og.goods_id and g.brand_id=" + brand_id);
            strSql.Append("  inner join ecs_order_info as oi on oi.order_id=og.order_id  and oi.order_status !=9 " + ordertime);
            //strSql.Append("  inner join ecs_users as u on u.user_id=oi.user_id");
            strSql.Append("  group by oi.admin_user_name) as sale on emp.emp_code=sale.admin_user_name");
            strSql.Append("  left join ");
            strSql.Append("  (select sum(d.je) as returnMoney,x.xm as admin_user_name");
            strSql.Append("  from djkck as d");
            strSql.Append("  inner join ecs_goods as g on d.bm=g.goods_id and g.brand_id=" + brand_id);
            //strSql.Append("  inner join xlkck as x on x.djhm=d.djhm and x.jz='√'");
            strSql.Append("  inner join xlkck as x on x.djhm=d.djhm ");
            //strSql.Append("  inner join ecs_users as u on u.user_id=x.dwmc");
            strSql.Append("  where " + djtime + " and d.je<0");
            strSql.Append("  group by x.xm) as back on emp.emp_code=back.admin_user_name");
            strSql1.Append(" select count(id) FROM hr_department  ");
            strSql1.Append(" where  parentid=1");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append("  group by dep.id ,dep.d_name");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据品牌计算业绩(全部)
        /// djtime：单据时间，ordertime：订单时间
        /// </summary>
        public DataSet GetDetail(string sqlWhere, string strWhere, string ordertime, string djtime, string brand_id, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("    select sum(sumMoney)  as sumMoney,abc.admin_user_name,abc.datetime,emp.emp_code,emp.name,emp.d_id,emp.dname");
            strSql.Append("   from hr_employee as emp  ");
            strSql.Append("  left join   (");
            strSql.Append("  select sum(og.goods_price*og.goods_number) as sumMoney ,oi.admin_user_name,FROM_UNIXTIME( oi.erp_time, '%Y-%m-%d' ) as datetime");
            strSql.Append("   from  ecs_order_goods as og ");
            strSql.Append("    inner join ecs_goods as g on g.goods_id=og.goods_id and g.brand_id=" + brand_id);
            strSql.Append("  inner join ecs_order_info as oi on oi.order_id=og.order_id  and oi.order_status !=9 " + ordertime);
            strSql.Append(" and oi.admin_user_name='" + strWhere + "'");

            //strSql.Append("   inner join ecs_users as u on u.user_id=oi.user_id " + strWhere);
            strSql.Append("    group by FROM_UNIXTIME( oi.erp_time, '%Y-%m-%d' )");
            strSql.Append("  union all");
            strSql.Append("  select sum(d.je) as sumMoney,x.xm as admin_user_name, date(d.rq) as datetime");
            strSql.Append("   from djkck as d ");
            strSql.Append("   inner join ecs_goods as g on d.bm=g.goods_id and g.brand_id=" + brand_id);
            //strSql.Append("  inner join xlkck as x on x.djhm=d.djhm  and x.jz='√'");
            strSql.Append("  inner join xlkck as x on x.djhm=d.djhm  ");
            //strSql.Append("  inner join ecs_users as u on u.user_id=x.dwmc ");
            strSql.Append("  and x.xm='" + strWhere + "'");
            strSql.Append("   where " + djtime + " and d.je<0 ");
            strSql.Append("  group by date(d.rq)");
            strSql.Append("  ) as abc on emp.emp_code=abc.admin_user_name ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + sqlWhere);
            }
            strSql.Append("  group by abc.datetime,abc.admin_user_name");
            strSql.Append(" order by " + filedOrder );

            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

