namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThietBi")]
    public partial class ThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThietBi()
        {
            LichSuSuaChuas = new HashSet<LichSuSuaChua>();
        }

        [Key]
        [Column("ID Phòng", Order = 0)]
        [StringLength(10)]
        public string ID_Phòng { get; set; }

        [Key]
        [Column("ID Loại thiết bị", Order = 1)]
        [StringLength(10)]
        public string ID_Loại_thiết_bị { get; set; }

        [Column("Tình trạng")]
        public bool Tình_trạng { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuSuaChua> LichSuSuaChuas { get; set; }

        public virtual LoaiThietBi LoaiThietBi { get; set; }

        public virtual PhongTro PhongTro { get; set; }
    }
}
