using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class ProgramNoteMap : EntityTypeConfiguration<ProgramNote>
    {
        public ProgramNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.ProgramNotesID);

            // Properties
            this.Property(t => t.CreatedBy)
                .HasMaxLength(200);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ProgramNotes");
            this.Property(t => t.ProgramNotesID).HasColumnName("ProgramNotesID");
            this.Property(t => t.ProgramID).HasColumnName("ProgramID");
            this.Property(t => t.NoteTypeID).HasColumnName("NoteTypeID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");

            // Relationships
            this.HasRequired(t => t.Program)
                .WithMany(t => t.ProgramNotes)
                .HasForeignKey(d => d.ProgramID);

        }
    }
}
