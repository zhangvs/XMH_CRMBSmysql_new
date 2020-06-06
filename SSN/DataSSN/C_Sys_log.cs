using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XHD.Common;

namespace SSN.DataSSN
{
    public class C_Sys_log
    {
        public C_Sys_log() { }

        public void Add_log(int uid, string uname, string ip, string EventTitle, string EventType, int EventID, string Remind_name, string Original_txt, string Current_txt, string factory_Id)
        {
            XHD.BLL.Sys_log log = new XHD.BLL.Sys_log();
            XHD.Model.Sys_log modellog = new XHD.Model.Sys_log();

            modellog.EventDate = DateTime.Now;
            modellog.UserID = uid;
            modellog.UserName = PageValidate.InputText(uname, 255);
            modellog.IPStreet = PageValidate.InputText(ip, 255);

            modellog.EventTitle = PageValidate.InputText(EventTitle, 255);

            modellog.EventType = PageValidate.InputText(EventType, 255);
            modellog.EventID = EventID.ToString();
            modellog.Original_txt = "【" + PageValidate.InputText(Remind_name, 255) + "】" + PageValidate.InputText(Original_txt, int.MaxValue);
            modellog.Current_txt = "【" + PageValidate.InputText(Remind_name, 255) + "】" + PageValidate.InputText(Current_txt, int.MaxValue);
            modellog.Factory_Id = factory_Id;

            log.Add(modellog);
        }
    }
}