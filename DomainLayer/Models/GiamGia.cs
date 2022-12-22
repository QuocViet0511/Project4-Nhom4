using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class GiamGia
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ThongTin { get; set; }
        public decimal PhanTramGiamGia { get; set; }
        public byte TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
    }
}
