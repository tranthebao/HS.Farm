using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpChiTietThuChi")]
    public class ChiTietThuChi: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength]
        [Required]
        public virtual string HangMuc { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string TenHoatDongCanhTac { get; set; }
        [Required]
        public virtual float TongSoTien { get; set; }
        public virtual int ThuChiId { get; set; }
        public virtual int ChuHoId { get; set; }
        public virtual ChuHo ChuHo { get; set; }
        public virtual ThuChi ThuChi { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
