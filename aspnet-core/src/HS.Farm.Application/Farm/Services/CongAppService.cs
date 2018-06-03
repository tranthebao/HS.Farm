using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class CongAppService : CrudAppService<Cong, CongDto>, ICongAppService
    {
        private readonly IRepository<Cong> _repository;
        public CongAppService(IRepository<Cong> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
