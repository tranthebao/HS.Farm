using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChuHo))]
    public class ChuHoDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public string TenChuHo { get; set; }
        [MaxLength(50)]
        [Required]
        public string DiaChi { get; set; }
        [MaxLength(50)]
        [Required]
        public string GioiTinh { get; set; }
        [Required]
        public string SoDienThoai { get; set; }
        public int? TenantId { get; set; }
    }
}
