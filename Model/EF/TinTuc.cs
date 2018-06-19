namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinTuc")]
    public partial class TinTuc
    {
        public int TinTucID { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập danh mục")]
        [Display(Name = "Danh mục tin tức *")]
        public int? DanhMucTinTucID { get; set; }


        [StringLength(250)]
        [Required(ErrorMessage = "Nhập tên bài viết")]
        [Display(Name = "Tên bài viết *")]
        public string Ten { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Nhập tiêu đề")]
        [Display(Name = "Tiêu đề *")]
        public string TieuDe { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Nhập tiêu đề seo")]
        [Display(Name = "Tiêu đề SEO *")]
        public string TieuDeSeo { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime? NgayTao { get; set; }

        [StringLength(250)]
        [Display(Name = "Tác giả")]
        public string NguoiTao { get; set; }
        [Display(Name = "Trạng thái")]
        public bool? TrangThai { get; set; }

        [StringLength(250)]
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }

        [Display(Name = "Nội dung *")]
        [Required(ErrorMessage = "Nhập nội dung")]
        public string NoiDung { get; set; }

        [StringLength(250)]
        [Display(Name = "Hình ảnh")]
        public string HinhAnh { get; set; }

        [StringLength(250)]
        [Display(Name = "Hình ảnh")]
        public string HinhAnh2 { get; set; }

        [StringLength(250)]
        [Display(Name = "Hình ảnh")]
        public string HinhAnh3 { get; set; }

        [StringLength(250)]
        [Display(Name = "Hình ảnh")]
        public string HinhAnh4 { get; set; }

        [StringLength(250)]
        [Display(Name = "Hình ảnh")]
        public string HinhAnh5 { get; set; }

        [StringLength(250)]
        [Display(Name = "Video")]
        public string Video { get; set; }

        [Display(Name = "Lượt xem")]
        public int? LuotXem { get; set; }

        [StringLength(50)]
        [Display(Name = "Thẻ tag")]
        public string Tag { get; set; }

        [StringLength(250)]
        [Display(Name = "Link bổ sung")]
        public string Link { get; set; }
    }
}
