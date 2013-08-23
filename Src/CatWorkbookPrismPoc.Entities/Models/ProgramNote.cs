using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class ProgramNote
    {
        public int ProgramNotesID { get; set; }
        public int ProgramID { get; set; }
        public int NoteTypeID { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public virtual Program Program { get; set; }
    }
}
