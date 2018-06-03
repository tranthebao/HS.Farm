using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpHoatDongCanhTacVeSinhVuon")]
    public class HoatDongCanhTacVeSinhVuon: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(250)]
        [Required]
        public virtual string NoiDungCongViec { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        public virtual DateTime NgayLam { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
