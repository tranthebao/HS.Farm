using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class HoatDongCanhTacVeSinhVuonAppService : CrudAppService<HoatDongCanhTacVeSinhVuon, HoatDongCanhtacVeSinhVuonDto>, IHoatDongCanhtacVeSinhVuonAppService
    {
        private readonly IRepository<HoatDongCanhTacVeSinhVuon> _repository;
        public HoatDongCanhTacVeSinhVuonAppService(IRepository<HoatDongCanhTacVeSinhVuon> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
