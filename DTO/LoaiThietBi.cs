namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiThietBi")]
    public partial class LoaiThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiThietBi()
        {
            ThietBis = new HashSet<ThietBi>();
        }

        [Key]
        [Column("ID Loại thiết bị")]
        [StringLength(10)]
        public string ID_Loại_thiết_bị { get; set; }

        [Column("Tên thiết bị")]
        [Required]
        [StringLength(50)]
        public string Tên_thiết_bị { get; set; }

        public decimal? Giá { get; set; }

        [Column("Số lượng")]
        public short Số_lượng { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThietBi> ThietBis { get; set; }
    }
}
