using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpHoatDongCanhTacTuoiNuoc")]
    public class HoatDongCanhTacTuoiNuoc : FullAuditedEntity, IMayHaveTenant
    {
        [Required]
        public virtual int DotTuoi { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        public virtual DateTime NgayTuoi { get; set; }
        [Required]
        public virtual float SoGioTuoi { get; set; }
        [Required]
        public virtual float LuongNuocTieuHao { get; set; }
        public virtual  int PhuongPhapCanhTacId { get; set; }
        public virtual PhuongPhapCanhTac PhuongPhapCanhTac { get; set; }
        public virtual int? TenantId { get; set; }
    }
}
