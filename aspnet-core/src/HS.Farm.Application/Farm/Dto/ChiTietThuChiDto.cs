using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietThuChi))]
    public class ChiTietThuChiDto : EntityDto
    {
        [MaxLength]
        [Required]
        public string HangMuc { get; set; }
        [MaxLength(50)]
        [Required]
        public string TenHoatDongCanhTac { get; set; }
        [Required]
        public float TongSoTien { get; set; }
    }
}
