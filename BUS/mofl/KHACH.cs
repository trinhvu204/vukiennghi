namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACH")]
    public partial class KHACH
    {
        [Key]
        [StringLength(10)]
        public string MA_KH { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN_KH { get; set; }

        [StringLength(20)]
        public string CMND { get; set; }

        [StringLength(15)]
        public string DIEN_THOAI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }
    }
}
