using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using XHD.DBUtility;

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_offersheetpdf
    /// </summary>
    public partial class crm_offersheetpdf
    {
        public crm_offersheetpdf()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_offersheetpdf");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_offersheetpdf model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_offersheetpdf(");
            strSql.Append("Factory_Id,brand_id,brand_name,provider_id,provider_name,file_name,file_path,upload_date,creater_id,creater_name)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@brand_id,@brand_name,@provider_id,@provider_name,@file_name,@file_path,@upload_date,@creater_id,@creater_name)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@brand_id", MySqlDbType.Int32,11),
					new MySqlParameter("@brand_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@provider_id", MySqlDbType.Int32,11),
					new MySqlParameter("@provider_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@file_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@file_path", MySqlDbType.VarChar,100),
					new MySqlParameter("@upload_date", MySqlDbType.DateTime),
					new MySqlParameter("@creater_id", MySqlDbType.Int32,11),
					new MySqlParameter("@creater_name", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.brand_id;
            parameters[2].Value = model.brand_name;
            parameters[3].Value = model.provider_id;
            parameters[4].Value = model.provider_name;
            parameters[5].Value = model.file_name;
            parameters[6].Value = model.file_path;
            parameters[7].Value = model.upload_date;
            parameters[8].Value = model.creater_id;
            parameters[9].Value = model.creater_name;

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
        public bool Update(XHD.Model.crm_offersheetpdf model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_offersheetpdf set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("brand_id=@brand_id,");
            strSql.Append("brand_name=@brand_name,");
            strSql.Append("provider_id=@provider_id,");
            strSql.Append("provider_name=@provider_name,");
            strSql.Append("file_name=@file_name,");
            strSql.Append("file_path=@file_path,");
            strSql.Append("upload_date=@upload_date,");
            strSql.Append("creater_id=@creater_id,");
            strSql.Append("creater_name=@creater_name");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@brand_id", MySqlDbType.Int32,11),
					new MySqlParameter("@brand_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@provider_id", MySqlDbType.Int32,11),
					new MySqlParameter("@provider_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@file_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@file_path", MySqlDbType.VarChar,100),
					new MySqlParameter("@upload_date", MySqlDbType.DateTime),
					new MySqlParameter("@creater_id", MySqlDbType.Int32,11),
					new MySqlParameter("@creater_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int64,20)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.brand_id;
            parameters[2].Value = model.brand_name;
            parameters[3].Value = model.provider_id;
            parameters[4].Value = model.provider_name;
            parameters[5].Value = model.file_name;
            parameters[6].Value = model.file_path;
            parameters[7].Value = model.upload_date;
            parameters[8].Value = model.creater_id;
            parameters[9].Value = model.creater_name;
            parameters[10].Value = model.id;

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
        public bool Delete(long id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_offersheetpdf ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
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
            strSql.Append("delete from crm_offersheetpdf ");
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
        /// 批量删除数据
        /// </summary>
        public bool Delete(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_offersheetpdf ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
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
        public XHD.Model.crm_offersheetpdf GetModel(long id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,brand_id,brand_name,provider_id,provider_name,file_name,file_path,upload_date,creater_id,creater_name from crm_offersheetpdf ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
            parameters[0].Value = id;

            XHD.Model.crm_offersheetpdf model = new XHD.Model.crm_offersheetpdf();
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
        public XHD.Model.crm_offersheetpdf DataRowToModel(DataRow row)
        {
            XHD.Model.crm_offersheetpdf model = new XHD.Model.crm_offersheetpdf();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = long.Parse(row["id"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["brand_id"] != null && row["brand_id"].ToString() != "")
                {
                    model.brand_id = int.Parse(row["brand_id"].ToString());
                }
                if (row["brand_name"] != null)
                {
                    model.brand_name = row["brand_name"].ToString();
                }
                if (row["provider_id"] != null && row["provider_id"].ToString() != "")
                {
                    model.provider_id = int.Parse(row["provider_id"].ToString());
                }
                if (row["provider_name"] != null)
                {
                    model.provider_name = row["provider_name"].ToString();
                }
                if (row["file_name"] != null)
                {
                    model.file_name = row["file_name"].ToString();
                }
                if (row["file_path"] != null)
                {
                    model.file_path = row["file_path"].ToString();
                }
                if (row["upload_date"] != null && row["upload_date"].ToString() != "")
                {
                    model.upload_date = DateTime.Parse(row["upload_date"].ToString());
                }
                if (row["creater_id"] != null && row["creater_id"].ToString() != "")
                {
                    model.creater_id = int.Parse(row["creater_id"].ToString());
                }
                if (row["creater_name"] != null)
                {
                    model.creater_name = row["creater_name"].ToString();
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
            strSql.Append("select id,Factory_Id,brand_id,brand_name,provider_id,provider_name,file_name,file_path,upload_date,creater_id,creater_name ");
            strSql.Append(" FROM crm_offersheetpdf ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select id,Factory_Id,brand_id,brand_name,provider_id,provider_name,file_name,file_path,upload_date,creater_id,creater_name ");
            strSql.Append(" FROM crm_offersheetpdf ");
            strSql1.Append(" select count(1) FROM crm_offersheetpdf ");
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM crm_offersheetpdf ");
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
            strSql.Append(")AS Row, T.*  from crm_offersheetpdf T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取品牌
        /// </summary>
        public DataSet getBrand(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select brand_id,brand_name ");
            strSql.Append(" FROM ecs_brand ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetListBrand(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    StringBuilder strSql1 = new StringBuilder();
        //    strSql.Append("select  b.brand_id,b.brand_name,o.file_path,o.upload_date,o.file_name,b.sort_order from ecs_brand as b left join crm_offersheetpdf as o on b.brand_id=o.brand_id ");
        //    //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_Contact ");
        //    //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
        //    strSql1.Append(" select count(1) from ecs_brand as b left join crm_offersheetpdf as o on b.brand_id=o.brand_id ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //        strSql1.Append(" where " + strWhere);
        //    }
        //    strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
        //    Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
        //    return DbHelperMySQL.Query(strSql.ToString());
        //}
        public DataSet GetListBrand(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select  b.brand_id,b.brand_name,b.sort_order,count(o.id) pnum from ecs_brand as b left join crm_offersheetpdf as o on b.brand_id=o.brand_id ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_Contact ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(distinct b.brand_id) from ecs_brand as b left join crm_offersheetpdf as o on b.brand_id=o.brand_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append("group by  b.brand_id,b.brand_name,b.sort_order");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
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
            parameters[0].Value = "crm_offersheetpdf";
            parameters[1].Value = "id";
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
