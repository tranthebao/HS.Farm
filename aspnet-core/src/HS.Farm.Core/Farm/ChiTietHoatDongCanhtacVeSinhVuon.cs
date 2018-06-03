using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpChiTietHoatDongCanhTacVeSinhVuon")]
    public class ChiTietHoatDongCanhTacVeSinhVuon: FullAuditedEntity, IMayHaveTenant
    {
        [Required]
        public virtual float TongChiPhiThueNhanCong { get; set; }
        [Required]
        public virtual float TongChiPhiDungNhienLieu { get; set; }
        [Required]
        public virtual float TongChiPhiLamVuon { get; set; }
        public virtual int NhienLieuId { get; set; }
        public virtual int HoatDongCanhtacVeSinhVuonId { get; set; }
        public virtual int LaoDongThueNgoaiId { get; set; }
        public virtual HoatDongCanhTacVeSinhVuon HoatDongCanhtacVeSinhVuon { get; set; }
        public virtual LaoDongThueNgoai LaoDongThueNgoai { get; set; }
        public virtual NhienLieu NhienLieu { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
