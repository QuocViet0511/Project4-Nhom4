using DomainLayer.Models;
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
        public   DbSet<User> Users { get; set; }
         public   DbSet<SanPham> SanPham { get; set; }
        public   DbSet<Role> Role { get; set; }
        public   DbSet<KeySP> KeySP { get; set; }
        public  DbSet<GioHang> GioHang { get; set; }
        public   DbSet<GiamGia> GiamGia { get; set; }
        public   DbSet<Feedback> Feedback { get; set; }
        public   DbSet<DanhMucSanPham> DanhMucSanPham { get; set; }
        public   DbSet<BinhLuan> BinhLuan { get; set; }
        public   DbSet<Banner> Banner { get; set; }
        public   DbSet<BaiViet> BaiViet { get; set; }


    }
}
