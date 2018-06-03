using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HS.Farm.Authorization.Roles;
using HS.Farm.Authorization.Users;
using HS.Farm.MultiTenancy;
using HS.Farm.Core;
using HS.Farm.People;

namespace HS.Farm.EntityFrameworkCore
{
    public class FarmDbContext : AbpZeroDbContext<Tenant, Role, User, FarmDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<BanSanPham> BanSanPhams { get; set; }
        public virtual DbSet<CayTrong> CayTrongs { get; set; }
        public virtual DbSet<ChatLuongSanPham> ChatLuongSanPhams { get; set; }
        public virtual DbSet<ChuHo> ChuHos { get; set; }
        public virtual DbSet<Cong> Congs { get; set; }
        public virtual DbSet<DatCanhTac> DatCanhTacs { get; set; }
        public virtual DbSet<HoatDongCanhTacBonPhan> HoatDongCanhtacBonPhans { get; set; }
        public virtual DbSet<HoatDongCanhTacPhunThuoc> HoatDongCanhtacPhunThuocs { get; set; }
        public virtual DbSet<HoatDongCanhTacTuoiNuoc> HoatDongCanhtacTuoiNuocs { get; set; }
        public virtual DbSet<HoatDongCanhTacVeSinhVuon> HoatDongCanhtacVeSinhVuons { get; set; }
        public virtual DbSet<LaoDongThueNgoai> LaoDongThueNgoais { get; set; }
        public virtual DbSet<NhienLieu> NhienLieus { get; set; }
        public virtual DbSet<PhanBon> PhanBons { get; set; }
        public virtual DbSet<PhuongPhapCanhTac> PhuongPhapCanhTacs { get; set; }
        public virtual DbSet<ThuChi> ThuChis { get; set; }
        public virtual DbSet<ThuHoach> ThuHoachs { get; set; }
        public virtual DbSet<ThuocBVTV> ThuocBVTVs { get; set; }
        public virtual DbSet<ChiTietChuHoDatCanhTac> ChiTietChuHoDatCanhTacs { get; set; }
        public virtual DbSet<ChiTietChuHoLaoDongThueNgoai> ChiTietChuHoLaoDongThueNgoais { get; set; }
        public virtual DbSet<ChiTietHoatDongCanhTacBonPhan> ChiTietHoatDongCanhtacBonPhans { get; set; }
        public virtual DbSet<ChiTietHoatDongCanhTacPhunThuoc> ChiTietHoatDongCanhtacPhunThuocs { get; set; }
        public virtual DbSet<ChiTietHoatDongCanhTacTuoiNuoc> ChiTietHoatDongCanhtacTuoiNuocs { get; set; }
        public virtual DbSet<ChiTietHoatDongCanhTacVeSinhVuon> ChiTietHoatDongCanhtacVeSinhVuons { get; set; }
        public virtual DbSet<ChiTietThuChi> ChiTietThuChis { get; set; }
        public virtual DbSet<ChiTietThuHoach> ChiTietThuHoachs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("StsPeople");
            modelBuilder.Entity<BanSanPham>().ToTable("AbpBanSanPham");
            modelBuilder.Entity<CayTrong>().ToTable("AbpCayTrong");
            modelBuilder.Entity<ChatLuongSanPham>().ToTable("AbpChatLuongSanPham");
            modelBuilder.Entity<ChuHo>().ToTable("AbpChuHo");
            modelBuilder.Entity<Cong>().ToTable("AbpCong");
            modelBuilder.Entity<DatCanhTac>().ToTable("AbpDatCanhTac");
            modelBuilder.Entity<HoatDongCanhTacBonPhan>().ToTable("AbpHoatDongCanhTacBonPhan");
            modelBuilder.Entity<HoatDongCanhTacPhunThuoc>().ToTable("AbpHoatDongCanhTacPhunThuoc");
            modelBuilder.Entity<HoatDongCanhTacTuoiNuoc>().ToTable("AbpHoatDongCanhTacTuoiNuoc");
            modelBuilder.Entity<HoatDongCanhTacVeSinhVuon>().ToTable("AbpHoatDongCanhTacVeSinhVuon");
            modelBuilder.Entity<LaoDongThueNgoai>().ToTable("AbpLaoDongThueNgoai");
            modelBuilder.Entity<NhienLieu>().ToTable("AbpNhienLieu");
            modelBuilder.Entity<PhanBon>().ToTable("AbpPhanBon");
            modelBuilder.Entity<PhuongPhapCanhTac>().ToTable("AbpPhuongPhapCanhTac");
            modelBuilder.Entity<ThuChi>().ToTable("AbpThuChi");
            modelBuilder.Entity<ThuHoach>().ToTable("AbpThuHoach");
            modelBuilder.Entity<ThuocBVTV>().ToTable("AbpThuocBVTV");
            modelBuilder.Entity<ChiTietChuHoDatCanhTac>().ToTable("AbpChiTietChuHoDatCanhTac");
            modelBuilder.Entity<ChiTietChuHoLaoDongThueNgoai>().ToTable("AbpChiTietChuHoLaoDongThueNgoai");
            modelBuilder.Entity<ChiTietHoatDongCanhTacBonPhan>().ToTable("AbpChiTietHoatDongCanhTacBonPhan");
            modelBuilder.Entity<ChiTietHoatDongCanhTacPhunThuoc>().ToTable("AbpChiTietHoatDongCanhTacPhunThuoc");
            modelBuilder.Entity<ChiTietHoatDongCanhTacTuoiNuoc>().ToTable("AbpChiTietHoatDongCanhTacTuoiNuoc");
            modelBuilder.Entity<ChiTietHoatDongCanhTacVeSinhVuon>().ToTable("AbpChiTietHoatDongCanhTacVeSinhVuon");
            modelBuilder.Entity<ChiTietThuChi>().ToTable("AbpChiTietThuChi");
            modelBuilder.Entity<ChiTietThuHoach>().ToTable("AbpChiTietThuHoach");
            base.OnModelCreating(modelBuilder);
        }
        public FarmDbContext(DbContextOptions<FarmDbContext> options)
            : base(options)
        {
        }
    }
}
