﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(BanSanPham))]
    public class BanSanPhamDto: FullAuditedEntityDto, IMayHaveTenant
    {
        public DateTime NgayBan { get; set; }
        [MaxLength(50)]
        [Required]
        public string NoiBan { get; set; }
        [Required]
        public float SoLuongBan { get; set; }
        [Required]
        public float GiaBan { get; set; }
        [Required]
        public float CongThuong { get; set; }
        [Required]
        public float ThanhTien { get; set; }
        public int? TenantId { get; set; }
    }
}
