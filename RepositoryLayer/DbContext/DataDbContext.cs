using Microsoft.EntityFrameworkCore;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class DataDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<KeySP> KeySP { get; set; }
        public virtual DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<GiamGia> GiamGia { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPham { get; set; }
        public virtual DbSet<BinhLuan> BinhLuan { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<BaiViet> BaiViet { get; set; }

        public DataDbContext(DbContextOptions<DataDbContext> options): base(options) { }

       
    }
}
