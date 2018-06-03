using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChuHoAppService : CrudAppService<ChuHo, ChuHoDto>, IChuHoAppService
    {
        private readonly IRepository<ChuHo> _repository;
        public ChuHoAppService(IRepository<ChuHo> repository)
             : base(repository)
        {
            _repository = repository;
        }
    }
}
