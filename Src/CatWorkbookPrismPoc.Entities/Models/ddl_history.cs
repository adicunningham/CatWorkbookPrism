using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class ddl_history
    {
        public Nullable<int> source_object_id { get; set; }
        public int object_id { get; set; }
        public Nullable<bool> required_column_update { get; set; }
        public string ddl_command { get; set; }
        public byte[] ddl_lsn { get; set; }
        public Nullable<System.DateTime> ddl_time { get; set; }
    }
}
