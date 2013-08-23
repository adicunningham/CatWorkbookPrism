using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class ddl_historyMap : EntityTypeConfiguration<ddl_history>
    {
        public ddl_historyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.object_id, t.ddl_lsn });

            // Properties
            this.Property(t => t.object_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ddl_lsn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ddl_history", "cdc");
            this.Property(t => t.source_object_id).HasColumnName("source_object_id");
            this.Property(t => t.object_id).HasColumnName("object_id");
            this.Property(t => t.required_column_update).HasColumnName("required_column_update");
            this.Property(t => t.ddl_command).HasColumnName("ddl_command");
            this.Property(t => t.ddl_lsn).HasColumnName("ddl_lsn");
            this.Property(t => t.ddl_time).HasColumnName("ddl_time");
        }
    }
}
