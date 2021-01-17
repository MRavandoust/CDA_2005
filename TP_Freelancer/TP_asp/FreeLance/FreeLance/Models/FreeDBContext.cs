using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FreeLance.Models
{
    public partial class FreeDBContext : DbContext
    {
        public FreeDBContext()
        {
        }

        public FreeDBContext(DbContextOptions<FreeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomersCat> CustomersCats { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FreeDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CatId).HasColumnName("Cat_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Customers_Cats");
            });

            modelBuilder.Entity<CustomersCat>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("Customers_Cats");

                entity.Property(e => e.CatId).HasColumnName("Cat_Id");

                entity.Property(e => e.CatDescription)
                    .HasColumnType("text")
                    .HasColumnName("Cat_Description");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Cat_Name");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId).HasColumnName("Job_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.JobDescription)
                    .HasColumnType("text")
                    .HasColumnName("Job_Description");

                entity.Property(e => e.JobEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Job_End");

                entity.Property(e => e.JobStart)
                    .HasColumnType("datetime")
                    .HasColumnName("Job_Start");

                entity.Property(e => e.JobState)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Job_State");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Job_Title");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jobs_Customers");
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.Property(e => e.QuoteId).HasColumnName("Quote_Id");

                entity.Property(e => e.JobId).HasColumnName("Job_id");

                entity.Property(e => e.QuoteAmount).HasColumnName("Quote_Amount");

                entity.Property(e => e.QuoteDate)
                    .HasColumnType("date")
                    .HasColumnName("Quote_Date");

                entity.Property(e => e.QuoteFinalAmount).HasColumnName("Quote_Final_Amount");

                entity.Property(e => e.QuoteFinalDate)
                    .HasColumnType("date")
                    .HasColumnName("Quote_Final_Date");

                entity.Property(e => e.QuoteState)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Quote_State");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quotes_Jobs");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
