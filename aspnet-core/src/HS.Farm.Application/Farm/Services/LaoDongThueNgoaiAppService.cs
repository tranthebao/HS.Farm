using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class LaoDongThueNgoaiAppService : CrudAppService<LaoDongThueNgoai, LaoDongThueNgoaiDto>, ILaoDongThueNgoaiAppService
    {
        private readonly IRepository<LaoDongThueNgoai> _repository;
        public LaoDongThueNgoaiAppService(IRepository<LaoDongThueNgoai> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
