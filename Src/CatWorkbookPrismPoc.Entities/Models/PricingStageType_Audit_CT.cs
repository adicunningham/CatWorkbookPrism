using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class PricingStageType_Audit_CT
    {
        public byte[] C___start_lsn { get; set; }
        public byte[] C___end_lsn { get; set; }
        public byte[] C___seqval { get; set; }
        public int C___operation { get; set; }
        public byte[] C___update_mask { get; set; }
        public Nullable<int> PricingStageTypeID { get; set; }
        public string PricingStage { get; set; }
    }
}
