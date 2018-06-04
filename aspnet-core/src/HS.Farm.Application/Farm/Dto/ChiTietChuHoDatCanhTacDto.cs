using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietChuHoDatCanhTac))]
    public class ChiTietChuHoDatCanhTacDto: FullAuditedEntityDto, IMayHaveTenant
    {
        [Required]
        public float TongDienTich { get; set; }
        [Required]
        public float TongDienTichCayTrongKhac { get; set; }
        [Required]
        public int TongSoVuon { get; set; }
        public int? TenantId { get; set; }
    }
}
