using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpChiTietChuHoLaoDongThueNgoai")]
    public class ChiTietChuHoLaoDongThueNgoai: FullAuditedEntity, IMayHaveTenant
    {
        public virtual int ChuHoId { get; set; }
        public virtual int LaoDongThueNgoaiId { get; set; }
        public virtual ChuHo ChuHo { get; set; }
        public virtual LaoDongThueNgoai LaoDongThueNgoai { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
