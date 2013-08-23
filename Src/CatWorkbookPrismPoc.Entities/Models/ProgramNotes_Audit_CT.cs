using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class ProgramNotes_Audit_CT
    {
        public byte[] C___start_lsn { get; set; }
        public byte[] C___end_lsn { get; set; }
        public byte[] C___seqval { get; set; }
        public int C___operation { get; set; }
        public byte[] C___update_mask { get; set; }
        public Nullable<int> ProgramNotesID { get; set; }
        public Nullable<int> ProgramID { get; set; }
        public Nullable<int> NoteTypeID { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
