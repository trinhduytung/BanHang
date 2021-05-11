using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHang.Models
{
    [Table("CTDHS")]
    public class CTHD
    {
        [Key]
        public string MaHoaDon { get; set; }
        public string MaHang { get; set; }
        public string Soluong { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien{ get; set; }
        public string GiamGia { get; set; }
        public string NgayLapHoaDon { get; set; }
        public string KhachHang { get; set; }
        public string NhanVien { get; set; }

    }
}