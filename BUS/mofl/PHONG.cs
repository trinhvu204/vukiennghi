namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            CT_PHIEU_DAT_PHONG = new HashSet<CT_PHIEU_DAT_PHONG>();
            HOA_DON = new HashSet<HOA_DON>();
            PHIEU_DAT_PHONG = new HashSet<PHIEU_DAT_PHONG>();
            PHIEU_LAP_DAT = new HashSet<PHIEU_LAP_DAT>();
            PHIEU_THUE_PHONG = new HashSet<PHIEU_THUE_PHONG>();
        }

        [Key]
        [StringLength(10)]
        public string MA_PHONG { get; set; }

        [StringLength(10)]
        public string MA_KHU_VUC { get; set; }

        public int? SO_NGUOI_TOI_DA { get; set; }

        public decimal? DON_GIA { get; set; }

        [StringLength(20)]
        public string TINH_TRANG { get; set; }

        [Column(TypeName = "text")]
        public string GHI_CHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEU_DAT_PHONG> CT_PHIEU_DAT_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }

        public virtual KHU_VUC KHU_VUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DAT_PHONG> PHIEU_DAT_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_LAP_DAT> PHIEU_LAP_DAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_THUE_PHONG> PHIEU_THUE_PHONG { get; set; }
    }
}
