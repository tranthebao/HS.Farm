using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpChuHo")]
    public class ChuHo: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string TenChuHo { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string DiaChi { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string GioiTinh { get; set; }
        [Required]
        public virtual string SoDienThoai { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
