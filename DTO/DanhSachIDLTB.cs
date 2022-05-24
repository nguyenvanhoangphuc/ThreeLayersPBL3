namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhSachIDLTB")]
    public partial class DanhSachIDLTB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IDLoaiPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDLoaiThietBi { get; set; }

        public int SoLuong { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        public virtual LoaiThietBi LoaiThietBi { get; set; }
    }
}
