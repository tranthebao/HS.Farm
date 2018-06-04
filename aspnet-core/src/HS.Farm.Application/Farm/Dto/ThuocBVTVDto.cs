using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ThuocBVTV))]
    public class ThuocBVTVDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public string TenThuoc { get; set; }
        [MaxLength(50)]
        [Required]
        public string TenSauBenh { get; set; }
        [MaxLength(50)]
        [Required]
        public string ThietBiPhun { get; set; }
        [Required]
        public float LieuLuongPhun { get; set; }
        [Required]
        public float ThoiGianCachLiThuHoac { get; set; }
        [Required]
        public float DonGiaThuoc { get; set; }
        [Required]
        public float ThanhTien { get; set; }
        public int? TenantId { get; set; }
    }
}
