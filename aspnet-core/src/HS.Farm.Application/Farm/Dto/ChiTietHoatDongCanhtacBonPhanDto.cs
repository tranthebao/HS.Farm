using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietHoatDongCanhTacBonPhan))]
    public class ChiTietHoatDongCanhtacBonPhanDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [Required]
        public float ThanhTienPhanTieuThu { get; set; }
        [Required]
        public float ThanhTienCongBonPhan { get; set; }
        [Required]
        public float TongChiPhiBonPhan { get; set; }
        public int? TenantId { get; set; }
    }
}
