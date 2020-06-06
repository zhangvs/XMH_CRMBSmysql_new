using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using XHD.Common;//Please add references

namespace XHD.DAL.ims
{
    /// <summary>
    /// 数据访问类:ims_complaint_points
    /// </summary>
    public partial class ims_complaint_points
    {
        public ims_complaint_points()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "ims_complaint_points");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ims_complaint_points");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ims.ims_complaint_points model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ims_complaint_points(");
            strSql.Append("id,apply_empId,apply_empName,apply_managerId,apply_managerName,sued_empId,sued_empName,sued_managerId,sued_managerName,sued_data,sued_remark,hand_empId,hand_empName,deal_date,hand_data,hand_remark,state)");
            strSql.Append(" values (");
            strSql.Append("@id,@apply_empId,@apply_empName,@apply_managerId,@apply_managerName,@sued_empId,@sued_empName,@sued_managerId,@sued_managerName,@sued_data,@sued_remark,@hand_empId,@hand_empName,@deal_date,@hand_data,@hand_remark,@state)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_empName", MySqlDbType.VarChar,50),
					new MySqlParameter("@apply_managerId", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_managerName", MySqlDbType.VarChar,50),
					new MySqlParameter("@sued_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@sued_empName", MySqlDbType.VarChar,50),
					new MySqlParameter("@sued_managerId", MySqlDbType.Int32,11),
					new MySqlParameter("@sued_managerName", MySqlDbType.VarChar,50),
					new MySqlParameter("@sued_data", MySqlDbType.DateTime),
					new MySqlParameter("@sued_remark", MySqlDbType.VarChar,500),
					new MySqlParameter("@hand_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@hand_empName", MySqlDbType.VarChar,50),
					new MySqlParameter("@deal_date", MySqlDbType.DateTime),
					new MySqlParameter("@hand_data", MySqlDbType.DateTime),
					new MySqlParameter("@hand_remark", MySqlDbType.VarChar,500),
					new MySqlParameter("@state", MySqlDbType.VarChar,1)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.apply_empId;
            parameters[2].Value = model.apply_empName;
            parameters[3].Value = model.apply_managerId;
            parameters[4].Value = model.apply_managerName;
            parameters[5].Value = model.sued_empId;
            parameters[6].Value = model.sued_empName;
            parameters[7].Value = model.sued_managerId;
            parameters[8].Value = model.sued_managerName;
            parameters[9].Value = model.sued_data;
            parameters[10].Value = model.sued_remark;
            parameters[11].Value = model.hand_empId;
            parameters[12].Value = model.hand_empName;
            parameters[13].Value = model.deal_date;
            parameters[14].Value = model.hand_data;
            parameters[15].Value = model.hand_remark;
            parameters[16].Value = model.state;

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
        public bool Update(XHD.Model.ims.ims_complaint_points model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ims_complaint_points set ");
            strSql.Append("apply_empId=@apply_empId,");
            strSql.Append("apply_empName=@apply_empName,");
            strSql.Append("apply_managerId=@apply_managerId,");
            strSql.Append("apply_managerName=@apply_managerName,");
            strSql.Append("sued_empId=@sued_empId,");
            strSql.Append("sued_empName=@sued_empName,");
            strSql.Append("sued_managerId=@sued_managerId,");
            strSql.Append("sued_managerName=@sued_managerName,");
            strSql.Append("sued_data=@sued_data,");
            strSql.Append("sued_remark=@sued_remark,");
            strSql.Append("hand_empId=@hand_empId,");
            strSql.Append("hand_empName=@hand_empName,");
            strSql.Append("deal_date=@deal_date,");
            strSql.Append("hand_data=@hand_data,");
            strSql.Append("hand_remark=@hand_remark,");
            strSql.Append("state=@state");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@apply_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_empName", MySqlDbType.VarChar,50),
					new MySqlParameter("@apply_managerId", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_managerName", MySqlDbType.VarChar,50),
					new MySqlParameter("@sued_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@sued_empName", MySqlDbType.VarChar,50),
					new MySqlParameter("@sued_managerId", MySqlDbType.Int32,11),
					new MySqlParameter("@sued_managerName", MySqlDbType.VarChar,50),
					new MySqlParameter("@sued_data", MySqlDbType.DateTime),
					new MySqlParameter("@sued_remark", MySqlDbType.VarChar,500),
					new MySqlParameter("@hand_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@hand_empName", MySqlDbType.VarChar,50),
					new MySqlParameter("@deal_date", MySqlDbType.DateTime),
					new MySqlParameter("@hand_data", MySqlDbType.DateTime),
					new MySqlParameter("@hand_remark", MySqlDbType.VarChar,500),
					new MySqlParameter("@state", MySqlDbType.VarChar,1),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.apply_empId;
            parameters[1].Value = model.apply_empName;
            parameters[2].Value = model.apply_managerId;
            parameters[3].Value = model.apply_managerName;
            parameters[4].Value = model.sued_empId;
            parameters[5].Value = model.sued_empName;
            parameters[6].Value = model.sued_managerId;
            parameters[7].Value = model.sued_managerName;
            parameters[8].Value = model.sued_data;
            parameters[9].Value = model.sued_remark;
            parameters[10].Value = model.hand_empId;
            parameters[11].Value = model.hand_empName;
            parameters[12].Value = model.deal_date;
            parameters[13].Value = model.hand_data;
            parameters[14].Value = model.hand_remark;
            parameters[15].Value = model.state;
            parameters[16].Value = model.id;

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
            strSql.Append("delete from ims_complaint_points ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
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
            strSql.Append("delete from ims_complaint_points ");
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

        //受理
        public bool UpdateState(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" update ims_complaint_points set state='1',deal_date='" + DateTime.Now + "' where id='" + id + "' ");
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

        //受理完成
        public bool finish(int id, string remark, DataSet ds, Model.ims.ims_emp_score modelScore, string scoreApply, string score)
        {
            hr_employee emp = new hr_employee();
            Personal_Score pscore = new Personal_Score();
            Model.Personal_Score model = new Model.Personal_Score();

            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            strSql = string.Format(@"update ims_complaint_points set state='{0}',hand_data='{1}',hand_remark='{2}' where id='{3}'",2,DateTime.Now,remark,id);
            strSqlList.Add(strSql);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                //被投诉人
                if (score != "0")
                {
                    strSql = string.Format(@"insert into  ims_emp_score(Factory_Id,d_id,d_name,emp_id,emp_name,rule_id,rule_name,isPlus,score,check_empId,check_empName,check_date,check_remark,score_source,complaint_id) 
                                   values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                                         modelScore.Factory_Id, int.Parse(ds.Tables[0].Rows[0]["d_id"].ToString()), ds.Tables[0].Rows[0]["dname"].ToString(),
                                         int.Parse(ds.Tables[0].Rows[0]["sued_empId"].ToString()), ds.Tables[0].Rows[0]["sued_empName"].ToString(), modelScore.rule_id, modelScore.rule_name,
                                         modelScore.isPlus, Convert.ToDecimal(PageValidate.InputText("-" + score, 16)), modelScore.check_empId, modelScore.check_empName,
                                         modelScore.check_date, modelScore.check_remark, modelScore.score_source,id);
                    strSqlList.Add(strSql);
                }

                //申请人
                if (scoreApply != "0")
                {
                    DataSet de = emp.GetList("ID='" + ds.Tables[0].Rows[0]["apply_empId"].ToString() + "'");
                    if (de != null & de.Tables[0].Rows.Count > 0)
                    {
                        strSql = string.Format(@"insert into  ims_emp_score(Factory_Id,d_id,d_name,emp_id,emp_name,rule_id,rule_name,isPlus,score,check_empId,check_empName,check_date,check_remark,score_source,complaint_id) 
                                   values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                                                              modelScore.Factory_Id, int.Parse(de.Tables[0].Rows[0]["d_id"].ToString()), de.Tables[0].Rows[0]["dname"].ToString(),
                                                              int.Parse(ds.Tables[0].Rows[0]["apply_empId"].ToString()), ds.Tables[0].Rows[0]["apply_empName"].ToString(), modelScore.rule_id, modelScore.rule_name,
                                                              modelScore.isPlus, Convert.ToDecimal(PageValidate.InputText("-" + scoreApply, 16)), modelScore.check_empId,
                                                              modelScore.check_empName, modelScore.check_date, modelScore.check_remark, modelScore.score_source,id);
                        strSqlList.Add(strSql);
                    }                    
                }
            }

           

            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //StringBuilder strSql = new StringBuilder();
            //strSql.Append(" update ims_complaint_points set state='2',hand_data='" + DateTime.Now + "',hand_remark='" + remark + "' where id='" + id + "' ");
            //int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            //if (rows > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ims.ims_complaint_points GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,apply_empId,apply_empName,apply_managerId,apply_managerName,sued_empId,sued_empName,sued_managerId,sued_managerName,sued_data,sued_remark,hand_empId,hand_empName,deal_date,hand_data,hand_remark,state from ims_complaint_points ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.ims.ims_complaint_points model = new XHD.Model.ims.ims_complaint_points();
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
        public XHD.Model.ims.ims_complaint_points DataRowToModel(DataRow row)
        {
            XHD.Model.ims.ims_complaint_points model = new XHD.Model.ims.ims_complaint_points();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["apply_empId"] != null && row["apply_empId"].ToString() != "")
                {
                    model.apply_empId = int.Parse(row["apply_empId"].ToString());
                }
                if (row["apply_empName"] != null)
                {
                    model.apply_empName = row["apply_empName"].ToString();
                }
                if (row["apply_managerId"] != null && row["apply_managerId"].ToString() != "")
                {
                    model.apply_managerId = int.Parse(row["apply_managerId"].ToString());
                }
                if (row["apply_managerName"] != null)
                {
                    model.apply_managerName = row["apply_managerName"].ToString();
                }
                if (row["sued_empId"] != null && row["sued_empId"].ToString() != "")
                {
                    model.sued_empId = int.Parse(row["sued_empId"].ToString());
                }
                if (row["sued_empName"] != null)
                {
                    model.sued_empName = row["sued_empName"].ToString();
                }
                if (row["sued_managerId"] != null && row["sued_managerId"].ToString() != "")
                {
                    model.sued_managerId = int.Parse(row["sued_managerId"].ToString());
                }
                if (row["sued_managerName"] != null)
                {
                    model.sued_managerName = row["sued_managerName"].ToString();
                }
                if (row["sued_data"] != null && row["sued_data"].ToString() != "")
                {
                    model.sued_data = DateTime.Parse(row["sued_data"].ToString());
                }
                if (row["sued_remark"] != null)
                {
                    model.sued_remark = row["sued_remark"].ToString();
                }
                if (row["hand_empId"] != null && row["hand_empId"].ToString() != "")
                {
                    model.hand_empId = int.Parse(row["hand_empId"].ToString());
                }
                if (row["hand_empName"] != null)
                {
                    model.hand_empName = row["hand_empName"].ToString();
                }
                if (row["deal_date"] != null && row["deal_date"].ToString() != "")
                {
                    model.deal_date = DateTime.Parse(row["deal_date"].ToString());
                }
                if (row["hand_data"] != null && row["hand_data"].ToString() != "")
                {
                    model.hand_data = DateTime.Parse(row["hand_data"].ToString());
                }
                if (row["hand_remark"] != null)
                {
                    model.hand_remark = row["hand_remark"].ToString();
                }
                if (row["state"] != null)
                {
                    model.state = row["state"].ToString();
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
            strSql.Append("select id,apply_empId,apply_empName,apply_managerId,apply_managerName,sued_empId,sued_empName,sued_managerId,sued_managerName,sued_data,sued_remark,hand_empId,hand_empName,deal_date,hand_data,hand_remark,state ");
            strSql.Append(" FROM ims_complaint_points ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetLists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select e.d_id,e.dname,e.name, c.id,c.apply_empId,c.apply_empName,c.apply_managerId,c.apply_managerName,c.sued_empId,c.sued_empName,c.sued_managerId,c.sued_managerName,c.sued_data,c.sued_remark,c.hand_empId,c.hand_empName,c.deal_date,c.hand_data,c.hand_remark,c.state ");
            strSql.Append(" FROM ims_complaint_points c inner join hr_employee e on c.sued_empId=e.ID");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取我的申请投诉及被投诉数据列表
        /// </summary>
        public DataSet GetListApply(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select id,apply_empId,apply_empName,apply_managerId,apply_managerName,sued_empId,sued_empName,sued_managerId,sued_managerName,sued_data,sued_remark,hand_empId,hand_empName,deal_date,hand_data,hand_remark,state  ");
            strSql.Append(" FROM ims_complaint_points ");

            strSql1.Append(" select count(id)  FROM ims_complaint_points ");
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
        /// 分页获取投诉数据列表
        /// </summary>
        public DataSet GetListApprove(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select id,apply_empId,apply_empName,apply_managerId,apply_managerName,sued_empId,sued_empName,sued_managerId,sued_managerName,sued_data,sued_remark,hand_empId,hand_empName,deal_date,hand_data,hand_remark,state ");
            strSql.Append(" FROM ims_complaint_points ");

            strSql1.Append(" select count(id)  FROM ims_complaint_points ");
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


