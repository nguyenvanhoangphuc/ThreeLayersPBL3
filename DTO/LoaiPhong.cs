namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiPhong")]
    public partial class LoaiPhong
    {
        [Key]
        [StringLength(10)]
        public string IDLoaiPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiPhong { get; set; }

        public int GiaThanh { get; set; }

        [Required]
        [StringLength(50)]
        public string DanhSachIDThietBi { get; set; }
    }
}