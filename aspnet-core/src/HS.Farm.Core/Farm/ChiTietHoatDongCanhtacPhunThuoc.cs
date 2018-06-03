using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpChiTietHoatDongCanhTacPhunThuoc")]
    public class ChiTietHoatDongCanhTacPhunThuoc : FullAuditedEntity, IMayHaveTenant
    {
        [Required]
        public virtual float ChiPhiSuDungThuocBVTV { get; set; }
        [Required]
        public virtual float ChiPhiThueNhanCongPhun { get; set; }
        [Required]
        public virtual float TongChiPhiPhunThuoc { get; set; }
        public virtual int ThuocBVTVId { get; set; }
        public virtual int HoatDongCanhtacPhunThuocId { get; set; }
        public virtual int LaoDongThueNgoaiId { get; set; }
        public virtual ThuocBVTV ThuocBVTV { get; set; }
        public virtual HoatDongCanhTacPhunThuoc HoatDongCanhtacPhunThuoc { get; set; }
        public virtual LaoDongThueNgoai LaoDongThueNgoai { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
