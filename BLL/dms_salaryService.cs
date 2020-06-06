using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// dms_salaryService
    /// </summary>
    public partial class dms_salaryService
    {
        private readonly XHD.DAL.dms_salaryDAO dal = new XHD.DAL.dms_salaryDAO();
        public dms_salaryService()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.dms_salary model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.dms_salary model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return dal.Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.dms_salary GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.dms_salary GetModelByCache(int id)
        {

            string CacheKey = "dms_salaryModel-" + id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.dms_salary)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.dms_salary> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.dms_salary> DataTableToList(DataTable dt)
        {
            List<XHD.Model.dms_salary> modelList = new List<XHD.Model.dms_salary>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.dms_salary model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 更新团队奖励，单品，电话，积分，id
        /// </summary>
        public bool UpdateTeamBonus(decimal team_carve_bonus, decimal good_bonus, decimal phone_bonus, decimal point_bonus, string name, int id)
        {
            return dal.UpdateTeamBonus(team_carve_bonus, good_bonus, phone_bonus, point_bonus, name, id);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteBySql(string sqlWhere)
        {
            return dal.DeleteBySql(sqlWhere);
        }

        /// <summary>
        /// 更新缺勤天数，工龄工资，根据年月，员工编号
        /// </summary>
        public bool Update_Attendance_SeniorityBonus(decimal absenceDays, decimal leave_days, decimal seniorityBonus, decimal meals_deductions, decimal social_deductions, decimal late_deductions, decimal shipping_deductions, decimal other_deductions, string admin_user_name, string year, string month)
        {
            return dal.Update_Attendance_SeniorityBonus(leave_days, absenceDays, seniorityBonus, meals_deductions, social_deductions,late_deductions, shipping_deductions, other_deductions, admin_user_name, year, month);
        }

        /// <summary>
        /// 更新团队奖励，单品，电话，积分，根据年月，员工编号
        /// </summary>
        public bool Update_Team_Carvebonus_FromExcel(decimal team_carve_bonus, decimal good_bonus, decimal phone_bonus, decimal point_bonus, string admin_user_name, string year, string month)
        {
            return dal.Update_Team_Carvebonus_FromExcel(team_carve_bonus, good_bonus, phone_bonus, point_bonus, admin_user_name, year, month);
        }

        /// <summary>
        /// 获得未分配团队奖
        /// </summary>
        public DataSet GetListTeamBonusUndistributed(string year, string month)
        {
            return dal.GetListTeamBonusUndistributed(year, month);
        }

        /// <summary>
        /// 导入考勤数据，就不能再分配团队奖
        /// </summary>
        public DataSet GetListImportAttendance(string year, string month)
        {
            return dal.GetListImportAttendance(year, month);
        }

        /// <summary>
        /// 已分配团队奖合计
        /// </summary>
        public DataSet GetListAssignedTeamBonus(string year, string month, string d_pid)
        {
            return dal.GetListAssignedTeamBonus(year, month, d_pid);
        }
        #endregion  ExtensionMethod
    }
}

