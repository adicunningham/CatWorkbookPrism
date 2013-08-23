using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CatWorkbookPrismPoc.Entities.Models.Mapping
{
    public class ErrorLogMap : EntityTypeConfiguration<ErrorLog>
    {
        public ErrorLogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogID);

            // Properties
            this.Property(t => t.UserID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ErrorLog");
            this.Property(t => t.LogID).HasColumnName("LogID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
        }
    }
}
