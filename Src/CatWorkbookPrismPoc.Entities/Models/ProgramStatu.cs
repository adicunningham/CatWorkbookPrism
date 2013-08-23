using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class ProgramStatu
    {
        public ProgramStatu()
        {
            this.Layers = new List<Layer>();
        }

        public int ProgramStatusID { get; set; }
        public string ProgramStatus { get; set; }
        public Nullable<int> Rank { get; set; }
        public virtual ICollection<Layer> Layers { get; set; }
    }
}
