namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEU_SU_DUNG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MA_PSD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MA_DV { get; set; }

        public int? SO_LUONG { get; set; }

        public decimal? THANH_TIEN { get; set; }

        public virtual PHIEU_THUE_PHONG PHIEU_THUE_PHONG { get; set; }
    }
}
