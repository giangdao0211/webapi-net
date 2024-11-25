﻿using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options):base(options)
        {

        }
        #region DbSet
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChitietDonHangs { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>(e =>
            {
                e.ToTable("Don Hang");
                e.HasKey(dh => dh.MaDh);
                e.Property(dh => dh.NgayDat).HasDefaultValueSql("getutcdate()");
            });
            modelBuilder.Entity<ChiTietDonHang>(entity =>
            {
                entity.ToTable("ChiTietDonHang");
                entity.HasKey(e => new { e.MaDh, e.MaHh });
                entity.HasOne(e => e.DonHang).WithMany(e => e.chiTietDonHangs).HasForeignKey(e => e.MaDh).HasConstraintName("FK_DonHangCT_DonHang");
                entity.HasOne(e => e.HangHoa).WithMany(e => e.chiTietDonHangs).HasForeignKey(e => e.MaHh).HasConstraintName("FK_DonHangCT_HangHoa");
            });
        }
    }
}
