using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChiTietHoatDongCanhTacPhunThuocAppService : CrudAppService<ChiTietHoatDongCanhTacPhunThuoc, ChiTietHoatDongCanhtacPhunThuocDto>, IChiTietHoatDongCanhtacPhunThuocAppService
    {
        private readonly IRepository<ChiTietHoatDongCanhTacPhunThuoc> _repository;
        public ChiTietHoatDongCanhTacPhunThuocAppService(IRepository<ChiTietHoatDongCanhTacPhunThuoc> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
