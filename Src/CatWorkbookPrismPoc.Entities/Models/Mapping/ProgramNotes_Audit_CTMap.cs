using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class ProgramNotes_Audit_CTMap : EntityTypeConfiguration<ProgramNotes_Audit_CT>
    {
        public ProgramNotes_Audit_CTMap()
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

            this.Property(t => t.CreatedBy)
                .HasMaxLength(200);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ProgramNotes_Audit_CT", "cdc");
            this.Property(t => t.C___start_lsn).HasColumnName("__$start_lsn");
            this.Property(t => t.C___end_lsn).HasColumnName("__$end_lsn");
            this.Property(t => t.C___seqval).HasColumnName("__$seqval");
            this.Property(t => t.C___operation).HasColumnName("__$operation");
            this.Property(t => t.C___update_mask).HasColumnName("__$update_mask");
            this.Property(t => t.ProgramNotesID).HasColumnName("ProgramNotesID");
            this.Property(t => t.ProgramID).HasColumnName("ProgramID");
            this.Property(t => t.NoteTypeID).HasColumnName("NoteTypeID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
        }
    }
}
