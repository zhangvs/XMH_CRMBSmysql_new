using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using XHD.Common;

namespace SSN.DataSSN
{
    /// <summary>
    /// SSN_Article 的摘要说明
    /// </summary>
    public class SSN_Article : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            XHD.BLL.ssn_art _art = new XHD.BLL.ssn_art();
            XHD.BLL.ssn_authority _authority = new XHD.BLL.ssn_authority();
            XHD.BLL.ssn_art_menu _menu = new XHD.BLL.ssn_art_menu();
            XHD.BLL.ssn_role _role = new XHD.BLL.ssn_role();
            XHD.BLL.ssn_visit _visit = new XHD.BLL.ssn_visit();

            C_Sys_log log = new C_Sys_log();

            XHD.Model.ssn_art model = new XHD.Model.ssn_art();

            var cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];
            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            string CoockiesID = ticket.UserData;

            XHD.BLL.hr_employee emp = new XHD.BLL.hr_employee();
            int emp_id = int.Parse(CoockiesID);
            DataSet dsemp = emp.GetList("id=" + emp_id);
            string empname = string.Empty;
            string uid = string.Empty;
            string factory_Id = string.Empty;
            if (dsemp != null && dsemp.Tables[0].Rows.Count > 0)
            {
                empname = dsemp.Tables[0].Rows[0]["name"].ToString();
                uid = dsemp.Tables[0].Rows[0]["uid"].ToString();
                factory_Id = dsemp.Tables[0].Rows[0]["Factory_Id"].ToString();
            }

            #region 加载数据grid
            if (request["Action"] == "grid")
            {
                int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                string Total = string.Empty;

                string filedOrder = " Art_order desc,Id desc ";
                string strWhere = " ";

                strWhere += " factory_id ='" + factory_Id + "' and is_del=0 ";

                if (!string.IsNullOrEmpty(request["Art_Menu_Id"]))
                    strWhere += " and  Art_Menu_Id = '" + request["Art_Menu_Id"] + "'";


                DataSet ds = _art.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
                string dt = XHD.Common.GetGridJSON.DataTableToJSON1(ds.Tables[0], Total);
                context.Response.Write(dt);
            }
            #endregion

            #region  加载员工的所能操作的页面 tree
            else if (request["Action"] == "tree")
            {
                DataSet dk = null;
                if (uid != "admin")
                {
                    string serchtxt = " a.factory_Id = '" + factory_Id + "' and  a.App_ids='1' ";

                    serchtxt += "and r.empID='" + emp_id + "'";


                    DataSet ds = _authority.GetListAuth(serchtxt);
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        string menu_ids = "";
                        foreach (DataRow item in ds.Tables[0].Rows)
                        {
                            menu_ids += item["Menu_ids"].ToString();
                        }
                        menu_ids = PageValidate.InputText(menu_ids, int.MaxValue).Replace("m", "");
                        menu_ids = menu_ids.Substring(0, menu_ids.Length - 1);
                        dk = _menu.GetList(0, " factory_Id='" + factory_Id + "' and  Id in (" + menu_ids + ")", "Menu_order");
                    }
                }
                else
                {
                    dk = _menu.GetList(0, " factory_Id='" + factory_Id + "' and app_id=1", "Menu_order");
                }

                StringBuilder str = new StringBuilder();
                str.Append("[");
                str.Append(GetTreeString(0, dk.Tables[0]));
                str.Replace(",", "", str.Length - 1, 1);
                str.Append("]");
                context.Response.Write(str);
            }
            #endregion

            #region 保存save
            else if (request["Action"] == "save")
            {
                model.Art_title = XHD.Common.PageValidate.InputText(request["T_title"], 250);
                model.Art_Content = PageValidate.InputText(request["T_content"], int.MaxValue);
                model.Art_Content = HttpUtility.HtmlDecode(model.Art_Content);
                model.Art_title_en = GetSpellCode(model.Art_title); ;
                model.image_lst = PageValidate.InputText(request["images"], int.MaxValue);
                model.Art_order = int.Parse(request["T_Order"]);
                model.factory_Id = factory_Id;
                model.Art_Menu_Id = Convert.ToInt32(PageValidate.InputText(request["art_Menu_Id"], 50));

                string id = PageValidate.InputText(request["nid"], 50);
                if (!string.IsNullOrEmpty(id) && id != "null")
                {
                    DataSet ds = _art.GetList("Id=" + int.Parse(id));
                    DataRow dr = ds.Tables[0].Rows[0];


                    model.Id = int.Parse(id);

                    if (_art.Update(model))
                    {
                        #region 修改访问权限

                        //查询该文章原来属于哪些角色下
                        DataSet dm = _visit.GetList(" Factory_Id='" + factory_Id + "' and find_in_set('a" + model.Id + "', Art_id)");
                        if (dm != null && dm.Tables[0].Rows.Count > 0)
                        {
                            //此次修改的文章以前已分配过角色
                            string oldRoleId = string.Empty;                                //原来所属的角色
                            string newRoleId = string.Empty;
                            for (int i = 0; i < dm.Tables[0].Rows.Count; i++)
                            {
                                if (i == dm.Tables[0].Rows.Count - 1)
                                    oldRoleId += dm.Tables[0].Rows[i]["Role_id"].ToString();
                                else
                                    oldRoleId += dm.Tables[0].Rows[i]["Role_id"].ToString() + ',';
                            }

                            string artId = "a" + model.Id + ",";
                            if (!string.IsNullOrEmpty(request["role_Id"].ToString()))
                            {
                                newRoleId = request["role_Id"].ToString();
                                newRoleId = newRoleId.Substring(0, newRoleId.Length - 1);
                                _visit.UpdateN(oldRoleId, newRoleId, artId, factory_Id, model.Art_Menu_Id.Value, emp_id);
                            }
                            else
                            {
                                _visit.UpdateN(oldRoleId, "", artId, factory_Id, model.Art_Menu_Id.Value, emp_id);
                            }

                            log.Add_log(emp_id, empname, request.UserHostAddress, "访问权限修改", "访问权限修改", model.Id, "访问权限修改", oldRoleId, newRoleId, factory_Id);

                        }
                        else
                        {
                            //若所修改的文章原来没有分配角色，若传进来的role_Id不为空，则进行添加
                            if (!string.IsNullOrEmpty(request["role_Id"].ToString()))
                            {
                                string roleId = request["role_Id"].ToString();
                                roleId = roleId.Substring(0, roleId.Length - 1);
                                string[] listRole = roleId.Split(',');
                                foreach (var item in listRole)
                                {
                                    DataSet df = _visit.GetList("Role_id='" + item + "'and Menu_ids='" + model.Art_Menu_Id + "' and Factory_Id='" + factory_Id + "'");
                                    if (df != null && df.Tables[0].Rows.Count > 0)
                                    {
                                        //修改
                                        int rId = Convert.ToInt32(df.Tables[0].Rows[0]["id"].ToString());
                                        string art_id = df.Tables[0].Rows[0]["Art_id"].ToString();
                                        art_id += "a" + model.Id + ",";
                                        _visit.Updates(rId, art_id);
                                    }
                                    else
                                    {
                                        //保存
                                        XHD.Model.ssn_visit modelVisit = new XHD.Model.ssn_visit();
                                        modelVisit.Factory_Id = factory_Id;
                                        modelVisit.Role_id = Convert.ToInt32(item);
                                        modelVisit.App_ids = "1";
                                        modelVisit.Menu_ids = model.Art_Menu_Id.ToString();
                                        modelVisit.Art_id = "a" + model.Id + ",";
                                        modelVisit.Create_id = emp_id;
                                        modelVisit.Create_date = DateTime.Now;
                                        _visit.Add(modelVisit);
                                    }
                                }
                            }
                        }
                        #endregion

                        #region 日志

                        int UserID = emp_id;
                        string UserName = empname;
                        string IPStreet = request.UserHostAddress;
                        string EventTitle = "ssn资料修改";
                        string EventType = "ssn资料修改";
                        int EventID = model.Id;

                        if (dr["Art_title"].ToString() != request["T_title"])
                            log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "资料名", dr["Art_title"].ToString(), request["T_title"].ToString(), factory_Id);

                        if (dr["Art_Content"].ToString() != request["T_content"])
                            log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "内容", dr["Art_Content"].ToString(), model.Art_Content, factory_Id);

                        if (dr["image_lst"].ToString() != request["images"])
                            log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "图片", dr["image_lst"].ToString(), request["images"].ToString(), factory_Id);

                        if (dr["Art_Menu_Id"].ToString() != request["art_Menu_Id"])
                            log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "页面Id", dr["Art_Menu_Id"].ToString(), request["art_Menu_Id"].ToString(), factory_Id);

                        #endregion

                        context.Response.Write("2"); //修改成功
                    }
                    else
                    {
                        context.Response.Write("3"); //修改失败
                    }
                }
                else
                {
                    model.is_del = 0;
                    model.Creater_Uid = uid;
                    model.Creater_Name = empname;
                    model.Create_Date = DateTime.Now;
                    model.Creater_Id = emp_id;
                    int artId = _art.Add(model);

                    if (artId > 0)
                    {
                        #region 保存访问权限
                        if (!string.IsNullOrEmpty(request["role_Id"].ToString()))
                        {
                            string roleId = request["role_Id"].ToString();
                            roleId = roleId.Substring(0, roleId.Length - 1);
                            string[] listRole = roleId.Split(',');
                            foreach (var item in listRole)
                            {
                                //查询该角色是否已有分配的文章记录
                                DataSet df = _visit.GetList("Role_id='" + item + "'and Menu_ids='" + model.Art_Menu_Id + "' and Factory_Id='" + factory_Id + "'");
                                if (df != null && df.Tables[0].Rows.Count > 0)
                                {
                                    //若已经记录，则修改
                                    int rId = Convert.ToInt32(df.Tables[0].Rows[0]["id"].ToString());
                                    string art_id = df.Tables[0].Rows[0]["Art_id"].ToString();
                                    art_id += "a" + artId + ",";
                                    if (_visit.Updates(rId, art_id))
                                    {
                                        context.Response.Write("1"); //保存成功
                                    }
                                    else
                                    {
                                        _art.Delete(artId);
                                        context.Response.Write("0"); //保存失败
                                    }
                                }
                                else
                                {
                                    //若没有记录，则保存
                                    XHD.Model.ssn_visit modelVisit = new XHD.Model.ssn_visit();
                                    modelVisit.Factory_Id = factory_Id;
                                    modelVisit.Role_id = Convert.ToInt32(item);
                                    modelVisit.App_ids = "1";
                                    modelVisit.Menu_ids = model.Art_Menu_Id.ToString();
                                    modelVisit.Art_id = "a" + artId + ",";
                                    modelVisit.Create_id = emp_id;
                                    modelVisit.Create_date = DateTime.Now;

                                    if (_visit.Add(modelVisit))
                                    {
                                        context.Response.Write("1"); //保存成功
                                    }
                                    else
                                    {
                                        _art.Delete(artId);
                                        context.Response.Write("0"); //保存失败
                                    }
                                }
                            }
                        }
                        else
                            context.Response.Write("1"); //保存成功
                        #endregion
                    }
                    else
                        context.Response.Write("0"); //保存失败
                }
            }
            #endregion

            #region form
            else if (request["Action"] == "form")
            {
                string artId = PageValidate.InputText(request["nid"], 50);
                string dt;

                if (PageValidate.IsNumber(artId))
                {
                    DataSet ds = _art.GetList("Id=" + artId);

                    dt = XHD.Common.DataToJson.DataToJSON(ds);
                }
                else
                {
                    dt = "{}";
                }

                context.Response.Write(dt);

            }
            #endregion

            #region 删除del
            else if (request["Action"] == "del")
            {
                string artId = PageValidate.InputText(request["id"], 50);

                bool num = _art.Delete(Convert.ToInt32(artId));
                if (num)
                    context.Response.Write("true");
            }
            #endregion

            #region 文章修改时获得查看权限 getRoleLiit
            else if (request["Action"] == "getRoleLiit")
            {
                string dt = string.Empty;

                string artId = PageValidate.InputText(request["nid"], 50);
                artId = "a" + artId;
                DataSet ds = _visit.GetList(" Factory_Id='" + factory_Id + "' and find_in_set('" + artId + "', Art_id)");

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    dt = XHD.Common.GetGridJSON.DataTableToJSON1(ds.Tables[0], "Total");
                }
                else
                {
                    dt = "{'Rows':[{'id':-9999}],'Total':'Total'}";
                }
                context.Response.Write(dt);
            }
            #endregion

            #region GetRole 获得所有角色
            else if (request["Action"] == "GetRole")
            {
                string dt = string.Empty;

                DataSet ds = _role.GetList(" Factory_Id='" + factory_Id + "'");

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    dt = XHD.Common.GetGridJSON.DataTableToJSON1(ds.Tables[0], "Total");
                }
                else
                {
                    dt = "{'Rows':[{'id':-9999}],'Total':'Total'}";
                }
                context.Response.Write(dt);
            }
            #endregion

            #region 上产文章图片
            else if (request["Action"] == "album")
            {
                string photo = request["photo"];    //文件路径goods_gallery  商品相册表
                string nowfileName1 = string.Empty;
                if (!string.IsNullOrEmpty(photo))
                {
                    photo = photo.Substring(photo.LastIndexOf('\\') + 1);
                    string sExt1 = photo.Substring(photo.LastIndexOf(".")).ToLower();
                    DateTime now1 = DateTime.Now;
                    nowfileName1 = XHD.Common.TimeParser.GenerateTimeStamp(DateTime.Now) + sExt1;

                }
                if (request.Files.Count > 0 && (!string.IsNullOrEmpty(photo)))
                {
                    HttpPostedFile uploadFile = request.Files[0];
                    ////生成缩略图
                    //SmallImg(uploadFile.InputStream, uploadFile.FileName, context, nowfileName1);
                    ////生成主图
                    //MainImg(uploadFile.InputStream, uploadFile.FileName, context, nowfileName1);
                    uploadFile.SaveAs(context.Server.MapPath(@"~/file/ssn_artImg/" + nowfileName1));
                }
                context.Response.Write("file/ssn_artImg/" + nowfileName1);
            }
            #endregion

            #region 移除图片
            else if (request["Action"] == "remove")
            {
                string src = request["srcvalue"];
                string file = System.Web.HttpContext.Current.Server.MapPath("../" + src);
                if (System.IO.File.Exists(file))
                {
                    File.Delete(file);
                }
            }
            #endregion

            #region 判断标题是否重复
            else if (request["Action"] == "validate")
            {
                string title = request["T_title"];
                string id = request["T_cid"];
                string artMenu_Id = request["art_Menu_Id"];
                if (string.IsNullOrEmpty(id) || id == "null")
                    id = "0";

                DataSet ds = _art.GetList("Art_title = '" + PageValidate.InputText(title, 255) + "' and Art_Menu_Id='" + artMenu_Id + "' and factory_Id='" + factory_Id + "' and Id!=" + int.Parse(id) + " and is_del=0");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    context.Response.Write("false");
                }
                else
                {
                    context.Response.Write("true");
                }
            }

            #endregion


            //#region 获取文章图片
            //else if (request["Action"] == "formGallery")
            //{
            //    string goods_id = request["goods_id"];
            //    if (!string.IsNullOrEmpty(goods_id))
            //    {
            //        DataSet ds = null;
            //        if (request["type"] == "1")
            //            ds = gallery.GetList(" goods_id='" + goods_id + "'");
            //        else if (request["type"] == "2")
            //            ds = gallery.GetListCopy(" goods_id='" + goods_id + "'");
            //        string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
            //        context.Response.Write(dt);
            //    }
            //}
            //#endregion

        }


        /// <summary> 
        /// 在指定的字符串列表CnStr中检索符合拼音索引字符串 
        /// </summary> 
        /// <param name="CnStr">汉字字符串</param> 
        /// <returns>相对应的汉语拼音首字母串</returns> 
        public static string GetSpellCode(string CnStr)
        {
            string strTemp = "";
            int iLen = CnStr.Length;
            int i = 0;

            for (i = 0; i <= iLen - 1; i++)
            {
                strTemp += GetCharSpellCode(CnStr.Substring(i, 1));
            }

            return strTemp;
        }


        /// <summary> 
        /// 得到一个汉字的拼音第一个字母，如果是一个英文字母则直接返回大写字母 
        /// </summary> 
        /// <param name="CnChar">单个汉字</param> 
        /// <returns>单个大写字母</returns> 
        private static string GetCharSpellCode(string CnChar)
        {
            long iCnChar;

            byte[] ZW = System.Text.Encoding.Default.GetBytes(CnChar);

            //如果是字母，则直接返回 
            if (ZW.Length == 1)
            {
                return CnChar.ToUpper();
            }
            else
            {
                // get the array of byte from the single char 
                int i1 = (short)(ZW[0]);
                int i2 = (short)(ZW[1]);
                iCnChar = i1 * 256 + i2;
            }

            //expresstion 
            //table of the constant list 
            // 'A'; //45217..45252 
            // 'B'; //45253..45760 
            // 'C'; //45761..46317 
            // 'D'; //46318..46825 
            // 'E'; //46826..47009 
            // 'F'; //47010..47296 
            // 'G'; //47297..47613 

            // 'H'; //47614..48118 
            // 'J'; //48119..49061 
            // 'K'; //49062..49323 
            // 'L'; //49324..49895 
            // 'M'; //49896..50370 
            // 'N'; //50371..50613 
            // 'O'; //50614..50621 
            // 'P'; //50622..50905 
            // 'Q'; //50906..51386 

            // 'R'; //51387..51445 
            // 'S'; //51446..52217 
            // 'T'; //52218..52697 
            //没有U,V 
            // 'W'; //52698..52979 
            // 'X'; //52980..53640 
            // 'Y'; //53689..54480 
            // 'Z'; //54481..55289 

            // iCnChar match the constant 
            if ((iCnChar >= 45217) && (iCnChar <= 45252))
            {
                return "A";
            }
            else if ((iCnChar >= 45253) && (iCnChar <= 45760))
            {
                return "B";
            }
            else if ((iCnChar >= 45761) && (iCnChar <= 46317))
            {
                return "C";
            }
            else if ((iCnChar >= 46318) && (iCnChar <= 46825))
            {
                return "D";
            }
            else if ((iCnChar >= 46826) && (iCnChar <= 47009))
            {
                return "E";
            }
            else if ((iCnChar >= 47010) && (iCnChar <= 47296))
            {
                return "F";
            }
            else if ((iCnChar >= 47297) && (iCnChar <= 47613))
            {
                return "G";
            }
            else if ((iCnChar >= 47614) && (iCnChar <= 48118))
            {
                return "H";
            }
            else if ((iCnChar >= 48119) && (iCnChar <= 49061))
            {
                return "J";
            }
            else if ((iCnChar >= 49062) && (iCnChar <= 49323))
            {
                return "K";
            }
            else if ((iCnChar >= 49324) && (iCnChar <= 49895))
            {
                return "L";
            }
            else if ((iCnChar >= 49896) && (iCnChar <= 50370))
            {
                return "M";
            }

            else if ((iCnChar >= 50371) && (iCnChar <= 50613))
            {
                return "N";
            }
            else if ((iCnChar >= 50614) && (iCnChar <= 50621))
            {
                return "O";
            }
            else if ((iCnChar >= 50622) && (iCnChar <= 50905))
            {
                return "P";
            }
            else if ((iCnChar >= 50906) && (iCnChar <= 51386))
            {
                return "Q";
            }
            else if ((iCnChar >= 51387) && (iCnChar <= 51445))
            {
                return "R";
            }
            else if ((iCnChar >= 51446) && (iCnChar <= 52217))
            {
                return "S";
            }
            else if ((iCnChar >= 52218) && (iCnChar <= 52697))
            {
                return "T";
            }
            else if ((iCnChar >= 52698) && (iCnChar <= 52979))
            {
                return "W";
            }
            else if ((iCnChar >= 52980) && (iCnChar <= 53640))
            {
                return "X";
            }
            else if ((iCnChar >= 53689) && (iCnChar <= 54480))
            {
                return "Y";
            }
            else if ((iCnChar >= 54481) && (iCnChar <= 55289))
            {
                return "Z";
            }
            else return ("?");
        }


        private static string GetTreeString(int Id, DataTable table)
        {
            DataRow[] rows = table.Select(string.Format("parentid={0}", Id));

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                string d_icon = "../../" + (string)row["Menu_icon"];

                //if (!string.IsNullOrEmpty(authtxt) && authtxt.IndexOf(row["id"].ToString()) == -1 && authtxt != "0")
                //    d_icon = "../../images/icon/50.png";

                str.Append("{id:" + (int)row["Menu_id"] + ",text:'" + row["Menu_name"].ToString() + "',d_icon:'" + d_icon + "'");

                if (GetTreeString((int)row["Menu_id"], table).Length > 0)
                {
                    str.Append(",children:[");
                    str.Append(GetTreeString((int)row["Menu_id"], table));
                    str.Append("]},");
                }
                else
                {
                    str.Append("},");
                }
            }
            return str[str.Length - 1] == ',' ? str.ToString(0, str.Length - 1) : str.ToString();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}