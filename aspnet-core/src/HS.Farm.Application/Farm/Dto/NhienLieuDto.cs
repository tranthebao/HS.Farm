using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(HoatDongCanhTacVeSinhVuon))]
    public class NhienLieuDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public string TenNhienLieu { get; set; }
        [MaxLength(50)]
        [Required]
        public string LoaiNhienLieu { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public int? TenantId { get; set; }
    }
}
