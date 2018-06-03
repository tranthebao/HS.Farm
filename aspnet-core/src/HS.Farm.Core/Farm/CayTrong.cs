using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HS.Farm.Core
{
    [Table("AbpCayTrong")]
    public class CayTrong: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string TenCay { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string LoaiCay { get; set; }
        public virtual float MatDo { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
