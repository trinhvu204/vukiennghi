namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_DAT_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_DAT_PHONG()
        {
            CT_PHIEU_DAT_PHONG = new HashSet<CT_PHIEU_DAT_PHONG>();
            HOA_DON = new HashSet<HOA_DON>();
        }

        [Key]
        [StringLength(10)]
        public string MA_PHIEU_DP { get; set; }

        [StringLength(10)]
        public string MA_PHONG { get; set; }

        [StringLength(10)]
        public string MA_KHACH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_LAP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_TRA { get; set; }

        [StringLength(20)]
        public string TRANG_THAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_DAT_PHONG> CT_PHIEU_DAT_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
