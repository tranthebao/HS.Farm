﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(HoatDongCanhTacTuoiNuoc))]
    public class HoatDongCanhtacTuoiNuocDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [Required]
        public int DotTuoi { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        public DateTime NgayTuoi { get; set; }
        [Required]
        public float SoGioTuoi { get; set; }
        [Required]
        public float LuongNuocTieuHao { get; set; }
        public int? TenantId { get; set; }
    }
}
