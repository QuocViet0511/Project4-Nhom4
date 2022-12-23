﻿using System.ComponentModel.DataAnnotations;

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
