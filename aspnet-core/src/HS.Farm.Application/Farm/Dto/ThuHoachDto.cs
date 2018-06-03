using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ThuHoach))]
    public class ThuHoachDto : EntityDto
    {
        [MaxLength(50)]
        [Required]
        public string TenSanPham { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        [Required]
        public DateTime NgayThuHoach { get; set; }
    }
}
