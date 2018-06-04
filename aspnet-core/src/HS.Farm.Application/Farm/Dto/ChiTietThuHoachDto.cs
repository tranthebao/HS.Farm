using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietThuHoach))]
    public class ChiTietThuHoachDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [Required]
        public float KhoiLuongSanPham { get; set; }
        [Required]
        public float ChiPhiThueNhanCongThuHoach { get; set; }
        public int? TenantId { get; set; }
    }
}
