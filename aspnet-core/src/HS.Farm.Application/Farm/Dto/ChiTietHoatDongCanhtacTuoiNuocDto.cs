using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietHoatDongCanhTacTuoiNuoc))]
    public class ChiTietHoatDongCanhtacTuoiNuocDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [Required]
        public float ThanhTienCongTuoi { get; set; }
        [Required]
        public float ThanhTienNhienLieuTieuHao { get; set; }
        [Required]
        public float TongChiPhiTuoiNuoc { get; set; }
        public int? TenantId { get; set; }
    }
}
