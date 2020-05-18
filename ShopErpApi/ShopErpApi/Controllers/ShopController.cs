namespace ShopErpApi.Controllers
{
    using ShopErpApi.Commons;
    using ShopErpApi.Models.DBModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using static ShopErpApi.Commons.SystemCommon;

    /// <summary>
    /// Defines the <see cref="ShopController" />.
    /// </summary>
    [Route("api/[controller]")]
    public class ShopController : ApiController
    {
        /// <summary>
        /// Defines the <see cref="ExpendModel" />.
        /// </summary>
        public class ExpendModel
        {
            /// <summary>
            /// 消耗率过高的商品.....
            /// </summary>
            public List<ProductExpendModel> High_Rate = new List<ProductExpendModel>();

            /// <summary>
            /// 消耗率过低的商品.....
            /// </summary>
            public List<ProductExpendModel> Low_Rate = new List<ProductExpendModel>();
        }

        /// <summary>
        /// 商品消耗率.
        /// </summary>
        public class ProductExpendModel
        {
            /// <summary>
            /// Gets or sets the product_name.
            /// </summary>
            public string product_name { get; set; }

            /// <summary>
            /// Gets or sets the product_id.
            /// </summary>
            public string product_id { get; set; }

            /// <summary>
            /// Gets or sets the expend_rate.
            /// </summary>
            public string expend_rate { get; set; }

            /// <summary>
            /// Gets or sets the average_expend_rate
            /// 消耗率平均值..
            /// </summary>
            public double average_expend_rate { get; set; }
        }

        /// <summary>
        /// Defines the <see cref="ProductSellModel" />.
        /// </summary>
        public class ProductSellModel
        {
            /// <summary>
            /// Gets or sets the product_id.
            /// </summary>
            public string product_id { get; set; }

            /// <summary>
            /// Gets or sets the product_name.
            /// </summary>
            public string product_name { get; set; }

            /// <summary>
            /// Gets or sets the delivery_count.
            /// </summary>
            public int delivery_count { get; set; }

            /// <summary>
            /// Gets or sets the sell_count.
            /// </summary>
            public int sell_count { get; set; }

            /// <summary>
            /// Gets or sets the product_price.
            /// </summary>
            public decimal product_price { get; set; }

            /// <summary>
            /// Gets or sets the sell_amount.
            /// </summary>
            public decimal sell_amount { get; set; }
        }

        /// <summary>
        /// Defines the <see cref="UserTradeDataModel" />.
        /// </summary>
        public class UserTradeDataModel
        {
            /// <summary>
            /// Defines the sell_info.
            /// </summary>
            public List<ProductSellModel> sell_info = new List<ProductSellModel>();

            /// <summary>
            /// Gets or sets the product_type.
            /// </summary>
            public string product_type { get; set; }

            /// <summary>
            /// Gets or sets the total_sell_count.
            /// </summary>
            public int total_sell_count { get; set; }

            /// <summary>
            /// Gets or sets the total_delivery_count.
            /// </summary>
            public int total_delivery_count { get; set; }

            /// <summary>
            /// Gets or sets the total_sell_amount.
            /// </summary>
            public decimal total_sell_amount { get; set; }
        }

        /// <summary>
        /// 商品消耗率标准差.
        /// </summary>
        public class ProductExpendRateStandardDeviationModel
        {
            /// <summary>
            /// Gets or sets the product_id.
            /// </summary>
            public string product_id { get; set; }

            /// <summary>
            /// Gets or sets the product_name.
            /// </summary>
            public string product_name { get; set; }

            /// <summary>
            /// Gets or sets the expend_rate_sd
            /// 消化率标准差.....
            /// </summary>
            public double expend_rate_sd { get; set; }
        }

        /// <summary>
        /// 1. 获取营业数据.
        /// </summary>
        /// <param name="user_id">The user_id<see cref="int"/>.</param>
        /// <returns>.</returns>
        [Route("api/product/staff_trade_info")]
        public IHttpActionResult GetUserTradeData(int user_id)
        {
            try
            {
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    Staff staff_auth = db.Staff.FirstOrDefault(a => a.id == user_id);
                    if (staff_auth == null)
                    {
                        return Json(new { result = "员工不存在" });
                    }

                    DateTime start_time = DateTime.Now.Date;
                    DateTime end_time = start_time.AddDays(1);
                    List<int> product_type = staff_auth.sell_product_type.Split(',').Select(a => int.Parse(a)).ToList();

                    var query = (from a in db.Sell_Record
                                 join b in db.Product on a.product_id equals b.product_id
                                 where a.create_time >= start_time && a.create_time < end_time && product_type.Contains(b.product_type)
                                 select new
                                 {
                                     a.product_id,
                                     a.product_name,
                                     a.sell_count,
                                     a.delivery_count,
                                     a.trash_count,
                                     b.product_type,
                                     b.stock_count,
                                     b.price
                                 }).ToList();

                    List<UserTradeDataModel> list = new List<UserTradeDataModel>();
                    var group_data = query.GroupBy(a => a.product_type);
                    foreach (var item in group_data)
                    {
                        UserTradeDataModel model = new UserTradeDataModel();
                        model.product_type = SystemCommon.GetDescription((Product_Type_Enum)Enum.ToObject(typeof(Product_Type_Enum), item.Key));
                        foreach (var pro in item)
                        {
                            ProductSellModel sell_model = new ProductSellModel();
                            sell_model.product_id = pro.product_id;
                            sell_model.product_name = pro.product_name;
                            sell_model.delivery_count = pro.delivery_count;     //交货
                            sell_model.sell_count = pro.sell_count;
                            sell_model.product_price = pro.price;
                            sell_model.sell_amount = pro.sell_count * pro.price;
                            model.sell_info.Add(sell_model);
                        }

                        model.total_sell_amount = model.sell_info.Sum(a => a.sell_amount);
                        model.total_sell_count = model.sell_info.Sum(a => a.sell_count);
                        model.total_delivery_count = model.sell_info.Sum(a => a.delivery_count);
                        list.Add(model);
                    }

                    return Json(new { result = list });
                }

            }
            catch (Exception ex)
            {

            }
            return NotFound();
        }

        /// <summary>
        /// 2. 获取所有商品的消化率.
        /// </summary>
        /// <param name="date">The date<see cref="DateTime?"/>.</param>
        /// <returns>.</returns>
        [Route("api/product/all_product_expend_rate")]
        public IHttpActionResult GetAllProductExpendRate(DateTime? date)
        {
            DateTime time = date.HasValue ? date.Value : new DateTime(2020, 5, 20);
            var data = GetProductExpendRate(time);
            return Json(new { result = data });
        }

        /// <summary>
        /// 4. 获取日配消化率过高和过低产品.
        /// </summary>
        /// <param name="date">The date<see cref="DateTime?"/>.</param>
        /// <returns>.</returns>
        [Route("api/product/get_ripei")]
        public IHttpActionResult GetRiPeiExpendRate(DateTime? date)
        {
            DateTime time = date.HasValue ? date.Value : new DateTime(2020, 5, 20);
            var data = GetProductExpendRate((int)Product_Category_Enum.RiPei, time);
            return Json(new { result = data });
        }

        /// <summary>
        /// 4. 获取非日配消化率过高和过低产品.
        /// </summary>
        /// <param name="date">The date<see cref="DateTime?"/>.</param>
        /// <returns>.</returns>
        [Route("api/product/get_nonripei")]
        public IHttpActionResult GetNonRiPeiExpendRate(DateTime? date)
        {
            DateTime time = date.HasValue ? date.Value : new DateTime(2020, 5, 20);
            var data = GetProductExpendRate((int)Product_Category_Enum.NoRiPei, time);
            return Json(new { result = data });
        }

        /// <summary>
        /// 5. 获取消化率稳定产品.
        /// </summary>
        /// <returns>.</returns>
        [Route("api/product/get_stable_expend_rate")]
        public IHttpActionResult GetExpendRateStable()
        {
            var data = GetStableExpendRate();
            return Json(new { result = data });
        }

        /// <summary>
        /// 6. 获取消化率过低商品.
        /// </summary>
        /// <returns>.</returns>
        [Route("api/product/get_low_expend_rate_product")]
        public IHttpActionResult GetLowExpendRateProduct()
        {
            try
            {
                List<ProductExpendRateStandardDeviationModel> list = new List<ProductExpendRateStandardDeviationModel>();
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var query = (from a in db.Product join b in db.Sell_Record on a.product_id equals b.product_id select new { a.product_id, a.product_name, a.stock_count, b.sell_count, a.product_category }).ToList();
                    if (query.Any())
                    {
                        var ri_pei = query.Where(a => a.product_category == (int)Product_Category_Enum.RiPei).GroupBy(a => new { a.product_id, a.product_name });
                        var no_ri_pei = query.Where(a => a.product_category == (int)Product_Category_Enum.NoRiPei).GroupBy(a => new { a.product_id, a.product_name });

                        if (ri_pei.Any())
                        {
                            foreach (var item in ri_pei)
                            {
                                List<double> expend_rate = new List<double>();
                                foreach (var info in item)
                                {
                                    double rate = ((double)info.sell_count / (double)info.stock_count) * 100;
                                    expend_rate.Add(rate);
                                }

                                double expent_rate_sd = SystemCommon.GetStdDev(expend_rate, false);
                                if (expent_rate_sd < 50) //日配商品消化率低于50%
                                {
                                    ProductExpendRateStandardDeviationModel model = new ProductExpendRateStandardDeviationModel();
                                    model.product_id = item.Key.product_id;
                                    model.product_name = item.Key.product_name;
                                    model.expend_rate_sd = SystemCommon.GetStdDev(expend_rate, false);
                                    list.Add(model);
                                }
                            }
                        }

                        if (no_ri_pei.Any())
                        {
                            foreach (var item in ri_pei)
                            {
                                List<double> expend_rate = new List<double>();
                                foreach (var info in item)
                                {
                                    double rate = ((double)info.sell_count / (double)info.stock_count) * 100;
                                    expend_rate.Add(rate);
                                }

                                double expent_rate_sd = SystemCommon.GetStdDev(expend_rate, false);
                                if (expent_rate_sd < 10) //非日配商品消化率低于10%
                                {
                                    ProductExpendRateStandardDeviationModel model = new ProductExpendRateStandardDeviationModel();
                                    model.product_id = item.Key.product_id;
                                    model.product_name = item.Key.product_name;
                                    model.expend_rate_sd = SystemCommon.GetStdDev(expend_rate, false);
                                    list.Add(model);
                                }
                            }
                        }
                    }

                    return Json(new { result = list });
                }
            }
            catch (Exception ex)
            {

            }

            return Json(new { result = "系统异常" });
        }

        /// <summary>
        /// 7. 修改商品消化率.
        /// </summary>
        /// <param name="product_id">The product_id<see cref="string"/>.</param>
        /// <param name="rate">The rate<see cref="double"/>.</param>
        /// <returns>.</returns>
        [Route("api/product/change_product_expend_rate")]
        public IHttpActionResult ChangeProductExpendRate(string product_id, double rate)
        {
            try
            {
                if (string.IsNullOrEmpty(product_id))
                    return Json(new { result = "参数错误" });

                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var expend_rate = db.Product_Expend_Rate_Config.FirstOrDefault(a => a.product_id == product_id);
                    if (expend_rate == null)
                    {
                        var product_info = db.Product.FirstOrDefault(a => a.product_id == product_id);
                        if (product_info == null)
                            return Json(new { result = "商品信息异常" });

                        expend_rate = new Product_Expend_Rate_Config();
                        expend_rate.product_id = product_info.product_id;
                        expend_rate.product_name = product_info.product_name;
                        expend_rate.product_type = product_info.product_type;
                        expend_rate.product_category = product_info.product_category;
                        expend_rate.high_expend_rate = product_info.product_category == (int)Product_Category_Enum.RiPei ? SystemCommon.Ri_Pei_High_Expend_Rate : SystemCommon.No_Ri_Pei_High_Expend_Rate;

                        if (rate > 0)
                        {
                            expend_rate.low_expend_rate = rate;
                        }
                        else
                        {
                            expend_rate.low_expend_rate = product_info.product_category == (int)Product_Category_Enum.RiPei ? SystemCommon.Ri_Pei_Low_Expend_Rate : SystemCommon.No_Ri_Pei_Low_Expend_Rate;
                        }

                        expend_rate.create_time = DateTime.Now;
                        expend_rate.update_time = DateTime.Now;
                        db.Entry(expend_rate).State = System.Data.Entity.EntityState.Added;
                        if (db.SaveChanges() < 0)
                            return Json(new { result = "设置失败" });

                        return Json(new { result = "设置成功" });
                    }

                    expend_rate.low_expend_rate = rate;
                    expend_rate.update_time = DateTime.Now;
                    db.Entry(expend_rate).State = System.Data.Entity.EntityState.Modified;
                    if (db.SaveChanges() < 0)
                        return Json(new { result = "设置失败" });

                    return Json(new { result = "设置成功" });
                }
            }
            catch (Exception ex)
            {

            }

            return Json(new { result = "系统异常" });
        }

        /// <summary>
        /// The GetProductExpendRate.
        /// </summary>
        /// <param name="time">The time<see cref="DateTime?"/>.</param>
        /// <returns>The <see cref="List{ProductExpendModel}"/>.</returns>
        private static List<ProductExpendModel> GetProductExpendRate(DateTime? time = null)
        {
            List<ProductExpendModel> list = new List<ProductExpendModel>();
            try
            {
                DateTime start_time = time.HasValue ? time.Value.Date : DateTime.Now.Date;
                DateTime end_time = start_time.AddDays(1);

                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var query = (from a in db.Product
                                 join b in db.Sell_Record on a.product_id equals b.product_id
                                 where b.create_time >= start_time && b.create_time < end_time
                                 select new { a.product_id, a.product_name, a.stock_count, b.sell_count, b.create_time }).AsQueryable();

                    if (query.Any())
                    {
                        var product = query.GroupBy(a => new { a.product_id, a.product_name });
                        foreach (var item in product)
                        {
                            List<double> expend_rate = new List<double>();
                            foreach (var info in item)
                            {
                                double rate = ((double)info.sell_count / (double)info.stock_count) * 100;
                                expend_rate.Add(rate);
                            }

                            double average_expend_rate = expend_rate.Average();
                            ProductExpendModel pro = new ProductExpendModel();
                            pro.product_id = item.Key.product_id;
                            pro.product_name = item.Key.product_name;
                            pro.average_expend_rate = average_expend_rate;
                            pro.expend_rate = average_expend_rate.ToString("f2") + "%";
                            list.Add(pro);
                        }
                    }

                    return list.OrderBy(a => a.average_expend_rate).ToList();
                }
            }
            catch (Exception ex)
            {
            }
            return null; ;
        }

        /// <summary>
        /// 获取商品消耗率过高和过低的5个产品.
        /// </summary>
        /// <param name="category">.</param>
        /// <param name="time">.</param>
        /// <returns>.</returns>
        private static ExpendModel GetProductExpendRate(int category, DateTime? time = null)
        {
            ExpendModel model = new ExpendModel();
            try
            {
                DateTime start_time = time.HasValue ? time.Value.Date : DateTime.Now.Date;
                DateTime end_time = start_time.AddDays(1);

                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var query = (from a in db.Product
                                 join b in db.Sell_Record on a.product_id equals b.product_id
                                 where a.product_category == category && b.create_time >= start_time && b.create_time < end_time
                                 select new { a.product_id, a.product_name, a.stock_count, b.sell_count, b.create_time }).AsQueryable();

                    if (query.Any())
                    {
                        var product = query.GroupBy(a => new { a.product_id, a.product_name });
                        foreach (var item in product)
                        {
                            List<double> expend_rate = new List<double>();
                            foreach (var info in item)
                            {
                                double rate = ((double)info.sell_count / (double)info.stock_count) * 100;
                                expend_rate.Add(rate);
                            }

                            double average_expend_rate = expend_rate.Average();
                            if (category == (int)Product_Category_Enum.RiPei)
                            {
                                //日配商品消化率过高，消化率90%，上下两个点
                                if (average_expend_rate >= SystemCommon.GetExpendRate(item.Key.product_id, (int)Product_Category_Enum.RiPei, (int)Enum_Product_Expend_Rate_Type.High_Expend_Rate))
                                {
                                    ProductExpendModel high_model = new ProductExpendModel();
                                    high_model.product_id = item.Key.product_id;
                                    high_model.product_name = item.Key.product_name;
                                    high_model.average_expend_rate = average_expend_rate;
                                    high_model.expend_rate = average_expend_rate.ToString("f2") + "%";
                                    model.High_Rate.Add(high_model);
                                }

                                //日配商品消化率过低，消化率50%
                                if (average_expend_rate < SystemCommon.GetExpendRate(item.Key.product_id, (int)Product_Category_Enum.RiPei, (int)Enum_Product_Expend_Rate_Type.Low_Expend_Rate))
                                {
                                    ProductExpendModel high_model = new ProductExpendModel();
                                    high_model.product_id = item.Key.product_id;
                                    high_model.product_name = item.Key.product_name;
                                    high_model.average_expend_rate = average_expend_rate;
                                    high_model.expend_rate = average_expend_rate.ToString("f2") + "%";
                                    model.Low_Rate.Add(high_model);
                                }
                            }
                            else if (category == (int)Product_Category_Enum.NoRiPei)
                            {
                                //非日配商品消化率过高，消化率30%，上下五个点
                                if (average_expend_rate >= SystemCommon.GetExpendRate(item.Key.product_id, (int)Product_Category_Enum.NoRiPei, (int)Enum_Product_Expend_Rate_Type.High_Expend_Rate))
                                {
                                    ProductExpendModel high_model = new ProductExpendModel();
                                    high_model.product_id = item.Key.product_id;
                                    high_model.product_name = item.Key.product_name;
                                    high_model.average_expend_rate = average_expend_rate;
                                    high_model.expend_rate = average_expend_rate.ToString("f2") + "%";
                                    model.High_Rate.Add(high_model);
                                }

                                //非日配商品消化率过低，消化率10%
                                if (average_expend_rate < SystemCommon.GetExpendRate(item.Key.product_id, (int)Product_Category_Enum.NoRiPei, (int)Enum_Product_Expend_Rate_Type.Low_Expend_Rate))
                                {
                                    ProductExpendModel high_model = new ProductExpendModel();
                                    high_model.product_id = item.Key.product_id;
                                    high_model.product_name = item.Key.product_name;
                                    high_model.average_expend_rate = average_expend_rate;
                                    high_model.expend_rate = average_expend_rate.ToString("f2") + "%";
                                    model.Low_Rate.Add(high_model);
                                }
                            }
                        }

                        if (model.High_Rate.Any() && model.High_Rate.Count > 5)
                        {
                            model.High_Rate = model.High_Rate.OrderByDescending(a => a.average_expend_rate).Take(5).ToList();
                        }

                        if (model.Low_Rate.Any() && model.Low_Rate.Count > 5)
                        {
                            model.Low_Rate = model.Low_Rate.OrderByDescending(a => a.average_expend_rate).Take(5).ToList();
                        }
                    }

                    return model;
                }
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        /// <summary>
        /// 默认根据最近7天的销售情况，用标准差公式计算消化率稳定产品.
        /// </summary>
        /// <returns>.</returns>
        private static List<ProductExpendRateStandardDeviationModel> GetStableExpendRate()
        {
            try
            {
                List<ProductExpendRateStandardDeviationModel> list = new List<ProductExpendRateStandardDeviationModel>();
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    DateTime start_time = DateTime.Now; DateTime end_time = start_time.AddDays(7);
                    var query = (from a in db.Product
                                 join b in db.Sell_Record on a.product_id equals b.product_id
                                 where b.create_time >= start_time && b.create_time <= end_time
                                 select new
                                 { a.product_id, a.product_name, a.stock_count, b.sell_count, b.create_time, a.product_category }).ToList();
                    if (query.Any())
                    {
                        var product = query.GroupBy(a => new { a.product_id, a.product_name });
                        if (product.Any())
                        {
                            foreach (var item in product)
                            {
                                List<double> expend_rate = new List<double>();
                                foreach (var info in item)
                                {
                                    double rate = ((double)info.sell_count / (double)info.stock_count) * 100;
                                    expend_rate.Add(rate);
                                }

                                ProductExpendRateStandardDeviationModel model = new ProductExpendRateStandardDeviationModel();
                                model.product_id = item.Key.product_id;
                                model.product_name = item.Key.product_name;
                                model.expend_rate_sd = SystemCommon.GetStdDev(expend_rate, false);
                                list.Add(model);
                            }
                        }
                    }

                    if (list.Any())
                    {
                        list = list.OrderBy(a => a.expend_rate_sd).Take(5).ToList();
                    }
                }

                return list;
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}
