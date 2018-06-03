using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpChiTietHoatDongCanhTacBonPhan")]
    public class ChiTietHoatDongCanhTacBonPhan: FullAuditedEntity, IMayHaveTenant
    {
        [Required]
        public virtual float ThanhTienPhanTieuThu { get; set; }
        [Required]
        public virtual float ThanhTienCongBonPhan { get; set; }
        [Required]
        public virtual float TongChiPhiBonPhan { get; set; }
        public virtual int PhanBonId { get; set; }
        public virtual int HoatDongCanhtacBonPhanId { get; set; }
        public virtual int LaoDongThueNgoaiId { get; set; }
        public virtual PhanBon PhanBon { get; set; }
        public virtual HoatDongCanhTacBonPhan HoatDongCanhtacBonPhan { get; set; }
        public virtual LaoDongThueNgoai LaoDongThueNgoai { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
