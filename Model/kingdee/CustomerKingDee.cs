using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model.kingdee
{
    public partial class CustomerKingDee
    {
        public string FNumber { get; set; }
        /// <summary>
        /// ※客户名称 
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string FAddress { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string FPhone { get; set; }
        /// <summary>
        /// 增值税率
        /// </summary>
        public string KeHuFuZeRen { get; set; }
        public string Kehufenlei { get; set; }

    }

    public partial class CustomerKingDeeS 
    {
        public string FNumber { get; set; }
        /// <summary>
        /// ※客户名称 
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string FAddress { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string FPhone { get; set; }
        /// <summary>
        /// 增值税率
        /// </summary>
        public string KeHuFuZeRen { get; set; }
        public string Kehufenlei { get; set; }
        /// <summary>
        /// 客户的税号已逗号分隔
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// 客户原税号，用于税号修改
        /// </summary>
        public string OldTaxCode { get; set; }
    }

    public partial class CustomerKingDeeList
    {
        public string strJson { get; set; }
        public string Token { get; set; }
        public string EmpCode { get; set; }
    }

    public partial class KingDeeBack
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public int ErrorCode { get; set; }
    }

    /// <summary>
    /// 供应商信息类
    /// </summary>
    public class SupplierKingDee
    {
        /// <summary>
        /// 供应商编码
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// ※供应商名称 
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 供应商地址
        /// </summary>
        public string FAddress { get; set; }
        /// <summary>
        /// 供应商电话
        /// </summary>
        public string FPhone { get; set; }
        /// <summary>
        /// 增值税率(例：17,默认为0)
        /// </summary>
        public decimal FValueAddRate { get; set; }

        /// <summary>
        /// 供应商分组
        /// </summary>
        public string FGroup { get; set; }
    }

    /// <summary>
    /// 删除对象
    /// </summary>
    public class CustomerDel
    {
        /// <summary>
        /// 客户id用于内账
        /// </summary>
        public string IdList { get; set; }

        /// <summary>
        /// 客户税号用于外账
        /// </summary>
        public string TaxList { get; set; }
    }

    /// <summary>
    /// 外账税号修改
    /// </summary>
    public class CustomerTax : CustomerKingDee
    {
        /// <summary>
        /// 客户税号用于外账
        /// </summary>
        public string NewFnumber { get; set; }
    }
}
