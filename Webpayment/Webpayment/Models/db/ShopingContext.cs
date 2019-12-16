using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Webpayment.Models.db
{
    public partial class ShopingContext : DbContext
    {
        public ShopingContext()
        {
        }

        public ShopingContext(DbContextOptions<ShopingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Shoping;TrusTed_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.IdCus);

                entity.Property(e => e.IdCus).HasColumnName("ID_Cus");

                entity.Property(e => e.AddressCus)
                    .HasColumnName("Address_Cus")
                    .HasMaxLength(200);

                entity.Property(e => e.LastnameCus).HasMaxLength(50);

                entity.Property(e => e.NameCus).HasMaxLength(50);

                entity.Property(e => e.TelCus)
                    .HasColumnName("Tel_Cus")
                    .HasMaxLength(13);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.IdPay);

                entity.Property(e => e.IdPay).HasColumnName("ID_pay");

                entity.Property(e => e.IdCus).HasColumnName("ID_Cus");

                entity.Property(e => e.IdProduct).HasColumnName("ID_Product");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("Payment_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.Property(e => e.IdProduct).HasColumnName("ID_Product");

                entity.Property(e => e.Image).HasMaxLength(300);

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdStatus)
                    .HasColumnName("ID_Status")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NameStatus)
                    .HasColumnName("Name_Status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("user");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                entity.Property(e => e.Image).HasMaxLength(300);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
