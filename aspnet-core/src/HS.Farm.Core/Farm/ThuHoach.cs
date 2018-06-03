using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpThuHoach")]
    public class ThuHoach : FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string TenSanPham { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        [Required]
        public virtual DateTime NgayThuHoach { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
