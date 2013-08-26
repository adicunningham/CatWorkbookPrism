using System;
using System.Runtime.Serialization;

namespace CatWorkbookPrismPoc.Services.Contracts.Data
{
    [DataContract]
    public partial class Program
    {
        public Program()
        {
        }

        [DataMember]
        public int ProgramID { get; set; }
        [DataMember]
        public int UnderwriterID { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public int TeamID { get; set; }
        [DataMember]
        public Nullable<int> ExpiringProgramID { get; set; }
        [DataMember]
        public Nullable<int> QuoteStructureID { get; set; }
        [DataMember]
        public Nullable<int> QuoteExpiringStructureID { get; set; }
        [DataMember]
        public Nullable<int> AuthorizedExpiringStructureID { get; set; }
        [DataMember]
        public string QuoteStatus { get; set; }
        [DataMember]
        public string AuthorizedStatus { get; set; }
        [DataMember]
        public string BoundStatus { get; set; }
        [DataMember]
        public string ProgramName { get; set; }
        [DataMember]
        public string ClientName { get; set; }
        [DataMember]
        public string UnderwriterName { get; set; }
        [DataMember]
        public string TeamName { get; set; }
        [DataMember]
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        [DataMember]
        public string MasterNumber { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public Nullable<System.DateTime> CreatedOn { get; set; }
        [DataMember]
        public string ModifiedBy { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
