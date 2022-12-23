using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        public string UrlLink { get; set; }
        public string TieuDe { get; set; }
    }
}
