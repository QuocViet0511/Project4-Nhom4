using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class GioHang
    {
        [Key]
        public int Id { get; set; }
        public string SanPhamId { get; set; }
        public int UserId { get; set; }
        public int SoLuong { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
