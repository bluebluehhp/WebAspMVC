namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucTinTuc")]
    public partial class DanhMucTinTuc
    {
        public int DanhMucTinTucID { get; set; }

        [StringLength(250)]
        public string Ten { get; set; }

        [StringLength(250)]
        public string TieuDe { get; set; }

        [StringLength(250)]
        public string TieuDeSeo { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        [StringLength(250)]
        public string Link { get; set; }
    }
}
