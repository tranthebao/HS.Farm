using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ThuHoachAppService : CrudAppService<ThuHoach, ThuHoachDto>, IThuHoachAppService
    {
        private readonly IRepository<ThuHoach> _repository;
        public ThuHoachAppService(IRepository<ThuHoach> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
