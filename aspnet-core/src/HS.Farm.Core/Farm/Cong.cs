using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpCong")]
    public class Cong: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string LoaiCongViec { get; set; }
        [Required]
        public virtual float SoCongTuoiNuoc { get; set; }
        [Required]
        public virtual float SoCongPhunThuoc { get; set; }
        [Required]
        public virtual float SoCongBonPhan { get; set; }
        public virtual float SoNgay { get; set; }
        public virtual float DonGia { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
