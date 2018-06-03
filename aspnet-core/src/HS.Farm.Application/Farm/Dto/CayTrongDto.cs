using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HS.Farm.Core;

namespace HS.Farm.Application.Dto
{
    [AutoMapFrom(typeof(CayTrong))]
    public class CayTrongDto: FullAuditedEntityDto
    {
        public string TenCay { get; set; }
        public string LoaiCay { get; set; }
        public float MatDo { get; set; }
    }
}
