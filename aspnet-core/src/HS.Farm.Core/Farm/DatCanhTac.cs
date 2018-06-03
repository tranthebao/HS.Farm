using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpDatCanhTac")]
    public class DatCanhTac: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string TenVuon { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string LoaiVuon { get; set; }
        [Required]
        public virtual float DienTich { get; set; }
        public virtual int CayTrongId { get; set; }
        public virtual CayTrong CayTrong { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
