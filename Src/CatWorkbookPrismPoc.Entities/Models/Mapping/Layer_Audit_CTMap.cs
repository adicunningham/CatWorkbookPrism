using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class Layer_Audit_CTMap : EntityTypeConfiguration<Layer_Audit_CT>
    {
        public Layer_Audit_CTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.C___start_lsn, t.C___seqval, t.C___operation });

            // Properties
            this.Property(t => t.C___start_lsn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.C___end_lsn)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.C___seqval)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.C___operation)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.C___update_mask)
                .HasMaxLength(128);

            this.Property(t => t.RemetricaLayer)
                .HasMaxLength(100);

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

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(200);

            this.Property(t => t.Modifiedby)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Layer_Audit_CT", "cdc");
            this.Property(t => t.C___start_lsn).HasColumnName("__$start_lsn");
            this.Property(t => t.C___end_lsn).HasColumnName("__$end_lsn");
            this.Property(t => t.C___seqval).HasColumnName("__$seqval");
            this.Property(t => t.C___operation).HasColumnName("__$operation");
            this.Property(t => t.C___update_mask).HasColumnName("__$update_mask");
            this.Property(t => t.PricingLayerID).HasColumnName("PricingLayerID");
            this.Property(t => t.PricingStageTypeID).HasColumnName("PricingStageTypeID");
            this.Property(t => t.StructureID).HasColumnName("StructureID");
            this.Property(t => t.ProgramID).HasColumnName("ProgramID");
            this.Property(t => t.LayerID).HasColumnName("LayerID");
            this.Property(t => t.RemetricaLayer).HasColumnName("RemetricaLayer");
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
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.Modifiedby).HasColumnName("Modifiedby");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            this.Property(t => t.LayerNumber).HasColumnName("LayerNumber");
            this.Property(t => t.CatLoss).HasColumnName("CatLoss");
        }
    }
}
