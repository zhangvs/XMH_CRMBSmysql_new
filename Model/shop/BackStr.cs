using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model.shop
{
    public class BackStr
    {
        public bool success { get; set; }
        public string msg { get; set; }
    }

    /// <summary>
    /// 用于修改税号
    /// </summary>
    public class BackStrTax : BackStr
    {
        public crm_contact_bill_check check { get; set; }
        public string code { get; set; }
    }
}
