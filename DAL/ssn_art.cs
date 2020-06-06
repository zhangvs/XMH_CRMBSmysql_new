using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ssn_art
    /// </summary>
    public partial class ssn_art
    {
        public ssn_art()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ssn_art");
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
        public int Add(XHD.Model.ssn_art model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ssn_art(");
            strSql.Append("factory_Id,Art_title,Art_title_en,Art_Menu_Id,Art_Content,image_lst,Art_order,is_del,Creater_Uid,Creater_Name,Create_Date,Creater_Id)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@Art_title,@Art_title_en,@Art_Menu_Id,@Art_Content,@image_lst,@Art_order,@is_del,@Creater_Uid,@Creater_Name,@Create_Date,@Creater_Id)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Art_title", MySqlDbType.VarChar,200),
					new MySqlParameter("@Art_title_en", MySqlDbType.VarChar,200),
					new MySqlParameter("@Art_Menu_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Art_Content", MySqlDbType.Text),
					new MySqlParameter("@image_lst", MySqlDbType.VarChar,400),
					new MySqlParameter("@Art_order", MySqlDbType.Int32,11),
					new MySqlParameter("@is_del", MySqlDbType.Int16,4),
					new MySqlParameter("@Creater_Uid", MySqlDbType.VarChar,50),
					new MySqlParameter("@Creater_Name", MySqlDbType.VarChar,20),
					new MySqlParameter("@Create_Date", MySqlDbType.DateTime),
					new MySqlParameter("@Creater_Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.Art_title;
            parameters[2].Value = model.Art_title_en;
            parameters[3].Value = model.Art_Menu_Id;
            parameters[4].Value = model.Art_Content;
            parameters[5].Value = model.image_lst;
            parameters[6].Value = model.Art_order;
            parameters[7].Value = model.is_del;
            parameters[8].Value = model.Creater_Uid;
            parameters[9].Value = model.Creater_Name;
            parameters[10].Value = model.Create_Date;
            parameters[11].Value = model.Creater_Id;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ssn_art model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_art set ");
           // strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("Art_title=@Art_title,");
            strSql.Append("Art_title_en=@Art_title_en,");
            //strSql.Append("Art_Menu_Id=@Art_Menu_Id,");
            strSql.Append("Art_Content=@Art_Content,");
            strSql.Append("image_lst=@image_lst,");
            strSql.Append("Art_order=@Art_order");
            //strSql.Append("is_del=@is_del,");
            //strSql.Append("Creater_Uid=@Creater_Uid,");
            //strSql.Append("Creater_Name=@Creater_Name,");
            //strSql.Append("Create_Date=@Create_Date,");
            //strSql.Append("Creater_Id=@Creater_Id");
            strSql.Append(" where Id=@Id and factory_Id=@factory_Id");
            MySqlParameter[] parameters = {
					//new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Art_title", MySqlDbType.VarChar,200),
					new MySqlParameter("@Art_title_en", MySqlDbType.VarChar,200),
					//new MySqlParameter("@Art_Menu_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Art_Content", MySqlDbType.Text),
					new MySqlParameter("@image_lst", MySqlDbType.VarChar,400),
					new MySqlParameter("@Art_order", MySqlDbType.Int32,11),
					//new MySqlParameter("@is_del", MySqlDbType.Int16,4),
					//new MySqlParameter("@Creater_Uid", MySqlDbType.Int32,11),
					//new MySqlParameter("@Creater_Name", MySqlDbType.VarChar,20),
					//new MySqlParameter("@Create_Date", MySqlDbType.DateTime),
					//new MySqlParameter("@Creater_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
                    new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60)};
            //parameters[0].Value = model.factory_Id;
            parameters[0].Value = model.Art_title;
            parameters[1].Value = model.Art_title_en;
            //parameters[3].Value = model.Art_Menu_Id;
            parameters[2].Value = model.Art_Content;
            parameters[3].Value = model.image_lst;
            parameters[4].Value = model.Art_order;
           // parameters[7].Value = model.is_del;
            //parameters[8].Value = model.Creater_Uid;
            //parameters[9].Value = model.Creater_Name;
           // parameters[10].Value = model.Create_Date;
           // parameters[11].Value = model.Creater_Id;
            parameters[5].Value = model.Id;
            parameters[6].Value = model.factory_Id;


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
            strSql.Append("update ssn_art  set is_del=1 ");
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
            strSql.Append("delete from ssn_art ");
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
        public XHD.Model.ssn_art GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,Art_title,Art_title_en,Art_Menu_Id,Art_Content,image_lst,Art_order,is_del,Creater_Uid,Creater_Name,Create_Date,Creater_Id from ssn_art ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.ssn_art model = new XHD.Model.ssn_art();
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
        public XHD.Model.ssn_art DataRowToModel(DataRow row)
        {
            XHD.Model.ssn_art model = new XHD.Model.ssn_art();
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
                if (row["Art_title"] != null)
                {
                    model.Art_title = row["Art_title"].ToString();
                }
                if (row["Art_title_en"] != null)
                {
                    model.Art_title_en = row["Art_title_en"].ToString();
                }
                if (row["Art_Menu_Id"] != null && row["Art_Menu_Id"].ToString() != "")
                {
                    model.Art_Menu_Id = int.Parse(row["Art_Menu_Id"].ToString());
                }
                if (row["Art_Content"] != null)
                {
                    model.Art_Content = row["Art_Content"].ToString();
                }
                if (row["image_lst"] != null)
                {
                    model.image_lst = row["image_lst"].ToString();
                }
                if (row["Art_order"] != null && row["Art_order"].ToString() != "")
                {
                    model.Art_order = int.Parse(row["Art_order"].ToString());
                }
                if (row["is_del"] != null && row["is_del"].ToString() != "")
                {
                    model.is_del = int.Parse(row["is_del"].ToString());
                }
                if (row["Creater_Uid"] != null && row["Creater_Uid"].ToString() != "")
                {
                    model.Creater_Uid =row["Creater_Uid"].ToString();
                }
                if (row["Creater_Name"] != null)
                {
                    model.Creater_Name = row["Creater_Name"].ToString();
                }
                if (row["Create_Date"] != null && row["Create_Date"].ToString() != "")
                {
                    model.Create_Date = DateTime.Parse(row["Create_Date"].ToString());
                }
                if (row["Creater_Id"] != null && row["Creater_Id"].ToString() != "")
                {
                    model.Creater_Id = int.Parse(row["Creater_Id"].ToString());
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
            strSql.Append("select Id,factory_Id,Art_title,Art_title_en,Art_Menu_Id,Art_Content,image_lst,Art_order,is_del,Creater_Uid,Creater_Name,Create_Date,Creater_Id ");
            strSql.Append(" FROM ssn_art ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by  Art_order desc,Id desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ssn_art ");
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
            strSql.Append(")AS Row, T.*  from ssn_art T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select Id,factory_Id,Art_title,Art_title_en,Art_Menu_Id,Art_Content,image_lst,Art_order,is_del,Creater_Uid,Creater_Name,Create_Date,Creater_Id   FROM ssn_art ");
            strSql1.Append(" select count(Id) FROM ssn_art ");
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

