using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DTO
{
    public partial class ModelQLPT : DbContext
    {
        public ModelQLPT()
            : base("name=ModelQLPT1")
        {
        }

        public virtual DbSet<DanhSachIDLTB> DanhSachIDLTBs { get; set; }
        public virtual DbSet<LichSuSuaChua> LichSuSuaChuas { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<LoaiThietBi> LoaiThietBis { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NguoiThue> NguoiThues { get; set; }
        public virtual DbSet<PhongTro> PhongTroes { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThietBi> ThietBis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhSachIDLTB>()
                .Property(e => e.IDLoaiPhong)
                .IsFixedLength();

            modelBuilder.Entity<DanhSachIDLTB>()
                .Property(e => e.IDLoaiThietBi)
                .IsFixedLength();

            modelBuilder.Entity<LichSuSuaChua>()
                .Property(e => e.ID_LichSuSuaChua)
                .IsFixedLength();

            modelBuilder.Entity<LichSuSuaChua>()
                .Property(e => e.IDNhanVien)
                .IsFixedLength();

            modelBuilder.Entity<LichSuSuaChua>()
                .Property(e => e.IDPhong)
                .IsFixedLength();

            modelBuilder.Entity<LichSuSuaChua>()
                .Property(e => e.ID_LoaiThietBi)
                .IsFixedLength();

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.IDLoaiPhong)
                .IsFixedLength();

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.DanhSachIDLTBs)
                .WithRequired(e => e.LoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.PhongTroes)
                .WithRequired(e => e.LoaiPhong)
                .HasForeignKey(e => e.ID_LoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiThietBi>()
                .Property(e => e.IDLoaiThietBi)
                .IsFixedLength();

            modelBuilder.Entity<LoaiThietBi>()
                .HasMany(e => e.DanhSachIDLTBs)
                .WithRequired(e => e.LoaiThietBi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiThietBi>()
                .HasMany(e => e.ThietBis)
                .WithRequired(e => e.LoaiThietBi)
                .HasForeignKey(e => e.ID_Phòng)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.LichSuSuaChuas)
                .WithRequired(e => e.NguoiDung)
                .HasForeignKey(e => e.IDNhanVien)
                .WillCascadeOnDelete(false);

            /*modelBuilder.Entity<NguoiThue>()
                .HasMany(e => e.PhongTroes)
                .WithMany(e => e.NguoiThues)
                .Map(m => m.ToTable("QLDatPhong").MapLeftKey("SDT").MapRightKey("ID_Phong"));*/

            modelBuilder.Entity<PhongTro>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<PhongTro>()
                .Property(e => e.ID_LoaiPhong)
                .IsFixedLength();

            modelBuilder.Entity<PhongTro>()
                .HasMany(e => e.LichSuSuaChuas)
                .WithRequired(e => e.PhongTro)
                .HasForeignKey(e => e.IDPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhongTro>()
                .HasMany(e => e.ThietBis)
                .WithRequired(e => e.PhongTro)
                .HasForeignKey(e => e.ID_Phòng)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .HasOptional(e => e.NguoiDung)
                .WithRequired(e => e.TaiKhoan);

            modelBuilder.Entity<ThietBi>()
                .Property(e => e.ID_Phòng)
                .IsFixedLength();

            modelBuilder.Entity<ThietBi>()
                .Property(e => e.ID_Loại_thiết_bị)
                .IsFixedLength();

            modelBuilder.Entity<ThietBi>()
                .HasMany(e => e.LichSuSuaChuas)
                .WithRequired(e => e.ThietBi)
                .HasForeignKey(e => new { e.IDPhong, e.ID_LoaiThietBi })
                .WillCascadeOnDelete(false);
        }
    }
}
