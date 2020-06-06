using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{

    /// <summary>
    /// 数据访问类:Sys_FactoryInfo
    /// </summary>
    public partial class Sys_FactoryInfo
    {
        public Sys_FactoryInfo()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_FactoryInfo");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,4)
			};
            parameters[0].Value = ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.Sys_FactoryInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_FactoryInfo(");
            strSql.Append("Factory_Id,Factory_Name,Factory_Pws,Factory_Log,Factory_Tel,Factory_Email,Factory_Linkman,Factory_Address,Create_Date,Create_Name,IsDelete,Linkman_tel,Factory_UserNum,Default_Account,empID,Default_role)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@Factory_Name,@Factory_Pws,@Factory_Log,@Factory_Tel,@Factory_Email,@Factory_Linkman,@Factory_Address,@Create_Date,@Create_Name,@IsDelete,@Linkman_tel,@Factory_UserNum,@Default_Account,@empID,@Default_role)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarString,60),
					new MySqlParameter("@Factory_Name", MySqlDbType.VarString,100),
					new MySqlParameter("@Factory_Pws", MySqlDbType.VarString,100),
					new MySqlParameter("@Factory_Log", MySqlDbType.VarString,100),
					new MySqlParameter("@Factory_Tel", MySqlDbType.VarString,50),
					new MySqlParameter("@Factory_Email", MySqlDbType.VarString,50),
					new MySqlParameter("@Factory_Linkman", MySqlDbType.VarString,50),
					new MySqlParameter("@Factory_Address", MySqlDbType.VarString,50),
					new MySqlParameter("@Create_Date", MySqlDbType.DateTime),
					new MySqlParameter("@Create_Name", MySqlDbType.VarString,50),
					new MySqlParameter("@IsDelete", MySqlDbType.VarChar,1),
					new MySqlParameter("@Linkman_tel", MySqlDbType.VarString,50),
					new MySqlParameter("@Factory_UserNum", MySqlDbType.Int32,4),
					new MySqlParameter("@Default_Account", MySqlDbType.VarString,50),
                    new MySqlParameter("@empID", MySqlDbType.Int32,4),
                    new MySqlParameter("@Default_role", MySqlDbType.Int32,4)                  };
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Factory_Name;
            parameters[2].Value = model.Factory_Pws;
            parameters[3].Value = model.Factory_Log;
            parameters[4].Value = model.Factory_Tel;
            parameters[5].Value = model.Factory_Email;
            parameters[6].Value = model.Factory_Linkman;
            parameters[7].Value = model.Factory_Address;
            parameters[8].Value = model.Create_Date;
            parameters[9].Value = model.Create_Name;
            parameters[10].Value = model.IsDelete;
            parameters[11].Value = model.Linkman_tel;
            parameters[12].Value = model.Factory_userNum;
            parameters[13].Value = model.Default_Account;
            parameters[14].Value = model.empID;
            parameters[15].Value = model.Default_role;

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
        /// 更新某个字段
        /// </summary>
        public bool Update(string parameter, string factory_id, string value, int size)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update sys_factoryinfo set ");
            strSql.Append(parameter + "=@" + parameter);
            strSql.Append(" where Factory_Id=@Factory_Id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@"+parameter+"", MySqlDbType.VarChar,size),
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60)           };
            parameters[0].Value = value;
            parameters[1].Value = factory_id;
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
        public bool Update(XHD.Model.Sys_FactoryInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_FactoryInfo set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("Factory_Name=@Factory_Name,");
            strSql.Append("Factory_Pws=@Factory_Pws,");
            strSql.Append("Factory_Log=@Factory_Log,");
            strSql.Append("Factory_Tel=@Factory_Tel,");
            strSql.Append("Factory_Email=@Factory_Email,");
            strSql.Append("Factory_Linkman=@Factory_Linkman,");
            strSql.Append("Factory_Address=@Factory_Address,");
            strSql.Append("IsDelete=@IsDelete,");
            strSql.Append("Linkman_tel=@Linkman_tel,");
            strSql.Append("Factory_UserNum=@Factory_UserNum,");
            strSql.Append("Default_Account=@Default_Account");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarString,60),
					new MySqlParameter("@Factory_Name", MySqlDbType.VarString,100),
					new MySqlParameter("@Factory_Pws", MySqlDbType.VarString,100),
					new MySqlParameter("@Factory_Log", MySqlDbType.VarString,100),
					new MySqlParameter("@Factory_Tel", MySqlDbType.VarString,50),
					new MySqlParameter("@Factory_Email", MySqlDbType.VarString,50),
					new MySqlParameter("@Factory_Linkman", MySqlDbType.VarString,50),
					new MySqlParameter("@Factory_Address", MySqlDbType.VarString,50),
					new MySqlParameter("@IsDelete", MySqlDbType.VarChar,1),
					new MySqlParameter("@Linkman_tel", MySqlDbType.VarString,50),
					new MySqlParameter("@Factory_UserNum", MySqlDbType.Int32,4),
					new MySqlParameter("@Default_Account", MySqlDbType.VarString,50),
					new MySqlParameter("@ID", MySqlDbType.Int32,4)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Factory_Name;
            parameters[2].Value = model.Factory_Pws;
            parameters[3].Value = model.Factory_Log;
            parameters[4].Value = model.Factory_Tel;
            parameters[5].Value = model.Factory_Email;
            parameters[6].Value = model.Factory_Linkman;
            parameters[7].Value = model.Factory_Address;
            parameters[8].Value = model.IsDelete;
            parameters[9].Value = model.Linkman_tel;
            parameters[10].Value = model.Factory_userNum;
            parameters[11].Value = model.Default_Account;
            parameters[12].Value = model.ID;

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
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_FactoryInfo set IsDelete = 1 ");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,4)
			};
            parameters[0].Value = ID;

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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_FactoryInfo ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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
        public XHD.Model.Sys_FactoryInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ID,Factory_Id,Factory_Name,Factory_Pws,Factory_Log,Factory_Tel,Factory_Email,Factory_Linkman,Factory_Address,Create_Date,Create_Name,IsDelete,Linkman_tel,Default_Account,empID,Default_role from Sys_FactoryInfo ");
            strSql.Append(" where ID=@ID limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,4)
			};
            parameters[0].Value = ID;

            XHD.Model.Sys_FactoryInfo model = new XHD.Model.Sys_FactoryInfo();
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
        public XHD.Model.Sys_FactoryInfo DataRowToModel(DataRow row)
        {
            XHD.Model.Sys_FactoryInfo model = new XHD.Model.Sys_FactoryInfo();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["Factory_Name"] != null)
                {
                    model.Factory_Name = row["Factory_Name"].ToString();
                }
                if (row["Factory_Pws"] != null)
                {
                    model.Factory_Pws = row["Factory_Pws"].ToString();
                }
                if (row["Factory_Log"] != null)
                {
                    model.Factory_Log = row["Factory_Log"].ToString();
                }
                if (row["Factory_Tel"] != null)
                {
                    model.Factory_Tel = row["Factory_Tel"].ToString();
                }
                if (row["Factory_Email"] != null)
                {
                    model.Factory_Email = row["Factory_Email"].ToString();
                }
                if (row["Factory_Linkman"] != null)
                {
                    model.Factory_Linkman = row["Factory_Linkman"].ToString();
                }
                if (row["Factory_Address"] != null)
                {
                    model.Factory_Address = row["Factory_Address"].ToString();
                }
                if (row["Create_Date"] != null && row["Create_Date"].ToString() != "")
                {
                    model.Create_Date = DateTime.Parse(row["Create_Date"].ToString());
                }
                if (row["Create_Name"] != null)
                {
                    model.Create_Name = row["Create_Name"].ToString();
                }
                if (row["IsDelete"] != null)
                {
                    model.IsDelete = row["IsDelete"].ToString();
                }
                if (row["Linkman_tel"] != null)
                {
                    model.Linkman_tel = row["Linkman_tel"].ToString();
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
            strSql.Append("select ID,Factory_Id,Factory_Name,Factory_Pws,Factory_Log,Factory_Tel,Factory_Email,Factory_Linkman,Factory_Address,Create_Date,Create_Name,IsDelete,Linkman_tel,Factory_UserNum,Default_Account,empID,Default_role,group_id,group_code ");
            strSql.Append(" FROM Sys_FactoryInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据客户获取id
        /// </summary>
        public DataSet getInfoByCus(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer as Factory_Name,C.address as Factory_Address,C.tel as Factory_Tel,C.fax,
                   L.id as lid,L.C_name as Factory_Linkman,L.C_tel as Linkman_tel,L.C_fax,L.C_email as Factory_Email ");
            strSql.Append(" FROM CRM_Customer C left join CRM_Contact L on C.id=L.C_customerid");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 客户升级为大经销商
        /// </summary>
        public bool UpdateCus(string myFactory, int id, string factory_id)
        {
            string strSql = string.Empty;

            //更改客户表中的关系
            strSql = string.Format(@" update crm_customer set myFactory_Id='{0}' where id = {1} and factory_id='{2}'", myFactory, id, factory_id);
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
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");

            strSql.Append(" ID,Factory_Id,Factory_Name,Factory_Pws,Factory_Log,Factory_Tel,Factory_Email,Factory_Linkman,Factory_Address,Create_Date,Create_Name,IsDelete,Linkman_tel,Factory_UserNum,Default_Account,empID,Default_role ");
            strSql.Append(" FROM Sys_FactoryInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Sys_FactoryInfo ");
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
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_FactoryInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            if (strWhere.Equals("") || strWhere == null)
                strWhere = "1=1";
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  ID,Factory_Id,Factory_Name,Factory_Pws,Factory_Log,Factory_Tel,Factory_Email,Factory_Linkman,Factory_Address,Create_Date,Create_Name,IsDelete,Linkman_tel,Factory_UserNum,Default_Account,empID,Default_role FROM Sys_FactoryInfo ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Sys_FactoryInfo ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM Sys_FactoryInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //更新密码
        public bool changepwd(XHD.Model.Sys_FactoryInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_FactoryInfo set ");
            strSql.Append("Factory_Pws=@Factory_Pws");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {					
					new MySqlParameter("@Factory_Pws", MySqlDbType.VarChar,50),					
					new MySqlParameter("@ID", MySqlDbType.Int32,4)};

            parameters[0].Value = model.Factory_Pws;
            parameters[1].Value = model.ID;

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
            parameters[0].Value = "Sys_FactoryInfo";
            parameters[1].Value = "ID";
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

