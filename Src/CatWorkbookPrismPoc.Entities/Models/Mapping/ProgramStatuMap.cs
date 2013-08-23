using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class ProgramStatuMap : EntityTypeConfiguration<ProgramStatu>
    {
        public ProgramStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.ProgramStatusID);

            // Properties
            this.Property(t => t.ProgramStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProgramStatus)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProgramStatus");
            this.Property(t => t.ProgramStatusID).HasColumnName("ProgramStatusID");
            this.Property(t => t.ProgramStatus).HasColumnName("ProgramStatus");
            this.Property(t => t.Rank).HasColumnName("Rank");
        }
    }
}
