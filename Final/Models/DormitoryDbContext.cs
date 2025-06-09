using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Final.Models;

public partial class DormitoryDbContext : DbContext
{
    public DormitoryDbContext()
    {
    }

    public DormitoryDbContext(DbContextOptions<DormitoryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Block> Blocks { get; set; }

    public virtual DbSet<Dormitory> Dormitories { get; set; }

    public virtual DbSet<Repair> Repairs { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomAsset> RoomAssets { get; set; }

    public virtual DbSet<RoomAssigment> RoomAssigments { get; set; }

    public virtual DbSet<StudentAsset> StudentAssets { get; set; }

    public virtual DbSet<SubstituteStudentAsset> SubstituteStudentAssets { get; set; }

    public virtual DbSet<TransferRoomAssetHistory> TransferRoomAssetHistorys { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-GUGI795;User ID=sa;Database=DormitoryDb;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Block>(entity =>
        {
            entity.Property(e => e.CreatOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(256);

            entity.HasOne(d => d.CreatByNavigation).WithMany(p => p.Blocks)
                .HasForeignKey(d => d.CreatBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Blocks_Users");

            entity.HasOne(d => d.Dermitory).WithMany(p => p.Blocks)
                .HasForeignKey(d => d.DermitoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Blocks_Dormitories");
        });

        modelBuilder.Entity<Dormitory>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(256);
            entity.Property(e => e.CreatOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(256);

            entity.HasOne(d => d.CreatByNavigation).WithMany(p => p.Dormitories)
                .HasForeignKey(d => d.CreatBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Dormitories_Users");
        });

        modelBuilder.Entity<Repair>(entity =>
        {
            entity.Property(e => e.Discription).HasMaxLength(256);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");

            entity.HasOne(d => d.RoomAsset).WithMany(p => p.Repairs)
                .HasForeignKey(d => d.RoomAssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Repairs_RoomAssets");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Role");

            entity.Property(e => e.CreatOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Role1).HasColumnName("Role");

            entity.HasOne(d => d.Block).WithMany(p => p.Roles)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("FK_Roles_Blocks");

            entity.HasOne(d => d.Dermitory).WithMany(p => p.Roles)
                .HasForeignKey(d => d.DermitoryId)
                .HasConstraintName("FK_Roles_Dormitories");

            entity.HasOne(d => d.User).WithMany(p => p.Roles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Roles_Users");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.Property(e => e.CreatOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Block).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.BlockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rooms_Blocks");

            entity.HasOne(d => d.CreatByNavigation).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.CreatBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rooms_Users");
        });

        modelBuilder.Entity<RoomAsset>(entity =>
        {
            entity.Property(e => e.CreatOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RoomAssigment>(entity =>
        {
            entity.Property(e => e.CreatOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Room).WithMany(p => p.RoomAssigments)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomAssigments_Rooms");

            entity.HasOne(d => d.Student).WithMany(p => p.RoomAssigments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomAssigments_Users");
        });

        modelBuilder.Entity<StudentAsset>(entity =>
        {
            entity.Property(e => e.Discription).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(256);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentAssets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentAssets_Users");
        });

        modelBuilder.Entity<SubstituteStudentAsset>(entity =>
        {
            entity.HasOne(d => d.LastRoomAsset).WithMany(p => p.SubstituteStudentAssets)
                .HasForeignKey(d => d.LastRoomAssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubstituteStudentAssets_RoomAssets");

            entity.HasOne(d => d.Student).WithMany(p => p.SubstituteStudentAssets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubstituteStudentAssets_Users");
        });

        modelBuilder.Entity<TransferRoomAssetHistory>(entity =>
        {
            entity.Property(e => e.CreatOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.RoomAsset).WithMany(p => p.TransferRoomAssetHistories)
                .HasForeignKey(d => d.RoomAssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferRoomAssetHistorys_RoomAssets");

            entity.HasOne(d => d.Room).WithMany(p => p.TransferRoomAssetHistories)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_TransferRoomAssetHistorys_Rooms");

            entity.HasOne(d => d.Student).WithMany(p => p.TransferRoomAssetHistories)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_TransferRoomAssetHistorys_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(256);
            entity.Property(e => e.DeletedTime).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(256);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(256);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(256);
            entity.Property(e => e.PreviousLogin).HasColumnType("datetime");
            entity.Property(e => e.StuPerCode).HasColumnName("Stu_Per_Code");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
