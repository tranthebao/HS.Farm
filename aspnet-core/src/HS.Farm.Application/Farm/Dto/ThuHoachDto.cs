using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ThuHoach))]
    public class ThuHoachDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public string TenSanPham { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        [Required]
        public DateTime NgayThuHoach { get; set; }
        public int? TenantId { get; set; }
    }
}
