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
    
    public partial class user_address
    {
        public decimal id { get; set; }
        public decimal uid { get; set; }
        public string real_name { get; set; }
        public string phone { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public Nullable<int> city_id { get; set; }
        public string district { get; set; }
        public string detail { get; set; }
        public string post_code { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public bool is_default { get; set; }
        public bool is_del { get; set; }
        public System.DateTime create_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
    }
}
