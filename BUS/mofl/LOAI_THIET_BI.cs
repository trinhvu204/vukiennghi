namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_THIET_BI
    {
        [Key]
        [StringLength(10)]
        public string MA_LOAI { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN_LOAI { get; set; }
    }
}
