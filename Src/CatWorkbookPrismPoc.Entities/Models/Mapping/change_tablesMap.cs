using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class change_tablesMap : EntityTypeConfiguration<change_tables>
    {
        public change_tablesMap()
        {
            // Primary Key
            this.HasKey(t => t.object_id);

            // Properties
            this.Property(t => t.object_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.capture_instance)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.start_lsn)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.end_lsn)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.role_name)
                .HasMaxLength(128);

            this.Property(t => t.index_name)
                .HasMaxLength(128);

            this.Property(t => t.filegroup_name)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("change_tables", "cdc");
            this.Property(t => t.object_id).HasColumnName("object_id");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.source_object_id).HasColumnName("source_object_id");
            this.Property(t => t.capture_instance).HasColumnName("capture_instance");
            this.Property(t => t.start_lsn).HasColumnName("start_lsn");
            this.Property(t => t.end_lsn).HasColumnName("end_lsn");
            this.Property(t => t.supports_net_changes).HasColumnName("supports_net_changes");
            this.Property(t => t.has_drop_pending).HasColumnName("has_drop_pending");
            this.Property(t => t.role_name).HasColumnName("role_name");
            this.Property(t => t.index_name).HasColumnName("index_name");
            this.Property(t => t.filegroup_name).HasColumnName("filegroup_name");
            this.Property(t => t.create_date).HasColumnName("create_date");
            this.Property(t => t.partition_switch).HasColumnName("partition_switch");
        }
    }
}
