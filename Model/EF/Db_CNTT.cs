namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Db_CNTT : DbContext
    {
        public Db_CNTT()
            : base("name=Db_CNTT")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BaiHoc> BaiHocs { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<ContentTag> ContentTags { get; set; }
        public virtual DbSet<DanhMucKienThuc> DanhMucKienThucs { get; set; }
        public virtual DbSet<DanhMucTinTuc> DanhMucTinTucs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TaiLieu> TaiLieux { get; set; }
        public virtual DbSet<TinTuc> TinTucs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
