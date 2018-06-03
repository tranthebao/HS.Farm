using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class PhuongPhapCanhTacAppService : CrudAppService<PhuongPhapCanhTac, PhuongPhapCanhTacDto>, IPhuongPhapCanhTacAppService
    {
        private readonly IRepository<PhuongPhapCanhTac> _repository;
        public PhuongPhapCanhTacAppService(IRepository<PhuongPhapCanhTac> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
