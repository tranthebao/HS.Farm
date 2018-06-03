using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpChiTietHoatDongCanhTacTuoiNuoc")]
    public class ChiTietHoatDongCanhTacTuoiNuoc: FullAuditedEntity, IMayHaveTenant
    {
        [Required]
        public virtual float ThanhTienCongTuoi { get; set; }
        [Required]
        public virtual float ThanhTienNhienLieuTieuHao { get; set; }
        [Required]
        public virtual float TongChiPhiTuoiNuoc { get; set; }
        public virtual int HoatDongCanhtacTuoiNuocId { get; set; }
        public virtual int LaoDongThueNgoaiId { get; set; }
        public virtual int NhienLieuId { get; set; }
        public virtual HoatDongCanhTacTuoiNuoc HoatDongCanhtacTuoiNuoc { get; set; }
        public virtual LaoDongThueNgoai LaoDongThueNgoai { get; set; }
        public virtual NhienLieu NhienLieu { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
