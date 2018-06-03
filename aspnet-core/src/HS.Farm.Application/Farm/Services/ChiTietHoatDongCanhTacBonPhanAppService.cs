using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChiTietHoatDongCanhTacBonPhanAppService : CrudAppService<ChiTietHoatDongCanhTacBonPhan, ChiTietHoatDongCanhtacBonPhanDto>, IChiTietHoatDongCanhtacBonPhanAppService
    {
        private readonly IRepository<ChiTietHoatDongCanhTacBonPhan> _repository;
        public ChiTietHoatDongCanhTacBonPhanAppService(IRepository<ChiTietHoatDongCanhTacBonPhan> repository)
             : base(repository)
        {
            _repository = repository;
        }
    }
}
