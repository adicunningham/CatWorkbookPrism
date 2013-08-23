using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class SnapshotMap : EntityTypeConfiguration<Snapshot>
    {
        public SnapshotMap()
        {
            // Primary Key
            this.HasKey(t => t.SnapshotID);

            // Properties
            this.Property(t => t.SnapshotName)
                .HasMaxLength(255);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(255);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Snapshot");
            this.Property(t => t.SnapshotID).HasColumnName("SnapshotID");
            this.Property(t => t.SnapshotName).HasColumnName("SnapshotName");
            this.Property(t => t.ProgramID).HasColumnName("ProgramID");
            this.Property(t => t.ParentSnapshotID).HasColumnName("ParentSnapshotID");
            this.Property(t => t.PricingStageTypeID).HasColumnName("PricingStageTypeID");
            this.Property(t => t.isOption).HasColumnName("isOption");
            this.Property(t => t.isActive).HasColumnName("isActive");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            this.Property(t => t.Disabled).HasColumnName("Disabled");

            // Relationships
            this.HasOptional(t => t.PricingStageType)
                .WithMany(t => t.Snapshots)
                .HasForeignKey(d => d.PricingStageTypeID);
            this.HasOptional(t => t.Program)
                .WithMany(t => t.Snapshots)
                .HasForeignKey(d => d.ProgramID);
            this.HasOptional(t => t.Snapshot2)
                .WithMany(t => t.Snapshot1)
                .HasForeignKey(d => d.ParentSnapshotID);

        }
    }
}
