namespace ShopErpApi.Controllers
{
    using ShopErpApi.Models.DBModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    /// <summary>
    /// 员工.
    /// </summary>
    [Route("api/[controller]")]
    public class UserController : ApiController
    {
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
    }
}
