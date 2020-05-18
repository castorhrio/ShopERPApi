using ShopErpApi.Commons;
using ShopErpApi.Models.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopErpApi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 初始化数据.
        /// </summary>
        /// <returns>.</returns>
        public void InitDB()
        {

            try
            {
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    if (!db.Product.Any())
                    {
                        DBInit.InitProduct();
                    }

                    if (!db.Staff.Any())
                    {
                        DBInit.InitStaff();
                    }

                    if (!db.WorkTime.Any())
                    {
                        DBInit.InitWorkTime();
                    }

                    if (!db.Sell_Record.Any())
                    {
                        DBInit.InitSellRecord();
                    }

                    if (!db.Inventory.Any())
                    {
                        DBInit.InitInventory();
                    }

                    if (!db.Product_Expend_Rate_Config.Any())
                    {
                        DBInit.InitProductExpendRateConfig();
                    }
                }

                Response.Write("ok");
                return;
            }
            catch (Exception ex)
            {

            }

            Response.Write("error");
        }
    }
}