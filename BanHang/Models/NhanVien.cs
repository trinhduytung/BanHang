using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHang.Models
{
    [Table("Nhanviens")]
    public class NhanVien
    {
        [Key]
        public string TenNV { get; set; }
        public string MaNV { get; set; }
        public string SoDienthoai { get; set; }
        public string DiaChi{ get; set; }
    }
}