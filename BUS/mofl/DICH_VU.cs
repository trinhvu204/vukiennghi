namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DICH_VU
    {
        [Key]
        [StringLength(10)]
        public string MA_DV { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN_DV { get; set; }

        public decimal? DON_GIA { get; set; }

        [StringLength(20)]
        public string DON_VI_TINH { get; set; }
    }
}
