using System;
using System.Collections.Generic;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class Layer
    {
        public int PricingLayerID { get; set; }
        public int PricingStageTypeID { get; set; }
        public Nullable<int> StructureID { get; set; }
        public Nullable<int> ProgramID { get; set; }
        public int LayerID { get; set; }
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
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string Modifiedby { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> LayerNumber { get; set; }
        public Nullable<decimal> CatLoss { get; set; }
        public string CoverageType { get; set; }
        public Nullable<decimal> MinPremiumPercentage { get; set; }
        public Nullable<decimal> DepositPremiumPercentage { get; set; }
        public Nullable<decimal> RateOnTIV { get; set; }
        public Nullable<decimal> RateOnPremium { get; set; }
        public Nullable<int> ExportedToGemini { get; set; }
        public Nullable<decimal> AggregateDeductible { get; set; }
        public string UnderwriterCategory { get; set; }
        public Nullable<decimal> NonCatLossPercentage { get; set; }
        public Nullable<int> SnapshotID { get; set; }
        public Nullable<int> LayerStatusID { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string RemetricaModelName { get; set; }
        public string RemetricaTrials { get; set; }
        public string RemetricaBlend { get; set; }
        public string RemetricaMTRLayer { get; set; }
        public string RemetricaLTRLayer { get; set; }
        public virtual ProgramStatu ProgramStatu { get; set; }
        public virtual PricingStageType PricingStageType { get; set; }
        public virtual Program Program { get; set; }
        public virtual Snapshot Snapshot { get; set; }
    }
}
