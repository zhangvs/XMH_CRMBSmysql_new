using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using XHD.Common;
using XHD.DBUtility;
using XMH.crmService.Data;

namespace crmService
{
    public partial class crmNodeFeatService : ServiceBase
    {
        //private System.Timers.Timer timerOnlinePull = null;


        //public wmsWuLiuService()
        //{
        //    InitializeComponent();
        //}

        //protected override void OnStart(string[] args)
        //{
        //    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log.txt", true))
        //    {
        //        sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Start.");
        //    }
        //    //时间计数器，开启
        //    timerOnlinePull = new System.Timers.Timer();
        //    try
        //    {
        //        timerOnlinePull.Elapsed += timerOnlineTime_Elapsed;
        //        double interval = 6000;
        //        timerOnlinePull.Interval = interval;
        //        timerOnlinePull.Enabled = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //void timerOnlineTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    try
        //    {
        //        this.timerOnlinePull.Enabled = false;
        //        Thread contractEffect = new Thread(this.OnlinePull);    //开启线程
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        ////执行方法
        //private void OnlinePull()
        //{
        //    string strWhere = "";
        //    try
        //    {
        //        StringBuilder strSql = new StringBuilder();
        //        strSql.Append("select UserID,UserName,LastLogTime ");
        //        strSql.Append(" FROM Sys_online ");
        //        if (strWhere.Trim() != "")
        //        {
        //            strSql.Append(" where " + strWhere);
        //        }
        //        DataSet ds1= DbHelperMySQL.Query(strSql.ToString());
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //protected override void OnStop()
        //{
        //    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log.txt", true))
        //    {
        //        sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Stop.");
        //    }
        //}

        readonly Timer _timer;

        private static readonly string FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + "test.txt";
        // string strFileName = AppDomain.CurrentDomain.BaseDirectory;  //获取当前程序运行路径

        public crmNodeFeatService()
        {
            InitializeComponent();

            _timer = new Timer(60000)  //14400000=4小时 18000000=5小时 1200000 20分钟 执行一次     25000
            {
                AutoReset = true,
                Enabled = true
            };

            #region 业绩节点，自动抓取
            _timer.Elapsed += delegate(object sender, ElapsedEventArgs e)
            {
                this.witre(string.Format("Run DateTime '{0}'", DateTime.Now.ToString()));
                DateTime dtNow = DateTime.Now;
                //执行时间段 凌晨0点 至 5点 执行程序
                //if (dtNow.Hour > 5)
                //{
                //    //当前时间段不执行
                //    //return;
                //}

                #region 客户自动业绩抓取
                try
                {
                    //执行规则
                    Receivable_Acc acc = new Receivable_Acc();
                    string strFactory = "1000";                     //新明辉1000
                    string strStart = "2016-07-01 00:00:00";        //开始时间
                    string strEnd = "2016-09-30 59:59:00";          //截至时间

                    acc.SetDelete(strFactory);                      //删除公客/私客回收站里的客户，彻底从数据库中删除
                    acc.SetMoveCustomer(strFactory);                //转移所有客户
                    acc.SetCustomer_protect(strEnd);                //保护的客户,申保的客户type=1
                    acc.SetCustomer_CreateDate(strFactory, strStart, strEnd);   //创建时间在期间的 type=2
                    acc.SetYeJiMove(strFactory, strStart, strEnd);              //业绩达标的type=3

                    string strStartYear = "2016-02-15 00:00:00";        //年期初时间
                    acc.SetYingShou(strFactory, strStartYear, strEnd);  //应收款项》0的 type=4
                    acc.SetCustomer_Employee(strFactory);               //不转的客户的客户 type=5

                    //按客服分组转移客户
                    acc.SetDoAction();

                    /*
                    //执行项目
                    string strItem = "";
                    //当前年
                    int iYear = DateTime.Now.Year;      //年当前
                    string type = string.Empty;
                    string factory_Id = "1000";
                    DataSet dsx = DbHelperMySQL.Query(string.Format(@"select Id,factory_Id,current_year,pri_Year,pri_Season,pri_Month,pri_Week,pri_Time,C_createId,
                                            C_createName,C_createDate FROM crm_set_pripub current_year='{0}' and factory_Id='{1}'", iYear, factory_Id));

                    if (dsx != null & dsx.Tables.Count > 0 && dsx.Tables[0].Rows.Count > 0)
                    {
                        string strpri_Year = dsx.Tables[0].Rows[0]["pri_Year"].ToString().Trim();       //年执行
                        string strpri_Season = dsx.Tables[0].Rows[0]["pri_Season"].ToString().Trim();   //季执行
                        string strpri_Month = dsx.Tables[0].Rows[0]["pri_Month"].ToString().Trim();     //月执行
                        string strpri_Week = dsx.Tables[0].Rows[0]["pri_Season"].ToString().Trim();     //周执行
                        string strpri_Time = dsx.Tables[0].Rows[0]["pri_Time"].ToString().Trim();       //时间段执行

                        if (strpri_Year == "1") { type = "year"; }
                        else if (strpri_Season == "1") { type = "season"; }
                        else if (strpri_Month == "1") { type = "month"; }
                        else if (strpri_Week == "1") { type = "week"; }
                        else if (strpri_Time == "1") { type = "time"; }
                    }
                    //执行抓取客户周期方式
                    if (!string.IsNullOrEmpty(type))
                    {
                        int nowDate = int.Parse(TimeParser.GenerateTimeStamp(DateTime.Now)); //转换时间戳

                        string sqlstr = "current_year='" + iYear + "' and factory_Id='" + factory_Id + "' and pripub_type='" + type + "'";
                        //查询当前时间的规则
                        sqlstr += " and " + nowDate + " between date_start and date_end";
                        //List<Model.crm_set_pripub_detail> lstPriPub_det = bllPriPub_det.GetModelList(sqlstr);
                    }

                    switch (strItem)
                    {
                        case "del": //删除公私客回收站数据，

                            break;
                        case "pro": //保护不转
                            break;
                        case "cycle": //周期内创建不转
                            break;
                        case "acc":  //应收款》0不转
                            break;
                        case "feat": //业绩
                            break;
                        case "emp":  //那些客服的客户不转

                            break;
                        default:
                            break;
                    }
                    */
                }
                catch (Exception)
                {
                    throw;
                }
                #endregion
            };
            #endregion
        }

        protected override void OnStart(string[] args)
        {
            this.witre(string.Format("Start DateTime {0}", DateTime.Now));
        }

        protected override void OnStop()
        {
            this.witre(string.Format("Stop DateTime {0}", DateTime.Now) + Environment.NewLine);
        }

        void witre(string context)
        {
            StreamWriter sw = File.AppendText(FileName);
            sw.WriteLine(context);
            sw.Flush();
            sw.Close();
        }
        private void OnlinePull(object sender, ElapsedEventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            try
            {
                //查询获取我的客户表内的记录，抓取记录，
                DataSet ds = DbHelperMySQL.Query("select * FROM crm_grab_notes");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        //获取结束时间
                        DateTime end_time = DateTime.Parse(ds.Tables[0].Rows[i]["end_time"].ToString());
                        //比较当前时间和结束时间，如果当前时间超过结束时间
                        if (dtNow > end_time)
                        {
                            //获取跑批配置表的规则，获取业绩配置
                            DataSet ds_rule = DbHelperMySQL.Query("select * FROM crm_set_grabrule");
                            string feat = ds_rule.Tables[0].Rows[i]["feat"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GenerateTimeStamp(DateTime dt)
        {
            // Default implementation of UNIX time of the current UTC time
            TimeSpan ts = dt.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }
}