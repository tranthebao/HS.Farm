using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietChuHoDatCanhTac))]
    public class ChiTietChuHoDatCanhTacDto:EntityDto
    {
        [Required]
        public float TongDienTich { get; set; }
        [Required]
        public float TongDienTichCayTrongKhac { get; set; }
        [Required]
        public int TongSoVuon { get; set; }
    }
}
