using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppBook.Models.db
{
    public partial class BookShopContext : DbContext
    {
        public BookShopContext()
        {
        }

        public BookShopContext(DbContextOptions<BookShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BookShop;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.IdCustomers);

                entity.Property(e => e.IdCustomers).HasColumnName("ID_Customers");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(13);
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.IdPayments);

                entity.Property(e => e.IdPayments).HasColumnName("ID_Payments");

                entity.Property(e => e.DatePayments)
                    .HasColumnName("Date_Payments")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCustomers).HasColumnName("ID_Customers");

                entity.Property(e => e.IdProducts).HasColumnName("ID_Products");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.IdProducts);

                entity.Property(e => e.IdProducts).HasColumnName("ID_Products");

                entity.Property(e => e.Image).HasMaxLength(300);

                entity.Property(e => e.ProductsName)
                    .HasColumnName("Products_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                entity.Property(e => e.Status1)
                    .HasColumnName("Status")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
