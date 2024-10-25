namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEU_DAT_PHONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MA_PHIEU_DP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MA_PHONG { get; set; }

        public decimal? DON_GIA { get; set; }

        public virtual PHIEU_DAT_PHONG PHIEU_DAT_PHONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
