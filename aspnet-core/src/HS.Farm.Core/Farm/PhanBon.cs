using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpPhanBon")]
    public class PhanBon: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string TenPhan { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string LoaiPhan { get; set; }
        [Required]
        public virtual float LuongBon { get; set; }
        [Required]
        public virtual float DonGia { get; set; }
        [Required]
        public virtual float ThanhTien { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
