using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class HoatDongCanhTacTuoiNuocAppService : CrudAppService<HoatDongCanhTacTuoiNuoc, HoatDongCanhtacTuoiNuocDto>, IHoatDongCanhtacTuoiNuocAppService
    {
        private readonly IRepository<HoatDongCanhTacTuoiNuoc> _repository;
        public HoatDongCanhTacTuoiNuocAppService(IRepository<HoatDongCanhTacTuoiNuoc> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
