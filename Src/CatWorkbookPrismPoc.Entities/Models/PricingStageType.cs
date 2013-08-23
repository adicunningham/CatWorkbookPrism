using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class PricingStageType
    {
        public PricingStageType()
        {
            this.Layers = new List<Layer>();
            this.Snapshots = new List<Snapshot>();
        }

        public int PricingStageTypeID { get; set; }
        public string PricingStage { get; set; }
        public virtual ICollection<Layer> Layers { get; set; }
        public virtual ICollection<Snapshot> Snapshots { get; set; }
    }
}
