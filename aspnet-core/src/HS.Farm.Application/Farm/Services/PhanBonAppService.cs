using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class PhanBonAppService : CrudAppService<PhanBon, PhanBonDto>, IPhanBonAppService
    {
        private readonly IRepository<PhanBon> _repository;
        public PhanBonAppService(IRepository<PhanBon> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
