using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class Program
    {
        public Program()
        {
            this.Layers = new List<Layer>();
            this.ProgramNotes = new List<ProgramNote>();
            this.Snapshots = new List<Snapshot>();
        }

        public int ProgramID { get; set; }
        public int UnderwriterID { get; set; }
        public int Year { get; set; }
        public int TeamID { get; set; }
        public Nullable<int> ExpiringProgramID { get; set; }
        public Nullable<int> QuoteStructureID { get; set; }
        public Nullable<int> QuoteExpiringStructureID { get; set; }
        public Nullable<int> AuthorizedExpiringStructureID { get; set; }
        public string QuoteStatus { get; set; }
        public string AuthorizedStatus { get; set; }
        public string BoundStatus { get; set; }
        public string ProgramName { get; set; }
        public string ClientName { get; set; }
        public string UnderwriterName { get; set; }
        public string TeamName { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public string MasterNumber { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public virtual ICollection<Layer> Layers { get; set; }
        public virtual ICollection<ProgramNote> ProgramNotes { get; set; }
        public virtual ICollection<Snapshot> Snapshots { get; set; }
    }
}
