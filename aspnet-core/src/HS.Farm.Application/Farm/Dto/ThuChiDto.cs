using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ThuChi))]
    public class ThuChiDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public string LoaiThuChi { get; set; }
        [MaxLength(50)]
        [Required]
        public string HangMuc { get; set; }
        [MaxLength(50)]
        [Required]
        public string TenHoatDongCanhTac { get; set; }
        [Required]
        public float ThanhTien { get; set; }
        public int? TenantId { get; set; }
    }
}
