using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpThuChi")]
    public class ThuChi: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string LoaiThuChi { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string HangMuc { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string TenHoatDongCanhTac { get; set; }
        [Required]
        public virtual float ThanhTien { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
