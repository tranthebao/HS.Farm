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
        public DbSet<Person> People { get; set; }
        public DbSet<BanSanPham> BanSanPhams { get; set; }
        public DbSet<CayTrong> CayTrongs { get; set; }
        public DbSet<ChatLuongSanPham> ChatLuongSanPhams { get; set; }
        public DbSet<ChuHo> ChuHos { get; set; }
        public DbSet<Cong> Congs { get; set; }
        public DbSet<DatCanhTac> DatCanhTacs { get; set; }
        public DbSet<HoatDongCanhTacBonPhan> HoatDongCanhtacBonPhans { get; set; }
        public DbSet<HoatDongCanhTacPhunThuoc> HoatDongCanhtacPhunThuocs { get; set; }
        public DbSet<HoatDongCanhTacTuoiNuoc> HoatDongCanhtacTuoiNuocs { get; set; }
        public DbSet<HoatDongCanhTacVeSinhVuon> HoatDongCanhtacVeSinhVuons { get; set; }
        public DbSet<LaoDongThueNgoai> LaoDongThueNgoais { get; set; }
        public DbSet<NhienLieu> NhienLieus { get; set; }
        public DbSet<PhanBon> PhanBons { get; set; }
        public DbSet<PhuongPhapCanhTac> PhuongPhapCanhTacs { get; set; }
        public DbSet<ThuChi> ThuChis { get; set; }
        public DbSet<ThuHoach> ThuHoachs { get; set; }
        public DbSet<ThuocBVTV> ThuocBVTVs { get; set; }
        public DbSet<ChiTietChuHoDatCanhTac> ChiTietChuHoDatCanhTacs { get; set; }
        public DbSet<ChiTietChuHoLaoDongThueNgoai> ChiTietChuHoLaoDongThueNgoais { get; set; }
        public DbSet<ChiTietHoatDongCanhTacBonPhan> ChiTietHoatDongCanhtacBonPhans { get; set; }
        public DbSet<ChiTietHoatDongCanhTacPhunThuoc> ChiTietHoatDongCanhtacPhunThuocs { get; set; }
        public DbSet<ChiTietHoatDongCanhTacTuoiNuoc> ChiTietHoatDongCanhtacTuoiNuocs { get; set; }
        public DbSet<ChiTietHoatDongCanhTacVeSinhVuon> ChiTietHoatDongCanhtacVeSinhVuons { get; set; }
        public DbSet<ChiTietThuChi> ChiTietThuChis { get; set; }
        public DbSet<ChiTietThuHoach> ChiTietThuHoachs { get; set; }
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
