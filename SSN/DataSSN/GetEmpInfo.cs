using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SSN.DataSSN
{
    public class GetEmpInfo
    {
        public GetEmpInfo() { }

        public  XHD.Model.hr_employee GetEmpModel(HttpRequest Request)
        {

            XHD.BLL.hr_employee emp = new XHD.BLL.hr_employee();
            var cookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            string CoockiesID = ticket.UserData;
            string name = ticket.Name;
            int emp_id = int.Parse(CoockiesID);
            string empname = string.Empty;
            string uid = string.Empty;
            string factory_Id = string.Empty;
            string d_id = string.Empty;
            string dname = string.Empty;
            XHD.Model.hr_employee empModel = emp.GetModel(Convert.ToInt32(emp_id));

            return empModel;
        }

    }
}