using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHang.Models
{
    [Table("LoaiHangs")]
    public class LoaiHang
    {
        [Key]
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

    }
}