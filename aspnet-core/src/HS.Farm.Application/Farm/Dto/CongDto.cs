using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(Cong))]
    public class CongDto : EntityDto
    {
        [MaxLength(50)]
        [Required]
        public string LoaiCongViec { get; set; }
        [Required]
        public float SoCongTuoiNuoc { get; set; }
        [Required]
        public float SoCongPhunThuoc { get; set; }
        [Required]
        public float SoCongBonPhan { get; set; }
        public float SoNgay { get; set; }
        public float DonGia { get; set; }
    }
}
