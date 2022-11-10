using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EF_Core_Scaffolding.ef_core_examples_database
{
    public partial class ef_core_examplesContext : DbContext
    {
        public ef_core_examplesContext()
        {
        }

        public ef_core_examplesContext(DbContextOptions<ef_core_examplesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sale> Sales { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;password=test#1234;database=ef_core_examples", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("sales");

                entity.Property(e => e.CostumerName)
                    .HasMaxLength(50)
                    .HasColumnName("Costumer_Name");

                entity.Property(e => e.IsDelivered).HasColumnName("isDelivered");

                entity.Property(e => e.IsPaymentRecieved).HasColumnName("isPaymentRecieved");

                entity.Property(e => e.IsShiped).HasColumnName("isShiped");

                entity.Property(e => e.Product).HasMaxLength(50);

                entity.Property(e => e.ShippingAdress).HasMaxLength(50);

                entity.Property(e => e.Value).HasPrecision(10, 2);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
