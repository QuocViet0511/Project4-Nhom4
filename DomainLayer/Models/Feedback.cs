using System;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
