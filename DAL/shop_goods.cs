﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:shop_goods
    /// </summary>
    public partial class shop_goods
    {
        public shop_goods()
        { }

        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int goods_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_goods");
            strSql.Append(" where goods_id=@goods_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8)			};
            parameters[0].Value = goods_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_goods(");
            strSql.Append("goods_id,parent_id,cat_id,goods_sn,goods_supplier_sn,goods_custom_sn,goods_name,goods_name_style,goods_invoice_name,goods_purchase_name,brand_id,type_id,goods_packing,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_volume,charge_by_volume,goods_sna,goods_snb,goods_snc,goods_snd,goods_u2tou1,goods_u3tou1,goods_u4tou1,goods_unit,goods_unit2,goods_unit3,goods_unit4,keywords,goods_brief,goods_desc,goods_thumb,goods_img,goods_origin,add_time,add_admin,update_time,update_admin,seller_note,goods_status,is_main_show,is_main_sell)");
            strSql.Append(" values (");
            strSql.Append("@goods_id,@parent_id,@cat_id,@goods_sn,@goods_supplier_sn,@goods_custom_sn,@goods_name,@goods_name_style,@goods_invoice_name,@goods_purchase_name,@brand_id,@type_id,@goods_packing,@goods_weight,@box_num,@box_weight,@box_length,@box_width,@box_height,@goods_volume,@charge_by_volume,@goods_sna,@goods_snb,@goods_snc,@goods_snd,@goods_u2tou1,@goods_u3tou1,@goods_u4tou1,@goods_unit,@goods_unit2,@goods_unit3,@goods_unit4,@keywords,@goods_brief,@goods_desc,@goods_thumb,@goods_img,@goods_origin,@add_time,@add_admin,@update_time,@update_admin,@seller_note,@goods_status,@is_main_show,@is_main_sell)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8),
					new MySqlParameter("@parent_id", MySqlDbType.Int32,8),
					new MySqlParameter("@cat_id", MySqlDbType.Int32,5),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_supplier_sn", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_custom_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_name_style", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_invoice_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_purchase_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@brand_id", MySqlDbType.Int32,5),
					new MySqlParameter("@type_id", MySqlDbType.Int32,5),
					new MySqlParameter("@goods_packing", MySqlDbType.VarChar,250),
					new MySqlParameter("@goods_weight", MySqlDbType.Decimal,18),
					new MySqlParameter("@box_num", MySqlDbType.Int32,6),
					new MySqlParameter("@box_weight", MySqlDbType.Decimal,15),
					new MySqlParameter("@box_length", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_width", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_height", MySqlDbType.Decimal,10),
					new MySqlParameter("@goods_volume", MySqlDbType.Decimal,10),
					new MySqlParameter("@charge_by_volume", MySqlDbType.Int32,1),
					new MySqlParameter("@goods_sna", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_snb", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_snc", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_snd", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_u2tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_u3tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_u4tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit", MySqlDbType.VarChar,20),
					new MySqlParameter("@goods_unit2", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit3", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit4", MySqlDbType.VarChar,6),
					new MySqlParameter("@keywords", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_brief", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_desc", MySqlDbType.Text),
					new MySqlParameter("@goods_thumb", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_img", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_origin", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.Int32,10),
					new MySqlParameter("@add_admin", MySqlDbType.VarChar,30),
					new MySqlParameter("@update_time", MySqlDbType.Int32,10),
					new MySqlParameter("@update_admin", MySqlDbType.VarChar,30),
					new MySqlParameter("@seller_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_status", MySqlDbType.Int32,1),
					new MySqlParameter("@is_main_show", MySqlDbType.Int32,1),
					new MySqlParameter("@is_main_sell", MySqlDbType.Int32,1)};
            parameters[0].Value = model.goods_id;
            parameters[1].Value = model.parent_id;
            parameters[2].Value = model.cat_id;
            parameters[3].Value = model.goods_sn;
            parameters[4].Value = model.goods_supplier_sn;
            parameters[5].Value = model.goods_custom_sn;
            parameters[6].Value = model.goods_name;
            parameters[7].Value = model.goods_name_style;
            parameters[8].Value = model.goods_invoice_name;
            parameters[9].Value = model.goods_purchase_name;
            parameters[10].Value = model.brand_id;
            parameters[11].Value = model.type_id;
            parameters[12].Value = model.goods_packing;
            parameters[13].Value = model.goods_weight;
            parameters[14].Value = model.box_num;
            parameters[15].Value = model.box_weight;
            parameters[16].Value = model.box_length;
            parameters[17].Value = model.box_width;
            parameters[18].Value = model.box_height;
            parameters[19].Value = model.goods_volume;
            parameters[20].Value = model.charge_by_volume;
            parameters[21].Value = model.goods_sna;
            parameters[22].Value = model.goods_snb;
            parameters[23].Value = model.goods_snc;
            parameters[24].Value = model.goods_snd;
            parameters[25].Value = model.goods_u2tou1;
            parameters[26].Value = model.goods_u3tou1;
            parameters[27].Value = model.goods_u4tou1;
            parameters[28].Value = model.goods_unit;
            parameters[29].Value = model.goods_unit2;
            parameters[30].Value = model.goods_unit3;
            parameters[31].Value = model.goods_unit4;
            parameters[32].Value = model.keywords;
            parameters[33].Value = model.goods_brief;
            parameters[34].Value = model.goods_desc;
            parameters[35].Value = model.goods_thumb;
            parameters[36].Value = model.goods_img;
            parameters[37].Value = model.goods_origin;
            parameters[38].Value = model.add_time;
            parameters[39].Value = model.add_admin;
            parameters[40].Value = model.update_time;
            parameters[41].Value = model.update_admin;
            parameters[42].Value = model.seller_note;
            parameters[43].Value = model.goods_status;
            parameters[44].Value = model.is_main_show;
            parameters[45].Value = model.is_main_sell;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.shop_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_goods set ");
            strSql.Append("parent_id=@parent_id,");
            strSql.Append("cat_id=@cat_id,");
            strSql.Append("goods_sn=@goods_sn,");
            strSql.Append("goods_supplier_sn=@goods_supplier_sn,");
            strSql.Append("goods_custom_sn=@goods_custom_sn,");
            strSql.Append("goods_name=@goods_name,");
            strSql.Append("goods_name_style=@goods_name_style,");
            strSql.Append("goods_invoice_name=@goods_invoice_name,");
            strSql.Append("goods_purchase_name=@goods_purchase_name,");
            strSql.Append("brand_id=@brand_id,");
            strSql.Append("type_id=@type_id,");
            strSql.Append("goods_packing=@goods_packing,");
            strSql.Append("goods_weight=@goods_weight,");
            strSql.Append("box_num=@box_num,");
            strSql.Append("box_weight=@box_weight,");
            strSql.Append("box_length=@box_length,");
            strSql.Append("box_width=@box_width,");
            strSql.Append("box_height=@box_height,");
            strSql.Append("goods_volume=@goods_volume,");
            strSql.Append("charge_by_volume=@charge_by_volume,");
            strSql.Append("goods_sna=@goods_sna,");
            strSql.Append("goods_snb=@goods_snb,");
            strSql.Append("goods_snc=@goods_snc,");
            strSql.Append("goods_snd=@goods_snd,");
            strSql.Append("goods_u2tou1=@goods_u2tou1,");
            strSql.Append("goods_u3tou1=@goods_u3tou1,");
            strSql.Append("goods_u4tou1=@goods_u4tou1,");
            strSql.Append("goods_unit=@goods_unit,");
            strSql.Append("goods_unit2=@goods_unit2,");
            strSql.Append("goods_unit3=@goods_unit3,");
            strSql.Append("goods_unit4=@goods_unit4,");
            strSql.Append("keywords=@keywords,");
            strSql.Append("goods_brief=@goods_brief,");
            strSql.Append("goods_desc=@goods_desc,");
            strSql.Append("goods_thumb=@goods_thumb,");
            strSql.Append("goods_img=@goods_img,");
            strSql.Append("goods_origin=@goods_origin,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("add_admin=@add_admin,");
            strSql.Append("update_time=@update_time,");
            strSql.Append("update_admin=@update_admin,");
            strSql.Append("seller_note=@seller_note,");
            strSql.Append("goods_status=@goods_status,");
            strSql.Append("is_main_show=@is_main_show,");
            strSql.Append("is_main_sell=@is_main_sell");
            strSql.Append(" where goods_id=@goods_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@parent_id", MySqlDbType.Int32,8),
					new MySqlParameter("@cat_id", MySqlDbType.Int32,5),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_supplier_sn", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_custom_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_name_style", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_invoice_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_purchase_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@brand_id", MySqlDbType.Int32,5),
					new MySqlParameter("@type_id", MySqlDbType.Int32,5),
					new MySqlParameter("@goods_packing", MySqlDbType.VarChar,250),
					new MySqlParameter("@goods_weight", MySqlDbType.Decimal,18),
					new MySqlParameter("@box_num", MySqlDbType.Int32,6),
					new MySqlParameter("@box_weight", MySqlDbType.Decimal,15),
					new MySqlParameter("@box_length", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_width", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_height", MySqlDbType.Decimal,10),
					new MySqlParameter("@goods_volume", MySqlDbType.Decimal,10),
					new MySqlParameter("@charge_by_volume", MySqlDbType.Int32,1),
					new MySqlParameter("@goods_sna", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_snb", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_snc", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_snd", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_u2tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_u3tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_u4tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit", MySqlDbType.VarChar,20),
					new MySqlParameter("@goods_unit2", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit3", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit4", MySqlDbType.VarChar,6),
					new MySqlParameter("@keywords", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_brief", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_desc", MySqlDbType.Text),
					new MySqlParameter("@goods_thumb", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_img", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_origin", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.Int32,10),
					new MySqlParameter("@add_admin", MySqlDbType.VarChar,30),
					new MySqlParameter("@update_time", MySqlDbType.Int32,10),
					new MySqlParameter("@update_admin", MySqlDbType.VarChar,30),
					new MySqlParameter("@seller_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_status", MySqlDbType.Int32,1),
					new MySqlParameter("@is_main_show", MySqlDbType.Int32,1),
					new MySqlParameter("@is_main_sell", MySqlDbType.Int32,1),
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8)};
            parameters[0].Value = model.parent_id;
            parameters[1].Value = model.cat_id;
            parameters[2].Value = model.goods_sn;
            parameters[3].Value = model.goods_supplier_sn;
            parameters[4].Value = model.goods_custom_sn;
            parameters[5].Value = model.goods_name;
            parameters[6].Value = model.goods_name_style;
            parameters[7].Value = model.goods_invoice_name;
            parameters[8].Value = model.goods_purchase_name;
            parameters[9].Value = model.brand_id;
            parameters[10].Value = model.type_id;
            parameters[11].Value = model.goods_packing;
            parameters[12].Value = model.goods_weight;
            parameters[13].Value = model.box_num;
            parameters[14].Value = model.box_weight;
            parameters[15].Value = model.box_length;
            parameters[16].Value = model.box_width;
            parameters[17].Value = model.box_height;
            parameters[18].Value = model.goods_volume;
            parameters[19].Value = model.charge_by_volume;
            parameters[20].Value = model.goods_sna;
            parameters[21].Value = model.goods_snb;
            parameters[22].Value = model.goods_snc;
            parameters[23].Value = model.goods_snd;
            parameters[24].Value = model.goods_u2tou1;
            parameters[25].Value = model.goods_u3tou1;
            parameters[26].Value = model.goods_u4tou1;
            parameters[27].Value = model.goods_unit;
            parameters[28].Value = model.goods_unit2;
            parameters[29].Value = model.goods_unit3;
            parameters[30].Value = model.goods_unit4;
            parameters[31].Value = model.keywords;
            parameters[32].Value = model.goods_brief;
            parameters[33].Value = model.goods_desc;
            parameters[34].Value = model.goods_thumb;
            parameters[35].Value = model.goods_img;
            parameters[36].Value = model.goods_origin;
            parameters[37].Value = model.add_time;
            parameters[38].Value = model.add_admin;
            parameters[39].Value = model.update_time;
            parameters[40].Value = model.update_admin;
            parameters[41].Value = model.seller_note;
            parameters[42].Value = model.goods_status;
            parameters[43].Value = model.is_main_show;
            parameters[44].Value = model.is_main_sell;
            parameters[45].Value = model.goods_id;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int goods_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_goods ");
            strSql.Append(" where goods_id=@goods_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8)			};
            parameters[0].Value = goods_id;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string goods_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_goods ");
            strSql.Append(" where goods_id in (" + goods_idlist + ")  ");
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.shop_goods GetModel(int goods_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select goods_id,parent_id,cat_id,goods_sn,goods_supplier_sn,goods_custom_sn,goods_name,goods_name_style,goods_invoice_name,goods_purchase_name,brand_id,type_id,goods_packing,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_volume,charge_by_volume,goods_sna,goods_snb,goods_snc,goods_snd,goods_u2tou1,goods_u3tou1,goods_u4tou1,goods_unit,goods_unit2,goods_unit3,goods_unit4,keywords,goods_brief,goods_desc,goods_thumb,goods_img,goods_origin,add_time,add_admin,update_time,update_admin,seller_note,goods_status,is_main_show,is_main_sell from shop_goods ");
            strSql.Append(" where goods_id=@goods_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8)			};
            parameters[0].Value = goods_id;

            XHD.Model.shop_goods model = new XHD.Model.shop_goods();
            DataSet ds = Shop_DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.shop_goods DataRowToModel(DataRow row)
        {
            XHD.Model.shop_goods model = new XHD.Model.shop_goods();
            if (row != null)
            {
                //model.goods_id=row["goods_id"].ToString();
                //model.parent_id=row["parent_id"].ToString();
                if (row["goods_id"] != null && row["goods_id"].ToString() != "")
                {
                    model.goods_id = int.Parse(row["goods_id"].ToString());
                }
                if (row["parent_id"] != null && row["parent_id"].ToString() != "")
                {
                    model.parent_id = int.Parse(row["parent_id"].ToString());
                }
                if (row["cat_id"] != null && row["cat_id"].ToString() != "")
                {
                    model.cat_id = int.Parse(row["cat_id"].ToString());
                }
                if (row["goods_sn"] != null)
                {
                    model.goods_sn = row["goods_sn"].ToString();
                }
                if (row["goods_supplier_sn"] != null)
                {
                    model.goods_supplier_sn = row["goods_supplier_sn"].ToString();
                }
                if (row["goods_custom_sn"] != null)
                {
                    model.goods_custom_sn = row["goods_custom_sn"].ToString();
                }
                if (row["goods_name"] != null)
                {
                    model.goods_name = row["goods_name"].ToString();
                }
                if (row["goods_name_style"] != null)
                {
                    model.goods_name_style = row["goods_name_style"].ToString();
                }
                if (row["goods_invoice_name"] != null)
                {
                    model.goods_invoice_name = row["goods_invoice_name"].ToString();
                }
                if (row["goods_purchase_name"] != null)
                {
                    model.goods_purchase_name = row["goods_purchase_name"].ToString();
                }
                if (row["brand_id"] != null && row["brand_id"].ToString() != "")
                {
                    model.brand_id = int.Parse(row["brand_id"].ToString());
                }
                if (row["type_id"] != null && row["type_id"].ToString() != "")
                {
                    model.type_id = int.Parse(row["type_id"].ToString());
                }
                if (row["goods_packing"] != null)
                {
                    model.goods_packing = row["goods_packing"].ToString();
                }
                if (row["goods_weight"] != null && row["goods_weight"].ToString() != "")
                {
                    model.goods_weight = decimal.Parse(row["goods_weight"].ToString());
                }
                if (row["box_num"] != null && row["box_num"].ToString() != "")
                {
                    model.box_num = int.Parse(row["box_num"].ToString());
                }
                if (row["box_weight"] != null && row["box_weight"].ToString() != "")
                {
                    model.box_weight = decimal.Parse(row["box_weight"].ToString());
                }
                if (row["box_length"] != null && row["box_length"].ToString() != "")
                {
                    model.box_length = decimal.Parse(row["box_length"].ToString());
                }
                if (row["box_width"] != null && row["box_width"].ToString() != "")
                {
                    model.box_width = decimal.Parse(row["box_width"].ToString());
                }
                if (row["box_height"] != null && row["box_height"].ToString() != "")
                {
                    model.box_height = decimal.Parse(row["box_height"].ToString());
                }
                if (row["goods_volume"] != null && row["goods_volume"].ToString() != "")
                {
                    model.goods_volume = decimal.Parse(row["goods_volume"].ToString());
                }
                if (row["charge_by_volume"] != null && row["charge_by_volume"].ToString() != "")
                {
                    model.charge_by_volume = int.Parse(row["charge_by_volume"].ToString());
                }
                if (row["goods_sna"] != null)
                {
                    model.goods_sna = row["goods_sna"].ToString();
                }
                if (row["goods_snb"] != null)
                {
                    model.goods_snb = row["goods_snb"].ToString();
                }
                if (row["goods_snc"] != null)
                {
                    model.goods_snc = row["goods_snc"].ToString();
                }
                if (row["goods_snd"] != null)
                {
                    model.goods_snd = row["goods_snd"].ToString();
                }
                if (row["goods_u2tou1"] != null)
                {
                    model.goods_u2tou1 = row["goods_u2tou1"].ToString();
                }
                if (row["goods_u3tou1"] != null)
                {
                    model.goods_u3tou1 = row["goods_u3tou1"].ToString();
                }
                if (row["goods_u4tou1"] != null)
                {
                    model.goods_u4tou1 = row["goods_u4tou1"].ToString();
                }
                if (row["goods_unit"] != null)
                {
                    model.goods_unit = row["goods_unit"].ToString();
                }
                if (row["goods_unit2"] != null)
                {
                    model.goods_unit2 = row["goods_unit2"].ToString();
                }
                if (row["goods_unit3"] != null)
                {
                    model.goods_unit3 = row["goods_unit3"].ToString();
                }
                if (row["goods_unit4"] != null)
                {
                    model.goods_unit4 = row["goods_unit4"].ToString();
                }
                if (row["keywords"] != null)
                {
                    model.keywords = row["keywords"].ToString();
                }
                if (row["goods_brief"] != null)
                {
                    model.goods_brief = row["goods_brief"].ToString();
                }
                if (row["goods_desc"] != null)
                {
                    model.goods_desc = row["goods_desc"].ToString();
                }
                if (row["goods_thumb"] != null)
                {
                    model.goods_thumb = row["goods_thumb"].ToString();
                }
                if (row["goods_img"] != null)
                {
                    model.goods_img = row["goods_img"].ToString();
                }
                if (row["goods_origin"] != null)
                {
                    model.goods_origin = row["goods_origin"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = int.Parse(row["add_time"].ToString());
                }
                if (row["add_admin"] != null)
                {
                    model.add_admin = row["add_admin"].ToString();
                }
                if (row["update_time"] != null && row["update_time"].ToString() != "")
                {
                    model.update_time = int.Parse(row["update_time"].ToString());
                }
                if (row["update_admin"] != null)
                {
                    model.update_admin = row["update_admin"].ToString();
                }
                if (row["seller_note"] != null)
                {
                    model.seller_note = row["seller_note"].ToString();
                }
                if (row["goods_status"] != null && row["goods_status"].ToString() != "")
                {
                    model.goods_status = int.Parse(row["goods_status"].ToString());
                }
                if (row["is_main_show"] != null && row["is_main_show"].ToString() != "")
                {
                    model.is_main_show = int.Parse(row["is_main_show"].ToString());
                }
                if (row["is_main_sell"] != null && row["is_main_sell"].ToString() != "")
                {
                    model.is_main_sell = int.Parse(row["is_main_sell"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select goods_id,parent_id,cat_id,goods_sn,goods_supplier_sn,goods_custom_sn,goods_name,goods_name_style,goods_invoice_name,goods_purchase_name,brand_id,type_id,goods_packing,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_volume,charge_by_volume,goods_sna,goods_snb,goods_snc,goods_snd,goods_u2tou1,goods_u3tou1,goods_u4tou1,goods_unit,goods_unit2,goods_unit3,goods_unit4,keywords,goods_brief,goods_desc,goods_thumb,goods_img,goods_origin,add_time,add_admin,update_time,update_admin,seller_note,goods_status,is_main_show,is_main_sell ");
            strSql.Append(" FROM shop_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select * FROM shop_goods");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_Contact ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(goods_id) FROM shop_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetShopGoods(string strWhere, int pageInt, int user_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct g.goods_id,g.parent_id,g.cat_id,g.goods_sn,g.goods_supplier_sn,g.goods_custom_sn,g.goods_name,g.goods_name_style,g.goods_invoice_name,g.goods_purchase_name,g.brand_id,g.type_id,g.goods_packing,g.goods_weight,g.box_num,g.box_weight,g.box_length,g.box_width,g.box_height,g.goods_volume,g.charge_by_volume,g.goods_sna,g.goods_snb,g.goods_snc,g.goods_snd,g.goods_u2tou1,g.goods_u3tou1,g.goods_u4tou1,g.goods_unit,g.goods_unit2,g.goods_unit3,g.goods_unit4,g.keywords,g.goods_brief,g.goods_desc,g.goods_thumb,g.goods_img,g.goods_origin,g.add_time,g.add_admin,g.update_time,g.update_admin,g.seller_note,g.goods_status,g.is_main_show,g.is_main_sell, ");
            strSql.Append(" ifnull(p.guide_price,0) guide_price,ifnull(p.buying_price,0) buying_price,ifnull(p.selling_price,0) selling_price,ifnull(p.warning_price,0) warning_price,ifnull(p.tax_warning_price,0) tax_warning_price,ifnull(p.wholesale_price,0) wholesale_price,");
            strSql.Append(" oc.goods_price");
            strSql.Append(" FROM shop_goods as g left join shop_goods_price as p on g.goods_id=p.goods_id ");
            strSql.Append(" left join shop_order_goods as og on g.goods_id=og.goods_id");
            strSql.Append(" left join (select * from shop_order_goods as og inner join (select max(ordergood_id) as id from shop_order_goods where user_id=" + user_id + " group by goods_id) as os");
            strSql.Append(" on og.ordergood_id = os.id ) as oc on g.goods_id=oc.goods_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" limit " + pageInt);
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取订单商品详情
        /// </summary>
        public DataSet GetOrderGoods(string strWhere, int user_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct og.ordergood_id,og.cart_id,og.order_id,og.order_sn,og.goods_id,og.goods_name,og.goods_sn,og.goods_number,og.market_price,og.goods_price,og.shipping_fee_price,og.brand_id,og.cat_id,og.user_id,og.admin_id,og.purchase_goods_status,og.is_submit_purchase,og.stock_warn,og.is_invoice,og.is_add_order,og.doc_id,og.wms_setbook_id,og.wms_position,og.wms_record,og.goods_attr, ");
            strSql.Append(" oc.goods_price as last_price,(og.goods_price-ifnull(og.shipping_fee_price,0)) as sum_price,(og.goods_price*og.goods_number) as all_price,");
            strSql.Append(" g.goods_weight,g.goods_unit,g.goods_desc,ifnull(lg.locked_num,0) locked_num,ifnull(lgm.match_num,0) match_num,i.invoice_status,og.invoice_number,(ifnull(og.goods_number,0) - ifnull(og.invoice_number, 0)) wait_number ");
            strSql.Append(" FROM shop_order_goods as og ");
            strSql.Append(" left join (select * from shop_order_goods as og inner join (select max(ordergood_id) as id from shop_order_goods as og2 INNER JOIN shop_order_info AS oi ON og2.order_id = oi.order_id AND oi.erp_time IS NOT NULL AND oi.erp_time!='' where og2.user_id=" + user_id + " group by goods_id) as os");
            strSql.Append(" on og.ordergood_id = os.id) as oc on og.goods_id=oc.goods_id");
            strSql.Append(" left join shop_goods as g on g.goods_id=og.goods_id");
            strSql.Append(" left join shop_locked_goods as lg on lg.rec_id=og.ordergood_id and  UNIX_TIMESTAMP(SUBDATE(now(),1))<lg.add_time ");
            strSql.Append(" left join shop_locked_goods as lgm on lgm.rec_id=og.ordergood_id  ");
            strSql.Append(" LEFT JOIN shop_invoices_among_goods AS ig ON og.ordergood_id = ig.rec_id ");
            strSql.Append(" LEFT JOIN shop_invoices AS i ON i.invoices_among_id = ig.target_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" group by  og.ordergood_id ");
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取商品总重金额数量
        /// </summary>
        public DataSet getSumParams(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select oi.shipping_fee,oi.tax,oi.insure_fee,oi.pay_fee,oi.pack_fee,sum(og.goods_number*g.goods_weight) all_goods_weight,");
            strSql.Append("sum(og.goods_number) all_goods_number,sum(og.goods_number*og.goods_price) all_goods_price ");
            strSql.Append(" FROM shop_order_info oi inner join shop_order_goods og on oi.order_id=og.order_id");
            strSql.Append(" left join shop_goods g on g.goods_id=og.goods_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet getCurStock(string strWhere, string sqltxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select ");
            strSql.Append(" 	cur.bm as goods_id,");
            strSql.Append("     ifnull(cur.sl, 0) AS real_num,");
            strSql.Append(" 	ifnull(zhan.zhan, 0) AS locked_number,");
            strSql.Append(" 	ifnull(cur.sl, 0)-ifnull(zhan.zhan, 0)-ifnull(fen.fen,0)  AS shop_num");
            strSql.Append(" from (select sum(sl) sl,bm from xmh_wms.dqkcyl  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" GROUP BY bm )as cur   ");
            strSql.Append(" LEFT JOIN (");
            strSql.Append(" 	SELECT goods_id,sum(locked_num) AS zhan  ");
            strSql.Append(" 	FROM xmh_shop.shop_locked_goods ");
            strSql.Append(" 	where (add_time+86400)>unix_timestamp(now())");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + sqltxt);
            }
            strSql.Append(" 	GROUP BY goods_id");
            strSql.Append(" )AS zhan on cur.BM=zhan.goods_id");
            strSql.Append(" LEFT JOIN (");
            strSql.Append(" 	SELECT goods_id,sum(match_num) AS fen  ");
            strSql.Append(" 	FROM xmh_shop.shop_locked_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + sqltxt);
            }
            strSql.Append(" 	GROUP BY");
            strSql.Append(" 		goods_id");
            strSql.Append(" )AS fen on cur.BM=fen.goods_id");

            //strSql.Append(" AND cur.hw = 'k1'");
            strSql.Append(" order by cur.bm ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM shop_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.goods_id desc");
            }
            strSql.Append(")AS Row, T.*  from shop_goods T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        //分页获取商品及库存
        public DataSet GetGoodsStock(int PageSize, int PageIndex, string strWhere, string strSqlOne, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            //strSql.Append(" select g.goods_id,g.parent_id,g.cat_id,g.brand_id,g.goods_sn,g.goods_supplier_sn,g.goods_name,g.goods_packing,g.goods_weight,g.box_num,g.box_weight,");
            //strSql.Append(" CONCAT(box_length,'*',box_width,'*',box_height) as box_size,g.goods_unit,g.goods_thumb,pr.guide_price,pr.wholesale_price "); //ga.thumb_url,IFNULL(l.locked_num,0) as locked_num,IFNULL(d.SL,0) as Sl 
            //strSql.Append(" from shop_goods as g ");
            //strSql.Append(" inner join( ");
            //strSql.Append(" select goods_id from shop_goods  where parent_id='0' and is_main_sell='1' ");
            //strSql.Append(" UNION ");
            //strSql.Append(" select goods_id  from shop_goods  where parent_id!='0' ");
            //strSql.Append(" ) as gg on g.goods_id=gg.goods_id ");
            //strSql.Append(" LEFT JOIN shop_goods_price as pr on pr.goods_id =g.goods_id ");

            strSql.Append(" select g.goods_id,g.parent_id,g.cat_id,g.brand_id,g.goods_sn,g.goods_supplier_sn,g.goods_name,g.goods_packing,g.goods_weight,g.box_num,g.box_weight,");
            strSql.Append(" CONCAT(box_length,'*',box_width,'*',box_height) as box_size,g.goods_unit,g.goods_thumb, g.goods_status,pr.guide_price,pr.wholesale_price, ");
            strSql.Append(" ifnull(zhan.zhan, 0) AS locked_number,ifnull(fen.match_num, 0) AS match_num "); //ifnull(s.SL, 0) AS SL,ifnull(s.SL, 0)-ifnull(zhan.zhan, 0)-ifnull(fen.match_num, 0) AS shop_num 
            strSql.Append(" from shop_goods as g ");
            strSql.Append(" inner join( ");
            strSql.Append(" select goods_id from shop_goods  where parent_id='0' and is_main_sell='1' ");
            strSql.Append(" UNION ");
            strSql.Append(" select goods_id  from shop_goods  where parent_id!='0' ");
            strSql.Append(" ) as gg on g.goods_id=gg.goods_id ");
            strSql.Append(" LEFT JOIN shop_goods_price as pr on pr.goods_id =g.goods_id ");
            strSql.Append(" LEFT JOIN ( SELECT goods_id,sum(locked_num) AS zhan FROM xmh_shop.shop_locked_goods where (add_time+86400)>unix_timestamp(now()) and wms_storage='" + strSqlOne + "'  GROUP BY goods_id ");
            strSql.Append(" )AS zhan on g.goods_id =zhan.goods_id ");
            strSql.Append(" LEFT JOIN ( SELECT goods_id,sum(match_num) AS match_num FROM xmh_shop.shop_locked_goods where  wms_storage='" + strSqlOne + "' GROUP BY goods_id ");
            strSql.Append(" )AS fen on g.goods_id =fen.goods_id ");
            // strSql.Append(" LEFT JOIN ( select BM,SL from xmh_wms.dqkcyl where HW='" + strSqlOne + "' GROUP BY BM ");
            // strSql.Append(" ) as s on s.bm=g.goods_id ");

            strSql1.Append(" select count(g.goods_id) ");
            strSql1.Append(" from shop_goods as g ");
            strSql1.Append(" inner join( ");
            strSql1.Append(" select goods_id from shop_goods  where parent_id='0' and is_main_sell='1' ");
            strSql1.Append(" UNION ");
            strSql1.Append(" select goods_id  from shop_goods  where parent_id!='0' ");
            strSql1.Append(" ) as gg on g.goods_id=gg.goods_id ");
            strSql1.Append(" LEFT JOIN shop_goods_price as pr on pr.goods_id =g.goods_id ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        //分页获取商品及库存SL排序
        public DataSet GetOrderSL(int PageSize, int PageIndex, string strWhere, string strSqlOne, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select g.goods_id,g.parent_id,g.cat_id,g.brand_id,g.goods_sn,g.goods_supplier_sn,g.goods_name,g.goods_packing, ");
            strSql.Append(" g.goods_weight,g.box_num,g.box_weight, CONCAT(box_length,'*',box_width,'*',box_height) as box_size,g.goods_status, ");
            strSql.Append(" g.goods_unit,g.goods_thumb,bb.guide_price,bb.wholesale_price,ifnull(cc.lock_num,0) as locked_num, (ifnull(dd.sl,0)-ifnull(cc.lock_num,0)) as SL ");
            strSql.Append(" from  xmh_shop.shop_goods g  ");
            strSql.Append(" left join xmh_shop.shop_goods_price bb  on g.goods_id=bb.goods_id ");
            strSql.Append(" left join (select goods_id,sum(match_num+locked_num) as lock_num from xmh_shop.shop_locked_goods where wms_storage='" + strSqlOne + "'  group by goods_id) cc on g.goods_id=cc.goods_id ");
            strSql.Append(" left join xmh_wms.dqkcyl dd on g.goods_id =dd.bm  and  dd.HW='" + strSqlOne + "' ");

            strSql1.Append(" select count(g.goods_id) ");
            strSql1.Append(" from shop_goods as g ");

            //strSql.Append(" select g.goods_id,g.parent_id,g.cat_id,g.brand_id,g.goods_sn,g.goods_supplier_sn,g.goods_name,g.goods_packing,g.goods_weight,g.box_num,g.box_weight,");
            //strSql.Append(" CONCAT(box_length,'*',box_width,'*',box_height) as box_size,g.goods_unit,g.goods_thumb,pr.guide_price,pr.wholesale_price, ");
            //strSql.Append(" ifnull(zhan.zhan, 0)+ifnull(fen.fen, 0) as locked_num,ifnull(cur.sl, 0)-ifnull(zhan.zhan, 0)-ifnull(fen.fen, 0) AS SL ");
            //strSql.Append(" from xmh_wms.dqkcyl as cur ");
            //strSql.Append(" LEFT JOIN ( SELECT goods_id,sum(locked_num) AS zhan FROM xmh_shop.shop_locked_goods where (add_time+86400)>unix_timestamp(now()) and wms_storage='" + strSqlOne + "'  GROUP BY goods_id ");
            //strSql.Append(" )AS zhan on cur.BM =zhan.goods_id ");
            //strSql.Append(" LEFT JOIN ( SELECT goods_id,sum(match_num) AS fen FROM xmh_shop.shop_locked_goods where  wms_storage='" + strSqlOne + "' GROUP BY goods_id ");
            //strSql.Append(" )AS fen on cur.BM =fen.goods_id ");
            //strSql.Append(" LEFT JOIN  shop_goods g on cur.BM=g.goods_id   ");
            //strSql.Append(" LEFT JOIN  shop_goods_price as pr on pr.goods_id =cur.BM ");

            //strSql1.Append(" select count(cur.BM) ");
            //strSql1.Append(" from xmh_wms.dqkcyl as cur ");
            //strSql1.Append(" LEFT JOIN  shop_goods g on cur.BM=g.goods_id   ");
            //strSql1.Append(" LEFT JOIN  shop_goods_price as pr on pr.goods_id =cur.BM ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        //获取商品及库存
        public DataSet GetGoodsStockAll(string strWhere, string strSqlOne)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select g.goods_id,g.parent_id,g.cat_id,g.brand_id,g.goods_sn,g.goods_supplier_sn,g.goods_name,g.goods_packing,g.goods_weight,g.box_num,g.box_weight, ");
            strSql.Append(" CONCAT(box_length,'*',box_width,'*',box_height) as box_size,g.goods_unit,g.goods_thumb,IFNULL(pr.guide_price,0) as guide_price, ");
            strSql.Append(" IFNULL(pr.wholesale_price,0) as wholesale_price,g.goods_desc ");
            strSql.Append(" from shop_goods as g ");
            strSql.Append(" inner join( ");
            strSql.Append(" select goods_id from shop_goods  where parent_id='0' and is_main_sell='1' ");
            strSql.Append(" UNION ");
            strSql.Append(" select goods_id  from shop_goods  where parent_id!='0' ");
            strSql.Append(" ) as gg on g.goods_id=gg.goods_id ");
            strSql.Append(" LEFT JOIN shop_goods_price as pr on pr.goods_id =g.goods_id ");


            //strSql.Append(" select g.goods_id,g.parent_id,g.cat_id,g.brand_id,g.goods_sn,g.goods_supplier_sn,g.goods_name,g.goods_packing,g.goods_weight,g.box_num,g.box_weight,");
            //strSql.Append(" CONCAT(box_length,'*',box_width,'*',box_height) as box_size,g.goods_unit,g.goods_thumb,pr.guide_price,pr.wholesale_price,");
            //strSql.Append(" ifnull(zhan.zhan, 0) AS locked_number,ifnull(fen.match_num, 0) AS match_num , ifnull(s.SL, 0) AS SL,ifnull(s.SL, 0)-ifnull(zhan.zhan, 0)-ifnull(fen.match_num, 0) AS shop_num ");
            //strSql.Append(" from shop_goods as g ");
            //strSql.Append(" inner join( ");
            //strSql.Append(" select goods_id from shop_goods  where parent_id='0' and is_main_sell='1' ");
            //strSql.Append(" UNION ");
            //strSql.Append(" select goods_id  from shop_goods  where parent_id!='0' ");
            //strSql.Append(" ) as gg on g.goods_id=gg.goods_id ");
            //strSql.Append(" LEFT JOIN shop_goods_price as pr on pr.goods_id =g.goods_id ");
            //strSql.Append(" LEFT JOIN ( SELECT goods_id,sum(locked_num) AS zhan FROM xmh_shop.shop_locked_goods where (add_time+86400)>unix_timestamp(now()) and wms_storage='k1' GROUP BY goods_id ");
            //strSql.Append(" )AS zhan on g.goods_id =zhan.goods_id ");
            //strSql.Append(" LEFT JOIN ( SELECT goods_id,sum(match_num) AS match_num FROM xmh_shop.shop_locked_goods where  wms_storage='" + strSqlOne + "' GROUP BY goods_id ");
            //strSql.Append(" )AS fen on g.goods_id =fen.goods_id ");
            //strSql.Append(" LEFT JOIN ( select BM,SL from xmh_wms.dqkcyl where HW='" + strSqlOne + "' GROUP BY BM ");
            //strSql.Append(" ) as s on s.bm=g.goods_id ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得品牌数据列表
        /// </summary>
        public DataSet GetListBrand(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  ");
            strSql.Append(" FROM shop_brand ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得分类数据列表
        /// </summary>
        public DataSet GetListClass(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  ");
            strSql.Append(" FROM shop_category ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 关联
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool RelatedGoods(string goodsId, string supplyId)
        {
            string strSql = string.Format(@" update shop_goods set suppliers_id='{0}' where goods_id in ({1})", supplyId, goodsId);
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql);
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 解除
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool UnRelatedGoods(string goodsId, string supplyId)
        {
            string strSql = string.Format(@" update shop_goods set suppliers_id='{0}' where goods_id in ({1})", 0, goodsId);
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql);
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListBrand(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select * FROM shop_brand");
            strSql1.Append(" select count(brand_id) FROM shop_brand ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 关联
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool RelatedBrand(string brandId, string supplyId)
        {
            string strSql = string.Format(@" update shop_brand set suppliers_id='{0}' where brand_id in ({1})", supplyId, brandId);
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql);
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 解除
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool UnRelatedBrand(string brandId, string supplyId)
        {
            string strSql = string.Format(@" update shop_brand set suppliers_id='{0}' where brand_id in ({1})", 0, brandId);
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql);
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

