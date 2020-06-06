using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_customer_dailyplanDAO
    /// </summary>
    public partial class crm_customer_dailyplanDAO
    {
        public crm_customer_dailyplanDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_customer_dailyplan");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_customer_dailyplan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_customer_dailyplan(");
            strSql.Append("factory_Id,customer_id,customer_name,empid,empname,did,dname,daily,plan_feat,plan_source,plan_5w1h,createtime,isdel)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@customer_id,@customer_name,@empid,@empname,@did,@dname,@daily,@plan_feat,@plan_source,@plan_5w1h,@createtime,@isdel)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@empid", MySqlDbType.Int32,11),
					new MySqlParameter("@empname", MySqlDbType.VarChar,30),
					new MySqlParameter("@did", MySqlDbType.Int32,11),
					new MySqlParameter("@dname", MySqlDbType.VarChar,30),
					new MySqlParameter("@daily", MySqlDbType.Date),
					new MySqlParameter("@plan_feat", MySqlDbType.Float,20),
					new MySqlParameter("@plan_source", MySqlDbType.VarChar,500),
					new MySqlParameter("@plan_5w1h", MySqlDbType.VarChar,500),
					new MySqlParameter("@createtime", MySqlDbType.DateTime),
					new MySqlParameter("@isdel", MySqlDbType.Int32,1)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.customer_id;
            parameters[2].Value = model.customer_name;
            parameters[3].Value = model.empid;
            parameters[4].Value = model.empname;
            parameters[5].Value = model.did;
            parameters[6].Value = model.dname;
            parameters[7].Value = model.daily;
            parameters[8].Value = model.plan_feat;
            parameters[9].Value = model.plan_source;
            parameters[10].Value = model.plan_5w1h;
            parameters[11].Value = model.createtime;
            parameters[12].Value = model.isdel;

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
        public bool Update(XHD.Model.crm_customer_dailyplan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_dailyplan set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("customer_id=@customer_id,");
            strSql.Append("customer_name=@customer_name,");
            strSql.Append("empid=@empid,");
            strSql.Append("empname=@empname,");
            strSql.Append("did=@did,");
            strSql.Append("dname=@dname,");
            strSql.Append("daily=@daily,");
            strSql.Append("plan_feat=@plan_feat,");
            strSql.Append("plan_source=@plan_source,");
            strSql.Append("plan_5w1h=@plan_5w1h,");
            strSql.Append("createtime=@createtime,");
            strSql.Append("isdel=@isdel");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@empid", MySqlDbType.Int32,11),
					new MySqlParameter("@empname", MySqlDbType.VarChar,30),
					new MySqlParameter("@did", MySqlDbType.Int32,11),
					new MySqlParameter("@dname", MySqlDbType.VarChar,30),
					new MySqlParameter("@daily", MySqlDbType.Date),
					new MySqlParameter("@plan_feat", MySqlDbType.Float,20),
					new MySqlParameter("@plan_source", MySqlDbType.VarChar,500),
					new MySqlParameter("@plan_5w1h", MySqlDbType.VarChar,500),
					new MySqlParameter("@createtime", MySqlDbType.DateTime),
					new MySqlParameter("@isdel", MySqlDbType.Int32,1),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.customer_id;
            parameters[2].Value = model.customer_name;
            parameters[3].Value = model.empid;
            parameters[4].Value = model.empname;
            parameters[5].Value = model.did;
            parameters[6].Value = model.dname;
            parameters[7].Value = model.daily;
            parameters[8].Value = model.plan_feat;
            parameters[9].Value = model.plan_source;
            parameters[10].Value = model.plan_5w1h;
            parameters[11].Value = model.createtime;
            parameters[12].Value = model.isdel;
            parameters[13].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_dailyplan ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_dailyplan ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public XHD.Model.crm_customer_dailyplan GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,factory_Id,customer_id,customer_name,empid,empname,did,dname,daily,plan_feat,plan_source,plan_5w1h,createtime,isdel from crm_customer_dailyplan ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.crm_customer_dailyplan model = new XHD.Model.crm_customer_dailyplan();
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
        public XHD.Model.crm_customer_dailyplan DataRowToModel(DataRow row)
        {
            XHD.Model.crm_customer_dailyplan model = new XHD.Model.crm_customer_dailyplan();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["customer_id"] != null && row["customer_id"].ToString() != "")
                {
                    model.customer_id = int.Parse(row["customer_id"].ToString());
                }
                if (row["customer_name"] != null)
                {
                    model.customer_name = row["customer_name"].ToString();
                }
                if (row["empid"] != null && row["empid"].ToString() != "")
                {
                    model.empid = int.Parse(row["empid"].ToString());
                }
                if (row["empname"] != null)
                {
                    model.empname = row["empname"].ToString();
                }
                if (row["did"] != null && row["did"].ToString() != "")
                {
                    model.did = int.Parse(row["did"].ToString());
                }
                if (row["dname"] != null)
                {
                    model.dname = row["dname"].ToString();
                }
                if (row["daily"] != null && row["daily"].ToString() != "")
                {
                    model.daily = DateTime.Parse(row["daily"].ToString());
                }
                if (row["plan_feat"] != null && row["plan_feat"].ToString() != "")
                {
                    model.plan_feat = decimal.Parse(row["plan_feat"].ToString());
                }
                if (row["plan_source"] != null)
                {
                    model.plan_source = row["plan_source"].ToString();
                }
                if (row["plan_5w1h"] != null)
                {
                    model.plan_5w1h = row["plan_5w1h"].ToString();
                }
                if (row["createtime"] != null && row["createtime"].ToString() != "")
                {
                    model.createtime = DateTime.Parse(row["createtime"].ToString());
                }
                if (row["isdel"] != null && row["isdel"].ToString() != "")
                {
                    model.isdel = int.Parse(row["isdel"].ToString());
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
            strSql.Append("select id,factory_Id,customer_id,customer_name,empid,empname,did,dname,daily,plan_feat,plan_source,plan_5w1h,createtime,isdel ");
            strSql.Append(" FROM crm_customer_dailyplan ");
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
            strSql.Append("select count(1) FROM crm_customer_dailyplan ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from crm_customer_dailyplan T ");
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
            parameters[0].Value = "crm_customer_dailyplan";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/


        #region 不用的sql

        //        /// <summary>
        //        /// 获取日计划完成情况，
        //        /// </summary>
        //        public DataSet GetListPlanFeat(int PageSize, int PageIndex, Dictionary<string, string> Parameters, string strWhere, string filedOrder, out string Total)
        //        {
        //            StringBuilder strSql = new StringBuilder();
        //            StringBuilder strSql1 = new StringBuilder();

        //            //string uname = Parameters["admin_user_name"].ToString();
        //            //string andName = " ";
        //            //if (uname != "dmin")
        //            //{
        //            //    andName = " and u.admin_user_name=" + Parameters["admin_user_name"].ToString();
        //            //}

        //            strSql.Append(@"SELECT sale.* from ( select cast((real_feat-plan_feat) as decimal(18,2)) as cha,CONCAT(cast((real_feat/plan_feat) as decimal(18,2)),'%') as wcl, d.*,ff.* FROM crm_customer_dailyplan as d 
        //LEFT JOIN 
        //(
        //SELECT * FROM
        //( 
        //	select abc.admin_user_name, abc.real_feat,c.id as cid,abc.user_id, abc.user_name,c.customer,from_unixtime(erp_time, '%Y-%m-%d') as orderDate from  crm_customer as c 
        //	inner join crm_contact as l on c.id=l.C_Customerid  
        //	inner join ( 
        //		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as real_feat, erp_time
        //		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
        //		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString() + @"
        //		group by u.user_name,u.admin_user_name,u.user_id,from_unixtime(erp_time, '%Y-%m-%d') ) as abc  on l.C_tel=abc.user_name 
        //	where  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
        //) f    
        //) as ff 
        //on ff.cid=d.customer_id  
        //and d.daily=ff.orderDate where daily between '" + Parameters["daily"].ToString() + @"' and '" + Parameters["daily2"].ToString() + @"' ) as sale, hr_employee as emp where emp.id=sale.empid 
        //").Replace("\r\n", "").Replace("\t", " ");

        //            strSql1.Append(@"SELECT sale.* from ( select d.*,ff.* FROM crm_customer_dailyplan as d 
        //LEFT JOIN 
        //(
        //SELECT *  FROM
        //( 
        //	select abc.admin_user_name, abc.real_feat,c.id as cid,abc.user_id, abc.user_name,c.customer,from_unixtime(erp_time, '%Y-%m-%d') as orderDate from  crm_customer as c 
        //	inner join crm_contact as l on c.id=l.C_Customerid  
        //	inner join ( 
        //		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as real_feat  ,erp_time
        //		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
        //		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString() + @"
        //		group by u.user_name,u.admin_user_name,u.user_id,from_unixtime(erp_time, '%Y-%m-%d') ) as abc  on l.C_tel=abc.user_name 
        //	where  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
        //) f    
        //) as ff 
        //on ff.cid=d.customer_id  
        //and d.daily=ff.orderDate where daily between '" + Parameters["daily"].ToString() + @"' and '" + Parameters["daily2"].ToString() + @"' ) as sale, hr_employee as emp where emp.id=sale.empid 
        //").Replace("\r\n", "").Replace("\t", " ");

        //            if (strWhere.Trim() != "")
        //            {
        //                strSql.Append(" and " + strWhere);
        //                strSql1.Append(" and " + strWhere);
        //            }

        //            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
        //            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
        //            return DbHelperMySQL.Query(strSql.ToString());
        //        }


        //        /// <summary>
        //        /// 分页获取数据列表(日内总业绩实际)
        //        /// </summary>
        //        public DataSet GetList(int PageSize, int PageIndex, Dictionary<string, string> Parameters, string filedOrder, out string Total)
        //        {
        //            StringBuilder strSql = new StringBuilder();
        //            StringBuilder strSql1 = new StringBuilder();
        //            //string uname=Parameters["admin_user_name"].ToString();
        //            //string andName=" ";
        //            //if(uname!="dmin")
        //            //{
        //            //    andName = " and u.admin_user_name=" + Parameters["admin_user_name"].ToString();
        //            //}
        //            strSql.Append(@"
        //SELECT f.*,returnNum+tall as real_feat  FROM
        //( 
        //	select abc.admin_user_name, abc.tall,case when returnNum IS NULL then 0 else returnNum end as returnNum,c.id,abc.user_id, abc.user_name,c.customer from  crm_customer as c 
        //	inner join crm_contact as l on c.id=l.C_Customerid  
        //	inner join ( 
        //		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as tall ,sum(xd.JE) as returnNum  
        //		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
        //		left join (select distinct x.* from XLKCK as x where  x.JE<0 and (x.BZ !='换' and x.BZ !='换货' or x.BZ is null) and date(x.RQ) ='" + Parameters["RQ"].ToString() + @"')  as xd on u.user_id= xd.DWMC 
        //		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString() + @"
        //		group by u.user_name,u.admin_user_name,u.user_id ) as abc  on l.C_tel=abc.user_name 
        //	on  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
        //) f  ").Replace("\r\n", "");

        //            strSql1.Append(@"
        //SELECT count(id)  FROM
        //( 
        //	select abc.admin_user_name, abc.tall,case when returnNum IS NULL then 0 else returnNum end as returnNum,c.id,abc.user_id, abc.user_name,c.customer from  crm_customer as c 
        //	inner join crm_contact as l on c.id=l.C_Customerid  
        //	inner join ( 
        //		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as tall ,sum(xd.JE) as returnNum  
        //		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
        //		left join (select distinct x.* from XLKCK as x where  x.JE<0 and (x.BZ !='换' and x.BZ !='换货' or x.BZ is null) and date(x.RQ) ='" + Parameters["RQ"].ToString() + @"')  as xd on u.user_id= xd.DWMC 
        //		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString() + @"
        //		group by u.user_name,u.admin_user_name,u.user_id ) as abc  on l.C_tel=abc.user_name 
        //	on  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
        //) f  ").Replace("\r\n", "");


        //            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
        //            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
        //            return DbHelperMySQL.Query(strSql.ToString());
        //        }


        //        /// <summary>
        //        /// 获得时间段内的总日计划
        //        /// </summary>
        //        public DataSet GetSumPlans(string strWhere)
        //        {
        //            StringBuilder strSql = new StringBuilder();
        //            strSql.Append("select sum(plan_feat) as sumPlans ");
        //            strSql.Append(" FROM crm_customer_dailyplan ");
        //            if (strWhere.Trim() != "")
        //            {
        //                strSql.Append(" where " + strWhere);
        //            }
        //            return DbHelperMySQL.Query(strSql.ToString());
        //        }

        //        /// <summary>
        //        /// 获得时间段内的实际业绩
        //        /// </summary>
        //        public DataSet GetSumSales(Dictionary<string, string> Parameters)
        //        {
        //            StringBuilder strSql = new StringBuilder();
        //            string uname = Parameters["admin_user_name"].ToString();
        //            string andName = " ";
        //            if (uname != "dmin")
        //            {
        //                andName = " and u.admin_user_name=" + Parameters["admin_user_name"].ToString();
        //            }
        //            strSql.Append(@"select sum(real_feat) FROM crm_customer_dailyplan as d 
        //LEFT JOIN 
        //(
        //SELECT *  FROM
        //( 
        //	select abc.admin_user_name, abc.real_feat,c.id as cid,abc.user_id, abc.user_name,c.customer,from_unixtime(erp_time, '%Y-%m-%d') as orderDate from  crm_customer as c 
        //	inner join crm_contact as l on c.id=l.C_Customerid  
        //	inner join ( 
        //		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as real_feat ,erp_time
        //		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
        //		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString() + andName + @"
        //		group by u.user_name,u.admin_user_name,u.user_id,from_unixtime(erp_time, '%Y-%m-%d') ) as abc  on l.C_tel=abc.user_name 
        //	where  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
        //) f    
        //) as ff 
        //on ff.cid=d.customer_id  
        //and d.daily=ff.orderDate where daily between '" + Parameters["daily"].ToString() + @"' and '" + Parameters["daily2"].ToString() + @"' 
        //").Replace("\r\n", "").Replace("\t", " ");

        //            return DbHelperMySQL.Query(strSql.ToString());
        //        }

        /// <summary>
        /// 获取日计划完成情况（经理）////因为经理需要修改，不同于报表查看
        /// </summary>
        //        public DataSet GetListPlanFeatManger(int PageSize, int PageIndex, Dictionary<string, string> Parameters, string strWhere, string filedOrder, out string Total)
        //        {
        //            StringBuilder strSql = new StringBuilder();
        //            StringBuilder strSql1 = new StringBuilder();

        //            strSql.Append(@" select  cast((sum_real_feat-sum_plan_feat) as decimal(18,2)) as cha,CONCAT(cast((sum_real_feat/sum_plan_feat) as decimal(18,2)),'%') as wcl,
        //        sales.sum_plan_feat,sales.sum_real_feat,sales.empname,emp.name,emp.d_id,emp.dname,emp.emp_code from hr_employee as emp left join  (
        //		select sum(plan_feat) as sum_plan_feat ,sum(real_feat) as sum_real_feat ,empname ,empid from ( 
        //select cast((real_feat-plan_feat) as decimal(18,2)) as cha,CONCAT(cast((real_feat/plan_feat) as decimal(18,2)),'%') as wcl, d.*,ff.* FROM crm_customer_dailyplan as d 
        //LEFT JOIN 
        //(
        //SELECT * FROM
        //( 
        //	select abc.admin_user_name, abc.real_feat,c.id as cid,abc.user_id, abc.user_name,c.customer,from_unixtime(erp_time, '%Y-%m-%d') as orderDate from  crm_customer as c 
        //	inner join crm_contact as l on c.id=l.C_Customerid  
        //	inner join ( 
        //		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as real_feat, erp_time
        //		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
        //		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString()  + @"
        //		group by u.user_name,u.admin_user_name,u.user_id,from_unixtime(erp_time, '%Y-%m-%d') ) as abc  on l.C_tel=abc.user_name 
        //	where  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
        //) f    
        //) as ff 
        //on ff.cid=d.customer_id  
        //and d.daily=ff.orderDate where daily between '" + Parameters["daily"].ToString() + @"' and '" + Parameters["daily2"].ToString() + @"'  ) sale) as sales on emp.id=sales.empid 
        //").Replace("\r\n", "").Replace("\t", " ");

        ////            strSql1.Append(@"   select count(*) from hr_employee as emp left join  (
        ////		select sum(plan_feat) as sum_plan_feat ,sum(real_feat) as sum_real_feat ,empname ,empid from ( 
        ////select cast((real_feat-plan_feat) as decimal(18,2)) as cha,CONCAT(cast((real_feat/plan_feat) as decimal(18,2)),'%') as wcl, d.*,ff.* FROM crm_customer_dailyplan as d 
        ////LEFT JOIN 
        ////(
        ////SELECT *  FROM
        ////( 
        ////	select abc.admin_user_name, abc.real_feat,c.id as cid,abc.user_id, abc.user_name,c.customer,from_unixtime(erp_time, '%Y-%m-%d') as orderDate from  crm_customer as c 
        ////	inner join crm_contact as l on c.id=l.C_Customerid  
        ////	inner join ( 
        ////		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as real_feat  ,erp_time
        ////		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
        ////		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString()  + @"
        ////		group by u.user_name,u.admin_user_name,u.user_id,from_unixtime(erp_time, '%Y-%m-%d') ) as abc  on l.C_tel=abc.user_name 
        ////	where  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
        ////) f    
        ////) as ff 
        ////on ff.cid=d.customer_id  
        ////and d.daily=ff.orderDate where daily between '" + Parameters["daily"].ToString() + @"' and '" + Parameters["daily2"].ToString() + @"'  ) sale) as sales on emp.id=sales.empid 
        ////").Replace("\r\n", "").Replace("\t", " ");

        //            if (strWhere.Trim() != "")
        //            {
        //                strSql.Append(" where " + strWhere);
        //                //strSql1.Append(" where " + strWhere);
        //            }
        //            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
        //            //Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
        //            Total = "30";
        //            return DbHelperMySQL.Query(strSql.ToString());
        //        }
        #endregion

        /// <summary>
        /// 获取日计划完成情况，根据不同的登录人权限获取数据，我的日计划只能查询当前登录empid的计划，经理和管理者根据DataAuth获取查询条件
        /// </summary>
        public DataSet GetListPlanFeatManger(int PageSize, int PageIndex, Dictionary<string, string> Parameters, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();


            strSql.Append(@"SELECT sale.*,emp.name from ( select cast((real_feat-plan_feat) as decimal(18,2)) as cha,CONCAT(cast((real_feat/plan_feat*100) as decimal),'%') as wcl, d.*,ff.* FROM crm_customer_dailyplan as d 
LEFT JOIN 
(
SELECT * FROM
( 
	select abc.admin_user_name, abc.real_feat,c.id as cid,abc.user_id, abc.user_name,c.customer,from_unixtime(erp_time, '%Y-%m-%d') as orderDate from  crm_customer as c 
	inner join crm_contact as l on c.id=l.C_Customerid  
	inner join ( 
		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as real_feat, erp_time
		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString() + @"
		group by u.user_name,u.admin_user_name,u.user_id,from_unixtime(erp_time, '%Y-%m-%d') ) as abc  on l.C_tel=abc.user_name 
	where  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
) f    
) as ff 
on ff.cid=d.customer_id  
and d.daily=ff.orderDate where daily between '" + Parameters["daily"].ToString() + @"' and '" + Parameters["daily2"].ToString() + @"' ) as sale, hr_employee as emp where emp.id=sale.empid 
").Replace("\r\n", "").Replace("\t", " ");

            strSql1.Append(@"SELECT count(*) from ( select cast((real_feat-plan_feat) as decimal(18,2)) as cha,CONCAT(cast((real_feat/plan_feat*100) as decimal),'%') as wcl, d.*,ff.* FROM crm_customer_dailyplan as d 
LEFT JOIN 
(
SELECT *  FROM
( 
	select abc.admin_user_name, abc.real_feat,c.id as cid,abc.user_id, abc.user_name,c.customer,from_unixtime(erp_time, '%Y-%m-%d') as orderDate from  crm_customer as c 
	inner join crm_contact as l on c.id=l.C_Customerid  
	inner join ( 
		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as real_feat  ,erp_time
		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString() + @"
		group by u.user_name,u.admin_user_name,u.user_id,from_unixtime(erp_time, '%Y-%m-%d') ) as abc  on l.C_tel=abc.user_name 
	where  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
) f    
) as ff 
on ff.cid=d.customer_id  
and d.daily=ff.orderDate where daily between '" + Parameters["daily"].ToString() + @"' and '" + Parameters["daily2"].ToString() + @"') as sale, hr_employee as emp where emp.id=sale.empid 
").Replace("\r\n", "").Replace("\t", " ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
                strSql1.Append(" and " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得时间段内的总日计划
        /// </summary>
        public DataSet GetSumPlansManger(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(plan_feat) as sumPlans  FROM crm_customer_dailyplan as plan, hr_employee as emp ");
            strSql.Append(" where emp.id=plan.empid ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得时间段内的实际业绩
        /// </summary>
        public DataSet GetSumSalesManger(Dictionary<string, string> Parameters, string whereStr)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(@"SELECT sum(real_feat) from (
 SELECT sale.* from ( select cast((real_feat-plan_feat) as decimal(18,2)) as cha,CONCAT(cast((real_feat/plan_feat*100) as decimal),'%') as wcl, d.*,ff.* FROM crm_customer_dailyplan as d 
LEFT JOIN 
(
SELECT * FROM
( 
	select abc.admin_user_name, abc.real_feat,c.id as cid,abc.user_id, abc.user_name,c.customer,from_unixtime(erp_time, '%Y-%m-%d') as orderDate from  crm_customer as c 
	inner join crm_contact as l on c.id=l.C_Customerid  
	inner join ( 
		select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as real_feat, erp_time
		from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id   
		where  o.order_status !=9 and erp_time between " + Parameters["erp_timeB"].ToString() + @" and " + Parameters["erp_timeT"].ToString() + @"
		group by u.user_name,u.admin_user_name,u.user_id,from_unixtime(erp_time, '%Y-%m-%d') ) as abc  on l.C_tel=abc.user_name 
	where  c.isdelete=0 and c.Factory_Id='" + Parameters["factory_id"].ToString() + @"' 
) f    
) as ff 
on ff.cid=d.customer_id  
and d.daily=ff.orderDate where daily between '" + Parameters["daily"].ToString() + @"' and '" + Parameters["daily2"].ToString() + @"' ) as sale, hr_employee as emp where emp.id=sale.empid 
" + whereStr + @"
) ss
").Replace("\r\n", "").Replace("\t", " ");

            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 更新一条数据，只修改计划业绩
        /// </summary>
        public bool Update(decimal plan_feat, string plan_source, string plan_5w1h, int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_dailyplan set ");
            strSql.Append("plan_feat=@plan_feat,");
            strSql.Append("plan_source=@plan_source,");
            strSql.Append("plan_5w1h=@plan_5w1h");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@plan_feat", MySqlDbType.Float,20),
                    new MySqlParameter("@plan_source", MySqlDbType.VarChar,500),
                    new MySqlParameter("@plan_5w1h", MySqlDbType.VarChar,500),
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = plan_feat;
            parameters[1].Value = plan_source;
            parameters[2].Value = plan_5w1h;
            parameters[3].Value = id;

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
        /// 管理员ALL查看页面，分部门显示
        /// </summary>
        public DataSet GetListPlanFeatAll(int PageSize, int PageIndex, Dictionary<string, string> Parameters, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@"SELECT dep.id,
       dep.d_name,
       dep.parentid,
       dep.parentname,
       sum(plan_feat) as dep_plan,
	   sum(real_feat) as dep_real,
       cast((sum(real_feat)-sum(plan_feat)) AS decimal(18,2)) AS dep_cha,
       CONCAT(cast((sum(real_feat)/sum(plan_feat)*100) AS decimal),'%') AS dep_wcl
 FROM hr_department AS dep
 LEFT JOIN hr_employee AS emp ON dep.id=emp.d_id and emp.factory_id='" + Parameters["factory_id"].ToString() + @"' AND emp.isdelete=0
 LEFT JOIN
 (SELECT empid,
		d.did,
        d.plan_feat,
        ff.real_feat
   FROM crm_customer_dailyplan AS d
   LEFT JOIN
     (SELECT *
      FROM
        (SELECT abc.admin_user_name,
                abc.real_feat,
                c.id AS cid,
                abc.user_id,
                abc.user_name,
                c.customer,
                from_unixtime(erp_time, '%Y-%m-%d') AS orderDate
         FROM crm_customer AS c
         INNER JOIN crm_contact AS l ON c.id=l.C_Customerid
         INNER JOIN
           (SELECT u.user_name,
                   u.admin_user_name,
                   u.user_id,
                   sum(o.goods_amount+o.shipping_fee) AS real_feat,
                   erp_time
            FROM ecs_users AS u
            LEFT JOIN ecs_order_info AS o ON o.user_id=u.user_id
            WHERE o.order_status !=9
              AND erp_time BETWEEN " + Parameters["erp_timeB"].ToString() + @" AND " + Parameters["erp_timeT"].ToString() + @"
            GROUP BY u.user_name,
                     u.admin_user_name,
                     u.user_id,
                     from_unixtime(erp_time, '%Y-%m-%d')) AS abc ON l.C_tel=abc.user_name
         WHERE c.isdelete=0
           AND c.Factory_Id='1000') f) AS ff ON ff.cid=d.customer_id
   AND d.daily=ff.orderDate
   WHERE daily BETWEEN '" + Parameters["daily"].ToString() + @"' AND '" + Parameters["daily2"].ToString() + @"') as sale on emp.id=sale.empid
   " + Parameters["whereStr"].ToString() + @"
  GROUP BY dep.id ,
         dep.d_name").Replace("\r\n", "").Replace("\t", " ");

            strSql1.Append(@" SELECT dep.id,
       dep.d_name,
       dep.parentid,
       dep.parentname
 FROM hr_department AS dep " + Parameters["whereStr"].ToString() + @"
").Replace("\r\n", "").Replace("\t", " ");

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取某个客户某天的完成情况
        /// </summary>
        public DataSet GetCompleteStatus(int customer_id, string date, int empid, int unixtimeStart, int unixtimeEnd, string factory_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT
                    	p.plan_feat,
                    	shop.toDayMoney,
                    	p.plan_feat - IFNULL(shop.toDayMoney, 0) AS difference,
                    	(IFNULL(shop.toDayMoney, 0) / p.plan_feat)*100  AS ratio
                    FROM
                    	crm_customer_dailyplan AS p
                    LEFT JOIN (
                    	SELECT
                    		l.C_customerid,
                    		sum(abc.tall) AS toDayMoney
                    	FROM
                    		crm_contact AS l
                    	INNER JOIN (
                    		SELECT
                    			u.user_name,
                    			u.admin_user_name,
                    			u.user_id,
                    			sum(
                    				o.goods_amount + o.shipping_fee
                    			) AS tall
                    		FROM
                    			ecs_users AS u
                    		LEFT JOIN ecs_order_info AS o ON o.user_id = u.user_id
                    		WHERE
                    			o.order_status != 9
                    		AND o.erp_time BETWEEN " + unixtimeStart + @"
                    		AND " + unixtimeEnd + @"
                    		GROUP BY
                    			u.user_name,
                    			u.user_id
                    	) AS abc ON l.C_tel = abc.user_name
                    	WHERE
                    		l.isDelete = 0
                    	AND l.Factory_Id = '" + factory_id + @"'
                    	AND l.C_customerid = " + customer_id + @"
                    	GROUP BY
                    		l.C_customerid
                    ) AS shop ON p.customer_id = shop.C_customerid
                    WHERE
                    	p.customer_id = " + customer_id + @"
                    AND p.empid =" + empid + " and p.daily='" + date + "'");
            return DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

