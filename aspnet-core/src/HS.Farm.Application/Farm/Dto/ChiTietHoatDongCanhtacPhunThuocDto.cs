using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietHoatDongCanhTacPhunThuoc))]
    public class ChiTietHoatDongCanhtacPhunThuocDto : EntityDto
    {
        [Required]
        public float ChiPhiSuDungThuocBVTV { get; set; }
        [Required]
        public float ChiPhiThueNhanCongPhun { get; set; }
        [Required]
        public float TongChiPhiPhunThuoc { get; set; }
    }
}
