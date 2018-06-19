namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiHoc")]
    public partial class BaiHoc
    {
        public int BaiHocID { get; set; }

        
        [Display(Name = "Danh mục kiến thức *")]
        [Required(ErrorMessage ="Nhập danh mục kiến thức")]
        public int? DanhMucKienThucID { get; set; }

        [Required(ErrorMessage ="Bạn chưa nhập")]
        [StringLength(250)]
        [Display(Name = "Bài (số thứ tự) *")]
        public string Ten { get; set; }

        [StringLength(250)]
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Nhập tiêu đề")]
        [Display(Name = "Tiêu đề *")]
        public string TieuDe { get; set; }

        [Required(ErrorMessage = "Nhập tiêu đề seo")]
        [StringLength(250)]
        [Display(Name = "Tiêu đề seo *")]
        public string TieuDeSeo { get; set; }

        [Required(ErrorMessage = "Nhập nội dung")]
        [Display(Name = "Nội dung *")]
        public string NoiDung { get; set; }

        [StringLength(250)]
        [Display(Name = "Hình ảnh")]
        public string HinhAnh { get; set; }

        [StringLength(250)]
        [Display(Name = "Video")]
        public string Video { get; set; }

        [Display(Name = "Ngày viết")]
        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        [Display(Name = "Tác giả")]
        public string NguoiTao { get; set; }

        [Display(Name = "Trạng thái")]
        public bool? TrangThai { get; set; }


        public int? LuotXem { get; set; }

        [StringLength(50)]
        [Display(Name = "Thẻ tag")]
        public string Tag { get; set; }

        [StringLength(250)]
        [Display(Name = "Link bổ sung")]
        public string Link { get; set; }
    }
}
