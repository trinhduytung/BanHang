namespace BanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTDHS",
                c => new
                    {
                        MaHoaDon = c.String(nullable: false, maxLength: 128),
                        MaHang = c.String(),
                        Soluong = c.String(),
                        DonGia = c.String(),
                        ThanhTien = c.String(),
                        GiamGia = c.String(),
                        NgayLapHoaDon = c.String(),
                        KhachHang = c.String(),
                        NhanVien = c.String(),
                    })
                .PrimaryKey(t => t.MaHoaDon);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 128),
                        MaKH = c.String(),
                        MaNV = c.String(),
                        NgayLapHD = c.String(),
                    })
                .PrimaryKey(t => t.MaHD);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 128),
                        TenKhachHang = c.String(),
                        SoDienThoai = c.String(),
                        Diachi = c.String(),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.LoaiHangs",
                c => new
                    {
                        MaLoai = c.String(nullable: false, maxLength: 128),
                        TenLoai = c.String(),
                    })
                .PrimaryKey(t => t.MaLoai);
            
            CreateTable(
                "dbo.MatHangs",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 128),
                        TenMH = c.String(),
                        Dongia = c.String(),
                        HinhAnh = c.String(),
                        TenLoaiMh = c.String(),
                    })
                .PrimaryKey(t => t.MaMH);
            
            CreateTable(
                "dbo.Nhanviens",
                c => new
                    {
                        TenNV = c.String(nullable: false, maxLength: 128),
                        MaNV = c.String(),
                        SoDienthoai = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.TenNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nhanviens");
            DropTable("dbo.MatHangs");
            DropTable("dbo.LoaiHangs");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HoaDons");
            DropTable("dbo.CTDHS");
        }
    }
}
