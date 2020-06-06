/**  版本信息模板在安装目录下，可自行修改。
* Personal_Score.cs
*
* 功 能： N/A
* 类 名： Personal_Score
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/10/6 14:04:41   N/A    初版
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
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;
using System.Collections.Generic;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:Personal_Score
    /// </summary>
    public partial class Personal_Score
    {
        public Personal_Score()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "Personal_Score");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Personal_Score");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsDate(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Personal_Score");
            strSql.Append(" where " + strWhere);

            return DbHelperMySQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 查询积分
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public string GetScore(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Score from Personal_Score");
            strSql.Append(" where " + strWhere);

            return DbHelperMySQL.GetSingles(strSql.ToString()).ToString();
        }

        /// <summary>
        /// 查询内容
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public string GetContent(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Content from Personal_Score");
            strSql.Append(" where " + strWhere);

            return DbHelperMySQL.GetSingles(strSql.ToString()).ToString();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int top)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from (select SUM(score)as sumScore,ItemName,username,userid,DtypeId,DtypeName from Personal_Score group by username,DtypeId,DtypeName,ItemName,userid)a  limit 10");
            //SqlParameter[] parameters = {
            //        new SqlParameter("@top",SqlDbType.Int)
            //        };
            //parameters[0].Value = top;
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.Personal_Score model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Personal_Score(");
            strSql.Append("Factory_Id,DtypeName,DtypeId,UserName,UserId,ItemName,ItemId,Content,IsTure,Score,OperationName,OperationId,CreateDate,Item_StandardId)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@DtypeName,@DtypeId,@UserName,@UserId,@ItemName,@ItemId,@Content,@IsTure,@Score,@OperationName,@OperationId,@CreateDate,@Item_StandardId)");
            strSql.Append(";select @@IDENTITY");

            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@DtypeName", MySqlDbType.VarChar,50),
					new MySqlParameter("@DtypeId", MySqlDbType.Int32,11),
					new MySqlParameter("@UserName", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserId", MySqlDbType.Int32,11),
					new MySqlParameter("@ItemName", MySqlDbType.VarChar,50),
					new MySqlParameter("@ItemId", MySqlDbType.Int32,11),
					new MySqlParameter("@Content", MySqlDbType.Text),
					new MySqlParameter("@IsTure", MySqlDbType.VarChar,1),
					new MySqlParameter("@Score", MySqlDbType.Decimal,16),
					new MySqlParameter("@OperationName", MySqlDbType.VarChar,50),
					new MySqlParameter("@OperationId", MySqlDbType.Int32,11),
					new MySqlParameter("@CreateDate", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Item_StandardId",MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.DtypeName;
            parameters[2].Value = model.DtypeId;
            parameters[3].Value = model.UserName;
            parameters[4].Value = model.UserId;
            parameters[5].Value = model.ItemName;
            parameters[6].Value = model.ItemId;
            parameters[7].Value = model.Content;
            parameters[8].Value = model.IsTure;
            parameters[9].Value = model.Score;
            parameters[10].Value = model.OperationName;
            parameters[11].Value = model.OperationId;
            parameters[12].Value = model.CreateDate;
            parameters[13].Value = model.Item_StandardId;

            object obj = DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        /// 增加积分
        /// </summary>
        public bool AddScore(XHD.Model.Personal_Score model, DataTable dt)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            int scoreTotal = 0;


            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    scoreTotal += Convert.ToInt32(dt.Rows[i]["standardScore"].ToString());

                    strSql = string.Format(@" insert into Personal_Score(Factory_Id,DtypeName,DtypeId,UserName,UserId,ItemName,ItemId,Item_StandardId,Content,IsTure,Score,OperationName,OperationId,CreateDate) 
                                                 values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                                                 model.Factory_Id, model.DtypeName, model.DtypeId, model.UserName, model.UserId, model.ItemName, model.ItemId, Convert.ToInt32(dt.Rows[i]["standardId"].ToString()),
                                                 model.Content, model.IsTure, Convert.ToDecimal(dt.Rows[i]["standardScore"].ToString()), model.OperationName, model.OperationId, model.CreateDate);

                    strSqlList.Add(strSql);
                }
            }

            strSql = string.Format(@" insert into Personal_Score(Factory_Id,DtypeName,DtypeId,UserName,UserId,ItemName,ItemId,Item_StandardId,Content,IsTure,Score,OperationName,OperationId,CreateDate) 
                                      values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                              model.Factory_Id, model.DtypeName, model.DtypeId, model.UserName, model.UserId, model.ItemName, model.ItemId, "",
                              model.Content, model.IsTure, scoreTotal, model.OperationName, model.OperationId, model.CreateDate);

            strSqlList.Add(strSql);


            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
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
        /// 修改积分
        /// </summary>
        public bool AlertScore(XHD.Model.Personal_Score model, List<Model.Personal_Score> lstScore, DataTable dt)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            int scoreTotal = 0;

            if (lstScore != null )
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string s = dt.Rows[i]["standardId"].ToString();

                        Model.Personal_Score parm = lstScore.Find(delegate(Model.Personal_Score p) { return p.Item_StandardId == Convert.ToInt32(dt.Rows[i]["standardId"].ToString()); }) as Model.Personal_Score;

                        scoreTotal += Convert.ToInt32(dt.Rows[i]["standardScore"].ToString());

                        strSql = string.Format(@" update Personal_Score set Factory_Id='{0}',DtypeName='{1}',DtypeId='{2}',UserName='{3}',UserId='{4}',ItemName='{5}',ItemId='{6}',
                                              Item_StandardId='{7}',Content='{8}',IsTure='{9}',Score='{10}',OperationName='{11}',OperationId='{12}',CreateDate='{13}' where Id='{14}'",
                                                     model.Factory_Id, model.DtypeName, model.DtypeId, model.UserName, model.UserId, model.ItemName, model.ItemId, Convert.ToInt32(dt.Rows[i]["standardId"].ToString()),
                                                     model.Content, model.IsTure, Convert.ToDecimal(dt.Rows[i]["standardScore"].ToString()), model.OperationName, model.OperationId, model.CreateDate,parm.Id);

                        strSqlList.Add(strSql);
                    }
                }
            }
            else
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        scoreTotal += Convert.ToInt32(dt.Rows[i]["standardScore"].ToString());

                        strSql = string.Format(@" insert into Personal_Score(Factory_Id,DtypeName,DtypeId,UserName,UserId,ItemName,ItemId,Item_StandardId,Content,IsTure,Score,OperationName,OperationId,CreateDate) 
                                                 values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                                                     model.Factory_Id, model.DtypeName, model.DtypeId, model.UserName, model.UserId, model.ItemName, model.ItemId, Convert.ToInt32(dt.Rows[i]["standardId"].ToString()),
                                                     model.Content, model.IsTure, Convert.ToDecimal(dt.Rows[i]["standardScore"].ToString()), model.OperationName, model.OperationId, model.CreateDate);

                        strSqlList.Add(strSql);
                    }
                }
            }
           

            strSql = string.Format(@" update Personal_Score set Factory_Id='{0}',DtypeName='{1}',DtypeId='{2}',UserName='{3}',UserId='{4}',ItemName='{5}',ItemId='{6}',
                                      Item_StandardId='{7}',Content='{8}',IsTure='{9}',Score='{10}',OperationName='{11}',OperationId='{12}',CreateDate='{13}' where Id='{14}'",
                              model.Factory_Id, model.DtypeName, model.DtypeId, model.UserName, model.UserId, model.ItemName, model.ItemId, "",
                              model.Content, model.IsTure, scoreTotal, model.OperationName, model.OperationId, model.CreateDate, model.Id);

            strSqlList.Add(strSql);


            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.Personal_Score model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Personal_Score set ");
            strSql.Append("DtypeName=@DtypeName,");
            strSql.Append("DtypeId=@DtypeId,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("UserId=@UserId,");
            strSql.Append("ItemName=@ItemName,");
            strSql.Append("ItemId=@ItemId,");
            strSql.Append("Content=@Content,");
            strSql.Append("IsTure=@IsTure,");
            strSql.Append("Score=@Score,");
            strSql.Append("OperationName=@OperationName,");
            strSql.Append("OperationId=@OperationId,");
            strSql.Append("CreateDate=@CreateDate");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@DtypeName", MySqlDbType.VarChar,50),
					new MySqlParameter("@DtypeId", MySqlDbType.Int32,11),
					new MySqlParameter("@UserName", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserId", MySqlDbType.Int32,11),
					new MySqlParameter("@ItemName", MySqlDbType.VarChar,50),
					new MySqlParameter("@ItemId", MySqlDbType.Int32,11),
					new MySqlParameter("@Content", MySqlDbType.Text),
					new MySqlParameter("@IsTure", MySqlDbType.VarChar,1),
					new MySqlParameter("@Score", MySqlDbType.Decimal,16),
					new MySqlParameter("@OperationName", MySqlDbType.VarChar,50),
					new MySqlParameter("@OperationId", MySqlDbType.Int32,11),
					new MySqlParameter("@CreateDate", MySqlDbType.VarChar,50),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.DtypeName;
            parameters[1].Value = model.DtypeId;
            parameters[2].Value = model.UserName;
            parameters[3].Value = model.UserId;
            parameters[4].Value = model.ItemName;
            parameters[5].Value = model.ItemId;
            parameters[6].Value = model.Content;
            parameters[7].Value = model.IsTure;
            parameters[8].Value = model.Score;
            parameters[9].Value = model.OperationName;
            parameters[10].Value = model.OperationId;
            parameters[11].Value = model.CreateDate;
            parameters[12].Value = model.Id;

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
        /// 修改积分
        /// </summary>
        /// <param name="id"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public bool Alert(int id, string score, string content)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Personal_Score set ");
            strSql.Append("Score=@Score,");
            strSql.Append("Content=@Content");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Score", MySqlDbType.Decimal,16),
                    new MySqlParameter("@Content", MySqlDbType.Text),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = score;
            parameters[1].Value = content;
            parameters[2].Value = id;

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
            strSql.Append("delete from Personal_Score ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Personal_Score ");
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
        public XHD.Model.Personal_Score GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  Id,Factory_Id,DtypeName,DtypeId,UserName,UserId,ItemName,ItemId,Content,IsTure,Score,OperationName,OperationId,CreateDate from Personal_Score ");
            strSql.Append(" where Id=@Id  limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)
			};
            parameters[0].Value = Id;

            XHD.Model.Personal_Score model = new XHD.Model.Personal_Score();
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
        public XHD.Model.Personal_Score DataRowToModel(DataRow row)
        {
            XHD.Model.Personal_Score model = new XHD.Model.Personal_Score();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["DtypeName"] != null)
                {
                    model.DtypeName = row["DtypeName"].ToString();
                }
                if (row["DtypeId"] != null && row["DtypeId"].ToString() != "")
                {
                    model.DtypeId = int.Parse(row["DtypeId"].ToString());
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["UserId"] != null && row["UserId"].ToString() != "")
                {
                    model.UserId = int.Parse(row["UserId"].ToString());
                }
                if (row["ItemName"] != null)
                {
                    model.ItemName = row["ItemName"].ToString();
                }
                if (row["ItemId"] != null && row["ItemId"].ToString() != "")
                {
                    model.ItemId = int.Parse(row["ItemId"].ToString());
                }
                if (row["Content"] != null)
                {
                    model.Content = row["Content"].ToString();
                }
                if (row["IsTure"] != null)
                {
                    model.IsTure = row["IsTure"].ToString();
                }
                if (row["Score"] != null && row["Score"].ToString() != "")
                {
                    model.Score = decimal.Parse(row["Score"].ToString());
                }
                if (row["OperationName"] != null)
                {
                    model.OperationName = row["OperationName"].ToString();
                }
                if (row["OperationId"] != null && row["OperationId"].ToString() != "")
                {
                    model.OperationId = int.Parse(row["OperationId"].ToString());
                }
                if (row["CreateDate"] != null)
                {
                    model.CreateDate = row["CreateDate"].ToString();
                }
                if (row["Item_StandardId"] != null && row["Item_StandardId"].ToString() != "")
                {
                    model.Item_StandardId = int.Parse(row["Item_StandardId"].ToString());
                }
            }
            return model;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public string getSumScore(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum(score) as score ");
            strSql.Append(" FROM Personal_Score ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetSearch2(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select DtypeName,DtypeId,sum(score)as summ, UserName,Userid,Factory_id,CreateDate ");
            strSql.Append(" from personal_score  ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Personal_Score ");
            //strSql.Append(" where " + strWhere + " order by Id ) ");
            strSql1.Append(" select count(distinct userid) FROM Personal_Score  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" group by UserId");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);

            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" * FROM Personal_Score ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Personal_Score ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM Personal_Score ");
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Factory_Id,DtypeName,DtypeId,UserName,UserId,ItemName,ItemId,Content,IsTure,Score,OperationName,OperationId,CreateDate,Item_StandardId ");
            strSql.Append(" FROM Personal_Score ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
     
        /// <summary>
        ///获取打分人员
        /// </summary>
        public DataSet GetOperationInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select OperationId,DtypeName,DtypeId,OperationName,count(userid) sumNum ");
            strSql.Append("from( select distinct userid,username, DtypeId,DtypeName,OperationId,OperationName from personal_score ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(") a group by OperationId,DtypeId ");
            strSql.Append("order by DtypeId ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        ///按打分人获取人员
        /// </summary>
        public DataSet GetUserInfo(string strWhere, string groupstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Factory_Id,DtypeName,DtypeId,UserName,UserId,ItemName,ItemId,Content,IsTure,Score,OperationName,OperationId,CreateDate from personal_score,Item_StandardId ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" group by " + groupstr);
            strSql.Append(" order by DtypeId ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListPersonalScoreImg(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select P.Id,DtypeName,DtypeId,UserName,UserId,ItemName,P.ItemId,Content,IsTure,Score,OperationName,OperationId,P.CreateDate,imgUrl");
            strSql.Append(" from Personal_Score   P join ImagerForScore I on P.Id=I.itemId   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");

            strSql.Append(" Id,Factory_Id,DtypeName,DtypeId,UserName,UserId,ItemName,ItemId,Content,IsTure,Score,OperationName,OperationId,CreateDate,Item_StandardId ");
            strSql.Append(" FROM Personal_Score ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Personal_Score ");
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
            strSql.Append(")AS Row, T.*  from Personal_Score T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 分页获取数据列表ScoreImageModel
        /// </summary>
        public DataSet GetListByPageForPhone(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  * FROM Personal_Score   P join ImagerForScore I on P.Id=I.itemId ");
            //strSql.Append(" WHERE P.id not in ( SELECT top " + PageIndex + " id FROM Personal_Score ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(P.id) FROM Personal_Score   P join ImagerForScore I on P.Id=I.itemId ");
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetSearch(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select s.sumScore,s.UserName,s.UserId,DATE_FORMAT(s.CreateDate,'%Y')as yearCreate,DATE_FORMAT(s.CreateDate,'%m' )as mouthCreate from hr_employee as e right join ");
            strSql.Append(" (select sum(score)as sumScore, userName,Userid,Factory_id,CreateDate ");
            strSql.Append(" from personal_score  ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Personal_Score ");
            //strSql.Append(" where " + strWhere + " order by Id ) ");
            strSql1.Append(" select count(distinct userid) FROM Personal_Score  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" group by userName,Userid,Factory_id,DATE_FORMAT(CreateDate,'%Y' ),DATE_FORMAT(CreateDate,'%m' )");
            strSql.Append(" ) as s on  e.id=s.userid");

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);

            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
