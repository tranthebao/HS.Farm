using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietThuHoach))]
    public class ChiTietThuHoachDto : EntityDto
    {
        [Required]
        public float KhoiLuongSanPham { get; set; }
        [Required]
        public float ChiPhiThueNhanCongThuHoach { get; set; }
    }
}
