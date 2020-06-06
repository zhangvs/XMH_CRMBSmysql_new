using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Common
{
    public class ColumnNameEnum
    {
        public string getColumnName(string columnCode)
        {
            string columnName="";
            switch (columnCode)
            {
                case "id":
                    columnName = "编号";
                    break;
                case "year":
                    columnName = "年";
                    break;
                case "month":
                    columnName = "月";
                    break;
                case "name":
                    columnName = "姓名";
                    break;
                case "admin_user_name":
                    columnName = "客服ID";
                    break;
                case "d_pid":
                    columnName = "部门ID";
                    break;
                case "d_pname":
                    columnName = "部门名称";
                    break;
                case "xy_1000":
                    columnName = "销售额<1千的客户数";
                    break;
                case "dy_1000":
                    columnName = "销售额>=1千的客户数";
                    break;
                case "dy_5000":
                    columnName = "销售额>=5千的客户数";
                    break;
                case "dy_10000":
                    columnName = "销售额>=1万的客户数";
                    break;
                case "dy_20000":
                    columnName = "销售额>=2万的客户数";
                    break;
                case "grade":
                    columnName = "工资等级";
                    break;
                case "basic":
                    columnName = "基本工资";
                    break;
                case "percentage_sum":
                    columnName = "提成合计";
                    break;
                case "personal_champion":
                    columnName = "月冠军";
                    break;
                case "personal_champion1":
                    columnName = "节点1冠军奖";
                    break;
                case "personal_bonus1":
                    columnName = "节点1达标奖励";
                    break;
                case "personal_champion2":
                    columnName = "节点2冠军奖";
                    break;
                case "personal_bonus2":
                    columnName = "节点1节点2达标奖励";
                    break;
                case "personal_champion3":
                    columnName = "节点3冠军奖";
                    break;
                case "personal_bonus3":
                    columnName = "节点3达标奖励";
                    break;
                case "personal_champion4":
                    columnName = "节点4冠军奖";
                    break;
                case "personal_bonus4":
                    columnName = "节点4达标奖励";
                    break;
                case "team_carve_bonus":
                    columnName = "团队奖分配";
                    break;
                case "good_bonus":
                    columnName = "单品奖励";
                    break;
                case "phone_bonus":
                    columnName = "电话量奖励";
                    break;
                case "point_bonus":
                    columnName = "积分奖励";
                    break;
                case "seniority_bonus":
                    columnName = "工龄工资";
                    break;
                case "bonus_sum":
                    columnName = "奖励合计";
                    break;
                case "absence_days":
                    columnName = "缺勤天数";
                    break;
                case "basic2":
                    columnName = "基本工资/30*缺勤天数";
                    break;
                case "leave_days":
                    columnName = "工作日请假天数";
                    break;
                case "percentage_sum2":
                    columnName = "提成合计/30*工作日请假天数";
                    break;
                case "bonus_sum2":
                    columnName = "奖励合计/30*工作日请假天数";
                    break;

                case "meals_deductions":
                    columnName = "餐费扣款";
                    break;
                case "social_deductions":
                    columnName = "社保扣款";
                    break;
                case "late_deductions":
                    columnName = "迟到扣款";
                    break;
                case "shipping_deductions":
                    columnName = "退货运费扣款";
                    break;
                case "other_deductions":
                    columnName = "其他扣款";
                    break;
                case "deductions_sum":
                    columnName = "扣款合计";
                    break;

                case "salary_sum":
                    columnName = "工资合计";
                    break;
                case "create_time":
                    columnName = "创建时间";
                    break;
                case "create_name":
                    columnName = "创建人";
                    break;
                case "factory_id":
                    columnName = "单位";
                    break;

                //生成客户年报excel使用
                case "user_id":
                    columnName = "客户id";
                    break;
                case "user_name":
                    columnName = "电话";
                    break;
                case "u_company":
                    columnName = "客户";
                    break;
                case "year_count":
                    columnName = "拿货次数";
                    break;
                case "year_frequency":
                    columnName = "拿货频率(天/次)";
                    break;
                case "salemoney":
                    columnName = "销售额";
                    break;
                case "backmoney":
                    columnName = "退货额";
                    break;
                case "realmoney":
                    columnName = "实际销售额";
                    break;
                case "orderyear":
                    columnName = "年份";
                    break;











            }
            return columnName;
        }

    };
}
