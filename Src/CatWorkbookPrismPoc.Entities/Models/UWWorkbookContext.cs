using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CatWorkbookPrismPoc.Entities.Models.Mapping;

namespace CatWorkbookPrismPoc.Entities.Models
{
    public partial class UWWorkbookContext : DbContext
    {
        static UWWorkbookContext()
        {
            Database.SetInitializer<UWWorkbookContext>(null);
        }

        public UWWorkbookContext()
            : base("Name=UWWorkbookContext")
        {
        }

        public DbSet<captured_columns> captured_columns { get; set; }
        public DbSet<change_tables> change_tables { get; set; }
        public DbSet<ddl_history> ddl_history { get; set; }
        public DbSet<index_columns> index_columns { get; set; }
        public DbSet<Layer_Audit_CT> Layer_Audit_CT { get; set; }
        public DbSet<lsn_time_mapping> lsn_time_mapping { get; set; }
        public DbSet<PricingStageType_Audit_CT> PricingStageType_Audit_CT { get; set; }
        public DbSet<ProgramNotes_Audit_CT> ProgramNotes_Audit_CT { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<Layer> Layers { get; set; }
        public DbSet<NamedRange> NamedRanges { get; set; }
        public DbSet<PricingStageType> PricingStageTypes { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<ProgramNote> ProgramNotes { get; set; }
        public DbSet<ProgramSession> ProgramSessions { get; set; }
        public DbSet<ProgramStatu> ProgramStatus { get; set; }
        public DbSet<Snapshot> Snapshots { get; set; }
        public DbSet<static_servers> static_servers { get; set; }
        public DbSet<systranschema> systranschemas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new captured_columnsMap());
            modelBuilder.Configurations.Add(new change_tablesMap());
            modelBuilder.Configurations.Add(new ddl_historyMap());
            modelBuilder.Configurations.Add(new index_columnsMap());
            modelBuilder.Configurations.Add(new Layer_Audit_CTMap());
            modelBuilder.Configurations.Add(new lsn_time_mappingMap());
            modelBuilder.Configurations.Add(new PricingStageType_Audit_CTMap());
            modelBuilder.Configurations.Add(new ProgramNotes_Audit_CTMap());
            modelBuilder.Configurations.Add(new ErrorLogMap());
            modelBuilder.Configurations.Add(new LayerMap());
            modelBuilder.Configurations.Add(new NamedRangeMap());
            modelBuilder.Configurations.Add(new PricingStageTypeMap());
            modelBuilder.Configurations.Add(new ProgramMap());
            modelBuilder.Configurations.Add(new ProgramNoteMap());
            modelBuilder.Configurations.Add(new ProgramSessionMap());
            modelBuilder.Configurations.Add(new ProgramStatuMap());
            modelBuilder.Configurations.Add(new SnapshotMap());
            modelBuilder.Configurations.Add(new static_serversMap());
            modelBuilder.Configurations.Add(new systranschemaMap());
        }
    }
}
