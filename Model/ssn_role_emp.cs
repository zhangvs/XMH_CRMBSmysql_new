﻿using System;
namespace XHD.Model
{
    /// <summary>
    /// ssn_role_emp:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ssn_role_emp
    {
        public ssn_role_emp()
        { }
        #region Model
        private int? _roleid;
        private int? _empid;
        /// <summary>
        /// 
        /// </summary>
        public int? RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? empID
        {
            set { _empid = value; }
            get { return _empid; }
        }
        #endregion Model

    }
}

