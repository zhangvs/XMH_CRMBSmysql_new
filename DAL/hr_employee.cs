using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// ���ݷ�����:hr_employee
    /// </summary>
    public partial class hr_employee
    {
        public hr_employee()
        { }
        #region  Method
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from hr_employee");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,4)};
            parameters[0].Value = ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }
        public Model.hr_employee LoginUser(string userName)
        {
            //string strSql = "select * from hr_employee where Factory_Id=@Factory_Id and uid=@uid";
            string strSql = "select * from hr_employee where uid=@uid";
            MySqlParameter[] parameters = { new MySqlParameter("@uid", MySqlDbType.VarChar, 50) };
            parameters[0].Value = userName;

            Model.hr_employee model = new Model.hr_employee();
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
        /// ��������б�
        /// </summary>
        public DataSet GetOptionList(string sql)
        {
            return DbHelperMySQL.Query(sql.ToString());
        }

        /// <summary>
        /// ��������б�  ָ���ֶ�
        /// </summary>
        public DataSet GetOptionListById(int id, string factory_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,name ");
            strSql.Append(" FROM hr_employee ");
            strSql.Append(" where d_id=@Id");
            strSql.Append(" and Factory_Id=@Factory_Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60)
            };
            parameters[0].Value = id;
            parameters[1].Value = factory_Id;
            return DbHelperMySQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(XHD.Model.hr_employee model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into hr_employee(");
            strSql.Append("emp_code,factory_Id,uid,pwd,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,emp_code_shop,warehouseid,offices_tel)");
            strSql.Append(" values (");
            strSql.Append("@emp_code,@factory_Id,@uid,@pwd,@name,@idcard,@birthday,@d_id,@dname,@postid,@post,@email,@sex,@tel,@status,@zhiwuid,@zhiwu,@sort,@EntryDate,@address,@remarks,@education,@level,@professional,@schools,@title,@isDelete,@Delete_time,@portal,@theme,@canlogin,@roletype,@emp_code_shop,@warehouseid,@offices_tel)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
                 
                    new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@uid", MySqlDbType.VarChar,50),
					new MySqlParameter("@pwd", MySqlDbType.VarChar,50),
					new MySqlParameter("@name", MySqlDbType.VarChar,50),
					new MySqlParameter("@idcard", MySqlDbType.VarChar,50),
					new MySqlParameter("@birthday", MySqlDbType.VarChar,50),
					new MySqlParameter("@d_id", MySqlDbType.Int32,4),
					new MySqlParameter("@dname", MySqlDbType.VarChar,50),
					new MySqlParameter("@postid", MySqlDbType.Int32,4),
					new MySqlParameter("@post", MySqlDbType.VarChar,250),
					new MySqlParameter("@email", MySqlDbType.VarChar,50),
					new MySqlParameter("@sex", MySqlDbType.VarChar,50),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@status", MySqlDbType.VarChar,50),
					new MySqlParameter("@zhiwuid", MySqlDbType.Int32,4),
					new MySqlParameter("@zhiwu", MySqlDbType.VarChar,50),
					new MySqlParameter("@sort", MySqlDbType.Int32,4),
					new MySqlParameter("@EntryDate", MySqlDbType.VarChar,50),
					new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@remarks", MySqlDbType.VarChar,255),
					new MySqlParameter("@education", MySqlDbType.VarChar,50),
					new MySqlParameter("@level", MySqlDbType.VarChar,50),
					new MySqlParameter("@professional", MySqlDbType.VarChar,50),
					new MySqlParameter("@schools", MySqlDbType.VarChar,50),
					new MySqlParameter("@title", MySqlDbType.VarChar,50),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,4),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime),
					new MySqlParameter("@portal", MySqlDbType.VarChar,250),
					new MySqlParameter("@theme", MySqlDbType.VarChar,250),
					new MySqlParameter("@canlogin", MySqlDbType.Int32,4),
                    new MySqlParameter("@roletype", MySqlDbType.Int32,4),
                    new MySqlParameter("@emp_code", MySqlDbType.VarChar,50),
                    new MySqlParameter("@emp_code_shop", MySqlDbType.VarChar,50),
                    new MySqlParameter("@warehouseid", MySqlDbType.VarChar,60),
                    new MySqlParameter("@offices_tel", MySqlDbType.VarChar,50)};

            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.uid;
            parameters[2].Value = model.pwd;
            parameters[3].Value = model.name;
            parameters[4].Value = model.idcard;
            parameters[5].Value = model.birthday;
            parameters[6].Value = model.d_id;
            parameters[7].Value = model.dname;
            parameters[8].Value = model.postid;
            parameters[9].Value = model.post;
            parameters[10].Value = model.email;
            parameters[11].Value = model.sex;
            parameters[12].Value = model.tel;
            parameters[13].Value = model.status;
            parameters[14].Value = model.zhiwuid;
            parameters[15].Value = model.zhiwu;
            parameters[16].Value = model.sort;
            parameters[17].Value = model.EntryDate;
            parameters[18].Value = model.address;
            parameters[19].Value = model.remarks;
            parameters[20].Value = model.education;
            parameters[21].Value = model.level;
            parameters[22].Value = model.professional;
            parameters[23].Value = model.schools;
            parameters[24].Value = model.title;
            parameters[25].Value = model.isDelete;
            parameters[26].Value = model.Delete_time;
            parameters[27].Value = model.portal;
            parameters[28].Value = model.theme;
            parameters[29].Value = model.canlogin;
            parameters[30].Value = model.roletype;
            parameters[31].Value = model.emp_code;
            parameters[32].Value = model.emp_code_shop;
            parameters[33].Value = model.warehouseid;
            parameters[34].Value = model.offices_tel;
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
        /// ����һ������
        /// </summary>
        public bool Update(XHD.Model.hr_employee model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_employee set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("uid=@uid,");
            strSql.Append("name=@name,");
            strSql.Append("idcard=@idcard,");
            strSql.Append("birthday=@birthday,");
            strSql.Append("d_id=@d_id,");
            strSql.Append("dname=@dname,");
            strSql.Append("postid=@postid,");
            strSql.Append("post=@post,");
            strSql.Append("email=@email,");
            strSql.Append("sex=@sex,");
            strSql.Append("tel=@tel,");
            strSql.Append("status=@status,");
            strSql.Append("zhiwuid=@zhiwuid,");
            strSql.Append("zhiwu=@zhiwu,");
            strSql.Append("sort=@sort,");
            strSql.Append("EntryDate=@EntryDate,");
            strSql.Append("address=@address,");
            strSql.Append("remarks=@remarks,");
            strSql.Append("education=@education,");
            strSql.Append("level=@level,");
            strSql.Append("professional=@professional,");
            strSql.Append("schools=@schools,");
            strSql.Append("title=@title,");
            strSql.Append("portal=@portal,");
            strSql.Append("theme=@theme,");
            strSql.Append("canlogin=@canlogin,");
            strSql.Append("emp_code=@emp_code,");
            strSql.Append("emp_code_shop=@emp_code_shop,");
            strSql.Append("warehouseid=@warehouseid,");
            strSql.Append("offices_tel=@offices_tel");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@uid", MySqlDbType.VarChar,50),
					new MySqlParameter("@name", MySqlDbType.VarChar,50),
					new MySqlParameter("@idcard", MySqlDbType.VarChar,50),
					new MySqlParameter("@birthday", MySqlDbType.VarChar,50),
					new MySqlParameter("@d_id", MySqlDbType.Int32,4),
					new MySqlParameter("@dname", MySqlDbType.VarChar,50),
					new MySqlParameter("@postid", MySqlDbType.Int32,4),
					new MySqlParameter("@post", MySqlDbType.VarChar,250),
					new MySqlParameter("@email", MySqlDbType.VarChar,50),
					new MySqlParameter("@sex", MySqlDbType.VarChar,50),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@status", MySqlDbType.VarChar,50),
					new MySqlParameter("@zhiwuid", MySqlDbType.Int32,4),
					new MySqlParameter("@zhiwu", MySqlDbType.VarChar,50),
					new MySqlParameter("@sort", MySqlDbType.Int32,4),
					new MySqlParameter("@EntryDate", MySqlDbType.VarChar,50),
					new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@remarks", MySqlDbType.VarChar,255),
					new MySqlParameter("@education", MySqlDbType.VarChar,50),
					new MySqlParameter("@level", MySqlDbType.VarChar,50),
					new MySqlParameter("@professional", MySqlDbType.VarChar,50),
					new MySqlParameter("@schools", MySqlDbType.VarChar,50),
					new MySqlParameter("@title", MySqlDbType.VarChar,50),  
					new MySqlParameter("@portal", MySqlDbType.VarChar,250),
					new MySqlParameter("@theme", MySqlDbType.VarChar,250),
					new MySqlParameter("@canlogin", MySqlDbType.Int32,4),
					new MySqlParameter("@ID", MySqlDbType.Int32,4),
                    new MySqlParameter("@emp_code", MySqlDbType.VarChar,50),
                    new MySqlParameter("@emp_code_shop", MySqlDbType.VarChar,50),
                    new MySqlParameter("@warehouseid", MySqlDbType.VarChar,60),
                    new MySqlParameter("@offices_tel", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.uid;
            parameters[2].Value = model.name;
            parameters[3].Value = model.idcard;
            parameters[4].Value = model.birthday;
            parameters[5].Value = model.d_id;
            parameters[6].Value = model.dname;
            parameters[7].Value = model.postid;
            parameters[8].Value = model.post;
            parameters[9].Value = model.email;
            parameters[10].Value = model.sex;
            parameters[11].Value = model.tel;
            parameters[12].Value = model.status;
            parameters[13].Value = model.zhiwuid;
            parameters[14].Value = model.zhiwu;
            parameters[15].Value = model.sort;
            parameters[16].Value = model.EntryDate;
            parameters[17].Value = model.address;
            parameters[18].Value = model.remarks;
            parameters[19].Value = model.education;
            parameters[20].Value = model.level;
            parameters[21].Value = model.professional;
            parameters[22].Value = model.schools;
            parameters[23].Value = model.title;
            parameters[24].Value = model.portal;
            parameters[25].Value = model.theme;
            parameters[26].Value = model.canlogin;
            parameters[27].Value = model.ID;
            parameters[28].Value = model.emp_code;
            parameters[29].Value = model.emp_code_shop;
            parameters[30].Value = model.warehouseid;
            parameters[31].Value = model.offices_tel;

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
        /// ����TQ_id
        /// </summary>
        public bool updateTQ(int ID, string TQ_Id, string TQ_seatid, string factory_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_employee set ");
            strSql.Append("TQ_Id=@TQ_Id,");
            strSql.Append("TQ_seatid=@TQ_seatid");
            strSql.Append(" where ID=@ID");
            strSql.Append(" and Factory_Id=@Factory_Id ");

            MySqlParameter[] parameters = {
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@TQ_Id", MySqlDbType.VarChar,30),
					new MySqlParameter("@TQ_seatid", MySqlDbType.VarChar,10),
					new MySqlParameter("@ID", MySqlDbType.Int32,4)};
            parameters[0].Value = factory_id;
            parameters[1].Value = TQ_Id;
            parameters[2].Value = TQ_seatid;
            parameters[3].Value = ID;

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
        /// Ԥɾ��
        /// </summary>
        public bool AdvanceDelete(int id, int isDelete, string time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_employee set ");
            strSql.Append("isDelete=" + isDelete);
            strSql.Append(",Delete_time='" + time + "'");
            strSql.Append(" where id=" + id);
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
        /// ɾ��һ������
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from hr_employee ");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,4)};
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
        /// ɾ��һ������
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from hr_employee ");
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
        /// ��������б�  ָ���ֶ�
        /// </summary>
        public DataSet GetOptionLists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,name ");
            strSql.Append(" FROM hr_employee ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public XHD.Model.hr_employee GetModelByTQ(int TQ_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Factory_Id,uid,pwd,emp_code,emp_code_shop,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,TQ_Id,TQ_seatid,warehouseid,offices_tel from hr_employee ");
            strSql.Append(" where TQ_Id=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32)
			};
            parameters[0].Value = TQ_ID;

            XHD.Model.hr_employee model = new XHD.Model.hr_employee();
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
        /// �õ�һ������ʵ��
        /// </summary>
        public XHD.Model.hr_employee GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ID,Factory_Id,uid,pwd,emp_code,emp_code_shop,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,TQ_Id,TQ_seatid,warehouseid,offices_tel from hr_employee ");
            strSql.Append(" where ID=@ID limit 1");
            MySqlParameter[] parameters = {
                        new MySqlParameter("@ID", MySqlDbType.Int32,4)};
            parameters[0].Value = ID;

            XHD.Model.hr_employee model = new XHD.Model.hr_employee();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Factory_Id"] != null && ds.Tables[0].Rows[0]["Factory_Id"].ToString() != "")
                {
                    model.factory_Id = ds.Tables[0].Rows[0]["Factory_Id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["uid"] != null && ds.Tables[0].Rows[0]["uid"].ToString() != "")
                {
                    model.uid = ds.Tables[0].Rows[0]["uid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pwd"] != null && ds.Tables[0].Rows[0]["pwd"].ToString() != "")
                {
                    model.pwd = ds.Tables[0].Rows[0]["pwd"].ToString();
                }
                if (ds.Tables[0].Rows[0]["emp_code"] != null && ds.Tables[0].Rows[0]["emp_code"].ToString() != "")
                {
                    model.emp_code = ds.Tables[0].Rows[0]["emp_code"].ToString();
                }
                if (ds.Tables[0].Rows[0]["emp_code_shop"] != null && ds.Tables[0].Rows[0]["emp_code_shop"].ToString() != "")
                {
                    model.emp_code_shop = ds.Tables[0].Rows[0]["emp_code_shop"].ToString();
                }

                if (ds.Tables[0].Rows[0]["name"] != null && ds.Tables[0].Rows[0]["name"].ToString() != "")
                {
                    model.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["idcard"] != null && ds.Tables[0].Rows[0]["idcard"].ToString() != "")
                {
                    model.idcard = ds.Tables[0].Rows[0]["idcard"].ToString();
                }
                if (ds.Tables[0].Rows[0]["birthday"] != null && ds.Tables[0].Rows[0]["birthday"].ToString() != "")
                {
                    model.birthday = ds.Tables[0].Rows[0]["birthday"].ToString();
                }
                if (ds.Tables[0].Rows[0]["d_id"] != null && ds.Tables[0].Rows[0]["d_id"].ToString() != "")
                {
                    model.d_id = int.Parse(ds.Tables[0].Rows[0]["d_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dname"] != null && ds.Tables[0].Rows[0]["dname"].ToString() != "")
                {
                    model.dname = ds.Tables[0].Rows[0]["dname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["postid"] != null && ds.Tables[0].Rows[0]["postid"].ToString() != "")
                {
                    model.postid = int.Parse(ds.Tables[0].Rows[0]["postid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["post"] != null && ds.Tables[0].Rows[0]["post"].ToString() != "")
                {
                    model.post = ds.Tables[0].Rows[0]["post"].ToString();
                }
                if (ds.Tables[0].Rows[0]["email"] != null && ds.Tables[0].Rows[0]["email"].ToString() != "")
                {
                    model.email = ds.Tables[0].Rows[0]["email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sex"] != null && ds.Tables[0].Rows[0]["sex"].ToString() != "")
                {
                    model.sex = ds.Tables[0].Rows[0]["sex"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tel"] != null && ds.Tables[0].Rows[0]["tel"].ToString() != "")
                {
                    model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["status"] != null && ds.Tables[0].Rows[0]["status"].ToString() != "")
                {
                    model.status = ds.Tables[0].Rows[0]["status"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhiwuid"] != null && ds.Tables[0].Rows[0]["zhiwuid"].ToString() != "")
                {
                    model.zhiwuid = int.Parse(ds.Tables[0].Rows[0]["zhiwuid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhiwu"] != null && ds.Tables[0].Rows[0]["zhiwu"].ToString() != "")
                {
                    model.zhiwu = ds.Tables[0].Rows[0]["zhiwu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sort"] != null && ds.Tables[0].Rows[0]["sort"].ToString() != "")
                {
                    model.sort = int.Parse(ds.Tables[0].Rows[0]["sort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EntryDate"] != null && ds.Tables[0].Rows[0]["EntryDate"].ToString() != "")
                {
                    model.EntryDate = ds.Tables[0].Rows[0]["EntryDate"].ToString();
                }
                if (ds.Tables[0].Rows[0]["address"] != null && ds.Tables[0].Rows[0]["address"].ToString() != "")
                {
                    model.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["remarks"] != null && ds.Tables[0].Rows[0]["remarks"].ToString() != "")
                {
                    model.remarks = ds.Tables[0].Rows[0]["remarks"].ToString();
                }
                if (ds.Tables[0].Rows[0]["education"] != null && ds.Tables[0].Rows[0]["education"].ToString() != "")
                {
                    model.education = ds.Tables[0].Rows[0]["education"].ToString();
                }
                if (ds.Tables[0].Rows[0]["level"] != null && ds.Tables[0].Rows[0]["level"].ToString() != "")
                {
                    model.level = ds.Tables[0].Rows[0]["level"].ToString();
                }
                if (ds.Tables[0].Rows[0]["professional"] != null && ds.Tables[0].Rows[0]["professional"].ToString() != "")
                {
                    model.professional = ds.Tables[0].Rows[0]["professional"].ToString();
                }
                if (ds.Tables[0].Rows[0]["schools"] != null && ds.Tables[0].Rows[0]["schools"].ToString() != "")
                {
                    model.schools = ds.Tables[0].Rows[0]["schools"].ToString();
                }
                if (ds.Tables[0].Rows[0]["title"] != null && ds.Tables[0].Rows[0]["title"].ToString() != "")
                {
                    model.title = ds.Tables[0].Rows[0]["title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["isDelete"] != null && ds.Tables[0].Rows[0]["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(ds.Tables[0].Rows[0]["isDelete"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Delete_time"] != null && ds.Tables[0].Rows[0]["Delete_time"].ToString() != "")
                {
                    model.Delete_time = DateTime.Parse(ds.Tables[0].Rows[0]["Delete_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["portal"] != null && ds.Tables[0].Rows[0]["portal"].ToString() != "")
                {
                    model.portal = ds.Tables[0].Rows[0]["portal"].ToString();
                }
                if (ds.Tables[0].Rows[0]["theme"] != null && ds.Tables[0].Rows[0]["theme"].ToString() != "")
                {
                    model.theme = ds.Tables[0].Rows[0]["theme"].ToString();
                }
                if (ds.Tables[0].Rows[0]["canlogin"] != null && ds.Tables[0].Rows[0]["canlogin"].ToString() != "")
                {
                    model.canlogin = int.Parse(ds.Tables[0].Rows[0]["canlogin"].ToString());
                }
                if (ds.Tables[0].Rows[0]["roletype"] != null && ds.Tables[0].Rows[0]["roletype"].ToString() != "")
                {
                    model.roletype = int.Parse(ds.Tables[0].Rows[0]["roletype"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TQ_Id"] != null && ds.Tables[0].Rows[0]["TQ_Id"].ToString() != "")
                {
                    model.TQ_Id = ds.Tables[0].Rows[0]["TQ_Id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["TQ_seatid"] != null && ds.Tables[0].Rows[0]["TQ_seatid"].ToString() != "")
                {
                    model.TQ_seatid = ds.Tables[0].Rows[0]["TQ_seatid"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public XHD.Model.hr_employee DataRowToModel(DataRow row)
        {
            XHD.Model.hr_employee model = new XHD.Model.hr_employee();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.factory_Id = row["Factory_Id"].ToString();
                }
                if (row["uid"] != null)
                {
                    model.uid = row["uid"].ToString();
                }
                if (row["pwd"] != null)
                {
                    model.pwd = row["pwd"].ToString();
                }
                if (row["emp_code"] != null)
                {
                    model.emp_code = row["emp_code"].ToString();
                }
                if (row["emp_code_shop"] != null)
                {
                    model.emp_code_shop = row["emp_code_shop"].ToString();
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["idcard"] != null)
                {
                    model.idcard = row["idcard"].ToString();
                }
                if (row["birthday"] != null)
                {
                    model.birthday = row["birthday"].ToString();
                }
                if (row["d_id"] != null && row["d_id"].ToString() != "")
                {
                    model.d_id = int.Parse(row["d_id"].ToString());
                }
                if (row["dname"] != null)
                {
                    model.dname = row["dname"].ToString();
                }
                if (row["postid"] != null && row["postid"].ToString() != "")
                {
                    model.postid = int.Parse(row["postid"].ToString());
                }
                if (row["post"] != null)
                {
                    model.post = row["post"].ToString();
                }
                if (row["email"] != null)
                {
                    model.email = row["email"].ToString();
                }
                if (row["sex"] != null)
                {
                    model.sex = row["sex"].ToString();
                }
                if (row["tel"] != null)
                {
                    model.tel = row["tel"].ToString();
                }
                if (row["status"] != null)
                {
                    model.status = row["status"].ToString();
                }
                if (row["zhiwuid"] != null && row["zhiwuid"].ToString() != "")
                {
                    model.zhiwuid = int.Parse(row["zhiwuid"].ToString());
                }
                if (row["zhiwu"] != null)
                {
                    model.zhiwu = row["zhiwu"].ToString();
                }
                if (row["sort"] != null && row["sort"].ToString() != "")
                {
                    model.sort = int.Parse(row["sort"].ToString());
                }
                if (row["EntryDate"] != null)
                {
                    model.EntryDate = row["EntryDate"].ToString();
                }
                if (row["address"] != null)
                {
                    model.address = row["address"].ToString();
                }
                if (row["remarks"] != null)
                {
                    model.remarks = row["remarks"].ToString();
                }
                if (row["education"] != null)
                {
                    model.education = row["education"].ToString();
                }
                if (row["level"] != null)
                {
                    model.level = row["level"].ToString();
                }
                if (row["professional"] != null)
                {
                    model.professional = row["professional"].ToString();
                }
                if (row["schools"] != null)
                {
                    model.schools = row["schools"].ToString();
                }
                if (row["title"] != null)
                {
                    model.title = row["title"].ToString();
                }
                if (row["isDelete"] != null && row["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(row["isDelete"].ToString());
                }
                if (row["Delete_time"] != null && row["Delete_time"].ToString() != "")
                {
                    model.Delete_time = DateTime.Parse(row["Delete_time"].ToString());
                }
                if (row["portal"] != null)
                {
                    model.portal = row["portal"].ToString();
                }
                if (row["theme"] != null)
                {
                    model.theme = row["theme"].ToString();
                }
                if (row["canlogin"] != null && row["canlogin"].ToString() != "")
                {
                    model.canlogin = int.Parse(row["canlogin"].ToString());
                }
                if (row["roletype"] != null && row["roletype"].ToString() != "")
                {
                    model.roletype = int.Parse(row["roletype"].ToString());
                }
                if (row["TQ_Id"] != null)
                {
                    model.TQ_Id = row["TQ_Id"].ToString();
                }
                if (row["TQ_seatid"] != null)
                {
                    model.TQ_seatid = row["TQ_seatid"].ToString();
                }
            }
            return model;
        }


        /// <summary>
        /// ��Ա��uid��TQ_ID
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public string GetTQ_SeatId(string uid)
        {
            string sql = "select TQ_seatid from hr_employee where uid=@uid";
            MySqlParameter[] param = { 
                                     new MySqlParameter("@uid",uid)
                                  };
            if (DbHelperMySQL.GetSingle(sql, param) != null)
            {
                return DbHelperMySQL.GetSingle(sql, param).ToString();
            }
            else
            {
                return "";
            }

        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select emp_code,ID,Factory_Id,uid,pwd,emp_code,emp_code_shop,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,TQ_Id,TQ_seatid,warehouseid,offices_tel ");
            strSql.Append(" FROM hr_employee ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetListEmp(string strWhereOne, string strWhereTwo)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" select distinct * from ( ");

            if (strWhereOne.Trim() != "" && strWhereTwo.Trim() != "")
            {
                strSql.Append("select ID,Factory_Id,uid,pwd,emp_code,emp_code_shop,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,TQ_Id,TQ_seatid,warehouseid,offices_tel ");
                strSql.Append(" FROM hr_employee ");
                strSql.Append(" where " + strWhereOne);

                strSql.Append(" union all select ID,Factory_Id,uid,pwd,emp_code,emp_code_shop,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,TQ_Id,TQ_seatid,warehouseid,offices_tel ");
                strSql.Append(" FROM hr_employee ");

                strSql.Append(" where " + strWhereTwo);
            }

            else if (strWhereOne.Trim() != "")
            {
                strSql.Append("select ID,Factory_Id,uid,pwd,emp_code,emp_code_shop,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,TQ_Id,TQ_seatid,warehouseid,offices_tel ");
                strSql.Append(" FROM hr_employee ");
                strSql.Append(" where " + strWhereOne);
            }
            else if (strWhereTwo.Trim() != "")
            {
                strSql.Append(" union all select ID,Factory_Id,uid,pwd,emp_code,emp_code_shop,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,TQ_Id,TQ_seatid,warehouseid,offices_tel ");
                strSql.Append(" FROM hr_employee ");
                strSql.Append(" where " + strWhereTwo);
            }

            strSql.Append(" ) as a ");
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetParentidOrDid(string d_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT emp_code,name,d_id,dname,parentid,parentname from hr_employee emp ");
            strSql.Append(" left join hr_department dep on emp.d_id=dep.id ");
            strSql.Append(" where parentid in(" + d_id + ") or d_id in(" + d_id + ") order by parentid,d_id ");
            strSql.Append(" left join hr_department dep on emp.d_id=dep.id ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ��õ�ǰ�û���
        /// </summary>
        public DataSet GetCurrent(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) currentuser ");
            strSql.Append(" FROM hr_employee ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());

        }

        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select ID,factory_Id,uid,emp_code,emp_code_shop,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,TQ_Id,TQ_seatid,warehouseid,offices_tel ");
            strSql.Append(" FROM hr_employee ");
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
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select ID,factory_Id,uid,emp_code,emp_code_shop,name,idcard,birthday,d_id,dname,postid,post,email,sex,tel,status,zhiwuid,zhiwu,sort,EntryDate,address,remarks,education,level,professional,schools,title,isDelete,Delete_time,portal,theme,canlogin,roletype,TQ_Id,TQ_seatid,warehouseid,offices_tel FROM hr_employee ");
            strSql1.Append(" select count(id) FROM hr_employee ");
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
        /// ��ȡ����
        /// </summary>
        public DataSet GetPWD(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select pwd ");
            strSql.Append(" FROM hr_employee ");
            strSql.Append(" WHERE ID =" + ID);

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// ��ȡ����
        /// </summary>
        public bool changepwd(XHD.Model.hr_employee model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_employee set ");
            strSql.Append("pwd=@pwd");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {					
					new MySqlParameter("@pwd", MySqlDbType.VarChar,50),					
					new MySqlParameter("@ID", MySqlDbType.Int32,4)};

            parameters[0].Value = model.pwd;
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
        /// <summary>
        /// ��ȡ���루uid��
        /// </summary>
        public bool changepwd(XHD.Model.hr_employee model, string uid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_employee set ");
            strSql.Append("pwd=@pwd");
            strSql.Append(" where Factory_Id=@Factory_Id and roletype=1 ");
            MySqlParameter[] parameters = {					
					new MySqlParameter("@pwd", MySqlDbType.VarChar,50),					
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60)};

            parameters[0].Value = model.pwd;
            parameters[1].Value = uid;

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
        /// ���¸�λ
        /// </summary>
        public bool UpdatePost(XHD.Model.hr_employee model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_employee set ");

            strSql.Append("d_id=@d_id,");
            strSql.Append("dname=@dname,");
            strSql.Append("postid=@postid,");
            strSql.Append("post=@post,");
            strSql.Append("zhiwuid=@zhiwuid,");
            strSql.Append("zhiwu=@zhiwu");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					
					new MySqlParameter("@d_id", MySqlDbType.Int32,4),
					new MySqlParameter("@dname", MySqlDbType.VarChar,50),
                    new MySqlParameter("@postid", MySqlDbType.Int32,4),
					new MySqlParameter("@post", MySqlDbType.VarChar,250),
					new MySqlParameter("@zhiwuid", MySqlDbType.Int32,4),
					new MySqlParameter("@zhiwu", MySqlDbType.VarChar,50),
					new MySqlParameter("@ID", MySqlDbType.Int32,4)};

            parameters[0].Value = model.d_id;
            parameters[1].Value = model.dname;
            parameters[2].Value = model.postid;
            parameters[3].Value = model.post;
            parameters[4].Value = model.zhiwuid;
            parameters[5].Value = model.zhiwu;
            parameters[6].Value = model.ID;

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
        /// ��ȡ��ɫ
        /// </summary>
        public DataSet GetRole(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from Sys_role where RoleID in ");
            strSql.Append("(select RoleID from Sys_role_emp where empID=" + ID + ")  ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ������Ϣ�޸�
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool PersonalUpdate(XHD.Model.hr_employee model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_employee set ");
            strSql.Append("name=@name,");
            strSql.Append("idcard=@idcard,");
            strSql.Append("birthday=@birthday,");
            strSql.Append("email=@email,");
            strSql.Append("sex=@sex,");
            strSql.Append("tel=@tel,");
            strSql.Append("address=@address,");
            strSql.Append("education=@education,");
            strSql.Append("level=@level,");
            strSql.Append("professional=@professional,");
            strSql.Append("schools=@schools,");
            strSql.Append("title=@title");

            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@name", MySqlDbType.VarChar,50),
					new MySqlParameter("@idcard", MySqlDbType.VarChar,50),
					new MySqlParameter("@birthday", MySqlDbType.VarChar,50),
					new MySqlParameter("@email", MySqlDbType.VarChar,50),
					new MySqlParameter("@sex", MySqlDbType.VarChar,50),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@education", MySqlDbType.VarChar,50),
					new MySqlParameter("@level", MySqlDbType.VarChar,50),
					new MySqlParameter("@professional", MySqlDbType.VarChar,50),
					new MySqlParameter("@schools", MySqlDbType.VarChar,50),
					new MySqlParameter("@title", MySqlDbType.VarChar,50),
					new MySqlParameter("@ID", MySqlDbType.Int32,4)};
            parameters[0].Value = model.name;
            parameters[1].Value = model.idcard;
            parameters[2].Value = model.birthday;
            parameters[3].Value = model.email;
            parameters[4].Value = model.sex;
            parameters[5].Value = model.tel;
            parameters[6].Value = model.address;
            parameters[7].Value = model.education;
            parameters[8].Value = model.level;
            parameters[9].Value = model.professional;
            parameters[10].Value = model.schools;
            parameters[11].Value = model.title;
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
        /// ���¿ͻ�����������ͬ���տ��Ʊ ��Ա
        /// </summary>
        public bool UpdateCOCRI(XHD.Model.hr_employee model)
        {
            StringBuilder strSql1 = new StringBuilder();
            strSql1.Append("UPDATE CRM_Customer SET ");
            strSql1.Append("Department_id=@dep_id,");
            strSql1.Append("Department=@dep_name,");
            strSql1.Append("Employee=@emp_name");
            strSql1.Append(" where Employee_id=@emp_id");

            StringBuilder strSql2 = new StringBuilder();
            strSql2.Append("UPDATE CRM_order SET ");
            strSql2.Append("C_dep_id=@dep_id,");
            strSql2.Append("C_dep_name=@dep_name,");
            strSql2.Append("C_emp_name=@emp_name");
            strSql2.Append(" where C_emp_id=@emp_id");

            StringBuilder strSql3 = new StringBuilder();
            strSql3.Append("UPDATE CRM_order SET ");
            strSql3.Append("F_dep_id=@dep_id,");
            strSql3.Append("F_dep_name=@dep_name,");
            strSql3.Append("F_emp_name=@emp_name");
            strSql3.Append(" where F_emp_id=@emp_id");

            StringBuilder strSql4 = new StringBuilder();
            strSql4.Append("UPDATE CRM_contract SET ");
            strSql4.Append("C_depid=@dep_id,");
            strSql4.Append("C_depname=@dep_name,");
            strSql4.Append("C_empname=@emp_name");
            strSql4.Append(" where C_empid=@emp_id");

            StringBuilder strSql5 = new StringBuilder();
            strSql5.Append("UPDATE CRM_contract SET ");
            strSql5.Append("Our_Contractor_depid=@dep_id,");
            strSql5.Append("Our_Contractor_depname=@dep_name,");
            strSql5.Append("Our_Contractor_name=@emp_name");
            strSql5.Append(" where Our_Contractor_id=@emp_id");

            StringBuilder strSql6 = new StringBuilder();
            strSql6.Append("UPDATE CRM_receive SET ");
            strSql6.Append("C_depid=@dep_id,");
            strSql6.Append("C_depname=@dep_name,");
            strSql6.Append("C_empname=@emp_name");
            strSql6.Append(" where C_empid=@emp_id");

            StringBuilder strSql7 = new StringBuilder();
            strSql7.Append("UPDATE CRM_receive SET ");
            strSql7.Append("C_depid=@dep_id,");
            strSql7.Append("C_depname=@dep_name,");
            strSql7.Append("C_empname=@emp_name");
            strSql7.Append(" where C_empid=@emp_id");

            StringBuilder strSql8 = new StringBuilder();
            strSql8.Append("UPDATE CRM_Customer SET ");
            strSql8.Append("BeSeats_depid=@dep_id,");
            strSql8.Append("BeSeats_depname=@dep_name,");
            strSql8.Append("BeSeats=@emp_name");
            strSql8.Append(" where BeSeats_id=@emp_id");

            MySqlParameter[] parameters = {					
					new MySqlParameter("@dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@dep_name", MySqlDbType.VarChar,50),
                    new MySqlParameter("@emp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,250)
					};

            parameters[0].Value = model.d_id;
            parameters[1].Value = model.dname;
            parameters[2].Value = model.ID;
            parameters[3].Value = model.name;



            int rows1 = DbHelperMySQL.ExecuteSql(strSql1.ToString(), parameters);
            int rows2 = DbHelperMySQL.ExecuteSql(strSql2.ToString(), parameters);
            int rows3 = DbHelperMySQL.ExecuteSql(strSql3.ToString(), parameters);
            int rows4 = DbHelperMySQL.ExecuteSql(strSql4.ToString(), parameters);
            int rows5 = DbHelperMySQL.ExecuteSql(strSql5.ToString(), parameters);
            int rows6 = DbHelperMySQL.ExecuteSql(strSql6.ToString(), parameters);
            int rows7 = DbHelperMySQL.ExecuteSql(strSql7.ToString(), parameters);
            int rows8 = DbHelperMySQL.ExecuteSql(strSql8.ToString(), parameters);
            if (rows1 > 0 && rows2 > 0 && rows3 > 0 && rows4 > 0 && rows5 > 0 && rows6 > 0 && rows7 > 0 && rows8 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion  Method
    }
}
