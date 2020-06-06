/**  版本信息模板在安装目录下，可自行修改。
* scm_spe_order_goods.cs
*
* 功 能： N/A
* 类 名： scm_spe_order_goods
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/24 14:13:55   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace XHD.Model
{
    /// <summary>
    /// scm_spe_order_goods:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class scm_spe_order_goods
    {
        public scm_spe_order_goods()
        { }
        #region Model
        private int _id;
        private int? _order_id;
        private int? _order_goodsid;
        private string _order_goodssn;
        private int? _goods_num;
        private decimal? _goods_price;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? order_id
        {
            set { _order_id = value; }
            get { return _order_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? order_goodsid
        {
            set { _order_goodsid = value; }
            get { return _order_goodsid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string order_goodssn
        {
            set { _order_goodssn = value; }
            get { return _order_goodssn; }
        }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int? goods_num
        {
            set { _goods_num = value; }
            get { return _goods_num; }
        }
        /// <summary>
        /// 商品单间
        /// </summary>
        public decimal? goods_price
        {
            set { _goods_price = value; }
            get { return _goods_price; }
        }
        #endregion Model

    }
}

