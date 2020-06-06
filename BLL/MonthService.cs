using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XHD.Model;

namespace XHD.BLL
{
    public partial class MonthService
    {
        public static string getMonthColumn(string month)
        {
            string monthColumn="";
                switch (month)
                {
                    case "1": monthColumn = "plan_jan";
                        break;
                    case "2": monthColumn = "plan_feb";
                        break;
                    case "3": monthColumn = "plan_mar";
                        break;
                    case "4": monthColumn = "plan_apr";
                        break;
                    case "5": monthColumn = "plan_may";
                        break;
                    case "6": monthColumn = "plan_jun";
                        break;
                    case "7": monthColumn = "plan_jul";
                        break;
                    case "8": monthColumn = "plan_aug";
                        break;
                    case "9": monthColumn = "plan_sep";
                        break;
                    case "10": monthColumn = "plan_oct";
                        break;
                    case "11": monthColumn = "plan_nov";
                        break;
                    case "12": monthColumn = "plan_dec";
                        break;
                }
                return monthColumn;
        }
    }
}
