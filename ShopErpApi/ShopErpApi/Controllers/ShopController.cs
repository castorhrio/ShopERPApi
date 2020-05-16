namespace ShopErpApi.Controllers
{
    using ShopErpApi.Commons;
    using ShopErpApi.Models.DBModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using static ShopErpApi.Commons.DBInit;

    /// <summary>
    /// Defines the <see cref="ShopController" />.
    /// </summary>
    [Route("api/[controller]")]
    public class ShopController : ApiController
    {
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
            /// Gets or sets the stock_count.
            /// </summary>
            public int stock_count { get; set; }

            /// <summary>
            /// Gets or sets the sell_count.
            /// </summary>
            public int sell_count { get; set; }

            /// <summary>
            /// Gets or sets the expend_rate.
            /// </summary>
            public string expend_rate { get; set; }
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
        /// 1. 获取营业数据.
        /// </summary>
        /// <param name="user_id">The user_id<see cref="int"/>.</param>
        /// <returns>.</returns>
        [Route("api/[controller]/staff_trade_info")]
        public IHttpActionResult GetUserTradeData(int user_id)
        {
            try
            {
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    Staff_Auth staff_auth = db.Staff_Auth.FirstOrDefault(a => a.staff_id == user_id);
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
        [Route("api/[controller]/all_product_expend_rate")]
        public IHttpActionResult GetAllProductExpendRate(DateTime? date)
        {
            DateTime time = date.HasValue ? date.Value : new DateTime(2020, 5, 20);
            var data = GetProductExpendRate(time: time);
            return Json(new { result = data });
        }

        /// <summary>
        /// 3. 调整员工主管.
        /// </summary>
        /// <param name="user_id">.</param>
        /// <param name="leader_id">.</param>
        /// <returns>.</returns>
        [Route("api/[controller]/change_staff_leader")]
        public IHttpActionResult ChangeStaffLeader(int user_id, int leader_id)
        {
            try
            {
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var staff = db.Staff.FirstOrDefault(a => a.id == user_id);
                    if (staff == null)
                        return Json(new { result = "员工不存在" });

                    var leader = (from a in db.Staff
                                  join b in db.Staff_Auth on a.id equals b.staff_id
                                  select new { a.id, b.sell_product_type }).FirstOrDefault();

                    if (leader == null)
                        return Json(new { result = "主管不存在" });

                    Staff_Auth auth = new Staff_Auth();
                    auth.leader_id = leader.id;
                    auth.staff_id = staff.id;
                    auth.sell_product_type = leader.sell_product_type.Split(',').FirstOrDefault();
                    auth.create_time = DateTime.Now;
                    auth.update_time = DateTime.Now;

                    db.Entry(auth).State = System.Data.Entity.EntityState.Added;
                    if (db.SaveChanges() > 0)
                        return Json(new { result = "操作成功" });
                }
            }
            catch (Exception ex)
            {

            }

            return Json(new { result = "操作失败" });
        }

        /// <summary>
        /// 3. 调整员工负责商品.
        /// </summary>
        /// <param name="user_id">.</param>
        /// <param name="product_type">.</param>
        /// <returns>.</returns>
        [Route("api/[controller]/change_staff_product_type")]
        public IHttpActionResult ChangeStaffProductType(int user_id, List<int> product_type)
        {
            try
            {
                if (product_type == null || !product_type.Any())
                    return Json(new { result = "请求参数错误" });

                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var staff = db.Staff_Auth.FirstOrDefault(a => a.staff_id == user_id);
                    if (staff == null)
                        return Json(new { result = "员工信息异常" });

                    staff.sell_product_type = string.Join(",", product_type);
                    db.Entry(staff).State = System.Data.Entity.EntityState.Added;
                    if (db.SaveChanges() > 0)
                        return Json(new { result = "操作成功" });
                }
            }
            catch (Exception ex)
            {

            }

            return Json(new { result = "操作失败" });
        }

        /// <summary>
        /// 4. 获取日配消化率最高和最低产品.
        /// </summary>
        /// <param name="date">The date<see cref="DateTime?"/>.</param>
        /// <returns>.</returns>
        [Route("api/[controller]/get_ripei")]
        public IHttpActionResult GetRiPeiExpendRate(DateTime? date)
        {
            DateTime time = date.HasValue ? date.Value : new DateTime(2020, 5, 20);
            var data = GetProductExpendRate((int)Product_Category_Enum.RiPei, time);
            return Json(new { result = data });
        }

        /// <summary>
        /// 4. 获取非日配消化率最高和最低产品.
        /// </summary>
        /// <param name="date">The date<see cref="DateTime?"/>.</param>
        /// <returns>.</returns>
        [Route("api/[controller]/get_nonripei")]
        public IHttpActionResult GetNonRiPeiExpendRate(DateTime? date)
        {
            DateTime time = date.HasValue ? date.Value : new DateTime(2020, 5, 20);
            var data = GetProductExpendRate((int)Product_Category_Enum.NoRiPei, time);
            return Json(new { result = data });
        }

        /// <summary>
        /// The GetProductExpendRate.
        /// </summary>
        /// <param name="category">The category<see cref="int?"/>.</param>
        /// <param name="time">The time<see cref="DateTime?"/>.</param>
        /// <returns>The <see cref="List{ProductExpendModel}"/>.</returns>
        private static List<ProductExpendModel> GetProductExpendRate(int? category = null, DateTime? time = null)
        {
            List<ProductExpendModel> list = new List<ProductExpendModel>();
            try
            {
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    if (category.HasValue)
                    {
                        var query = (from a in db.Product join b in db.Sell_Record on a.product_id equals b.product_id where a.product_category == category.Value select new { a.product_id, a.product_name, a.stock_count, b.sell_count, b.create_time }).ToList();
                        if (time.HasValue)
                        {
                            query = query.Where(a => a.create_time.ToString("yyyy-MM-dd") == time.Value.ToString("yyyy-MM-dd")).Select(a => a).ToList();
                        }
                        foreach (var item in query)
                        {
                            ProductExpendModel pro = new ProductExpendModel();
                            pro.product_id = item.product_id;
                            pro.product_name = item.product_name;
                            pro.stock_count = item.stock_count;
                            pro.sell_count = item.sell_count;
                            pro.expend_rate = (((double)item.sell_count / (double)item.stock_count) * 100).ToString("f2") + "%";
                            list.Add(pro);
                        }
                        List<ProductExpendModel> temp = new List<ProductExpendModel>();
                        temp.AddRange(list.OrderBy(a => a.sell_count).Take(5));
                        temp.AddRange(list.OrderByDescending(a => a.sell_count).Take(5));
                        return temp.OrderBy(a => a.sell_count).ToList();
                    }
                    else
                    {
                        var query = (from a in db.Product join b in db.Sell_Record on a.product_id equals b.product_id select new { a.product_id, a.product_name, a.stock_count, b.sell_count, b.create_time }).ToList();
                        if (time.HasValue)
                        {
                            query = query.Where(a => a.create_time.ToString("yyyy-MM-dd") == time.Value.ToString("yyyy-MM-dd")).Select(a => a).ToList();
                        }
                        foreach (var item in query)
                        {
                            ProductExpendModel pro = new ProductExpendModel();
                            pro.product_id = item.product_id;
                            pro.product_name = item.product_name;
                            pro.stock_count = item.stock_count;
                            pro.sell_count = item.sell_count;
                            pro.expend_rate = (((double)item.sell_count / (double)item.stock_count) * 100).ToString("f2") + "%";
                            list.Add(pro);
                        }
                        return list.OrderBy(a => a.sell_count).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return null; ;
        }
    }
}
