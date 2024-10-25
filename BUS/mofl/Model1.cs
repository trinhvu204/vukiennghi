using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BUS.mofl
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CHI_TIET_LAP_DAT> CHI_TIET_LAP_DAT { get; set; }
        public virtual DbSet<CT_PHIEU_DAT_PHONG> CT_PHIEU_DAT_PHONG { get; set; }
        public virtual DbSet<CT_PHIEU_SU_DUNG> CT_PHIEU_SU_DUNG { get; set; }
        public virtual DbSet<DICH_VU> DICH_VU { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<KHACH> KHACHes { get; set; }
        public virtual DbSet<KHU_VUC> KHU_VUC { get; set; }
        public virtual DbSet<LOAI_THIET_BI> LOAI_THIET_BI { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<PHIEU_DAT_PHONG> PHIEU_DAT_PHONG { get; set; }
        public virtual DbSet<PHIEU_DU_TRU> PHIEU_DU_TRU { get; set; }
        public virtual DbSet<PHIEU_LAP_DAT> PHIEU_LAP_DAT { get; set; }
        public virtual DbSet<PHIEU_THUE_PHONG> PHIEU_THUE_PHONG { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<THIET_BI> THIET_BI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHI_TIET_LAP_DAT>()
                .Property(e => e.MA_TN)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_LAP_DAT>()
                .Property(e => e.MA_PLD)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_LAP_DAT>()
                .Property(e => e.TINH_TRANG)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_DAT_PHONG>()
                .Property(e => e.MA_PHIEU_DP)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_DAT_PHONG>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_DAT_PHONG>()
                .Property(e => e.DON_GIA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CT_PHIEU_SU_DUNG>()
                .Property(e => e.MA_PSD)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_SU_DUNG>()
                .Property(e => e.MA_DV)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEU_SU_DUNG>()
                .Property(e => e.THANH_TIEN)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DICH_VU>()
                .Property(e => e.MA_DV)
                .IsUnicode(false);

            modelBuilder.Entity<DICH_VU>()
                .Property(e => e.TEN_DV)
                .IsUnicode(false);

            modelBuilder.Entity<DICH_VU>()
                .Property(e => e.DON_GIA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DICH_VU>()
                .Property(e => e.DON_VI_TINH)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_HD)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_NV)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_PHIEU_DP)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.MA_KH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.TEN_KH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.DIEN_THOAI)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<KHU_VUC>()
                .Property(e => e.MA_KHU_VUC)
                .IsUnicode(false);

            modelBuilder.Entity<KHU_VUC>()
                .Property(e => e.TEN_KHU_VUC)
                .IsUnicode(false);

            modelBuilder.Entity<LOAI_THIET_BI>()
                .Property(e => e.MA_LOAI)
                .IsUnicode(false);

            modelBuilder.Entity<LOAI_THIET_BI>()
                .Property(e => e.TEN_LOAI)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_NV)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.TEN_NV)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.DIA_CHI)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .Property(e => e.MA_PHIEU_DP)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .Property(e => e.MA_KHACH)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .Property(e => e.TRANG_THAI)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_DAT_PHONG>()
                .HasMany(e => e.CT_PHIEU_DAT_PHONG)
                .WithRequired(e => e.PHIEU_DAT_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_DU_TRU>()
                .Property(e => e.MA_PDT)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_DU_TRU>()
                .Property(e => e.MA_NV)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_LAP_DAT>()
                .Property(e => e.MA_PLD)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_LAP_DAT>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_LAP_DAT>()
                .HasMany(e => e.CHI_TIET_LAP_DAT)
                .WithRequired(e => e.PHIEU_LAP_DAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_THUE_PHONG>()
                .Property(e => e.MA_PSD)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THUE_PHONG>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THUE_PHONG>()
                .Property(e => e.MA_KH)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THUE_PHONG>()
                .Property(e => e.TRANG_THAI)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THUE_PHONG>()
                .HasMany(e => e.CT_PHIEU_SU_DUNG)
                .WithRequired(e => e.PHIEU_THUE_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MA_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MA_KHU_VUC)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.DON_GIA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.TINH_TRANG)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.GHI_CHU)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CT_PHIEU_DAT_PHONG)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIET_BI>()
                .Property(e => e.MA_TB)
                .IsUnicode(false);

            modelBuilder.Entity<THIET_BI>()
                .Property(e => e.TEN_THIET_BI)
                .IsUnicode(false);

            modelBuilder.Entity<THIET_BI>()
                .Property(e => e.XUAT_XU)
                .IsUnicode(false);

            modelBuilder.Entity<THIET_BI>()
                .Property(e => e.MA_LOAI)
                .IsUnicode(false);
        }
    }
}
