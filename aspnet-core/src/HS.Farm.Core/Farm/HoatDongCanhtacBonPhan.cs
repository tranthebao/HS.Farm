using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpHoatDongCanhTacBonPhan")]
    public class HoatDongCanhTacBonPhan: FullAuditedEntity, IMayHaveTenant
    {
        [Required]
        public virtual int DotBon { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        public virtual DateTime NgayBon { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
