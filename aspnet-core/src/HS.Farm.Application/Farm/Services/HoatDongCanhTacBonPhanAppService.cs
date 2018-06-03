using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class HoatDongCanhTacBonPhanAppService : CrudAppService<HoatDongCanhTacBonPhan, HoatDongCanhtacBonPhanDto>, IHoatDongCanhtacBonPhanAppService
    {
        private readonly IRepository<HoatDongCanhTacBonPhan> _repository;
        public HoatDongCanhTacBonPhanAppService(IRepository<HoatDongCanhTacBonPhan> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
