using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
using XHD.Common;

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_order_feat
    /// </summary>
    public partial class crm_order_feat
    {
        public crm_order_feat()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_order_feat");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_order_feat model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_order_feat(");
            strSql.Append("factory_Id,emp_code,order_feat,customer_Id,customer_name,customer_Id_shop,customer_name_shop,create_date,create_id)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@emp_code,@order_feat,@customer_Id,@customer_name,@customer_Id_shop,@customer_name_shop,@create_date,@create_id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@order_feat", MySqlDbType.Float,20),
					new MySqlParameter("@customer_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@customer_Id_shop", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_name_shop", MySqlDbType.VarChar,100),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.emp_code;
            parameters[2].Value = model.order_feat;
            parameters[3].Value = model.customer_Id;
            parameters[4].Value = model.customer_name;
            parameters[5].Value = model.customer_Id_shop;
            parameters[6].Value = model.customer_name_shop;
            parameters[7].Value = model.create_date;
            parameters[8].Value = model.create_id;

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
        /// 向临时表增添数据
        /// </summary>
        public bool Add(XHD.Model.crm_set_pripub_detail model)
        {
            // ConvertIntDateTime

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Insert Into crm_order_feat (factory_Id,emp_code,order_feat,customer_Id,customer_Id_shop,customer_name_shop,customer_name,create_date,create_id)");
            strSql.Append(" select '" + model.factory_Id + "',abc.emp_code, abc.tall,c.id,abc.user_id,");
            strSql.Append(" abc.user_name,c.customer,'" + model.C_createDate + "','" + model.C_createId + "'  from ");
            strSql.Append(" crm_customer as c inner join crm_contact as l on c.id=l.C_Customerid");
            strSql.Append(" inner join ");
            strSql.Append(" (select e.emp_code,e.name,e.dname,e.post,o.order_status,");
            strSql.Append(" o.user_id,u.user_name,sum( o.goods_amount+o.shipping_fee) as tall");
            strSql.Append(" from hr_employee as e inner join ecs_order_info as o on e.emp_code=o.admin_user_name and o.order_status =1");
            strSql.Append(" and o.confirm_time  between " + model.date_start + " and " + model.date_end);
            strSql.Append(" left join ecs_users as u on o.user_id=u.user_id ");
            strSql.Append(" group by e.emp_code,e.name,e.dname,e.post,o.user_id,u.user_name");
            strSql.Append(" ) as abc on l.C_tel=abc.user_name ");
            strSql.Append(" where c.factory_id='" + model.factory_Id + "'");

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
        /// 向临时表增添数据
        /// </summary>
        public int AddNew(XHD.Model.crm_set_pripub_detail model)
        {
            DateTime startdata = XHD.Common.TimeParser.ConvertIntDateTime(Convert.ToDouble(model.date_start));
            DateTime enddata = XHD.Common.TimeParser.ConvertIntDateTime(Convert.ToDouble(model.date_end));

            
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Insert Into crm_order_feat (factory_Id,emp_code,order_feat,sales_return,customer_Id,customer_Id_shop,customer_name_shop,customer_name,create_date,create_id)");
            //strSql.Append(" Insert Into crm_order_feat (factory_Id,emp_code,order_feat,sales_return,customer_Id,customer_Id_shop,customer_name_shop,customer_name,create_date,create_id)");
            //strSql.Append(" select '" + model.factory_Id + "',abc.emp_code, abc.tall,abc.returnNum,c.id,abc.user_id,");
            //strSql.Append(" abc.user_name,c.customer,'" + model.C_createDate + "','" + model.C_createId + "'  from ");
            //strSql.Append(" crm_customer as c inner join crm_contact as l on c.id=l.C_Customerid");
            //strSql.Append(" inner join ");
            //strSql.Append(" (select e.emp_code,e.name,e.dname,e.post,o.order_status,");
            //strSql.Append(" o.user_id,u.user_name,sum( o.goods_amount+o.shipping_fee) as tall,sum(xd.JE) as returnNum");
            //strSql.Append(" from hr_employee as e inner join ecs_order_info as o on e.emp_code=o.admin_user_name and e.factory_id='" + model.factory_Id + "' and o.order_status !=9");
            //strSql.Append(" and o.erp_time  between " + model.date_start + " and " + model.date_end);

            //strSql.Append(" left join (select distinct x.* from XLKCK as x where  date(x.RQ) >='" + startdata + "' and date(x.RQ)<='" + enddata + "' and x.JE<0  and (x.BZ !='换' and x.BZ !='换货' or x.BZ is null) ) as xd on o.user_id= xd.DWMC ");

            //strSql.Append(" left join ecs_users as u on o.user_id=u.user_id ");
            //strSql.Append(" group by e.emp_code,e.name,e.dname,e.post,o.user_id,u.user_name");
            //strSql.Append(" ) as abc on l.C_tel=abc.user_name ");
            //strSql.Append(" where c.factory_id='" + model.factory_Id + "' and c.isdelete=0");

            strSql.Append(" select '" + model.factory_Id + "',	abc.admin_user_name,abc.tall,abc.returnNum,c.id,abc.user_id,abc.user_name,c.customer,'" + model.C_createDate + "','" + model.C_createId + "' ");
            strSql.Append(" from  crm_customer as c inner join crm_contact as l on c.id=l.C_Customerid inner join ( ");
            strSql.Append("  select  u.user_name,u.admin_user_name,u.user_id,sum( o.goods_amount+o.shipping_fee) as tall ,sum(xd.JE) as returnNum ");
            strSql.Append(" from ecs_users as u left join ecs_order_info as o on o.user_id=u.user_id  ");
            strSql.Append(" left join (select distinct x.* from XLKCK as x where  date(x.RQ) >='" + startdata + "' and date(x.RQ)<='" + enddata + "' and x.JE<0  and (x.BZ !='换' and x.BZ !='换货' or x.BZ is null) ) as xd on u.user_id= xd.DWMC ");
            strSql.Append(" where  o.order_status !=9 and o.erp_time  between " + model.date_start + " and " + model.date_end);
            strSql.Append(" group by u.user_name,u.admin_user_name,u.user_id ");
            strSql.Append(" ) as abc on l.C_tel=abc.user_name ");
            strSql.Append("  where c.factory_id='" + model.factory_Id + "' and c.isdelete=0 ");

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return rows;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_order_feat model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_order_feat set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("emp_code=@emp_code,");
            strSql.Append("order_feat=@order_feat,");
            strSql.Append("customer_Id=@customer_Id,");
            strSql.Append("customer_name=@customer_name,");
            strSql.Append("customer_Id_shop=@customer_Id_shop,");
            strSql.Append("customer_name_shop=@customer_name_shop,");
            strSql.Append("create_date=@create_date,");
            strSql.Append("create_id=@create_id");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@order_feat", MySqlDbType.Float,20),
					new MySqlParameter("@customer_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@customer_Id_shop", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_name_shop", MySqlDbType.VarChar,100),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.emp_code;
            parameters[2].Value = model.order_feat;
            parameters[3].Value = model.customer_Id;
            parameters[4].Value = model.customer_name;
            parameters[5].Value = model.customer_Id_shop;
            parameters[6].Value = model.customer_name_shop;
            parameters[7].Value = model.create_date;
            parameters[8].Value = model.create_id;
            parameters[9].Value = model.Id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_order_feat ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

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
        /// 删除除全部数据
        /// </summary>
        public bool Delete()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_order_feat ");

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_order_feat ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        public XHD.Model.crm_order_feat GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,emp_code,order_feat,customer_Id,customer_name,customer_Id_shop,customer_name_shop,create_date,create_id from crm_order_feat ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.crm_order_feat model = new XHD.Model.crm_order_feat();
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
        public XHD.Model.crm_order_feat DataRowToModel(DataRow row)
        {
            XHD.Model.crm_order_feat model = new XHD.Model.crm_order_feat();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["emp_code"] != null)
                {
                    model.emp_code = row["emp_code"].ToString();
                }
                if (row["order_feat"] != null && row["order_feat"].ToString() != "")
                {
                    model.order_feat = decimal.Parse(row["order_feat"].ToString());
                }
                if (row["customer_Id"] != null && row["customer_Id"].ToString() != "")
                {
                    model.customer_Id = int.Parse(row["customer_Id"].ToString());
                }
                if (row["customer_name"] != null)
                {
                    model.customer_name = row["customer_name"].ToString();
                }
                if (row["customer_Id_shop"] != null && row["customer_Id_shop"].ToString() != "")
                {
                    model.customer_Id_shop = int.Parse(row["customer_Id_shop"].ToString());
                }
                if (row["customer_name_shop"] != null)
                {
                    model.customer_name_shop = row["customer_name_shop"].ToString();
                }
                if (row["create_date"] != null && row["create_date"].ToString() != "")
                {
                    model.create_date = DateTime.Parse(row["create_date"].ToString());
                }
                if (row["create_id"] != null && row["create_id"].ToString() != "")
                {
                    model.create_id = int.Parse(row["create_id"].ToString());
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
            strSql.Append("select Id,factory_Id,emp_code,order_feat,sales_return,customer_Id,customer_name,customer_Id_shop,customer_name_shop,create_date,create_id ");
            strSql.Append(" FROM crm_order_feat ");
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
            strSql.Append("select count(1) FROM crm_order_feat ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from crm_order_feat T ");
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
            parameters[0].Value = "crm_order_feat";
            parameters[1].Value = "Id";
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

