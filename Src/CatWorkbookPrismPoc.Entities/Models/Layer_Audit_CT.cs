using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class Layer_Audit_CT
    {
        public byte[] C___start_lsn { get; set; }
        public byte[] C___end_lsn { get; set; }
        public byte[] C___seqval { get; set; }
        public int C___operation { get; set; }
        public byte[] C___update_mask { get; set; }
        public Nullable<int> PricingLayerID { get; set; }
        public Nullable<int> PricingStageTypeID { get; set; }
        public Nullable<int> StructureID { get; set; }
        public Nullable<int> ProgramID { get; set; }
        public Nullable<int> LayerID { get; set; }
        public string RemetricaLayer { get; set; }
        public Nullable<decimal> Placed { get; set; }
        public Nullable<decimal> Covered { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<int> ReinstatementNumber { get; set; }
        public Nullable<decimal> ReinstatementAmount { get; set; }
        public Nullable<decimal> AggLimit { get; set; }
        public Nullable<decimal> OccLimit { get; set; }
        public Nullable<decimal> OccAttachment { get; set; }
        public Nullable<double> RateOnLine { get; set; }
        public Nullable<decimal> Premium { get; set; }
        public Nullable<double> Share { get; set; }
        public Nullable<double> FXRate { get; set; }
        public Nullable<decimal> OurPremium { get; set; }
        public Nullable<decimal> OurLimit { get; set; }
        public Nullable<decimal> DepositPremium { get; set; }
        public Nullable<decimal> RIPremium { get; set; }
        public Nullable<decimal> DepositBrokerage { get; set; }
        public Nullable<decimal> RIBrokerage { get; set; }
        public Nullable<decimal> FET { get; set; }
        public Nullable<decimal> InternalGA { get; set; }
        public Nullable<decimal> NonCatLoss { get; set; }
        public Nullable<decimal> ProfitLoss { get; set; }
        public Nullable<double> CatEL { get; set; }
        public Nullable<double> LossRatio { get; set; }
        public Nullable<double> UWRatio { get; set; }
        public Nullable<double> CombinedRatio { get; set; }
        public Nullable<decimal> Loss250Year { get; set; }
        public Nullable<decimal> IncrementalLoss250Year { get; set; }
        public Nullable<decimal> IncrementalRIPremium { get; set; }
        public Nullable<decimal> IncrementalLoss250YearOccLimit { get; set; }
        public Nullable<decimal> C3PremiumRiskCharge { get; set; }
        public Nullable<decimal> C4ReserveRiskCharge { get; set; }
        public Nullable<decimal> C5CatRiskCharge { get; set; }
        public Nullable<decimal> C6LimitCharge { get; set; }
        public Nullable<decimal> SPCapital { get; set; }
        public Nullable<decimal> InvestmentIncome { get; set; }
        public Nullable<double> ReturnOnCapital { get; set; }
        public string UWWorkbookFullPath { get; set; }
        public string UWWorkbookMDrivePath { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public Nullable<int> AnalysisID { get; set; }
        public Nullable<int> ResultSetKey { get; set; }
        public string AnalysisName { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string Modifiedby { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> LayerNumber { get; set; }
        public Nullable<decimal> CatLoss { get; set; }
    }
}
