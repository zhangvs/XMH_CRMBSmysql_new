using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_Model
{
    /// <summary>
    /// 删除入库单类
    /// </summary>
    public class removeModel
    {
        /// <summary>
        /// 单据编号
        /// </summary>
        public string Fnumber { get; set; }
        /// <summary>
        /// 用户工号
        /// </summary>
        public string EmpCode { get; set; }
        /// <summary>
        /// 令牌
        /// </summary>
        public string Token { get; set; }

    }

    /// <summary>
    /// 金蝶接口返回类
    /// </summary>
    public class KingDee_Response
    {
        private bool _Success = false;
        private int _ErrorCode = -1;
        private string _msg = string.Empty;
        /// <summary>
        /// 返回结果
        /// </summary>
        public bool Success { get { return _Success; } set { _Success = value; } }
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorCode { get { return _ErrorCode; } set { _ErrorCode = value; } }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string msg { get { return _msg; } set { _msg = value; } }

    }


    /// <summary>
    ///   采购入库单
    /// </summary>
    public class PurchaseInOrder
    {
        /// <summary>
        /// ※单据编号  
        /// </summary>        
        public string FBillNo { get; set; }

        /// <summary>
        /// ※部门（hr_department表dept_code_kingdee字段）
        /// </summary>        
        public string FDept { get; set; }
        /// <summary>
        /// 业务员（工号）
        /// </summary>        
        public string FEmp { get; set; }
        /// <summary>
        /// ※单据类型  其中:ftrantype值表示单据类型如下：1-采购 21-销售 41-调拨 100-成本调整单
        /// </summary>        
        public string FTranType { get; set; }
        /// <summary>
        /// 业务日期 (制单日期)
        /// </summary>        
        public string BusinessDate { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>        
        public string supply { get; set; }

        /// <summary>
        /// (红蓝字)蓝字正常为1，红字退货为-1
        /// </summary>        
        public string FROB { get; set; }
        /// <summary>
        ///  ※验收人（发货人编码）
        /// </summary>        
        public string FFManager { get; set; }
        /// <summary>
        /// 保管（编码）
        /// </summary>        
        public string FSManager { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string Rrmark { get; set; }

        /// <summary>
        /// 总金额（含税）
        /// </summary>        
        public decimal? totalprice { get; set; }
        /// <summary>
        /// 出入库单明细
        /// </summary>
        public List<OutInStoreOrderEntry> orderList { get; set; }

        private string _iskaipiao = "是";
        /// <summary>
        /// 是否开票
        /// </summary>
        public string iskaipiao { get { return _iskaipiao; } set { _iskaipiao = value; } }

        /// <summary>
        ///  //用户工号
        /// </summary>
        public string EmpCode { get; set; }
        /// <summary>
        ///  //令牌
        /// </summary>
        public string Token { get; set; }
    }


    /// <summary>
    /// 采购入库单附表
    /// </summary>
    public class OutInStoreOrderEntry
    {
        /// <summary>
        /// 商品编码  
        /// </summary>      
        public string FNumber { get; set; }
        /// <summary>
        ///  计量单位       
        /// </summary>       
        public string UnitName { get; set; }
        /// <summary>
        /// ※数量
        /// </summary>
        public decimal FQty { get; set; }
        /// <summary>
        /// 单价(含税)
        /// </summary>
        public decimal FPrice { get; set; }
        /// <summary>
        /// 金额（含税）
        /// </summary>
        public decimal FAmount { get; set; }
        /// <summary>
        /// ※收货仓库  
        /// </summary>
        public string FDCStock { get; set; }
        /// <summary>
        /// 发货仓库  
        /// </summary>
        public string FSCStockID { get; set; }
        /// <summary>
        ///※ 单据编号
        /// </summary>
        public string FBillNo { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string Pihao { get; set; }
        ///<summary>
        ///采购日期
        ///</summary>
        public string PurchaseDate { get; set; }
        ///<summary>
        ///保质期
        ///</summary>
        public string Baozhiqi { get; set; }
        ///<summary>
        ///有效期
        ///</summary>
        public string Youxiaoqi { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Rrmark { get; set; }
        /// <summary>
        /// 税额
        /// </summary>
        public decimal? TaxAmount { get; set; }


    }




    /// <summary>
    /// 金蝶销售出库主表
    /// </summary>
    public class SellOutOrder    //※必填
    {
        public string FBillNo { get; set; }  //※单据编号
        public string Customer { get; set; }   //客户编号
        public string CoustemorReceiveInfor { get; set; }  //客户收货地址
        public string FDept { get; set; } //※部门（hr_department表dept_code_kingdee字段）
        public string FEmp { get; set; }  //※客服（工号）
        public string FTranType { get; set; } // ※单据类型 其中:ftrantype值表示单据类型如下：1-采购 21-销售 41-调拨 100-成本调整单
        public string BusinessDate { get; set; }//※业务日期
        public string FROB { get; set; }  //※正常为1，退货为-1
        public string FFManager { get; set; }  //发货人编码
        public string FSManager { get; set; } //保管（编码）
        public string FManager { get; set; }  //主管（编码）
        public string Rrmark { get; set; }//概要
        public string dinghuoren { get; set; } //订货人姓名 
        public string dianhua { get; set; }  //电话
        public string iskaipiao { get; set; }//是否开票（中文是或否）
        public decimal totalprice { get; set; }  // 总金额（含税）
        public string FNumber { get; set; } //客户编码
        public string FName { get; set; } //客户名称
        public string FAddress { get; set; } //地址
        public string FPhone { get; set; }  //电话号码
        public string CustomerService { get; set; }  //所属客服
        public string CustomerKind { get; set; }  //客户分类(例:中国,山东,临沂)
        public string EmpCode { get; set; } //用户工号
        public string Token { get; set; } //令牌

        private List<SellOrderEntry> _orderList = new List<SellOrderEntry>();

        /// <summary>
        /// 销售换货副表
        /// </summary>
        public List<SellOrderEntry> orderList { get { return _orderList; } set { _orderList = value; } }
    }

    /// <summary>
    /// 产品类(金蝶销售出库附表)
    /// </summary>
    public class SellOrderEntry
    {
        public string FNumber { get; set; }  //商品编码
        public string UnitName { get; set; } //计量单位 
        public decimal FQty { get; set; } //※数量
        public decimal FPrice { get; set; } //单价(含税) 
        public decimal FAmount { get; set; }  //金额（含税）
        public string FDCStock { get; set; } //※收货仓库
        public string FSCStock { get; set; } //发货仓库
        public string FBillNo { get; set; }  // ※单据编号
        public string orderNo { get; set; } //订单号
        public string Rrmark { get; set; } //备注
    }

    //调账
    public class OtherReceiveBill
    {
        /// <summary>
        /// //※收款单编号
        /// </summary>
        public string FNumber { get; set; }

        /// <summary>
        ///  //※核算项目类别 , 1为客户,2为部门,3为职员,4为物料,5为仓库, 7为计量单位,8为供应商,9为现金科目,10为分支机构,2001为成本对象,
        /// </summary>
        public int FItemClassID { get; set; }

        /// <summary>
        ///  //※核算项目编码(客户/供应商)
        /// </summary>
        public string FCustomer { get; set; }
        /// <summary>
        ///  //※金额
        /// </summary>
        public decimal FAmount { get; set; }
        /// <summary>
        /// //※事务类型 其它应收单为1000021、其它应付单为1000022
        /// </summary>
        public int FClassTypeID { get; set; }
        /// <summary>
        /// //财务日期
        /// </summary>
        public string FincDate { get; set; }
        /// <summary>
        ///  //摘要
        /// </summary>
        public string FExplanation { get; set; }
        /// <summary>
        ///  //借方科目代码
        /// </summary>
        public string FAccountID { get; set; }
        /// <summary>
        ///  //贷方科目代码
        /// </summary>
        public string FAPAcctID { get; set; }
        /// <summary>
        /// //部门(编码)
        /// </summary>
        public string Dept { get; set; }
        /// <summary>
        /// //业务员(编码)
        /// </summary>
        public string FEmp { get; set; }
        /// <summary>
        /// //用户工号
        /// </summary>
        public string EmpCode { get; set; }
        /// <summary>
        /// //令牌
        /// </summary>
        public string Token { get; set; }

    }

    //认款
    public class ReceiveBill
    {

        /// <summary>
        /// //※收款单编号
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// //※核算项目类别 , 1为客户,2为部门,3为职员,4为物料,5为仓库, 7为计量单位,8为供应商,9为现金科目,10为分支机构,2001为成本对象,
        /// </summary>
        public int FItemClassID { get; set; }
        /// <summary>
        ///  //※核算项目编码(客户/供应商)
        /// </summary>
        public string FCustomer { get; set; }
        /// <summary>
        /// //※金额
        /// </summary>
        public decimal FAmount { get; set; }
        /// <summary>
        /// //支付方式
        /// </summary>
        public string FSettle { get; set; }
        /// <summary>
        /// //※事务类型 收款单为1000005、销售退款为1000015、付款单为1000016、采购退款单为1000017
        /// </summary>
        public int FClassTypeID { get; set; }
        /// <summary>
        /// //财务日期
        /// </summary>
        public string FincDate { get; set; }
        /// <summary>
        /// //往来科目
        /// </summary>
        public string Wanglaikemu { get; set; }

        private string _Remark = "";
        /// <summary>
        /// 备注摘要
        /// </summary>
        public string Remark { get { return _Remark; } set { _Remark = value; } }

        private string _Dept = "";
        /// <summary>
        /// 部门(编码)
        /// </summary>
        public string Dept { get { return _Dept; } set { _Dept = value; } }

        private string _FEmp = "";
        /// <summary>
        /// 业务员(编码)
        /// </summary>
        public string FEmp { get { return _FEmp; } set { _FEmp = value; } }

        /// <summary>
        /// 用户工号
        /// </summary>
        public string EmpCode { get; set; }

        /// <summary>
        /// 令牌
        /// </summary>
        public string Token { get; set; }
    }

    //删除发票
    public class DeleteOrder
    {
        private List<string> _Fnumbers = new List<string>();
        public List<string> Fnumbers { get { return _Fnumbers; } set { _Fnumbers = value; } }

        public string EmpCode { get; set; }//用户工号
        public string Token { get; set; } //令牌
    }


    //现金、银行日记账
    public class CashJournal
    {
        /// <summary>
        /// 唯一编码（财务顺序号）
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// ※核算项目类别 , 1为客户,2为部门,3为职员,4为物料,5为仓库, 7为计量单位,8为供应商,9为现金科目,10为分支机构,2001为成本对象,
        /// </summary>
        public int FItemClassID { get; set; }
        /// <summary>
        /// 核算项目编码
        /// </summary>
        public string FItemCode { get; set; }
        /// <summary>
        /// 对方科目
        /// </summary>
        public string FAccountId { get; set; }
        /// <summary>
        /// 借方金额
        /// </summary>
        public decimal FDebit { get; set; }
        /// <summary>
        /// 贷方金额
        /// </summary>
        public decimal FCredit { get; set; }
        /// <summary>
        /// 结算方式
        /// </summary>
        public string FSettlement { get; set; }
        /// <summary>
        /// 业务日期
        /// </summary>
        public string FDate { get; set; }
        /// <summary>
        /// 备注摘要
        /// </summary>
        public string FRemark { get; set; }
        /// <summary>
        /// 用户工号
        /// </summary>
        public string EmpCode { get; set; }
        /// <summary>
        /// 令牌
        /// </summary>
        public string Token { get; set; }
    }

}
