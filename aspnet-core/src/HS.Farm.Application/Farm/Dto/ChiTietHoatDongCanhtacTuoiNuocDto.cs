using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietHoatDongCanhTacTuoiNuoc))]
    public class ChiTietHoatDongCanhtacTuoiNuocDto : EntityDto
    {
        [Required]
        public float ThanhTienCongTuoi { get; set; }
        [Required]
        public float ThanhTienNhienLieuTieuHao { get; set; }
        [Required]
        public float TongChiPhiTuoiNuoc { get; set; }
    }
}
