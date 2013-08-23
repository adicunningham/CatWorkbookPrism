using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class Snapshot
    {
        public Snapshot()
        {
            this.Layers = new List<Layer>();
            this.Snapshot1 = new List<Snapshot>();
        }

        public int SnapshotID { get; set; }
        public string SnapshotName { get; set; }
        public Nullable<int> ProgramID { get; set; }
        public Nullable<int> ParentSnapshotID { get; set; }
        public Nullable<int> PricingStageTypeID { get; set; }
        public Nullable<bool> isOption { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> Disabled { get; set; }
        public virtual ICollection<Layer> Layers { get; set; }
        public virtual PricingStageType PricingStageType { get; set; }
        public virtual Program Program { get; set; }
        public virtual ICollection<Snapshot> Snapshot1 { get; set; }
        public virtual Snapshot Snapshot2 { get; set; }
    }
}
