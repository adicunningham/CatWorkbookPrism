using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class captured_columns
    {
        public int object_id { get; set; }
        public string column_name { get; set; }
        public Nullable<int> column_id { get; set; }
        public string column_type { get; set; }
        public int column_ordinal { get; set; }
        public Nullable<bool> is_computed { get; set; }
    }
}
