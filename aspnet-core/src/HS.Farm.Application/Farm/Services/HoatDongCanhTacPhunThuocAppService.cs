using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class HoatDongCanhTacPhunThuocAppService : CrudAppService<HoatDongCanhTacPhunThuoc, HoatDongCanhtacPhunThuocDto>, IHoatDongCanhtacPhunThuocAppService
    {
        private readonly IRepository<HoatDongCanhTacPhunThuoc> _repository;
        public HoatDongCanhTacPhunThuocAppService(IRepository<HoatDongCanhTacPhunThuoc> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
