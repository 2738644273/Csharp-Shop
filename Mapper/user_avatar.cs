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
    
    public partial class user_avatar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_avatar()
        {
            this.users = new HashSet<user>();
        }
    
        public long id { get; set; }
        public string real_name { get; set; }
        public string path { get; set; }
        public string size { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
    }
}
