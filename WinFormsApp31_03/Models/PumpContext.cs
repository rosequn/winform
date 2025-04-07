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
            entity.HasKey(e => e.AlertId).HasName("PK__Alerts__EBB16AEDC2F9AC73");

            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.AlertMessage).HasMaxLength(500);
            entity.Property(e => e.AlertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PumpId).HasColumnName("PumpID");
            entity.Property(e => e.ResolvedTime).HasColumnType("datetime");

            entity.HasOne(d => d.Pump).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.PumpId)
                .HasConstraintName("FK__Alerts__PumpID__693CA210");

            entity.HasOne(d => d.ResolvedByNavigation).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.ResolvedBy)
                .HasConstraintName("FK__Alerts__Resolved__6D0D32F4");
        });

        modelBuilder.Entity<MaintenanceHistory>(entity =>
        {
            entity.HasKey(e => e.MaintenanceId).HasName("PK__Maintena__E60542B58861E794");

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
                .HasConstraintName("FK__Maintenan__Perfo__656C112C");

            entity.HasOne(d => d.Pump).WithMany(p => p.MaintenanceHistories)
                .HasForeignKey(d => d.PumpId)
                .HasConstraintName("FK__Maintenan__PumpI__628FA481");
        });

        modelBuilder.Entity<Pump>(entity =>
        {
            entity.HasKey(e => e.PumpId).HasName("PK__Pumps__5CC3F60551089F63");

            entity.Property(e => e.PumpId).HasColumnName("PumpID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Manufacturer).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PumpName).HasMaxLength(100);
            entity.Property(e => e.SerialNumber).HasMaxLength(100);
            entity.Property(e => e.StationId).HasColumnName("StationID");
            entity.Property(e => e.WarrantyExpireDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PumpCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Pumps__CreatedBy__59063A47");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PumpModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Pumps__ModifiedB__5AEE82B9");

            entity.HasOne(d => d.Station).WithMany(p => p.Pumps)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("FK__Pumps__StationID__5629CD9C");
        });

        modelBuilder.Entity<PumpStation>(entity =>
        {
            entity.HasKey(e => e.StationId).HasName("PK__PumpStat__E0D8A6DD6FC0D4AF");

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
                .HasConstraintName("FK__PumpStati__Creat__5165187F");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PumpStationModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__PumpStati__Modif__534D60F1");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC65DCE851");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E4D9730C1D").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
