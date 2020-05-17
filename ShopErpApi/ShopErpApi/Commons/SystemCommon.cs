namespace ShopErpApi.Commons
{
    using ShopErpApi.Models.DBModel;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Defines the <see cref="SystemCommon" />.
    /// </summary>
    public class SystemCommon
    {
        /// <summary>
        /// 消耗率类型
        /// </summary>
        public enum Enum_Product_Expend_Rate_Type
        {
            /// <summary>
            /// Defines the High_Expend_Rate.
            /// </summary>
            High_Expend_Rate = 1,
            /// <summary>
            /// Defines the Low_Expend_Rate.
            /// </summary>
            Low_Expend_Rate = 2
        }

        /// <summary>
        /// 商品类别
        /// </summary>
        public enum Product_Category_Enum
        {
            /// <summary>
            /// Defines the RiPei.
            /// </summary>
            [Description("日配")]
            RiPei = 0,
            /// <summary>
            /// Defines the NoRiPei.
            /// </summary>
            [Description("非日配")]
            NoRiPei = 1
        }

        /// <summary>
        /// 商品类型
        /// </summary>
        public enum Product_Type_Enum
        {
            /// <summary>
            /// Defines the FangBianShiPin.
            /// </summary>
            [Description("方便食品")]
            FangBianShiPin = 1,
            /// <summary>
            /// Defines the PengHuaShiPin.
            /// </summary>
            [Description("膨化食品")]
            PengHuaShiPin = 2,
            /// <summary>
            /// Defines the TangGuo.
            /// </summary>
            [Description("巧克力糖果")]
            TangGuo = 3,
            /// <summary>
            /// Defines the YinLiao.
            /// </summary>
            [Description("软饮料")]
            YinLiao = 4,
            /// <summary>
            /// Defines the ZaHuo.
            /// </summary>
            [Description("杂货")]
            ZaHuo = 5,
            /// <summary>
            /// Defines the FanTuan.
            /// </summary>
            [Description("饭团")]
            FanTuan = 6,
            /// <summary>
            /// Defines the MianBao.
            /// </summary>
            [Description("面包")]
            MianBao = 7,
            /// <summary>
            /// Defines the SanMingZhi.
            /// </summary>
            [Description("三明治")]
            SanMingZhi = 8,
            /// <summary>
            /// Defines the ShouSi.
            /// </summary>
            [Description("寿司")]
            ShouSi = 9,
            /// <summary>
            /// Defines the SuanNai.
            /// </summary>
            [Description("酸奶")]
            SuanNai = 10
        }

        /// <summary>
        /// Defines the Staff_Postion_Type_Enum.
        /// </summary>
        public enum Staff_Postion_Type_Enum
        {
            /// <summary>
            /// Defines the 店长.
            /// </summary>
            店长,
            /// <summary>
            /// Defines the 副店.
            /// </summary>
            副店,
            /// <summary>
            /// Defines the 班长.
            /// </summary>
            班长,
            /// <summary>
            /// Defines the 店员.
            /// </summary>
            店员,
            /// <summary>
            /// Defines the PT.
            /// </summary>
            PT
        }

        /// <summary>
        /// 日配消化率过高..
        /// </summary>
        public static double Ri_Pei_High_Expend_Rate = 88;//日配商品消化率90%，上下两个点

        /// <summary>
        /// 非日配消化率过高..
        /// </summary>
        public static double No_Ri_Pei_High_Expend_Rate = 25;//非日配商品消化率30%，上下五个点

        /// <summary>
        /// 日配消化率过低..
        /// </summary>
        public static double Ri_Pei_Low_Expend_Rate = 50;

        /// <summary>
        /// 非日配消化率过低..
        /// </summary>
        public static double No_Ri_Pei_Low_Expend_Rate = 10;

        /// <summary>
        /// The GetDescription.
        /// </summary>
        /// <param name="en">The en<see cref="Enum"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetDescription(Enum en)
        {
            //获取类型  
            Type type = en.GetType();
            MemberInfo[] memberInfos = type.GetMember(en.ToString());   //获取成员  
            if (memberInfos != null && memberInfos.Length > 0)
            {
                //获取描述特性  
                DescriptionAttribute[] attrs = memberInfos[0].GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
                if (attrs != null && attrs.Length > 0)
                {
                    return attrs[0].Description;
                }
            }
            return en.ToString();
        }

        /// <summary>
        /// 计算标准差.
        /// </summary>
        /// <param name="values">.</param>
        /// <param name="as_sample">.</param>
        /// <returns>.</returns>
        public static double GetStdDev(IEnumerable<double> values, bool as_sample)
        {
            // Get the mean.
            double mean = values.Sum() / values.Count();

            // Get the sum of the squares of the differences
            // between the values and the mean.
            var squares_query = from int value in values select (value - mean) * (value - mean);
            double sum_of_squares = squares_query.Sum();

            if (as_sample)
            {
                return Math.Sqrt(sum_of_squares / (values.Count() - 1));
            }
            else
            {
                return Math.Sqrt(sum_of_squares / values.Count());
            }
        }

        /// <summary>
        /// 获取消耗率.
        /// </summary>
        /// <param name="product_id">.</param>
        /// <param name="product_category">.</param>
        /// <param name="expend_rate_type">.</param>
        /// <returns>.</returns>
        public static double GetExpendRate(string product_id, int product_category, int expend_rate_type)
        {
            double expend_rate = 0;
            try
            {
                using (ERPDBEntities db = new ERPDBEntities())
                {
                    var rate_config = db.Product_Expend_Rate_Config.FirstOrDefault(a => a.product_id == product_id);
                    if (rate_config != null)
                    {
                        if (product_category == (int)Product_Category_Enum.NoRiPei)
                        {
                            if (expend_rate_type == (int)Enum_Product_Expend_Rate_Type.High_Expend_Rate)
                            {
                                expend_rate = SystemCommon.No_Ri_Pei_High_Expend_Rate;
                            }
                            else if (expend_rate_type == (int)Enum_Product_Expend_Rate_Type.Low_Expend_Rate)
                            {
                                expend_rate = SystemCommon.No_Ri_Pei_Low_Expend_Rate;
                            }
                        }
                        else if (product_category == (int)Product_Category_Enum.RiPei)
                        {
                            if (expend_rate_type == (int)Enum_Product_Expend_Rate_Type.High_Expend_Rate)
                            {
                                expend_rate = SystemCommon.Ri_Pei_High_Expend_Rate;
                            }
                            else if (expend_rate_type == (int)Enum_Product_Expend_Rate_Type.Low_Expend_Rate)
                            {
                                expend_rate = SystemCommon.Ri_Pei_Low_Expend_Rate;
                            }
                        }
                    }
                    else
                    {
                        if (expend_rate_type == (int)Enum_Product_Expend_Rate_Type.High_Expend_Rate)
                        {
                            expend_rate = rate_config.high_expend_rate;
                        }
                        else if (expend_rate_type == (int)Enum_Product_Expend_Rate_Type.Low_Expend_Rate)
                        {
                            expend_rate = rate_config.low_expend_rate;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return expend_rate;
        }
    }
}
