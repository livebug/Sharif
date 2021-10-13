using Blog.Api.Models;
using IBM.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog.Api.Contexts
{
#nullable disable

    public partial class ShadbContext : DbContext
    {
        public ShadbContext(DbContextOptions<ShadbContext> options): base(options)
        {
        }
        public virtual DbSet<AreaCode> AreaCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("SQL210919122713190")
                    .ForDb2IsClustered(false);

                entity.ToTable("AREACODE", "SHA");

                entity.Property(e => e.Code)
                    .HasMaxLength(12)
                    .HasPrecision(12)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Catalog)
                    .HasMaxLength(255)
                    .HasPrecision(255)
                    .IsUnicode(false)
                    .HasColumnName("CATALOG");

                entity.Property(e => e.Dartetime)
                    .HasMaxLength(10)
                    .HasPrecision(10)
                    .HasColumnName("DARTETIME");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasPrecision(255)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ParentCode)
                    .HasMaxLength(12)
                    .HasPrecision(12)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_CODE");

                entity.Property(e => e.ShortCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasPrecision(12)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_CODE");

                entity.Property(e => e.Sub)
                    .HasColumnType("integer(4)")
                    .HasColumnName("SUB");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasPrecision(1)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Version)
                    .HasMaxLength(4)
                    .HasPrecision(4)
                    .IsUnicode(false)
                    .HasColumnName("VERSION");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
