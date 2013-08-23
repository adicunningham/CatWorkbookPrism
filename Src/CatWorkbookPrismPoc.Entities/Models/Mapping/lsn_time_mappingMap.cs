using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class lsn_time_mappingMap : EntityTypeConfiguration<lsn_time_mapping>
    {
        public lsn_time_mappingMap()
        {
            // Primary Key
            this.HasKey(t => t.start_lsn);

            // Properties
            this.Property(t => t.start_lsn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.tran_id)
                .HasMaxLength(10);

            this.Property(t => t.tran_begin_lsn)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("lsn_time_mapping", "cdc");
            this.Property(t => t.start_lsn).HasColumnName("start_lsn");
            this.Property(t => t.tran_begin_time).HasColumnName("tran_begin_time");
            this.Property(t => t.tran_end_time).HasColumnName("tran_end_time");
            this.Property(t => t.tran_id).HasColumnName("tran_id");
            this.Property(t => t.tran_begin_lsn).HasColumnName("tran_begin_lsn");
        }
    }
}
