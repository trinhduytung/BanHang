using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHang.Models
{
    [Table("MatHangs")]
    
    public class MatHang
    {
        [Key]
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string Dongia { get; set; }
        public string HinhAnh { get; set; }
        public string TenLoaiMh { get; set; }
    }
}