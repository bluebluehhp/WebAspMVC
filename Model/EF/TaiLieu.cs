namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiLieu")]
    public partial class TaiLieu
    {
        public long TaiLieuID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string LoaiTaiLieu { get; set; }

        [StringLength(250)]
        public string Link1 { get; set; }

        [StringLength(250)]
        public string HinhAnh1 { get; set; }

        [StringLength(250)]
        public string Link2 { get; set; }

        [StringLength(250)]
        public string LinkDuPhong { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }
    }
}
