using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class lsn_time_mapping
    {
        public byte[] start_lsn { get; set; }
        public Nullable<System.DateTime> tran_begin_time { get; set; }
        public Nullable<System.DateTime> tran_end_time { get; set; }
        public byte[] tran_id { get; set; }
        public byte[] tran_begin_lsn { get; set; }
    }
}
