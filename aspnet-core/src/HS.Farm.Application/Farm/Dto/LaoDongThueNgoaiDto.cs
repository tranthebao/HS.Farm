using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(LaoDongThueNgoai))]
    public class LaoDongThueNgoaiDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public string HoTenNhanCong { get; set; }
        [MaxLength(50)]
        [Required]
        public string CMND { get; set; }
        [MaxLength(50)]
        [Required]
        public string DiaChi { get; set; }
        [MaxLength(50)]
        [Required]
        public string GioiTinh { get; set; }
        [Required]
        public DateTime NgaySinh { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        [Required]
        public DateTime NgayBatDau { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        [Required]
        public DateTime NgayNgayKetThuc { get; set; }
        public int? TenantId { get; set; }
    }
}
