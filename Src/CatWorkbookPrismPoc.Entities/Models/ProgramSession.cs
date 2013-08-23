using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class ProgramSession
    {
        public int ProgramSessionID { get; set; }
        public Nullable<int> ProgramID { get; set; }
        public Nullable<int> ProgramStatusID { get; set; }
        public Nullable<int> QuoteSnapshotID { get; set; }
        public Nullable<int> AuthorizedSnapshotID { get; set; }
        public Nullable<int> FotSnapshotID { get; set; }
        public Nullable<int> BoundSnapshotID { get; set; }
    }
}
