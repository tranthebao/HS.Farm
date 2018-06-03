using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChiTietHoatDongCanhTacVeSinhVuonAppService : CrudAppService<ChiTietHoatDongCanhTacVeSinhVuon, ChiTietHoatDongCanhtacVeSinhVuonDto>, IChiTietHoatDongCanhtacVeSinhVuonAppService
    {
        private readonly IRepository<ChiTietHoatDongCanhTacVeSinhVuon> _repository;
        public ChiTietHoatDongCanhTacVeSinhVuonAppService(IRepository<ChiTietHoatDongCanhTacVeSinhVuon> repository)
             : base(repository)
        {
            _repository = repository;
        }
    }
}
