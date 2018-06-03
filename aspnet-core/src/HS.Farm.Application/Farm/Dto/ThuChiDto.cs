using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ThuChi))]
    public class ThuChiDto : EntityDto
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
    }
}
