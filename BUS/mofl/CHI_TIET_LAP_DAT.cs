namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_LAP_DAT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MA_TN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MA_PLD { get; set; }

        public int? SO_LUONG { get; set; }

        [StringLength(20)]
        public string TINH_TRANG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_LAP_DAT { get; set; }

        public virtual PHIEU_LAP_DAT PHIEU_LAP_DAT { get; set; }
    }
}
