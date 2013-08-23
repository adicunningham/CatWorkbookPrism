using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class ProgramSessionMap : EntityTypeConfiguration<ProgramSession>
    {
        public ProgramSessionMap()
        {
            // Primary Key
            this.HasKey(t => t.ProgramSessionID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProgramSession");
            this.Property(t => t.ProgramSessionID).HasColumnName("ProgramSessionID");
            this.Property(t => t.ProgramID).HasColumnName("ProgramID");
            this.Property(t => t.ProgramStatusID).HasColumnName("ProgramStatusID");
            this.Property(t => t.QuoteSnapshotID).HasColumnName("QuoteSnapshotID");
            this.Property(t => t.AuthorizedSnapshotID).HasColumnName("AuthorizedSnapshotID");
            this.Property(t => t.FotSnapshotID).HasColumnName("FotSnapshotID");
            this.Property(t => t.BoundSnapshotID).HasColumnName("BoundSnapshotID");
        }
    }
}
