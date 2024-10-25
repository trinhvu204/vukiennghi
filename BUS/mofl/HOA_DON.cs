namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [Key]
        [StringLength(10)]
        public string MA_HD { get; set; }

        [StringLength(10)]
        public string MA_NV { get; set; }

        [StringLength(10)]
        public string MA_PHONG { get; set; }

        [StringLength(10)]
        public string MA_PHIEU_DP { get; set; }

        public virtual PHIEU_DAT_PHONG PHIEU_DAT_PHONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
