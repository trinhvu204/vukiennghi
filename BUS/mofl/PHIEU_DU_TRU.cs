namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_DU_TRU
    {
        [Key]
        [StringLength(10)]
        public string MA_PDT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_LAP { get; set; }

        [StringLength(10)]
        public string MA_NV { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
