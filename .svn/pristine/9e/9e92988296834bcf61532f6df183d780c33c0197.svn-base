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

namespace XMH.crmService
{
    partial class imsNodeFeatService : ServiceBase
    {
        readonly Timer _timer;

        private static readonly string FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + "test.txt";
        // string strFileName = AppDomain.CurrentDomain.BaseDirectory;  //获取当前程序运行路径

        public imsNodeFeatService()
        {
            InitializeComponent();

            _timer = new Timer(14400000)  //14400000=4小时 18000000=5小时 1200000 20分钟 执行一次     25000
            {
                AutoReset = true,
                Enabled = true
            };

            #region 自动统计积分
            _timer.Elapsed += delegate(object sender, ElapsedEventArgs e)
            {
                //string nowTime = DateTime.Now.ToString("HH:mm:ss");

                DateTime dtNow = DateTime.Now;
                //执行时间段 凌晨0点 至 5点 执行程序
                if (dtNow.Hour > 5 )
                {
                    //当前时间段不执行
                    //return;
                }
                else
                {
                    this.witre(string.Format("----IMS_Start DateTime {0}", DateTime.Now));

                    #region 自动统计积分
                    try
                    {
                        string search = " h.d_id !='1354'  and h.Factory_Id='1000' ";   //离职人员

                        string strWhereOne = " score_source=1 and is_scoring='0' ";  //ims_emp_score
                        string strWhereTwo = " is_scoring='0' ";                     //oa_attend
                        string strWhereThree = " is_scoring='0' ";                   //ssn_qa_answer
                        string strWhereFoure = " is_scoring='0' ";                   //personal_score
                        string strWhereFive = " is_scoring='0' ";                    //ims_lead_score_average

                        int year = DateTime.Now.Year;   //当前年  
                        int mouth = DateTime.Now.Month; //当前月  

                        int beforeYear = 0;
                        int beforeMouth = 0;
                        if (mouth <= 1)                 //如果当前月是一月，那么年份就要减1  
                        {
                            beforeYear = year - 1;
                            beforeMouth = 12;           //上个月  
                        }
                        else
                        {
                            beforeYear = year;
                            beforeMouth = mouth - 1;    //上个月  
                        }

                        string beforeMouthOneDay = beforeYear + "年" + beforeMouth + "月" + 1 + "日";//上个月第一天  
                        string beforeMouthLastDay = Convert.ToDateTime(beforeYear + "-" + beforeMouth + "-" + DateTime.DaysInMonth(year, beforeMouth) + "").ToString("yyyy-MM-dd");//上个月最后一天

                        #region  查询条件
                        if (!string.IsNullOrEmpty(beforeMouthLastDay))
                        {
                            strWhereOne += " and check_date <='" + beforeMouthLastDay + "'";
                            strWhereFoure += " and CreateDate<='" + beforeMouthLastDay + "'";
                            strWhereThree += " and answer_time <='" + beforeMouthLastDay + "'";

                            strWhereTwo += " and attend_year<='" + year + "' and attend_month<='" + beforeMouth + "' ";
                            strWhereFive += " and year<='" + year + "' and month<='" + beforeMouth + "'";
                        }

                        #endregion


                        Data_Integral integral = new Data_Integral();

                        DataSet ds = integral.GetStatistics(search, strWhereOne, strWhereTwo, strWhereThree, strWhereFoure, strWhereFive);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            integral.RecordStatistics(ds.Tables[0], beforeYear, beforeMouth, beforeMouthLastDay);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    #endregion
                }             
            };

            #endregion
        }

        protected override void OnStart(string[] args)
        {
            this.witre(string.Format("IMS_Start DateTime {0}", DateTime.Now));
        }

        protected override void OnStop()
        {
            this.witre(string.Format("IMS_Stop DateTime {0}", DateTime.Now) + Environment.NewLine);
        }

        void witre(string context)
        {
            StreamWriter sw = File.AppendText(FileName);
            sw.WriteLine(context);
            sw.Flush();
            sw.Close();
        }
    }
}
