using System;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class BinhLuan
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SanPhamId { get; set; }
        public int ParentId { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
