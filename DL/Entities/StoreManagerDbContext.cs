using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DL.Entities
{
    public partial class StoreManagerDbContext : DbContext
    {
        public StoreManagerDbContext()
        {
        }

        public StoreManagerDbContext(DbContextOptions<StoreManagerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<LineItems> LineItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<StoreItems> StoreItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__Customer__049E3AA96A9B8717");

                entity.HasIndex(e => e.Email, "UQ__Customer__A9D1053476BE4827")
                    .IsUnique();

                entity.Property(e => e.CustAddress)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.Property(e => e.ItemCatagory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(2, 0)");
            });

            modelBuilder.Entity<LineItems>(entity =>
            {
                entity.HasKey(e => e.LineItemsId)
                    .HasName("PK__LineItem__091CFB71CE0BF0E9");

                entity.Property(e => e.Price).HasColumnType("decimal(38, 0)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__LineItems__ItemI__693CA210");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__LineItems__Order__68487DD7");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(2, 0)");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK__Orders__CustId__6477ECF3");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Orders__StoreId__656C112C");
            });

            modelBuilder.Entity<Stores>(entity =>
            {
                entity.Property(e => e.StoreAddress)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreItems>(entity =>
            {
                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StoreItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("StoreItems_FK_1");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreItems)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("StoreItems_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
