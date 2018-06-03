using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChatLuongSanPham))]
    public class ChatLuongSanPhamDto:EntityDto
    {
        [Required]
        public float DoDzem { get; set; }
        [Required]
        public float TapChat { get; set; }
        [Required]
        public float DoAm { get; set; }
    }
}
