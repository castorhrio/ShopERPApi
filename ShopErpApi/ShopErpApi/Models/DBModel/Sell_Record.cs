//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopErpApi.Models.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sell_Record
    {
        public int id { get; set; }
        public string product_id { get; set; }
        public string product_name { get; set; }
        public int delivery_count { get; set; }
        public int sell_count { get; set; }
        public int trash_count { get; set; }
        public System.DateTime create_time { get; set; }
        public System.DateTime update_time { get; set; }
    }
}
