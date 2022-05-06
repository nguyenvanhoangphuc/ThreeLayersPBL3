namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTK { get; set; }

        [Required]
        [StringLength(50)]
        public string MKhau { get; set; }

        public virtual NguoiDung NguoiDung { get; set; } 

    }
}
