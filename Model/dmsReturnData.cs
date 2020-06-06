using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model
{
    /// <summary>
    /// bzsldygx:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class dmsReturnData
    {
        public dmsReturnData()
        { }
        public decimal salemoney { get; set; }
        public decimal backmoney { get; set; }
        public decimal realmoney { get; set; }
        public string orderdate { get; set; }

    }
}

