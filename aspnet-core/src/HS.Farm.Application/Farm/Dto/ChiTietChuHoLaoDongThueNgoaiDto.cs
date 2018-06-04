using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace HS.Farm.Application.Dto
{
    [AutoMap(typeof(ChiTietChuHoLaoDongThueNgoai))]
    public class ChiTietChuHoLaoDongThueNgoaiDto: FullAuditedEntityDto, IMayHaveTenant
    {
        public int? TenantId { get; set; }
    }
}
