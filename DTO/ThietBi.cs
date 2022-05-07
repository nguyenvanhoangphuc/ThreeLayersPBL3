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

        public virtual LoaiThietBi LoaiThietBi { get; set; }
    }
}
