using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace XHD.BLL
{
    public class auth
    {
        private readonly XHD.DAL.auth dal = new XHD.DAL.auth();
        public auth() { }
        /// <summary>
        /// 获取查询
        /// </summary>
        /// <param name="serchtxt"></param>
        /// <param name="emp_id"></param>
        /// <param name="optionid"></param>
        /// <param name="d_id"></param>
        /// <returns></returns>
        public string getAuthSys_View(DataSet ds, string serchtxt, int emp_id, int optionid, int d_id)
        {
            return dal.getAuthSys_View(ds, serchtxt, emp_id, optionid, d_id);
        }
    }
}
