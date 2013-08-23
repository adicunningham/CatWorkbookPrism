using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class PricingStageType_Audit_CTMap : EntityTypeConfiguration<PricingStageType_Audit_CT>
    {
        public PricingStageType_Audit_CTMap()
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

            this.Property(t => t.PricingStage)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PricingStageType_Audit_CT", "cdc");
            this.Property(t => t.C___start_lsn).HasColumnName("__$start_lsn");
            this.Property(t => t.C___end_lsn).HasColumnName("__$end_lsn");
            this.Property(t => t.C___seqval).HasColumnName("__$seqval");
            this.Property(t => t.C___operation).HasColumnName("__$operation");
            this.Property(t => t.C___update_mask).HasColumnName("__$update_mask");
            this.Property(t => t.PricingStageTypeID).HasColumnName("PricingStageTypeID");
            this.Property(t => t.PricingStage).HasColumnName("PricingStage");
        }
    }
}
