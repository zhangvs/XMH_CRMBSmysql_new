using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XHD.DBUtility;

namespace XMH.crmService.Data
{
    /// <summary>
    /// 客户应收款，一定时间段内的；业务逻辑
    /// </summary>
    public class Receivable_Acc
    {
        #region 整理数据
        //第一、执行删除操作,删除公客/私客回收站里的客户，彻底从数据库中删除
        public void SetDelete(string strFactory)
        {
            //删除 公客/私客回收站 客户数据
            //1、删除客户跟踪记录
            //2、删除客户联系信息
            //3、删除客户信息
            string strSQL = string.Format(@"delete from crm_follow where customer_id in (select id from crm_customer where  isDelete=1 and  factory_Id={0}) and factory_Id={0};
                                            delete from crm_contact where C_customerid in (select id from crm_customer where  isDelete=1 and  factory_Id={0}) and factory_Id={0};
                                            delete from crm_customer where  isDelete=1 and  factory_Id={0};", strFactory);
            int rows = DbHelperMySQL.ExecuteSql(strSQL.ToString());
        }

        //第二、客户转移记录；**仅转移客服部的客户************
        public void SetMoveCustomer(string strFactory)
        {
            DateTime dtime = DateTime.Now;

            //客户转移记录
            string strSQL = string.Format(@"delete from crm_set_grabcustomer_flow;
                                            Insert Into crm_set_grabcustomer_flow(Factory_Id,CustomerId,BeSeats_empId,Datetime,type)
                                            select factory_Id, id,BeSeats_id,'" + dtime + @"','0'from crm_customer where factory_Id={0} and privatecustomer_Id=52 and isDelete=0
                                            and BeSeats_depid in(" + GetDeptNextAll().TrimEnd(',') + ");", strFactory);

            int rows = DbHelperMySQL.ExecuteSql(strSQL);
        }
        #endregion

        #region 设置数据 type 1、2、3、4、5
        //处理保护客户crm_customer_protect type=1
        public void SetCustomer_protect(string strEnd)
        {
            //时间 周期，临时写死时间周期
            //保护的客户，是指type=1;
            string strSQL = string.Format(@"update crm_set_grabcustomer_flow f, 
                            (select * from crm_customer_protect where isInvalid=0 and isSucceed=1 and apply_etime>UNIX_TIMESTAMP('{0}')) p
                            set f.type =1 where f.CustomerId = p.customer_Id;", strEnd);

            int rows = DbHelperMySQL.ExecuteSql(strSQL);
        }

        //时间周期内创建的客户 type=2
        public void SetCustomer_CreateDate(string strStart, string strEnd, string strFactory)
        {
            string strSQL = string.Format(@"update crm_set_grabcustomer_flow set type =2  where CustomerId in
                                        (select id from crm_customer where Factory_Id={0} and IsDelete=0 and  Create_date<'{1}' and Create_date>'{2}' )", strFactory, strEnd, strStart);

            int rows = DbHelperMySQL.ExecuteSql(strSQL);
        }

        #region 业绩 type=3
        //业绩达标；设置type=3
        public void SetYeJiMove(string strFactory, string strStart, string strEnd)
        {
            DbHelperMySQL.ExecuteSql("delete from crm_order_feat"); //删除历史业绩数据

            GetYeJi(null, strFactory, strStart, strEnd);      //执行计算业绩临时数据

            //执行业绩匹配客户，达标的type=3
            string strSQL = string.Format(@"update crm_set_grabcustomer_flow set type =3  where CustomerId in (select customer_Id from (select factory_id,emp_code,customer_Id,customer_name,sum(realmoney) as realmoney  from crm_order_feat 
                                        group by customer_Id,customer_name,emp_code) as yj where yj.realmoney>={0})", strFactory);
            int rows = DbHelperMySQL.ExecuteSql(strSQL);
        }
        //获取业绩，向临时表增添数据
        public void GetYeJi(XHD.Model.crm_set_pripub_detail model, string strFactory, string strStart, string strEnd)
        {
            //获取有效转移客户，部门 hr_department ;临时写死，客户部ID=1；
            //string strDept = "emp.factory_id='1000' and emp.isdelete=0 and ( emp.d_id  in ( " + GetDeptNextAll().TrimEnd(',') + ")";

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Insert Into crm_order_feat (factory_Id,emp_code,order_feat,sales_return,realmoney,customer_Id,customer_Id_shop,customer_name_shop,customer_name,create_date,create_id)");
            strSql.Append(" (select distinct '" + strFactory + "',c.BeSeats_id,yj.salemoney,yj.backmoney,yj.realmoney,l.C_customerid,yj.user_id,yj.user_name,C.customer,'" + strEnd + "','-1' ");
            strSql.Append("from  crm_customer as c inner join crm_contact as l on c.id=l.C_Customerid  and c.isDelete=0 and privatecustomer_Id=52 ");
            strSql.Append("inner join(");
            strSql.Append("SELECT abcd.*,u.user_name,u.u_company FROM (");
            strSql.Append("SELECT user_id,sum(salemoney) salemoney,sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name,name,d_id,dname ");
            strSql.Append(" FROM hr_employee AS emp LEFT JOIN ");
            strSql.Append(" (select admin_user_name,user_id,goods_amount as salemoney , 0 as backmoney   from ecs_order_info    where order_status !=9 and erp_order_sn<>'' and erp_time  between UNIX_TIMESTAMP('");
            strSql.Append(strStart + "') and UNIX_TIMESTAMP('" + strEnd + "')");
            strSql.Append(" union all ");
            strSql.Append("select xm as admin_user_name,dwmc as user_id, 0 as salemoney,d.je as backmoney from djkck as d   inner join xlkck as x on x.djhm=d.djhm  where  d.rq between '" + strStart.Trim() + "' and '" + strEnd.Trim() + "' and d.je < 0 and date(d.RQ)<'2016-8-24 00:00:00'");
            strSql.Append("union all ");
            strSql.Append("select admin_user_name,user_id, 0 as salemoney, cast(ret_money_total as decimal(18,2)) as backmoney   from ecs_return_order as e   where e.erp_time  between UNIX_TIMESTAMP('" + strStart + "') and UNIX_TIMESTAMP('" + strEnd + "')  and e.ret_money_total<0  and e.erp_time>=1471968000 ");
            strSql.Append(")AS abc ON emp.emp_code=abc.admin_user_name ");
            strSql.Append("WHERE emp.factory_id='1000' and emp.isdelete=0 and ( emp.d_id  in (" + GetDeptNextAll().TrimEnd(',') + ")) and admin_user_name is not null ");
            strSql.Append("GROUP BY user_id ORDER BY convert(user_id,signed) ");
            strSql.Append(")AS abcd ");
            strSql.Append("LEFT JOIN ecs_users AS u ON abcd.user_id=u.user_id ");
            strSql.Append(")  as yj ");
            strSql.Append("on l.C_tel=yj.user_name ");
            strSql.Append(")");

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
        }

        #endregion

        #region 应收款 type=4
        public void SetYingShou(string strFactory, string strStartYear, string strEnd)
        {
            DbHelperMySQL.ExecuteSql("delete from crm_customer_receivable_acc"); //删除历史应收款数据
            GetReceivableAcc(strFactory, strStartYear, strEnd);     //整理应收款的数据
            //维护数据
            string strSQL1 = string.Format(@"UPDATE crm_customer_receivable_acc as r inner join crm_contact as t on r.user_name=t.C_tel Set r.customer_Id=t.C_customerid;");
            int rowsX = DbHelperMySQL.ExecuteSql(strSQL1);
            string strSQL2 = string.Format(@"UPDATE crm_customer_receivable_acc as r inner join crm_customer as c on r.customer_Id=c.id set  r.BeSeats_id=c.BeSeats_id;");
            int rows2 = DbHelperMySQL.ExecuteSql(strSQL2);

            //修改应收款>0，type=4
            string strSQL = string.Format(@"update crm_set_grabcustomer_flow set type =4  where CustomerId in (select Customer_Id from crm_customer_receivable_acc )");

            int rows = DbHelperMySQL.ExecuteSql(strSQL);
        }

        //应收款》0，设置type=4
        //获取应收款
        public void GetReceivableAcc(string strFactory, string strStartYear, string strEnd)
        {
            /*
             *  往来款2016.2.15号开始
                发货order_info 
                打款kuan
                退货return_order
                起初user表jieyu字段
                调账kuan_adjust
             * */
            #region 应收款 = 起初应收+发货金额-收款金额-|退货金额|+调账金额========================================================================

            //应收款=期初已收-打款金额+实际业绩(发货金额-|退货金额|)+调账金额
            string strSQL = string.Format(@"Insert Into crm_customer_receivable_acc(user_Id,user_name,admin_usercode, jieyu,  salemoney, kuan, backmoney, kuanadjust,Settlement_value)(
                                            select  user_id,user_name,admin_user_name, jieyu,  salemoney, kuan, backmoney, kuanadjust, realmoney  from (
                                            select user_id,user_name,admin_user_name,sum(jieyu) as jieyu, sum(salemoney) salemoney,sum(kuan) as kuan,sum(backmoney) backmoney,sum(kuanadjust) as kuanadjust,sum(jieyu+salemoney-kuan+backmoney+kuanadjust) AS realmoney from 
                                             (
                                            select admin_user_name,user_name,user_id,jieyu,0 as salemoney,0 as kuan,0 as backmoney,0 as kuanadjust from ecs_users
                                            union all
                                            select f.admin_user_name,'' as user_name,f.user_id,0 as jieyu,sum(d.tt+shipping_fee)  as salemoney , 0 as kuan,0 as backmoney,0 as kuanadjust   
                                            from ecs_order_info as f left join (
                                            select ab.order_id,ab.user_id,sum(tt) as tt from (
                                            select  o.order_id ,o.user_id,g.goods_number,g.goods_price,(g.goods_number* g.goods_price) as tt
                                            from ecs_order_info as o inner join ecs_order_goods as g on o.order_id=g.order_id where order_status !=9 and shipping_status=1 and erp_order_sn<>'' and erp_time  between UNIX_TIMESTAMP('{0}') and  UNIX_TIMESTAMP('{1}')
                                            ) as ab group by ab.order_id) as d on f.order_id=d.order_id 
                                            where f.order_status !=9 and f.shipping_status=1 and f.erp_order_sn<>'' and f.erp_time  between UNIX_TIMESTAMP('{0}') and  UNIX_TIMESTAMP('{1}') 
                                            group by d.user_id 
                                            union all 
                                            select jiefang as admin_user_name,'',user_id,0 as jieyu, 0 as salemoney,daifang as kuan,0 as backmoney,0 as kuanadjust  from ecs_kuan where jzdate>'{0}' and  jytime>'{0}' 
                                             union all    
                                            select xm as admin_user_name,'',dwmc as user_id, 0 as jieyu,0 as salemoney,0 as kuan,d.je as backmoney, 0 as kuanadjust from djkck as d   inner join xlkck as x on x.djhm=d.djhm  where  d.rq between '{0}' and  '{1}'  and d.je < 0 and date(d.RQ)<'2016-8-24 00:00:00'  
                                            union all 
                                            select admin_user_name,'',user_id, 0 as jieyu,0 as salemoney,0 as kuan, cast(ret_money_total as decimal(18,2)) as backmoney,0 as kuanadjust  from ecs_return_order as e   where  erp_time  between 1471968000 and UNIX_TIMESTAMP('{1}')  and e.ret_money_total<0  
                                            union all
                                            select admin_id as admin_user_name, '',user_id,0 as jieyu,0 as salemoney, 0 as kuan ,0 as backmoney,change_total as kuanadjust  from ecs_kuan_adjust where date_time between  UNIX_TIMESTAMP('{0}') and  UNIX_TIMESTAMP('{1}')
                                            )AS abc group by user_id ) as nn where nn.realmoney>0)", strStartYear, strEnd);

            int rows = DbHelperMySQL.ExecuteSql(strSQL);
            #endregion  ========================================================================
        }

        #endregion

        //不抓的客服的客户;type=5
        public void SetCustomer_Employee(string strFactory)
        {
            string strSQL = string.Format(@"update crm_set_grabcustomer_flow set type =5 where CustomerId in
                                    (select c.id from crm_set_grabcustomer_protect as p inner join crm_customer as c on p.emp_Id=c.BeSeats_id where c.factory_id={0})", strFactory);

            int rows = DbHelperMySQL.ExecuteSql(strSQL);
        }
        #endregion

        #region //执行抓数据
        public void SetDoAction()
        {
            //根据客服分组一次执行
            //type=0，客户部所属的客户；转为公客
            string strSQLDo = string.Empty; //执行操作SQL
            string strSQL = string.Format(@"select distinct BeSeats_id,BeSeats_uid,BeSeats from crm_customer where factory_id=1000");
            DataTable dt = DbHelperMySQL.GetDataTable(strSQL);
            string strFactoryId = "1000";
            string isEmpId = ConfigurationManager.AppSettings["empId"].ToString().Trim();
            switch (isEmpId.Trim())
            {
                case "-1":  //不执行
                    break;
                case "0":   //执行全部
                    foreach (DataRow item in dt.Rows)
                    {
                        //客服Id
                        string strEmpId = item["BeSeats_id"].ToString();
                        strSQLDo = string.Format(@"UPDATE crm_customer c INNER JOIN 
                                (select CustomerId from crm_set_grabcustomer_flow as f where f.factory_id={0} and f.type=0 and BeSeats_empId={1} ) s ON s.CustomerId=c.id and c.factory_id ={0}
                                set c.privatecustomer_Id=51,c.privatecustomer='公客';", strFactoryId, strEmpId);

                        int rows = DbHelperMySQL.ExecuteSql(strSQLDo.ToString());
                    }
                    break;
                default:    //执行当前员工
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["BeSeats_id"].ToString().Trim() == isEmpId)
                        {
                            //客服Id
                            string strEmpId = item["BeSeats_id"].ToString();
                            strSQLDo = string.Format(@"UPDATE crm_customer c INNER JOIN 
                                (select CustomerId from crm_set_grabcustomer_flow as f where f.factory_id={0} and f.type=0 and BeSeats_empId={1} ) s ON s.CustomerId=c.id and c.factory_id ={0}
                                set c.privatecustomer_Id=51,c.privatecustomer='公客';", strFactoryId, strEmpId);

                            int rows = DbHelperMySQL.ExecuteSql(strSQLDo.ToString());
                            break;
                        }
                    }
                    break;
            }
        }
        #endregion

        #region 辅助方法
        #region 获取部门 SQL查询语句：X,X,X,X,X样式
        public string GetDeptNextAll()
        {
            XHD.BLL.hr_department dep = new XHD.BLL.hr_department();
            DataSet ds = dep.GetAllList("Factory_Id='1000'");
            string deptaskAll = GetDepTask(1, ds.Tables[0]);
            return deptaskAll;
        }

        //获取部门，递归函数--临时
        private string GetDepTask(int Id, DataTable table)
        {
            DataRow[] rows = table.Select("parentid=" + Id.ToString());

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                str.Append(row["id"] + ",");
                if (GetDepTask((int)row["id"], table).Length > 0)
                    str.Append(GetDepTask((int)row["id"], table));
            }
            return str.ToString();
        }
        #endregion

        #endregion
    }
}