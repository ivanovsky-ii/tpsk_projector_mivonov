//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace barbi_shop.barbi_database
{
    using System;
    using System.Collections.Generic;
    
    public partial class records
    {
        public int record_id { get; set; }
        public Nullable<int> service_id { get; set; }
        public Nullable<int> barber_id { get; set; }
        public Nullable<int> client_id { get; set; }
        public Nullable<System.DateTime> record_date_and_time { get; set; }
        public string record_comment { get; set; }
    
        public virtual barbers barbers { get; set; }
        public virtual clients clients { get; set; }
        public virtual services services { get; set; }
    }
}
