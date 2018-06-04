using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(HoatDongCanhTacBonPhan))]
    public class HoatDongCanhtacBonPhanDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [Required]
        public int DotBon { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        public DateTime NgayBon { get; set; }
        public int? TenantId { get; set; }
    }
}
