using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        public string RollNo { get; set; }
        public int DanhMucSanPhamId { get; set; }
        public string TenSanPham { get; set; }
        public string ThongTin { get; set; }
        public string Image { get; set; }
        public decimal GiaTien { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
        public int GiamGiaId { get; set; }
    }
}
