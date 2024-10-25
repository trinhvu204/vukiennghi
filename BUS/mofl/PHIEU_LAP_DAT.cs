namespace BUS.mofl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_LAP_DAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_LAP_DAT()
        {
            CHI_TIET_LAP_DAT = new HashSet<CHI_TIET_LAP_DAT>();
        }

        [Key]
        [StringLength(10)]
        public string MA_PLD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_LAP { get; set; }

        [StringLength(10)]
        public string MA_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_LAP_DAT> CHI_TIET_LAP_DAT { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
