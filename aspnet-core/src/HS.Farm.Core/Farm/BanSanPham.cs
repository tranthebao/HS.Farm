using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HS.Farm.Core
{
    [Table("AbpBanSanPham")]
    public class BanSanPham : FullAuditedEntity, IMayHaveTenant
    {
        public virtual DateTime NgayBan { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string NoiBan { get; set; }
        public virtual float SoLuongBan { get; set; }
        public virtual float GiaBan { get; set; }
        public virtual float CongThuong { get; set; }
        public virtual float ThanhTien { get; set; }
        public virtual int ChuHoId { get; set; }
        public virtual int ChatLuongSanPhamId { get; set; }
        public virtual ChuHo ChuHo { get; set; }
        public virtual ChatLuongSanPham ChatLuongSanPham { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
