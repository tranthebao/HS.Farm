using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(DatCanhTac))]
    public class DatCanhTacDto : EntityDto
    {
        [MaxLength(50)]
        [Required]
        public string TenVuon { get; set; }
        [MaxLength(50)]
        [Required]
        public string LoaiVuon { get; set; }
        [Required]
        public float DienTich { get; set; }
    }
}
