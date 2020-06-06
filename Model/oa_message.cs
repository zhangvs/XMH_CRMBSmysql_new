/**  版本信息模板在安装目录下，可自行修改。
* oa_message.cs
*
* 功 能： N/A
* 类 名： oa_message
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/26 11:14:46   N/A    初版
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
    /// oa_message:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class oa_message
    {
        public oa_message()
        { }
        #region Model
        private int _id;
        private int? _receive_id;
        private string _msg_title;
        private string _msg_content;
        private int? _msg_status;
        private string _redirect_url;
        private string _create_man;
        private DateTime? _create_time;
        private string _tab_id;
        public string sys_shorthand { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 接收人ID
        /// </summary>
        public int? receive_id
        {
            set { _receive_id = value; }
            get { return _receive_id; }
        }
        /// <summary>
        /// 消息标题
        /// </summary>
        public string msg_title
        {
            set { _msg_title = value; }
            get { return _msg_title; }
        }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string msg_content
        {
            set { _msg_content = value; }
            get { return _msg_content; }
        }
        /// <summary>
        /// 0 未读 1 已读
        /// </summary>
        public int? msg_status
        {
            set { _msg_status = value; }
            get { return _msg_status; }
        }
        /// <summary>
        /// 跳转路径
        /// </summary>
        public string redirect_url
        {
            set { _redirect_url = value; }
            get { return _redirect_url; }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string create_man
        {
            set { _create_man = value; }
            get { return _create_man; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_time
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tab_id
        {
            set { _tab_id = value; }
            get { return _tab_id; }
        }
        #endregion Model

    }
}

