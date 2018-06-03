using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpHoatDongCanhTacPhunThuoc")]
    public class HoatDongCanhTacPhunThuoc: FullAuditedEntity, IMayHaveTenant
    {
        [Required]
        public virtual int DotPhun { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        public virtual DateTime NgayPhun { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
