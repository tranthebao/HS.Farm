using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChiTietHoatDongCanhTacTuoiNuocAppService : CrudAppService<ChiTietHoatDongCanhTacTuoiNuoc, ChiTietHoatDongCanhtacTuoiNuocDto>, IChiTietHoatDongCanhtacTuoiNuocAppService
    {
        private readonly IRepository<ChiTietHoatDongCanhTacTuoiNuoc> _repository;
        public ChiTietHoatDongCanhTacTuoiNuocAppService(IRepository<ChiTietHoatDongCanhTacTuoiNuoc> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
