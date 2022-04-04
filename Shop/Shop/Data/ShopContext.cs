using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Shop.Models;

namespace Shop.Data
{
    public partial class ShopContext : DbContext
    {
        public ShopContext()
        {
        }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<ProductCatview> ProductCatview { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=182.163.100.230;Database=Shop;User Id=sa;Password=p!0n33r@23#");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.CCode).IsFixedLength();

                entity.Property(e => e.CName).IsFixedLength();
            });

            modelBuilder.Entity<ProductCatview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductCatview");

                entity.Property(e => e.CCode).IsFixedLength();

                entity.Property(e => e.CName).IsFixedLength();

                entity.Property(e => e.PCode).IsFixedLength();

                entity.Property(e => e.PName).IsFixedLength();
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.PCode).IsFixedLength();

                entity.Property(e => e.CCode).IsFixedLength();

                entity.Property(e => e.PName).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
