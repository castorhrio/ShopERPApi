﻿namespace ShopErpApi.Controllers
{
    using ShopErpApi.Commons;
    using ShopErpApi.Models.DBModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Web.Http;
    using static ShopErpApi.Commons.SystemCommon;

    public class HomeInfoData
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public List<string> staff { get; set; }

        /// <summary>
        /// 业绩目标
        /// </summary>
        public decimal sell_target { get; set; }

        /// <summary>
        /// 当前时间
        /// </summary>
        public string current_date { get; set; }

        /// <summary>
        /// 日配商品数量
        /// </summary>
        public int ri_pei_count { get; set; }

        /// <summary>
        /// 非日配商品数量
        /// </summary>
        public int no_ri_pei_count { get; set; }

        /// <summary>
        /// 业绩
        /// </summary>
        public int sell_amount { get; set; }

        /// <summary>
        /// 来客数
        /// </summary>
        public int custome_amount { get; set; }

        /// <summary>
        /// 客单价
        /// </summary>
        public decimal custome_price_per { get; set; }
    }

    /// <summary>
    /// 员工.
    /// </summary>
    [Route("api/[controller]")]
    public class UserController : ApiController
    {
        /// <summary>
        /// 3.1 用户登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [Route("api/user/login")]
        public IHttpActionResult UserLogin(string name, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
                return Json(new { result = "用户名或密码错误" });

            using (ERPDBEntities db = new ERPDBEntities())
            {
                var encode_pass = SystemCommon.GetMD5Str(password);
                var user = db.Staff.FirstOrDefault(a => a.name == name && a.password == encode_pass);
                if (user == null)
                    return Json(new { result = "用户不存在" });

                return Json(new { result = "登陆成功", data = user.id });
            }
        }

        /// <summary>
        /// 3.1 新增用户
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="leader_id"></param>
        /// <param name="user_type"></param>
        /// <param name="salary"></param>
        /// <param name="sell_product_type">产品类型枚举值用逗号分割</param>
        /// <returns></returns>
        [Route("api/user/add_user")]
        public IHttpActionResult AddUser(string name, string password, int leader_id, string user_type, decimal salary, string sell_product_type)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                    return Json(new { result = "用户名不能为空" });

                Enum_User_Type userType;
                bool convertResult = Enum.TryParse(user_type, out userType);
                if (convertResult == false)
                {
                    return Json(new { result = "用户类型异常" });
                }

                Staff user = new Staff();
                user.name = name;
                user.password = string.IsNullOrEmpty(password) ? SystemCommon.GetMD5Str(SystemCommon.Default_Password) : SystemCommon.GetMD5Str(password);
                user.leader_id = leader_id;
                user.user_type = user_type;
                user.salary = salary;
                user.sell_product_type = sell_product_type;
                user.create_time = DateTime.Now;
                user.update_time = DateTime.Now;

                using (ERPDBEntities db = new ERPDBEntities())
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Added;
                    if (db.SaveChanges() < 0)
                        return Json(new { result = "用户添加失败" });
                }

                return Json(new { result = "用户添加成功" });
            }
            catch (Exception ex)
            {

            }

            return Json(new { result = "系统异常" });
        }

        /// <summary>
        /// 2.3. 调整员工主管.
        /// </summary>
        /// <param name="user_id">.</param>
        /// <param name="leader_id">.</param>
        /// <returns>.</returns>
        [Route("api/user/change_staff_leader")]
        public IHttpActionResult ChangeStaffLeader(int user_id, int leader_id)
        {
            try
            {
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var staff = db.Staff.FirstOrDefault(a => a.id == user_id);
                    if (staff == null)
                        return Json(new { result = "员工信息不存在" });

                    var leader = db.Staff.FirstOrDefault(a => a.id == leader_id);
                    if (leader == null)
                        return Json(new { result = "主管信息不存在" });

                    staff.leader_id = leader.id;
                    staff.update_time = DateTime.Now;

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
        /// 2.3. 调整员工负责商品.
        /// </summary>
        /// <param name="user_id">.</param>
        /// <param name="product_type">.</param>
        /// <returns>.</returns>
        [Route("api/user/change_staff_product_type")]
        public IHttpActionResult ChangeStaffProductType(int user_id, List<int> product_type)
        {
            try
            {
                if (product_type == null || !product_type.Any())
                    return Json(new { result = "请求参数错误" });

                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var staff = db.Staff.FirstOrDefault(a => a.id == user_id);
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
        /// 3.2获取排班表
        /// </summary>
        /// <returns></returns>
        [Route("api/user/get_schedule")]
        public IHttpActionResult GetSchedule()
        {
            try
            {
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    string week = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
                    List<WorkTime> work = db.WorkTime.Where(a => a.week == week).ToList();
                    return Json(new { result = work });
                }
            }
            catch (Exception ex)
            {

            }

            return Json(new { result = "系统异常" });
        }

        /// <summary>
        /// 3.2新增员工排班
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="week"></param>
        /// <param name="on_work"></param>
        /// <param name="off_work"></param>
        /// <returns></returns>
        [Route("api/user/add_schedule")]
        public IHttpActionResult AddSchedule(int user_id, string week, string on_work, string off_work)
        {
            try
            {
                if (string.IsNullOrEmpty(week) || string.IsNullOrEmpty(on_work) || string.IsNullOrEmpty(off_work))
                    return Json(new { result = "请求参数错误" });

                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var staff = db.Staff.FirstOrDefault(a => a.id == user_id);
                    if (staff == null)
                        return Json(new { result = "员工信息异常" });

                    WorkTime work_time = new WorkTime();
                    work_time.staff_id = staff.id;
                    work_time.staff_name = staff.name;
                    work_time.week = week;
                    work_time.on_work = on_work;
                    work_time.off_work = off_work;
                    work_time.create_time = DateTime.Now;
                    work_time.update_time = DateTime.Now;
                    db.Entry(work_time).State = System.Data.Entity.EntityState.Added;
                    if (db.SaveChanges() < 0)
                        return Json(new { result = "添加失败" });

                    return Json(new { result = "添加成功" });
                }

            }
            catch (Exception ex)
            {

            }
            return Json(new { result = "系统异常" });
        }

        /// <summary>
        /// 3.2修改排班表
        /// </summary>
        /// <returns></returns>
        [Route("api/user/edit_schedule")]
        public IHttpActionResult EditSchedule(int word_time_id, string week, string on_work, string off_work)
        {
            try
            {
                if (string.IsNullOrEmpty(week) || string.IsNullOrEmpty(on_work) || string.IsNullOrEmpty(off_work))
                    return Json(new { result = "请求参数错误" });

                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var work_time = db.WorkTime.FirstOrDefault(a => a.id == word_time_id);
                    if (work_time == null)
                        return Json(new { result = "排班信息异常" });

                    work_time.week = week;
                    work_time.on_work = on_work;
                    work_time.off_work = off_work;
                    work_time.update_time = DateTime.Now;
                    db.Entry(work_time).State = System.Data.Entity.EntityState.Modified;
                    if (db.SaveChanges() < 0)
                        return Json(new { result = "修改失败" });

                    return Json(new { result = "修改成功" });
                }

            }
            catch (Exception ex)
            {

            }
            return Json(new { result = "系统异常" });
        }

        /// <summary>
        /// 1.1 获取首页信息
        /// </summary>
        /// <returns></returns>
        [Route("api/home/home_info")]
        public IHttpActionResult GetHomeInfo()
        {
            try
            {
                HomeInfoData model = new HomeInfoData();
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    DateTime now = DateTime.Now;
                    string week = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(now.DayOfWeek);
                    List<WorkTime> work = db.WorkTime.Where(a => a.week == week).ToList();
                    model.staff = work.Select(a => a.staff_name).ToList();

                    model.ri_pei_count = db.Product.Where(a => a.product_category == (int)Product_Category_Enum.RiPei).Sum(a => a.stock_count);
                    model.ri_pei_count = db.Product.Where(a => a.product_category == (int)Product_Category_Enum.NoRiPei).Sum(a => a.stock_count);
                    model.current_date = now.ToString("yyyy.MM.dd") + "(" + week + ")";
                    model.sell_target = SystemCommon.Default_Sell_Target;
                }
            }
            catch (Exception ex)
            {

            }

            return Json(new { result = "系统异常" });
        }
    }
}
