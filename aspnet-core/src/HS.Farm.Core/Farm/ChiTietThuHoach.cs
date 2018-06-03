using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpChiTietThuHoach")]
    public class ChiTietThuHoach: FullAuditedEntity, IMayHaveTenant
    {
        [Required]
        public virtual float KhoiLuongSanPham { get; set; }
        [Required]
        public virtual float ChiPhiThueNhanCongThuHoach { get; set; }
        public virtual int ThuHoachId { get; set; }
        public virtual int LaoDongThueNgoaiId { get; set; }
        public virtual ThuHoach ThuHoach { get; set; }
        public virtual LaoDongThueNgoai LaoDongThueNgoai { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
