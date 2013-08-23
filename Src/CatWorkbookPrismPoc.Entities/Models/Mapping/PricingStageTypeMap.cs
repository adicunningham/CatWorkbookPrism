using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class PricingStageTypeMap : EntityTypeConfiguration<PricingStageType>
    {
        public PricingStageTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PricingStageTypeID);

            // Properties
            this.Property(t => t.PricingStageTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PricingStage)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PricingStageType");
            this.Property(t => t.PricingStageTypeID).HasColumnName("PricingStageTypeID");
            this.Property(t => t.PricingStage).HasColumnName("PricingStage");
        }
    }
}
