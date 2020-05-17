namespace ShopErpApi.Commons
{
    using ShopErpApi.Models.DBModel;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using static ShopErpApi.Commons.SystemCommon;

    /// <summary>
    /// Defines the <see cref="DBInit" />.
    /// </summary>
    public class DBInit
    {
        /// <summary>
        /// The InitProduct.
        /// </summary>
        public static void InitProduct()
        {
            List<Product> list = new List<Product>();
            Product pro1 = new Product
            {
                product_name = "蒙时代风干牛肉干",
                product_id = "140309",
                price = 59.9M,
                purchase_price = 41.93M,
                production_date = new DateTime(2019, 12, 01),
                shelf_life = 12,
                stock_count = 58,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };

            Product pro2 = new Product
            {
                product_name = "康师傅牛肉面",
                product_id = "140310",
                price = 4.5M,
                purchase_price = 3.15M,
                production_date = new DateTime(2020, 02, 12),
                shelf_life = 12,
                stock_count = 120,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };
            Product pro3 = new Product
            {
                product_name = "汤达人桶装方便面",
                product_id = "140311",
                price = 6M,
                purchase_price = 4.2M,
                production_date = new DateTime(2020, 01, 23),
                shelf_life = 12,
                stock_count = 112,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };
            Product pro4 = new Product
            {
                product_name = "其妙蔓越莓曲奇饼干",
                product_id = "140312",
                price = 9.9M,
                purchase_price = 6.93M,
                production_date = new DateTime(2019, 11, 03),
                shelf_life = 12,
                stock_count = 50,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };
            Product pro5 = new Product
            {
                product_name = "奥利奥夹心饼干",
                product_id = "140313",
                price = 19.9M,
                purchase_price = 13.93M,
                production_date = new DateTime(2019, 12, 23),
                shelf_life = 12,
                stock_count = 60,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };
            Product pro6 = new Product
            {
                product_name = "冬己网红麦芽饼干",
                product_id = "140314",
                price = 15M,
                purchase_price = 10.5M,
                production_date = new DateTime(2019, 12, 12),
                shelf_life = 12,
                stock_count = 33,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };
            Product pro7 = new Product
            {
                product_name = "丰岛黄桃罐头",
                product_id = "140315",
                price = 12.8M,
                purchase_price = 8.96M,
                production_date = new DateTime(2020, 02, 11),
                shelf_life = 12,
                stock_count = 22,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };
            Product pro8 = new Product
            {
                product_name = "友臣肉松饼",
                product_id = "140316",
                price = 15.8M,
                purchase_price = 11.06M,
                production_date = new DateTime(2020, 03, 01),
                shelf_life = 12,
                stock_count = 31,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };
            Product pro9 = new Product
            {
                product_name = "自嗨锅",
                product_id = "140317",
                price = 23.8M,
                purchase_price = 16.66M,
                production_date = new DateTime(2020, 03, 07),
                shelf_life = 12,
                stock_count = 55,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };
            Product pro10 = new Product
            {
                product_name = "LIPO榴莲味面包干",
                product_id = "140318",
                price = 14.8M,
                purchase_price = 10.36M,
                production_date = new DateTime(2020, 01, 06),
                shelf_life = 12,
                stock_count = 25,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.FangBianShiPin,
                supplier = "山东总供"
            };
            Product pro11 = new Product
            {
                product_name = "二阳锅巴",
                product_id = "106913",
                price = 8.6M,
                purchase_price = 6.02M,
                production_date = new DateTime(2019, 12, 15),
                shelf_life = 12,
                stock_count = 44,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };
            Product pro12 = new Product
            {
                product_name = "上好佳鲜虾片",
                product_id = "106914",
                price = 9.8M,
                purchase_price = 6.86M,
                production_date = new DateTime(2020, 01, 16),
                shelf_life = 12,
                stock_count = 29,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };
            Product pro13 = new Product
            {
                product_name = "乐事薯片",
                product_id = "106915",
                price = 9.9M,
                purchase_price = 6.93M,
                production_date = new DateTime(2020, 01, 18),
                shelf_life = 12,
                stock_count = 67,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };
            Product pro14 = new Product
            {
                product_name = "董小姐薯片",
                product_id = "106916",
                price = 9.8M,
                purchase_price = 6.86M,
                production_date = new DateTime(2020, 02, 04),
                shelf_life = 12,
                stock_count = 55,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };
            Product pro15 = new Product
            {
                product_name = "五味园薯条",
                product_id = "106917",
                price = 11.8M,
                purchase_price = 8.26M,
                production_date = new DateTime(2020, 03, 08),
                shelf_life = 12,
                stock_count = 49,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };
            Product pro16 = new Product
            {
                product_name = "童友蔬菜圈",
                product_id = "106918",
                price = 18.5M,
                purchase_price = 12.95M,
                production_date = new DateTime(2020, 03, 04),
                shelf_life = 12,
                stock_count = 38,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };
            Product pro17 = new Product
            {
                product_name = "臻点童友麦香鸡味块",
                product_id = "106919",
                price = 15.4M,
                purchase_price = 10.78M,
                production_date = new DateTime(2019, 12, 23),
                shelf_life = 12,
                stock_count = 55,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };
            Product pro18 = new Product
            {
                product_name = "米多奇雪饼",
                product_id = "106920",
                price = 12.2M,
                purchase_price = 8.54M,
                production_date = new DateTime(2020, 01, 24),
                shelf_life = 12,
                stock_count = 27,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };
            Product pro19 = new Product
            {
                product_name = "怡味园猫耳朵",
                product_id = "106921",
                price = 12.8M,
                purchase_price = 8.96M,
                production_date = new DateTime(2020, 02, 19),
                shelf_life = 12,
                stock_count = 49,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };
            Product pro20 = new Product
            {
                product_name = "好友趣薯片",
                product_id = "106922",
                price = 8.8M,
                purchase_price = 6.16M,
                production_date = new DateTime(2020, 02, 11),
                shelf_life = 12,
                stock_count = 46,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.PengHuaShiPin,
                supplier = "山东总供"
            };

            Product pro21 = new Product
            {
                product_name = "俄罗斯紫皮糖",
                product_id = "102104",
                price = 16.8M,
                purchase_price = 11.76M,
                production_date = new DateTime(2019, 11, 22),
                shelf_life = 12,
                stock_count = 35,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };

            Product pro22 = new Product
            {
                product_name = "松露形黑巧克力",
                product_id = "102105",
                price = 9.9M,
                purchase_price = 6.93M,
                production_date = new DateTime(2019, 12, 11),
                shelf_life = 12,
                stock_count = 23,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };
            Product pro23 = new Product
            {
                product_name = "松尾Tirol夹心巧克力",
                product_id = "102106",
                price = 23.5M,
                purchase_price = 16.45M,
                production_date = new DateTime(2019, 12, 24),
                shelf_life = 12,
                stock_count = 8,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };
            Product pro24 = new Product
            {
                product_name = "德芙黑巧克力",
                product_id = "102107",
                price = 8M,
                purchase_price = 5.6M,
                production_date = new DateTime(2020, 01, 15),
                shelf_life = 12,
                stock_count = 43,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };
            Product pro25 = new Product
            {
                product_name = "好时巧克力牛奶排块",
                product_id = "102108",
                price = 8.9M,
                purchase_price = 6.23M,
                production_date = new DateTime(2020, 01, 30),
                shelf_life = 12,
                stock_count = 36,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };
            Product pro26 = new Product
            {
                product_name = "麦德好燕麦巧克力",
                product_id = "102109",
                price = 29.9M,
                purchase_price = 20.93M,
                production_date = new DateTime(2019, 11, 23),
                shelf_life = 12,
                stock_count = 12,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };
            Product pro27 = new Product
            {
                product_name = "健达牛奶巧克力",
                product_id = "102110",
                price = 8.4M,
                purchase_price = 5.88M,
                production_date = new DateTime(2019, 12, 18),
                shelf_life = 12,
                stock_count = 38,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };
            Product pro28 = new Product
            {
                product_name = "KDV俄罗斯土豆糖",
                product_id = "102111",
                price = 12M,
                purchase_price = 8.46M,
                production_date = new DateTime(2020, 02, 12),
                shelf_life = 12,
                stock_count = 41,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };
            Product pro29 = new Product
            {
                product_name = "梁丰麦丽素巧克力",
                product_id = "102112",
                price = 15.1M,
                purchase_price = 10.57M,
                production_date = new DateTime(2020, 03, 05),
                shelf_life = 12,
                stock_count = 39,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };
            Product pro30 = new Product
            {
                product_name = "卜珂零点速溶黑巧克力",
                product_id = "102113",
                price = 19.8M,
                purchase_price = 13.86M,
                production_date = new DateTime(2019, 12, 22),
                shelf_life = 12,
                stock_count = 26,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.TangGuo,
                supplier = "山东总供"
            };
            Product pro31 = new Product
            {
                product_name = "维他柠檬茶饮料",
                product_id = "115221",
                price = 2.5M,
                purchase_price = 1.73M,
                production_date = new DateTime(2019, 11, 14),
                shelf_life = 12,
                stock_count = 68,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro32 = new Product
            {
                product_name = "农夫山泉茶π饮料",
                product_id = "115222",
                price = 5M,
                purchase_price = 3.5M,
                production_date = new DateTime(2020, 01, 13),
                shelf_life = 12,
                stock_count = 69,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro33 = new Product
            {
                product_name = "百事可乐（罐装）",
                product_id = "115223",
                price = 3M,
                purchase_price = 2.1M,
                production_date = new DateTime(2020, 02, 08),
                shelf_life = 12,
                stock_count = 87,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro34 = new Product
            {
                product_name = "天喔茶庄蜂蜜柚子茶饮料",
                product_id = "115224",
                price = 4M,
                purchase_price = 2.8M,
                production_date = new DateTime(2019, 12, 16),
                shelf_life = 12,
                stock_count = 44,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro35 = new Product
            {
                product_name = "统一阿萨姆小奶茶饮料",
                product_id = "115225",
                price = 5.5M,
                purchase_price = 3.85M,
                production_date = new DateTime(2019, 12, 18),
                shelf_life = 12,
                stock_count = 29,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro36 = new Product
            {
                product_name = "李子园甜牛奶",
                product_id = "115226",
                price = 4.5M,
                purchase_price = 3.15M,
                production_date = new DateTime(2019, 11, 23),
                shelf_life = 12,
                stock_count = 40,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro37 = new Product
            {
                product_name = "宏宝莱荔枝味碳酸汽水",
                product_id = "115227",
                price = 5.4M,
                purchase_price = 3.78M,
                production_date = new DateTime(2019, 11, 28),
                shelf_life = 12,
                stock_count = 22,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro38 = new Product
            {
                product_name = "卡昵诗水蜜桃果汁饮料",
                product_id = "115228",
                price = 13.8M,
                purchase_price = 9.66M,
                production_date = new DateTime(2020, 02, 07),
                shelf_life = 12,
                stock_count = 39,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro39 = new Product
            {
                product_name = "达利园绿茶",
                product_id = "115229",
                price = 3.9M,
                purchase_price = 2.73M,
                production_date = new DateTime(2020, 01, 25),
                shelf_life = 12,
                stock_count = 37,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro40 = new Product
            {
                product_name = "维他可可原装进口椰子水饮料",
                product_id = "115230",
                price = 12.8M,
                purchase_price = 8.96M,
                production_date = new DateTime(2019, 12, 14),
                shelf_life = 12,
                stock_count = 27,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.YinLiao,
                supplier = "山东总供"
            };
            Product pro41 = new Product
            {
                product_name = "卡通便签本",
                product_id = "205402",
                price = 2.9M,
                purchase_price = 2.03M,
                production_date = new DateTime(2020, 01, 05),
                shelf_life = 12,
                stock_count = 26,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro42 = new Product
            {
                product_name = "桌面收纳盒",
                product_id = "205403",
                price = 6.5M,
                purchase_price = 4.55M,
                production_date = new DateTime(2019, 12, 18),
                shelf_life = 12,
                stock_count = 15,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro43 = new Product
            {
                product_name = "衣架",
                product_id = "205404",
                price = 9.9M,
                purchase_price = 6.93M,
                production_date = new DateTime(2019, 10, 15),
                shelf_life = 12,
                stock_count = 24,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro44 = new Product
            {
                product_name = "卡通钥匙扣",
                product_id = "205405",
                price = 8.7M,
                purchase_price = 6.09M,
                production_date = new DateTime(2019, 09, 23),
                shelf_life = 12,
                stock_count = 52,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro45 = new Product
            {
                product_name = "毛巾",
                product_id = "205406",
                price = 12.5M,
                purchase_price = 8.75M,
                production_date = new DateTime(2020, 01, 11),
                shelf_life = 12,
                stock_count = 34,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro46 = new Product
            {
                product_name = "厨房隔热手套",
                product_id = "205407",
                price = 15.5M,
                purchase_price = 10.85M,
                production_date = new DateTime(2020, 02, 17),
                shelf_life = 12,
                stock_count = 29,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro47 = new Product
            {
                product_name = "一次性手套",
                product_id = "205408",
                price = 16.9M,
                purchase_price = 11.83M,
                production_date = new DateTime(2019, 11, 28),
                shelf_life = 12,
                stock_count = 33,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro48 = new Product
            {
                product_name = "垃圾袋",
                product_id = "205409",
                price = 7.9M,
                purchase_price = 5.53M,
                production_date = new DateTime(2019, 10, 24),
                shelf_life = 12,
                stock_count = 56,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro49 = new Product
            {
                product_name = "可撕式粘毛滚",
                product_id = "205410",
                price = 19.4M,
                purchase_price = 13.58M,
                production_date = new DateTime(2020, 03, 11),
                shelf_life = 12,
                stock_count = 37,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro50 = new Product
            {
                product_name = "舒克牙刷",
                product_id = "205411",
                price = 19.9M,
                purchase_price = 13.93M,
                production_date = new DateTime(2020, 01, 16),
                shelf_life = 12,
                stock_count = 46,
                product_category = (int)Product_Category_Enum.NoRiPei,
                product_type = (int)Product_Type_Enum.ZaHuo,
                supplier = "山东总供"
            };
            Product pro51 = new Product
            {
                product_name = "韩式烤肉饭团",
                product_id = "152406",
                price = 4.8M,
                purchase_price = 3.36M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 23,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro52 = new Product
            {
                product_name = "奥尔良烤鸡肉饭团",
                product_id = "152407",
                price = 5.9M,
                purchase_price = 4.13M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 22,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro53 = new Product
            {
                product_name = "烤牛肉辣白菜饭团",
                product_id = "152408",
                price = 3.9M,
                purchase_price = 2.73M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 15,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro54 = new Product
            {
                product_name = "酱香烤牛肉饭团",
                product_id = "152409",
                price = 4.8M,
                purchase_price = 3.36M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 19,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro55 = new Product
            {
                product_name = "金枪鱼辣白菜饭团",
                product_id = "152410",
                price = 6.5M,
                purchase_price = 4.55M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 27,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro56 = new Product
            {
                product_name = "金枪鱼蛋黄酱饭团",
                product_id = "152411",
                price = 7.8M,
                purchase_price = 5.46M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 34,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro57 = new Product
            {
                product_name = "虾仁蛋黄酱饭团",
                product_id = "152412",
                price = 7.5M,
                purchase_price = 5.25M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 27,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro58 = new Product
            {
                product_name = "三文鱼蛋黄酱饭团",
                product_id = "152413",
                price = 5.9M,
                purchase_price = 4.13M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 16,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro59 = new Product
            {
                product_name = "奥尔良鸡肉什锦中卷",
                product_id = "152414",
                price = 5.8M,
                purchase_price = 4.06M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 8,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro60 = new Product
            {
                product_name = "虾仁蛋黄酱中卷",
                product_id = "152415",
                price = 4.9M,
                purchase_price = 3.43M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 27,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.FanTuan,
                supplier = "山东冷配"
            };
            Product pro61 = new Product
            {
                product_name = "可可火山包",
                product_id = "162304",
                price = 8.5M,
                purchase_price = 5.95M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 26,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro62 = new Product
            {
                product_name = "芝士火腿丹麦面包",
                product_id = "162305",
                price = 8.5M,
                purchase_price = 5.95M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 52,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro63 = new Product
            {
                product_name = "葡萄干奶油起酥面包",
                product_id = "162306",
                price = 5M,
                purchase_price = 3.5M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 57,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro64 = new Product
            {
                product_name = "草莓味多纳滋",
                product_id = "162307",
                price = 4.5M,
                purchase_price = 3.15M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 49,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro65 = new Product
            {
                product_name = "巧克力菠萝面包",
                product_id = "162308",
                price = 4.9M,
                purchase_price = 3.43M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 43,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro66 = new Product
            {
                product_name = "奶油多纳滋面包",
                product_id = "162309",
                price = 3.5M,
                purchase_price = 2.45M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 28,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro67 = new Product
            {
                product_name = "奶香红豆面包",
                product_id = "162310",
                price = 7.8M,
                purchase_price = 5.46M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 16,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro68 = new Product
            {
                product_name = "红豆卷面包",
                product_id = "162311",
                price = 5.5M,
                purchase_price = 3.85M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 40,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro69 = new Product
            {
                product_name = "蒸蛋糕（可可味）",
                product_id = "162312",
                price = 5.8M,
                purchase_price = 4.06M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 13,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro70 = new Product
            {
                product_name = "玉米沙拉面包",
                product_id = "162313",
                price = 5M,
                purchase_price = 3.5M,
                production_date = new DateTime(2020, 04, 22),
                shelf_life = 24,
                stock_count = 22,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.MianBao,
                supplier = "山东冷配"
            };
            Product pro71 = new Product
            {
                product_name = "金枪鱼三明治",
                product_id = "101207",
                price = 9.8M,
                purchase_price = 6.86M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 15,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro72 = new Product
            {
                product_name = "火腿三明治",
                product_id = "101208",
                price = 9M,
                purchase_price = 6.3M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 24,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro73 = new Product
            {
                product_name = "鸡蛋培根三明治",
                product_id = "101209",
                price = 10.6M,
                purchase_price = 7.42M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 11,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro74 = new Product
            {
                product_name = "鲔鱼鲜蔬三明治",
                product_id = "101210",
                price = 13.5M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 13,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro75 = new Product
            {
                product_name = "松茸火腿三明治",
                product_id = "101211",
                price = 10.8M,
                purchase_price = 7.56M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 24,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro76 = new Product
            {
                product_name = "芝士火腿三明治",
                product_id = "101212",
                price = 11.2M,
                purchase_price = 7.84M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 22,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro77 = new Product
            {
                product_name = "火腿奶酪三明治",
                product_id = "101213",
                price = 10.6M,
                purchase_price = 7.42M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 16,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro78 = new Product
            {
                product_name = "印度咖喱鱼排三明治",
                product_id = "101214",
                price = 15.6M,
                purchase_price = 10.92M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 28,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro79 = new Product
            {
                product_name = "肉松三明治",
                product_id = "101215",
                price = 11.4M,
                purchase_price = 7.98M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 17,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro80 = new Product
            {
                product_name = "猪排三明治",
                product_id = "101216",
                price = 13.5M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 16,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SanMingZhi,
                supplier = "山东冷配"
            };
            Product pro81 = new Product
            {
                product_name = "五彩寿司卷",
                product_id = "110200",
                price = 15M,
                purchase_price = 10.5M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 22,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro82 = new Product
            {
                product_name = "缤纷寿司组合",
                product_id = "110201",
                price = 18.8M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 25,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro83 = new Product
            {
                product_name = "三文鱼辣螺肉双味双卷寿司",
                product_id = "110202",
                price = 13.5M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 19,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro84 = new Product
            {
                product_name = "稻荷寿司",
                product_id = "110203",
                price = 12.8M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 11,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro85 = new Product
            {
                product_name = "田园什蔬盒装寿司",
                product_id = "110204",
                price = 9.5M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 38,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro86 = new Product
            {
                product_name = "军舰盒装寿司",
                product_id = "110205",
                price = 15.2M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 34,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro87 = new Product
            {
                product_name = "芝士烤和牛炸鸡双味寿司",
                product_id = "101216",
                price = 13.8M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 23,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro88 = new Product
            {
                product_name = "烤三文鱼什蔬双卷寿司",
                product_id = "110207",
                price = 10.8M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 26,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro89 = new Product
            {
                product_name = "金枪鱼沙拉酱中卷寿司",
                product_id = "110208",
                price = 6.7M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 27,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro90 = new Product
            {
                product_name = "虾仁沙拉酱中卷寿司",
                product_id = "110209",
                price = 8.2M,
                purchase_price = 9.45M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 24,
                stock_count = 16,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.ShouSi,
                supplier = "山东冷配"
            };
            Product pro91 = new Product
            {
                product_name = "君乐宝简醇0蔗糖酸奶",
                product_id = "131210",
                price = 3.5M,
                purchase_price = 2.45M,
                production_date = new DateTime(2020, 04, 19),
                shelf_life = 7,
                stock_count = 20,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };
            Product pro92 = new Product
            {
                product_name = "君乐宝老酸奶",
                product_id = "131211",
                price = 5.8M,
                purchase_price = 4.06M,
                production_date = new DateTime(2020, 04, 20),
                shelf_life = 7,
                stock_count = 22,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };
            Product pro93 = new Product
            {
                product_name = "新希望自立袋果实粒酸奶",
                product_id = "131212",
                price = 6.5M,
                purchase_price = 4.55M,
                production_date = new DateTime(2020, 04, 20),
                shelf_life = 7,
                stock_count = 30,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };
            Product pro94 = new Product
            {
                product_name = "新希望若雪酸奶",
                product_id = "131213",
                price = 12.2M,
                purchase_price = 8.54M,
                production_date = new DateTime(2020, 04, 19),
                shelf_life = 7,
                stock_count = 19,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };
            Product pro95 = new Product
            {
                product_name = "光明如实酸奶",
                product_id = "131214",
                price = 6.8M,
                purchase_price = 4.76M,
                production_date = new DateTime(2020, 04, 17),
                shelf_life = 7,
                stock_count = 12,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };
            Product pro96 = new Product
            {
                product_name = "新希望雪兰初心酸奶",
                product_id = "131215",
                price = 7.8M,
                purchase_price = 5.46M,
                production_date = new DateTime(2020, 04, 19),
                shelf_life = 7,
                stock_count = 24,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };
            Product pro97 = new Product
            {
                product_name = "欧亚大理牧场酸奶",
                product_id = "131216",
                price = 8.5M,
                purchase_price = 5.95M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 7,
                stock_count = 43,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };
            Product pro98 = new Product
            {
                product_name = "简爱酸奶百香果味",
                product_id = "131217",
                price = 10.6M,
                purchase_price = 7.42M,
                production_date = new DateTime(2020, 04, 18),
                shelf_life = 7,
                stock_count = 26,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };
            Product pro99 = new Product
            {
                product_name = "得益优麦风味酸奶",
                product_id = "131218",
                price = 13.9M,
                purchase_price = 9.73M,
                production_date = new DateTime(2020, 04, 19),
                shelf_life = 7,
                stock_count = 33,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };
            Product pro100 = new Product
            {
                product_name = "蒙牛纯甄酸奶草莓果粒",
                product_id = "131219",
                price = 7.8M,
                purchase_price = 5.46M,
                production_date = new DateTime(2020, 04, 21),
                shelf_life = 7,
                stock_count = 42,
                product_category = (int)Product_Category_Enum.RiPei,
                product_type = (int)Product_Type_Enum.SuanNai,
                supplier = "山东冷配"
            };

            list.Add(pro1);
            list.Add(pro2);
            list.Add(pro3);
            list.Add(pro4);
            list.Add(pro5);
            list.Add(pro6);
            list.Add(pro7);
            list.Add(pro8);
            list.Add(pro9);
            list.Add(pro10);
            list.Add(pro11);
            list.Add(pro12);
            list.Add(pro13);
            list.Add(pro14);
            list.Add(pro15);
            list.Add(pro16);
            list.Add(pro17);
            list.Add(pro18);
            list.Add(pro19);
            list.Add(pro20);
            list.Add(pro21);
            list.Add(pro22);
            list.Add(pro23);
            list.Add(pro24);
            list.Add(pro25);
            list.Add(pro26);
            list.Add(pro27);
            list.Add(pro28);
            list.Add(pro29);
            list.Add(pro30);
            list.Add(pro31);
            list.Add(pro32);
            list.Add(pro33);
            list.Add(pro34);
            list.Add(pro35);
            list.Add(pro36);
            list.Add(pro37);
            list.Add(pro38);
            list.Add(pro39);
            list.Add(pro40);
            list.Add(pro41);
            list.Add(pro42);
            list.Add(pro43);
            list.Add(pro44);
            list.Add(pro45);
            list.Add(pro46);
            list.Add(pro47);
            list.Add(pro48);
            list.Add(pro49);
            list.Add(pro50);
            list.Add(pro51);
            list.Add(pro52);
            list.Add(pro53);
            list.Add(pro54);
            list.Add(pro55);
            list.Add(pro56);
            list.Add(pro57);
            list.Add(pro58);
            list.Add(pro59);
            list.Add(pro60);
            list.Add(pro61);
            list.Add(pro62);
            list.Add(pro63);
            list.Add(pro64);
            list.Add(pro65);
            list.Add(pro66);
            list.Add(pro67);
            list.Add(pro68);
            list.Add(pro69);
            list.Add(pro70);
            list.Add(pro71);
            list.Add(pro72);
            list.Add(pro73);
            list.Add(pro74);
            list.Add(pro75);
            list.Add(pro76);
            list.Add(pro77);
            list.Add(pro78);
            list.Add(pro79);
            list.Add(pro80);
            list.Add(pro81);
            list.Add(pro82);
            list.Add(pro83);
            list.Add(pro84);
            list.Add(pro85);
            list.Add(pro86);
            list.Add(pro87);
            list.Add(pro88);
            list.Add(pro89);
            list.Add(pro90);
            list.Add(pro91);
            list.Add(pro92);
            list.Add(pro93);
            list.Add(pro94);
            list.Add(pro95);
            list.Add(pro96);
            list.Add(pro97);
            list.Add(pro98);
            list.Add(pro99);
            list.Add(pro100);

            using (ERPDBEntities db = new ERPDBEntities())
            {
                db.BulkInsert(list);
                db.BulkSaveChanges();
            }
        }

        /// <summary>
        /// 初始化员工表.
        /// </summary>
        public static void InitStaff()
        {
            List<Staff> list = new List<Staff>();
            Staff staff1 = new Staff
            {
                position = Staff_Postion_Type_Enum.店长.ToString(),
                name = "张三",
                salary = 0
            };
            Staff staff2 = new Staff
            {
                position = Staff_Postion_Type_Enum.副店.ToString(),
                name = "王五",
                salary = 0
            };
            Staff staff3 = new Staff
            {
                position = Staff_Postion_Type_Enum.班长.ToString(),
                name = "赵六",
                salary = 0
            };
            Staff staff4 = new Staff
            {
                position = Staff_Postion_Type_Enum.店员.ToString(),
                name = "李三",
                salary = 0
            };
            Staff staff5 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "孙里",
                salary = 0
            };
            Staff staff6 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "王建",
                salary = 0
            };
            Staff staff7 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "李四",
                salary = 0
            };
            Staff staff8 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "张琪",
                salary = 0
            };
            Staff staff9 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "张伟",
                salary = 0
            };
            Staff staff10 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "王文",
                salary = 0
            };
            Staff staff11 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "李政",
                salary = 0
            };
            Staff staff12 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "杨柳",
                salary = 0
            };
            Staff staff13 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "韩先",
                salary = 0
            };
            Staff staff14 = new Staff
            {
                position = Staff_Postion_Type_Enum.PT.ToString(),
                name = "郑茜",
                salary = 0
            };

            list.Add(staff1);
            list.Add(staff2);
            list.Add(staff3);
            list.Add(staff4);
            list.Add(staff5);
            list.Add(staff6);
            list.Add(staff7);
            list.Add(staff8);
            list.Add(staff9);
            list.Add(staff10);
            list.Add(staff11);
            list.Add(staff12);
            list.Add(staff13);
            list.Add(staff14);

            using (ERPDBEntities db = new ERPDBEntities())
            {
                db.BulkInsert(list);
                db.BulkSaveChanges();
            }
        }

        /// <summary>
        /// 初始化工作计划.
        /// </summary>
        public static void InitSchedule()
        {
            List<schedule> list = new List<schedule>
            {
                new schedule
                {
                    week = "周一",
                    on_work = "7",
                    off_work = "15",
                    create_time = DateTime.Now,
                    update_time = DateTime.Now
                },
                new schedule
                {
                week = "周一",
                on_work = "14",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },new schedule
                {
                week = "周一",
                on_work = "22",
                off_work = "8",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周一",
                on_work = "22",
                off_work = "8",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周一",
                on_work = "10",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周一",
                on_work = "10",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周一",
                on_work = "6.5",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周一",
                on_work = "6.5",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周一",
                on_work = "7",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周一",
                on_work = "16",
                off_work = "22.5",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                    week = "周二",
                    on_work = "7",
                    off_work = "15",
                    create_time = DateTime.Now,
                    update_time = DateTime.Now
                },
                new schedule
                {
                week = "周二",
                on_work = "10",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周二",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周二",
                on_work = "22",
                off_work = "7",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周二",
                on_work = "14",
                off_work = "22.5",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周二",
                on_work = "14",
                off_work = "22.5",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周二",
                on_work = "10",
                off_work = "16",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周二",
                on_work = "16",
                off_work = "22.5",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周三",
                on_work = "7",
                off_work = "15",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周三",
                on_work = "14",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周三",
                on_work = "22",
                off_work = "7",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周三",
                on_work = "22",
                off_work = "7",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周三",
                on_work = "10",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周三",
                on_work = "10",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周三",
                on_work = "6.5",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周三",
                on_work = "6.5",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                 new schedule
                {
                week = "周四",
                on_work = "7",
                off_work = "15",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
             new schedule
                {
                week = "周四",
                on_work = "14",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
             new schedule
                {
                week = "周四",
                on_work = "22",
                off_work = "8",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
             new schedule
                {
                week = "周四",
                on_work = "10",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
             new schedule
                {
                week = "周四",
                on_work = "10",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
             new schedule
                {
                week = "周四",
                on_work = "10",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
             new schedule
                {
                week = "周四",
                on_work = "6.5",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
             new schedule
                {
                week = "周四",
                on_work = "16",
                off_work = "22.5",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
             new schedule
                {
                week = "周四",
                on_work = "6.5",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
             new schedule
                {
                week = "周四",
                on_work = "16",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                          new schedule
                {
                week = "周五",
                on_work = "7",
                off_work = "15",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "14",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "14",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "10",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "10",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "10",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "10",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "16",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "6.5",
                off_work = "13",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                 new schedule
                {
                week = "周五",
                on_work = "16",
                off_work = "22.5",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周六",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周六",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周六",
                on_work = "7",
                off_work = "15",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周六",
                on_work = "14",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周六",
                on_work = "7",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周六",
                on_work = "7",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周日",
                on_work = "14",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周日",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周日",
                on_work = "22",
                off_work = "7",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周日",
                on_work = "14",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周日",
                on_work = "7",
                off_work = "14",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周日",
                on_work = "16",
                off_work = "22",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周日",
                on_work = "14",
                off_work = "22.5",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周一",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周二",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周三",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周四",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周五",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周六",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                },
                new schedule
                {
                week = "周日",
                on_work = "休",
                off_work = "休",
                create_time = DateTime.Now,
                update_time = DateTime.Now
                }
            };

            var dist_list = list.Distinct(new ScheduleComparer());
            using (ERPDBEntities db = new ERPDBEntities())
            {
                db.BulkInsert(dist_list);
                db.BulkSaveChanges();
            }
        }

        /// <summary>
        /// 初始化工作排版表.
        /// </summary>
        public static void InitWorkTime()
        {
            try
            {
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    List<WorkTime> list = new List<WorkTime>();
                    List<Staff> staffs = db.Staff.ToList();
                    schedule monday_work = new schedule(),
                                    tuesday_work = new schedule(),
                                    wednesday_work = new schedule(),
                                    thursday_work = new schedule(),
                                    friday_work = new schedule(),
                                    saturday_work = new schedule(),
                                    sunday_work = new schedule();
                    foreach (var staff in staffs)
                    {
                        switch (staff.name)
                        {
                            case "张三":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "7" && a.off_work == "15");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "7" && a.off_work == "15");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "7" && a.off_work == "15");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "7" && a.off_work == "15");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "7" && a.off_work == "15");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "14" && a.off_work == "22");
                                break;
                            case "王五":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "14" && a.off_work == "22");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "10" && a.off_work == "22");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "14" && a.off_work == "22");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "14" && a.off_work == "22");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "14" && a.off_work == "22");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "休" && a.off_work == "休");
                                break;
                            case "赵六":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "22" && a.off_work == "8");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "休" && a.off_work == "休");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "22" && a.off_work == "7");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "22" && a.off_work == "8");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "休" && a.off_work == "休");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "7" && a.off_work == "15");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "22" && a.off_work == "7");
                                break;
                            case "李三":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "22" && a.off_work == "8");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "22" && a.off_work == "7");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "22" && a.off_work == "7");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "休" && a.off_work == "休");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "14" && a.off_work == "22");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "14" && a.off_work == "22");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "休" && a.off_work == "休");
                                break;
                            case "孙里":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "10" && a.off_work == "13");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "14" && a.off_work == "22.5");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "10" && a.off_work == "14");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "10" && a.off_work == "13");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "10" && a.off_work == "14");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "休" && a.off_work == "休");
                                break;
                            case "王建":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "10" && a.off_work == "13");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "14" && a.off_work == "22.5");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "10" && a.off_work == "14");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "10" && a.off_work == "13");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "10" && a.off_work == "14");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "休" && a.off_work == "休");
                                break;
                            case "李四":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "6.5" && a.off_work == "13");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "休" && a.off_work == "休");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "6.5" && a.off_work == "14");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "休" && a.off_work == "休");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "10" && a.off_work == "14");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "14" && a.off_work == "22");
                                break;
                            case "张琪":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "6.5" && a.off_work == "13");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "休" && a.off_work == "休");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "6.5" && a.off_work == "14");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "10" && a.off_work == "13");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "10" && a.off_work == "14");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "7" && a.off_work == "14");
                                break;
                            case "张伟":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "7" && a.off_work == "13");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "10" && a.off_work == "16");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "休" && a.off_work == "休");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "6.5" && a.off_work == "13");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "休" && a.off_work == "休");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "16" && a.off_work == "22");
                                break;
                            case "王文":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "休" && a.off_work == "休");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "休" && a.off_work == "休");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "休" && a.off_work == "休");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "休" && a.off_work == "休");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "16" && a.off_work == "22");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "7" && a.off_work == "14");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "休" && a.off_work == "休");
                                break;
                            case "李政":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "休" && a.off_work == "休");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "16" && a.off_work == "22.5");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "休" && a.off_work == "休");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "16" && a.off_work == "22.5");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "休" && a.off_work == "休");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "休" && a.off_work == "休");
                                break;
                            case "杨柳":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "休" && a.off_work == "休");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "休" && a.off_work == "休");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "休" && a.off_work == "休");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "6.5" && a.off_work == "13");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "6.5" && a.off_work == "13");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "休" && a.off_work == "休");
                                break;
                            case "韩先":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "休" && a.off_work == "休");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "休" && a.off_work == "休");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "休" && a.off_work == "休");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "16" && a.off_work == "22");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "16" && a.off_work == "22.5");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "7" && a.off_work == "14");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "休" && a.off_work == "休");
                                break;
                            case "郑茜":
                                monday_work = db.schedule.FirstOrDefault(a => a.week == "周一" && a.on_work == "16" && a.off_work == "22.5");
                                tuesday_work = db.schedule.FirstOrDefault(a => a.week == "周二" && a.on_work == "休" && a.off_work == "休");
                                wednesday_work = db.schedule.FirstOrDefault(a => a.week == "周三" && a.on_work == "休" && a.off_work == "休");
                                thursday_work = db.schedule.FirstOrDefault(a => a.week == "周四" && a.on_work == "休" && a.off_work == "休");
                                friday_work = db.schedule.FirstOrDefault(a => a.week == "周五" && a.on_work == "休" && a.off_work == "休");
                                saturday_work = db.schedule.FirstOrDefault(a => a.week == "周六" && a.on_work == "休" && a.off_work == "休");
                                sunday_work = db.schedule.FirstOrDefault(a => a.week == "周日" && a.on_work == "14" && a.off_work == "22.5");
                                break;
                        }

                        WorkTime w1 = new WorkTime
                        {
                            staff_id = staff.id,
                            schedule_id = monday_work.id,
                            staff_name = staff.name,
                            week = monday_work.week,
                            on_work = monday_work.on_work,
                            off_work = monday_work.off_work,
                            create_time = DateTime.Now,
                            update_time = DateTime.Now
                        };
                        WorkTime w2 = new WorkTime
                        {
                            staff_id = staff.id,
                            schedule_id = tuesday_work.id,
                            staff_name = staff.name,
                            week = tuesday_work.week,
                            on_work = tuesday_work.on_work,
                            off_work = tuesday_work.off_work,
                            create_time = DateTime.Now,
                            update_time = DateTime.Now
                        };
                        WorkTime w3 = new WorkTime
                        {
                            staff_id = staff.id,
                            schedule_id = wednesday_work.id,
                            staff_name = staff.name,
                            week = wednesday_work.week,
                            on_work = wednesday_work.on_work,
                            off_work = wednesday_work.off_work,
                            create_time = DateTime.Now,
                            update_time = DateTime.Now
                        };
                        WorkTime w4 = new WorkTime
                        {
                            staff_id = staff.id,
                            schedule_id = thursday_work.id,
                            staff_name = staff.name,
                            week = thursday_work.week,
                            on_work = thursday_work.on_work,
                            off_work = thursday_work.off_work,
                            create_time = DateTime.Now,
                            update_time = DateTime.Now
                        };
                        WorkTime w5 = new WorkTime
                        {
                            staff_id = staff.id,
                            schedule_id = friday_work.id,
                            staff_name = staff.name,
                            week = friday_work.week,
                            on_work = friday_work.on_work,
                            off_work = friday_work.off_work,
                            create_time = DateTime.Now,
                            update_time = DateTime.Now
                        };
                        WorkTime w6 = new WorkTime
                        {
                            staff_id = staff.id,
                            schedule_id = saturday_work.id,
                            staff_name = staff.name,
                            week = saturday_work.week,
                            on_work = saturday_work.on_work,
                            off_work = saturday_work.off_work,
                            create_time = DateTime.Now,
                            update_time = DateTime.Now
                        };
                        WorkTime w7 = new WorkTime
                        {
                            staff_id = staff.id,
                            schedule_id = sunday_work.id,
                            staff_name = staff.name,
                            week = sunday_work.week,
                            on_work = sunday_work.on_work,
                            off_work = sunday_work.off_work,
                            create_time = DateTime.Now,
                            update_time = DateTime.Now
                        };

                        list.Add(w1);
                        list.Add(w2);
                        list.Add(w3);
                        list.Add(w4);
                        list.Add(w5);
                        list.Add(w6);
                        list.Add(w7);
                    }

                    db.BulkInsert(list);
                    db.BulkSaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 初始化销售表.
        /// </summary>
        public static void InitSellRecord()
        {
            try
            {
                List<Sell_Record> list = new List<Sell_Record>();
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    Random rd = new Random();
                    var products = db.Product.GroupBy(a => a.product_type).ToList();
                    foreach (var item in products)
                    {
                        List<Product> product = item.ToList();
                        foreach (var pro in product)
                        {
                            for (int i = 1; i < 7; i++)
                            {
                                Sell_Record re = new Sell_Record();
                                re.product_id = pro.product_id;
                                re.product_name = pro.product_name;
                                re.delivery_count = rd.Next(100, 500);
                                re.sell_count = rd.Next(re.delivery_count / 2);
                                re.trash_count = rd.Next(re.sell_count / 2);
                                re.create_time = DateTime.Now.AddDays(i);
                                re.update_time = DateTime.Now.AddDays(i);
                                list.Add(re);
                            }
                        }
                    }

                    db.BulkInsert(list);
                    db.BulkSaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 初始化员工权限表.
        /// </summary>
        public static void InitStaffAuth()
        {
            try
            {
                List<Staff_Auth> list = new List<Staff_Auth>();
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var staffs = db.Staff.AsQueryable();
                    Staff admin = staffs.FirstOrDefault(a => a.position == Staff_Postion_Type_Enum.店长.ToString());
                    List<Staff> manage_staff = staffs.Where(a => a.position != Staff_Postion_Type_Enum.PT.ToString() && a.position != Staff_Postion_Type_Enum.店长.ToString()).ToList();

                    string sell_product_type = "";
                    foreach (int pro in Enum.GetValues(typeof(Product_Type_Enum)))
                    {
                        sell_product_type += pro.ToString() + ",";
                    }

                    //店长
                    Staff_Auth admin_auth = new Staff_Auth();
                    admin_auth.staff_id = admin.id;
                    admin_auth.leader_id = 0;
                    admin_auth.sell_product_type = sell_product_type.Substring(0, sell_product_type.Length - 1);
                    admin_auth.create_time = DateTime.Now;
                    admin_auth.update_time = DateTime.Now;
                    list.Add(admin_auth);

                    List<int> product_types = admin_auth.sell_product_type.Split(',').Select(a => int.Parse(a)).ToList();
                    foreach (var item in manage_staff)
                    {
                        Staff_Auth auth = new Staff_Auth();
                        auth.staff_id = item.id;
                        auth.leader_id = admin.id;
                        if (item.position == Staff_Postion_Type_Enum.副店.ToString())
                        {
                            auth.sell_product_type = string.Join(",", product_types.Where(a => a <= 5).ToList());
                        }
                        else if (item.position == Staff_Postion_Type_Enum.班长.ToString())
                        {
                            auth.sell_product_type = string.Join(",", product_types.Where(a => a > 5 && a <= 8).ToList());
                        }
                        else
                        {
                            auth.sell_product_type = string.Join(",", product_types.Where(a => a > 8 && a <= 10).ToList());
                        }
                        auth.create_time = DateTime.Now;
                        auth.update_time = DateTime.Now;
                        list.Add(auth);
                    }

                    List<Staff> pt_staff = staffs.Where(a => a.position == Staff_Postion_Type_Enum.PT.ToString()).ToList();
                    List<Staff_Auth> temp = list.Where(a => a.leader_id != 0).ToList();

                    int pt_index = 0;
                    for (int i = 0; i < temp.Count && pt_index < pt_staff.Count; i++)
                    {
                        string[] sell_pro_type_id = temp[i].sell_product_type.Split(',');
                        for (int j = 0; j < sell_pro_type_id.Length; j++)
                        {
                            Staff_Auth auth = new Staff_Auth();
                            auth.staff_id = pt_staff[pt_index].id;
                            auth.leader_id = temp[i].staff_id;
                            auth.sell_product_type = sell_pro_type_id[j];
                            auth.create_time = DateTime.Now;
                            auth.update_time = DateTime.Now;
                            pt_index++;
                            list.Add(auth);
                        }
                    }

                    db.BulkInsert(list);
                    db.BulkSaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 初始化盘点表.
        /// </summary>
        public static void InitInventory()
        {
            try
            {
                List<Inventory> list = new List<Inventory>();
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var sell_record = db.Sell_Record.ToList();
                    Random rd = new Random();

                    for (int i = 0; i < 20; i++)
                    {
                        int index = rd.Next(sell_record.Count - 1);
                        Inventory inv = new Inventory();
                        inv.product_id = sell_record[index].id;
                        inv.stock_count = sell_record[index].delivery_count - sell_record[index].sell_count;
                        inv.in_stock_count = sell_record[index].delivery_count - sell_record[index].sell_count - sell_record[index].trash_count;
                        inv.create_time = DateTime.Now;
                        inv.update_time = DateTime.Now;
                        list.Add(inv);
                    }

                    db.BulkInsert(list);
                    db.BulkSaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void InitProductExpendRateConfig()
        {
            try
            {
                List<Product_Expend_Rate_Config> list = new List<Product_Expend_Rate_Config>();
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var product = db.Product.ToList();
                    foreach (var item in product)
                    {
                        Product_Expend_Rate_Config model = new Product_Expend_Rate_Config();
                        model.product_id = item.product_id;
                        model.product_name = item.product_name;
                        model.product_type = item.product_type;
                        model.product_category = item.product_category;
                        model.high_expend_rate = item.product_category == (int)Product_Category_Enum.RiPei ? SystemCommon.Ri_Pei_High_Expend_Rate : SystemCommon.No_Ri_Pei_High_Expend_Rate;
                        model.low_expend_rate = item.product_category == (int)Product_Category_Enum.RiPei ? SystemCommon.Ri_Pei_Low_Expend_Rate : SystemCommon.No_Ri_Pei_Low_Expend_Rate;
                        model.create_time = DateTime.Now;
                        model.update_time = DateTime.Now;
                        list.Add(model);
                    }

                    db.BulkInsert(list);
                    db.BulkSaveChanges();
                }
            }
            catch(Exception ex)
            {

            }
        }

        /// <summary>
        /// Defines the <see cref="ScheduleComparer" />.
        /// </summary>
        internal class ScheduleComparer : IEqualityComparer<schedule>
        {
            /// <summary>
            /// The Equals.
            /// </summary>
            /// <param name="x">The x<see cref="schedule"/>.</param>
            /// <param name="y">The y<see cref="schedule"/>.</param>
            /// <returns>The <see cref="bool"/>.</returns>
            public bool Equals(schedule x, schedule y)
            {
                return x.week == y.week && x.on_work == y.on_work && y.off_work == x.on_work;
            }

            /// <summary>
            /// The GetHashCode.
            /// </summary>
            /// <param name="obj">The obj<see cref="schedule"/>.</param>
            /// <returns>The <see cref="int"/>.</returns>
            public int GetHashCode(schedule obj)
            {
                return obj.week.GetHashCode() ^ obj.on_work.GetHashCode() ^ obj.off_work.GetHashCode();
            }
        }
    }
}
