﻿using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<SoLuongGioHang> SoLuongGioHang { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<KeySP> KeySP { get; set; }
        public  DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<GiamGia> GiamGia { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPham { get; set; }
        public virtual DbSet<BinhLuan> BinhLuan { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<BaiViet> BaiViet { get; set; }


    }
}
