using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietThuChi))]
    public class ChiTietThuChiDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength]
        [Required]
        public string HangMuc { get; set; }
        [MaxLength(50)]
        [Required]
        public string TenHoatDongCanhTac { get; set; }
        [Required]
        public float TongSoTien { get; set; }
        public int? TenantId { get; set; }
    }
}
