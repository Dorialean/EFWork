using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFWork.Models
{
    public partial class macdonaldsWorkContext : DbContext
    {
        public macdonaldsWorkContext()
        {
        }

        public macdonaldsWorkContext(DbContextOptions<macdonaldsWorkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-GMJN9AI\\SQLEXPRESS;Encrypt=false;Database=macdonaldsWork;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocumentsPackId)
                    .HasName("PK__Document__2104C85E41EBEFF1");

                entity.HasIndex(e => e.PasportId, "UQ__Document__07E30CA0F29E4E30")
                    .IsUnique();

                entity.HasIndex(e => e.MedicalBook, "UQ__Document__2D66F6430DB004A5")
                    .IsUnique();

                entity.HasIndex(e => e.ControlListId, "UQ__Document__4CE954544317CD4D")
                    .IsUnique();

                entity.HasIndex(e => e.Snils, "UQ__Document__7EB2A6F9C32908ED")
                    .IsUnique();

                entity.HasIndex(e => e.EmploementHistory, "UQ__Document__A81A8E1A90305683")
                    .IsUnique();

                entity.Property(e => e.DocumentsPackId).ValueGeneratedNever();

                entity.Property(e => e.Snils).HasColumnName("SNILS");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.TableNumberId)
                    .HasName("PK__Employee__EB6F9EC90E204A3B");

                entity.ToTable("Employee");

                entity.Property(e => e.TableNumberId).ValueGeneratedNever();

                entity.Property(e => e.DateOfPromotion).HasColumnType("date");

                entity.Property(e => e.FatherName).HasMaxLength(30);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.SizeOfClothes)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.HasOne(d => d.DocumentsPack)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DocumentsPackId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Employee__Docume__403A8C7D");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Employee__PostId__412EB0B6");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(e => e.JobTitle, "UQ__Posts__44C68B9F5CAFB844")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.JobTitle).HasMaxLength(30);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
