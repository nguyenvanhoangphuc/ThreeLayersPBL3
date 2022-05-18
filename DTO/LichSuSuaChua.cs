namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuSuaChua")]
    public partial class LichSuSuaChua
    {
        [Key]
        [StringLength(10)]
        public string ID_LichSuSuaChua { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNhanVien { get; set; }

        [Required]
        [StringLength(10)]
        public string IDPhong { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_LoaiThietBi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySuaChua { get; set; }

        public int SoTienSuaChua { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual PhongTro PhongTro { get; set; }

        public virtual ThietBi ThietBi { get; set; }
    }
}
