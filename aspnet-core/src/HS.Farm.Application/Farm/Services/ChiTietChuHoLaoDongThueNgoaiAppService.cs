using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChiTietChuHoLaoDongThueNgoaiAppService : CrudAppService<ChiTietChuHoLaoDongThueNgoai, ChiTietChuHoLaoDongThueNgoaiDto>, IChiTietChuHoLaoDongThueNgoaiAppService
    {
        private readonly IRepository<ChiTietChuHoLaoDongThueNgoai> _repository;
        public ChiTietChuHoLaoDongThueNgoaiAppService(IRepository<ChiTietChuHoLaoDongThueNgoai> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
