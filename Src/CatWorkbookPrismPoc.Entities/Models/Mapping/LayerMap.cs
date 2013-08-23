using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class LayerMap : EntityTypeConfiguration<Layer>
    {
        public LayerMap()
        {
            // Primary Key
            this.HasKey(t => t.PricingLayerID);

            // Properties
            this.Property(t => t.CurrencyCode)
                .HasMaxLength(30);

            this.Property(t => t.UWWorkbookFullPath)
                .HasMaxLength(256);

            this.Property(t => t.UWWorkbookMDrivePath)
                .HasMaxLength(256);

            this.Property(t => t.ServerName)
                .HasMaxLength(50);

            this.Property(t => t.DatabaseName)
                .HasMaxLength(100);

            this.Property(t => t.AnalysisName)
                .HasMaxLength(100);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(200);

            this.Property(t => t.Modifiedby)
                .HasMaxLength(200);

            this.Property(t => t.CoverageType)
                .HasMaxLength(200);

            this.Property(t => t.UnderwriterCategory)
                .HasMaxLength(200);

            this.Property(t => t.RemetricaModelName)
                .HasMaxLength(500);

            this.Property(t => t.RemetricaTrials)
                .HasMaxLength(500);

            this.Property(t => t.RemetricaBlend)
                .HasMaxLength(500);

            this.Property(t => t.RemetricaMTRLayer)
                .HasMaxLength(200);

            this.Property(t => t.RemetricaLTRLayer)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Layer");
            this.Property(t => t.PricingLayerID).HasColumnName("PricingLayerID");
            this.Property(t => t.PricingStageTypeID).HasColumnName("PricingStageTypeID");
            this.Property(t => t.StructureID).HasColumnName("StructureID");
            this.Property(t => t.ProgramID).HasColumnName("ProgramID");
            this.Property(t => t.LayerID).HasColumnName("LayerID");
            this.Property(t => t.Placed).HasColumnName("Placed");
            this.Property(t => t.Covered).HasColumnName("Covered");
            this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            this.Property(t => t.ReinstatementNumber).HasColumnName("ReinstatementNumber");
            this.Property(t => t.ReinstatementAmount).HasColumnName("ReinstatementAmount");
            this.Property(t => t.AggLimit).HasColumnName("AggLimit");
            this.Property(t => t.OccLimit).HasColumnName("OccLimit");
            this.Property(t => t.OccAttachment).HasColumnName("OccAttachment");
            this.Property(t => t.RateOnLine).HasColumnName("RateOnLine");
            this.Property(t => t.Premium).HasColumnName("Premium");
            this.Property(t => t.Share).HasColumnName("Share");
            this.Property(t => t.FXRate).HasColumnName("FXRate");
            this.Property(t => t.OurPremium).HasColumnName("OurPremium");
            this.Property(t => t.OurLimit).HasColumnName("OurLimit");
            this.Property(t => t.DepositPremium).HasColumnName("DepositPremium");
            this.Property(t => t.RIPremium).HasColumnName("RIPremium");
            this.Property(t => t.DepositBrokerage).HasColumnName("DepositBrokerage");
            this.Property(t => t.RIBrokerage).HasColumnName("RIBrokerage");
            this.Property(t => t.FET).HasColumnName("FET");
            this.Property(t => t.InternalGA).HasColumnName("InternalGA");
            this.Property(t => t.NonCatLoss).HasColumnName("NonCatLoss");
            this.Property(t => t.ProfitLoss).HasColumnName("ProfitLoss");
            this.Property(t => t.CatEL).HasColumnName("CatEL");
            this.Property(t => t.LossRatio).HasColumnName("LossRatio");
            this.Property(t => t.UWRatio).HasColumnName("UWRatio");
            this.Property(t => t.CombinedRatio).HasColumnName("CombinedRatio");
            this.Property(t => t.Loss250Year).HasColumnName("Loss250Year");
            this.Property(t => t.IncrementalLoss250Year).HasColumnName("IncrementalLoss250Year");
            this.Property(t => t.IncrementalRIPremium).HasColumnName("IncrementalRIPremium");
            this.Property(t => t.IncrementalLoss250YearOccLimit).HasColumnName("IncrementalLoss250YearOccLimit");
            this.Property(t => t.C3PremiumRiskCharge).HasColumnName("C3PremiumRiskCharge");
            this.Property(t => t.C4ReserveRiskCharge).HasColumnName("C4ReserveRiskCharge");
            this.Property(t => t.C5CatRiskCharge).HasColumnName("C5CatRiskCharge");
            this.Property(t => t.C6LimitCharge).HasColumnName("C6LimitCharge");
            this.Property(t => t.SPCapital).HasColumnName("SPCapital");
            this.Property(t => t.InvestmentIncome).HasColumnName("InvestmentIncome");
            this.Property(t => t.ReturnOnCapital).HasColumnName("ReturnOnCapital");
            this.Property(t => t.UWWorkbookFullPath).HasColumnName("UWWorkbookFullPath");
            this.Property(t => t.UWWorkbookMDrivePath).HasColumnName("UWWorkbookMDrivePath");
            this.Property(t => t.ServerName).HasColumnName("ServerName");
            this.Property(t => t.DatabaseName).HasColumnName("DatabaseName");
            this.Property(t => t.AnalysisID).HasColumnName("AnalysisID");
            this.Property(t => t.ResultSetKey).HasColumnName("ResultSetKey");
            this.Property(t => t.AnalysisName).HasColumnName("AnalysisName");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.Modifiedby).HasColumnName("Modifiedby");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            this.Property(t => t.LayerNumber).HasColumnName("LayerNumber");
            this.Property(t => t.CatLoss).HasColumnName("CatLoss");
            this.Property(t => t.CoverageType).HasColumnName("CoverageType");
            this.Property(t => t.MinPremiumPercentage).HasColumnName("MinPremiumPercentage");
            this.Property(t => t.DepositPremiumPercentage).HasColumnName("DepositPremiumPercentage");
            this.Property(t => t.RateOnTIV).HasColumnName("RateOnTIV");
            this.Property(t => t.RateOnPremium).HasColumnName("RateOnPremium");
            this.Property(t => t.ExportedToGemini).HasColumnName("ExportedToGemini");
            this.Property(t => t.AggregateDeductible).HasColumnName("AggregateDeductible");
            this.Property(t => t.UnderwriterCategory).HasColumnName("UnderwriterCategory");
            this.Property(t => t.NonCatLossPercentage).HasColumnName("NonCatLossPercentage");
            this.Property(t => t.SnapshotID).HasColumnName("SnapshotID");
            this.Property(t => t.LayerStatusID).HasColumnName("LayerStatusID");
            this.Property(t => t.isActive).HasColumnName("isActive");
            this.Property(t => t.RemetricaModelName).HasColumnName("RemetricaModelName");
            this.Property(t => t.RemetricaTrials).HasColumnName("RemetricaTrials");
            this.Property(t => t.RemetricaBlend).HasColumnName("RemetricaBlend");
            this.Property(t => t.RemetricaMTRLayer).HasColumnName("RemetricaMTRLayer");
            this.Property(t => t.RemetricaLTRLayer).HasColumnName("RemetricaLTRLayer");

            // Relationships
            this.HasOptional(t => t.ProgramStatu)
                .WithMany(t => t.Layers)
                .HasForeignKey(d => d.LayerStatusID);
            this.HasRequired(t => t.PricingStageType)
                .WithMany(t => t.Layers)
                .HasForeignKey(d => d.PricingStageTypeID);
            this.HasOptional(t => t.Program)
                .WithMany(t => t.Layers)
                .HasForeignKey(d => d.ProgramID);
            this.HasOptional(t => t.Snapshot)
                .WithMany(t => t.Layers)
                .HasForeignKey(d => d.SnapshotID);

        }
    }
}
