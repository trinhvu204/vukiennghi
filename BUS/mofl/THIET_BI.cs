namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THIET_BI
    {
        [Key]
        [StringLength(10)]
        public string MA_TB { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN_THIET_BI { get; set; }

        [StringLength(50)]
        public string XUAT_XU { get; set; }

        [StringLength(10)]
        public string MA_LOAI { get; set; }
    }
}
