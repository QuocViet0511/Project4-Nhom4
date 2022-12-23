using System;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class KeySP
    {
        [Key]
        public int Id { get; set; }
        public int SanPhamId { get; set; }
        public string KeyName { get; set; }
        public string KeyInfo { get; set; }
        public DateTime NgayTao { get; set; }
        public byte TrangThaiKey { get; set; }

    }
}
