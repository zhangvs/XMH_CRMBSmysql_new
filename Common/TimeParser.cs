using System;
using System.Collections.Generic;
using System.Text;

namespace XHD.Common
{
    public class TimeParser
    {
        /// <summary>
        /// ����ת���ɷ���
        /// </summary>
        /// <returns></returns>
        public static int SecondToMinute(int Second)
        {
            decimal mm = (decimal)((decimal)Second / (decimal)60);
            return Convert.ToInt32(Math.Ceiling(mm));
        }

        #region ����ĳ��ĳ�����һ��
        /// <summary>
        /// ����ĳ��ĳ�����һ��
        /// </summary>
        /// <param name="year">���</param>
        /// <param name="month">�·�</param>
        /// <returns>��</returns>
        public static int GetMonthLastDate(int year, int month)
        {
            DateTime lastDay = new DateTime(year, month, new System.Globalization.GregorianCalendar().GetDaysInMonth(year, month));
            int Day = lastDay.Day;
            return Day;
        }
        #endregion

        #region ����ʱ���
        public static string timestampdiff(DateTime DateTime1, DateTime DateTime2)
        {
            string timestampdiff = null;
            try
            {
                //TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
                //TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
                //TimeSpan ts = ts1.Subtract(ts2).Duration();
                TimeSpan ts = DateTime2 - DateTime1;
                if (ts.Days >= 1)
                {
                    timestampdiff = DateTime1.Month.ToString() + "��" + DateTime1.Day.ToString() + "��";
                }
                else
                {
                    if (ts.Hours > 1)
                    {
                        timestampdiff = ts.Hours.ToString() + "Сʱǰ";
                    }
                    else
                    {
                        timestampdiff = ts.Minutes.ToString() + "����ǰ";
                    }
                }
            }
            catch
            { }
            return timestampdiff;
        }
        #endregion


        #region ConvertIntDateTimeʱ���תʱ��
        public static System.DateTime ConvertIntDateTime(double d)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddSeconds(d);
            //ar start = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);
            //return start.AddSeconds(timestamp);
            return time;
        }
        #endregion


        #region ʱ��תΪʱ���
        public static string GenerateTimeStamp(DateTime dt)
        {
            // Default implementation of UNIX time of the current UTC time  
            TimeSpan ts = dt.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
        #endregion


    }
}
