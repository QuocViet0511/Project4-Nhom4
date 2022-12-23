using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class DanhMucSanPham 
    {
        [Key]
        public int Id { get; set; }
        public string TenDanhMuc { get; set; }
        public string ThongTin { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
    }
}
