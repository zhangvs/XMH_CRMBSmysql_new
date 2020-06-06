using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_supply_goods
    /// </summary>
    public partial class scm_supply_goods
    {
        public scm_supply_goods()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int goods_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_supply_goods");
            strSql.Append(" where goods_id=@goods_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = goods_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_supply_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_supply_goods(");
            strSql.Append("goods_id,factory_id,suppliers_id,goods_sn,goods_name,goods_name_style,goods_invoce_name,click_count,brand_id,provider_name,goods_number,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_snc,goods_snb,goods_sna,goods_u2tou1,goods_u3tou1,goods_unit,goods_unit2,goods_unit3,goods_packing,market_price,wholesale_price,shop_price,goods_num_limit,goods_num_limit2,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,is_shipping,integral,add_time,sort_order,is_delete,is_best,is_new,is_hot,is_standing_stock,is_promote,bonus_type_id,last_update,goods_type,seller_note,give_integral,rank_integral,is_check,cat_id,is_catindex,is_main_show,goods_sn2,goods_volume,charge_by_volume,mian_price,goods_stock,sx,dealer_id,is_share,goods_source,update_type,update_reason,update_date,isDelete_copy)");
            strSql.Append(" values (");
            strSql.Append("@goods_id,@factory_id,@suppliers_id,@goods_sn,@goods_name,@goods_name_style,@goods_invoce_name,@click_count,@brand_id,@provider_name,@goods_number,@goods_weight,@box_num,@box_weight,@box_length,@box_width,@box_height,@goods_snc,@goods_snb,@goods_sna,@goods_u2tou1,@goods_u3tou1,@goods_unit,@goods_unit2,@goods_unit3,@goods_packing,@market_price,@wholesale_price,@shop_price,@goods_num_limit,@goods_num_limit2,@promote_price,@promote_start_date,@promote_end_date,@warn_number,@keywords,@goods_brief,@goods_desc,@goods_thumb,@goods_img,@original_img,@is_real,@extension_code,@is_on_sale,@is_alone_sale,@is_shipping,@integral,@add_time,@sort_order,@is_delete,@is_best,@is_new,@is_hot,@is_standing_stock,@is_promote,@bonus_type_id,@last_update,@goods_type,@seller_note,@give_integral,@rank_integral,@is_check,@cat_id,@is_catindex,@is_main_show,@goods_sn2,@goods_volume,@charge_by_volume,@mian_price,@goods_stock,@sx,@dealer_id,@is_share,@goods_source,@update_type,@update_reason,@update_date,@isDelete_copy)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_name_style", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_invoce_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@click_count", MySqlDbType.Int32,10),
					new MySqlParameter("@brand_id", MySqlDbType.Int16,5),
					new MySqlParameter("@provider_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@goods_number", MySqlDbType.Decimal,12),
					new MySqlParameter("@goods_weight", MySqlDbType.Decimal,18),
					new MySqlParameter("@box_num", MySqlDbType.Int32,6),
					new MySqlParameter("@box_weight", MySqlDbType.Decimal,15),
					new MySqlParameter("@box_length", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_width", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_height", MySqlDbType.Decimal,10),
					new MySqlParameter("@goods_snc", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_snb", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_sna", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_u2tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_u3tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit", MySqlDbType.VarChar,20),
					new MySqlParameter("@goods_unit2", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit3", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_packing", MySqlDbType.VarChar,250),
					new MySqlParameter("@market_price", MySqlDbType.Decimal,12),
					new MySqlParameter("@wholesale_price", MySqlDbType.Decimal,12),
					new MySqlParameter("@shop_price", MySqlDbType.Decimal,12),
					new MySqlParameter("@goods_num_limit", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_num_limit2", MySqlDbType.Int32,10),
					new MySqlParameter("@promote_price", MySqlDbType.Decimal,12),
					new MySqlParameter("@promote_start_date", MySqlDbType.Int32,11),
					new MySqlParameter("@promote_end_date", MySqlDbType.Int32,11),
					new MySqlParameter("@warn_number", MySqlDbType.Int16,3),
					new MySqlParameter("@keywords", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_brief", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_desc", MySqlDbType.Text),
					new MySqlParameter("@goods_thumb", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_img", MySqlDbType.VarChar,255),
					new MySqlParameter("@original_img", MySqlDbType.VarChar,255),
					new MySqlParameter("@is_real", MySqlDbType.Int16,3),
					new MySqlParameter("@extension_code", MySqlDbType.VarChar,30),
					new MySqlParameter("@is_on_sale", MySqlDbType.Int16,1),
					new MySqlParameter("@is_alone_sale", MySqlDbType.Int16,1),
					new MySqlParameter("@is_shipping", MySqlDbType.Int16,1),
					new MySqlParameter("@integral", MySqlDbType.Int32,10),
					new MySqlParameter("@add_time", MySqlDbType.Int32,10),
					new MySqlParameter("@sort_order", MySqlDbType.Int16,4),
					new MySqlParameter("@is_delete", MySqlDbType.Int16,1),
					new MySqlParameter("@is_best", MySqlDbType.Int16,1),
					new MySqlParameter("@is_new", MySqlDbType.Int16,1),
					new MySqlParameter("@is_hot", MySqlDbType.Int16,1),
					new MySqlParameter("@is_standing_stock", MySqlDbType.Int16,1),
					new MySqlParameter("@is_promote", MySqlDbType.Int16,1),
					new MySqlParameter("@bonus_type_id", MySqlDbType.Int16,3),
					new MySqlParameter("@last_update", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_type", MySqlDbType.Int16,5),
					new MySqlParameter("@seller_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@give_integral", MySqlDbType.Int32,11),
					new MySqlParameter("@rank_integral", MySqlDbType.Int32,11),
					new MySqlParameter("@is_check", MySqlDbType.Int16,1),
					new MySqlParameter("@cat_id", MySqlDbType.Int16,5),
					new MySqlParameter("@is_catindex", MySqlDbType.Int16,1),
					new MySqlParameter("@is_main_show", MySqlDbType.Int16,1),
					new MySqlParameter("@goods_sn2", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_volume", MySqlDbType.Decimal,10),
					new MySqlParameter("@charge_by_volume", MySqlDbType.Int16,1),
					new MySqlParameter("@mian_price", MySqlDbType.Decimal,12),
					new MySqlParameter("@goods_stock", MySqlDbType.Int32,11),
					new MySqlParameter("@sx", MySqlDbType.VarChar,30),
					new MySqlParameter("@dealer_id", MySqlDbType.Int16,6),
					new MySqlParameter("@is_share", MySqlDbType.Int16,2),
					new MySqlParameter("@goods_source", MySqlDbType.Int16,1),
					new MySqlParameter("@update_type", MySqlDbType.Int16,1),
					new MySqlParameter("@update_reason", MySqlDbType.VarChar,255),
					new MySqlParameter("@update_date", MySqlDbType.DateTime),
					new MySqlParameter("@isDelete_copy", MySqlDbType.Int16,1)};
            parameters[0].Value = model.goods_id;
            parameters[1].Value = model.factory_id;
            parameters[2].Value = model.suppliers_id;
            parameters[3].Value = model.goods_sn;
            parameters[4].Value = model.goods_name;
            parameters[5].Value = model.goods_name_style;
            parameters[6].Value = model.goods_invoce_name;
            parameters[7].Value = model.click_count;
            parameters[8].Value = model.brand_id;
            parameters[9].Value = model.provider_name;
            parameters[10].Value = model.goods_number;
            parameters[11].Value = model.goods_weight;
            parameters[12].Value = model.box_num;
            parameters[13].Value = model.box_weight;
            parameters[14].Value = model.box_length;
            parameters[15].Value = model.box_width;
            parameters[16].Value = model.box_height;
            parameters[17].Value = model.goods_snc;
            parameters[18].Value = model.goods_snb;
            parameters[19].Value = model.goods_sna;
            parameters[20].Value = model.goods_u2tou1;
            parameters[21].Value = model.goods_u3tou1;
            parameters[22].Value = model.goods_unit;
            parameters[23].Value = model.goods_unit2;
            parameters[24].Value = model.goods_unit3;
            parameters[25].Value = model.goods_packing;
            parameters[26].Value = model.market_price;
            parameters[27].Value = model.wholesale_price;
            parameters[28].Value = model.shop_price;
            parameters[29].Value = model.goods_num_limit;
            parameters[30].Value = model.goods_num_limit2;
            parameters[31].Value = model.promote_price;
            parameters[32].Value = model.promote_start_date;
            parameters[33].Value = model.promote_end_date;
            parameters[34].Value = model.warn_number;
            parameters[35].Value = model.keywords;
            parameters[36].Value = model.goods_brief;
            parameters[37].Value = model.goods_desc;
            parameters[38].Value = model.goods_thumb;
            parameters[39].Value = model.goods_img;
            parameters[40].Value = model.original_img;
            parameters[41].Value = model.is_real;
            parameters[42].Value = model.extension_code;
            parameters[43].Value = model.is_on_sale;
            parameters[44].Value = model.is_alone_sale;
            parameters[45].Value = model.is_shipping;
            parameters[46].Value = model.integral;
            parameters[47].Value = model.add_time;
            parameters[48].Value = model.sort_order;
            parameters[49].Value = model.is_delete;
            parameters[50].Value = model.is_best;
            parameters[51].Value = model.is_new;
            parameters[52].Value = model.is_hot;
            parameters[53].Value = model.is_standing_stock;
            parameters[54].Value = model.is_promote;
            parameters[55].Value = model.bonus_type_id;
            parameters[56].Value = model.last_update;
            parameters[57].Value = model.goods_type;
            parameters[58].Value = model.seller_note;
            parameters[59].Value = model.give_integral;
            parameters[60].Value = model.rank_integral;
            parameters[61].Value = model.is_check;
            parameters[62].Value = model.cat_id;
            parameters[63].Value = model.is_catindex;
            parameters[64].Value = model.is_main_show;
            parameters[65].Value = model.goods_sn2;
            parameters[66].Value = model.goods_volume;
            parameters[67].Value = model.charge_by_volume;
            parameters[68].Value = model.mian_price;
            parameters[69].Value = model.goods_stock;
            parameters[70].Value = model.sx;
            parameters[71].Value = model.dealer_id;
            parameters[72].Value = model.is_share;
            parameters[73].Value = model.goods_source;
            parameters[74].Value = model.update_type;
            parameters[75].Value = model.update_reason;
            parameters[76].Value = model.update_date;
            parameters[77].Value = model.isDelete_copy;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(XHD.Model.scm_supply_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_supply_goods set ");
            strSql.Append("cat_id=@cat_id,");
            //strSql.Append("goods_sn=@goods_sn,");
            strSql.Append("goods_name=@goods_name,");
            strSql.Append("goods_name_style=@goods_name_style,");
            strSql.Append("brand_id=@brand_id,");
            strSql.Append("goods_number=@goods_number,");
            strSql.Append("goods_weight=@goods_weight,");
            strSql.Append("box_num=@box_num,");
            strSql.Append("box_weight=@box_weight,");
            strSql.Append("box_length=@box_length,");
            strSql.Append("box_width=@box_width,");
            strSql.Append("box_height=@box_height,");
            strSql.Append("goods_unit=@goods_unit,");
            strSql.Append("goods_snc=@goods_snc,");
            strSql.Append("goods_snb=@goods_snb,");
            strSql.Append("goods_sna=@goods_sna,");
            strSql.Append("goods_u2tou1=@goods_u2tou1,");
            strSql.Append("goods_u3tou1=@goods_u3tou1,");
            strSql.Append("goods_unit3=@goods_unit3,");
            strSql.Append("goods_unit2=@goods_unit2,");
            strSql.Append("goods_packing=@goods_packing,");
            strSql.Append("goods_desc=@goods_desc,");
            strSql.Append("goods_thumb=@goods_thumb,");
            strSql.Append("goods_img=@goods_img,");
            strSql.Append("original_img=@original_img,");
            //strSql.Append("is_on_sale=@is_on_sale,");
            strSql.Append("last_update=@last_update,");
            strSql.Append("goods_type=@goods_type,");
            strSql.Append("goods_sn2=@goods_sn2,");
            strSql.Append("goods_volume=@goods_volume,");
            strSql.Append("sx=@sx,");
            strSql.Append("market_price=@market_price,");
            strSql.Append("update_type=0,");
            strSql.Append("update_date='" + DateTime.Now + "'");
            strSql.Append(" where goods_id=@goods_id");
            strSql.Append(" and suppliers_id=@suppliers_id");
            strSql.Append(" and  isDelete_copy=0");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cat_id", MySqlDbType.Int16,5),
                    //new MySqlParameter("@goods_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_name_style", MySqlDbType.VarChar,60),
					new MySqlParameter("@brand_id", MySqlDbType.Int16,5),
					new MySqlParameter("@goods_number", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_weight", MySqlDbType.Decimal,18),
					new MySqlParameter("@box_num", MySqlDbType.Int32,6),
					new MySqlParameter("@box_weight", MySqlDbType.Decimal,15),
					new MySqlParameter("@box_length", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_width", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_height", MySqlDbType.Decimal,10),
					new MySqlParameter("@goods_unit", MySqlDbType.VarChar,20),
					new MySqlParameter("@goods_snc", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_snb", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_sna", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_u2tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_u3tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit3", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit2", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_packing", MySqlDbType.VarChar,250),
					new MySqlParameter("@goods_desc", MySqlDbType.Text),
					new MySqlParameter("@goods_thumb", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_img", MySqlDbType.VarChar,255),
					new MySqlParameter("@original_img", MySqlDbType.VarChar,255),
					new MySqlParameter("@is_on_sale", MySqlDbType.Int16,1),
					new MySqlParameter("@last_update", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_type", MySqlDbType.Int16,5),
					new MySqlParameter("@goods_sn2", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_volume", MySqlDbType.Decimal,10),
					new MySqlParameter("@sx", MySqlDbType.VarChar,30),
                    new MySqlParameter("@market_price", MySqlDbType.Decimal,12),
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
                                              new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5)};
            parameters[0].Value = model.cat_id;
            //parameters[1].Value = model.goods_sn;
            parameters[1].Value = model.goods_name;
            parameters[2].Value = model.goods_name_style;
            parameters[3].Value = model.brand_id;
            parameters[4].Value = model.goods_number;
            parameters[5].Value = model.goods_weight;
            parameters[6].Value = model.box_num;
            parameters[7].Value = model.box_weight;
            parameters[8].Value = model.box_length;
            parameters[9].Value = model.box_width;
            parameters[10].Value = model.box_height;
            parameters[11].Value = model.goods_unit;
            parameters[12].Value = model.goods_snc;
            parameters[13].Value = model.goods_snb;
            parameters[14].Value = model.goods_sna;
            parameters[15].Value = model.goods_u2tou1;
            parameters[16].Value = model.goods_u3tou1;
            parameters[17].Value = model.goods_unit3;
            parameters[18].Value = model.goods_unit2;
            parameters[19].Value = model.goods_packing;
            parameters[20].Value = model.goods_desc;
            parameters[21].Value = model.goods_thumb;
            parameters[22].Value = model.goods_img;
            parameters[23].Value = model.original_img;
            parameters[24].Value = model.is_on_sale;
            parameters[25].Value = model.last_update;
            parameters[26].Value = model.goods_type;
            parameters[27].Value = model.goods_sn2;
            parameters[28].Value = model.goods_volume;
            parameters[29].Value = model.sx;
            parameters[30].Value = model.market_price;
            parameters[31].Value = model.goods_id;
            parameters[32].Value = model.suppliers_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 更新到主表
        /// </summary>
        public bool UpdateToShop(XHD.Model.scm_supply_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_goods set ");
            strSql.Append("cat_id=@cat_id,");
            //strSql.Append("goods_sn=@goods_sn,");
            strSql.Append("goods_name=@goods_name,");
            strSql.Append("goods_name_style=@goods_name_style,");
            strSql.Append("brand_id=@brand_id,");
            strSql.Append("goods_number=@goods_number,");
            strSql.Append("goods_weight=@goods_weight,");
            strSql.Append("box_num=@box_num,");
            strSql.Append("box_weight=@box_weight,");
            strSql.Append("box_length=@box_length,");
            strSql.Append("box_width=@box_width,");
            strSql.Append("box_height=@box_height,");
            strSql.Append("goods_unit=@goods_unit,");
            strSql.Append("goods_snc=@goods_snc,");
            strSql.Append("goods_snb=@goods_snb,");
            strSql.Append("goods_sna=@goods_sna,");
            strSql.Append("goods_u2tou1=@goods_u2tou1,");
            strSql.Append("goods_u3tou1=@goods_u3tou1,");
            strSql.Append("goods_unit3=@goods_unit3,");
            strSql.Append("goods_unit2=@goods_unit2,");
            strSql.Append("goods_packing=@goods_packing,");
            strSql.Append("goods_desc=@goods_desc,");
            strSql.Append("goods_thumb=@goods_thumb,");
            strSql.Append("goods_img=@goods_img,");
            strSql.Append("original_img=@original_img,");
            strSql.Append("last_update=@last_update,");
            strSql.Append("goods_type=@goods_type,");
            strSql.Append("goods_sn2=@goods_sn2,");
            strSql.Append("goods_volume=@goods_volume,");
            strSql.Append("sx=@sx,");
            strSql.Append("file_ip=@file_ip,");
            strSql.Append("market_price=@market_price");
            strSql.Append(" where goods_id=@goods_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cat_id", MySqlDbType.Int16,5),
                    //new MySqlParameter("@goods_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_name_style", MySqlDbType.VarChar,60),
					new MySqlParameter("@brand_id", MySqlDbType.Int16,5),
					new MySqlParameter("@goods_number", MySqlDbType.Int32,11),
					new MySqlParameter("@goods_weight", MySqlDbType.Decimal,18),
					new MySqlParameter("@box_num", MySqlDbType.Int32,6),
					new MySqlParameter("@box_weight", MySqlDbType.Decimal,15),
					new MySqlParameter("@box_length", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_width", MySqlDbType.Decimal,10),
					new MySqlParameter("@box_height", MySqlDbType.Decimal,10),
					new MySqlParameter("@goods_unit", MySqlDbType.VarChar,20),
					new MySqlParameter("@goods_snc", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_snb", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_sna", MySqlDbType.VarChar,48),
					new MySqlParameter("@goods_u2tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_u3tou1", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit3", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_unit2", MySqlDbType.VarChar,6),
					new MySqlParameter("@goods_packing", MySqlDbType.VarChar,250),
					new MySqlParameter("@goods_desc", MySqlDbType.Text),
					new MySqlParameter("@goods_thumb", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_img", MySqlDbType.VarChar,255),
					new MySqlParameter("@original_img", MySqlDbType.VarChar,255),
					new MySqlParameter("@last_update", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_type", MySqlDbType.Int16,5),
					new MySqlParameter("@goods_sn2", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_volume", MySqlDbType.Decimal,10),
					new MySqlParameter("@sx", MySqlDbType.VarChar,30),
                    new MySqlParameter("@file_ip", MySqlDbType.VarChar,200),
                    new MySqlParameter("@market_price", MySqlDbType.Decimal,12),
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8)};
            parameters[0].Value = model.cat_id;
            //parameters[1].Value = model.goods_sn;
            parameters[1].Value = model.goods_name;
            parameters[2].Value = model.goods_name_style;
            parameters[3].Value = model.brand_id;
            parameters[4].Value = model.goods_number;
            parameters[5].Value = model.goods_weight;
            parameters[6].Value = model.box_num;
            parameters[7].Value = model.box_weight;
            parameters[8].Value = model.box_length;
            parameters[9].Value = model.box_width;
            parameters[10].Value = model.box_height;
            parameters[11].Value = model.goods_unit;
            parameters[12].Value = model.goods_snc;
            parameters[13].Value = model.goods_snb;
            parameters[14].Value = model.goods_sna;
            parameters[15].Value = model.goods_u2tou1;
            parameters[16].Value = model.goods_u3tou1;
            parameters[17].Value = model.goods_unit3;
            parameters[18].Value = model.goods_unit2;
            parameters[19].Value = model.goods_packing;
            parameters[20].Value = model.goods_desc;
            parameters[21].Value = model.goods_thumb;
            parameters[22].Value = model.goods_img;
            parameters[23].Value = model.original_img;
            parameters[24].Value = model.last_update;
            parameters[25].Value = model.goods_type;
            parameters[26].Value = model.goods_sn2;
            parameters[27].Value = model.goods_volume;
            parameters[28].Value = model.sx;
            parameters[29].Value = model.file_ip;
            parameters[30].Value = model.market_price;
            parameters[31].Value = model.goods_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int goods_id, int suppliers_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_supply_goods ");
            strSql.Append("set isDelete_copy=1 ");
            strSql.Append(" where goods_id=@goods_id ");
            strSql.Append(" and suppliers_id=@suppliers_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
                    new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5)};
            parameters[0].Value = goods_id;
            parameters[1].Value = suppliers_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 拒绝申请
        /// </summary>
        public bool refuse(int id, int suppliers_id, string reason, string type)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_supply_goods ");
            strSql.Append("set is_on_sale=" + type + ", ");
            strSql.Append(" refuse_reason='" + reason + "'");
            strSql.Append(" where goods_id = " + id);
            strSql.Append(" and suppliers_id=" + suppliers_id);
            strSql.Append(" and isDelete_copy=0 ");

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        /// 删除同步商城
        /// </summary>
        public bool setDeleteToShop(int goods_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_goods ");
            strSql.Append("set is_delete=1 ");
            strSql.Append(" where goods_id =" + goods_id);

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        /// 下架同步商城
        /// </summary>
        public bool setOutToShop(int goods_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_goods ");
            strSql.Append("set is_on_sale=0 ");
            strSql.Append(" where goods_id =" + goods_id);

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        /// 退市同步到商城
        /// </summary>
        public bool setDeliToShop(int goods_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_goods ");
            strSql.Append("set is_on_sale=3 ");
            strSql.Append(" where goods_id = " + goods_id);
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
            strSql.Append("delete from scm_supply_goods ");
            strSql.Append(" where goods_id in (" + goods_idlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public XHD.Model.scm_supply_goods GetModel(int goods_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select goods_id,factory_id,suppliers_id,goods_sn,goods_name,goods_name_style,goods_invoce_name,click_count,brand_id,provider_name,goods_number,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_snc,goods_snb,goods_sna,goods_u2tou1,goods_u3tou1,goods_unit,goods_unit2,goods_unit3,goods_packing,market_price,wholesale_price,shop_price,goods_num_limit,goods_num_limit2,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,is_shipping,integral,add_time,sort_order,is_delete,is_best,is_new,is_hot,is_standing_stock,is_promote,bonus_type_id,last_update,goods_type,seller_note,give_integral,rank_integral,is_check,cat_id,is_catindex,is_main_show,goods_sn2,goods_volume,charge_by_volume,mian_price,goods_stock,sx,dealer_id,is_share,goods_source,update_type,update_reason,update_date,isDelete_copy,file_ip from scm_supply_goods ");
            strSql.Append(" where goods_id=@goods_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = goods_id;

            XHD.Model.scm_supply_goods model = new XHD.Model.scm_supply_goods();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// 同步商城用
        /// </summary>
        public XHD.Model.scm_supply_goods GetModelShop(int goods_id, int suppliers_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select goods_id,factory_id,suppliers_id,goods_sn,goods_name,goods_name_style,goods_invoce_name,click_count,brand_id,provider_name,goods_number,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_snc,goods_snb,goods_sna,goods_u2tou1,goods_u3tou1,goods_unit,goods_unit2,goods_unit3,goods_packing,market_price,wholesale_price,shop_price,goods_num_limit,goods_num_limit2,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,is_shipping,integral,add_time,sort_order,is_delete,is_best,is_new,is_hot,is_standing_stock,is_promote,bonus_type_id,last_update,goods_type,seller_note,give_integral,rank_integral,is_check,cat_id,is_catindex,is_main_show,goods_sn2,goods_volume,charge_by_volume,mian_price,goods_stock,sx,dealer_id,is_share,goods_source,update_type,update_reason,update_date,isDelete_copy,file_ip from scm_supply_goods ");
            strSql.Append(" where goods_id=@goods_id ");
            strSql.Append(" and suppliers_id=@suppliers_id ");
            strSql.Append(" and isDelete_copy=0 and update_type=0 and is_on_sale=0 ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
                    new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5)};
            parameters[0].Value = goods_id;
            parameters[1].Value = suppliers_id;

            XHD.Model.scm_supply_goods model = new XHD.Model.scm_supply_goods();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModelToShop(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// 同步商城用
        /// </summary>
        public XHD.Model.scm_supply_goods DataRowToModelToShop(DataRow row)
        {
            XHD.Model.scm_supply_goods model = new XHD.Model.scm_supply_goods();
            if (row != null)
            {
                if (row["goods_id"] != null)
                {
                    model.goods_id = int.Parse(row["goods_id"].ToString());
                }
                if (row["goods_sn"] != null)
                {
                    model.goods_sn = row["goods_sn"].ToString();
                }
                if (row["goods_name"] != null)
                {
                    model.goods_name = row["goods_name"].ToString();
                }
                if (row["goods_name_style"] != null)
                {
                    model.goods_name_style = row["goods_name_style"].ToString();
                }
                if (row["goods_invoce_name"] != null)
                {
                    model.goods_invoce_name = row["goods_invoce_name"].ToString();
                }
                if (row["brand_id"] != null && row["brand_id"].ToString() != "")
                {
                    model.brand_id = int.Parse(row["brand_id"].ToString());
                }
                if (row["provider_name"] != null)
                {
                    model.provider_name = row["provider_name"].ToString();
                }
                if (row["goods_number"] != null && row["goods_number"].ToString() != "")
                {
                    model.goods_number = decimal.Parse(row["goods_number"].ToString());
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
                if (row["goods_snc"] != null)
                {
                    model.goods_snc = row["goods_snc"].ToString();
                }
                if (row["goods_snb"] != null)
                {
                    model.goods_snb = row["goods_snb"].ToString();
                }
                if (row["goods_sna"] != null)
                {
                    model.goods_sna = row["goods_sna"].ToString();
                }
                if (row["goods_u2tou1"] != null)
                {
                    model.goods_u2tou1 = row["goods_u2tou1"].ToString();
                }
                if (row["goods_u3tou1"] != null)
                {
                    model.goods_u3tou1 = row["goods_u3tou1"].ToString();
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
                if (row["goods_packing"] != null)
                {
                    model.goods_packing = row["goods_packing"].ToString();
                }
                if (row["market_price"] != null && row["market_price"].ToString() != "")
                {
                    model.market_price = decimal.Parse(row["market_price"].ToString());
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
                if (row["original_img"] != null)
                {
                    model.original_img = row["original_img"].ToString();
                }

                if (row["is_on_sale"] != null && row["is_on_sale"].ToString() != "")
                {
                    model.is_on_sale = int.Parse(row["is_on_sale"].ToString());
                }
                if (row["last_update"] != null && row["last_update"].ToString() != "")
                {
                    model.last_update = int.Parse(row["last_update"].ToString());
                }
                if (row["goods_type"] != null && row["goods_type"].ToString() != "")
                {
                    model.goods_type = int.Parse(row["goods_type"].ToString());
                }
                if (row["cat_id"] != null && row["cat_id"].ToString() != "")
                {
                    model.cat_id = int.Parse(row["cat_id"].ToString());
                }

                if (row["goods_sn2"] != null)
                {
                    model.goods_sn2 = row["goods_sn2"].ToString();
                }
                if (row["goods_volume"] != null && row["goods_volume"].ToString() != "")
                {
                    model.goods_volume = decimal.Parse(row["goods_volume"].ToString());
                }

                if (row["sx"] != null)
                {
                    model.sx = row["sx"].ToString();
                }
                if (row["file_ip"] != null)
                {
                    model.file_ip = row["file_ip"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.scm_supply_goods DataRowToModel(DataRow row)
        {
            XHD.Model.scm_supply_goods model = new XHD.Model.scm_supply_goods();
            if (row != null)
            {
                //model.goods_id=row["goods_id"].ToString();
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                if (row["goods_sn"] != null)
                {
                    model.goods_sn = row["goods_sn"].ToString();
                }
                if (row["goods_name"] != null)
                {
                    model.goods_name = row["goods_name"].ToString();
                }
                if (row["goods_name_style"] != null)
                {
                    model.goods_name_style = row["goods_name_style"].ToString();
                }
                if (row["goods_invoce_name"] != null)
                {
                    model.goods_invoce_name = row["goods_invoce_name"].ToString();
                }
                if (row["click_count"] != null && row["click_count"].ToString() != "")
                {
                    model.click_count = int.Parse(row["click_count"].ToString());
                }
                if (row["brand_id"] != null && row["brand_id"].ToString() != "")
                {
                    model.brand_id = int.Parse(row["brand_id"].ToString());
                }
                if (row["provider_name"] != null)
                {
                    model.provider_name = row["provider_name"].ToString();
                }
                if (row["goods_number"] != null && row["goods_number"].ToString() != "")
                {
                    model.goods_number = decimal.Parse(row["goods_number"].ToString());
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
                if (row["goods_snc"] != null)
                {
                    model.goods_snc = row["goods_snc"].ToString();
                }
                if (row["goods_snb"] != null)
                {
                    model.goods_snb = row["goods_snb"].ToString();
                }
                if (row["goods_sna"] != null)
                {
                    model.goods_sna = row["goods_sna"].ToString();
                }
                if (row["goods_u2tou1"] != null)
                {
                    model.goods_u2tou1 = row["goods_u2tou1"].ToString();
                }
                if (row["goods_u3tou1"] != null)
                {
                    model.goods_u3tou1 = row["goods_u3tou1"].ToString();
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
                if (row["goods_packing"] != null)
                {
                    model.goods_packing = row["goods_packing"].ToString();
                }
                if (row["market_price"] != null && row["market_price"].ToString() != "")
                {
                    model.market_price = decimal.Parse(row["market_price"].ToString());
                }
                if (row["wholesale_price"] != null && row["wholesale_price"].ToString() != "")
                {
                    model.wholesale_price = decimal.Parse(row["wholesale_price"].ToString());
                }
                if (row["shop_price"] != null && row["shop_price"].ToString() != "")
                {
                    model.shop_price = decimal.Parse(row["shop_price"].ToString());
                }
                if (row["goods_num_limit"] != null && row["goods_num_limit"].ToString() != "")
                {
                    model.goods_num_limit = int.Parse(row["goods_num_limit"].ToString());
                }
                if (row["goods_num_limit2"] != null && row["goods_num_limit2"].ToString() != "")
                {
                    model.goods_num_limit2 = int.Parse(row["goods_num_limit2"].ToString());
                }
                if (row["promote_price"] != null && row["promote_price"].ToString() != "")
                {
                    model.promote_price = decimal.Parse(row["promote_price"].ToString());
                }
                if (row["promote_start_date"] != null && row["promote_start_date"].ToString() != "")
                {
                    model.promote_start_date = int.Parse(row["promote_start_date"].ToString());
                }
                if (row["promote_end_date"] != null && row["promote_end_date"].ToString() != "")
                {
                    model.promote_end_date = int.Parse(row["promote_end_date"].ToString());
                }
                if (row["warn_number"] != null && row["warn_number"].ToString() != "")
                {
                    model.warn_number = int.Parse(row["warn_number"].ToString());
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
                if (row["original_img"] != null)
                {
                    model.original_img = row["original_img"].ToString();
                }
                if (row["is_real"] != null && row["is_real"].ToString() != "")
                {
                    model.is_real = int.Parse(row["is_real"].ToString());
                }
                if (row["extension_code"] != null)
                {
                    model.extension_code = row["extension_code"].ToString();
                }
                if (row["is_on_sale"] != null && row["is_on_sale"].ToString() != "")
                {
                    model.is_on_sale = int.Parse(row["is_on_sale"].ToString());
                }
                if (row["is_alone_sale"] != null && row["is_alone_sale"].ToString() != "")
                {
                    model.is_alone_sale = int.Parse(row["is_alone_sale"].ToString());
                }
                if (row["is_shipping"] != null && row["is_shipping"].ToString() != "")
                {
                    model.is_shipping = int.Parse(row["is_shipping"].ToString());
                }
                if (row["integral"] != null && row["integral"].ToString() != "")
                {
                    model.integral = int.Parse(row["integral"].ToString());
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = int.Parse(row["add_time"].ToString());
                }
                if (row["sort_order"] != null && row["sort_order"].ToString() != "")
                {
                    model.sort_order = int.Parse(row["sort_order"].ToString());
                }
                if (row["is_delete"] != null && row["is_delete"].ToString() != "")
                {
                    model.is_delete = int.Parse(row["is_delete"].ToString());
                }
                if (row["is_best"] != null && row["is_best"].ToString() != "")
                {
                    model.is_best = int.Parse(row["is_best"].ToString());
                }
                if (row["is_new"] != null && row["is_new"].ToString() != "")
                {
                    model.is_new = int.Parse(row["is_new"].ToString());
                }
                if (row["is_hot"] != null && row["is_hot"].ToString() != "")
                {
                    model.is_hot = int.Parse(row["is_hot"].ToString());
                }
                if (row["is_standing_stock"] != null && row["is_standing_stock"].ToString() != "")
                {
                    model.is_standing_stock = int.Parse(row["is_standing_stock"].ToString());
                }
                if (row["is_promote"] != null && row["is_promote"].ToString() != "")
                {
                    model.is_promote = int.Parse(row["is_promote"].ToString());
                }
                if (row["bonus_type_id"] != null && row["bonus_type_id"].ToString() != "")
                {
                    model.bonus_type_id = int.Parse(row["bonus_type_id"].ToString());
                }
                if (row["last_update"] != null && row["last_update"].ToString() != "")
                {
                    model.last_update = int.Parse(row["last_update"].ToString());
                }
                if (row["goods_type"] != null && row["goods_type"].ToString() != "")
                {
                    model.goods_type = int.Parse(row["goods_type"].ToString());
                }
                if (row["seller_note"] != null)
                {
                    model.seller_note = row["seller_note"].ToString();
                }
                if (row["give_integral"] != null && row["give_integral"].ToString() != "")
                {
                    model.give_integral = int.Parse(row["give_integral"].ToString());
                }
                if (row["rank_integral"] != null && row["rank_integral"].ToString() != "")
                {
                    model.rank_integral = int.Parse(row["rank_integral"].ToString());
                }
                if (row["is_check"] != null && row["is_check"].ToString() != "")
                {
                    model.is_check = int.Parse(row["is_check"].ToString());
                }
                if (row["cat_id"] != null && row["cat_id"].ToString() != "")
                {
                    model.cat_id = int.Parse(row["cat_id"].ToString());
                }
                if (row["is_catindex"] != null && row["is_catindex"].ToString() != "")
                {
                    model.is_catindex = int.Parse(row["is_catindex"].ToString());
                }
                if (row["is_main_show"] != null && row["is_main_show"].ToString() != "")
                {
                    model.is_main_show = int.Parse(row["is_main_show"].ToString());
                }
                if (row["goods_sn2"] != null)
                {
                    model.goods_sn2 = row["goods_sn2"].ToString();
                }
                if (row["goods_volume"] != null && row["goods_volume"].ToString() != "")
                {
                    model.goods_volume = decimal.Parse(row["goods_volume"].ToString());
                }
                if (row["charge_by_volume"] != null && row["charge_by_volume"].ToString() != "")
                {
                    model.charge_by_volume = int.Parse(row["charge_by_volume"].ToString());
                }
                if (row["mian_price"] != null && row["mian_price"].ToString() != "")
                {
                    model.mian_price = decimal.Parse(row["mian_price"].ToString());
                }
                if (row["goods_stock"] != null && row["goods_stock"].ToString() != "")
                {
                    model.goods_stock = int.Parse(row["goods_stock"].ToString());
                }
                if (row["sx"] != null)
                {
                    model.sx = row["sx"].ToString();
                }
                //model.dealer_id=row["dealer_id"].ToString();
                if (row["is_share"] != null && row["is_share"].ToString() != "")
                {
                    model.is_share = int.Parse(row["is_share"].ToString());
                }
                if (row["goods_source"] != null && row["goods_source"].ToString() != "")
                {
                    model.goods_source = int.Parse(row["goods_source"].ToString());
                }
                if (row["update_type"] != null && row["update_type"].ToString() != "")
                {
                    model.update_type = int.Parse(row["update_type"].ToString());
                }
                if (row["update_reason"] != null)
                {
                    model.update_reason = row["update_reason"].ToString();
                }
                if (row["update_date"] != null && row["update_date"].ToString() != "")
                {
                    model.update_date = DateTime.Parse(row["update_date"].ToString());
                }
                if (row["isDelete_copy"] != null && row["isDelete_copy"].ToString() != "")
                {
                    model.isDelete_copy = int.Parse(row["isDelete_copy"].ToString());
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
            strSql.Append("select goods_id,factory_id,suppliers_id,goods_sn,goods_name,goods_name_style,goods_invoce_name,click_count,brand_id,provider_name,goods_number,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_snc,goods_snb,goods_sna,goods_u2tou1,goods_u3tou1,goods_unit,goods_unit2,goods_unit3,goods_packing,market_price,wholesale_price,shop_price,goods_num_limit,goods_num_limit2,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,is_shipping,integral,add_time,sort_order,is_delete,is_best,is_new,is_hot,is_standing_stock,is_promote,bonus_type_id,last_update,goods_type,seller_note,give_integral,rank_integral,is_check,cat_id,is_catindex,is_main_show,goods_sn2,goods_volume,charge_by_volume,mian_price,goods_stock,sx,dealer_id,is_share,goods_source,update_type,update_reason,update_date,isDelete_copy ");
            strSql.Append(" FROM scm_supply_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM scm_supply_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
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
            strSql.Append(")AS Row, T.*  from scm_supply_goods T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select g.goods_id,g.factory_id,g.suppliers_id,g.goods_sn,g.goods_name,g.goods_name_style,g.goods_invoce_name,g.click_count,g.brand_id,g.provider_name,g.goods_number,g.goods_weight,g.box_num,g.box_weight,g.box_length,g.box_width,g.box_height,g.goods_snc,g.goods_snb,g.goods_sna,g.goods_u2tou1,g.goods_u3tou1,g.goods_unit,g.goods_unit2,g.goods_unit3,g.goods_packing,g.market_price,g.wholesale_price,g.shop_price,g.goods_num_limit,g.goods_num_limit2,g.promote_price,g.promote_start_date,g.promote_end_date,g.warn_number,g.keywords,g.goods_brief,g.goods_desc,g.goods_thumb,g.goods_img,g.original_img,g.is_real,g.extension_code,g.is_on_sale,g.is_alone_sale,g.is_shipping,g.integral,g.add_time,g.sort_order,g.is_delete,g.is_best,g.is_new,g.is_hot,g.is_standing_stock,g.is_promote,g.bonus_type_id,g.last_update,g.goods_type,g.seller_note,g.give_integral,g.rank_integral,g.is_check,g.cat_id,g.is_catindex,g.is_main_show,g.goods_sn2,g.goods_volume,g.charge_by_volume,g.mian_price,g.goods_stock,g.sx,g.dealer_id,g.is_share,g.goods_source,g.file_ip,s.suppliers_name,g.update_reason      ");
            strSql.Append(" from scm_supply_goods as g left join ecs_suppliers as s on g.suppliers_id=s.suppliers_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql1.Append(" select count(1) FROM scm_supply_goods as g ");
            if (strWhere.Trim() != "")
            {
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    StringBuilder strSql1 = new StringBuilder();
        //    strSql.Append("select abc.* FROM (");
        //    strSql.Append(" select goods_id,factory_id,suppliers_id,goods_sn,goods_name,goods_name_style,goods_invoce_name,click_count,brand_id,provider_name,goods_number,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_snc,goods_snb,goods_sna,goods_u2tou1,goods_u3tou1,goods_unit,goods_unit2,goods_unit3,goods_packing,market_price,wholesale_price,shop_price,goods_num_limit,goods_num_limit2,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,is_shipping,integral,add_time,sort_order,is_delete,is_best,is_new,is_hot,is_standing_stock,is_promote,bonus_type_id,last_update,goods_type,seller_note,give_integral,rank_integral,is_check,cat_id,is_catindex,is_main_show,goods_sn2,goods_volume,charge_by_volume,mian_price,goods_stock,sx,dealer_id,is_share,2 as type ");
        //    strSql.Append(" from scm_supply_goods");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where isDelete_copy=0 and " + strWhere);
        //    }
        //    strSql.Append(" UNION All ");
        //    strSql.Append("select goods_id,factory_id,suppliers_id,goods_sn,goods_name,goods_name_style,goods_invoce_name,click_count,brand_id,provider_name,goods_number,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_snc,goods_snb,goods_sna,goods_u2tou1,goods_u3tou1,goods_unit,goods_unit2,goods_unit3,goods_packing,market_price,wholesale_price,shop_price,goods_num_limit,goods_num_limit2,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,is_shipping,integral,add_time,sort_order,is_delete,is_best,is_new,is_hot,is_standing_stock,is_promote,bonus_type_id,last_update,goods_type,seller_note,give_integral,rank_integral,is_check,cat_id,is_catindex,is_main_show,goods_sn2,goods_volume,charge_by_volume,mian_price,goods_stock,sx,dealer_id,is_share,1 as type ");
        //    strSql.Append(" FROM ecs_goods ");
        //    strSql.Append(" where goods_id not in(select goods_id from scm_supply_goods where isDelete_copy=0) and is_delete=0");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" and " + strWhere);
        //    }

        //    strSql1.Append(" select count(1) FROM ecs_goods ");
        //    strSql1.Append(" where is_delete=0");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql1.Append(" and " + strWhere);
        //    }
        //    strSql.Append(")   as abc ");
        //    strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
        //    Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
        //    return DbHelperMySQL.Query(strSql.ToString());
        //}

        /// <summary>
        /// 产品主表向附表添加数据
        /// </summary>
        public bool AddCopy(int goods_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_supply_goods(goods_id,factory_id,suppliers_id,goods_sn,goods_name,goods_name_style,goods_invoce_name,click_count,brand_id,provider_name,goods_number,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_snc,goods_snb,goods_sna,goods_u2tou1,goods_u3tou1,goods_unit,goods_unit2,goods_unit3,goods_packing,market_price,wholesale_price,shop_price,goods_num_limit,goods_num_limit2,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,is_shipping,integral,add_time,sort_order,is_delete,is_best,is_new,is_hot,is_standing_stock,is_promote,bonus_type_id,last_update,goods_type,seller_note,give_integral,rank_integral,is_check,cat_id,is_catindex,is_main_show,goods_sn2,goods_volume,charge_by_volume,mian_price,goods_stock,sx,dealer_id,is_share,file_ip) ");
            strSql.Append(" select goods_id,factory_id,suppliers_id,goods_sn,goods_name,goods_name_style,goods_invoce_name,click_count,brand_id,provider_name,goods_number,goods_weight,box_num,box_weight,box_length,box_width,box_height,goods_snc,goods_snb,goods_sna,goods_u2tou1,goods_u3tou1,goods_unit,goods_unit2,goods_unit3,goods_packing,market_price,wholesale_price,shop_price,goods_num_limit,goods_num_limit2,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,is_shipping,integral,add_time,sort_order,is_delete,is_best,is_new,is_hot,is_standing_stock,is_promote,bonus_type_id,last_update,goods_type,seller_note,give_integral,rank_integral,is_check,cat_id,is_catindex,is_main_show,goods_sn2,goods_volume,charge_by_volume,mian_price,goods_stock,sx,dealer_id,is_share,file_ip ");
            strSql.Append(" from ecs_goods where goods_id=@goods_id  ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = goods_id;

            int row = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList1(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select g.goods_id,g.factory_Id,g.suppliers_id,g.cat_id,b.brand_name,c.cat_name,g.goods_sn,g.goods_name,g.goods_name_style,g.click_count,g.brand_id,g.provider_name,g.goods_number,g.goods_weight,g.box_num,g.box_weight,g.box_length,g.box_width,g.box_height,g.goods_unit,g.goods_snc,g.goods_snb,g.goods_sna,g.goods_u2tou1,g.goods_u3tou1,g.goods_unit3,g.goods_unit2,g.goods_packing,g.market_price,g.wholesale_price,g.shop_price,g.goods_num_limit,g.goods_num_limit2,g.promote_price,g.promote_start_date,g.promote_end_date,g.warn_number,g.keywords,g.goods_brief,g.goods_desc,g.goods_thumb,g.goods_img,g.original_img,g.is_real,g.extension_code,g.is_on_sale,g.is_alone_sale,g.is_shipping,g.integral,g.add_time,g.sort_order,g.is_delete,g.is_best,g.is_new,g.is_hot,g.is_standing_stock,g.is_promote,g.bonus_type_id,g.last_update,g.goods_type,g.seller_note,g.give_integral,g.rank_integral,g.is_check,g.is_catindex,g.is_main_show,g.goods_sn2,g.goods_volume,g.charge_by_volume,g.mian_price,g.goods_stock,g.sx,g.file_ip ");
            strSql.Append("   FROM scm_supply_goods as g left join ecs_brand as b on g.brand_id=b.brand_id left join ecs_category as c on g.cat_id=c.cat_id   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where isDelete_copy=0 and  " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 提交产品信息
        /// </summary>
        public bool submitProduct(string goods_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_supply_goods set ");
            strSql.Append(" is_on_sale=0, ");
            strSql.Append(" last_update=" + int.Parse(Common.TimeParser.GenerateTimeStamp(DateTime.Now)));
            strSql.Append(" where goods_id in (" + goods_idlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        /// 删除产品信息
        /// </summary>
        public bool setDelete(int goods_idlist, string reason)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_supply_goods set ");
            strSql.Append(" is_delete=1, ");
            strSql.Append("update_type=1,");
            strSql.Append("update_reason='" + reason + "',");
            strSql.Append("update_date='" + DateTime.Now + "'");
            strSql.Append(" where goods_id = " + goods_idlist);
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetUnitById(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ecs_category ");
            strSql.Append(" where cat_id=" + id);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            MySqlParameter[] parameters = {
                    new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@PageSize", MySqlDbType.Int32),
                    new MySqlParameter("@PageIndex", MySqlDbType.Int32),
                    new MySqlParameter("@IsReCount", MySqlDbType.Bit),
                    new MySqlParameter("@OrderType", MySqlDbType.Bit),
                    new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "scm_supply_goods";
            parameters[1].Value = "isDelete_copy";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod

        //根据商品ID在wms中查库存数量
        public DataSet GetSLByBM(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select d.SL,g.goods_name FROM dqkcyl d left join  ecs_goods g on g.goods_id=d.BM ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet Getgoods(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select g.goods_id,g.factory_id,g.suppliers_id,g.goods_sn,g.goods_name,g.goods_name_style,g.goods_invoce_name,g.click_count,g.brand_id,g.provider_name,g.goods_number,g.goods_weight,g.box_num,g.box_weight,g.box_length,g.box_width,g.box_height,g.goods_snc,g.goods_snb,g.goods_sna,g.goods_u2tou1,g.goods_u3tou1,g.goods_unit,g.goods_unit2,g.goods_unit3,g.goods_packing,g.market_price,g.wholesale_price,g.shop_price,g.goods_num_limit,g.goods_num_limit2,g.promote_price,g.promote_start_date,g.promote_end_date,g.warn_number,g.keywords,g.goods_brief,g.goods_desc,g.goods_thumb,g.goods_img,g.original_img,g.is_real,g.extension_code,g.is_on_sale,g.is_alone_sale,g.is_shipping,g.integral,g.add_time,g.sort_order,g.is_delete,g.is_best,g.is_new,g.is_hot,g.is_standing_stock,g.is_promote,g.bonus_type_id,g.last_update,g.goods_type,g.seller_note,g.give_integral,g.rank_integral,g.is_check,g.cat_id,g.is_catindex,g.is_main_show,g.goods_sn2,g.goods_volume,g.charge_by_volume,g.mian_price,g.goods_stock,g.sx,g.dealer_id,g.is_share,g.goods_source,g.file_ip,b.brand_name,s.suppliers_name     ");
            strSql.Append(" from ecs_goods as g left join ecs_brand as b on g.brand_id=b.brand_id left join ecs_suppliers as s on g.suppliers_id=s.suppliers_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql1.Append(" select count(1) FROM ecs_goods as g");
            if (strWhere.Trim() != "")
            {
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + ",g.brand_id asc  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

