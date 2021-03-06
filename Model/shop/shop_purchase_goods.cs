﻿/**  版本信息模板在安装目录下，可自行修改。
* shop_purchase_goods.cs
*
* 功 能： N/A
* 类 名： shop_purchase_goods
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/2 14:54:59   N/A    初版
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
    /// shop_purchase_goods:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_purchase_goods
    {
        public shop_purchase_goods()
        { }
        #region Model
        private int _gid;
        private int _oid;
        private int _rec_id;
        private int _from_order_id = 0;
        private int _user_type = 2;
        private int _customer_id;
        private int _user_id;
        private int _goods_id;
        private string _goods_sn2;
        private string _goods_sn;
        private string _goods_name;
        private int _brand_id;
        private decimal _old_price = 0.000M;
        private decimal _goods_price = 0.00M;
        private string _goods_unit;
        private string _goods_desc;
        private int _goods_number = 0;
        private int _booking_time = 0;
        private int _p_status = 10;
        private string _dispose_user;
        private int _dispose_time = 0;
        private string _dispose_note;
        private int _demand_time;
        private int _grade = 1;
        private int _reviewer = 0;
        private int _is_paid = 0;
        private int _is_remind = 1;
        private int _arrive_time;
        private int _last_update_time;
        private int _is_show;
        private string _already_bought = "-";
        private string _emp_code;
        /// <summary>
        /// 
        /// </summary>
        public int gid
        {
            set { _gid = value; }
            get { return _gid; }
        }
        /// <summary>
        /// 采购订单id
        /// </summary>
        public int oid
        {
            set { _oid = value; }
            get { return _oid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int rec_id
        {
            set { _rec_id = value; }
            get { return _rec_id; }
        }
        /// <summary>
        /// 销售订单id
        /// </summary>
        public int from_order_id
        {
            set { _from_order_id = value; }
            get { return _from_order_id; }
        }
        /// <summary>
        /// 1客户 2 管理员
        /// </summary>
        public int user_type
        {
            set { _user_type = value; }
            get { return _user_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int customer_id
        {
            set { _customer_id = value; }
            get { return _customer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int goods_id
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_sn2
        {
            set { _goods_sn2 = value; }
            get { return _goods_sn2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_sn
        {
            set { _goods_sn = value; }
            get { return _goods_sn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int brand_id
        {
            set { _brand_id = value; }
            get { return _brand_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal old_price
        {
            set { _old_price = value; }
            get { return _old_price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal goods_price
        {
            set { _goods_price = value; }
            get { return _goods_price; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string goods_unit
        {
            set { _goods_unit = value; }
            get { return _goods_unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_desc
        {
            set { _goods_desc = value; }
            get { return _goods_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int goods_number
        {
            set { _goods_number = value; }
            get { return _goods_number; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int booking_time
        {
            set { _booking_time = value; }
            get { return _booking_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int p_status
        {
            set { _p_status = value; }
            get { return _p_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dispose_user
        {
            set { _dispose_user = value; }
            get { return _dispose_user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int dispose_time
        {
            set { _dispose_time = value; }
            get { return _dispose_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dispose_note
        {
            set { _dispose_note = value; }
            get { return _dispose_note; }
        }
        /// <summary>
        /// 求需时间默认三天后
        /// </summary>
        public int demand_time
        {
            set { _demand_time = value; }
            get { return _demand_time; }
        }
        /// <summary>
        /// 紧急程度 1不紧急 2 紧急 3 非常紧急
        /// </summary>
        public int grade
        {
            set { _grade = value; }
            get { return _grade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int reviewer
        {
            set { _reviewer = value; }
            get { return _reviewer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_paid
        {
            set { _is_paid = value; }
            get { return _is_paid; }
        }
        /// <summary>
        /// 否是qq提醒
        /// </summary>
        public int is_remind
        {
            set { _is_remind = value; }
            get { return _is_remind; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int arrive_time
        {
            set { _arrive_time = value; }
            get { return _arrive_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int last_update_time
        {
            set { _last_update_time = value; }
            get { return _last_update_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_show
        {
            set { _is_show = value; }
            get { return _is_show; }
        }
        /// <summary>
        /// 是否已经采买标志 √:已经采购  -:未采购
        /// </summary>
        public string already_bought
        {
            set { _already_bought = value; }
            get { return _already_bought; }
        }
        public string emp_code
        {
            set { _emp_code = value; }
            get { return _emp_code; }
        }
        #endregion Model

    }
}

