using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class KeySP
    {
        [Key]
        public int Id { get; set; }
        public string KeyName { get; set; }
        public string KeyInfo { get; set; }
        public DateTime NgayTao { get; set; }
        public byte TrangThaiKey { get; set; }

    }
}
