using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietHoatDongCanhTacVeSinhVuon))]
    public class ChiTietHoatDongCanhtacVeSinhVuonDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [Required]
        public float TongChiPhiThueNhanCong { get; set; }
        [Required]
        public float TongChiPhiDungNhienLieu { get; set; }
        [Required]
        public float TongChiPhiLamVuon { get; set; }
        public int? TenantId { get; set; }
    }
}
