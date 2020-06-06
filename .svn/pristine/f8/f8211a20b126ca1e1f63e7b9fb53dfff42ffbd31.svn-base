using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references

namespace XHD.DAL
{
    public class auth
    {
        public auth() { }
        Sys_data_authority authority = new Sys_data_authority();

        /// <summary>
        /// 获取查询
        /// </summary>
        /// <param name="serchtxt"></param>
        /// <param name="emp_id"></param>
        /// <param name="optionid"></param>
        /// <param name="d_id"></param>
        /// <returns></returns>
        public string getAuthSys_View(DataSet dt, string serchtxt, int emp_id, int optionid, int d_id)
        {
            if (dt.Tables[0].Rows.Count > 0)
            {
                try
                {
                    int sys_view = int.Parse(dt.Tables[0].Rows[0].ItemArray[0].ToString());
                    switch (sys_view)
                    {
                        case 1:
                            serchtxt += " and UserId=" + emp_id + "";
                            break;
                        case 2:
                            serchtxt += " and DtypeId= " +  d_id  +  "";
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        default: break;
                    }
                }
                catch
                {
                }
            }
            return serchtxt;
        }
    }


}
