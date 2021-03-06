﻿using System;
namespace XHD.Model
{
    /// <summary>
    /// ecs_brand_percentage:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ecs_brand_percentage
    {
        public ecs_brand_percentage()
        { }
        #region Model
        private int _bp_id;
        private int? _bp_brand_id;
        private string _bp_brand_name;
        private decimal? _bp_percentage;
        private string _bp_year;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int bp_id
        {
            set { _bp_id = value; }
            get { return _bp_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? bp_brand_id
        {
            set { _bp_brand_id = value; }
            get { return _bp_brand_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bp_brand_name
        {
            set { _bp_brand_name = value; }
            get { return _bp_brand_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? bp_percentage
        {
            set { _bp_percentage = value; }
            get { return _bp_percentage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bp_year
        {
            set { _bp_year = value; }
            get { return _bp_year; }
        }
        #endregion Model

    }
}

