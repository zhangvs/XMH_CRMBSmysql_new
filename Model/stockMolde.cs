using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model
{
    public partial class stockMolde
    {
        public stockMolde()
        { }
        public string factory_id { get; set; }
        public int goods_id { get; set; }
        public int suppliers_id { get; set; }
        public string goods_sn2 { get; set; }

        public string goods_name { get; set; }
        public int brand_id { get; set; }
        public int cat_id { get; set; }
        public string goods_unit { get; set; }
        public int warn_number { get; set; }
        public string file_ip { get; set; }
        public int stockQry { get; set; }
        public decimal price { get; set; }
    }
}
