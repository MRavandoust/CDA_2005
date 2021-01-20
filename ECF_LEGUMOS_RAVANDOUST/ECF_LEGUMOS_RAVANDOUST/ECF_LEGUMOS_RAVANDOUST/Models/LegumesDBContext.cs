using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ECF_LEGUMOS_RAVANDOUST.Models
{
    public partial class LegumesDBContext : DbContext
    {
        public LegumesDBContext()
        {
        }

        public LegumesDBContext(DbContextOptions<LegumesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Vegetable> Vegetables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(e => e.SaleActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SaleDate).HasColumnType("date");

                entity.Property(e => e.SaleUnitPrice).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Vegetable)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.VegetableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sales__Vegetable__2E1BDC42");
            });

            modelBuilder.Entity<Vegetable>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryColor)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Variety)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
