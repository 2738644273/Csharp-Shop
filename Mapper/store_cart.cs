//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mapper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class store_cart
    {

        public store_product_attr_value store_product_attr_value;
        public decimal id { get; set; }
        public decimal uid { get; set; }
        public string type { get; set; }
        public decimal product_id { get; set; }
        public string product_attr_unique { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public store_product_attr_value attrInfo;
        /// <summary>
        /// 详情信息
        /// </summary>
        public store_product productInfo;
        public int cart_num { get; set; }
        public System.DateTime create_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public bool is_pay { get; set; }
        public bool is_del { get; set; }
        public bool is_new { get; set; }
        public Nullable<long> combination_id { get; set; }
        public long seckill_id { get; set; }
        public long bargain_id { get; set; }
    }
}
