using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class index_columnsMap : EntityTypeConfiguration<index_columns>
    {
        public index_columnsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.object_id, t.index_ordinal });

            // Properties
            this.Property(t => t.object_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.column_name)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("index_columns", "cdc");
            this.Property(t => t.object_id).HasColumnName("object_id");
            this.Property(t => t.column_name).HasColumnName("column_name");
            this.Property(t => t.index_ordinal).HasColumnName("index_ordinal");
            this.Property(t => t.column_id).HasColumnName("column_id");
        }
    }
}
