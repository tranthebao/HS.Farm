using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpChiTietChuHoDatCanhTac")]
    public class ChiTietChuHoDatCanhTac: FullAuditedEntity, IMayHaveTenant
    { 
        [Required]
        public virtual float TongDienTich { get; set; }
        [Required]
        public virtual float TongDienTichCayTrongKhac { get; set; }
        [Required]
        public virtual int TongSoVuon { get; set; }
        public virtual int ChuHoId { get; set; }
        public virtual int DatCanhTacId { get; set; }
        public virtual ChuHo ChuHo { get; set; }
        public virtual DatCanhTac DatCanhTac { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
