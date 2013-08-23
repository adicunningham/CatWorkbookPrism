using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class captured_columnsMap : EntityTypeConfiguration<captured_columns>
    {
        public captured_columnsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.object_id, t.column_ordinal });

            // Properties
            this.Property(t => t.object_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.column_name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.column_type)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.column_ordinal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("captured_columns", "cdc");
            this.Property(t => t.object_id).HasColumnName("object_id");
            this.Property(t => t.column_name).HasColumnName("column_name");
            this.Property(t => t.column_id).HasColumnName("column_id");
            this.Property(t => t.column_type).HasColumnName("column_type");
            this.Property(t => t.column_ordinal).HasColumnName("column_ordinal");
            this.Property(t => t.is_computed).HasColumnName("is_computed");
        }
    }
}
