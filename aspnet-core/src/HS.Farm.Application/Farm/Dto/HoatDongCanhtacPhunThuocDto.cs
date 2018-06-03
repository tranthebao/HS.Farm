using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(HoatDongCanhTacPhunThuoc))]
    public class HoatDongCanhtacPhunThuocDto : EntityDto
    {
        [Required]
        public int DotPhun { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        public DateTime NgayPhun { get; set; }
    }
}
