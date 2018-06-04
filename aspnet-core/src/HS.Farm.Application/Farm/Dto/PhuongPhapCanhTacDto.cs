using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(PhuongPhapCanhTac))]
    public class PhuongPhapCanhTacDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public string NguonNuoc { get; set; }
        [MaxLength(50)]
        [Required]
        public string PhuongPhapTuoi { get; set; }
        [Required]
        public float MatDo { get; set; }
        public int? TenantId { get; set; }
    }
}
