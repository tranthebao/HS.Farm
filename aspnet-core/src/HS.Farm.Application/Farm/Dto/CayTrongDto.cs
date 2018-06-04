using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using HS.Farm.Authorization.Users;
using HS.Farm.Core;

namespace HS.Farm.Application.Dto
{
    [AutoMapFrom(typeof(CayTrong))]
    public class CayTrongDto: FullAuditedEntityDto<int>
    {
        public string TenCay { get; set; }
        public string LoaiCay { get; set; }
        public float MatDo { get; set; }
        public int? TenantId { get; set; }
    }
}
