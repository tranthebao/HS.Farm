using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpThuocBVTV")]
    public class ThuocBVTV: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string TenThuoc { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string TenSauBenh { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string ThietBiPhun { get; set; }
        [Required]
        public virtual float LieuLuongPhun { get; set; }
        [Required]
        public virtual float ThoiGianCachLiThuHoac { get; set; }
        [Required]
        public virtual float DonGiaThuoc { get; set; }
        [Required]
        public virtual float ThanhTien { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
