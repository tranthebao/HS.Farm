using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(HoatDongCanhTacVeSinhVuon))]
    public class HoatDongCanhtacVeSinhVuonDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength(250)]
        [Required]
        public string NoiDungCongViec { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        public DateTime NgayLam { get; set; }
        public int? TenantId { get; set; }
    }
}
