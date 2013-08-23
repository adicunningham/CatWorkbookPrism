using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class ErrorLog
    {
        public int LogID { get; set; }
        public string UserID { get; set; }
        public string ErrorMessage { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
