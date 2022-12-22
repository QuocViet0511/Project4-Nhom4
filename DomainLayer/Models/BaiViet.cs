﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class BaiViet
    {
        [Key]
        public int Id { get; set; }
        public string ChuDe { get; set; }
        public string NoiDung { get; set; }
        public string Image { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
        public int UserId { get; set; }

    }
}
