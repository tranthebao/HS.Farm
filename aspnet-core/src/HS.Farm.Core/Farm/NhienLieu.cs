using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpNhienLieu")]
    public class NhienLieu : FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string TenNhienLieu { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string LoaiNhienLieu { get; set; }
        public virtual float DonGia { get; set; }
        public virtual float ThanhTien { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
