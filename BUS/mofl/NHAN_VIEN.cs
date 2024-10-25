namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            PHIEU_DU_TRU = new HashSet<PHIEU_DU_TRU>();
        }

        [Key]
        [StringLength(10)]
        public string MA_NV { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN_NV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_SINH { get; set; }

        [StringLength(100)]
        public string DIA_CHI { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DU_TRU> PHIEU_DU_TRU { get; set; }
    }
}
