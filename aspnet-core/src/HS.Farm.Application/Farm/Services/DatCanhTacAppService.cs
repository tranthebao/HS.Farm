using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class DatCanhTacAppService : CrudAppService<DatCanhTac, DatCanhTacDto>, IDatCanhtacAppService
    {
        private readonly IRepository<DatCanhTac> _repository;
        public DatCanhTacAppService(IRepository<DatCanhTac> repository)
             : base(repository)
        {
            _repository = repository;
        }
    }
}
