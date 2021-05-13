namespace BanHang.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class LTQLDbcontect : DbContext
    {
        public LTQLDbcontect()
            : base("name=LTQLDbcontect")
        {
        }
        public virtual DbSet<KhachHang>KhachHangs { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<HoaDon>HoaDons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<LoaiHang> LoaiHangs { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public IEnumerable<object> Accounts { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
