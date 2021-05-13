namespace BanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDons", "KhachHang_MaKhachHang", c => c.String(maxLength: 128));
            AddColumn("dbo.KhachHangs", "Email", c => c.String(nullable: false));
            AddColumn("dbo.KhachHangs", "Password", c => c.String(nullable: false));
            CreateIndex("dbo.HoaDons", "KhachHang_MaKhachHang");
            AddForeignKey("dbo.HoaDons", "KhachHang_MaKhachHang", "dbo.KhachHangs", "MaKhachHang");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "KhachHang_MaKhachHang", "dbo.KhachHangs");
            DropIndex("dbo.HoaDons", new[] { "KhachHang_MaKhachHang" });
            DropColumn("dbo.KhachHangs", "Password");
            DropColumn("dbo.KhachHangs", "Email");
            DropColumn("dbo.HoaDons", "KhachHang_MaKhachHang");
        }
    }
}
