using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class NamedRange
    {
        public int NamedRangeID { get; set; }
        public string SheetName { get; set; }
        public string RangeName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsLocked { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
