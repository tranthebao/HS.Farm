﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(PhanBon))]
    public class PhanBonDto : FullAuditedEntityDto, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public string TenPhan { get; set; }
        [MaxLength(50)]
        [Required]
        public string LoaiPhan { get; set; }
        [Required]
        public float LuongBon { get; set; }
        [Required]
        public float DonGia { get; set; }
        [Required]
        public float ThanhTien { get; set; }
        public int? TenantId { get; set; }
    }
}
