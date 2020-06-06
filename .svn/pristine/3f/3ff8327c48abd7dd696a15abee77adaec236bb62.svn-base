using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_goods_gallery
    /// </summary>
    public partial class ecs_goods_gallery
    {
        public ecs_goods_gallery()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int img_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_goods_gallery");
            strSql.Append(" where img_id=@img_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@img_id", MySqlDbType.Int16)
			};
            parameters[0].Value = img_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_goods_gallery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_goods_gallery(");
            strSql.Append("goods_id,img_url,img_desc,thumb_url,img_original,file_ip)");
            strSql.Append(" values (");
            strSql.Append("@goods_id,@img_url,@img_desc,@thumb_url,@img_original,@file_ip)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
					new MySqlParameter("@img_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@img_desc", MySqlDbType.VarChar,255),
					new MySqlParameter("@thumb_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@img_original", MySqlDbType.VarChar,255),
                    new MySqlParameter("@file_ip", MySqlDbType.VarChar,200)};
            parameters[0].Value = model.goods_id;
            parameters[1].Value = model.img_url;
            parameters[2].Value = model.img_desc;
            parameters[3].Value = model.thumb_url;
            parameters[4].Value = model.img_original;
            parameters[5].Value = model.file_ip;

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
        /// 增加一条数据
        /// </summary>
        public bool AddCopy(XHD.Model.ecs_goods_gallery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_goods_gallery(");
            strSql.Append("goods_id,img_url,img_desc,thumb_url,img_original,file_ip)");
            strSql.Append(" values (");
            strSql.Append("@goods_id,@img_url,@img_desc,@thumb_url,@img_original,@file_ip)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
					new MySqlParameter("@img_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@img_desc", MySqlDbType.VarChar,255),
					new MySqlParameter("@thumb_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@img_original", MySqlDbType.VarChar,255),
                     new MySqlParameter("@file_ip", MySqlDbType.VarChar,200)};
            parameters[0].Value = model.goods_id;
            parameters[1].Value = model.img_url;
            parameters[2].Value = model.img_desc;
            parameters[3].Value = model.thumb_url;
            parameters[4].Value = model.img_original;
            parameters[5].Value = model.file_ip;

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
        public bool Update(XHD.Model.ecs_goods_gallery model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_goods_gallery set ");
            strSql.Append("goods_id=@goods_id,");
            strSql.Append("img_url=@img_url,");
            strSql.Append("img_desc=@img_desc,");
            strSql.Append("thumb_url=@thumb_url,");
            strSql.Append("img_original=@img_original,");
            strSql.Append("file_ip=@file_ip");
            strSql.Append(" where img_id=@img_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
					new MySqlParameter("@img_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@img_desc", MySqlDbType.VarChar,255),
					new MySqlParameter("@thumb_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@img_original", MySqlDbType.VarChar,255),
                    new MySqlParameter("@file_ip", MySqlDbType.VarChar,200),
					new MySqlParameter("@img_id", MySqlDbType.Int16,8)};
            parameters[0].Value = model.goods_id;
            parameters[1].Value = model.img_url;
            parameters[2].Value = model.img_desc;
            parameters[3].Value = model.thumb_url;
            parameters[4].Value = model.img_original;
            parameters[5].Value = model.file_ip;
            parameters[6].Value = model.img_id;

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
        public bool Delete(int goods_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_goods_gallery ");
            strSql.Append(" where goods_id=@goods_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16)
			};
            parameters[0].Value = goods_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除一条数据
        /// </summary>
        public bool DeleteByGoodsId(int goods_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_goods_gallery ");
            strSql.Append(" where goods_id=@goods_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16)
			};
            parameters[0].Value = goods_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除一条数据
        /// </summary>
        public bool DeleteCopy(int goods_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_goods_gallery ");
            strSql.Append(" where goods_id=@goods_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16)
			};
            parameters[0].Value = goods_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string img_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_goods_gallery ");
            strSql.Append(" where img_id in (" + img_idlist + ")  ");
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
        public XHD.Model.ecs_goods_gallery GetModel(int img_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select img_id,goods_id,img_url,img_desc,thumb_url,img_original from ecs_goods_gallery,file_ip ");
            strSql.Append(" where img_id=@img_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@img_id", MySqlDbType.Int16)
			};
            parameters[0].Value = img_id;

            XHD.Model.ecs_goods_gallery model = new XHD.Model.ecs_goods_gallery();
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
        public XHD.Model.ecs_goods_gallery DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_goods_gallery model = new XHD.Model.ecs_goods_gallery();
            if (row != null)
            {
                //model.img_id=row["img_id"].ToString();
                //model.goods_id=row["goods_id"].ToString();
                if (row["img_url"] != null)
                {
                    model.img_url = row["img_url"].ToString();
                }
                if (row["img_desc"] != null)
                {
                    model.img_desc = row["img_desc"].ToString();
                }
                if (row["thumb_url"] != null)
                {
                    model.thumb_url = row["thumb_url"].ToString();
                }
                if (row["img_original"] != null)
                {
                    model.img_original = row["img_original"].ToString();
                }
                if (row["file_ip"] != null)
                {
                    model.file_ip = row["file_ip"].ToString();
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
            strSql.Append("select img_id,goods_id,img_url,img_desc,thumb_url,img_original,file_ip ");
            strSql.Append(" FROM ecs_goods_gallery ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListCopy(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select img_id,goods_id,img_url,img_desc,thumb_url,img_original,file_ip ");
            strSql.Append(" FROM scm_goods_gallery ");
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
            strSql.Append("select count(1) FROM ecs_goods_gallery ");
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
                strSql.Append("order by T.img_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_goods_gallery T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 产品主表向附表添加数据
        /// </summary>
        public bool AddCopy(int goods_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_goods_gallery( img_id,goods_id,img_url,img_desc,thumb_url,img_original,file_ip) ");
            strSql.Append(" select img_id,goods_id,img_url,img_desc,thumb_url,img_original,file_ip ");
            strSql.Append(" from ecs_goods_gallery where goods_id=@goods_id  ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = goods_id;

            int row = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 附表同步到商城
        /// </summary>
        public bool CopyToShop(int goods_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_goods_gallery( img_id,goods_id,img_url,img_desc,thumb_url,img_original) ");
            strSql.Append(" select img_id,goods_id,img_url,img_desc,thumb_url,img_original ");
            strSql.Append(" from scm_goods_gallery where goods_id=@goods_id  ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = goods_id;

            int row = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            parameters[0].Value = "ecs_goods_gallery";
            parameters[1].Value = "img_id";
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

