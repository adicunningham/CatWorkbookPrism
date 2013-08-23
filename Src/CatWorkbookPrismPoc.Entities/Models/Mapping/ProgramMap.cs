using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class ProgramMap : EntityTypeConfiguration<Program>
    {
        public ProgramMap()
        {
            // Primary Key
            this.HasKey(t => t.ProgramID);

            // Properties
            this.Property(t => t.ProgramID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QuoteStatus)
                .HasMaxLength(50);

            this.Property(t => t.AuthorizedStatus)
                .HasMaxLength(50);

            this.Property(t => t.BoundStatus)
                .HasMaxLength(50);

            this.Property(t => t.ProgramName)
                .HasMaxLength(200);

            this.Property(t => t.ClientName)
                .HasMaxLength(200);

            this.Property(t => t.UnderwriterName)
                .HasMaxLength(50);

            this.Property(t => t.TeamName)
                .HasMaxLength(50);

            this.Property(t => t.MasterNumber)
                .HasMaxLength(100);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(200);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Program");
            this.Property(t => t.ProgramID).HasColumnName("ProgramID");
            this.Property(t => t.UnderwriterID).HasColumnName("UnderwriterID");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.TeamID).HasColumnName("TeamID");
            this.Property(t => t.ExpiringProgramID).HasColumnName("ExpiringProgramID");
            this.Property(t => t.QuoteStructureID).HasColumnName("QuoteStructureID");
            this.Property(t => t.QuoteExpiringStructureID).HasColumnName("QuoteExpiringStructureID");
            this.Property(t => t.AuthorizedExpiringStructureID).HasColumnName("AuthorizedExpiringStructureID");
            this.Property(t => t.QuoteStatus).HasColumnName("QuoteStatus");
            this.Property(t => t.AuthorizedStatus).HasColumnName("AuthorizedStatus");
            this.Property(t => t.BoundStatus).HasColumnName("BoundStatus");
            this.Property(t => t.ProgramName).HasColumnName("ProgramName");
            this.Property(t => t.ClientName).HasColumnName("ClientName");
            this.Property(t => t.UnderwriterName).HasColumnName("UnderwriterName");
            this.Property(t => t.TeamName).HasColumnName("TeamName");
            this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
            this.Property(t => t.ExpirationDate).HasColumnName("ExpirationDate");
            this.Property(t => t.MasterNumber).HasColumnName("MasterNumber");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        }
    }
}
