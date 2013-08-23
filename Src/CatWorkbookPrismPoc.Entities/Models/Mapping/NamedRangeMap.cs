using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class NamedRangeMap : EntityTypeConfiguration<NamedRange>
    {
        public NamedRangeMap()
        {
            // Primary Key
            this.HasKey(t => t.NamedRangeID);

            // Properties
            this.Property(t => t.SheetName)
                .HasMaxLength(255);

            this.Property(t => t.RangeName)
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(255);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NamedRange");
            this.Property(t => t.NamedRangeID).HasColumnName("NamedRangeID");
            this.Property(t => t.SheetName).HasColumnName("SheetName");
            this.Property(t => t.RangeName).HasColumnName("RangeName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsLocked).HasColumnName("IsLocked");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        }
    }
}
