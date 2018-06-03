using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpPhuongPhapCanhTac")]
    public class PhuongPhapCanhTac : FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string NguonNuoc { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string PhuongPhapTuoi { get; set; }
        [Required]
        public virtual float MatDo { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
