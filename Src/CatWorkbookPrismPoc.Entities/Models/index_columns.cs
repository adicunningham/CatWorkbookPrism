using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class index_columns
    {
        public int object_id { get; set; }
        public string column_name { get; set; }
        public byte index_ordinal { get; set; }
        public Nullable<int> column_id { get; set; }
    }
}
