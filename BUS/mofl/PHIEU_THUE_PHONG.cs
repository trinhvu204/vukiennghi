namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_THUE_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_THUE_PHONG()
        {
            CT_PHIEU_SU_DUNG = new HashSet<CT_PHIEU_SU_DUNG>();
        }

        [Key]
        [StringLength(10)]
        public string MA_PSD { get; set; }

        [StringLength(10)]
        public string MA_PHONG { get; set; }

        [StringLength(10)]
        public string MA_KH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_DEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_DI { get; set; }

        [StringLength(20)]
        public string TRANG_THAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_SU_DUNG> CT_PHIEU_SU_DUNG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
