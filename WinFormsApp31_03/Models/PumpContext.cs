using Microsoft.EntityFrameworkCore;

namespace WinFormsApp31_03.Models;

public partial class PumpContext : DbContext
{
    public PumpContext()
    {
    }

    public PumpContext(DbContextOptions<PumpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<MaintenanceHistory> MaintenanceHistories { get; set; }

    public virtual DbSet<OperatingData> OperatingData { get; set; }

    public virtual DbSet<Pump> Pumps { get; set; }

    public virtual DbSet<PumpStation> PumpStations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PumpStationManagement;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alert>(entity =>
        {
            entity.HasKey(e => e.AlertId).HasName("PK__Alerts__EBB16AED6132612F");

            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.AlertMessage).HasMaxLength(500);
            entity.Property(e => e.AlertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PumpId).HasColumnName("PumpID");
            entity.Property(e => e.ResolvedTime).HasColumnType("datetime");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.AlertModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Alerts__Modified__74AE54BC");

            entity.HasOne(d => d.Pump).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.PumpId)
                .HasConstraintName("FK__Alerts__PumpID__6E01572D");

            entity.HasOne(d => d.ResolvedByNavigation).WithMany(p => p.AlertResolvedByNavigations)
                .HasForeignKey(d => d.ResolvedBy)
                .HasConstraintName("FK__Alerts__Resolved__72C60C4A");
        });

        modelBuilder.Entity<MaintenanceHistory>(entity =>
        {
            entity.HasKey(e => e.MaintenanceId).HasName("PK__Maintena__E60542B53B6FB91D");

            entity.ToTable("MaintenanceHistory");

            entity.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.PumpId).HasColumnName("PumpID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.PerformedByNavigation).WithMany(p => p.MaintenanceHistories)
                .HasForeignKey(d => d.PerformedBy)
                .HasConstraintName("FK__Maintenan__Perfo__693CA210");

            entity.HasOne(d => d.Pump).WithMany(p => p.MaintenanceHistories)
                .HasForeignKey(d => d.PumpId)
                .HasConstraintName("FK__Maintenan__PumpI__66603565");
        });

        modelBuilder.Entity<OperatingData>(entity =>
        {
            entity.HasKey(e => e.DataId).HasName("PK__Operatin__9D05305D06358B3B");

            entity.Property(e => e.DataId).HasColumnName("DataID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PumpId).HasColumnName("PumpID");
            entity.Property(e => e.RecordTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Pump).WithMany(p => p.OperatingData)
                .HasForeignKey(d => d.PumpId)
                .HasConstraintName("FK__Operating__PumpI__60A75C0F");
        });

        modelBuilder.Entity<Pump>(entity =>
        {
            entity.HasKey(e => e.PumpId).HasName("PK__Pumps__5CC3F6051A076841");

            entity.Property(e => e.PumpId).HasColumnName("PumpID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Manufacturer).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PumpName).HasMaxLength(100);
            entity.Property(e => e.SerialNumber).HasMaxLength(100);
            entity.Property(e => e.StationId).HasColumnName("StationID");
            entity.Property(e => e.WarrantyExpireDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PumpCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Pumps__CreatedBy__5BE2A6F2");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PumpModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Pumps__ModifiedB__5DCAEF64");

            entity.HasOne(d => d.Station).WithMany(p => p.Pumps)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("FK__Pumps__StationID__571DF1D5");
        });

        modelBuilder.Entity<PumpStation>(entity =>
        {
            entity.HasKey(e => e.StationId).HasName("PK__PumpStat__E0D8A6DD8EDB1D45");

            entity.Property(e => e.StationId).HasColumnName("StationID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StationName).HasMaxLength(100);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PumpStationCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__PumpStati__Creat__52593CB8");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PumpStationModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__PumpStati__Modif__5441852A");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACB620384D");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E4386125BC").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
