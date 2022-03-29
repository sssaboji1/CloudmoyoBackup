using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApi.Models
{
    public partial class EmployeeCRUDContext : DbContext
    {
        public EmployeeCRUDContext()
        {
        }

        public EmployeeCRUDContext(DbContextOptions<EmployeeCRUDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public virtual DbSet<EmployeeMaster> EmployeeMasters { get; set; }
        public virtual DbSet<EmployeeShiftRelationship> EmployeeShiftRelationships { get; set; }
        public virtual DbSet<ShiftMaster> ShiftMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\.;Initial Catalog=Employee CRUD");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DepartmentMaster>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK__Departme__B2079BCD77836348");

                entity.ToTable("DepartmentMaster");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeMaster>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF1AAA18AD2");

                entity.ToTable("EmployeeMaster");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate).HasColumnType("datetime");

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeMasters)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__EmployeeM__Depar__2B3F6F97");
            });

            modelBuilder.Entity<EmployeeShiftRelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId)
                    .HasName("PK__Employee__31FEB8610C869A2B");

                entity.ToTable("EmployeeShiftRelationship");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeShiftRelationships)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__EmployeeS__Emplo__300424B4");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.EmployeeShiftRelationships)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("FK__EmployeeS__Shift__30F848ED");
            });

            modelBuilder.Entity<ShiftMaster>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PK__ShiftMas__C0A838E1FE0B6BFC");

                entity.ToTable("ShiftMaster");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Modifieddate).HasColumnType("datetime");

                entity.Property(e => e.ShiftEndTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftStartTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
